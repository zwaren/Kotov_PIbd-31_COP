namespace WindowsFormsApp
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new System.Windows.Forms.Button();
            this.controlTextBox1 = new ControlLibrary.ControlTextBox();
            this.controlComboBox = new ControlLibrary.ControlComboBox();
            this.controlTreeView1 = new ControlLibrary.ControlTreeView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlTextBox1
            // 
            this.controlTextBox1.AutoSize = true;
            this.controlTextBox1.Location = new System.Drawing.Point(113, 208);
            this.controlTextBox1.Name = "controlTextBox1";
            this.controlTextBox1.Size = new System.Drawing.Size(150, 20);
            this.controlTextBox1.TabIndex = 5;
            // 
            // controlComboBox
            // 
            this.controlComboBox.AutoSize = true;
            this.controlComboBox.Location = new System.Drawing.Point(85, 82);
            this.controlComboBox.Name = "controlComboBox";
            this.controlComboBox.SelectedIndex = 0;
            this.controlComboBox.Size = new System.Drawing.Size(133, 98);
            this.controlComboBox.TabIndex = 0;
            this.controlComboBox.ComboBoxSelectedElementChange += new System.EventHandler(this.controlComboBox_ComboBoxSelectedElementChange);
            // 
            // controlTreeView1
            // 
            this.controlTreeView1.Location = new System.Drawing.Point(329, 60);
            this.controlTreeView1.Name = "controlTreeView1";
            this.controlTreeView1.Size = new System.Drawing.Size(194, 206);
            this.controlTreeView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 311);
            this.Controls.Add(this.controlTreeView1);
            this.Controls.Add(this.controlTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.controlComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private ControlLibrary.ControlComboBox controlComboBox;
		private System.Windows.Forms.Button button1;
        private ControlLibrary.ControlTextBox controlTextBox1;
        private ControlLibrary.ControlTreeView controlTreeView1;
    }
}

