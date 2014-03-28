namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnDiv = new System.Windows.Forms.RadioButton();
            this.rbtnMul = new System.Windows.Forms.RadioButton();
            this.rbtnMinus = new System.Windows.Forms.RadioButton();
            this.rbtnPlus = new System.Windows.Forms.RadioButton();
            this.numericB = new System.Windows.Forms.NumericUpDown();
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(254, 48);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.ReadOnly = true;
            this.textBoxRes.Size = new System.Drawing.Size(84, 20);
            this.textBoxRes.TabIndex = 4;
            this.textBoxRes.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnDiv);
            this.panel1.Controls.Add(this.rbtnMul);
            this.panel1.Controls.Add(this.rbtnMinus);
            this.panel1.Controls.Add(this.rbtnPlus);
            this.panel1.Location = new System.Drawing.Point(100, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 93);
            this.panel1.TabIndex = 5;
            // 
            // rbtnDiv
            // 
            this.rbtnDiv.AutoSize = true;
            this.rbtnDiv.Location = new System.Drawing.Point(3, 73);
            this.rbtnDiv.Name = "rbtnDiv";
            this.rbtnDiv.Size = new System.Drawing.Size(30, 17);
            this.rbtnDiv.TabIndex = 3;
            this.rbtnDiv.TabStop = true;
            this.rbtnDiv.Text = "/";
            this.rbtnDiv.UseVisualStyleBackColor = true;
            this.rbtnDiv.CheckedChanged += new System.EventHandler(this.any_Changed);
            // 
            // rbtnMul
            // 
            this.rbtnMul.AutoSize = true;
            this.rbtnMul.Location = new System.Drawing.Point(3, 50);
            this.rbtnMul.Name = "rbtnMul";
            this.rbtnMul.Size = new System.Drawing.Size(29, 17);
            this.rbtnMul.TabIndex = 2;
            this.rbtnMul.TabStop = true;
            this.rbtnMul.Text = "*";
            this.rbtnMul.UseVisualStyleBackColor = true;
            this.rbtnMul.CheckedChanged += new System.EventHandler(this.any_Changed);
            // 
            // rbtnMinus
            // 
            this.rbtnMinus.AutoSize = true;
            this.rbtnMinus.Location = new System.Drawing.Point(3, 26);
            this.rbtnMinus.Name = "rbtnMinus";
            this.rbtnMinus.Size = new System.Drawing.Size(28, 17);
            this.rbtnMinus.TabIndex = 1;
            this.rbtnMinus.TabStop = true;
            this.rbtnMinus.Text = "-";
            this.rbtnMinus.UseVisualStyleBackColor = true;
            this.rbtnMinus.CheckedChanged += new System.EventHandler(this.any_Changed);
            // 
            // rbtnPlus
            // 
            this.rbtnPlus.AutoSize = true;
            this.rbtnPlus.Checked = true;
            this.rbtnPlus.Location = new System.Drawing.Point(3, 3);
            this.rbtnPlus.Name = "rbtnPlus";
            this.rbtnPlus.Size = new System.Drawing.Size(31, 17);
            this.rbtnPlus.TabIndex = 0;
            this.rbtnPlus.TabStop = true;
            this.rbtnPlus.Text = "+";
            this.rbtnPlus.UseVisualStyleBackColor = true;
            this.rbtnPlus.CheckedChanged += new System.EventHandler(this.any_Changed);
            // 
            // numericB
            // 
            this.numericB.Location = new System.Drawing.Point(148, 48);
            this.numericB.Name = "numericB";
            this.numericB.Size = new System.Drawing.Size(81, 20);
            this.numericB.TabIndex = 6;
            this.numericB.ValueChanged += new System.EventHandler(this.any_Changed);
            // 
            // numericA
            // 
            this.numericA.Location = new System.Drawing.Point(13, 48);
            this.numericA.Name = "numericA";
            this.numericA.Size = new System.Drawing.Size(81, 20);
            this.numericA.TabIndex = 7;
            this.numericA.ValueChanged += new System.EventHandler(this.any_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 121);
            this.Controls.Add(this.numericA);
            this.Controls.Add(this.numericB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Super Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnDiv;
        private System.Windows.Forms.RadioButton rbtnMul;
        private System.Windows.Forms.RadioButton rbtnMinus;
        private System.Windows.Forms.RadioButton rbtnPlus;
        private System.Windows.Forms.NumericUpDown numericB;
        private System.Windows.Forms.NumericUpDown numericA;
    }
}

