namespace crontab_alternativo_timer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.btnSalvar1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnSalvar2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnRezetar = new System.Windows.Forms.Button();
            this.txtUrl1 = new System.Windows.Forms.TextBox();
            this.txtUrl2 = new System.Windows.Forms.TextBox();
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.lblUrl1 = new System.Windows.Forms.Label();
            this.lblUrl2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // webBrowser2
            // 
            resources.ApplyResources(this.webBrowser2, "webBrowser2");
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // btnSalvar1
            // 
            resources.ApplyResources(this.btnSalvar1, "btnSalvar1");
            this.btnSalvar1.Name = "btnSalvar1";
            this.btnSalvar1.UseVisualStyleBackColor = true;
            this.btnSalvar1.Click += new System.EventHandler(this.btnSalvar1_Click);
            // 
            // btnDelete1
            // 
            resources.ApplyResources(this.btnDelete1, "btnDelete1");
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnSalvar2
            // 
            resources.ApplyResources(this.btnSalvar2, "btnSalvar2");
            this.btnSalvar2.Name = "btnSalvar2";
            this.btnSalvar2.UseVisualStyleBackColor = true;
            this.btnSalvar2.Click += new System.EventHandler(this.btnSalvar2_Click);
            // 
            // btnDelete2
            // 
            resources.ApplyResources(this.btnDelete2, "btnDelete2");
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnRezetar
            // 
            resources.ApplyResources(this.btnRezetar, "btnRezetar");
            this.btnRezetar.Name = "btnRezetar";
            this.btnRezetar.UseVisualStyleBackColor = true;
            this.btnRezetar.Click += new System.EventHandler(this.btnRezetar_Click);
            // 
            // txtUrl1
            // 
            resources.ApplyResources(this.txtUrl1, "txtUrl1");
            this.txtUrl1.Name = "txtUrl1";
            this.txtUrl1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUrl2
            // 
            resources.ApplyResources(this.txtUrl2, "txtUrl2");
            this.txtUrl2.Name = "txtUrl2";
            this.txtUrl2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblHoraAtual
            // 
            resources.ApplyResources(this.lblHoraAtual, "lblHoraAtual");
            this.lblHoraAtual.Name = "lblHoraAtual";
            // 
            // lblUrl1
            // 
            resources.ApplyResources(this.lblUrl1, "lblUrl1");
            this.lblUrl1.ForeColor = System.Drawing.Color.Red;
            this.lblUrl1.Name = "lblUrl1";
            // 
            // lblUrl2
            // 
            resources.ApplyResources(this.lblUrl2, "lblUrl2");
            this.lblUrl2.ForeColor = System.Drawing.Color.Red;
            this.lblUrl2.Name = "lblUrl2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.lblUrl2);
            this.Controls.Add(this.lblUrl1);
            this.Controls.Add(this.lblHoraAtual);
            this.Controls.Add(this.txtUrl2);
            this.Controls.Add(this.txtUrl1);
            this.Controls.Add(this.btnRezetar);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnSalvar2);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnSalvar1);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button btnSalvar1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnSalvar2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnRezetar;
        private System.Windows.Forms.TextBox txtUrl1;
        private System.Windows.Forms.TextBox txtUrl2;
        private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.Label lblUrl1;
        private System.Windows.Forms.Label lblUrl2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

