﻿namespace MaintainStudentScores;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        lblStudents = new System.Windows.Forms.Label();
        btnAddNew = new System.Windows.Forms.Button();
        btnDeleteStudent = new System.Windows.Forms.Button();
        btnUpdateStudent = new System.Windows.Forms.Button();
        btnExit = new System.Windows.Forms.Button();
        txtStudentAVG = new System.Windows.Forms.TextBox();
        lblAverage = new System.Windows.Forms.Label();
        txtCount = new System.Windows.Forms.TextBox();
        lblCount = new System.Windows.Forms.Label();
        txtScoreTotal = new System.Windows.Forms.TextBox();
        lblTotal = new System.Windows.Forms.Label();
        lstStudents = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // lblStudents
        // 
        lblStudents.Location = new System.Drawing.Point(13, 11);
        lblStudents.Name = "lblStudents";
        lblStudents.Size = new System.Drawing.Size(100, 23);
        lblStudents.TabIndex = 0;
        lblStudents.Text = "Students";
        // 
        // btnAddNew
        // 
        btnAddNew.Location = new System.Drawing.Point(294, 34);
        btnAddNew.Name = "btnAddNew";
        btnAddNew.Size = new System.Drawing.Size(75, 23);
        btnAddNew.TabIndex = 2;
        btnAddNew.Text = "&Add New";
        btnAddNew.UseVisualStyleBackColor = true;
        btnAddNew.Click += btnAddNew_Click;
        // 
        // btnDeleteStudent
        // 
        btnDeleteStudent.Location = new System.Drawing.Point(294, 90);
        btnDeleteStudent.Name = "btnDeleteStudent";
        btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
        btnDeleteStudent.TabIndex = 4;
        btnDeleteStudent.Text = "&Delete";
        btnDeleteStudent.UseVisualStyleBackColor = true;
        btnDeleteStudent.Click += btnDeleteStudent_Click;
        // 
        // btnUpdateStudent
        // 
        btnUpdateStudent.Location = new System.Drawing.Point(294, 63);
        btnUpdateStudent.Name = "btnUpdateStudent";
        btnUpdateStudent.Size = new System.Drawing.Size(75, 23);
        btnUpdateStudent.TabIndex = 3;
        btnUpdateStudent.Text = "&Update";
        btnUpdateStudent.UseVisualStyleBackColor = true;
        btnUpdateStudent.Click += btnUpdateStudent_Click;
        // 
        // btnExit
        // 
        btnExit.Location = new System.Drawing.Point(294, 189);
        btnExit.Name = "btnExit";
        btnExit.Size = new System.Drawing.Size(75, 23);
        btnExit.TabIndex = 5;
        btnExit.Text = "E&xit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // txtStudentAVG
        // 
        txtStudentAVG.Location = new System.Drawing.Point(220, 189);
        txtStudentAVG.Name = "txtStudentAVG";
        txtStudentAVG.ReadOnly = true;
        txtStudentAVG.Size = new System.Drawing.Size(57, 23);
        txtStudentAVG.TabIndex = 11;
        txtStudentAVG.TabStop = false;
        // 
        // lblAverage
        // 
        lblAverage.Location = new System.Drawing.Point(150, 189);
        lblAverage.Name = "lblAverage";
        lblAverage.Size = new System.Drawing.Size(64, 23);
        lblAverage.TabIndex = 10;
        lblAverage.Text = "Average:";
        // 
        // txtCount
        // 
        txtCount.Location = new System.Drawing.Point(220, 160);
        txtCount.Name = "txtCount";
        txtCount.ReadOnly = true;
        txtCount.Size = new System.Drawing.Size(57, 23);
        txtCount.TabIndex = 9;
        txtCount.TabStop = false;
        // 
        // lblCount
        // 
        lblCount.Location = new System.Drawing.Point(135, 160);
        lblCount.Name = "lblCount";
        lblCount.Size = new System.Drawing.Size(79, 23);
        lblCount.TabIndex = 8;
        lblCount.Text = "Score Count:";
        // 
        // txtScoreTotal
        // 
        txtScoreTotal.Location = new System.Drawing.Point(220, 131);
        txtScoreTotal.Name = "txtScoreTotal";
        txtScoreTotal.ReadOnly = true;
        txtScoreTotal.Size = new System.Drawing.Size(57, 23);
        txtScoreTotal.TabIndex = 7;
        txtScoreTotal.TabStop = false;
        // 
        // lblTotal
        // 
        lblTotal.Location = new System.Drawing.Point(135, 131);
        lblTotal.Name = "lblTotal";
        lblTotal.Size = new System.Drawing.Size(79, 23);
        lblTotal.TabIndex = 6;
        lblTotal.Text = "Score Total:";
        // 
        // lstStudents
        // 
        lstStudents.FormattingEnabled = true;
        lstStudents.Location = new System.Drawing.Point(13, 34);
        lstStudents.Name = "lstStudents";
        lstStudents.Size = new System.Drawing.Size(264, 79);
        lstStudents.TabIndex = 1;
        lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(378, 227);
        Controls.Add(lstStudents);
        Controls.Add(lblTotal);
        Controls.Add(txtScoreTotal);
        Controls.Add(lblCount);
        Controls.Add(txtCount);
        Controls.Add(lblAverage);
        Controls.Add(txtStudentAVG);
        Controls.Add(btnExit);
        Controls.Add(btnUpdateStudent);
        Controls.Add(btnDeleteStudent);
        Controls.Add(btnAddNew);
        Controls.Add(lblStudents);
        Text = "Student Scores";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ListBox lstStudents;

    private System.Windows.Forms.Label lblStudents;
    private System.Windows.Forms.Button btnAddNew;
    private System.Windows.Forms.Button btnDeleteStudent;
    private System.Windows.Forms.Button btnUpdateStudent;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.TextBox txtStudentAVG;
    private System.Windows.Forms.Label lblAverage;
    private System.Windows.Forms.TextBox txtCount;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.TextBox txtScoreTotal;
    private System.Windows.Forms.Label lblTotal;

    #endregion
}