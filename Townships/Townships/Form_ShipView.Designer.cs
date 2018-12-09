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
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(992, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cell-Data";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_hr_2
            // 
            this.label_hr_2.Location = new System.Drawing.Point(994, 123);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(974, 948);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label_data
            // 
            this.label_data.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(995, 144);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(365, 241);
            this.label_data.TabIndex = 8;
            this.label_data.Text = "Type";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1000, 388);
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
            this.button2.Location = new System.Drawing.Point(1000, 423);
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
            this.comboBox1.Location = new System.Drawing.Point(1000, 458);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 26);
            this.comboBox1.TabIndex = 11;
            // 
            // Form_ShipView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1371, 1051);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label_hr_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_hr_1);
            this.Controls.Add(this.label1);
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
    }
}