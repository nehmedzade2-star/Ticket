namespace WinFormsApp4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			pictureBox3 = new PictureBox();
			pictureBox1 = new PictureBox();
			groupBox1 = new GroupBox();
			button1 = new Button();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			maskedTextBox1 = new MaskedTextBox();
			comboBox2 = new ComboBox();
			comboBox1 = new ComboBox();
			groupBox2 = new GroupBox();
			button2 = new Button();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			maskedTextBox2 = new MaskedTextBox();
			textBox4 = new TextBox();
			textBox2 = new TextBox();
			button3 = new Button();
			button4 = new Button();
			listBox1 = new ListBox();
			maskedTextBox3 = new MaskedTextBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Control;
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(pictureBox3);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(941, 100);
			panel1.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(452, 69);
			label2.Name = "label2";
			label2.Size = new Size(82, 27);
			label2.TabIndex = 4;
			label2.Text = "by Ali";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(365, 23);
			label1.Name = "label1";
			label1.Size = new Size(271, 46);
			label1.TabIndex = 3;
			label1.Text = "Transport 8";
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(827, 12);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(102, 66);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 2;
			pictureBox3.TabStop = false;
			pictureBox3.Click += pictureBox3_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(197, 94);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = SystemColors.ControlDarkDark;
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(maskedTextBox1);
			groupBox1.Controls.Add(comboBox2);
			groupBox1.Controls.Add(comboBox1);
			groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.ForeColor = SystemColors.ButtonHighlight;
			groupBox1.Location = new Point(12, 106);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(359, 229);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Travel Information";
			// 
			// button1
			// 
			button1.BackColor = SystemColors.HotTrack;
			button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.Black;
			button1.Location = new Point(235, 22);
			button1.Name = "button1";
			button1.Size = new Size(64, 75);
			button1.TabIndex = 13;
			button1.Text = "<\r\n>\r\n";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
			label6.ForeColor = SystemColors.ButtonFace;
			label6.Location = new Point(6, 161);
			label6.Name = "label6";
			label6.Size = new Size(36, 20);
			label6.TabIndex = 7;
			label6.Text = "Yer:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
			label5.ForeColor = SystemColors.ButtonFace;
			label5.Location = new Point(6, 117);
			label5.Name = "label5";
			label5.Size = new Size(47, 20);
			label5.TabIndex = 6;
			label5.Text = "Tarix:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
			label4.ForeColor = SystemColors.ButtonFace;
			label4.Location = new Point(6, 74);
			label4.Name = "label4";
			label4.Size = new Size(62, 20);
			label4.TabIndex = 5;
			label4.Text = "Haraya:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
			label3.ForeColor = SystemColors.ButtonFace;
			label3.Location = new Point(6, 31);
			label3.Name = "label3";
			label3.Size = new Size(72, 20);
			label3.TabIndex = 4;
			label3.Text = "Haradan:";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(83, 161);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(128, 33);
			textBox1.TabIndex = 3;
			// 
			// maskedTextBox1
			// 
			maskedTextBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			maskedTextBox1.Location = new Point(83, 117);
			maskedTextBox1.Mask = "00/00/0000 90:00";
			maskedTextBox1.Name = "maskedTextBox1";
			maskedTextBox1.Size = new Size(128, 27);
			maskedTextBox1.TabIndex = 3;
			maskedTextBox1.ValidatingType = typeof(DateTime);
			// 
			// comboBox2
			// 
			comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox2.FormattingEnabled = true;
			comboBox2.Items.AddRange(new object[] { "Quba", "Şəki", "Lənkəran", "Qəbələ", "Şamaxı" });
			comboBox2.Location = new Point(83, 74);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(128, 33);
			comboBox2.TabIndex = 1;
			// 
			// comboBox1
			// 
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Quba", "Şəki", "Lənkəran", "Qəbələ", "Şamaxı" });
			comboBox1.Location = new Point(83, 31);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(128, 33);
			comboBox1.TabIndex = 0;
			// 
			// groupBox2
			// 
			groupBox2.BackColor = SystemColors.ControlDarkDark;
			groupBox2.Controls.Add(maskedTextBox3);
			groupBox2.Controls.Add(button2);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(maskedTextBox2);
			groupBox2.Controls.Add(textBox4);
			groupBox2.Controls.Add(textBox2);
			groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox2.ForeColor = SystemColors.ButtonFace;
			groupBox2.Location = new Point(576, 106);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(353, 229);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "Person Information";
			// 
			// button2
			// 
			button2.BackColor = Color.RoyalBlue;
			button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = SystemColors.ActiveCaptionText;
			button2.Location = new Point(6, 190);
			button2.Name = "button2";
			button2.Size = new Size(293, 33);
			button2.TabIndex = 3;
			button2.Text = "Bilet al";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
			label7.Location = new Point(6, 161);
			label7.Name = "label7";
			label7.Size = new Size(47, 20);
			label7.TabIndex = 12;
			label7.Text = "Email";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
			label8.Location = new Point(6, 117);
			label8.Name = "label8";
			label8.Size = new Size(65, 20);
			label8.TabIndex = 11;
			label8.Text = "Telefon:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
			label9.Location = new Point(6, 74);
			label9.Name = "label9";
			label9.Size = new Size(38, 20);
			label9.TabIndex = 10;
			label9.Text = "FIN:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
			label10.Location = new Point(6, 31);
			label10.Name = "label10";
			label10.Size = new Size(99, 20);
			label10.TabIndex = 9;
			label10.Text = "Ad və Soyad:";
			// 
			// maskedTextBox2
			// 
			maskedTextBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			maskedTextBox2.Location = new Point(111, 117);
			maskedTextBox2.Mask = "(994)00-000-00-00";
			maskedTextBox2.Name = "maskedTextBox2";
			maskedTextBox2.Size = new Size(128, 27);
			maskedTextBox2.TabIndex = 8;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(111, 154);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(128, 33);
			textBox4.TabIndex = 6;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(111, 31);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(128, 33);
			textBox2.TabIndex = 4;
			// 
			// button3
			// 
			button3.BackColor = Color.Red;
			button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.ForeColor = SystemColors.ButtonHighlight;
			button3.Location = new Point(12, 405);
			button3.Name = "button3";
			button3.Size = new Size(187, 41);
			button3.TabIndex = 13;
			button3.Text = "Siyahıdan sil";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.BackColor = Color.FromArgb(192, 64, 0);
			button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button4.ForeColor = SystemColors.ButtonFace;
			button4.Location = new Point(756, 405);
			button4.Name = "button4";
			button4.Size = new Size(173, 41);
			button4.TabIndex = 14;
			button4.Text = "Proqramdan çıxış";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(12, 341);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(917, 64);
			listBox1.TabIndex = 14;
			// 
			// maskedTextBox3
			// 
			maskedTextBox3.Location = new Point(111, 78);
			maskedTextBox3.Mask = "aaaaaaa";
			maskedTextBox3.Name = "maskedTextBox3";
			maskedTextBox3.Size = new Size(128, 33);
			maskedTextBox3.TabIndex = 13;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonShadow;
			ClientSize = new Size(941, 450);
			Controls.Add(listBox1);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(panel1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private PictureBox pictureBox3;
		private Label label1;
		private Label label2;
		private GroupBox groupBox1;
		private ComboBox comboBox1;
		private GroupBox groupBox2;
		private ComboBox comboBox2;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private TextBox textBox1;
		private MaskedTextBox maskedTextBox1;
		private MaskedTextBox maskedTextBox2;
		private TextBox textBox4;
		private TextBox textBox2;
		private Button button1;
		private Button button2;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Button button3;
		private Button button4;
		private ListBox listBox1;
		private MaskedTextBox maskedTextBox3;
	}
}
