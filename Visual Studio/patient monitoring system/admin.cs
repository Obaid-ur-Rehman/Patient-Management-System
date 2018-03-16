using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patient_monitoring_system
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addRecord ar = new addRecord();
            ar.MdiParent = this;
            ar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modifyRecord mr = new modifyRecord();
            mr.MdiParent = this;
            mr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteRecord dr = new deleteRecord();
            dr.MdiParent = this;
            dr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
