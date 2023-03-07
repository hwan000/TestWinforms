using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dummyproj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int text1 = 0;
        int text2 = 0;
        int plusText;

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            


            plusText = text1 + text2;

            labelControl1.Text = plusText.ToString();

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            text1 = int.Parse(textEdit1.Text);

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            text2 = int.Parse(textEdit2.Text);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 showForm2 = new Form2();
            showForm2.ShowDialog();
        }

    }
}
