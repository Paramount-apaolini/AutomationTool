using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseAutomationFramework.PageObjects.Encompass;
using NUnit.Framework;
using System.Threading;
using BaseAutomationFramework.PageObjects;
using BaseAutomationFramework.PageObjects.EncompassLoanCenter;
using System;
using BaseAutomationFramework.Tests.Encompass.EnvironmentLogin;

namespace BaseAutomationFramework.Tests.Encompass.TicketTesting.Tonys
{


    [TestFixture]
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
            {
                    {"tpaolini", "Paramount2"},
            };
            LaunchAndLogin_2_STAGE launchAndLogin_2_STAGE = new LaunchAndLogin_2_STAGE();
            launchAndLogin_2_STAGE.UserLogin(keyValuePairs);
        }
    }
}

