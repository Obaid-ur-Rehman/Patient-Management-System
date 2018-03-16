using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patient_monitoring_system
{
    public partial class patient : Form
    {
        Thread listenerT;
        int listenPort = 1500;
        UdpClient listener;
        IPEndPoint groupEP;
        String id;
        public patient(String idd)
        {
            InitializeComponent();
            id = idd;
            label1.Text = "Patient Portal ID: " + idd;
            listener = new UdpClient(listenPort);
            groupEP = new IPEndPoint(IPAddress.Any, listenPort);
            listenerT = new Thread(listenToDevice);
            listenerT.IsBackground = true;
            listenerT.Start();
        }

        private void patient_Load(object sender, EventArgs e)
        {
            updateUI();
        }

        private void listenToDevice()
        {
            while (true)
            {
                string received_data;
                byte[] receive_byte_array;

                receive_byte_array = listener.Receive(ref groupEP);
                received_data = Encoding.ASCII.GetString(receive_byte_array, 0, receive_byte_array.Length);
                MessageBox.Show(received_data);
                String[] packets = received_data.Split(',');
                try {
                    using (OleDbConnection con = new OleDbConnection(Form1.conStr))
                    {
                        OleDbCommand cmd = new OleDbCommand("INSERT INTO diag (pid, BPM, temperature) VALUES('" + id + "', '" + packets[0] + "', '" + packets[1] + "')", con);
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            this.Invoke((MethodInvoker)delegate
                           {
                               updateUI();
                           });

                        }
                        else
                        {
                        }
                    }
                }
                catch (Exception x) { }
            }
        }

        private void updateUI()
        {
            dataGridView1.Rows.Clear();
            using (OleDbConnection con = new OleDbConnection(Form1.conStr))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT ID, BPM, temperature FROM diag WHERE pid = '" + id + "';", con);
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
                OleDbCommand cmd = new OleDbCommand("SELECT ID, descr, did FROM presc WHERE pid = '" + id + "';", con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridView2.Rows.Add(reader.GetString(2), reader.GetString(1), reader.GetInt32(0));
                    }
                }
            }
        }
    }
}

