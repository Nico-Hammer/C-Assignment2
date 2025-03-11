using System.ComponentModel;

namespace MaintainStudentScores;

partial class AddScore
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
        lblAddScore = new System.Windows.Forms.Label();
        btnAddaddscore = new System.Windows.Forms.Button();
        btnAddCancel = new System.Windows.Forms.Button();
        txtAddscore = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // lblAddScore
        // 
        lblAddScore.Location = new System.Drawing.Point(32, 21);
        lblAddScore.Name = "lblAddScore";
        lblAddScore.Size = new System.Drawing.Size(100, 23);
        lblAddScore.TabIndex = 0;
        lblAddScore.Text = "Score:";
        // 
        // btnAddaddscore
        // 
        btnAddaddscore.Location = new System.Drawing.Point(32, 47);
        btnAddaddscore.Name = "btnAddaddscore";
        btnAddaddscore.Size = new System.Drawing.Size(75, 23);
        btnAddaddscore.TabIndex = 1;
        btnAddaddscore.Text = "&Add";
        btnAddaddscore.UseVisualStyleBackColor = true;
        // 
        // btnAddCancel
        // 
        btnAddCancel.Location = new System.Drawing.Point(113, 47);
        btnAddCancel.Name = "btnAddCancel";
        btnAddCancel.Size = new System.Drawing.Size(75, 23);
        btnAddCancel.TabIndex = 2;
        btnAddCancel.Text = "&Cancel";
        btnAddCancel.UseVisualStyleBackColor = true;
        btnAddCancel.Click += btnAddCancel_Click;
        // 
        // txtAddscore
        // 
        txtAddscore.Location = new System.Drawing.Point(88, 18);
        txtAddscore.Name = "txtAddscore";
        txtAddscore.Size = new System.Drawing.Size(100, 23);
        txtAddscore.TabIndex = 3;
        // 
        // AddScore
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(217, 91);
        Controls.Add(txtAddscore);
        Controls.Add(btnAddCancel);
        Controls.Add(btnAddaddscore);
        Controls.Add(lblAddScore);
        Text = "AddScore";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblAddScore;
    private System.Windows.Forms.Button btnAddaddscore;
    private System.Windows.Forms.Button btnAddCancel;
    private System.Windows.Forms.TextBox txtAddscore;

    #endregion
}