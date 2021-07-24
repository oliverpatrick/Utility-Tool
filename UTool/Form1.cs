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
    public partial class UToolForm : Form
    {
        public UToolForm()
        {
            InitializeComponent();
        }

        FormMethods formMethods = new FormMethods();
        OperatingSystemInfo systemInfo = new OperatingSystemInfo();

        private Form activeForm = null;
        private void openChildFrom(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelView.Controls.Add(childForm);
            panelView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCleanManager_Click(object sender, EventArgs e)
        {
            formMethods.CommandPromptArguments("cleanmgr");
        }

        private void btnPrefetch_Click(object sender, EventArgs e)
        {
            formMethods.CommandPromptArguments(@"del C:\Windows\prefetch\*.*/s/q");
            MessageBox.Show("Prefetch Deleted");
        }

        private void btnDeleteCacheMemory_Click(object sender, EventArgs e)
        {
            formMethods.CommandPromptArguments("ipconfig/flushDNS");
            MessageBox.Show("Cache Deleted");

        }

        private void btnDefrag_Click(object sender, EventArgs e)
        {
            openChildFrom(new Form2());
        }

        private void btnDeleteTempFiles_Click(object sender, EventArgs e)
        {
            formMethods.CommandPromptArguments(@"del /q/f/s %TEMP%*");
            MessageBox.Show("Temp Files Deleted");

        }

        private void btnComputerDetails_Click(object sender, EventArgs e)
        {
            string computerDetails = systemInfo.GetOperatingSystemInfo();
            MessageBox.Show(computerDetails);
        }

        private void btnPreformanceInfo_Click(object sender, EventArgs e)
        {
            string preformanceInfo = systemInfo.GetProcessorInfo();
            MessageBox.Show(preformanceInfo);
        }
    }
}
