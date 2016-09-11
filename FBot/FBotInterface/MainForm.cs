using System;
using System.Windows.Forms;
using FBot;
using FBotInterface.secondaryForms;
using System.Resources;
using System.Globalization;
using System.Threading;
using Microsoft.Win32;
using System.Reflection;

namespace FBotInterface
{
    public partial class MainForm : Form
    {
        Fbot fb;

        string strCulture;

        private static ResourceManager rm;
        public static ResourceManager RM
        {
            get
            {
                return rm;
            }
        }


        #region forms declarations

        LogInFrm login;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.accountToolStripMenuItem.Text = MainForm.RM.GetString("0000");

            strCulture = "en-EN";

            SetCulture();
            SetResource();
        }

        private void LogIn()
        {
            login = new LogInFrm();
            login.ShowDialog();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #region language

        private void SetCulture()
        {
            CultureInfo objCI = new CultureInfo(strCulture);
            Thread.CurrentThread.CurrentCulture = objCI;
            Thread.CurrentThread.CurrentUICulture = objCI;
        }

        private void SetResource()
        {
            rm = ResourceManager.CreateFileBasedResourceManager("resource", Application.StartupPath + @"\languagepacks", null);
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rm.GetString("0002"));
        }
    }
}
