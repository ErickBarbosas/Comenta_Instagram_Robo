
using System;

namespace Robo_Comenta_Insta
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Iniciar = new System.Windows.Forms.Button();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.panelConfiguracao = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textRecomentar = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.TextTempoComent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textComentario = new System.Windows.Forms.TextBox();
            this.btnParar = new System.Windows.Forms.Button();
            this.textContOK = new System.Windows.Forms.TextBox();
            this.textFalhas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panellogin = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBloque = new System.Windows.Forms.TextBox();
            this.panelConfiguracao.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panellogin.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Iniciar
            // 
            this.Iniciar.BackColor = System.Drawing.Color.White;
            this.Iniciar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Iniciar.Location = new System.Drawing.Point(307, 222);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(117, 36);
            this.Iniciar.TabIndex = 0;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = false;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(76, 54);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(141, 20);
            this.textLogin.TabIndex = 1;
            this.textLogin.TextChanged += new System.EventHandler(this.textLogin_TextChanged);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(76, 94);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(141, 20);
            this.textSenha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(76, 198);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(141, 20);
            this.textUrl.TabIndex = 5;
            // 
            // panelConfiguracao
            // 
            this.panelConfiguracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelConfiguracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConfiguracao.Controls.Add(this.panel5);
            this.panelConfiguracao.Controls.Add(this.label5);
            this.panelConfiguracao.Controls.Add(this.label8);
            this.panelConfiguracao.Controls.Add(this.textComentario);
            this.panelConfiguracao.Location = new System.Drawing.Point(4, 280);
            this.panelConfiguracao.Name = "panelConfiguracao";
            this.panelConfiguracao.Size = new System.Drawing.Size(621, 289);
            this.panelConfiguracao.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.textRecomentar);
            this.panel5.Controls.Add(this.radioButton1);
            this.panel5.Controls.Add(this.TextTempoComent);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(176, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 100);
            this.panel5.TabIndex = 20;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Recomentar Acada:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(207, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Seg\'s";
            // 
            // textRecomentar
            // 
            this.textRecomentar.Location = new System.Drawing.Point(145, 42);
            this.textRecomentar.Name = "textRecomentar";
            this.textRecomentar.Size = new System.Drawing.Size(57, 20);
            this.textRecomentar.TabIndex = 17;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(145, 78);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Com Curtida";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // TextTempoComent
            // 
            this.TextTempoComent.Location = new System.Drawing.Point(145, 12);
            this.TextTempoComent.Name = "TextTempoComent";
            this.TextTempoComent.Size = new System.Drawing.Size(57, 20);
            this.TextTempoComent.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Comentar Acada: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Seg\'s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Configuração ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "Comentario:";
            // 
            // textComentario
            // 
            this.textComentario.Location = new System.Drawing.Point(3, 167);
            this.textComentario.Multiline = true;
            this.textComentario.Name = "textComentario";
            this.textComentario.Size = new System.Drawing.Size(600, 111);
            this.textComentario.TabIndex = 16;
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.White;
            this.btnParar.Enabled = false;
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnParar.Location = new System.Drawing.Point(488, 222);
            this.btnParar.Name = "btnParar";
            this.btnParar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnParar.Size = new System.Drawing.Size(117, 36);
            this.btnParar.TabIndex = 22;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // textContOK
            // 
            this.textContOK.BackColor = System.Drawing.Color.White;
            this.textContOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textContOK.Location = new System.Drawing.Point(126, 3);
            this.textContOK.Name = "textContOK";
            this.textContOK.ReadOnly = true;
            this.textContOK.Size = new System.Drawing.Size(38, 20);
            this.textContOK.TabIndex = 9;
            this.textContOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textFalhas
            // 
            this.textFalhas.BackColor = System.Drawing.Color.White;
            this.textFalhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFalhas.ForeColor = System.Drawing.Color.Red;
            this.textFalhas.Location = new System.Drawing.Point(126, 26);
            this.textFalhas.Name = "textFalhas";
            this.textFalhas.ReadOnly = true;
            this.textFalhas.Size = new System.Drawing.Size(38, 20);
            this.textFalhas.TabIndex = 9;
            this.textFalhas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Falhas:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Comentarios Feitos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panellogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panellogin.Controls.Add(this.label9);
            this.panellogin.Controls.Add(this.label10);
            this.panellogin.Controls.Add(this.textLogin);
            this.panellogin.Controls.Add(this.label11);
            this.panellogin.Controls.Add(this.label1);
            this.panellogin.Controls.Add(this.textSenha);
            this.panellogin.Controls.Add(this.textUrl);
            this.panellogin.Controls.Add(this.label2);
            this.panellogin.Location = new System.Drawing.Point(12, 12);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(276, 246);
            this.panellogin.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Login Do Instagram";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Dados do Post";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "URL Post";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(436, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 108);
            this.panel4.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.textBloque);
            this.panel6.Controls.Add(this.textContOK);
            this.panel6.Controls.Add(this.textFalhas);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(4, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 84);
            this.panel6.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(53, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Bloqueios:";
            // 
            // textBloque
            // 
            this.textBloque.BackColor = System.Drawing.Color.White;
            this.textBloque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBloque.ForeColor = System.Drawing.Color.Red;
            this.textBloque.Location = new System.Drawing.Point(125, 59);
            this.textBloque.Name = "textBloque";
            this.textBloque.ReadOnly = true;
            this.textBloque.Size = new System.Drawing.Size(38, 20);
            this.textBloque.TabIndex = 12;
            this.textBloque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Principal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(631, 574);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panellogin);
            this.Controls.Add(this.panelConfiguracao);
            this.Controls.Add(this.Iniciar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Comenta Insta";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelConfiguracao.ResumeLayout(false);
            this.panelConfiguracao.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panellogin.ResumeLayout(false);
            this.panellogin.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
         
        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {
          
        }

        #endregion

        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Panel panelConfiguracao;
        private System.Windows.Forms.TextBox textContOK;
        private System.Windows.Forms.TextBox textFalhas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textComentario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextTempoComent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textRecomentar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBloque;
    }
}

