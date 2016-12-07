namespace LC_RK9
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Пространство параметров");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ТР растяжения");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ТР сжатия");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Никелевый ТР");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Мост Уитстона", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Функциональные ограничения&планирование эксперимента");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Критерии");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Просмотр результатов");
            this.designProcessTree = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // designProcessTree
            // 
            this.designProcessTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.designProcessTree.Location = new System.Drawing.Point(12, 12);
            this.designProcessTree.Name = "designProcessTree";
            treeNode1.Name = "ndParameterSpaceDef";
            treeNode1.Text = "Пространство параметров";
            treeNode2.Name = "ndTensionGauge";
            treeNode2.Text = "ТР растяжения";
            treeNode3.Name = "ndCompressionGauge";
            treeNode3.Text = "ТР сжатия";
            treeNode4.Name = "ndNickelGauge";
            treeNode4.Text = "Никелевый ТР";
            treeNode5.Name = "ndWheatstoneBridgeDef";
            treeNode5.Text = "Мост Уитстона";
            treeNode6.Name = "ndFuncConstrDOE_Def";
            treeNode6.Text = "Функциональные ограничения&планирование эксперимента";
            treeNode7.Name = "ndCriterionsDef";
            treeNode7.Text = "Критерии";
            treeNode8.Name = "ndResultsViewer";
            treeNode8.Text = "Просмотр результатов";
            this.designProcessTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.designProcessTree.Size = new System.Drawing.Size(359, 173);
            this.designProcessTree.TabIndex = 0;
            this.designProcessTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.designProcessTree_NodeMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Провести эксперимент";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 240);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.designProcessTree);
            this.Name = "MainForm";
            this.Text = "Проектирование ТД";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView designProcessTree;
        private System.Windows.Forms.Button button1;
    }
}

