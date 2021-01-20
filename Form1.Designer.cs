
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.b64Radio = new System.Windows.Forms.RadioButton();
            this.urldRadio = new System.Windows.Forms.RadioButton();
            this.hexRadioGB = new System.Windows.Forms.RadioButton();
            this.uniRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexBox = new System.Windows.Forms.RichTextBox();
            this.asciiBox = new System.Windows.Forms.RichTextBox();
            this.hexRadioU8 = new System.Windows.Forms.RadioButton();
            this.revRadio = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b64Radio
            // 
            this.b64Radio.AutoSize = true;
            this.b64Radio.Location = new System.Drawing.Point(194, 12);
            this.b64Radio.Name = "b64Radio";
            this.b64Radio.Size = new System.Drawing.Size(59, 16);
            this.b64Radio.TabIndex = 2;
            this.b64Radio.TabStop = true;
            this.b64Radio.Text = "Base64";
            this.b64Radio.UseVisualStyleBackColor = true;
            // 
            // urldRadio
            // 
            this.urldRadio.AutoSize = true;
            this.urldRadio.Location = new System.Drawing.Point(259, 12);
            this.urldRadio.Name = "urldRadio";
            this.urldRadio.Size = new System.Drawing.Size(77, 16);
            this.urldRadio.TabIndex = 4;
            this.urldRadio.TabStop = true;
            this.urldRadio.Text = "Urldecode";
            this.urldRadio.UseVisualStyleBackColor = true;
            // 
            // hexRadioGB
            // 
            this.hexRadioGB.AutoSize = true;
            this.hexRadioGB.Location = new System.Drawing.Point(342, 12);
            this.hexRadioGB.Name = "hexRadioGB";
            this.hexRadioGB.Size = new System.Drawing.Size(83, 16);
            this.hexRadioGB.TabIndex = 5;
            this.hexRadioGB.TabStop = true;
            this.hexRadioGB.Text = "Hex-GB2312";
            this.hexRadioGB.UseVisualStyleBackColor = true;
            // 
            // uniRadio
            // 
            this.uniRadio.AutoSize = true;
            this.uniRadio.Location = new System.Drawing.Point(508, 12);
            this.uniRadio.Name = "uniRadio";
            this.uniRadio.Size = new System.Drawing.Size(65, 16);
            this.uniRadio.TabIndex = 6;
            this.uniRadio.TabStop = true;
            this.uniRadio.Text = "Unicode";
            this.uniRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "解码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(109, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(366, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "HexOutput";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(636, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "AsciiOutput";
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.SystemColors.Window;
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.ContextMenuStrip = this.contextMenuStrip1;
            this.inputBox.Location = new System.Drawing.Point(12, 67);
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.inputBox.Size = new System.Drawing.Size(266, 246);
            this.inputBox.TabIndex = 13;
            this.inputBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.全选ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // hexBox
            // 
            this.hexBox.BackColor = System.Drawing.SystemColors.Control;
            this.hexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hexBox.ContextMenuStrip = this.contextMenuStrip1;
            this.hexBox.Location = new System.Drawing.Point(284, 67);
            this.hexBox.Name = "hexBox";
            this.hexBox.ReadOnly = true;
            this.hexBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.hexBox.Size = new System.Drawing.Size(271, 246);
            this.hexBox.TabIndex = 14;
            this.hexBox.Text = "";
            // 
            // asciiBox
            // 
            this.asciiBox.ContextMenuStrip = this.contextMenuStrip1;
            this.asciiBox.DetectUrls = false;
            this.asciiBox.Location = new System.Drawing.Point(562, 67);
            this.asciiBox.Name = "asciiBox";
            this.asciiBox.ReadOnly = true;
            this.asciiBox.Size = new System.Drawing.Size(257, 243);
            this.asciiBox.TabIndex = 15;
            this.asciiBox.Text = "";
            // 
            // hexRadioU8
            // 
            this.hexRadioU8.AutoSize = true;
            this.hexRadioU8.Location = new System.Drawing.Point(431, 12);
            this.hexRadioU8.Name = "hexRadioU8";
            this.hexRadioU8.Size = new System.Drawing.Size(71, 16);
            this.hexRadioU8.TabIndex = 16;
            this.hexRadioU8.TabStop = true;
            this.hexRadioU8.Text = "Hex-UTF8";
            this.hexRadioU8.UseVisualStyleBackColor = true;
            // 
            // revRadio
            // 
            this.revRadio.AutoSize = true;
            this.revRadio.Location = new System.Drawing.Point(579, 12);
            this.revRadio.Name = "revRadio";
            this.revRadio.Size = new System.Drawing.Size(65, 16);
            this.revRadio.TabIndex = 17;
            this.revRadio.TabStop = true;
            this.revRadio.Text = "Reverse";
            this.revRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 362);
            this.Controls.Add(this.revRadio);
            this.Controls.Add(this.hexRadioU8);
            this.Controls.Add(this.asciiBox);
            this.Controls.Add(this.hexBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uniRadio);
            this.Controls.Add(this.hexRadioGB);
            this.Controls.Add(this.urldRadio);
            this.Controls.Add(this.b64Radio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "常用编码解码工具";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton b64Radio;
        private System.Windows.Forms.RadioButton urldRadio;
        private System.Windows.Forms.RadioButton hexRadioGB;
        private System.Windows.Forms.RadioButton uniRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.RichTextBox hexBox;
        private System.Windows.Forms.RichTextBox asciiBox;
        private System.Windows.Forms.RadioButton hexRadioU8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.RadioButton revRadio;
    }
}

