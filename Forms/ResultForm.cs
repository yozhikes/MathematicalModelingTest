﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathematicalModelingTestByMidili.Forms
{
    public partial class ResultForm : Form
    {
        public ResultForm(int wrong,int right)
        {
            InitializeComponent();
            wrongLbl.Text += wrong.ToString();
            rightLbl.Text += right.ToString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
