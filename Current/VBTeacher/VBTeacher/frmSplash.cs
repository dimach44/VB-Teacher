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
    public partial class frmSplash : Form {

        int m_countdown = 2;

        public frmSplash() {
            InitializeComponent();
       
        }

        private void tmrCounter_Tick(object sender, EventArgs e) {
            
            if (m_countdown > 0)
                m_countdown--;
            else
                this.Close();

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e) {
            this.Close();
        }
    }
}
