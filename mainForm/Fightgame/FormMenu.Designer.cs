namespace Fightgame
{
    partial class FormMenu
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
            buttonStartGame = new Button();
            textBoxPlayerName = new TextBox();
            labelPlayerName = new Label();
            comboBoxdifficulty = new ComboBox();
            comboBoxMainPanelSize = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonStartGame
            // 
            buttonStartGame.BackColor = Color.FromArgb(192, 255, 192);
            buttonStartGame.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStartGame.Location = new Point(708, 780);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.Size = new Size(454, 131);
            buttonStartGame.TabIndex = 0;
            buttonStartGame.Text = "START FIGHT";
            buttonStartGame.UseVisualStyleBackColor = false;
            buttonStartGame.Click += buttonStartGame_Click;
            // 
            // textBoxPlayerName
            // 
            textBoxPlayerName.BackColor = Color.Silver;
            textBoxPlayerName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPlayerName.ForeColor = SystemColors.WindowText;
            textBoxPlayerName.Location = new Point(708, 495);
            textBoxPlayerName.Name = "textBoxPlayerName";
            textBoxPlayerName.Size = new Size(454, 41);
            textBoxPlayerName.TabIndex = 1;
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.BackColor = Color.Silver;
            labelPlayerName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerName.Location = new Point(861, 451);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(164, 41);
            labelPlayerName.TabIndex = 2;
            labelPlayerName.Text = "Your Name";
            // 
            // comboBoxdifficulty
            // 
            comboBoxdifficulty.BackColor = Color.Silver;
            comboBoxdifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxdifficulty.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxdifficulty.ForeColor = Color.FromArgb(192, 0, 0);
            comboBoxdifficulty.FormattingEnabled = true;
            comboBoxdifficulty.Location = new Point(708, 595);
            comboBoxdifficulty.Name = "comboBoxdifficulty";
            comboBoxdifficulty.Size = new Size(454, 43);
            comboBoxdifficulty.TabIndex = 3;
            // 
            // comboBoxMainPanelSize
            // 
            comboBoxMainPanelSize.BackColor = Color.Silver;
            comboBoxMainPanelSize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMainPanelSize.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMainPanelSize.ForeColor = Color.FromArgb(192, 0, 0);
            comboBoxMainPanelSize.FormattingEnabled = true;
            comboBoxMainPanelSize.Location = new Point(708, 712);
            comboBoxMainPanelSize.Name = "comboBoxMainPanelSize";
            comboBoxMainPanelSize.Size = new Size(454, 43);
            comboBoxMainPanelSize.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(883, 557);
            label1.Name = "label1";
            label1.Size = new Size(113, 35);
            label1.TabIndex = 5;
            label1.Text = "Difficulty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(836, 672);
            label2.Name = "label2";
            label2.Size = new Size(214, 37);
            label2.TabIndex = 6;
            label2.Text = "Playing field size";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MenuImageBlack;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMainPanelSize);
            Controls.Add(comboBoxdifficulty);
            Controls.Add(labelPlayerName);
            Controls.Add(textBoxPlayerName);
            Controls.Add(buttonStartGame);
            DoubleBuffered = true;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStartGame;
        private TextBox textBoxPlayerName;
        private Label labelPlayerName;
        private ComboBox comboBoxdifficulty;
        private ComboBox comboBoxMainPanelSize;
        private Label label1;
        private Label label2;
    }
}