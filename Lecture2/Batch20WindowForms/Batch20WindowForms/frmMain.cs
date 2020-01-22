using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batch20WindowForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void sampleFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sampleForm = new frmSample();
            sampleForm.MdiParent = this;
            sampleForm.Show();
        }
    }
}
