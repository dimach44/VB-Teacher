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

//This is where the magic happens
namespace VBTeacher {

    public partial class frmQuestions : Form {

        struct Question {

            public String m_title;
            public String m_ans0;
            public String m_ans1;
            public String m_ans2;
            public String m_ans3;
            public int m_correctAns;
        }


        private Queue<Question> m_questions = new Queue<Question>();
        private String m_path;
        private int m_correct = 0;
        private int m_incorrect = 0;
        private int m_currentAns = 0;
        private int m_totalQuestions = 0;
        private int m_currIndex = 0;
        private bool m_answered = false;

        public frmQuestions(String l_path) {
            //figure out the right xml file to load
            m_path = @"data/questions/" + l_path + ".xml";
            InitializeComponent();
            setup();
        }

        //Loads questions from the specified xml file and quenes them up
        private void setup() {

            XmlDocument l_xmlDoc = new XmlDocument();
            l_xmlDoc.Load(m_path);

            XmlNodeList l_questionNodes = l_xmlDoc.GetElementsByTagName("Question");
            for (int i = 0; i <= l_questionNodes.Count - 1; i++) {
              
                Question l_temp = new Question();
               
                l_temp.m_title = l_questionNodes[i].ChildNodes.Item(0).InnerXml;
                l_temp.m_ans0 = l_questionNodes[i].ChildNodes.Item(1).InnerXml;
                l_temp.m_ans1 = l_questionNodes[i].ChildNodes.Item(2).InnerXml;
                l_temp.m_ans2 = l_questionNodes[i].ChildNodes.Item(3).InnerXml;
                l_temp.m_ans3 = l_questionNodes[i].ChildNodes.Item(4).InnerXml;
                l_temp.m_correctAns = (int) Convert.ToInt32(l_questionNodes[i].ChildNodes.Item(5).InnerXml);

                m_questions.Enqueue(l_temp);
            }

            m_totalQuestions = l_questionNodes.Count;
            next();
        }

        //Goes to the next question in the quene and updates the controls
        private void next() {

            if (m_questions.Count > 0) {
                Question l_temp = m_questions.Dequeue();

                lblQuestion.Text = l_temp.m_title;
                rbtnAns0.Text = l_temp.m_ans0;
                rbtnAns1.Text = l_temp.m_ans1;
                rbtnAns2.Text = l_temp.m_ans2;
                rbtnAns3.Text = l_temp.m_ans3;
                m_currentAns = l_temp.m_correctAns;

                rbtnAns0.Checked = true;
                m_answered = false;
            }
        }

        //returns an index based on the selected radio button checked
        private short getSelectedAnswerIndex() {
            
            if (rbtnAns0.Checked)
                return 0;
            else if (rbtnAns1.Checked)
                return 1;
            else if (rbtnAns2.Checked)
                return 2;
            else if (rbtnAns3.Checked)
                return 3;
            else
                return -1;
        }

        //checks to see if an answer is correct 
        private void btnSubmit_Click(object sender, EventArgs e) {

            if (getSelectedAnswerIndex() == m_currentAns) {
                frmCorrect frc = new frmCorrect();
                frc.ShowDialog();
                if (!m_answered) m_correct++;
                m_currIndex++;
                next();
            }  else {
                MessageBox.Show("Sorry try again!");
                if (!m_answered) m_incorrect++;
                m_answered = true;
            }

            if (m_currIndex >= m_totalQuestions) {
                frmResults l_results = new frmResults(m_correct, m_incorrect, m_totalQuestions);
                l_results.ShowDialog();
                this.Close();
            }
        }

        private void btnRun_Click(object sender, EventArgs e) {

            System.IO.File.WriteAllText(@"data/code/src.txt", txtSrc.Text);

            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = @"VBCompiler.exe";
            startInfo.Arguments = @"-r data\code\src.txt";
            System.Diagnostics.Process.Start(startInfo);
        }

        private void frmQuestions_Load(object sender, EventArgs e) {

        }

        private void lblQuestion_Click(object sender, EventArgs e) {

        }

        private void btnHelpMe_Click(object sender, EventArgs e) {
           
            frmHelp l_help = new frmHelp();
            l_help.ShowDialog();
        }
    }
}
