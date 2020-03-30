namespace Cayley
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblLeftPer = new System.Windows.Forms.Label();
            this.lblRightPer = new System.Windows.Forms.Label();
            this.lblLeftTh = new System.Windows.Forms.Label();
            this.lblRightTh = new System.Windows.Forms.Label();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtRightPer = new System.Windows.Forms.TextBox();
            this.txtLeftPer = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtRightTh = new System.Windows.Forms.TextBox();
            this.txtLeftTh = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(3, 5);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(42, 17);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "颜色";
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "蓝色",
            "绿色",
            "红色",
            "黄色",
            "紫色"});
            this.cmbColor.Location = new System.Drawing.Point(113, 1);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(100, 25);
            this.cmbColor.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 490);
            this.panel1.TabIndex = 3;
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(554, 139);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(76, 17);
            this.lblDepth.TabIndex = 4;
            this.lblDepth.Text = "递归深度";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(554, 185);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(76, 17);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "主干长度";
            // 
            // lblLeftPer
            // 
            this.lblLeftPer.AutoSize = true;
            this.lblLeftPer.Location = new System.Drawing.Point(554, 234);
            this.lblLeftPer.Name = "lblLeftPer";
            this.lblLeftPer.Size = new System.Drawing.Size(110, 17);
            this.lblLeftPer.TabIndex = 6;
            this.lblLeftPer.Text = "左分支长度比";
            // 
            // lblRightPer
            // 
            this.lblRightPer.AutoSize = true;
            this.lblRightPer.Location = new System.Drawing.Point(554, 283);
            this.lblRightPer.Name = "lblRightPer";
            this.lblRightPer.Size = new System.Drawing.Size(110, 17);
            this.lblRightPer.TabIndex = 7;
            this.lblRightPer.Text = "右分支长度比";
            // 
            // lblLeftTh
            // 
            this.lblLeftTh.AutoSize = true;
            this.lblLeftTh.Location = new System.Drawing.Point(554, 329);
            this.lblLeftTh.Name = "lblLeftTh";
            this.lblLeftTh.Size = new System.Drawing.Size(93, 17);
            this.lblLeftTh.TabIndex = 8;
            this.lblLeftTh.Text = "左分支角度";
            // 
            // lblRightTh
            // 
            this.lblRightTh.AutoSize = true;
            this.lblRightTh.Location = new System.Drawing.Point(554, 378);
            this.lblRightTh.Name = "lblRightTh";
            this.lblRightTh.Size = new System.Drawing.Size(93, 17);
            this.lblRightTh.TabIndex = 9;
            this.lblRightTh.Text = "右分支角度";
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(670, 136);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(100, 27);
            this.txtDepth.TabIndex = 10;
            // 
            // txtRightPer
            // 
            this.txtRightPer.Location = new System.Drawing.Point(670, 280);
            this.txtRightPer.Name = "txtRightPer";
            this.txtRightPer.Size = new System.Drawing.Size(100, 27);
            this.txtRightPer.TabIndex = 11;
            // 
            // txtLeftPer
            // 
            this.txtLeftPer.Location = new System.Drawing.Point(670, 231);
            this.txtLeftPer.Name = "txtLeftPer";
            this.txtLeftPer.Size = new System.Drawing.Size(100, 27);
            this.txtLeftPer.TabIndex = 12;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(670, 182);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 27);
            this.txtLength.TabIndex = 13;
            // 
            // txtRightTh
            // 
            this.txtRightTh.Location = new System.Drawing.Point(670, 375);
            this.txtRightTh.Name = "txtRightTh";
            this.txtRightTh.Size = new System.Drawing.Size(100, 27);
            this.txtRightTh.TabIndex = 14;
            // 
            // txtLeftTh
            // 
            this.txtLeftTh.Location = new System.Drawing.Point(670, 326);
            this.txtLeftTh.Name = "txtLeftTh";
            this.txtLeftTh.Size = new System.Drawing.Size(100, 27);
            this.txtLeftTh.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblColor);
            this.panel2.Controls.Add(this.cmbColor);
            this.panel2.Location = new System.Drawing.Point(557, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 27);
            this.panel2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 549);
            this.Controls.Add(this.txtLeftTh);
            this.Controls.Add(this.txtRightTh);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtLeftPer);
            this.Controls.Add(this.txtRightPer);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.lblRightTh);
            this.Controls.Add(this.lblLeftTh);
            this.Controls.Add(this.lblRightPer);
            this.Controls.Add(this.lblLeftPer);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "CayleyTree";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblLeftPer;
        private System.Windows.Forms.Label lblRightPer;
        private System.Windows.Forms.Label lblLeftTh;
        private System.Windows.Forms.Label lblRightTh;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtRightPer;
        private System.Windows.Forms.TextBox txtLeftPer;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtRightTh;
        private System.Windows.Forms.TextBox txtLeftTh;
        private System.Windows.Forms.Panel panel2;
    }
}

