namespace LC_RK9.subforms
{
    partial class FuncConstrDOE_Def
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckbxUserDefinedN = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butFindN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Constraint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldDecisionVariableStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 125);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Требуемое число точек в ЛПтау последовательности";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckbxUserDefinedN);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butFindN);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(340, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 299);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Определение числа точек ЛПтау последовательности";
            // 
            // chckbxUserDefinedN
            // 
            this.chckbxUserDefinedN.AutoSize = true;
            this.chckbxUserDefinedN.Location = new System.Drawing.Point(19, 36);
            this.chckbxUserDefinedN.Name = "chckbxUserDefinedN";
            this.chckbxUserDefinedN.Size = new System.Drawing.Size(397, 24);
            this.chckbxUserDefinedN.TabIndex = 5;
            this.chckbxUserDefinedN.Text = "Использовать автоматически определенное N?";
            this.chckbxUserDefinedN.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 205);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 26);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Constraint});
            this.dataGridView1.Location = new System.Drawing.Point(13, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 211);
            this.dataGridView1.TabIndex = 3;
            // 
            // Constraint
            // 
            this.Constraint.HeaderText = "Фунциональное ограничение";
            this.Constraint.Name = "Constraint";
            this.Constraint.Width = 250;
            // 
            // fldDecisionVariableStatus
            // 
            this.fldDecisionVariableStatus.Location = new System.Drawing.Point(13, 33);
            this.fldDecisionVariableStatus.Multiline = true;
            this.fldDecisionVariableStatus.Name = "fldDecisionVariableStatus";
            this.fldDecisionVariableStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fldDecisionVariableStatus.Size = new System.Drawing.Size(312, 61);
            this.fldDecisionVariableStatus.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Используемые управляющие параметры";
            // 
            // FuncConstrDOE_Def
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fldDecisionVariableStatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FuncConstrDOE_Def";
            this.Text = "Функциональные ограничения. Планирование эксперимента";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butFindN;
        private System.Windows.Forms.CheckBox chckbxUserDefinedN;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox fldDecisionVariableStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Constraint;
    }
}