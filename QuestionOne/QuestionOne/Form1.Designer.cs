namespace QuestionOne
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			listBox1 = new ListBox();
			Button1 = new Button();
			Button2 = new Button();
			listBox2 = new ListBox();
			textBox2 = new TextBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(140, 42);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(204, 23);
			textBox1.TabIndex = 0;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(140, 79);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(204, 289);
			listBox1.TabIndex = 1;
			// 
			// Button1
			// 
			Button1.Location = new Point(140, 386);
			Button1.Name = "Button1";
			Button1.Size = new Size(204, 44);
			Button1.TabIndex = 2;
			Button1.Text = "Calculate";
			Button1.UseVisualStyleBackColor = true;
			Button1.Click += Button1_Click;
			// 
			// Button2
			// 
			Button2.Location = new Point(424, 386);
			Button2.Name = "Button2";
			Button2.Size = new Size(204, 44);
			Button2.TabIndex = 5;
			Button2.Text = "Calculate";
			Button2.UseVisualStyleBackColor = true;
			Button2.Click += Button2_Click;
			// 
			// listBox2
			// 
			listBox2.FormattingEnabled = true;
			listBox2.ItemHeight = 15;
			listBox2.Location = new Point(424, 79);
			listBox2.Name = "listBox2";
			listBox2.Size = new Size(204, 289);
			listBox2.TabIndex = 4;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(424, 42);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(204, 23);
			textBox2.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(Button2);
			Controls.Add(listBox2);
			Controls.Add(textBox2);
			Controls.Add(Button1);
			Controls.Add(listBox1);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private ListBox listBox1;
		private Button Button1;
		private Button Button2;
		private ListBox listBox2;
		private TextBox textBox2;
	}
}
