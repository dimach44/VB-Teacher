using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VBTeacher {

    public partial class frmMain : Form {

        private TreeNode m_selectedNode = null;
        
        public frmMain() {

            frmSplash l_splash = new frmSplash();
            l_splash.ShowDialog();

            InitializeComponent();
            generateTreeviewNodes();
            treDirectory.SelectedNode = treDirectory.TopNode;
        }

        /*
         * Generates tree nodes based on the root.xml file
         */
        private void generateTreeviewNodes() {
           
            XmlDocument l_xmlDoc = new XmlDocument();
            l_xmlDoc.Load(@"data/root.xml");

            XmlNodeList l_tutorals = l_xmlDoc.GetElementsByTagName("Tutorial");
            for (int i = 0; i <= l_tutorals.Count - 1; i++) {
               
                TreeNode l_rootNode = new TreeNode();
                //l_rootNode.NodeFont = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
                l_rootNode.Text = l_tutorals[i].Attributes["Title"].Value;
                
                for (int j = 0; j < l_tutorals[i].ChildNodes.Count; j++) {
                   
                    TreeNode l_childNode = new TreeNode();
                    l_childNode.NodeFont = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
                    l_childNode.Text = l_tutorals[i].ChildNodes.Item(j).InnerXml;
                    l_rootNode.Nodes.Add(l_childNode);
                }

                if (i == 0)
                    l_rootNode.Expand();

                treDirectory.Nodes.Add(l_rootNode);
            }
        }

        private void btnBack_Click(object sender, EventArgs e) {

            if (m_selectedNode.PrevNode != null) {

                TreeNode l_nextNode = m_selectedNode.PrevNode;
                treDirectory.SelectedNode = l_nextNode;
                m_selectedNode = l_nextNode;
                updateScene();
            }
        }

        private void btnNext_Click(object sender, EventArgs e) {
            
            if (m_selectedNode.Parent != null) {

                if (m_selectedNode.NextNode != null) {

                    TreeNode l_nextNode = m_selectedNode.NextNode;
                    treDirectory.SelectedNode = l_nextNode;
                    m_selectedNode = l_nextNode;
                    updateScene();

                }

            } else {

                TreeNode l_nextNode = m_selectedNode.FirstNode;
                m_selectedNode = l_nextNode;
                treDirectory.SelectedNode = l_nextNode;
                updateScene();
            } 
        }

        /*
         * Loads image files or pops a question dialog based on the selected node in the treeview 
         */
        private void treDirectory_AfterSelect(object sender, TreeViewEventArgs e)  {
            updateScene();
        }

        private void updateScene() {
            
            m_selectedNode = treDirectory.SelectedNode;
            m_selectedNode.Expand();
            if (m_selectedNode.FirstNode != null) {
                m_selectedNode = m_selectedNode.FirstNode;
            }
            if (m_selectedNode.Text.CompareTo("Questions") != 0) {
                m_selectedNode.ForeColor = Color.Purple;

                if (m_selectedNode.Parent != null) {

                    Image l_currImage;
                    String l_strRoot = m_selectedNode.Parent.Text;

                    try {

                        l_currImage = Image.FromFile(@"data\slides\" + l_strRoot + @"\" + l_strRoot + m_selectedNode.Index + @".png");

                    } catch (Exception ex) {

                        MessageBox.Show(@"data\slides\" + l_strRoot + m_selectedNode.Index + ".png \n" + ex.ToString());
                        Console.WriteLine(ex.ToString());
                        l_currImage = null;
                    }

                    if (l_currImage != null) pbSlideView.Image = l_currImage;

                } else {

                    if (m_selectedNode.Parent == null) {
                        m_selectedNode.ForeColor = Color.Black;
                        if (m_selectedNode.PrevNode != null) {
                            m_selectedNode.PrevNode.ForeColor = Color.Purple;
                        }
                    }
                }
            } else {

                if (m_selectedNode.Parent != null) {
                    frmQuestions questionsDlg = new frmQuestions(m_selectedNode.Parent.Text);
                    questionsDlg.ShowDialog();
                    m_selectedNode.ForeColor = Color.Purple;
                    m_selectedNode.Parent.ForeColor = Color.Purple;
                    m_selectedNode.Parent.Collapse();
                    treDirectory.SelectedNode = m_selectedNode.NextVisibleNode;
                }
            } 
        }

        private void frmMain_Load(object sender, EventArgs e) {}

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e) {
            frmHelp l_help = new frmHelp();
            l_help.ShowDialog();
        }

        private void btnWorkPad_Click(object sender, EventArgs e) {
            frmCodePad l_pad = new frmCodePad();
            l_pad.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e) {
            
            //treDirectory.SelectedNode = treDirectory.Nodes[7].Nodes[0];       
            foreach (TreeNode n in treDirectory.Nodes) {
               
                if (n.Parent == null) {
                    if (n.Text.CompareTo("Help") == 0) {

                        n.Expand();

                        m_selectedNode = n.FirstNode;
                        treDirectory.SelectedNode = n.FirstNode;

                        updateScene();
                    }
                }
            }
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e) {
            frmAbout l_about = new frmAbout();
            l_about.ShowDialog();
        }
    }
}
