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

    public partial class frmHelp : Form {
        
        public frmHelp() {
            InitializeComponent();
            getFiles();
        }


        private void getFiles() {

            string[] fileEntries = System.IO.Directory.GetFiles(@"data\help");
            foreach (string s in fileEntries) {
                lstFiles.Items.Add(System.IO.Path.GetFileNameWithoutExtension(s));
            }

            if (lstFiles.Items.Count > 0) {
                lstFiles.SetSelected(0, true);
                updateSelectionInfo();
            }
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e) {

            updateSelectionInfo();
        }

        private void updateSelectionInfo() {
           
            string l_title = lstFiles.SelectedItem.ToString();
            lblTitle.Text = l_title;

            string[] l_readText = System.IO.File.ReadAllLines(@"data\help\" + lstFiles.SelectedItem + ".txt");

            txtContent.Text = "";
            foreach (string s in l_readText) {

                string l_temp = s;
                l_temp += "\r\n";

                txtContent.Text += l_temp;
            }
        }

        private void frmHelp_Load(object sender, EventArgs e) {

        }
    }
}
