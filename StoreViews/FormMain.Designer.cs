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
			this.controlTreeView.Name = "controlTreeView";
			this.controlTreeView.Size = new System.Drawing.Size(221, 342);
			this.controlTreeView.TabIndex = 1;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(508, 366);
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
	}
}