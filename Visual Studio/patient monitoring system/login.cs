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
    public partial class login : Form
    {
        int lType;
        public login(int type)
        {
            lType = type;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (lType == 1)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM admin WHERE ID = " + tbID.Text + " AND pass = '" + tbPass.Text + "'", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Form1.loginSuccess(1, tbID.Text);

                    }
                    else
                        Form1.loginSuccess(-1, "");
                    this.Dispose();
                }
            }
            if (lType == 2)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM nurse WHERE ID = " + tbID.Text + " AND pass = '" + tbPass.Text + "'", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Form1.loginSuccess(2, tbID.Text);
                    }
                    else
                        Form1.loginSuccess(-1, "");
                    this.Dispose();
                }
            }
            if (lType == 3)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM doctor WHERE ID = " + tbID.Text + " AND pass = '" + tbPass.Text + "'", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Form1.loginSuccess(3, tbID.Text);

                    }
                    else
                        Form1.loginSuccess(-1, "");
                    this.Dispose();
                }
            }
            if (lType == 4)
            {
                using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM patient WHERE ID = " + tbID.Text + " AND pass = '" + tbPass.Text + "'", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Form1.loginSuccess(4, tbID.Text);

                    }
                    else
                        Form1.loginSuccess(-1, "");
                    this.Dispose();
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
