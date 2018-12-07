namespace Townships
{
    partial class Form_ShipView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_hr_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flow_cells = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Dirty War", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1034, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "{Township NAme}";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_hr_1
            // 
            this.label_hr_1.Location = new System.Drawing.Point(18, 73);
            this.label_hr_1.Name = "label_hr_1";
            this.label_hr_1.Size = new System.Drawing.Size(1037, 1);
            this.label_hr_1.TabIndex = 1;
            this.label_hr_1.Paint += new System.Windows.Forms.PaintEventHandler(this.label_hr_1_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1013, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flow_cells
            // 
            this.flow_cells.AutoScroll = true;
            this.flow_cells.Location = new System.Drawing.Point(12, 91);
            this.flow_cells.Name = "flow_cells";
            this.flow_cells.Size = new System.Drawing.Size(966, 945);
            this.flow_cells.TabIndex = 3;
            this.flow_cells.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.flow_cells_MouseDoubleClick);
            // 
            // Form_ShipView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1364, 1051);
            this.Controls.Add(this.flow_cells);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_hr_1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_ShipView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Township View";
            this.Load += new System.EventHandler(this.Form_ShipView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_hr_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flow_cells;
    }
}