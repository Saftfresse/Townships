using ProjectClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Townships.Classes;

namespace Townships
{
    public partial class Form_ShipView : Form
    {
        Township township;
        Bitmap screen;
        Bitmap screen_district;
        TownshipGridCell selectedCell = null;

        public Form_ShipView(Township ship)
        {
            township = ship;
            InitializeComponent();
        }

        private void label_hr_1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush lb = new LinearGradientBrush(label_hr_1.ClientRectangle, Color.FromArgb(70,70,70), Color.FromArgb(19,19,19), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(lb, label_hr_1.ClientRectangle);
        }

        private void Form_ShipView_Load(object sender, EventArgs e)
        {
            foreach (var item in Collection.Buildings)
            {
                ComboBoxItem cbi = new ComboBoxItem();
                cbi.Text = item.Name;
                cbi.Value = item.Uid;
                comboBox1.Items.Add(cbi);
            }
            comboBox1.SelectedIndex = 0;
            screen = new Bitmap(canvas.Width, canvas.Height);
            screen_district = new Bitmap(canvas_district.Width, canvas_district.Height);
            label1.Text = township.Name;
            label2.Text = township.ShipType.ToString() + " Type";
            draw();
            selectedCell = township.Cells.OrderByDescending(x => x.CellTier).ElementAt(0);
            updateDetails();
            drawDistrict();
        }
        
        void draw()
        {
            screen = new Bitmap(canvas.Width, canvas.Height);
            int size = 180, margin = 7, sizeAbs = size + margin, currX = margin, currY = 0, cX = canvas.Width / (size + margin), cY = (int)Math.Ceiling((double)township.Cells.Count / cX), nX = 0, nY = 1;
            
            using (var g = Graphics.FromImage(screen))
            {
                var cells = township.Cells.OrderByDescending(x => x.CellTier);
                foreach (var cell in township.Cells.OrderByDescending(x => x.CellTier))
                {
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                    Color c = new Color();
                    Image tier = Properties.Resources.tiers_0;
                    switch (cell.CellTier)
                    {
                        case TownshipGridCell.TownCellTier.Tier_1:
                            c = Color.FromArgb(23, 31, 102);
                            break;
                        case TownshipGridCell.TownCellTier.Tier_2:
                            tier = Properties.Resources.tiers_1;
                            c = Color.FromArgb(26, 59, 178);
                            break;
                        case TownshipGridCell.TownCellTier.Tier_3:
                            tier = Properties.Resources.tiers_2;
                            c = Color.FromArgb(19, 107, 196);
                            break;
                        case TownshipGridCell.TownCellTier.Tier_4:
                            tier = Properties.Resources.Tiers_3;
                            c = Color.FromArgb(0, 191, 255);
                            break;
                    }
                    cell.Bounds = new Rectangle(currX, currY, size, size);

                    if (cell == selectedCell) g.FillRectangle(new SolidBrush(Color.FromArgb(25,25,25)), cell.Bounds);

                    g.DrawRectangle(new Pen(c, 1), cell.Bounds);
                    g.DrawString(cell.District.Name, new Font("Roboto Lt", 12), new SolidBrush(ForeColor), cell.Bounds.X + 1, cell.Bounds.Y + 6);
                    LinearGradientBrush lg = new LinearGradientBrush(new Point(0, 0), new Point(size + margin, 0), Color.FromArgb(60, 60, 60), Color.FromArgb(19, 19, 19));
                    g.FillRectangle(lg, cell.Bounds.X + 5, cell.Bounds.Y + 30, size - 10, 1);
                    g.DrawString("Size: " + cell.DistrictSize.ToString() + "\n" + "Tier: " + ((int)cell.CellTier + 1), Font, new SolidBrush(ForeColor), cell.Bounds.X + margin, cell.Bounds.Y + 32);
                    g.DrawImage(tier, new Rectangle(cell.Bounds.X + size - 60 - 3, cell.Bounds.Y + 5, 60, 20));


                    if (currX + sizeAbs + size >= screen.Width)
                    {
                        currX = margin;
                        currY += sizeAbs;
                        nY++;
                    }
                    else
                    {
                        currX += sizeAbs;
                    }
                }
                canvas.Height = cY * sizeAbs;
            }
            canvas.Invalidate();
        }

