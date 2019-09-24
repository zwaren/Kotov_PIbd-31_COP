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
			this.controlComboBox = new ControlLibrary.ControlComboBox();
			this.controlCheckedListBox1 = new ControlLibrary.ControlCheckedListBox();
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
			// controlCheckedListBox1
			// 
			this.controlCheckedListBox1.Location = new System.Drawing.Point(340, 82);
			this.controlCheckedListBox1.Name = "controlCheckedListBox1";
			this.controlCheckedListBox1.SelectedIndex = 0;
			this.controlCheckedListBox1.Size = new System.Drawing.Size(150, 150);
			this.controlCheckedListBox1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 311);
			this.Controls.Add(this.controlCheckedListBox1);
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
		private ControlLibrary.ControlCheckedListBox controlCheckedListBox1;
	}
}

