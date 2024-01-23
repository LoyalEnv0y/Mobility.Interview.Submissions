using System.Collections;

namespace QuestionOne
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			FillTextBox(textBox1, listBox1);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			FillTextBox(textBox2, listBox2);
		}

		private static void FillTextBox(TextBox textbox, ListBox listbox)
		{
			if (string.IsNullOrEmpty(textbox.Text)) return;

			try
			{
				listbox.Items.Clear();
				int limit = Convert.ToInt32(textbox.Text);

				Task.Factory.StartNew(() =>
				{
					ArrayList primeNumbers = GetPrimesUntilN(limit);
					foreach (int primeNumber in primeNumbers) listbox.Items.Add(primeNumber);
				});
			}
			catch (FormatException)
			{
				MessageBox.Show("Please enter a whole integer");
			}
		}

		private static ArrayList GetPrimesUntilN(int limit)
		{
			ArrayList primes = [];

			for (int i = 0; i < limit; i++)
			{
				if (IsPrime(i)) primes.Add(i);
			}

			return primes;
		}

		private static bool IsPrime(int num)
		{
			if (num < 2) return false;
			if (num == 2) return true;
			if (num % 2 == 0) return false;

			double rooted = Math.Sqrt(num);

			for (int i = 3; i <= rooted; i += 2)
			{
				if (num % i == 0) return false;
			}

			return true;
		}

	}
}
