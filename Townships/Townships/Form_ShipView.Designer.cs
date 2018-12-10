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
            this.label3 = new System.Windows.Forms.Label();
            this.label_hr_2 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_data = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.canvas_district = new System.Windows.Forms.PictureBox();
            this.label_hr_3 = new System.Windows.Forms.Label();
            this.radio_surface = new System.Windows.Forms.RadioButton();
            this.radio_underground = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_config = new System.Windows.Forms.Panel();
            this.btn_config_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_command_center = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas_district)).BeginInit();
            this.panel_config.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Dirty War", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1034, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "{Township NAme}";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_hr_1
            // 
            this.label_hr_1.Location = new System.Drawing.Point(5, 69);
            this.label_hr_1.Name = "label_hr_1";
            this.label_hr_1.Size = new System.Drawing.Size(1037, 1);
            this.label_hr_1.TabIndex = 1;
            this.label_hr_1.Paint += new System.Windows.Forms.PaintEventHandler(this.label_hr_1_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1013, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(979, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cell-Data";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_hr_2
            // 
            this.label_hr_2.Location = new System.Drawing.Point(981, 119);
            this.label_hr_2.Name = "label_hr_2";
            this.label_hr_2.Size = new System.Drawing.Size(372, 1);
            this.label_hr_2.TabIndex = 5;
            this.label_hr_2.Paint += new System.Windows.Forms.PaintEventHandler(this.label4_Paint);
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(3, 3);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(940, 383);
            this.canvas.TabIndex = 6;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.Resize += new System.EventHandler(this.canvas_Resize);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.canvas);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(974, 375);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label_data
            // 
            this.label_data.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(982, 140);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(365, 218);
            this.label_data.TabIndex = 8;
            this.label_data.Text = "Type";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(987, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Upgrade Plot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(987, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(366, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Build";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(987, 431);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 26);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // canvas_district
            // 
            this.canvas_district.Location = new System.Drawing.Point(12, 522);
            this.canvas_district.Name = "canvas_district";
            this.canvas_district.Size = new System.Drawing.Size(630, 630);
            this.canvas_district.TabIndex = 12;
            this.canvas_district.TabStop = false;
            this.canvas_district.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_district_Paint);
            // 
            // label_hr_3
            // 
            this.label_hr_3.Location = new System.Drawing.Point(9, 475);
            this.label_hr_3.Name = "label_hr_3";
            this.label_hr_3.Size = new System.Drawing.Size(1350, 1);
            this.label_hr_3.TabIndex = 13;
            this.label_hr_3.Paint += new System.Windows.Forms.PaintEventHandler(this.label_hr_3_Paint);
            // 
            // radio_surface
            // 
            this.radio_surface.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_surface.Checked = true;
            this.radio_surface.FlatAppearance.BorderSize = 0;
            this.radio_surface.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.radio_surface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radio_surface.Location = new System.Drawing.Point(12, 487);
            this.radio_surface.Name = "radio_surface";
            this.radio_surface.Size = new System.Drawing.Size(316, 29);
            this.radio_surface.TabIndex = 14;
            this.radio_surface.TabStop = true;
            this.radio_surface.Text = "Surface";
            this.radio_surface.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_surface.UseVisualStyleBackColor = true;
            this.radio_surface.CheckedChanged += new System.EventHandler(this.radio_surface_CheckedChanged);
            // 
            // radio_underground
            // 
            this.radio_underground.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_underground.FlatAppearance.BorderSize = 0;
            this.radio_underground.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.radio_underground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radio_underground.Location = new System.Drawing.Point(326, 487);
            this.radio_underground.Name = "radio_underground";
            this.radio_underground.Size = new System.Drawing.Size(316, 29);
            this.radio_underground.TabIndex = 15;
            this.radio_underground.Text = "Underground";
            this.radio_underground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_underground.UseVisualStyleBackColor = true;
            this.radio_underground.CheckedChanged += new System.EventHandler(this.radio_underground_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label4.Location = new System.Drawing.Point(648, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 677);
            this.label4.TabIndex = 16;
            // 
            // panel_config
            // 
            this.panel_config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_config.Controls.Add(this.btn_config_close);
            this.panel_config.Location = new System.Drawing.Point(268, 261);
            this.panel_config.Name = "panel_config";
            this.panel_config.Size = new System.Drawing.Size(838, 627);
            this.panel_config.TabIndex = 17;
            // 
            // btn_config_close
            // 
            this.btn_config_close.FlatAppearance.BorderSize = 0;
            this.btn_config_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config_close.Location = new System.Drawing.Point(237, 593);
            this.btn_config_close.Name = "btn_config_close";
            this.btn_config_close.Size = new System.Drawing.Size(366, 29);
            this.btn_config_close.TabIndex = 11;
            this.btn_config_close.Text = "Close";
            this.btn_config_close.UseVisualStyleBackColor = true;
            this.btn_config_close.Click += new System.EventHandler(this.btn_config_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_command_center);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label_hr_1);
            this.panel1.Controls.Add(this.radio_underground);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radio_surface);
            this.panel1.Controls.Add(this.label_hr_3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.canvas_district);
            this.panel1.Controls.Add(this.label_hr_2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label_data);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1373, 1164);
            this.panel1.TabIndex = 18;
            // 
            // btn_command_center
            // 
            this.btn_command_center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_command_center.FlatAppearance.BorderSize = 0;
            this.btn_command_center.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_command_center.Location = new System.Drawing.Point(1007, 0);
            this.btn_command_center.Name = "btn_command_center";
            this.btn_command_center.Size = new System.Drawing.Size(366, 29);
            this.btn_command_center.TabIndex = 17;
            this.btn_command_center.Text = "Township Command-Center";
            this.btn_command_center.UseVisualStyleBackColor = false;
            this.btn_command_center.Click += new System.EventHandler(this.btn_command_center_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(715, 616);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(366, 29);
            this.button3.TabIndex = 18;
            this.button3.Text = "Upgrade Plot";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_ShipView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1371, 1164);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_config);
            this.Font = new System.Drawing.Font("Roboto Lt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ShipView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Township View";
            this.Load += new System.EventHandler(this.Form_ShipView_Load);
            this.Resize += new System.EventHandler(this.Form_ShipView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas_district)).EndInit();
            this.panel_config.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_hr_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_hr_2;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox canvas_district;
        private System.Windows.Forms.Label label_hr_3;
        private System.Windows.Forms.RadioButton radio_surface;
        private System.Windows.Forms.RadioButton radio_underground;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_config;
        private System.Windows.Forms.Button btn_config_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_command_center;
        private System.Windows.Forms.Button button3;
    }
}