namespace Gonio_Cabalo
{
    partial class frmAddEditStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOK = new Button();
            label1 = new Label();
            txtStudentID = new TextBox();
            label3 = new Label();
            txtFullName = new TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(306, 64);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Student ID:";
            label1.Click += label1_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(96, 6);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(130, 23);
            txtStudentID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 38);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Full name:";
            label3.Click += label3_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(96, 35);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(296, 23);
            txtFullName.TabIndex = 5;
            // 
            // frmAddEditStudent
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 99);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(txtStudentID);
            Controls.Add(label1);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddEditStudent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit";
            Load += frmAddEditStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Label label1;
        private TextBox txtStudentID;
        private Label label3;
        private TextBox txtFullName;
    }
}