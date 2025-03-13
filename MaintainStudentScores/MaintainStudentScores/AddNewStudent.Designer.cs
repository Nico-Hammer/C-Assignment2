using System.ComponentModel;

namespace MaintainStudentScores;

partial class AddNewStudent
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
        lblNewName = new System.Windows.Forms.Label();
        lblNewScore = new System.Windows.Forms.Label();
        lblNewScores = new System.Windows.Forms.Label();
        txtNewScores = new System.Windows.Forms.TextBox();
        txtNewScore = new System.Windows.Forms.TextBox();
        txtNewName = new System.Windows.Forms.TextBox();
        btnNewAddScore = new System.Windows.Forms.Button();
        btnNewClearScores = new System.Windows.Forms.Button();
        btnNewCancel = new System.Windows.Forms.Button();
        btnNewOk = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblNewName
        // 
        lblNewName.Location = new System.Drawing.Point(32, 20);
        lblNewName.Name = "lblNewName";
        lblNewName.Size = new System.Drawing.Size(100, 23);
        lblNewName.TabIndex = 0;
        lblNewName.Text = "Name:";
        // 
        // lblNewScore
        // 
        lblNewScore.Location = new System.Drawing.Point(32, 58);
        lblNewScore.Name = "lblNewScore";
        lblNewScore.Size = new System.Drawing.Size(100, 23);
        lblNewScore.TabIndex = 2;
        lblNewScore.Text = "Score:";
        // 
        // lblNewScores
        // 
        lblNewScores.Location = new System.Drawing.Point(32, 97);
        lblNewScores.Name = "lblNewScores";
        lblNewScores.Size = new System.Drawing.Size(100, 23);
        lblNewScores.TabIndex = 5;
        lblNewScores.Text = "Scores:";
        // 
        // txtNewScores
        // 
        txtNewScores.Location = new System.Drawing.Point(92, 97);
        txtNewScores.Name = "txtNewScores";
        txtNewScores.ReadOnly = true;
        txtNewScores.Size = new System.Drawing.Size(220, 23);
        txtNewScores.TabIndex = 6;
        txtNewScores.TabStop = false;
        // 
        // txtNewScore
        // 
        txtNewScore.Location = new System.Drawing.Point(92, 58);
        txtNewScore.Name = "txtNewScore";
        txtNewScore.Size = new System.Drawing.Size(100, 23);
        txtNewScore.TabIndex = 3;
        // 
        // txtNewName
        // 
        txtNewName.Location = new System.Drawing.Point(92, 20);
        txtNewName.Name = "txtNewName";
        txtNewName.Size = new System.Drawing.Size(220, 23);
        txtNewName.TabIndex = 1;
        // 
        // btnNewAddScore
        // 
        btnNewAddScore.Location = new System.Drawing.Point(214, 58);
        btnNewAddScore.Name = "btnNewAddScore";
        btnNewAddScore.Size = new System.Drawing.Size(98, 23);
        btnNewAddScore.TabIndex = 4;
        btnNewAddScore.Text = "&Add Score";
        btnNewAddScore.UseVisualStyleBackColor = true;
        btnNewAddScore.Click += btnNewAddScore_Click;
        // 
        // btnNewClearScores
        // 
        btnNewClearScores.Location = new System.Drawing.Point(214, 135);
        btnNewClearScores.Name = "btnNewClearScores";
        btnNewClearScores.Size = new System.Drawing.Size(98, 23);
        btnNewClearScores.TabIndex = 7;
        btnNewClearScores.Text = "Clear &Scores";
        btnNewClearScores.UseVisualStyleBackColor = true;
        btnNewClearScores.Click += btnNewClearScores_Click;
        // 
        // btnNewCancel
        // 
        btnNewCancel.Location = new System.Drawing.Point(214, 176);
        btnNewCancel.Name = "btnNewCancel";
        btnNewCancel.Size = new System.Drawing.Size(98, 23);
        btnNewCancel.TabIndex = 9;
        btnNewCancel.Text = "&Cancel";
        btnNewCancel.UseVisualStyleBackColor = true;
        btnNewCancel.Click += btnNewCancel_Click;
        // 
        // btnNewOk
        // 
        btnNewOk.Location = new System.Drawing.Point(110, 176);
        btnNewOk.Name = "btnNewOk";
        btnNewOk.Size = new System.Drawing.Size(98, 23);
        btnNewOk.TabIndex = 8;
        btnNewOk.Text = "&Ok";
        btnNewOk.UseVisualStyleBackColor = true;
        btnNewOk.Click += btnNewOk_Click;
        // 
        // AddNewStudent
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(341, 220);
        Controls.Add(btnNewOk);
        Controls.Add(btnNewCancel);
        Controls.Add(btnNewClearScores);
        Controls.Add(btnNewAddScore);
        Controls.Add(txtNewName);
        Controls.Add(txtNewScore);
        Controls.Add(txtNewScores);
        Controls.Add(lblNewScores);
        Controls.Add(lblNewScore);
        Controls.Add(lblNewName);
        Text = "AddNewStudent";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtNewScore;
    private System.Windows.Forms.TextBox txtNewName;
    private System.Windows.Forms.Button btnNewAddScore;
    private System.Windows.Forms.Button btnNewClearScores;
    private System.Windows.Forms.Button btnNewCancel;
    private System.Windows.Forms.Button btnNewOk;

    private System.Windows.Forms.Label lblNewName;
    private System.Windows.Forms.Label lblNewScore;
    private System.Windows.Forms.Label lblNewScores;
    private System.Windows.Forms.TextBox txtNewScores;

    #endregion
}