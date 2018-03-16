using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace patient_monitoring_system
{
    public partial class Form1 : Form
    {
        public static String conStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =hospital.mdb";
        
        public Form1()
        {
            InitializeComponent();
            
            

        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            login lf = new patient_monitoring_system.login(4);
            lf.MdiParent = this;
            lf.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            login lf = new patient_monitoring_system.login(3);
            lf.MdiParent = this;
            lf.Show();
        }

        private void nurseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login lf = new patient_monitoring_system.login(2);
            lf.MdiParent = this;
            lf.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login lf = new patient_monitoring_system.login(1);
            lf.MdiParent = this;
            lf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool login(int type, int id, String password)
        {
            if(type == 1)
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM admin WHERE id = " + id + " AND pass = '" + password + "'", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    return false;
                }
            }
            if(type == 2)
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM nurse WHERE id = " + id + " AND pass = '" + password + "'", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    return false;
                }
            }
            if(type == 3)
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM doctor WHERE id = " + id + " AND pass = '" + password + "'", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    return false;
                }
            }

            if(type == 4)
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM patient WHERE id = " + id + " AND pass = '" + password + "'", con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        public static void loginSuccess(int type, String id)
        {
            if(type == 1)
            {
                admin af = new admin();
                af.Show();
            }

            if(type == 2)
            {
                nurse nf = new nurse(id);
                nf.Show();
            }
            if (type == 3)
            {
                doctor df = new doctor(id);
                df.Show();
            }
            if (type == 4)
            {
                patient pf = new patient(id);
                pf.Show();
            }
        }
    }
}
