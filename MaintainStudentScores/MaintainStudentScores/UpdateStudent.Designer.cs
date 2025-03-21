﻿using System.ComponentModel;

namespace MaintainStudentScores;

partial class UpdateStudent
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        lblUpdateName = new System.Windows.Forms.Label();
        txtUpdateName = new System.Windows.Forms.TextBox();
        lblUpdateScores = new System.Windows.Forms.Label();
        lstUpdateScores = new System.Windows.Forms.ListBox();
        btnUpdateAdd = new System.Windows.Forms.Button();
        btnUpdateScore = new System.Windows.Forms.Button();
        btnUpdateRemove = new System.Windows.Forms.Button();
        btnUpdateClear = new System.Windows.Forms.Button();
        btnUpdateCancel = new System.Windows.Forms.Button();
        btnUpdateOk = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblUpdateName
        // 
        lblUpdateName.Location = new System.Drawing.Point(27, 17);
        lblUpdateName.Name = "lblUpdateName";
        lblUpdateName.Size = new System.Drawing.Size(100, 23);
        lblUpdateName.TabIndex = 0;
        lblUpdateName.Text = "Name:";
        // 
        // txtUpdateName
        // 
        txtUpdateName.Location = new System.Drawing.Point(97, 17);
        txtUpdateName.Name = "txtUpdateName";
        txtUpdateName.ReadOnly = true;
        txtUpdateName.Size = new System.Drawing.Size(292, 23);
        txtUpdateName.TabIndex = 1;
        // 
        // lblUpdateScores
        // 
        lblUpdateScores.Location = new System.Drawing.Point(27, 61);
        lblUpdateScores.Name = "lblUpdateScores";
        lblUpdateScores.Size = new System.Drawing.Size(62, 23);
        lblUpdateScores.TabIndex = 2;
        lblUpdateScores.Text = "Scores:";
        // 
        // lstUpdateScores
        // 
        lstUpdateScores.FormattingEnabled = true;
        lstUpdateScores.Location = new System.Drawing.Point(95, 61);
        lstUpdateScores.Name = "lstUpdateScores";
        lstUpdateScores.Size = new System.Drawing.Size(189, 109);
        lstUpdateScores.TabIndex = 3;
        // 
        // btnUpdateAdd
        // 
        btnUpdateAdd.Location = new System.Drawing.Point(290, 61);
        btnUpdateAdd.Name = "btnUpdateAdd";
        btnUpdateAdd.Size = new System.Drawing.Size(99, 23);
        btnUpdateAdd.TabIndex = 4;
        btnUpdateAdd.Text = "&Add";
        btnUpdateAdd.UseVisualStyleBackColor = true;
        btnUpdateAdd.Click += btnUpdateAdd_Click;
        // 
        // btnUpdateScore
        // 
        btnUpdateScore.Location = new System.Drawing.Point(290, 90);
        btnUpdateScore.Name = "btnUpdateScore";
        btnUpdateScore.Size = new System.Drawing.Size(99, 23);
        btnUpdateScore.TabIndex = 5;
        btnUpdateScore.Text = "&Update";
        btnUpdateScore.UseVisualStyleBackColor = true;
        btnUpdateScore.Click += btnUpdateScore_Click;
        // 
        // btnUpdateRemove
        // 
        btnUpdateRemove.Location = new System.Drawing.Point(290, 119);
        btnUpdateRemove.Name = "btnUpdateRemove";
        btnUpdateRemove.Size = new System.Drawing.Size(99, 23);
        btnUpdateRemove.TabIndex = 6;
        btnUpdateRemove.Text = "&Remove";
        btnUpdateRemove.UseVisualStyleBackColor = true;
        btnUpdateRemove.Click += btnUpdateRemove_Click;
        // 
        // btnUpdateClear
        // 
        btnUpdateClear.Location = new System.Drawing.Point(290, 148);
        btnUpdateClear.Name = "btnUpdateClear";
        btnUpdateClear.Size = new System.Drawing.Size(99, 23);
        btnUpdateClear.TabIndex = 7;
        btnUpdateClear.Text = "Clear &Scores";
        btnUpdateClear.UseVisualStyleBackColor = true;
        btnUpdateClear.Click += btnUpdateClear_Click;
        // 
        // btnUpdateCancel
        // 
        btnUpdateCancel.Location = new System.Drawing.Point(290, 195);
        btnUpdateCancel.Name = "btnUpdateCancel";
        btnUpdateCancel.Size = new System.Drawing.Size(99, 23);
        btnUpdateCancel.TabIndex = 8;
        btnUpdateCancel.Text = "&Cancel";
        btnUpdateCancel.UseVisualStyleBackColor = true;
        btnUpdateCancel.Click += btnUpdateCancel_Click;
        // 
        // btnUpdateOk
        // 
        btnUpdateOk.Location = new System.Drawing.Point(185, 195);
        btnUpdateOk.Name = "btnUpdateOk";
        btnUpdateOk.Size = new System.Drawing.Size(99, 23);
        btnUpdateOk.TabIndex = 9;
        btnUpdateOk.Text = "&Ok";
        btnUpdateOk.UseVisualStyleBackColor = true;
        btnUpdateOk.Click += btnUpdateOk_Click;
        // 
        // UpdateStudent
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(405, 238);
        Controls.Add(btnUpdateOk);
        Controls.Add(btnUpdateCancel);
        Controls.Add(btnUpdateClear);
        Controls.Add(btnUpdateRemove);
        Controls.Add(btnUpdateScore);
        Controls.Add(btnUpdateAdd);
        Controls.Add(lstUpdateScores);
        Controls.Add(lblUpdateScores);
        Controls.Add(txtUpdateName);
        Controls.Add(lblUpdateName);
        Text = "UpdateStudent";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnUpdateScore;
    private System.Windows.Forms.Button btnUpdateRemove;
    private System.Windows.Forms.Button btnUpdateClear;
    private System.Windows.Forms.Button btnUpdateCancel;
    private System.Windows.Forms.Button btnUpdateOk;

    private System.Windows.Forms.Label lblUpdateName;
    private System.Windows.Forms.TextBox txtUpdateName;
    private System.Windows.Forms.Label lblUpdateScores;
    private System.Windows.Forms.ListBox lstUpdateScores;
    private System.Windows.Forms.Button btnUpdateAdd;

    #endregion
}