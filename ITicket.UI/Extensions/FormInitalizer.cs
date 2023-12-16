using ITicket.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITicket.UI.Extensions
{
    public static  class FormInitalizer
    {
        public static void InitalizeEventTypeComboBox(this ComboBox comboBox)
        {
            comboBox.Items.Add("All");
            comboBox.Items.Add(EventType.Sport);
            comboBox.Items.Add(EventType.Science);
            comboBox.Items.Add(EventType.Concert);
            comboBox.Items.Add(EventType.Other);
            comboBox.SelectedIndex = 0;
        }
        public static void InitalizePriceComboBox(this ComboBox comboBox)
        {
            comboBox.Items.Add("More than");
            comboBox.Items.Add("Less than");
            comboBox.SelectedIndex = 0;
        }
        public static void InitalizeNumberComboBox(this ComboBox comboBox) 
        {
            for(int i=1; i<=5; i++)
            {
                comboBox.Items.Add(i.ToString());
            }
            comboBox.SelectedIndex = 0;
        }
        public static void InitalizeDateComboBox(this ComboBox comboBox)
        {
            comboBox.Items.Add("Ascending");
            comboBox.Items.Add("Descending");
            comboBox.SelectedIndex = 0;
        }
    }
}
