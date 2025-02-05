using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace DatabaseConnectionTester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnTestConnection_Click(object sender, EventArgs e)
        {
            string connectionString = $"Server={txtServer.Text};User Id={txtUsername.Text};Password={txtPassword.Text};";
            try
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    conn.Open();
                    lblResult.Text = "Connection successful!";
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    await Task.Delay(3500);
                    lblResult.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = "Connection failed: " + ex.Message;
                lblResult.ForeColor = System.Drawing.Color.Red;
                await Task.Delay(3500);
                lblResult.Text = "";
            }
        }

        private async void btnTestConnection2_Click(object sender, EventArgs e)
        {
            string connectionString = $"Server={txtServer.Text};User Id={txtUsername.Text};Password={txtPassword.Text};";
            try
            {
                using (Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
                {
                    conn.Open();
                    lblResult.Text = "Connection successful!";
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    await Task.Delay(3500);
                    lblResult.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = "Connection failed: " + ex.Message;
                lblResult.ForeColor = System.Drawing.Color.Red;
                await Task.Delay(3500);
                lblResult.Text = "";
            }
        }
    }
}
