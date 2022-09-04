using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVEPIPlan
{
    public partial class PIInfo : Form
    {
        private MainForm mainForm;
        public PIInfo(MainForm _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void PIInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.UpdatePIList();
        }
    }
}
