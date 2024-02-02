using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Collections;

namespace QueryConstructor
{
    public partial class Authentication : Form
    {
        public string conString;

        public Authentication()
        {
            InitializeComponent();
        }

        private void Authentication_Load(object sender, EventArgs e)
        {
            Authentication_comboBox.SelectedIndex = 0;
            ConnectionStatus_label.Text = string.Empty;
            this.ActiveControl = UserID_textBox;
        }

        private void CheckConnection(string conString)
        {
            DisabeForm();
            SqlConnection con = new SqlConnection(conString);
            ConnectionStatus_label.Text = string.Empty;

            try
            {
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand selectdb = new SqlCommand("SELECT name FROM sys.databases;", con);
                    adapter.SelectCommand = selectdb;
                    adapter.Fill(table);

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        InitialCatalog_comboBox.Items.Add(table.Rows[i]["name"]);
                    }

                    ConnectionStatus_label.Text = "Connected!";
                    ConnectionStatus_label.ForeColor = Color.Green;
                    con.Close();
                    EnableForm();
                }
            }
            catch
            {
                ConnectionStatus_label.Text = "Not connected!";
                ConnectionStatus_label.ForeColor = Color.Red;
                EnableForm();
                InitialCatalog_comboBox.Items.Clear();
            }
        }

        private void CheckConnection_button_Click(object sender, EventArgs e)
        {
            conString = "";

            if (Authentication_comboBox.SelectedIndex == 0 && Server_comboBox.Text != string.Empty)
            {
                conString = $"Server={Server_comboBox.Text};Trusted_Connection=True;";
                CheckConnection(conString);
            }
            else if (Authentication_comboBox.SelectedIndex == 1 && UserID_textBox.Text != string.Empty && Server_comboBox.Text != string.Empty)
            {
                conString = $"Server={Server_comboBox.Text};User Id={UserID_textBox.Text};Password={Password_textBox.Text};";
                CheckConnection(conString);
            }
            else
            {
                MessageBox.Show("Enter all the fields!");
            }
        }

        private void Authentication_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionStatus_label.Text = string.Empty;
            InitialCatalog_comboBox.Items.Clear();
            if (Authentication_comboBox.SelectedIndex == 0)
            {
                UserID_label.Visible = false;
                UserID_textBox.Visible = false;
                Password_label.Visible = false;
                Password_textBox.Visible = false;
                ConnectionStatus_label.Location = new Point(328, 48);
                CheckConnection_button.Location = new Point(328, 67);
                InitialCatalog_label.Location = new Point(80, 99);
                InitialCatalog_comboBox.Location = new Point(156, 96);
                OpenProgram_button.Location = new Point(201, 122);
            }
            else if (Authentication_comboBox.SelectedIndex == 1)
            {
                UserID_label.Visible = true;
                UserID_textBox.Visible = true;
                Password_label.Visible = true;
                Password_textBox.Visible = true;
                ConnectionStatus_label.Location = new Point(328, 101);
                CheckConnection_button.Location = new Point(328, 120);
                InitialCatalog_label.Location = new Point(80, 153);
                InitialCatalog_comboBox.Location = new Point(156, 150);
                OpenProgram_button.Location = new Point(201, 177);
            }
        }

        private void DisabeForm()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
            this.Enabled = false;
            EnableControl();
        }

        private void EnableForm()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
            this.Enabled = true;
            EnableControl();
        }

        private void EnableControl()
        {
            if (ConnectionStatus_label.Text == "Connected!")
            {
                InitialCatalog_comboBox.Enabled = true;
                InitialCatalog_label.Enabled = true;
            }
            else
            {
                InitialCatalog_comboBox.Enabled = false;
                InitialCatalog_label.Enabled = false;
            }

            if (InitialCatalog_comboBox.Text != string.Empty)
            {
                OpenProgram_button.Enabled = true;
            }
            else
            {
                OpenProgram_button.Enabled = false;
            }
        }

        private void UserID_textBox_TextChanged(object sender, EventArgs e)
        {
            InitialCatalog_comboBox.Items.Clear();
            ConnectionStatus_label.Text = string.Empty;
            EnableControl();
        }

        private void InitialCatalog_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableControl();
        }

        private void OpenProgram_button_Click(object sender, EventArgs e)
        {
            string server = Server_comboBox.Text;
            string login = UserID_textBox.Text;
            string password = Password_textBox.Text;
            string initialcatalog = InitialCatalog_comboBox.Text;
            QueryConsole queryConsole = new QueryConsole();
            queryConsole.Server_label.Text = server;
            queryConsole.Login_label.Text = login;
            queryConsole.Password_label.Text = password;
            queryConsole.InitialCatalog_label.Text = initialcatalog;
            queryConsole.conString_label.Text = conString;
            queryConsole.Show();
            this.Hide();
        }
    }
}
