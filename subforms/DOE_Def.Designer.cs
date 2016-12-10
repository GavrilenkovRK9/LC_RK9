namespace LC_RK9.subforms
{
    partial class DOE_Def
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
            this.chckbxUserDefinedN = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butFindN = new System.Windows.Forms.Button();
            this.fldRequiredN_prime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chckbxUserDefinedN
            // 
            this.chckbxUserDefinedN.AutoSize = true;
            this.chckbxUserDefinedN.Location = new System.Drawing.Point(19, 36);
            this.chckbxUserDefinedN.Name = "chckbxUserDefinedN";
            this.chckbxUserDefinedN.Size = new System.Drawing.Size(271, 17);
            this.chckbxUserDefinedN.TabIndex = 5;
            this.chckbxUserDefinedN.Text = "Использовать автоматически определенное N?";
            this.chckbxUserDefinedN.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 205);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "или введите свое значение:";
            // 
            // butFindN
            // 
            this.butFindN.Location = new System.Drawing.Point(291, 121);
            this.butFindN.Name = "butFindN";
            this.butFindN.Size = new System.Drawing.Size(160, 34);
            this.butFindN.TabIndex = 2;
            this.butFindN.Text = "Определить N";
            this.butFindN.UseVisualStyleBackColor = true;
            this.butFindN.Click += new System.EventHandler(this.butFindN_Click);
            // 
            // fldRequiredN_prime
            // 
            this.fldRequiredN_prime.Location = new System.Drawing.Point(19, 125);
            this.fldRequiredN_prime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fldRequiredN_prime.Name = "fldRequiredN_prime";
            this.fldRequiredN_prime.Size = new System.Drawing.Size(248, 20);
            this.fldRequiredN_prime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Требуемое число точек в ЛПтау последовательности";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckbxUserDefinedN);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butFindN);
            this.groupBox1.Controls.Add(this.fldRequiredN_prime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 299);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Определение числа точек ЛПтау последовательности";
            // 
            // DOE_Def
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 321);
            this.Controls.Add(this.groupBox1);
            this.Name = "DOE_Def";
            this.Text = "DOE_Def";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chckbxUserDefinedN;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butFindN;
        private System.Windows.Forms.TextBox fldRequiredN_prime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}