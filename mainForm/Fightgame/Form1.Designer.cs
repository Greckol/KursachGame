﻿namespace Fightgame
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
            buttonNextTurn = new Button();
            hpBarPlayer = new ProgressBar();
            hpBarEnemy = new ProgressBar();
            progressBarExp = new ProgressBar();
            panelMain = new BufferedPanel();
            checkBoxMain = new CheckBox();
            checkBoxSide = new CheckBox();
            buttonStats = new Button();
            checkBoxRangeEnemys = new CheckBox();
            button1 = new Button();
            labelLVL = new Label();
            listView1 = new ListView();
            buttonEnterUp = new Button();
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
            buttonAtack.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtack.Location = new Point(1140, 585);
            buttonAtack.Name = "buttonAtack";
            buttonAtack.Size = new Size(365, 95);
            buttonAtack.TabIndex = 1;
            buttonAtack.Text = "Atack";
            buttonAtack.UseVisualStyleBackColor = true;
            buttonAtack.Click += buttonAtack_Click;
            // 
            // buttonNextTurn
            // 
            buttonNextTurn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNextTurn.Location = new Point(1570, 585);
            buttonNextTurn.Name = "buttonNextTurn";
            buttonNextTurn.Size = new Size(323, 95);
            buttonNextTurn.TabIndex = 2;
            buttonNextTurn.Text = "NextTurn";
            buttonNextTurn.UseVisualStyleBackColor = true;
            buttonNextTurn.Click += buttonNextTurn_Click;
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
            // checkBoxMain
            // 
            checkBoxMain.AutoSize = true;
            checkBoxMain.Enabled = false;
            checkBoxMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxMain.Location = new Point(1570, 686);
            checkBoxMain.Name = "checkBoxMain";
            checkBoxMain.Size = new Size(78, 32);
            checkBoxMain.TabIndex = 8;
            checkBoxMain.Text = "Main";
            checkBoxMain.UseVisualStyleBackColor = true;
            // 
            // checkBoxSide
            // 
            checkBoxSide.AutoSize = true;
            checkBoxSide.Enabled = false;
            checkBoxSide.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSide.Location = new Point(1654, 686);
            checkBoxSide.Name = "checkBoxSide";
            checkBoxSide.Size = new Size(72, 32);
            checkBoxSide.TabIndex = 9;
            checkBoxSide.Text = "Side";
            checkBoxSide.UseVisualStyleBackColor = true;
            // 
            // buttonStats
            // 
            buttonStats.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStats.Location = new Point(1140, 718);
            buttonStats.Name = "buttonStats";
            buttonStats.Size = new Size(365, 102);
            buttonStats.TabIndex = 10;
            buttonStats.Text = "Stats";
            buttonStats.UseVisualStyleBackColor = true;
            // 
            // checkBoxRangeEnemys
            // 
            checkBoxRangeEnemys.AutoSize = true;
            checkBoxRangeEnemys.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxRangeEnemys.Location = new Point(1140, 200);
            checkBoxRangeEnemys.Name = "checkBoxRangeEnemys";
            checkBoxRangeEnemys.Size = new Size(89, 32);
            checkBoxRangeEnemys.TabIndex = 11;
            checkBoxRangeEnemys.Text = "Range";
            checkBoxRangeEnemys.UseVisualStyleBackColor = true;
            checkBoxRangeEnemys.CheckedChanged += checkBoxRangeEnemys_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1113, 346);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelLVL
            // 
            labelLVL.AutoSize = true;
            labelLVL.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelLVL.Location = new Point(2, 965);
            labelLVL.Name = "labelLVL";
            labelLVL.Size = new Size(54, 35);
            labelLVL.TabIndex = 13;
            labelLVL.Text = "LVL";
            // 
            // listView1
            // 
            listView1.Location = new Point(1354, 228);
            listView1.Name = "listView1";
            listView1.Size = new Size(239, 222);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonEnterUp
            // 
            buttonEnterUp.Location = new Point(1599, 312);
            buttonEnterUp.Name = "buttonEnterUp";
            buttonEnterUp.Size = new Size(171, 55);
            buttonEnterUp.TabIndex = 15;
            buttonEnterUp.Text = "enter";
            buttonEnterUp.UseVisualStyleBackColor = true;
            buttonEnterUp.Click += buttonEnterUp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(buttonEnterUp);
            Controls.Add(listView1);
            Controls.Add(labelLVL);
            Controls.Add(button1);
            Controls.Add(checkBoxRangeEnemys);
            Controls.Add(buttonStats);
            Controls.Add(checkBoxSide);
            Controls.Add(checkBoxMain);
            Controls.Add(panelMain);
            Controls.Add(progressBarExp);
            Controls.Add(hpBarEnemy);
            Controls.Add(hpBarPlayer);
            Controls.Add(buttonNextTurn);
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
        private Button buttonNextTurn;
        private ProgressBar hpBarPlayer;
        private ProgressBar hpBarEnemy;
        private ProgressBar progressBarExp;
        private BufferedPanel panelMain;
        private CheckBox checkBoxMain;
        private CheckBox checkBoxSide;
        private Button buttonStats;
        private CheckBox checkBoxRangeEnemys;
        private Button button1;
        private Label labelLVL;
        private ListView listView1;
        private Button buttonEnterUp;
    }
}