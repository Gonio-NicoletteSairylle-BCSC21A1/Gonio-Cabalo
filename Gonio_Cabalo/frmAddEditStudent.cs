﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gonio_Cabalo
{
    public partial class frmAddEditStudent : Form
    {
        public Student StudentInfo { get; set;}
        public frmAddEditStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAddEditStudent_Load(object sender, EventArgs e)
        {
            if (StudentInfo != null)
            {
                txtStudentID.Text = StudentInfo.ID;
                txtFullName.Text = StudentInfo.FullName;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StudentInfo.ID = txtStudentID.Text;
            StudentInfo.FullName = txtFullName.Text;
        }
    }
}
