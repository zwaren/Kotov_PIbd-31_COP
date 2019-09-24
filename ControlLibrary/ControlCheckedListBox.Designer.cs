namespace ControlLibrary
{
	partial class ControlCheckedListBox
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

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.checkedListBox = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// checkedListBox
			// 
			this.checkedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBox.FormattingEnabled = true;
			this.checkedListBox.Location = new System.Drawing.Point(0, 0);
			this.checkedListBox.Name = "checkedListBox";
			this.checkedListBox.Size = new System.Drawing.Size(150, 150);
			this.checkedListBox.TabIndex = 0;
			
			// 
			// ControlCheckedListBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkedListBox);
			this.Name = "ControlCheckedListBox";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckedListBox checkedListBox;
	}
}
