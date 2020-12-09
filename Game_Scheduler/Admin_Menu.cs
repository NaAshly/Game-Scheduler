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
    public partial class Admin_Menu : MetroForm
    {
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Create_Schedule frm = new Create_Schedule();
            frm.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Update_Winner frm = new Update_Winner();
            frm.Show();
        }

     
    }
}
