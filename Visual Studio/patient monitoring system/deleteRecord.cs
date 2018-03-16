using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patient_monitoring_system
{
    public partial class deleteRecord : Form
    {
        public deleteRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbD.Checked)
            {
                deleteD();
            }
            else if (rbP.Checked)
            {
                deleteP();
            }
            else if (rbN.Checked)
            {
                deleteN();
            }
            else
            {
                MessageBox.Show("Select type");
            }
        }

        private void deleteD()
        {
            if (tbID.Text.Length > 0)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("DELETE * FROM doctor WHERE ID = " + tbID.Text.ToString() + "", con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Deleted");
                    }
                    else
                    {
                        MessageBox.Show("No Record Found");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter ID");
            }
        }

        private void deleteP()
        {
            if (tbID.Text.Length > 0)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("DELETE * FROM patient WHERE ID = " + tbID.Text.ToString() + "", con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Deleted");
                    }
                    else
                    {
                        MessageBox.Show("No Record Found");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter ID");
            }
        }

        private void deleteN()
        {
            if (tbID.Text.Length > 0)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("DELETE * FROM nurse WHERE ID = " + tbID.Text.ToString() + "", con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Deleted");
                    }
                    else
                    {
                        MessageBox.Show("No Record Found");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter ID");
            }
        }
    }
}
