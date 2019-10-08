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
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
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
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(13, 191);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "CreateDiagram";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 220);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(119, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "CreateReport";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(13, 250);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(118, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Deserialize";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
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
			this.controlTreeView1.Location = new System.Drawing.Point(281, 61);
			this.controlTreeView1.Name = "controlTreeView1";
			this.controlTreeView1.Size = new System.Drawing.Size(150, 150);
			this.controlTreeView1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 311);
			this.Controls.Add(this.controlTreeView1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
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
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private ControlLibrary.ControlTreeView controlTreeView1;
	}
}

