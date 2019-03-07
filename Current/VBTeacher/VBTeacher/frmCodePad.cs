using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBTeacher {

    public partial class frmCodePad : Form {
        public frmCodePad() {
            InitializeComponent();
        }

        private void btnRun_Click_1(object sender, EventArgs e) {
           
            if (txtSrc.Text.CompareTo("carlton") == 0) {

                frmTest l_test = new frmTest();
                l_test.ShowDialog();

            } else {

                System.IO.File.WriteAllText(@"data/code/src.txt", txtSrc.Text);

                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = @"VBCompiler.exe";
                startInfo.Arguments = @"-r data\code\src.txt";
                System.Diagnostics.Process.Start(startInfo);
            }
        }
    }
}
