using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Access_object_not_belong_to_class
{
    public partial class MainForm : Form
    {
        //static object or single instance object
        public static ToolStripProgressBar MainProgressBar;

        public MainForm()
        {
            InitializeComponent();
            //set the value
            MainProgressBar = toolStripProgressBar1;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm();

            childForm.MdiParent = this;
            childForm.Show();
            childForm.Location = new Point(0, 0);
        }

        //method to update the progressbar
        public static void UpdateProgressBar(int value)
        {
            //defensive programming
            //we should only allow appropriate values
            if (MainProgressBar != null && value >= 1 && value <= 100)
            {
                MainProgressBar.Value = value;
                MainProgressBar.PerformStep();
            }
        }
    }
}
