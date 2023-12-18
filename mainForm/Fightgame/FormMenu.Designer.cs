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
            buttonStartGame.Location = new Point(697, 633);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.Size = new Size(491, 124);
            buttonStartGame.TabIndex = 0;
            buttonStartGame.Text = "START";
            buttonStartGame.UseVisualStyleBackColor = true;
            buttonStartGame.Click += buttonStartGame_Click;
            // 
            // textBoxPlayerName
            // 
            textBoxPlayerName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPlayerName.Location = new Point(697, 269);
            textBoxPlayerName.Name = "textBoxPlayerName";
            textBoxPlayerName.Size = new Size(491, 41);
            textBoxPlayerName.TabIndex = 1;
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerName.Location = new Point(853, 209);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(185, 46);
            labelPlayerName.TabIndex = 2;
            labelPlayerName.Text = "Your Name";
            // 
            // comboBoxdifficulty
            // 
            comboBoxdifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxdifficulty.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxdifficulty.FormattingEnabled = true;
            comboBoxdifficulty.Location = new Point(697, 396);
            comboBoxdifficulty.Name = "comboBoxdifficulty";
            comboBoxdifficulty.Size = new Size(491, 43);
            comboBoxdifficulty.TabIndex = 3;
            // 
            // comboBoxMainPanelSize
            // 
            comboBoxMainPanelSize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMainPanelSize.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMainPanelSize.FormattingEnabled = true;
            comboBoxMainPanelSize.Location = new Point(697, 527);
            comboBoxMainPanelSize.Name = "comboBoxMainPanelSize";
            comboBoxMainPanelSize.Size = new Size(491, 43);
            comboBoxMainPanelSize.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(866, 337);
            label1.Name = "label1";
            label1.Size = new Size(153, 46);
            label1.TabIndex = 5;
            label1.Text = "Difficulty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(823, 467);
            label2.Name = "label2";
            label2.Size = new Size(265, 46);
            label2.TabIndex = 6;
            label2.Text = "Playing field size";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxMainPanelSize);
            Controls.Add(comboBoxdifficulty);
            Controls.Add(labelPlayerName);
            Controls.Add(textBoxPlayerName);
            Controls.Add(buttonStartGame);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
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