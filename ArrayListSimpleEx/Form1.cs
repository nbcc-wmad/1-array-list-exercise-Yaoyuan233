using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {

        ArrayList exercise = new ArrayList();


        public Form1()
        {
            InitializeComponent();

        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            for(int i = 0; i < exercise.Count; i++)
            {
                lblMessage.Text = lblMessage.Text + exercise[i].ToString()+" ";
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            exercise.Reverse();
            lblMessage.Text = string.Empty;
            for (int i = 0; i < exercise.Count; i++)
            {
                lblMessage.Text = lblMessage.Text + exercise[i].ToString() + " ";
            }
            exercise.Reverse();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            exercise.Insert(1,txtSecondPos.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exercise.RemoveAt(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exercise.Add("I");
            exercise.Add("Love");
            exercise.Add("Programming");
            exercise.Add("So");
            exercise.Add("Much");
        }
    }
}
