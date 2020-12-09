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

namespace Game_Scheduler
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Login.SelectedItem == "Sign Up")
            {

                Sign_Up frm = new Sign_Up();
                frm.Show();
            }
            
            else if (Login.SelectedItem == "Admin Login")
            {

                Admin_Login frm = new Admin_Login();
                frm.Show();
            }
            
            else if (Login.SelectedItem == "Player Login")
            {

                Player_Login frm = new Player_Login();
                frm.Show();
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Sign_Up frm = new Sign_Up();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
