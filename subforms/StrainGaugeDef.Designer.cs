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
            this.SuspendLayout();
            // 
            // fldLength
            // 
            this.fldLength.Location = new System.Drawing.Point(13, 28);
            this.fldLength.Name = "fldLength";
            this.fldLength.Size = new System.Drawing.Size(100, 20);
            this.fldLength.TabIndex = 0;
            // 
            // fldWidth
            // 
            this.fldWidth.Location = new System.Drawing.Point(13, 73);
            this.fldWidth.Name = "fldWidth";
            this.fldWidth.Size = new System.Drawing.Size(100, 20);
            this.fldWidth.TabIndex = 1;
            // 
            // fldGridLength
            // 
            this.fldGridLength.Location = new System.Drawing.Point(13, 124);
            this.fldGridLength.Name = "fldGridLength";
            this.fldGridLength.Size = new System.Drawing.Size(100, 20);
            this.fldGridLength.TabIndex = 2;
            // 
            // fldGridWidth
            // 
            this.fldGridWidth.Location = new System.Drawing.Point(13, 180);
            this.fldGridWidth.Name = "fldGridWidth";
            this.fldGridWidth.Size = new System.Drawing.Size(100, 20);
            this.fldGridWidth.TabIndex = 3;
            // 
            // StrainGaugeDef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.Controls.Add(this.fldGridWidth);
            this.Controls.Add(this.fldGridLength);
            this.Controls.Add(this.fldWidth);
            this.Controls.Add(this.fldLength);
            this.Name = "StrainGaugeDef";
            this.Text = "Тензорезистор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fldLength;
        private System.Windows.Forms.TextBox fldWidth;
        private System.Windows.Forms.TextBox fldGridLength;
        private System.Windows.Forms.TextBox fldGridWidth;
    }
}