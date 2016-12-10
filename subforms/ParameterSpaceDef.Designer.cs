﻿namespace LC_RK9.subforms
{
    partial class ParameterSpaceDef
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
            this.butSelectFEA = new System.Windows.Forms.Button();
            this.tblParameters = new System.Windows.Forms.DataGridView();
            this.ParName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParInitValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParLo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParHi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDecisionVariable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butDeleteVariable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // butSelectFEA
            // 
            this.butSelectFEA.Location = new System.Drawing.Point(12, 12);
            this.butSelectFEA.Name = "butSelectFEA";
            this.butSelectFEA.Size = new System.Drawing.Size(162, 23);
            this.butSelectFEA.TabIndex = 0;
            this.butSelectFEA.Text = "Выбрать файл расчета";
            this.butSelectFEA.UseVisualStyleBackColor = true;
            this.butSelectFEA.Click += new System.EventHandler(this.butSelectFEA_Click);
            // 
            // tblParameters
            // 
            this.tblParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParName,
            this.ParInitValue,
            this.ParLo,
            this.ParHi,
            this.IsDecisionVariable});
            this.tblParameters.Location = new System.Drawing.Point(12, 41);
            this.tblParameters.Name = "tblParameters";
            this.tblParameters.Size = new System.Drawing.Size(544, 168);
            this.tblParameters.TabIndex = 1;
            this.tblParameters.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblParameters_CellContentDoubleClick);
            this.tblParameters.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblParameters_CellValidated);
            // 
            // ParName
            // 
            this.ParName.HeaderText = "Имя параметра";
            this.ParName.Name = "ParName";
            this.ParName.ReadOnly = true;
            // 
            // ParInitValue
            // 
            this.ParInitValue.HeaderText = "Номинальное значение";
            this.ParInitValue.Name = "ParInitValue";
            this.ParInitValue.ReadOnly = true;
            // 
            // ParLo
            // 
            this.ParLo.HeaderText = "Нижняя граница";
            this.ParLo.Name = "ParLo";
            // 
            // ParHi
            // 
            this.ParHi.HeaderText = "Верхняя граница";
            this.ParHi.Name = "ParHi";
            // 
            // IsDecisionVariable
            // 
            this.IsDecisionVariable.HeaderText = "Это управляющий параметр?";
            this.IsDecisionVariable.Name = "IsDecisionVariable";
            this.IsDecisionVariable.ReadOnly = true;
            // 
            // butDeleteVariable
            // 
            this.butDeleteVariable.Location = new System.Drawing.Point(225, 12);
            this.butDeleteVariable.Name = "butDeleteVariable";
            this.butDeleteVariable.Size = new System.Drawing.Size(328, 23);
            this.butDeleteVariable.TabIndex = 0;
            this.butDeleteVariable.Text = "Убрать выбранную переменную";
            this.butDeleteVariable.UseVisualStyleBackColor = true;
            this.butDeleteVariable.Click += new System.EventHandler(this.butDeleteVariable_Click);
            // 
            // ParameterSpaceDef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 222);
            this.Controls.Add(this.butDeleteVariable);
            this.Controls.Add(this.tblParameters);
            this.Controls.Add(this.butSelectFEA);
            this.Name = "ParameterSpaceDef";
            this.Text = "Определение пространства параметров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParameterSpaceDef_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tblParameters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butSelectFEA;
        private System.Windows.Forms.DataGridView tblParameters;
        private System.Windows.Forms.Button butDeleteVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParInitValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParLo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParHi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDecisionVariable;
    }
}