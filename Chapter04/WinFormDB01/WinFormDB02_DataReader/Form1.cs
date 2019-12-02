using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB02_DataReader
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
            conn = new MySqlConnection("server = localhost; port = 3306; database = world; username = root; password = 1234");

            try
            {
                conn.Open();

                // 3. SELECT 쿼리 객체 준비
                string queryString = "SELECT distinct continent FROM country";
                MySqlCommand command = new MySqlCommand(queryString, conn); 

                // 4. 쿼리 실행 및 데이터 가져오기
                MySqlDataReader reader = command.ExecuteReader();

                // 5. 데이터 활용
                while (reader.Read())  // 가져올 레코드가 있으면 TRUE 없으면 FALSE
                {
                    comboBox1.Items.Add(reader.GetString("continent"));
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryString = $"SELECGT name FROM country WHERE continent='{comboBox1.SelectedItem}'";
            MySqlCommand command = new MySqlCommand(queryString, conn);
            MySqlDataReader reader = command.ExecuteReader();

            comboBox2.Items.Clear();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetString("name"));

            }
            reader.Close();
        }
    }
}
