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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.btnSalvar1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.btnSalvar2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnRezetar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.lblUrl1 = new System.Windows.Forms.Label();
            this.lblUrl2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(32, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(483, 12);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(250, 250);
            this.webBrowser2.TabIndex = 1;
            this.webBrowser2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // btnSalvar1
            // 
            this.btnSalvar1.Location = new System.Drawing.Point(32, 354);
            this.btnSalvar1.Name = "btnSalvar1";
            this.btnSalvar1.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar1.TabIndex = 2;
            this.btnSalvar1.Text = "SALVAR";
            this.btnSalvar1.UseVisualStyleBackColor = true;
            this.btnSalvar1.Click += new System.EventHandler(this.btnSalvar1_Click);
            // 
            // btnDelete1
            // 
            this.btnDelete1.Location = new System.Drawing.Point(161, 354);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(75, 23);
            this.btnDelete1.TabIndex = 3;
            this.btnDelete1.Text = "DELETAR";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete1_Click);
            // 
            // btnSalvar2
            // 
            this.btnSalvar2.Location = new System.Drawing.Point(526, 371);
            this.btnSalvar2.Name = "btnSalvar2";
            this.btnSalvar2.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar2.TabIndex = 4;
            this.btnSalvar2.Text = "SALVAR";
            this.btnSalvar2.UseVisualStyleBackColor = true;
            this.btnSalvar2.Click += new System.EventHandler(this.btnSalvar2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(673, 371);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(75, 23);
            this.btnDelete2.TabIndex = 5;
            this.btnDelete2.Text = "DELETAR";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnRezetar
            // 
            this.btnRezetar.Location = new System.Drawing.Point(348, 202);
            this.btnRezetar.Name = "btnRezetar";
            this.btnRezetar.Size = new System.Drawing.Size(75, 23);
            this.btnRezetar.TabIndex = 6;
            this.btnRezetar.Text = "REZETAR";
            this.btnRezetar.UseVisualStyleBackColor = true;
            this.btnRezetar.Click += new System.EventHandler(this.btnRezetar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(589, 313);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.AutoSize = true;
            this.lblHoraAtual.Location = new System.Drawing.Point(283, 277);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(197, 13);
            this.lblHoraAtual.TabIndex = 9;
            this.lblHoraAtual.Text = "Dia e Hora Atual : 00/00/0000 00:00:00";
            // 
            // lblUrl1
            // 
            this.lblUrl1.AutoSize = true;
            this.lblUrl1.Location = new System.Drawing.Point(117, 405);
            this.lblUrl1.Name = "lblUrl1";
            this.lblUrl1.Size = new System.Drawing.Size(35, 13);
            this.lblUrl1.TabIndex = 10;
            this.lblUrl1.Text = "label2";
            // 
            // lblUrl2
            // 
            this.lblUrl2.AutoSize = true;
            this.lblUrl2.Location = new System.Drawing.Point(634, 405);
            this.lblUrl2.Name = "lblUrl2";
            this.lblUrl2.Size = new System.Drawing.Size(35, 13);
            this.lblUrl2.TabIndex = 11;
            this.lblUrl2.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUrl2);
            this.Controls.Add(this.lblUrl1);
            this.Controls.Add(this.lblHoraAtual);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRezetar);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.btnSalvar2);
            this.Controls.Add(this.btnDelete1);
            this.Controls.Add(this.btnSalvar1);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.Label lblUrl1;
        private System.Windows.Forms.Label lblUrl2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

