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
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(480, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 200);
            panel1.TabIndex = 0;
            // 
            // buttonHit
            // 
            buttonHit.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHit.Location = new Point(469, 574);
            buttonHit.Name = "buttonHit";
            buttonHit.Size = new Size(421, 144);
            buttonHit.TabIndex = 1;
            buttonHit.Text = "Hit";
            buttonHit.UseVisualStyleBackColor = true;
            buttonHit.Click += buttonHit_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(828, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 300);
            panel2.TabIndex = 8;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = Color.FromArgb(255, 128, 128);
            labelInfo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfo.Location = new Point(937, 404);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(0, 37);
            labelInfo.TabIndex = 0;
            // 
            // hpBarPlayer
            // 
            hpBarPlayer.Location = new Point(468, 793);
            hpBarPlayer.Name = "hpBarPlayer";
            hpBarPlayer.Size = new Size(970, 60);
            hpBarPlayer.TabIndex = 4;
            // 
            // hpBarEnemy
            // 
            hpBarEnemy.Location = new Point(469, 454);
            hpBarEnemy.Name = "hpBarEnemy";
            hpBarEnemy.Size = new Size(970, 74);
            hpBarEnemy.TabIndex = 5;
            // 
            // buttonEscape
            // 
            buttonEscape.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEscape.Location = new Point(1015, 574);
            buttonEscape.Name = "buttonEscape";
            buttonEscape.Size = new Size(409, 142);
            buttonEscape.TabIndex = 6;
            buttonEscape.Text = "Escape";
            buttonEscape.UseVisualStyleBackColor = true;
            buttonEscape.Click += buttonEscape_Click;
            // 
            // labelEnemyName
            // 
            labelEnemyName.AutoSize = true;
            labelEnemyName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnemyName.Location = new Point(878, 35);
            labelEnemyName.Name = "labelEnemyName";
            labelEnemyName.Size = new Size(97, 41);
            labelEnemyName.TabIndex = 7;
            labelEnemyName.Text = "label1";
            labelEnemyName.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelInfo2
            // 
            labelInfo2.AutoSize = true;
            labelInfo2.BackColor = Color.FromArgb(255, 128, 128);
            labelInfo2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfo2.Location = new Point(937, 737);
            labelInfo2.Name = "labelInfo2";
            labelInfo2.Size = new Size(0, 37);
            labelInfo2.TabIndex = 9;
            // 
            // labelEnemyHealth
            // 
            labelEnemyHealth.AutoSize = true;
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
            labelMyHealth.AutoSize = true;
            labelMyHealth.BackColor = Color.Silver;
            labelMyHealth.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelMyHealth.Location = new Point(469, 821);
            labelMyHealth.Name = "labelMyHealth";
            labelMyHealth.Size = new Size(78, 32);
            labelMyHealth.TabIndex = 11;
            labelMyHealth.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
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
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
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