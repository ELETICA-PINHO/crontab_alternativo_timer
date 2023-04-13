using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crontab_alternativo_timer.Properties;

namespace crontab_alternativo_timer
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaHora();
            AtualizaWeb();
        }

        private void AtualizaWeb()
        {
            lblUrl1.Text = Settings.Default["txtUrl1"].ToString();
            lblUrl2.Text = Settings.Default["txtUrl2"].ToString();


            Console.WriteLine(Settings.Default["txtUrl1"].ToString().Length);

            if (Settings.Default["txtUrl1"].ToString().Length > 0 ) {
                webBrowser1.Url = new Uri(Settings.Default["txtUrl1"].ToString());
            }

            if (Settings.Default["txtUrl2"].ToString().Length > 0)
            {
                webBrowser2.Url = new Uri(Settings.Default["txtUrl2"].ToString());
            }



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
            
            AtualizaWeb();
        }

        private void btnSalvar1_Click(object sender, EventArgs e)
        {
            Settings.Default["txtUrl1"] = txtUrl1.Text.Trim();
            Settings.Default.Save();
            MessageBox.Show("Dados Salavos");


        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            Settings.Default["txtUrl1"] = txtUrl1.Text = "";
            Settings.Default.Save();
            MessageBox.Show("Dados Deletados");

        }

        private void btnSalvar2_Click(object sender, EventArgs e)
        {
            Settings.Default["txtUrl2"] = txtUrl2.Text.Trim();
            Settings.Default.Save();
            MessageBox.Show("Dados Salavos");
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            Settings.Default["txtUrl2"] = txtUrl2.Text = "";
            Settings.Default.Save();
            MessageBox.Show("Dados Deletados");
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
            Settings.Default.Reset();
            MessageBox.Show("Dados Rezetados");
        }
    }
}
