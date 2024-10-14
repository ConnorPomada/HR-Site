using Microsoft.Data.SqlClient;
using PasswordController;
using System.Security.Cryptography;
namespace FinalHRSite
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		//Login Button
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=HR;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
				{
					SqlCommand command = new SqlCommand($"SELECT HASH, Salt, EmployeeID, Access FROM LOGIN WHERE Username = '{username.Text}'", connection);
					connection.Open();
					using (SqlDataReader reader = command.ExecuteReader())
					{
						PasswordSalt passwordSalt = new PasswordSalt();
						int access = 0;
						byte[] salt = null;
						string hash = null;
						int id = 0;
						while (reader.Read())
						{
							hash = reader.GetString(0);
							salt = Convert.FromBase64String(reader.GetString(1));
							id = reader.GetInt32(2);
							access = reader.GetInt32(3);

						}
						if (passwordSalt.VerifyPassword(password.Text, hash, salt))
						{
							switch (access)
							{
								case 0:
									Error.Text = "Login Successful";
									Form2 form2 = new Form2(id);
									form2.Show();
									this.Hide();
									break;
								case 1:
									Error.Text = "Login Successful";
									Form2 form22 = new Form2(id);
									form22.Show();
									this.Hide();
									break;
								case 2:
									Error.Text = "Login Successful";
									Employee employee = new Employee(id);
									employee.Show();
									this.Hide();
									break;
								default:
									Error.Text = "Access Unkown";
									break;
							}
						}
						else
						{
							Error.Text = "Login Failed";
						}
					}
				}
		}
			catch (Exception ex)
			{
				Error.Text = "Username And/Or Password Inncorrect";
			}
}
		private void password_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button1_Click(this, new EventArgs());
			}
		}
		private void password_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
