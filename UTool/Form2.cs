using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTool
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        FormMethods formMethods = new FormMethods();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCDrive_Click(object sender, EventArgs e)
        {
            formMethods.CommandPromptArguments("Defrag C: /D /M");
        }

        private void btnDDrive_Click(object sender, EventArgs e)
        {
            formMethods.CommandPromptArguments("Defrag D: /D /M");
        }

        private void btnEDrive_Click(object sender, EventArgs e)
        {
            formMethods.CommandPromptArguments("Defrag E: /D /M");
        }

        private void btnFDrive_Click(object sender, EventArgs e)
        {
            formMethods.CommandPromptArguments("Defrag F: /D /M");
        }
    }
}
