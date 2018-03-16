using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace patient_monitoring_system
{
    public partial class nurse : Form
    {
        String id;
        public nurse(String idd)
        {
            InitializeComponent();
            id = idd;
        }

        private void nurse_Load(object sender, EventArgs e)
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

            updateDiag();
        }

        private void updateDiag()
        {
            dataGridView2.Rows.Clear();
            using (OleDbConnection con = new OleDbConnection(Form1.conStr))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT ID, descr, did FROM presc;", con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader.GetString(2), reader.GetString(1), reader.GetInt32(0));
                    }
                }
            }
        }
    }
}
