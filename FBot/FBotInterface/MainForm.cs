using System;
using System.Windows.Forms;
using FBot;
using FBotInterface.secondaryForms;

namespace FBotInterface
{
    public partial class MainForm : Form
    {
        Fbot fb;

        #region forms declarations

        LogInFrm login;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LogIn()
        {
            login = new LogInFrm();
            login.ShowDialog();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
