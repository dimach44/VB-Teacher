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

    public partial class frmResults : Form {

        public frmResults(double l_correct, double l_incorrect, double l_totalQuestions) {

            InitializeComponent();
            lblTotal.Text = (String)Convert.ToString((l_correct / l_totalQuestions) * 100) + @"%";
            lblCorrect.Text = "Correct: " + l_correct;
            lblIncorrect.Text = "Incorrect: " + l_incorrect;
        }

        private void btnContinue_Click(object sender, EventArgs e) {
            this.Close();
            //m_retry = false;
        }

        private void btnRetry_Click(object sender, EventArgs e) {
            //m_retry = true;
        }

        private void frmResults_Load(object sender, EventArgs e) {

        }
    }
}
