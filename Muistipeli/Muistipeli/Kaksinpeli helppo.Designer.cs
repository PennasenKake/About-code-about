﻿namespace Muistipeli
{
    partial class Kaksinpeli_helppo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaksinpeli_helppo));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslbVuoro = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbPeliAika = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrKuva = new System.Windows.Forms.Timer(this.components);
            this.tmrAika = new System.Windows.Forms.Timer(this.components);
            this.tlbTaulu = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Sulje = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1.SuspendLayout();
            this.tlbTaulu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbVuoro,
            this.tsslbPeliAika});
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(957, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslbVuoro
            // 
            this.tsslbVuoro.Name = "tsslbVuoro";
            this.tsslbVuoro.Size = new System.Drawing.Size(70, 25);
            this.tsslbVuoro.Text = "Vuoro: ";
            // 
            // tsslbPeliAika
            // 
            this.tsslbPeliAika.Name = "tsslbPeliAika";
            this.tsslbPeliAika.Size = new System.Drawing.Size(83, 25);
            this.tsslbPeliAika.Text = "Peli aika: ";
            // 
            // tmrKuva
            // 
            this.tmrKuva.Interval = 750;
            this.tmrKuva.Tick += new System.EventHandler(this.tmrKuva_Tick);
            // 
            // tmrAika
            // 
            this.tmrAika.Interval = 1000;
            this.tmrAika.Tick += new System.EventHandler(this.tmrAika_Tick_1);
            // 
            // tlbTaulu
            // 
            this.tlbTaulu.BackColor = System.Drawing.Color.IndianRed;
            this.tlbTaulu.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlbTaulu.ColumnCount = 4;
            this.tlbTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbTaulu.Controls.Add(this.label16, 3, 3);
            this.tlbTaulu.Controls.Add(this.label15, 2, 3);
            this.tlbTaulu.Controls.Add(this.label14, 1, 3);
            this.tlbTaulu.Controls.Add(this.label13, 0, 3);
            this.tlbTaulu.Controls.Add(this.label12, 3, 2);
            this.tlbTaulu.Controls.Add(this.label11, 2, 2);
            this.tlbTaulu.Controls.Add(this.label10, 1, 2);
            this.tlbTaulu.Controls.Add(this.label9, 0, 2);
            this.tlbTaulu.Controls.Add(this.label8, 3, 1);
            this.tlbTaulu.Controls.Add(this.label7, 2, 1);
            this.tlbTaulu.Controls.Add(this.label6, 1, 1);
            this.tlbTaulu.Controls.Add(this.label5, 0, 1);
            this.tlbTaulu.Controls.Add(this.label4, 3, 0);
            this.tlbTaulu.Controls.Add(this.label3, 2, 0);
            this.tlbTaulu.Controls.Add(this.label2, 1, 0);
            this.tlbTaulu.Controls.Add(this.label1, 0, 0);
            this.tlbTaulu.Location = new System.Drawing.Point(165, 111);
            this.tlbTaulu.Name = "tlbTaulu";
            this.tlbTaulu.RowCount = 4;
            this.tlbTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlbTaulu.Size = new System.Drawing.Size(544, 438);
            this.tlbTaulu.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label16.ForeColor = System.Drawing.Color.IndianRed;
            this.label16.Location = new System.Drawing.Point(410, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 107);
            this.label16.TabIndex = 15;
            this.label16.Text = "s";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label15.ForeColor = System.Drawing.Color.IndianRed;
            this.label15.Location = new System.Drawing.Point(275, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 107);
            this.label15.TabIndex = 14;
            this.label15.Text = "s";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label14.ForeColor = System.Drawing.Color.IndianRed;
            this.label14.Location = new System.Drawing.Point(140, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 107);
            this.label14.TabIndex = 13;
            this.label14.Text = "s";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label13.ForeColor = System.Drawing.Color.IndianRed;
            this.label13.Location = new System.Drawing.Point(5, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 107);
            this.label13.TabIndex = 12;
            this.label13.Text = "s";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.ForeColor = System.Drawing.Color.IndianRed;
            this.label12.Location = new System.Drawing.Point(410, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 107);
            this.label12.TabIndex = 11;
            this.label12.Text = "s";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.ForeColor = System.Drawing.Color.IndianRed;
            this.label11.Location = new System.Drawing.Point(275, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 107);
            this.label11.TabIndex = 10;
            this.label11.Text = "s";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(140, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 107);
            this.label10.TabIndex = 9;
            this.label10.Text = "s";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(5, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 107);
            this.label9.TabIndex = 8;
            this.label9.Text = "s";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(410, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 107);
            this.label8.TabIndex = 7;
            this.label8.Text = "s";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(275, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 107);
            this.label7.TabIndex = 6;
            this.label7.Text = "s";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(140, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 107);
            this.label6.TabIndex = 5;
            this.label6.Text = "s";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(5, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 107);
            this.label5.TabIndex = 4;
            this.label5.Text = "s";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(410, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 107);
            this.label4.TabIndex = 3;
            this.label4.Text = "s";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(275, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 107);
            this.label3.TabIndex = 2;
            this.label3.Text = "s";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(140, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 107);
            this.label2.TabIndex = 1;
            this.label2.Text = "s";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sulje,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(957, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Sulje
            // 
            this.Sulje.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Sulje.Image = ((System.Drawing.Image)(resources.GetObject("Sulje.Image")));
            this.Sulje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sulje.Name = "Sulje";
            this.Sulje.Size = new System.Drawing.Size(53, 29);
            this.Sulje.Text = "Sulje";
            this.Sulje.Click += new System.EventHandler(this.Sulje_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // Kaksinpeli_helppo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 597);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tlbTaulu);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Kaksinpeli_helppo";
            this.Text = "Kaksinpeli_helppo";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tlbTaulu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer tmrKuva;
        private System.Windows.Forms.Timer tmrAika;
        private System.Windows.Forms.TableLayoutPanel tlbTaulu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Sulje;
        private System.Windows.Forms.ToolStripStatusLabel tsslbVuoro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel tsslbPeliAika;
    }
}