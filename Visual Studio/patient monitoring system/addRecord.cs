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
    public partial class addRecord : Form
    {
        public addRecord()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbD.Checked)
            {
                insertD();
            }
            else if (rbP.Checked)
            {
                insertP();
            }
            else if (rbN.Checked)
            {
                insertN();
            }
            else
            {
                MessageBox.Show("Select type");
            }
        }

        private void insertP()
        {
            if ((tbPass.Text.Length > 0) && (tbName.Text.Length > 0) && (tbAddress.Text.Length > 0) && (tbContact.Text.Length > 0))
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO patient (pass, pname, address, contact) VALUES('" + tbPass.Text.ToString() + "', '" + tbName.Text.ToString() + "', '" + tbAddress.Text.ToString() + "', '" + tbContact.Text.ToString() + "')", con);
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
            else
            {
                MessageBox.Show("Missing fields");
            }
        }

        private void insertD()
        {
            if ((tbPass.Text.Length > 0) && (tbName.Text.Length > 0) && (tbAddress.Text.Length > 0) && (tbContact.Text.Length > 0))
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO doctor (pass, dname, address, contact) VALUES('" + tbPass.Text.ToString() + "', '" + tbName.Text.ToString() + "', '" + tbAddress.Text.ToString() + "', '" + tbContact.Text.ToString() + "')", con);
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
            else
            {
                MessageBox.Show("Missing fields");
            }
        }

        private void insertN()
        {
            if ((tbPass.Text.Length > 0) && (tbName.Text.Length > 0) && (tbAddress.Text.Length > 0) && (tbContact.Text.Length > 0))
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO nurse (pass, nname, address, contact) VALUES('" + tbPass.Text.ToString() + "', '" + tbName.Text.ToString() + "', '" + tbAddress.Text.ToString() + "', '" + tbContact.Text.ToString() + "')", con);
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
            else
            {
                MessageBox.Show("Missing fields");
            }
        }

        private void x_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
