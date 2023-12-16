using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fightgame
{
    public class Shop
    {
        public Shop(ListView listView)
        {
            shop = new Dictionary<string, int>();
            listView.Columns.Add("Stat", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Cost", -2, HorizontalAlignment.Left);
            listView.View = View.Details;
            fill();

        }
        Dictionary<string, int> shop;
        public Dictionary<string, int> getShop()
        {
            return shop;
        }


        int damageCost = 5;
        int HealthCost = 5;
        int CritDamageCost = 10;
        

        void fill()
        {
            shop.Add("Damage", damageCost);
            shop.Add("Health", HealthCost);
            shop.Add("CritDamage", CritDamageCost);
        }

        public void refresh(ListView listView)
        {
            listView.Items.Clear();
            foreach (var pair in shop)
            {
                ListViewItem item = new ListViewItem(pair.Key.ToString());
                item.SubItems.Add(pair.Value.ToString());
                listView.Items.Add(item);
            }
        }

        public void refreshCost(ListView listView, ListViewItem listViewItem)
        {
            if (listViewItem.Text == "Damage")
            {
                damageCost *= 2;
                shop[listViewItem.Text] = damageCost;
            }
            refresh(listView);
        }
        
    }
}
