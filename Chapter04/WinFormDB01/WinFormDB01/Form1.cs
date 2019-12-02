using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. MySql 연결 설정
            string connectionString = "server=localhost;port=3308;username=root;password=1234";
            conn = new MySqlConnection(connectionString);

            try
            {
                // 2. DB Open
                conn.Open();
                ShowDBConnectionState();
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowDBConnectionState()
        {
            if (conn.State == ConnectionState.Open)
            {
                label1.Text = "Connected";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Not Connected";
                label1.ForeColor = Color.Red;
            }
        }

        private void CloseConnection_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
                ShowDBConnectionState();
            }
        }
    }
}
