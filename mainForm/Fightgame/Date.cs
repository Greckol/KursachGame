using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fightgame
{
    public partial class Date : Form
    {
        public Date(Unit unit)
        {
            InitializeComponent();
            dataGridView1.Columns.Add("magnitudeColumn", "Величина");
            dataGridView1.Columns.Add("valueColumn", "Значение");
            dataGridView1.Rows.Add("Name", unit.Name);
            dataGridView1.Rows.Add("Damage", unit.getDamage());
            dataGridView1.Rows.Add("Health", unit.getHealth());
            dataGridView1.Rows.Add("HealthMax", unit.getHealthMax());
            dataGridView1.Rows.Add("Armor", unit.getArmor());
            dataGridView1.Rows.Add("RangeAtack", unit.getRangeAtack());


            /*if (unit is Enemy enemy)
            {
               dataGridView1.Rows.Add("Damage", enemy.getDamage());
               dataGridView1.Rows.Add("AtackCount", enemy.getAtackCount());
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
