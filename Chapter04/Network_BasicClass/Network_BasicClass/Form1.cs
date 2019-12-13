using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_BasicClass
{
    public partial class Form1 : Form
    {
        TcpListener tcpListener;
        TcpClient tcpClient;
        NetworkStream ns;

        public Form1()
        {
            InitializeComponent();
        }


    }
}
