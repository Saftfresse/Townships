using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Townships.Classes;

namespace Townships
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        
        Gameworld world = new Gameworld();

        void addShips()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            world.Ships.Add(new WaterTownship() {  Name = "New Pilgrim" });
            Console.WriteLine(world.Ships.Count);
            world.Ships[0].Cells[0].Building = Collection.GetBuilding(Collection.Building.Factory_Small);
            Console.WriteLine(world.Ships[0].Cells[0].Building.Name);
            updateList();
        }

        void updateList()
        {
            view_ships.Items.Clear();
            foreach (var item in world.Ships)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = item.Uid;
                lvi.Text = item.Name;
                lvi.SubItems.Add(item.ShipType.ToString());
                lvi.SubItems.Add(item.Cells.Count.ToString());
                view_ships.Items.Add(lvi);
            }
        }

        private void view_ships_DoubleClick(object sender, EventArgs e)
        {
            if (view_ships.SelectedItems.Count > 0)
            {
                foreach (var item in world.Ships)
                {
                    if (item.Uid == (Guid)view_ships.SelectedItems[0].Tag)
                    {

                    }
                }
                Form_ShipView f = new Form_ShipView(world.Ships.Find(x => x.Uid == (Guid)view_ships.SelectedItems[0].Tag));
                f.Show();
            }
        }
    }
}
