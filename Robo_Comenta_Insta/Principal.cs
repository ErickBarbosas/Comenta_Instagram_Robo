using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Robo_Comenta_Insta.Navegador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robo_Comenta_Insta
{
    public  partial class Principal : Form
    {
        static int TempoComentario;
        static int TempoRementario;
        static int ComentarioFeito;
        static int ComentarioFalha;
        static int ContBloqueio;
        static bool Curtir;


        static string Login;
        static string Senha;
        static string UrlPost;
        static string[] separadorComentario;

        Thread execComentar = new Thread(ExecultarComentario);


        protected IWebDriver Driver;

        public Principal()
        {
            InitializeComponent();
            CarregaContadores();
        }
        public void setcurtir()
        {

            
            Curtir = radioButton1.Checked;

        }

        public static void setContaBloqueio()
        {


            ContBloqueio++;

        }

        public static void setContaComentarioFalha()
        {
            

            ComentarioFalha++;

        }

        public static void setContaComentarioFeito()
        {
            

            ComentarioFeito ++;
            
        }
        public void setTempoComentarios()
        {
            int tempo = System.Convert.ToInt32(TextTempoComent.Text+"000");

            TempoComentario = tempo;


        }
        public int getTempoComentarios()
        {


            return TempoComentario;


        }
        public void setRecomentar()
        {
            int tempo = System.Convert.ToInt32(textRecomentar.Text + "000");

            TempoRementario = tempo;


        }


        public static int getRecomentar()
        {


            return TempoRementario;


        }
        public  void  setUrlPost()
        { 
           UrlPost = textUrl.Text;
            
        }
        public  void setLogin()
        {
           Login = textLogin.Text;
        }
        public void setSenha()
        {
           Senha = textSenha.Text;
        }
       

            public void Desativarpainel()
        {        
            panellogin.Enabled = false;
            panelConfiguracao.Enabled = false;
            Iniciar.Enabled = false;
            Iniciar.Enabled = false;
            btnParar.Enabled = true;
        }
        public void Ativarpainel()
        {
            Iniciar.Enabled = true;
            btnParar.Enabled = false;
            panellogin.Enabled = true;
            panelConfiguracao.Enabled = true;
            Iniciar.Enabled = true;

        }

        public void CarregaContadores()
        {
            AcaoNavegador Nav = new AcaoNavegador();
           

            textContOK.Text = Convert.ToString( ComentarioFeito);
            textFalhas.Text = Convert.ToString( ComentarioFalha );
            textBloque.Text = Convert.ToString(ContBloqueio);
            textBloque.Refresh();
            textContOK.Refresh();
            textFalhas.Refresh();
        }
        




       public void setComentario()
        {
          separadorComentario  = textComentario.Text.Split(',');
            
        }
        public void setUrl()
        {
            separadorComentario = textComentario.Text.Split(',');

        }
        public static string getComentario(int ordem)
        {
            return separadorComentario[ordem];
        }


       

        private void TextTempoComent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {

                e.Handled = true;
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            
            Ativarpainel();
            execComentar.Suspend();
            CarregaContadores();
        }





        public void CarregaDados()
        {

            setRecomentar(); ;
            setTempoComentarios();
            setComentario();
            Desativarpainel();
            setUrlPost();
            setLogin();
            setSenha();
            CarregaContadores();
            setcurtir();
        }


        public string ValidarDados()
        {
            string msg="";

            if (textComentario.Text=="")
            {
                msg = " 'Comentario' ";
            }
            if (textLogin.Text == "")
            {
                msg = msg +" 'Login' ";
            }
            if (textSenha.Text == "")
            {
                msg = msg + " 'Senha' ";
            }
            if (textUrl.Text == "")
            {
                msg = msg + " 'URL' ";
            }
            if (textRecomentar.Text == "")
            {
                msg = msg + " 'Tempo Recomentar' ";
            }
            if (TextTempoComent.Text == "")
            {
                msg = msg + " 'Tempo Comentario' ";
            }


            return msg;
          
        }

       

        //teste
        private void Iniciar_Click(object sender, EventArgs e)
        {
            string msg = ValidarDados();

            if (msg == "")
            {
                MessageBox.Show("Robo Iniciado Com Sucesso!!!","Comenta Insta");
                Desativarpainel();
                CarregaDados();
                execComentar.Start();
            }
            else
            {
                MessageBox.Show("PorFavor Preencha Os Campos em Branco:\n\n (" + msg + ")","Comenta Insta" );
            }
            

        }


    


       
        public static void ExecultarComentario()
        {

            AcaoNavegador Nav = new AcaoNavegador();
            Principal principal = new Principal();

            int i = 0;
            int bloqueio = 0;
            int j=0 ;

          
            while (true)
            {

                try
                {

                    Nav.AbrirPost(UrlPost);

                    Nav.logarUser(Login, Senha);
                    
                    while (i < separadorComentario.Length)
                    {


                        if (Nav.VerificarBloqueio())
                        {

                            Nav.ComentarPost(separadorComentario[i]);
                            
                            if(Curtir)
                            { Nav.CurtirPost();}
                              
                            setContaComentarioFeito();

                            
                        }
                        else
                        {
                             bloqueio = bloqueio + 1200000;
                            setContaBloqueio();
                            Nav.FecharNavegados();
                            Thread.Sleep(bloqueio);
                            Nav.AbrirPost(UrlPost);
                            Nav.logarUser(Login, Senha);


                        }



                        i++;


                    }

                    i = 0;
                    Nav.FecharNavegados();



                }
                catch (Exception e)
                {
                    setContaComentarioFalha();
                  
                 
                }

               ;
                Thread.Sleep(getRecomentar());

               
                
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }


}

