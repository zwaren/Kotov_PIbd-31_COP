namespace StoreViews
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.bCategory = new System.Windows.Forms.Button();
            this.controlTreeView = new ControlLibrary.ControlTreeView();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.bBackUp = new System.Windows.Forms.Button();
            this.createBackUpComponent1 = new WindowsFormsControlLibraryComponentSansiel.CreateBackUpComponent(this.components);
            this.bWordDiagram = new System.Windows.Forms.Button();
            this.bWordReport = new System.Windows.Forms.Button();
            this.wordReport1 = new Konponens.WordReport(this.components);
            this.SuspendLayout();
            // 
            // bCategory
            // 
            this.bCategory.Location = new System.Drawing.Point(12, 12);
            this.bCategory.Name = "bCategory";
            this.bCategory.Size = new System.Drawing.Size(87, 23);
            this.bCategory.TabIndex = 0;
            this.bCategory.Text = "Категории";
            this.bCategory.UseVisualStyleBackColor = true;
            this.bCategory.Click += new System.EventHandler(this.bCategory_Click);
            // 
            // controlTreeView
            // 
            this.controlTreeView.Location = new System.Drawing.Point(275, 12);
            this.controlTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlTreeView.Name = "controlTreeView";
            this.controlTreeView.Size = new System.Drawing.Size(221, 342);
            this.controlTreeView.TabIndex = 1;
            // 
            // buttonProduct
            // 
            this.buttonProduct.Location = new System.Drawing.Point(9, 45);
            this.buttonProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(90, 21);
            this.buttonProduct.TabIndex = 2;
            this.buttonProduct.Text = "Продукты";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // bBackUp
            // 
            this.bBackUp.Location = new System.Drawing.Point(13, 331);
            this.bBackUp.Name = "bBackUp";
            this.bBackUp.Size = new System.Drawing.Size(75, 23);
            this.bBackUp.TabIndex = 3;
            this.bBackUp.Text = "Back Up";
            this.bBackUp.UseVisualStyleBackColor = true;
            this.bBackUp.Click += new System.EventHandler(this.BBackUp_Click);
            // 
            // bWordDiagram
            // 
            this.bWordDiagram.Location = new System.Drawing.Point(12, 302);
            this.bWordDiagram.Name = "bWordDiagram";
            this.bWordDiagram.Size = new System.Drawing.Size(102, 23);
            this.bWordDiagram.TabIndex = 4;
            this.bWordDiagram.Text = "Word Diagram";
            this.bWordDiagram.UseVisualStyleBackColor = true;
            // 
            // bWordReport
            // 
            this.bWordReport.Location = new System.Drawing.Point(13, 273);
            this.bWordReport.Name = "bWordReport";
            this.bWordReport.Size = new System.Drawing.Size(87, 23);
            this.bWordReport.TabIndex = 5;
            this.bWordReport.Text = "Word Report";
            this.bWordReport.UseVisualStyleBackColor = true;
            this.bWordReport.Click += new System.EventHandler(this.BWordReport_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 366);
            this.Controls.Add(this.bWordReport);
            this.Controls.Add(this.bWordDiagram);
            this.Controls.Add(this.bBackUp);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.controlTreeView);
            this.Controls.Add(this.bCategory);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button bCategory;
		private ControlLibrary.ControlTreeView controlTreeView;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button bBackUp;
        private WindowsFormsControlLibraryComponentSansiel.CreateBackUpComponent createBackUpComponent1;
        private System.Windows.Forms.Button bWordDiagram;
        private System.Windows.Forms.Button bWordReport;
        private Konponens.WordReport wordReport1;
    }
}