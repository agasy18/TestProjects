namespace Tnayin1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnMsgBox = new System.Windows.Forms.Button();
            this.txtBoxForLabel = new System.Windows.Forms.TextBox();
            this.lblForTxtBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMsgBox
            // 
            this.BtnMsgBox.Location = new System.Drawing.Point(22, 226);
            this.BtnMsgBox.Name = "BtnMsgBox";
            this.BtnMsgBox.Size = new System.Drawing.Size(75, 23);
            this.BtnMsgBox.TabIndex = 0;
            this.BtnMsgBox.Text = "MsgBox";
            this.BtnMsgBox.UseVisualStyleBackColor = true;
            this.BtnMsgBox.Click += new System.EventHandler(this.BtnMsgBox_Click);
            // 
            // txtBoxForLabel
            // 
            this.txtBoxForLabel.Location = new System.Drawing.Point(22, 177);
            this.txtBoxForLabel.Name = "txtBoxForLabel";
            this.txtBoxForLabel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxForLabel.TabIndex = 1;
            this.txtBoxForLabel.TextChanged += new System.EventHandler(this.txtBoxForLabel_TextChanged);
            // 
            // lblForTxtBox
            // 
            this.lblForTxtBox.AutoSize = true;
            this.lblForTxtBox.Location = new System.Drawing.Point(147, 181);
            this.lblForTxtBox.Name = "lblForTxtBox";
            this.lblForTxtBox.Size = new System.Drawing.Size(31, 13);
            this.lblForTxtBox.TabIndex = 2;
            this.lblForTxtBox.Text = "Hello";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblForTxtBox);
            this.Controls.Add(this.txtBoxForLabel);
            this.Controls.Add(this.BtnMsgBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMsgBox;
        private System.Windows.Forms.TextBox txtBoxForLabel;
        private System.Windows.Forms.Label lblForTxtBox;
    }
}

