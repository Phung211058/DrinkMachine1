namespace Form1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rad_mango = new System.Windows.Forms.RadioButton();
            this.rad_orange = new System.Windows.Forms.RadioButton();
            this.rad_water = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rad_juice = new System.Windows.Forms.RadioButton();
            this.rad_smoothie = new System.Windows.Forms.RadioButton();
            this.pgress_cutter = new System.Windows.Forms.ProgressBar();
            this.pgress_cleanser = new System.Windows.Forms.ProgressBar();
            this.pgress_presser = new System.Windows.Forms.ProgressBar();
            this.pgress_blender = new System.Windows.Forms.ProgressBar();
            this.btn_success = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pgress_filter = new System.Windows.Forms.ProgressBar();
            this.lbl_percent_cutter = new System.Windows.Forms.Label();
            this.lbl_percent_blender = new System.Windows.Forms.Label();
            this.lbl_percent_cleanser = new System.Windows.Forms.Label();
            this.lbl_percent_presser = new System.Windows.Forms.Label();
            this.lbl_percent_filter = new System.Windows.Forms.Label();
            this.lbl_announce = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rad_mango);
            this.panel1.Controls.Add(this.rad_orange);
            this.panel1.Controls.Add(this.rad_water);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 412);
            this.panel1.TabIndex = 0;
            // 
            // rad_mango
            // 
            this.rad_mango.AutoSize = true;
            this.rad_mango.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_mango.Location = new System.Drawing.Point(119, 317);
            this.rad_mango.Name = "rad_mango";
            this.rad_mango.Size = new System.Drawing.Size(103, 29);
            this.rad_mango.TabIndex = 2;
            this.rad_mango.Text = "Mango";
            this.rad_mango.UseVisualStyleBackColor = true;
            // 
            // rad_orange
            // 
            this.rad_orange.AutoSize = true;
            this.rad_orange.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_orange.Location = new System.Drawing.Point(117, 217);
            this.rad_orange.Name = "rad_orange";
            this.rad_orange.Size = new System.Drawing.Size(105, 29);
            this.rad_orange.TabIndex = 1;
            this.rad_orange.Text = "Orange";
            this.rad_orange.UseVisualStyleBackColor = true;
            // 
            // rad_water
            // 
            this.rad_water.AutoSize = true;
            this.rad_water.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_water.Location = new System.Drawing.Point(119, 134);
            this.rad_water.Name = "rad_water";
            this.rad_water.Size = new System.Drawing.Size(165, 29);
            this.rad_water.TabIndex = 0;
            this.rad_water.Text = "WaterLemon";
            this.rad_water.UseVisualStyleBackColor = true;
            this.rad_water.CheckedChanged += new System.EventHandler(this.rad_water_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.rad_juice);
            this.panel2.Controls.Add(this.rad_smoothie);
            this.panel2.Location = new System.Drawing.Point(2, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 268);
            this.panel2.TabIndex = 1;
            // 
            // rad_juice
            // 
            this.rad_juice.AutoSize = true;
            this.rad_juice.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_juice.Location = new System.Drawing.Point(160, 203);
            this.rad_juice.Name = "rad_juice";
            this.rad_juice.Size = new System.Drawing.Size(89, 29);
            this.rad_juice.TabIndex = 1;
            this.rad_juice.Text = "Juice";
            this.rad_juice.UseVisualStyleBackColor = true;
            // 
            // rad_smoothie
            // 
            this.rad_smoothie.AutoSize = true;
            this.rad_smoothie.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_smoothie.Location = new System.Drawing.Point(160, 110);
            this.rad_smoothie.Name = "rad_smoothie";
            this.rad_smoothie.Size = new System.Drawing.Size(128, 29);
            this.rad_smoothie.TabIndex = 0;
            this.rad_smoothie.Text = "Smoothie";
            this.rad_smoothie.UseVisualStyleBackColor = true;
            // 
            // pgress_cutter
            // 
            this.pgress_cutter.BackColor = System.Drawing.SystemColors.Control;
            this.pgress_cutter.ForeColor = System.Drawing.Color.IndianRed;
            this.pgress_cutter.Location = new System.Drawing.Point(596, 88);
            this.pgress_cutter.Name = "pgress_cutter";
            this.pgress_cutter.Size = new System.Drawing.Size(341, 40);
            this.pgress_cutter.TabIndex = 2;
            // 
            // pgress_cleanser
            // 
            this.pgress_cleanser.Location = new System.Drawing.Point(596, 259);
            this.pgress_cleanser.Name = "pgress_cleanser";
            this.pgress_cleanser.Size = new System.Drawing.Size(341, 40);
            this.pgress_cleanser.TabIndex = 3;
            // 
            // pgress_presser
            // 
            this.pgress_presser.Location = new System.Drawing.Point(596, 347);
            this.pgress_presser.Name = "pgress_presser";
            this.pgress_presser.Size = new System.Drawing.Size(341, 40);
            this.pgress_presser.TabIndex = 4;
            // 
            // pgress_blender
            // 
            this.pgress_blender.Location = new System.Drawing.Point(596, 171);
            this.pgress_blender.Name = "pgress_blender";
            this.pgress_blender.Size = new System.Drawing.Size(341, 40);
            this.pgress_blender.TabIndex = 5;
            // 
            // btn_success
            // 
            this.btn_success.Location = new System.Drawing.Point(682, 580);
            this.btn_success.Name = "btn_success";
            this.btn_success.Size = new System.Drawing.Size(137, 39);
            this.btn_success.TabIndex = 6;
            this.btn_success.Text = "OK >>>";
            this.btn_success.UseVisualStyleBackColor = true;
            this.btn_success.Click += new System.EventHandler(this.btn_ok_Click_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pgress_filter
            // 
            this.pgress_filter.Location = new System.Drawing.Point(596, 435);
            this.pgress_filter.Name = "pgress_filter";
            this.pgress_filter.Size = new System.Drawing.Size(341, 40);
            this.pgress_filter.TabIndex = 7;
            // 
            // lbl_percent_cutter
            // 
            this.lbl_percent_cutter.AutoSize = true;
            this.lbl_percent_cutter.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percent_cutter.Location = new System.Drawing.Point(981, 92);
            this.lbl_percent_cutter.Name = "lbl_percent_cutter";
            this.lbl_percent_cutter.Size = new System.Drawing.Size(0, 36);
            this.lbl_percent_cutter.TabIndex = 8;
            // 
            // lbl_percent_blender
            // 
            this.lbl_percent_blender.AutoSize = true;
            this.lbl_percent_blender.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percent_blender.Location = new System.Drawing.Point(981, 175);
            this.lbl_percent_blender.Name = "lbl_percent_blender";
            this.lbl_percent_blender.Size = new System.Drawing.Size(0, 36);
            this.lbl_percent_blender.TabIndex = 9;
            // 
            // lbl_percent_cleanser
            // 
            this.lbl_percent_cleanser.AutoSize = true;
            this.lbl_percent_cleanser.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percent_cleanser.Location = new System.Drawing.Point(981, 263);
            this.lbl_percent_cleanser.Name = "lbl_percent_cleanser";
            this.lbl_percent_cleanser.Size = new System.Drawing.Size(0, 36);
            this.lbl_percent_cleanser.TabIndex = 10;
            // 
            // lbl_percent_presser
            // 
            this.lbl_percent_presser.AutoSize = true;
            this.lbl_percent_presser.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percent_presser.Location = new System.Drawing.Point(981, 351);
            this.lbl_percent_presser.Name = "lbl_percent_presser";
            this.lbl_percent_presser.Size = new System.Drawing.Size(0, 36);
            this.lbl_percent_presser.TabIndex = 11;
            // 
            // lbl_percent_filter
            // 
            this.lbl_percent_filter.AutoSize = true;
            this.lbl_percent_filter.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percent_filter.Location = new System.Drawing.Point(981, 439);
            this.lbl_percent_filter.Name = "lbl_percent_filter";
            this.lbl_percent_filter.Size = new System.Drawing.Size(0, 36);
            this.lbl_percent_filter.TabIndex = 12;
            // 
            // lbl_announce
            // 
            this.lbl_announce.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_announce.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_announce.Location = new System.Drawing.Point(578, 517);
            this.lbl_announce.Name = "lbl_announce";
            this.lbl_announce.Size = new System.Drawing.Size(396, 36);
            this.lbl_announce.TabIndex = 13;
            this.lbl_announce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker3_ProgressChanged);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.WorkerReportsProgress = true;
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            this.backgroundWorker4.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker4_ProgressChanged);
            this.backgroundWorker4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker4_RunWorkerCompleted);
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.WorkerReportsProgress = true;
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
            this.backgroundWorker5.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker5_ProgressChanged);
            this.backgroundWorker5.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker5_RunWorkerCompleted);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Form1.Properties.Resources.juice;
            this.pictureBox5.Location = new System.Drawing.Point(32, 193);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Form1.Properties.Resources.sinhto_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(32, 89);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Form1.Properties.Resources.mango;
            this.pictureBox3.Location = new System.Drawing.Point(32, 301);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Form1.Properties.Resources.orange_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(32, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Form1.Properties.Resources.watermelon;
            this.pictureBox1.Location = new System.Drawing.Point(32, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.label1.Location = new System.Drawing.Point(640, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 55);
            this.label1.TabIndex = 14;
            this.label1.Text = "Progess";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 51);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choose Fruit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 51);
            this.label3.TabIndex = 16;
            this.label3.Text = "Choose Drink";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label4.Location = new System.Drawing.Point(449, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cleanser";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label5.Location = new System.Drawing.Point(449, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Filter";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label6.Location = new System.Drawing.Point(449, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Presser";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label7.Location = new System.Drawing.Point(449, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Blender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.label8.Location = new System.Drawing.Point(449, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cutter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 731);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_announce);
            this.Controls.Add(this.lbl_percent_filter);
            this.Controls.Add(this.lbl_percent_presser);
            this.Controls.Add(this.lbl_percent_cleanser);
            this.Controls.Add(this.lbl_percent_blender);
            this.Controls.Add(this.lbl_percent_cutter);
            this.Controls.Add(this.pgress_filter);
            this.Controls.Add(this.btn_success);
            this.Controls.Add(this.pgress_blender);
            this.Controls.Add(this.pgress_presser);
            this.Controls.Add(this.pgress_cleanser);
            this.Controls.Add(this.pgress_cutter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar pgress_cutter;
        private System.Windows.Forms.ProgressBar pgress_cleanser;
        private System.Windows.Forms.ProgressBar pgress_presser;
        private System.Windows.Forms.ProgressBar pgress_blender;
        private System.Windows.Forms.Button btn_success;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rad_mango;
        private System.Windows.Forms.RadioButton rad_orange;
        private System.Windows.Forms.RadioButton rad_water;
        private System.Windows.Forms.RadioButton rad_juice;
        private System.Windows.Forms.RadioButton rad_smoothie;
        private System.Windows.Forms.ProgressBar pgress_filter;
        private System.Windows.Forms.Label lbl_percent_cutter;
        private System.Windows.Forms.Label lbl_percent_blender;
        private System.Windows.Forms.Label lbl_percent_cleanser;
        private System.Windows.Forms.Label lbl_percent_presser;
        private System.Windows.Forms.Label lbl_percent_filter;
        private System.Windows.Forms.Label lbl_announce;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

