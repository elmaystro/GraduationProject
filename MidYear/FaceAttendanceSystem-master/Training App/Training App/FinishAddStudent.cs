﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraCapture
{
    public partial class FinishAddStudent : Form
    {
        String courseName_ = "";
        public FinishAddStudent(String courseName)
        {
            InitializeComponent();
            courseName_ = courseName; //set courseName
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_student form = new New_student();
            form.Tag = this;
            form.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrainData fr = new TrainData(courseName_);
            fr.Tag = this;
            fr.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}