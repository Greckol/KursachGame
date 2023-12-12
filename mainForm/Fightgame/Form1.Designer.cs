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
            hpBarPlayer = new ProgressBar();
            hpBarEnemy = new ProgressBar();
            progressBarExp = new ProgressBar();
            panelMain = new BufferedPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1140, 61);
            label1.Name = "label1";
            label1.Size = new Size(149, 46);
            label1.TabIndex = 0;
            label1.Text = "InfoClick";
            // 
            // buttonAtack
            // 
            buttonAtack.Location = new Point(1140, 585);
            buttonAtack.Name = "buttonAtack";
            buttonAtack.Size = new Size(365, 95);
            buttonAtack.TabIndex = 1;
            buttonAtack.Text = "Atack";
            buttonAtack.UseVisualStyleBackColor = true;
            buttonAtack.Click += buttonAtack_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1570, 585);
            button1.Name = "button1";
            button1.Size = new Size(323, 95);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // hpBarPlayer
            // 
            hpBarPlayer.Location = new Point(1140, 491);
            hpBarPlayer.Name = "hpBarPlayer";
            hpBarPlayer.Size = new Size(752, 58);
            hpBarPlayer.TabIndex = 3;
            // 
            // hpBarEnemy
            // 
            hpBarEnemy.Location = new Point(1140, 132);
            hpBarEnemy.Name = "hpBarEnemy";
            hpBarEnemy.Size = new Size(753, 62);
            hpBarEnemy.Step = 100;
            hpBarEnemy.TabIndex = 4;
            // 
            // progressBarExp
            // 
            progressBarExp.Location = new Point(2, 1003);
            progressBarExp.Name = "progressBarExp";
            progressBarExp.Size = new Size(1898, 29);
            progressBarExp.TabIndex = 5;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(46, 25);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(900, 900);
            panelMain.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelMain);
            Controls.Add(progressBarExp);
            Controls.Add(hpBarEnemy);
            Controls.Add(hpBarPlayer);
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
        private ProgressBar hpBarPlayer;
        private ProgressBar hpBarEnemy;
        private ProgressBar progressBarExp;
        private BufferedPanel panelMain;
    }
}