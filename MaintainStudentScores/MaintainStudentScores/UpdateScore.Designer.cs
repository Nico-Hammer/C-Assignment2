using System.ComponentModel;

namespace MaintainStudentScores;

partial class UpdateScore
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
        lblUScorescore = new System.Windows.Forms.Label();
        txtUScore = new System.Windows.Forms.TextBox();
        btnUScorecancel = new System.Windows.Forms.Button();
        btnUScoreupdate = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lblUScorescore
        // 
        lblUScorescore.Location = new System.Drawing.Point(29, 18);
        lblUScorescore.Name = "lblUScorescore";
        lblUScorescore.Size = new System.Drawing.Size(100, 23);
        lblUScorescore.TabIndex = 0;
        lblUScorescore.Text = "Score:";
        // 
        // txtUScore
        // 
        txtUScore.Location = new System.Drawing.Point(92, 18);
        txtUScore.Name = "txtUScore";
        txtUScore.Size = new System.Drawing.Size(100, 23);
        txtUScore.TabIndex = 1;
        // 
        // btnUScorecancel
        // 
        btnUScorecancel.Location = new System.Drawing.Point(117, 60);
        btnUScorecancel.Name = "btnUScorecancel";
        btnUScorecancel.Size = new System.Drawing.Size(75, 23);
        btnUScorecancel.TabIndex = 2;
        btnUScorecancel.Text = "&Cancel";
        btnUScorecancel.UseVisualStyleBackColor = true;
        btnUScorecancel.Click += btnUScorecancel_Click;
        // 
        // btnUScoreupdate
        // 
        btnUScoreupdate.Location = new System.Drawing.Point(29, 60);
        btnUScoreupdate.Name = "btnUScoreupdate";
        btnUScoreupdate.Size = new System.Drawing.Size(75, 23);
        btnUScoreupdate.TabIndex = 3;
        btnUScoreupdate.Text = "&Update";
        btnUScoreupdate.UseVisualStyleBackColor = true;
        btnUScoreupdate.Click += btnUScoreupdate_Click;
        // 
        // UpdateScore
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(213, 103);
        Controls.Add(btnUScoreupdate);
        Controls.Add(btnUScorecancel);
        Controls.Add(txtUScore);
        Controls.Add(lblUScorescore);
        Text = "UpdateScore";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblUScorescore;
    private System.Windows.Forms.TextBox txtUScore;
    private System.Windows.Forms.Button btnUScorecancel;
    private System.Windows.Forms.Button btnUScoreupdate;

    #endregion
}