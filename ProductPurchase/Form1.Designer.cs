namespace ProductPurchase
{
    partial class Form1
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
            this.productVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCreate = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productVMBindingSource
            // 
            this.productVMBindingSource.DataSource = typeof(StoreDAL.VMs.ProductVM);
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(13, 13);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(121, 23);
            this.bCreate.TabIndex = 0;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(13, 43);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(121, 23);
            this.bPrint.TabIndex = 1;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(146, 79);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.bCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productVMBindingSource;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bPrint;
    }
}