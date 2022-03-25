using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iBox
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // With Microsoft SQL Server Database File
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Documents\database_Login.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From Table_Login where Username = '" + txb_username.Text + "' and Password = '"+txb_password.Text+"'", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {
                Form1 log = new Form1();
                this.Hide();
                log.Show();

            }
            else
            {
                MessageBox.Show("The username or password you entered is incorrect, try again!");
                txb_username.Clear();
                txb_password.Clear();
                txb_username.Focus();
            }
            /*
            if(txb_username.Text=="1234" && txb_password.Text=="1234")
            {
                Form1 log = new Form1();
                this.Hide();
                log.Show();

            }
            else
            {
                MessageBox.Show("The username or password you entered is incorrect, try again!");
                txb_username.Clear();
                txb_password.Clear();
                txb_username.Focus();
            }
            */
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            txb_username.Clear();
            txb_password.Clear();
            txb_username.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txb_password.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Hide Password";

            }
            else
            {
                txb_password.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Show Password";
            }
        }
    }
}
