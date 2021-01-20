using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (b64Radio.Checked)
            {
                asciiBox.Text = ExportSpecialChar(Base64_decode(inputBox.Text));
                hexBox.Text = AsciiToHex(Base64_decode(inputBox.Text));
            }
            else if (urldRadio.Checked)
            {
                asciiBox.Text = Urldecode(inputBox.Text);
                hexBox.Text = AsciiToHex(Urldecode(inputBox.Text));
            }
            else if (hexRadioGB.Checked)
            {
                asciiBox.Text = UnHexGB(inputBox.Text);
                hexBox.Text = "";
            }
            else if (hexRadioU8.Checked)
            {
                asciiBox.Text = UnHexU8(inputBox.Text);
                hexBox.Text = "";
            }
            else if (uniRadio.Checked)
            {
                asciiBox.Text = DeUnicode(inputBox.Text);
                hexBox.Text = AsciiToHex(DeUnicode(inputBox.Text));
            }
            else if (revRadio.Checked)
            {
                asciiBox.Text = ReverseString(inputBox.Text);
                hexBox.Text = AsciiToHex(asciiBox.Text);
            }
            else
            {
                MessageBox.Show("未选择编码！", "提示");
            }

        }
        //base64
        private string Base64_decode(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("传入值为空", "提示");
            }
            try
            {
                byte[] bytes = Convert.FromBase64String(data);
                string result = Encoding.UTF8.GetString(bytes);
                return result;
            }
            catch
            {
                return "Base64 Decode Fail";
            }
        }
        //特殊字符
        private string ExportSpecialChar(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("传入值为空", "提示");
            }
            string result = Regex.Replace(data, @"[^(\x21-\x7E)]", "");
            return result;
        }
        //url解码
        private string Urldecode(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("传入值为空", "提示");
            }
            try
            {
                string result = System.Web.HttpUtility.UrlDecode(data);
                return result;
            }
            catch
            {
                return "Url Decode Fail";
            }
        }
        //ascii转hex
        private string AsciiToHex(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("传入值为空", "提示");
            }
            return BitConverter.ToString(ASCIIEncoding.Default.GetBytes(data)).Replace("-", " ");
        }
        //
        private string UnHexGB(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("传入值为空", "提示");
            }
            data = data.Replace(",", "");
            data = data.Replace("\n", "");
            data = data.Replace("\\", "");
            data = data.Replace(" ", "");
            if (data.Length % 2 != 0)
            {
                data += "20";//空格
                return "hex is not a valid number!";
            }
            byte[] bytes = new byte[data.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    bytes[i] = byte.Parse(data.Substring(i * 2, 2),
                    System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    return "hex is not a valid hex number!";
                }
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("GB2312");
            return chs.GetString(bytes);
        }
        //UTF-8解码
        private string UnHexU8(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("传入值为空", "提示");
            }
            data = data.Replace(",", "");
            data = data.Replace("\n", "");
            data = data.Replace("\\", "");
            data = data.Replace(" ", "");
            if (data.Length % 2 != 0)
            {
                data += "20";//空格
                return "hex is not a valid number!";
            }
            byte[] bytes = new byte[data.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    bytes[i] = byte.Parse(data.Substring(i * 2, 2),
                    System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    return "hex is not a valid hex number!";
                }
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("UTF-8");
            return chs.GetString(bytes);
        }
        //Unicode解码
        private string DeUnicode(string data)
        {
            StringBuilder strResult = new StringBuilder();
            if (!string.IsNullOrEmpty(data))
            {
                string[] strlist = data.Replace("\\", "").Split('u');
                try
                {
                    for (int i = 1; i < strlist.Length; i++)
                    {
                        int charCode = Convert.ToInt32(strlist[i], 16);
                        strResult.Append((char)charCode);
                    }
                }
                catch
                {
                    return Regex.Unescape(data);
                }
            }
            return strResult.ToString();
        }
        //反转
        private string ReverseString(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
        //菜单
        void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show((sender as ContextMenuStrip).SourceControl.Name);
        }
        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip1.SourceControl.Select();
            RichTextBox rtb = (RichTextBox)this.contextMenuStrip1.SourceControl;
            rtb.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip1.SourceControl.Select();
            RichTextBox rtb = (RichTextBox)this.contextMenuStrip1.SourceControl;
            rtb.Paste();
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip1.SourceControl.Select();
            RichTextBox rtb = (RichTextBox)this.contextMenuStrip1.SourceControl;
            rtb.SelectAll();
        }
    }
}
