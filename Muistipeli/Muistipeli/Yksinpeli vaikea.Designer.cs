﻿namespace Muistipeli
{
    partial class Yksinpeli_vaikea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yksinpeli_vaikea));
            this.tmrKuva = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslbArvaukset = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbKulunutAika = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrAika = new System.Windows.Forms.Timer(this.components);
            this.tlpTaulu = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
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
            this.tsbSulje = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.tlpTaulu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrKuva
            // 
            this.tmrKuva.Interval = 750;
            this.tmrKuva.Tick += new System.EventHandler(this.tmrKuva_Tick_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslbArvaukset,
            this.tsslbKulunutAika});
            this.statusStrip1.Location = new System.Drawing.Point(0, 800);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1054, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslbArvaukset
            // 
            this.sslbArvaukset.Name = "sslbArvaukset";
            this.sslbArvaukset.Size = new System.Drawing.Size(99, 25);
            this.sslbArvaukset.Text = "Arvaukset: ";
            // 
            // tsslbKulunutAika
            // 
            this.tsslbKulunutAika.Name = "tsslbKulunutAika";
            this.tsslbKulunutAika.Size = new System.Drawing.Size(20, 25);
            this.tsslbKulunutAika.Text = "..";
            // 
            // tmrAika
            // 
            this.tmrAika.Interval = 1000;
            this.tmrAika.Tick += new System.EventHandler(this.tmrAika_Tick_1);
            // 
            // tlpTaulu
            // 
            this.tlpTaulu.BackColor = System.Drawing.Color.SkyBlue;
            this.tlpTaulu.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpTaulu.ColumnCount = 4;
            this.tlpTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTaulu.Controls.Add(this.label24, 3, 5);
            this.tlpTaulu.Controls.Add(this.label23, 2, 5);
            this.tlpTaulu.Controls.Add(this.label22, 1, 5);
            this.tlpTaulu.Controls.Add(this.label21, 0, 5);
            this.tlpTaulu.Controls.Add(this.label20, 3, 4);
            this.tlpTaulu.Controls.Add(this.label19, 2, 4);
            this.tlpTaulu.Controls.Add(this.label18, 1, 4);
            this.tlpTaulu.Controls.Add(this.label17, 0, 4);
            this.tlpTaulu.Controls.Add(this.label16, 3, 3);
            this.tlpTaulu.Controls.Add(this.label15, 2, 3);
            this.tlpTaulu.Controls.Add(this.label14, 1, 3);
            this.tlpTaulu.Controls.Add(this.label13, 0, 3);
            this.tlpTaulu.Controls.Add(this.label12, 3, 2);
            this.tlpTaulu.Controls.Add(this.label11, 2, 2);
            this.tlpTaulu.Controls.Add(this.label10, 1, 2);
            this.tlpTaulu.Controls.Add(this.label9, 0, 2);
            this.tlpTaulu.Controls.Add(this.label8, 3, 1);
            this.tlpTaulu.Controls.Add(this.label7, 2, 1);
            this.tlpTaulu.Controls.Add(this.label6, 1, 1);
            this.tlpTaulu.Controls.Add(this.label5, 0, 1);
            this.tlpTaulu.Controls.Add(this.label4, 3, 0);
            this.tlpTaulu.Controls.Add(this.label3, 2, 0);
            this.tlpTaulu.Controls.Add(this.label2, 1, 0);
            this.tlpTaulu.Controls.Add(this.label1, 0, 0);
            this.tlpTaulu.Location = new System.Drawing.Point(90, 37);
            this.tlpTaulu.Name = "tlpTaulu";
            this.tlpTaulu.RowCount = 6;
            this.tlpTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpTaulu.Size = new System.Drawing.Size(734, 616);
            this.tlpTaulu.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label24.ForeColor = System.Drawing.Color.SkyBlue;
            this.label24.Location = new System.Drawing.Point(554, 512);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(175, 102);
            this.label24.TabIndex = 25;
            this.label24.Text = "s";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label24.Click += new System.EventHandler(this.label1_Click);
            // 
            // label23
            // 
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label23.ForeColor = System.Drawing.Color.SkyBlue;
            this.label23.Location = new System.Drawing.Point(371, 512);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(175, 102);
            this.label23.TabIndex = 24;
            this.label23.Text = "s";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label23.Click += new System.EventHandler(this.label1_Click);
            // 
            // label22
            // 
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label22.ForeColor = System.Drawing.Color.SkyBlue;
            this.label22.Location = new System.Drawing.Point(188, 512);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(175, 102);
            this.label22.TabIndex = 23;
            this.label22.Text = "s";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Click += new System.EventHandler(this.label1_Click);
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label21.ForeColor = System.Drawing.Color.SkyBlue;
            this.label21.Location = new System.Drawing.Point(5, 512);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(175, 102);
            this.label21.TabIndex = 22;
            this.label21.Text = "s";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.Click += new System.EventHandler(this.label1_Click);
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label20.ForeColor = System.Drawing.Color.SkyBlue;
            this.label20.Location = new System.Drawing.Point(554, 410);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(175, 100);
            this.label20.TabIndex = 21;
            this.label20.Text = "s";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.label1_Click);
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label19.ForeColor = System.Drawing.Color.SkyBlue;
            this.label19.Location = new System.Drawing.Point(371, 410);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(175, 100);
            this.label19.TabIndex = 20;
            this.label19.Text = "s";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.Click += new System.EventHandler(this.label1_Click);
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label18.ForeColor = System.Drawing.Color.SkyBlue;
            this.label18.Location = new System.Drawing.Point(188, 410);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(175, 100);
            this.label18.TabIndex = 19;
            this.label18.Text = "s";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.label1_Click);
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label17.ForeColor = System.Drawing.Color.SkyBlue;
            this.label17.Location = new System.Drawing.Point(5, 410);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(175, 100);
            this.label17.TabIndex = 18;
            this.label17.Text = "s";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.label1_Click);
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label16.ForeColor = System.Drawing.Color.SkyBlue;
            this.label16.Location = new System.Drawing.Point(554, 308);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 100);
            this.label16.TabIndex = 17;
            this.label16.Text = "s";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label15.ForeColor = System.Drawing.Color.SkyBlue;
            this.label15.Location = new System.Drawing.Point(371, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 100);
            this.label15.TabIndex = 16;
            this.label15.Text = "s";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label14.ForeColor = System.Drawing.Color.SkyBlue;
            this.label14.Location = new System.Drawing.Point(188, 308);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 100);
            this.label14.TabIndex = 15;
            this.label14.Text = "s";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label13.ForeColor = System.Drawing.Color.SkyBlue;
            this.label13.Location = new System.Drawing.Point(5, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 100);
            this.label13.TabIndex = 14;
            this.label13.Text = "s";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.ForeColor = System.Drawing.Color.SkyBlue;
            this.label12.Location = new System.Drawing.Point(554, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 100);
            this.label12.TabIndex = 13;
            this.label12.Text = "s";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.ForeColor = System.Drawing.Color.SkyBlue;
            this.label11.Location = new System.Drawing.Point(371, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 100);
            this.label11.TabIndex = 12;
            this.label11.Text = "s";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.ForeColor = System.Drawing.Color.SkyBlue;
            this.label10.Location = new System.Drawing.Point(188, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 100);
            this.label10.TabIndex = 11;
            this.label10.Text = "s";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.ForeColor = System.Drawing.Color.SkyBlue;
            this.label9.Location = new System.Drawing.Point(5, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 100);
            this.label9.TabIndex = 10;
            this.label9.Text = "s";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.ForeColor = System.Drawing.Color.SkyBlue;
            this.label8.Location = new System.Drawing.Point(554, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 100);
            this.label8.TabIndex = 9;
            this.label8.Text = "s";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.ForeColor = System.Drawing.Color.SkyBlue;
            this.label7.Location = new System.Drawing.Point(371, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 100);
            this.label7.TabIndex = 8;
            this.label7.Text = "s";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.ForeColor = System.Drawing.Color.SkyBlue;
            this.label6.Location = new System.Drawing.Point(188, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 100);
            this.label6.TabIndex = 7;
            this.label6.Text = "s";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.ForeColor = System.Drawing.Color.SkyBlue;
            this.label5.Location = new System.Drawing.Point(5, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 100);
            this.label5.TabIndex = 6;
            this.label5.Text = "s";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.ForeColor = System.Drawing.Color.SkyBlue;
            this.label4.Location = new System.Drawing.Point(554, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 100);
            this.label4.TabIndex = 5;
            this.label4.Text = "s";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(371, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 100);
            this.label3.TabIndex = 4;
            this.label3.Text = "s";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(188, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 100);
            this.label2.TabIndex = 3;
            this.label2.Text = "s";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSulje});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1054, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSulje
            // 
            this.tsbSulje.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSulje.Image = ((System.Drawing.Image)(resources.GetObject("tsbSulje.Image")));
            this.tsbSulje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSulje.Name = "tsbSulje";
            this.tsbSulje.Size = new System.Drawing.Size(53, 29);
            this.tsbSulje.Text = "Sulje";
            // 
            // Yksinpeli_vaikea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 832);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tlpTaulu);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Yksinpeli_vaikea";
            this.Text = "Yksinpeli_vaikea";
            this.Load += new System.EventHandler(this.Yksinpeli_vaikea_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tlpTaulu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrKuva;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer tmrAika;
        private System.Windows.Forms.TableLayoutPanel tlpTaulu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
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
        private System.Windows.Forms.ToolStripStatusLabel sslbArvaukset;
        private System.Windows.Forms.ToolStripStatusLabel tsslbKulunutAika;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSulje;
    }
}