        void drawDistrict()
        {
            screen_district = new Bitmap(canvas_district.Width, canvas_district.Height);
            int rows = selectedCell.District.Plots.GetLength(0), cols = selectedCell.District.Plots.GetLength(1);
            int margin = 7, size = (canvas_district.Width - cols * margin) / cols, sizeAbs = size + margin;
            using (var g = Graphics.FromImage(screen_district))
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                for (int i = 0; i < selectedCell.District.Plots.GetLength(0); i++)
                {
                    for (int j = 0; j < selectedCell.District.Plots.GetLength(1); j++)
                    {
                        DistrictPlotCell cell = selectedCell.District.Plots[i, j];
                        g.DrawRectangle(new Pen(Color.Red), new Rectangle(j * sizeAbs, i * sizeAbs, size, size));
                        if (radio_surface.Checked)
                        {
                            g.DrawString(cell.UpperBuilding.Name, Font, new SolidBrush(Color.White), j * sizeAbs, i * sizeAbs);
                        }
                        else if (radio_underground.Checked)
                        {
                            g.DrawString(cell.LowerBuilding.Name, Font, new SolidBrush(Color.White), j * sizeAbs, i * sizeAbs);
                        }
                    }
                }
            }
            canvas_district.Invalidate();
        }
        
        void updateDetails()
        {
            if (selectedCell != null)
            {
                label_data.Text = string.Format("{0}\n{1}\n{2}\n{3}", selectedCell.Building.Name, selectedCell.CellTier, selectedCell.DistrictSize, selectedCell.District.GetTotalIncome());
                draw();
                drawDistrict();
            }
        }

        private void flow_cells_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush lb = new LinearGradientBrush(new Point(label_hr_2.Width / 2, 0), new Point(0,0), Color.FromArgb(70, 70, 70), Color.FromArgb(19, 19, 19));
            LinearGradientBrush lb2 = new LinearGradientBrush(new Point(label_hr_2.Width / 2, 0), new Point(label_hr_2.Width, 0), Color.FromArgb(70, 70, 70), Color.FromArgb(19, 19, 19));
            e.Graphics.FillRectangle(lb, 0,0,label_hr_2.Width / 2, 1);
            e.Graphics.FillRectangle(lb2, label_hr_2.Width / 2, 0, label_hr_2.Width, 1);
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(screen, 0, 0);
        }

        private void canvas_Resize(object sender, EventArgs e)
        {
            screen = new Bitmap(canvas.Width, canvas.Height);
            draw();
        }

        private void canvas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Form_ShipView_Resize(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width = Width - label_hr_2.Width - 15;
            canvas.Width = flowLayoutPanel1.Width - 24;
            label3.Location = new Point(flowLayoutPanel1.Width - 9, label3.Location.Y);
            label_hr_2.Location = new Point(flowLayoutPanel1.Width - 9, label_hr_2.Location.Y);
            draw();
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            TownshipGridCell cell = township.Cells.Find(x => x.Bounds.Contains(e.Location));
            if (cell != null) selectedCell = cell;
            updateDetails();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedCell.CellTier < TownshipGridCell.TownCellTier.Tier_4) selectedCell.CellTier++;
            draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Building b = null;
            Console.WriteLine(((ComboBoxItem)comboBox1.SelectedItem).Value);
            selectedCell.Building = Collection.Buildings.Find(x => x.Uid == (Guid)((ComboBoxItem)comboBox1.SelectedItem).Value);

            updateDetails();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void canvas_district_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(screen_district, 0, 0);
        }

        private void label_hr_3_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush lb = new LinearGradientBrush(label_hr_3.ClientRectangle, Color.FromArgb(70, 70, 70), Color.FromArgb(19, 19, 19), LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(new SolidBrush(lb.LinearColors[0]), label_hr_3.ClientRectangle);
        }

        private void btn_config_close_Click(object sender, EventArgs e)
        {
            panel_config.Hide();
        }

        private void btn_command_center_Click(object sender, EventArgs e)
        {
            panel_config.Show();
            panel_config.BringToFront();
        }

        private void radio_surface_CheckedChanged(object sender, EventArgs e)
        {
            drawDistrict();
        }

        private void radio_underground_CheckedChanged(object sender, EventArgs e)
        {
            drawDistrict();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedCell.District.Plots[0, 0].UpperBuilding.Name = "Set over!";
            selectedCell.District.Plots[0, 0].LowerBuilding.Name = "Set under!";
            drawDistrict();
        }
    }
}
