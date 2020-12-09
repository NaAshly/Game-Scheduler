using MetroFramework.Forms;
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

namespace Game_Scheduler
{
    public partial class Admin_Login : MetroForm
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }

       
        private void metroLink2_Click(object sender, EventArgs e)
        {
            Sign_Up frm = new Sign_Up();
            frm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(global::Game_Scheduler.Properties.Settings.Default.Database1ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter ("Select Count(*) from Admin where Email ='" + txtEmail.Text + "' and Password ='" + txtPass.Text + "'",con);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                Admin_Menu frm = new Admin_Menu();
                frm.Show();
            }

            else {

                MessageBox.Show("Please Check your email or password ");
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();


        }

        private void txtEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_Click(object sender, EventArgs e)
        {

        }
    }
}
