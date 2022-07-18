using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System.IO;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Threading;
using System.Media;

namespace IkeaMon
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();

            // show program status
            txt_console.Text = DateTime.Now + " > Ready to run!";
        }

              
        // logger
        private void logekle(string log)
        {
            Debug.WriteLine(log);
            this.Invoke(new MethodInvoker(delegate { txt_console.Text += log; txt_console.ScrollToCaret(); }));
        }

        // main "brain"
        private void btn_run_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> lst_user = new Dictionary<string, int>();

            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--start-maximized");
            options.AddExcludedArgument("enable-automation");

            IWebDriver driver = new ChromeDriver(options);

            var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(Timeout.Infinite));

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            driver.Navigate().GoToUrl(@"https://ikea.com/ru/ru");

            // pause 2 s
            Thread.Sleep(2000);

            bool flag = true;

            Int32 counter = 0;
            string name1 = "";

            // cycle...
            while (flag)
            {
                try
                {
                    counter++; 
                    name1 = wait.Until(drv => drv.FindElement(By.XPath("//h1"))).Text;
                }
                catch 
                {
                    name1 = ""; 
                }

                logekle("name: " + name1);
                txt_console.Text = counter.ToString() + " :  " + name1;

                // pause 2 s
                Thread.Sleep(2000);

                if (name1 != "Вы находитесь на странице ожидания для перехода на IKEA.ru. Не обновляйте страницу, чтобы сохранить свое место в очереди. Ожидание зависит от количества пользователей на сайте и может занять как несколько минут, так и более часа. Обратите внимание, что время вашего пребывания на сайте будет ограничено – через 10-15 минут система может вернуть вас обратно в очередь. Личный кабинет и список покупок на сайте не доступны – добавляйте товары непосредственно в корзину.")
                {
                    flag = false;

                    // System sound named "Beep" . I use it as simplest alert  =)
                    SystemSounds.Beep.Play();

                    txt_console.Text = counter.ToString() + " :  Event handled =)";
                }

            }//while...

        }//btn_run_Click

    }

}
