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
            this.bCategory = new System.Windows.Forms.Button();
            this.controlTreeView = new ControlLibrary.ControlTreeView();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCategory
            // 
            this.bCategory.Location = new System.Drawing.Point(16, 15);
            this.bCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCategory.Name = "bCategory";
            this.bCategory.Size = new System.Drawing.Size(116, 28);
            this.bCategory.TabIndex = 0;
            this.bCategory.Text = "Категории";
            this.bCategory.UseVisualStyleBackColor = true;
            this.bCategory.Click += new System.EventHandler(this.bCategory_Click);
            // 
            // controlTreeView
            // 
            this.controlTreeView.Location = new System.Drawing.Point(367, 15);
            this.controlTreeView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlTreeView.Name = "controlTreeView";
            this.controlTreeView.Size = new System.Drawing.Size(295, 421);
            this.controlTreeView.TabIndex = 1;
            // 
            // buttonProduct
            // 
            this.buttonProduct.Location = new System.Drawing.Point(12, 55);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(120, 26);
            this.buttonProduct.TabIndex = 2;
            this.buttonProduct.Text = "Продукты";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.controlTreeView);
            this.Controls.Add(this.bCategory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button bCategory;
		private ControlLibrary.ControlTreeView controlTreeView;
        private System.Windows.Forms.Button buttonProduct;
    }
}