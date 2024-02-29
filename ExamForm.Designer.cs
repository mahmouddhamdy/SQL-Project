﻿namespace OnlineExamination
{
    partial class ExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamForm));
            ptnPrev = new Button();
            panelQuestion = new Panel();
            finishExamButton = new Button();
            lblTimer = new Label();
            btnNext = new Button();
            SuspendLayout();
            // 
            // ptnPrev
            // 
            ptnPrev.BackColor = Color.FromArgb(34, 40, 49);
            ptnPrev.ForeColor = Color.FromArgb(238, 238, 238);
            ptnPrev.Image = (Image)resources.GetObject("ptnPrev.Image");
            ptnPrev.Location = new Point(306, 523);
            ptnPrev.Name = "ptnPrev";
            ptnPrev.Size = new Size(77, 74);
            ptnPrev.TabIndex = 1;
            ptnPrev.UseVisualStyleBackColor = false;
            ptnPrev.Click += ptnPrev_Click;
            // 
            // panelQuestion
            // 
            panelQuestion.Location = new Point(21, 26);
            panelQuestion.Name = "panelQuestion";
            panelQuestion.Size = new Size(1248, 491);
            panelQuestion.TabIndex = 3;
            // 
            // finishExamButton
            // 
            finishExamButton.BackColor = Color.FromArgb(238, 238, 238);
            finishExamButton.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            finishExamButton.ForeColor = Color.FromArgb(0, 173, 181);
            finishExamButton.Location = new Point(1108, 594);
            finishExamButton.Name = "finishExamButton";
            finishExamButton.Size = new Size(180, 79);
            finishExamButton.TabIndex = 4;
            finishExamButton.Text = "Submit";
            finishExamButton.UseVisualStyleBackColor = false;
            finishExamButton.Visible = false;
            finishExamButton.Click += finishExamButton_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.FromArgb(34, 40, 49);
            lblTimer.Font = new Font("Corbel", 23.7913036F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.FromArgb(0, 173, 181);
            lblTimer.Location = new Point(1275, 26);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(119, 46);
            lblTimer.TabIndex = 5;
            lblTimer.Text = "label1";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(34, 40, 49);
            btnNext.ForeColor = Color.FromArgb(238, 238, 238);
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(832, 523);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(77, 74);
            btnNext.TabIndex = 2;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(1407, 781);
            Controls.Add(lblTimer);
            Controls.Add(finishExamButton);
            Controls.Add(panelQuestion);
            Controls.Add(btnNext);
            Controls.Add(ptnPrev);
            MaximumSize = new Size(1425, 826);
            MinimumSize = new Size(1425, 826);
            Name = "ExamForm";
            Text = "ExamForm";
            FormClosing += ExamForm_FormClosing;
            Load += ExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ptnPrev;
        private Panel panelQuestion;
        private Button finishExamButton;
        private Label lblTimer;
        private Button btnNext;
    }
}