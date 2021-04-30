using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robo_Comenta_Insta.Navegador
{
    class AcaoNavegador
    {
        private static int Falhas = 0;
        private static int Feitas = 0;
     
        private static IWebDriver Driver;
        protected By form = By.Id("react-root");
        

        public void Fazerlogin(string login, string senha)
        {
            try
            {

            //Clicando no botão Entrar
            Driver.FindElement(By.CssSelector("button[type='button']")).Click();
            //Digitando Login 
            Driver.FindElement(By.CssSelector("input[name='username']")).SendKeys(login);
            //Digitando A senha
            Driver.FindElement(By.CssSelector("input[name='password']")).SendKeys(senha);
            //Clicando botão entrar
            Driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            //
            Driver.FindElement(By.XPath("//button[text()='Agora não']")).Click();

            }
            catch { }

        }
        //public void Login(string login)
        //{
        //    Driver.FindElement(By.CssSelector("input[name='username']")).SendKeys(login);
            
        //}

        //public void Senha(string senha)
        //{
        //    Driver.FindElement(By.CssSelector("input[name='password']")).SendKeys(senha);


        //}


        //public void ClickLogar()
        //{
        //    Driver.FindElement(By.CssSelector("button[type='submit']")).Click(); ;


        //}
        public void AbrirPost(string post)
        {
            try
            {   //Local Do Chrome Driver
                Driver = new ChromeDriver("C:/Projetos/Robo_Comenta_Insta/Comenta_Instagram_Robo/Robo_Comenta_Insta/Webdriver");
                //Abrindo o post
                Driver.Navigate().GoToUrl(post);
                Thread.Sleep(10000);
            }
            catch (Exception e)
            {
                //MessageBox.Show("Erro ao Tentar Encontar o Post: \n\n"+e);

            }
        }

     

        //public void logarUser(string user, string password)
        //{

        //    try
        //    {
        //        ClickPaginaLogin();
        //        Thread.Sleep(10000);

        //        Login(user);

        //        Senha(password);
                

        //        ClickLogar();
        //        Thread.Sleep(10000);

        //       ClickResposta();
        //        Thread.Sleep(10000);

               
        //    }
        //    catch (Exception e)
        //    {
        //        // MessageBox.Show("Erro ao Tentar Logar: \n\n" + e);

               
        //    }


        //}
        

        public void setContaFalhas()
        {
            Falhas++;
        }
        public void setContaFeitas()
        {
            Feitas++;
        }
        public string getContaFalhas()
        {
            return System.Convert.ToString( Falhas);
        }
        public string getContaFeitas()
        {
            return System.Convert.ToString( Feitas);
        }




       

        public void ClickPaginaLogin()
        {
            Driver.FindElement(By.CssSelector("button[type='button']")).Click();



        }
        public void ClickResposta()
        {
            try
            {
                Driver.FindElement(By.XPath("//button[text()='Agora não']")).Click();
            }
            catch { }
            



        }


        public void CurtirPost()
        {
            
            try
            {
                Thread.Sleep(3000);
                Driver.FindElement(By.CssSelector("svg[aria-label='Curtir']")).Click(); ;
            }
            catch (Exception e)
            {
               // MessageBox.Show("Erro ao Tentar Localizar o Botão de Curtida: \n\n" + e); 
            }
        }

        public void ComentarPost(string comentario)
        {
            try
            {
              
                Driver.FindElement(By.CssSelector("textarea[placeholder='Adicione um comentário...']")).Click();
                Thread.Sleep(1000);
                Driver.FindElement(By.CssSelector("textarea[placeholder='Adicione um comentário...']")).SendKeys(comentario);
                Driver.FindElement(By.CssSelector("button[type='submit']")).Click();
                Thread.Sleep(1000);

            }
            catch(Exception e)
            {
               // MessageBox.Show("Erro ao Tentar Fazer o Comentario: \n\n" + e);
            }
        }



        public void FecharNavegados()
        {

            if (Driver != null)
            { Driver.Quit(); }
        }



        public bool VerificarBloqueio()
        {
            bool a = false;
            
            try 
            {

                a =Driver.FindElement(By.CssSelector("textarea[placeholder='Adicione um comentário...']")).Enabled;

                return a;
            }
            catch 
            {
                return a;
            }


        }
      

    }
}
