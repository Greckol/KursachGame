namespace Fightgame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonAtack = new Button();
            button1 = new Button();
            progressBarPlayer = new ProgressBar();
            progressBarEnemy = new ProgressBar();
            progressBarExp = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(879, 56);
            label1.Name = "label1";
            label1.Size = new Size(149, 46);
            label1.TabIndex = 0;
            label1.Text = "InfoClick";
            // 
            // buttonAtack
            // 
            buttonAtack.Location = new Point(879, 209);
            buttonAtack.Name = "buttonAtack";
            buttonAtack.Size = new Size(324, 59);
            buttonAtack.TabIndex = 1;
            buttonAtack.Text = "Atack";
            buttonAtack.UseVisualStyleBackColor = true;
            buttonAtack.Click += buttonAtack_Click;
            // 
            // button1
            // 
            button1.Location = new Point(879, 583);
            button1.Name = "button1";
            button1.Size = new Size(345, 142);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBarPlayer
            // 
            progressBarPlayer.Location = new Point(879, 486);
            progressBarPlayer.Name = "progressBarPlayer";
            progressBarPlayer.Size = new Size(752, 58);
            progressBarPlayer.TabIndex = 3;
            // 
            // progressBarEnemy
            // 
            progressBarEnemy.Location = new Point(879, 127);
            progressBarEnemy.Name = "progressBarEnemy";
            progressBarEnemy.Size = new Size(753, 62);
            progressBarEnemy.Step = 100;
            progressBarEnemy.TabIndex = 4;
            // 
            // progressBarExp
            // 
            progressBarExp.Location = new Point(2, 1003);
            progressBarExp.Name = "progressBarExp";
            progressBarExp.Size = new Size(1898, 29);
            progressBarExp.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(progressBarExp);
            Controls.Add(progressBarEnemy);
            Controls.Add(progressBarPlayer);
            Controls.Add(button1);
            Controls.Add(buttonAtack);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAtack;
        private Button button1;
        private ProgressBar progressBarPlayer;
        private ProgressBar progressBarEnemy;
        private ProgressBar progressBarExp;
    }
}