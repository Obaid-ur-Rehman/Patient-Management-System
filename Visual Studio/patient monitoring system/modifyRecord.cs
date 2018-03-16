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
    public partial class modifyRecord : Form
    {
        public modifyRecord()
        {
            InitializeComponent();
        }

        private void modifyRecord_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(rbD.Checked)
            {
                showD();
            }
            else if(rbP.Checked)
            {
                showP();
            }
            else if(rbN.Checked)
            {
                showN();
            }
            else
            {
                MessageBox.Show("Select type");
            }
        }

        private void showD()
        {
            if (tbID.Text.Length > 0)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM doctor WHERE id = " + tbID.Text + "", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lblID.Text = "Showing record of Doctor ID: " + tbID.Text;
                            tbPass.Text = reader.GetString(1);
                            tbName.Text = reader.GetString(2);
                            tbAddress.Text = reader.GetString(3);
                            tbContact.Text = reader.GetString(4);

                        }
                    }
                }
            }
            else
                MessageBox.Show("Enter ID");
        }
        private void showN()
        {
            if (tbID.Text.Length > 0)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM nurse WHERE id = " + Convert.ToInt32(tbID.Text) + "", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {

                    }
                }
            }
            else
                MessageBox.Show("Enter ID");
        }
        private void showP()
        {
            if (tbID.Text.Length > 0)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM patient WHERE id = " + Convert.ToInt32(tbID.Text) + "", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {

                    }
                }
            }
            else
                MessageBox.Show("Enter ID");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbD.Checked)
            {
                modifyD();
            }
            else if (rbP.Checked)
            {
                modifyP();
            }
            else if (rbN.Checked)
            {
                modifyN();
            }
            else
            {
                MessageBox.Show("Select type");
            }
        }


        private void modifyD()
        {
            if (tbID.Text.Length > 0)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE doctor SET pass = '" + tbPass.Text.ToString() + "', dname = '" + tbName.Text.ToString() + "'" + ", address = '" + tbAddress.Text.ToString() + "'" + ", contact = '" + tbContact.Text.ToString() + "' WHERE ID="+ tbID.Text +"", con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Updated");
                    }
                    else
                    {
                        MessageBox.Show("Could not update record");
                    }
                }
            }
            else
                MessageBox.Show("Enter ID");
        }

        private void modifyN()
        {
            if (tbID.Text.Length > 0)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE nurse SET pass = '" + tbPass.Text.ToString() + "', dname = '" + tbName.Text.ToString() + "'" + ", address = '" + tbAddress.Text.ToString() + "'" + ", contact = '" + tbContact.Text.ToString() + "' WHERE ID=" + tbID.Text + "", con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Updated");
                    }
                    else
                    {
                        MessageBox.Show("Could not update record");
                    }
                }
            }
            else
                MessageBox.Show("Enter ID");
        }

        private void modifyP()
        {
            if (tbID.Text.Length > 0)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("UPDATE patient SET pass = '" + tbPass.Text.ToString() + "', dname = '" + tbName.Text.ToString() + "'" + ", address = '" + tbAddress.Text.ToString() + "'" + ", contact = '" + tbContact.Text.ToString() + "' WHERE ID=" + tbID.Text + "", con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record Updated");
                    }
                    else
                    {
                        MessageBox.Show("Could not update record");
                    }
                }
            }
            else
                MessageBox.Show("Enter ID");
        }
    }
}
