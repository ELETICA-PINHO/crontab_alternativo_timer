using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crontab_alternativo_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaHora();
        }

        private void AtualizaHora()
        {
            lblHoraAtual.Text = "Dia e Hora Atual:" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizaHora();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void btnSalvar1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnRezetar_Click(object sender, EventArgs e)
        {

        }
    }
}
