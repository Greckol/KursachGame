using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fightgame
{
    public partial class FormMenu : Form
    {
        public const string easy = "easy";
        public const string normal = "normal";
        public const string hard = "hard";
        public const string impossible = "impossible";
        public const string nightmare = "nightmare";

        public FormMenu()
        {
            InitializeComponent();
            comboBoxdifficulty.Items.Add(easy);
            comboBoxdifficulty.Items.Add(normal);
            comboBoxdifficulty.Items.Add(hard);
            comboBoxdifficulty.Items.Add(impossible);
            comboBoxdifficulty.Items.Add(nightmare);
            ///
            comboBoxMainPanelSize.Items.Add("17x17");
            comboBoxMainPanelSize.Items.Add("21x21");
            comboBoxMainPanelSize.Items.Add("25x25");
            comboBoxMainPanelSize.Items.Add("29x29");
            comboBoxMainPanelSize.Items.Add("33x33");

        }

        void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (comboBoxdifficulty.SelectedItem != null &&
                comboBoxMainPanelSize.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(textBoxPlayerName.Text))
            {

                Program.ShouldOpenForm1 = true;
                Program.Difficulty = comboBoxdifficulty.Text;
                Program.PanelSizeWidth = int.Parse(comboBoxMainPanelSize.Text.Split('x')[0]);
                Program.PanelSizeHeight = int.Parse(comboBoxMainPanelSize.Text.Split('x')[1]);
                Program.PlayerName = textBoxPlayerName.Text;
                this.Close();
            }
        }
    }
}
