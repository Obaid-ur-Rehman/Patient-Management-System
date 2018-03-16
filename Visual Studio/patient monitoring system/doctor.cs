using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace patient_monitoring_system
{
    public partial class doctor : Form
    {
        String id;
        public doctor(String idd)
        {
            InitializeComponent();
            id = idd;
            label3.Text = "Doctor Portal ID: " + id;
        }

        private void doctor_Load(object sender, EventArgs e)
        {
            updateUI();
        }


        private void updateUI()
        {
            dataGridView1.Rows.Clear();
            using (OleDbConnection con = new OleDbConnection(Form1.conStr))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT ID, BPM, temperature FROM diag;", con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(Form1.conStr))
            {
                OleDbCommand cmd = new OleDbCommand("INSERT INTO presc (pid, descr, did) VALUES('" + pid.Text.ToString() + "', '" + desc.Text.ToString() + "', '" + id + "');", con);
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Record Added");
                }
                else
                {
                    MessageBox.Show("Could not add record");
                }
            }
        }
    }
}
