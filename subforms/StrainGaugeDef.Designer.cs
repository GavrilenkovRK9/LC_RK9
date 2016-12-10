namespace LC_RK9.subforms
{
    partial class StrainGaugeDef
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
            this.fldLength = new System.Windows.Forms.TextBox();
            this.fldWidth = new System.Windows.Forms.TextBox();
            this.fldGridLength = new System.Windows.Forms.TextBox();
            this.fldGridWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fldLength
            // 
            this.fldLength.Location = new System.Drawing.Point(13, 22);
            this.fldLength.Name = "fldLength";
            this.fldLength.Size = new System.Drawing.Size(100, 20);
            this.fldLength.TabIndex = 0;
            // 
            // fldWidth
            // 
            this.fldWidth.Location = new System.Drawing.Point(13, 61);
            this.fldWidth.Name = "fldWidth";
            this.fldWidth.Size = new System.Drawing.Size(100, 20);
            this.fldWidth.TabIndex = 1;
            // 
            // fldGridLength
            // 
            this.fldGridLength.Location = new System.Drawing.Point(12, 100);
            this.fldGridLength.Name = "fldGridLength";
            this.fldGridLength.Size = new System.Drawing.Size(100, 20);
            this.fldGridLength.TabIndex = 2;
            // 
            // fldGridWidth
            // 
            this.fldGridWidth.Location = new System.Drawing.Point(13, 139);
            this.fldGridWidth.Name = "fldGridWidth";
            this.fldGridWidth.Size = new System.Drawing.Size(100, 20);
            this.fldGridWidth.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Длина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ширина базы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Длина базы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ширина базы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Длина базы";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // StrainGaugeDef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fldGridWidth);
            this.Controls.Add(this.fldGridLength);
            this.Controls.Add(this.fldWidth);
            this.Controls.Add(this.fldLength);
            this.Name = "StrainGaugeDef";
            this.Text = "Тензорезистор";
            this.Load += new System.EventHandler(this.StrainGaugeDef_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fldLength;
        private System.Windows.Forms.TextBox fldWidth;
        private System.Windows.Forms.TextBox fldGridLength;
        private System.Windows.Forms.TextBox fldGridWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}