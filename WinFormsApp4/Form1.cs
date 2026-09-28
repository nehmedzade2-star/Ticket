namespace WinFormsApp4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string a = comboBox1.Text;
			string b = comboBox2.Text;
			string c = b;
			comboBox2.Text = a;
			comboBox1.Text = c;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DialogResult d = MessageBox.Show("Proqramdan çıxış edilsinmi?", "Bildiriş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (d == DialogResult.Yes)
			{
				Close();
			}
		}
		int n = 0;
		private void button2_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text == comboBox2.Text)
			{
				MessageBox.Show("Eyni şəhərlərə gediş yoxdur", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				n++;
				listBox1.Items.Add(n.ToString() + ") " + comboBox1.Text + " " + comboBox2.Text + " "
					+ maskedTextBox1.Text + " " + textBox1.Text);


			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex == -1)
			{
				MessageBox.Show("Zəhmət olmasa siyahıdan element seçin.");
				return;
			}

			DialogResult d = MessageBox.Show(
				"Siyahıdan silinsinmi?",
				"Bildiriş",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (d == DialogResult.Yes)
			{
				listBox1.Items.RemoveAt(listBox1.SelectedIndex);
			}
		}
	}
}
