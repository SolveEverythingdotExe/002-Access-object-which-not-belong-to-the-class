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
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //do the work
            try
            {
                //temporary work
                System.Threading.Thread.Sleep(500);
            }
            finally
            {
                MainForm.UpdateProgressBar(100);
            }
        }
    }
}
