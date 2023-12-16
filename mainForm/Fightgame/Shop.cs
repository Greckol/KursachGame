﻿using System;
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
            dictionaryShop = new Dictionary<string, int>();
            FillColumns(listView);
            listView.View = View.Details;
            
            //fill();
        }

        protected virtual void FillColumns(ListView listView)
        {
            listView.Columns.Add("Stat", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Cost Gold", -2, HorizontalAlignment.Left);
        }
        //private static Shop shopM;
        /*public static Shop GetInstance(ListView listView = null)
        {
            if (shopM == null)
            {
                shopM = new Shop(listView);
            }
            return shopM;
        }*/
        protected Dictionary<string, int> dictionaryShop;
        public Dictionary<string, int> getShop()
        {
            return dictionaryShop;
        }


        int damageCost = 5;
        int healthCost = 5;
        int critChanceCost = 10;
        int rangeAtackCost = 100;
        int healthRegenerationCost = 50;
        int armorCost = 15;
        int healthFullRegencCOst = 100;

        public const string damage = "Damage";
        public const string healthFullRegen = "HealthFullRegen";
        public const string healthMax = "HealthMax";
        public const string health = "Health";
        public const string healthRegeneration = "HealthRegeneration";
        public const string armor = "Armor";
        public const string rangeAtack = "RangeAtack";
        public const string critChance = "CritChance";



        public virtual void fill(ListView listView)
        {
            dictionaryShop.Add(healthMax, healthCost);
            dictionaryShop.Add(healthRegeneration, healthRegenerationCost);
            dictionaryShop.Add(armor, armorCost);
            dictionaryShop.Add(damage, damageCost);
            dictionaryShop.Add(critChance, critChanceCost);
            dictionaryShop.Add(rangeAtack, rangeAtackCost);
            dictionaryShop.Add(healthFullRegen, healthFullRegencCOst);
            refresh(listView);
        }

        protected void refresh(ListView listView)
        {
            listView.Items.Clear();
            foreach (var pair in dictionaryShop)
            {
                ListViewItem item = new ListViewItem(pair.Key.ToString());
                item.SubItems.Add(pair.Value.ToString());
                listView.Items.Add(item);
            }
        }

        public void refreshCost(ListView listView, ListViewItem listViewItem)
        {
            switch (listViewItem.Text)
            {
                case damage:
                    damageCost *= 2;
                    dictionaryShop[listViewItem.Text] = damageCost;
                    break;
                case healthMax:
                    healthCost *= 2;
                    dictionaryShop[listViewItem.Text] = healthCost;
                    break;
                case critChance:
                    critChanceCost *= 2;
                    dictionaryShop[listViewItem.Text] = critChanceCost;
                    break;
                case rangeAtack:
                    rangeAtackCost *= 2;
                    dictionaryShop[listViewItem.Text] = rangeAtackCost;
                    break;
                case armor:
                    armorCost *= 2;
                    dictionaryShop[listViewItem.Text] = armorCost;
                    break;
                case healthRegeneration:
                    healthRegenerationCost *= 2;
                    dictionaryShop[listViewItem.Text] = healthRegenerationCost;
                    break;
                case healthFullRegen:
                    break;
                default:
                    break;
            }

            refresh(listView);
        }


        public void buttonEnterRefresh(ListViewItem listViewItem, Button button)
        {
            if (Player.GetInstance().getGold() < dictionaryShop[listViewItem.Text])
            {
                button.Enabled = false;
            }
            else button.Enabled = true;
        }
    }
}
