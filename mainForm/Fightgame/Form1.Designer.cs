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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            buttonAtack = new Button();
            buttonNextTurn = new Button();
            hpBarPlayer = new ProgressBar();
            hpBarEnemy = new ProgressBar();
            progressBarExp = new ProgressBar();
            panelMain = new BufferedPanel();
            labelLVL = new Label();
            checkBoxMain = new CheckBox();
            checkBoxRangeEnemys = new CheckBox();
            listView1 = new ListView();
            buttonEnterUp = new Button();
            listView2 = new ListView();
            labelStatName = new Label();
            buttonExit = new Button();
            labelMyHealth = new Label();
            labelEnemyHealth = new Label();
            buttonAutoMode = new Button();
            checkBoxAutoMode = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            labelUpgrades = new Label();
            labelStages = new Label();
            labelScore = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1012, 70);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // buttonAtack
            // 
            buttonAtack.Anchor = AnchorStyles.None;
            buttonAtack.BackColor = Color.IndianRed;
            buttonAtack.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtack.Location = new Point(1021, 401);
            buttonAtack.Name = "buttonAtack";
            buttonAtack.Size = new Size(238, 95);
            buttonAtack.TabIndex = 1;
            buttonAtack.Text = "Atack";
            buttonAtack.UseVisualStyleBackColor = false;
            buttonAtack.Click += buttonAtack_Click;
            // 
            // buttonNextTurn
            // 
            buttonNextTurn.Anchor = AnchorStyles.None;
            buttonNextTurn.BackColor = Color.FromArgb(255, 255, 192);
            buttonNextTurn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNextTurn.Location = new Point(1369, 401);
            buttonNextTurn.Name = "buttonNextTurn";
            buttonNextTurn.Size = new Size(252, 95);
            buttonNextTurn.TabIndex = 2;
            buttonNextTurn.Text = "NextTurn";
            buttonNextTurn.UseVisualStyleBackColor = false;
            buttonNextTurn.Click += buttonNextTurn_Click;
            // 
            // hpBarPlayer
            // 
            hpBarPlayer.Anchor = AnchorStyles.None;
            hpBarPlayer.Location = new Point(1021, 322);
            hpBarPlayer.Name = "hpBarPlayer";
            hpBarPlayer.Size = new Size(600, 60);
            hpBarPlayer.TabIndex = 3;
            // 
            // hpBarEnemy
            // 
            hpBarEnemy.Anchor = AnchorStyles.None;
            hpBarEnemy.Location = new Point(1021, 119);
            hpBarEnemy.Name = "hpBarEnemy";
            hpBarEnemy.Size = new Size(600, 60);
            hpBarEnemy.Step = 100;
            hpBarEnemy.TabIndex = 4;
            // 
            // progressBarExp
            // 
            progressBarExp.Anchor = AnchorStyles.None;
            progressBarExp.Location = new Point(94, 1003);
            progressBarExp.Name = "progressBarExp";
            progressBarExp.Size = new Size(1707, 31);
            progressBarExp.TabIndex = 5;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(990, 990);
            panelMain.TabIndex = 7;
            // 
            // labelLVL
            // 
            labelLVL.Anchor = AnchorStyles.None;
            labelLVL.BackColor = Color.Transparent;
            labelLVL.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelLVL.ForeColor = Color.Blue;
            labelLVL.Location = new Point(0, 999);
            labelLVL.Name = "labelLVL";
            labelLVL.Size = new Size(54, 35);
            labelLVL.TabIndex = 13;
            labelLVL.Text = "LVL";
            // 
            // checkBoxMain
            // 
            checkBoxMain.Anchor = AnchorStyles.None;
            checkBoxMain.AutoSize = true;
            checkBoxMain.Enabled = false;
            checkBoxMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMain.Location = new Point(1548, 502);
            checkBoxMain.Name = "checkBoxMain";
            checkBoxMain.Size = new Size(73, 32);
            checkBoxMain.TabIndex = 8;
            checkBoxMain.Text = "Turn";
            checkBoxMain.UseVisualStyleBackColor = true;
            // 
            // checkBoxRangeEnemys
            // 
            checkBoxRangeEnemys.Anchor = AnchorStyles.None;
            checkBoxRangeEnemys.AutoSize = true;
            checkBoxRangeEnemys.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRangeEnemys.Location = new Point(1021, 192);
            checkBoxRangeEnemys.Name = "checkBoxRangeEnemys";
            checkBoxRangeEnemys.Size = new Size(89, 32);
            checkBoxRangeEnemys.TabIndex = 11;
            checkBoxRangeEnemys.Text = "Range";
            checkBoxRangeEnemys.UseVisualStyleBackColor = true;
            checkBoxRangeEnemys.CheckedChanged += checkBoxRangeEnemys_CheckedChanged;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(1021, 568);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(600, 301);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            // 
            // buttonEnterUp
            // 
            buttonEnterUp.Anchor = AnchorStyles.None;
            buttonEnterUp.BackColor = Color.FromArgb(192, 255, 192);
            buttonEnterUp.Enabled = false;
            buttonEnterUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEnterUp.Location = new Point(1021, 879);
            buttonEnterUp.Name = "buttonEnterUp";
            buttonEnterUp.Size = new Size(600, 48);
            buttonEnterUp.TabIndex = 15;
            buttonEnterUp.Text = "enter";
            buttonEnterUp.UseVisualStyleBackColor = false;
            buttonEnterUp.Click += buttonEnterUp_Click;
            // 
            // listView2
            // 
            listView2.Anchor = AnchorStyles.None;
            listView2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listView2.Location = new Point(1667, 119);
            listView2.Name = "listView2";
            listView2.Size = new Size(233, 750);
            listView2.TabIndex = 16;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // labelStatName
            // 
            labelStatName.Anchor = AnchorStyles.None;
            labelStatName.BackColor = Color.FromArgb(255, 255, 128);
            labelStatName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatName.Location = new Point(1667, 80);
            labelStatName.Name = "labelStatName";
            labelStatName.Size = new Size(54, 28);
            labelStatName.TabIndex = 17;
            labelStatName.Text = "label";
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.None;
            buttonExit.BackColor = Color.Red;
            buttonExit.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(1021, 230);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(600, 52);
            buttonExit.TabIndex = 18;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Visible = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelMyHealth
            // 
            labelMyHealth.Anchor = AnchorStyles.None;
            labelMyHealth.BackColor = Color.Silver;
            labelMyHealth.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelMyHealth.Location = new Point(1021, 352);
            labelMyHealth.Name = "labelMyHealth";
            labelMyHealth.Size = new Size(71, 30);
            labelMyHealth.TabIndex = 20;
            labelMyHealth.Text = "label2";
            // 
            // labelEnemyHealth
            // 
            labelEnemyHealth.Anchor = AnchorStyles.None;
            labelEnemyHealth.BackColor = Color.Silver;
            labelEnemyHealth.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnemyHealth.Location = new Point(1021, 149);
            labelEnemyHealth.Margin = new Padding(0);
            labelEnemyHealth.Name = "labelEnemyHealth";
            labelEnemyHealth.Size = new Size(71, 30);
            labelEnemyHealth.TabIndex = 21;
            labelEnemyHealth.Text = "label2";
            // 
            // buttonAutoMode
            // 
            buttonAutoMode.Anchor = AnchorStyles.None;
            buttonAutoMode.BackColor = Color.FromArgb(255, 224, 192);
            buttonAutoMode.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAutoMode.Location = new Point(1667, 879);
            buttonAutoMode.Name = "buttonAutoMode";
            buttonAutoMode.Size = new Size(233, 48);
            buttonAutoMode.TabIndex = 22;
            buttonAutoMode.Text = "AutoMode";
            buttonAutoMode.UseVisualStyleBackColor = false;
            buttonAutoMode.Click += buttonAutoMode_Click;
            // 
            // checkBoxAutoMode
            // 
            checkBoxAutoMode.Anchor = AnchorStyles.None;
            checkBoxAutoMode.Enabled = false;
            checkBoxAutoMode.Location = new Point(1758, 929);
            checkBoxAutoMode.Name = "checkBoxAutoMode";
            checkBoxAutoMode.Size = new Size(142, 24);
            checkBoxAutoMode.TabIndex = 23;
            checkBoxAutoMode.Text = "AutoModeStatus";
            checkBoxAutoMode.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1012, 273);
            label2.Name = "label2";
            label2.Size = new Size(162, 41);
            label2.TabIndex = 24;
            label2.Text = "HeroName";
            // 
            // labelUpgrades
            // 
            labelUpgrades.Anchor = AnchorStyles.None;
            labelUpgrades.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelUpgrades.Location = new Point(1261, 535);
            labelUpgrades.Name = "labelUpgrades";
            labelUpgrades.Size = new Size(107, 30);
            labelUpgrades.TabIndex = 25;
            labelUpgrades.Text = "Upgrades";
            // 
            // labelStages
            // 
            labelStages.Anchor = AnchorStyles.None;
            labelStages.BackColor = Color.FromArgb(192, 255, 255);
            labelStages.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelStages.Location = new Point(1021, 955);
            labelStages.Name = "labelStages";
            labelStages.Size = new Size(101, 35);
            labelStages.TabIndex = 26;
            labelStages.Text = "Stage: 1";
            // 
            // labelScore
            // 
            labelScore.Anchor = AnchorStyles.None;
            labelScore.BackColor = Color.FromArgb(192, 255, 255);
            labelScore.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(1519, 955);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(102, 35);
            labelScore.TabIndex = 27;
            labelScore.Text = "Score: 0";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttonExit);
            Controls.Add(labelScore);
            Controls.Add(labelStages);
            Controls.Add(labelLVL);
            Controls.Add(labelUpgrades);
            Controls.Add(label2);
            Controls.Add(checkBoxAutoMode);
            Controls.Add(buttonAutoMode);
            Controls.Add(labelEnemyHealth);
            Controls.Add(labelMyHealth);
            Controls.Add(labelStatName);
            Controls.Add(listView2);
            Controls.Add(buttonEnterUp);
            Controls.Add(listView1);
            Controls.Add(checkBoxRangeEnemys);
            Controls.Add(checkBoxMain);
            Controls.Add(hpBarEnemy);
            Controls.Add(hpBarPlayer);
            Controls.Add(buttonNextTurn);
            Controls.Add(buttonAtack);
            Controls.Add(label1);
            Controls.Add(panelMain);
            Controls.Add(progressBarExp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAtack;
        private Button buttonNextTurn;
        private ProgressBar hpBarPlayer;
        private ProgressBar hpBarEnemy;
        private ProgressBar progressBarExp;
        private BufferedPanel panelMain;
        private CheckBox checkBoxMain;
        private CheckBox checkBoxRangeEnemys;
        private Label labelLVL;
        private ListView listView1;
        private Button buttonEnterUp;
        private ListView listView2;
        private Label labelStatName;
        private Button buttonExit;
        private Label labelMyHealth;
        private Label labelEnemyHealth;
        private Button buttonAutoMode;
        private CheckBox checkBoxAutoMode;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label labelUpgrades;
        private Label labelStages;
        private Label labelScore;
    }
}