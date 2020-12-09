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
using System.Collections;
using System.Data.SqlClient;

namespace Game_Scheduler
{
    public partial class Create_Schedule : MetroForm
    {
        public Create_Schedule()
        {
            InitializeComponent();
        }

        private void Create_Schedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.database1DataSet.Schedule);

        }

        private void Logout_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::Game_Scheduler.Properties.Settings.Default.Database1ConnectionString);

            try
            {
                string sql = "Insert into Schedule (GameId,TournamentName) values ('" + txtGameId.Text + "','"+txtTname.Text+"')";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                this.scheduleTableAdapter.Fill(this.database1DataSet.Schedule);
                //this.playerTableAdapter.Fill(this.database1DataSet.Player);


            }
            catch (Exception ex)
            {
            }
            finally
            {

                cn.Close();
            }


             round_robin(listBox1.Items);
        
        }
        public void round_robin(ListBox.ObjectCollection items)
        {

            SqlConnection cn = new SqlConnection(global::Game_Scheduler.Properties.Settings.Default.Database1ConnectionString);
            string a, b;

            ArrayList A = new ArrayList();
            ArrayList B = new ArrayList();
            int s = items.Count;
            int n = s / 2;

            for (int i = 0; i < s / 2; i++)
            {
                A.Add(items[i]);
                B.Add(items[s - 1 - i]);
            }
            if (s % 2 != 0)
            {
                A.Add(items[s / 2]);
                B.Add("Bye");
                n = (s + 1) / 2;
            }

            for (int i = 0; i < (s - 1); i++)
            {

                string sql2 = "INSERT INTO Schedule(Round,Day) values (" + (i + 1) + "," + (i + 1) + ")";
                SqlCommand exesql2 = new SqlCommand(sql2, cn);
                cn.Open();
                exesql2.ExecuteNonQuery();
                cn.Close();
                this.scheduleTableAdapter.Fill(this.database1DataSet.Schedule);
              //  this.schedulingTableAdapter.Fill(this.database1DataSet.Scheduling);

                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        database1DataSet.EnforceConstraints = false;

                        string sql1 = "INSERT INTO Schedule(team1,team2) values ('" + A[j] + "','" + B[j] + "')";

                        SqlCommand exesql1 = new SqlCommand(sql1, cn);
                        cn.Open();
                        exesql1.ExecuteNonQuery();
                        this.scheduleTableAdapter.Fill(this.database1DataSet.Schedule);

                       // this.schedulingTableAdapter.Fill(this.database1DataSet.Scheduling);
                    }
                    catch (Exception e) { }
                    finally { cn.Close(); }

                }



                a = A[n - 1] as string;
                b = B[0] as string;

                A.RemoveAt(n - 1);
                B.RemoveAt(0);
                A.Insert(1, b);
                B.Add(a);
            }

        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != " ")
            {
                listBox1.Items.Add(this.textBox1.Text);

                this.textBox1.Clear();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != " ")
            {
                listBox1.Items.Add(this.textBox1.Text);

                this.textBox1.Clear();

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::Game_Scheduler.Properties.Settings.Default.Database1ConnectionString);

            try
            {
                string sql = "Insert into Schedule (GameId,TournamentName) values ('" + txtGameId.Text + "','" + txtTname.Text + "')";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                this.scheduleTableAdapter.Fill(this.database1DataSet.Schedule);
                //this.playerTableAdapter.Fill(this.database1DataSet.Player);


            }
            catch (Exception ex)
            {
            }
            finally
            {

                cn.Close();
            }

            double_round_robin(listBox1.Items);
        }
        public void double_round_robin(ListBox.ObjectCollection items)
        {

            SqlConnection cn = new SqlConnection(global::Game_Scheduler.Properties.Settings.Default.Database1ConnectionString);
            string a, b;

            ArrayList A = new ArrayList();
            ArrayList B = new ArrayList();
            int s = items.Count;
            int n = s / 2;

            for (int i = 0; i < s / 2; i++)
            {
                A.Add(items[i]);
                B.Add(items[s - 1 - i]);
            }
            if (s % 2 != 0)
            {
                A.Add(items[s / 2]);
                B.Add("Bye");
                n = (s + 1) / 2;
            }

            for (int i = 0; i < 2*(s - 1); i++)
            {

                string sql2 = "INSERT INTO Schedule(Round,Day) values (" + (i + 1) + "," + (i + 1) + ")";
                SqlCommand exesql2 = new SqlCommand(sql2, cn);
                cn.Open();
                exesql2.ExecuteNonQuery();
                cn.Close();
                this.scheduleTableAdapter.Fill(this.database1DataSet.Schedule);
                //  this.schedulingTableAdapter.Fill(this.database1DataSet.Scheduling);

                for (int j = 0; j < n; j++)
                {
                    try
                    {
                        database1DataSet.EnforceConstraints = false;

                        string sql1 = "INSERT INTO Schedule(team1,team2) values ('" + A[j] + "','" + B[j] + "')";

                        SqlCommand exesql1 = new SqlCommand(sql1, cn);
                        cn.Open();
                        exesql1.ExecuteNonQuery();
                        this.scheduleTableAdapter.Fill(this.database1DataSet.Schedule);

                        // this.schedulingTableAdapter.Fill(this.database1DataSet.Scheduling);
                    }
                    catch (Exception e) { }
                    finally { cn.Close(); }

                }



                a = A[n - 1] as string;
                b = B[0] as string;

                A.RemoveAt(n - 1);
                B.RemoveAt(0);
                A.Insert(1, b);
                B.Add(a);
            }

        }

    }
}
