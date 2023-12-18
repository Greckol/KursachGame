namespace Fightgame
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new BufferedPanel();
            buttonHit = new Button();
            panel2 = new BufferedPanel();
            labelInfo = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            hpBarPlayer = new ProgressBar();
            hpBarEnemy = new ProgressBar();
            buttonEscape = new Button();
            labelEnemyName = new Label();
            labelInfo2 = new Label();
            labelEnemyHealth = new Label();
            labelMyHealth = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Location = new Point(469, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 228);
            panel1.TabIndex = 0;
            // 
            // buttonHit
            // 
            buttonHit.Anchor = AnchorStyles.None;
            buttonHit.BackColor = Color.IndianRed;
            buttonHit.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHit.Location = new Point(468, 575);
            buttonHit.Name = "buttonHit";
            buttonHit.Size = new Size(421, 144);
            buttonHit.TabIndex = 1;
            buttonHit.Text = "Hit";
            buttonHit.UseVisualStyleBackColor = false;
            buttonHit.Click += buttonHit_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Location = new Point(828, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 300);
            panel2.TabIndex = 8;
            // 
            // labelInfo
            // 
            labelInfo.Anchor = AnchorStyles.None;
            labelInfo.BackColor = Color.FromArgb(255, 128, 128);
            labelInfo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfo.Location = new Point(937, 414);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(0, 37);
            labelInfo.TabIndex = 0;
            // 
            // hpBarPlayer
            // 
            hpBarPlayer.Anchor = AnchorStyles.None;
            hpBarPlayer.Location = new Point(470, 753);
            hpBarPlayer.Name = "hpBarPlayer";
            hpBarPlayer.Size = new Size(970, 60);
            hpBarPlayer.TabIndex = 4;
            // 
            // hpBarEnemy
            // 
            hpBarEnemy.Anchor = AnchorStyles.None;
            hpBarEnemy.Location = new Point(469, 454);
            hpBarEnemy.Name = "hpBarEnemy";
            hpBarEnemy.Size = new Size(970, 74);
            hpBarEnemy.TabIndex = 5;
            // 
            // buttonEscape
            // 
            buttonEscape.Anchor = AnchorStyles.None;
            buttonEscape.BackColor = Color.FromArgb(192, 255, 192);
            buttonEscape.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEscape.ForeColor = SystemColors.ControlText;
            buttonEscape.Location = new Point(1029, 575);
            buttonEscape.Name = "buttonEscape";
            buttonEscape.Size = new Size(409, 142);
            buttonEscape.TabIndex = 6;
            buttonEscape.Text = "Escape";
            buttonEscape.UseVisualStyleBackColor = false;
            buttonEscape.Click += buttonEscape_Click;
            // 
            // labelEnemyName
            // 
            labelEnemyName.Anchor = AnchorStyles.None;
            labelEnemyName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnemyName.Location = new Point(914, 42);
            labelEnemyName.Name = "labelEnemyName";
            labelEnemyName.Size = new Size(109, 46);
            labelEnemyName.TabIndex = 7;
            labelEnemyName.Text = "label1";
            labelEnemyName.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelInfo2
            // 
            labelInfo2.Anchor = AnchorStyles.None;
            labelInfo2.BackColor = Color.FromArgb(255, 128, 128);
            labelInfo2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfo2.Location = new Point(937, 713);
            labelInfo2.Name = "labelInfo2";
            labelInfo2.Size = new Size(0, 37);
            labelInfo2.TabIndex = 9;
            // 
            // labelEnemyHealth
            // 
            labelEnemyHealth.Anchor = AnchorStyles.None;
            labelEnemyHealth.BackColor = Color.Silver;
            labelEnemyHealth.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnemyHealth.Location = new Point(469, 496);
            labelEnemyHealth.Name = "labelEnemyHealth";
            labelEnemyHealth.Size = new Size(78, 32);
            labelEnemyHealth.TabIndex = 10;
            labelEnemyHealth.Text = "label1";
            // 
            // labelMyHealth
            // 
            labelMyHealth.Anchor = AnchorStyles.None;
            labelMyHealth.BackColor = Color.Silver;
            labelMyHealth.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelMyHealth.Location = new Point(470, 781);
            labelMyHealth.Name = "labelMyHealth";
            labelMyHealth.Size = new Size(78, 32);
            labelMyHealth.TabIndex = 11;
            labelMyHealth.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            Controls.Add(labelMyHealth);
            Controls.Add(labelEnemyHealth);
            Controls.Add(labelInfo2);
            Controls.Add(panel2);
            Controls.Add(labelEnemyName);
            Controls.Add(buttonEscape);
            Controls.Add(labelInfo);
            Controls.Add(hpBarEnemy);
            Controls.Add(hpBarPlayer);
            Controls.Add(buttonHit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private BufferedPanel panel1;
        private Button buttonHit;
        private BufferedPanel panel2;
        private System.Windows.Forms.Timer timer2;
        private ProgressBar hpBarPlayer;
        private ProgressBar hpBarEnemy;
        private Label labelInfo;
        private Button buttonEscape;
        private Label labelEnemyName;
        private Label labelInfo2;
        private Label labelEnemyHealth;
        private Label labelMyHealth;
    }
}