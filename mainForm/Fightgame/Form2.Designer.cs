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
            panel1 = new Panel();
            buttonHit = new Button();
            panel2 = new Panel();
            timer2 = new System.Windows.Forms.Timer(components);
            labelEnemyName = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(469, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 200);
            panel1.TabIndex = 0;
            // 
            // buttonHit
            // 
            buttonHit.Location = new Point(469, 520);
            buttonHit.Name = "buttonHit";
            buttonHit.Size = new Size(492, 144);
            buttonHit.TabIndex = 1;
            buttonHit.Text = "Hit";
            buttonHit.UseVisualStyleBackColor = true;
            buttonHit.Click += buttonHit_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(788, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 220);
            panel2.TabIndex = 2;
            // 
            // labelEnemyName
            // 
            labelEnemyName.AutoSize = true;
            labelEnemyName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnemyName.Location = new Point(905, 58);
            labelEnemyName.Name = "labelEnemyName";
            labelEnemyName.Size = new Size(109, 46);
            labelEnemyName.TabIndex = 3;
            labelEnemyName.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(labelEnemyName);
            Controls.Add(panel2);
            Controls.Add(buttonHit);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Button buttonHit;
        private Panel panel2;
        private System.Windows.Forms.Timer timer2;
        private Label labelEnemyName;
    }
}