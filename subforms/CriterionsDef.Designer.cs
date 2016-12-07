namespace LC_RK9.subforms
{
    partial class CriterionsDef
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
            this.tblCriterionDefinition = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblCriterionDefinition)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCriterionDefinition
            // 
            this.tblCriterionDefinition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCriterionDefinition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.tblCriterionDefinition.Location = new System.Drawing.Point(45, 40);
            this.tblCriterionDefinition.Margin = new System.Windows.Forms.Padding(6);
            this.tblCriterionDefinition.Name = "tblCriterionDefinition";
            this.tblCriterionDefinition.Size = new System.Drawing.Size(554, 244);
            this.tblCriterionDefinition.TabIndex = 0;
            this.tblCriterionDefinition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCriterionDefinition_CellContentClick);
            this.tblCriterionDefinition.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCriterionDefinition_CellValidated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Два критерия обязательные: нелинейность и РКП, остальные по желанию";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя критерия";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Минимизировать критерий?";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Text = "Да";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Удалить критерий";
            this.Column3.Name = "Column3";
            this.Column3.Text = "Удалить";
            this.Column3.Width = 120;
            // 
            // CriterionsDef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblCriterionDefinition);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CriterionsDef";
            this.Text = "CriterionDef";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CriterionsDef_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tblCriterionDefinition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblCriterionDefinition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}