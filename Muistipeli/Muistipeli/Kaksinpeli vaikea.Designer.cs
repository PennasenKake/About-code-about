﻿namespace Muistipeli
{
    partial class Kaksinpeli_vaikea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kaksinpeli_vaikea));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSulje = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslbVuoro = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbKulunutAika = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrAika = new System.Windows.Forms.Timer(this.components);
            this.tmrKuva = new System.Windows.Forms.Timer(this.components);
            this.tlbTaulu = new System.Windows.Forms.TableLayoutPanel();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
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
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tlbTaulu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSulje});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1082, 34);
            this.toolStrip1.TabIndex = 0;
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
            this.tsbSulje.Click += new System.EventHandler(this.tsbSulje_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbVuoro,
            this.tsslbKulunutAika});
            this.statusStrip1.Location = new System.Drawing.Point(0, 757);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1082, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslbVuoro
            // 
            this.tsslbVuoro.Name = "tsslbVuoro";
            this.tsslbVuoro.Size = new System.Drawing.Size(70, 25);
            this.tsslbVuoro.Text = "Vuoro: ";
            // 
            // tsslbKulunutAika
            // 
            this.tsslbKulunutAika.Name = "tsslbKulunutAika";
            this.tsslbKulunutAika.Size = new System.Drawing.Size(55, 25);
            this.tsslbKulunutAika.Text = "Aika: ";
            // 
            // tmrAika
            // 
            this.tmrAika.Interval = 1000;
            this.tmrAika.Tick += new System.EventHandler(this.tmrAika_Tick_1);
            // 
            // tmrKuva
            // 
            this.tmrKuva.Interval = 750;
            this.tmrKuva.Tick += new System.EventHandler(this.tmrKuva_Tick);
            // 
            // tlbTaulu
            // 
            this.tlbTaulu.BackColor = System.Drawing.Color.Violet;
            this.tlbTaulu.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlbTaulu.ColumnCount = 6;
            this.tlbTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbTaulu.Controls.Add(this.label36, 5, 5);
            this.tlbTaulu.Controls.Add(this.label35, 4, 5);
            this.tlbTaulu.Controls.Add(this.label34, 3, 5);
            this.tlbTaulu.Controls.Add(this.label33, 2, 5);
            this.tlbTaulu.Controls.Add(this.label32, 1, 5);
            this.tlbTaulu.Controls.Add(this.label31, 0, 5);
            this.tlbTaulu.Controls.Add(this.label30, 5, 4);
            this.tlbTaulu.Controls.Add(this.label29, 4, 4);
            this.tlbTaulu.Controls.Add(this.label28, 3, 4);
            this.tlbTaulu.Controls.Add(this.label27, 2, 4);
            this.tlbTaulu.Controls.Add(this.label26, 1, 4);
            this.tlbTaulu.Controls.Add(this.label25, 0, 4);
            this.tlbTaulu.Controls.Add(this.label24, 5, 3);
            this.tlbTaulu.Controls.Add(this.label23, 4, 3);
            this.tlbTaulu.Controls.Add(this.label22, 3, 3);
            this.tlbTaulu.Controls.Add(this.label21, 2, 3);
            this.tlbTaulu.Controls.Add(this.label20, 1, 3);
            this.tlbTaulu.Controls.Add(this.label19, 0, 3);
            this.tlbTaulu.Controls.Add(this.label18, 5, 2);
            this.tlbTaulu.Controls.Add(this.label17, 4, 2);
            this.tlbTaulu.Controls.Add(this.label16, 3, 2);
            this.tlbTaulu.Controls.Add(this.label15, 2, 2);
            this.tlbTaulu.Controls.Add(this.label14, 1, 2);
            this.tlbTaulu.Controls.Add(this.label13, 0, 2);
            this.tlbTaulu.Controls.Add(this.label12, 5, 1);
            this.tlbTaulu.Controls.Add(this.label11, 4, 1);
            this.tlbTaulu.Controls.Add(this.label10, 3, 1);
            this.tlbTaulu.Controls.Add(this.label9, 2, 1);
            this.tlbTaulu.Controls.Add(this.label8, 1, 1);
            this.tlbTaulu.Controls.Add(this.label7, 0, 1);
            this.tlbTaulu.Controls.Add(this.label6, 5, 0);
            this.tlbTaulu.Controls.Add(this.label5, 4, 0);
            this.tlbTaulu.Controls.Add(this.label4, 3, 0);
            this.tlbTaulu.Controls.Add(this.label3, 2, 0);
            this.tlbTaulu.Controls.Add(this.label2, 1, 0);
            this.tlbTaulu.Controls.Add(this.label1, 0, 0);
            this.tlbTaulu.Location = new System.Drawing.Point(128, 126);
            this.tlbTaulu.Name = "tlbTaulu";
            this.tlbTaulu.RowCount = 6;
            this.tlbTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlbTaulu.Size = new System.Drawing.Size(626, 535);
            this.tlbTaulu.TabIndex = 2;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label36.ForeColor = System.Drawing.Color.Violet;
            this.label36.Location = new System.Drawing.Point(525, 442);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(96, 91);
            this.label36.TabIndex = 35;
            this.label36.Text = "s";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label36.Click += new System.EventHandler(this.label1_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label35.ForeColor = System.Drawing.Color.Violet;
            this.label35.Location = new System.Drawing.Point(421, 442);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(96, 91);
            this.label35.TabIndex = 34;
            this.label35.Text = "s";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label35.Click += new System.EventHandler(this.label1_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label34.ForeColor = System.Drawing.Color.Violet;
            this.label34.Location = new System.Drawing.Point(317, 442);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(96, 91);
            this.label34.TabIndex = 33;
            this.label34.Text = "s";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label34.Click += new System.EventHandler(this.label1_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label33.ForeColor = System.Drawing.Color.Violet;
            this.label33.Location = new System.Drawing.Point(213, 442);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(96, 91);
            this.label33.TabIndex = 32;
            this.label33.Text = "s";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label33.Click += new System.EventHandler(this.label1_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label32.ForeColor = System.Drawing.Color.Violet;
            this.label32.Location = new System.Drawing.Point(109, 442);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(96, 91);
            this.label32.TabIndex = 31;
            this.label32.Text = "s";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label32.Click += new System.EventHandler(this.label1_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label31.ForeColor = System.Drawing.Color.Violet;
            this.label31.Location = new System.Drawing.Point(5, 442);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(96, 91);
            this.label31.TabIndex = 30;
            this.label31.Text = "s";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label31.Click += new System.EventHandler(this.label1_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label30.ForeColor = System.Drawing.Color.Violet;
            this.label30.Location = new System.Drawing.Point(525, 354);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(96, 86);
            this.label30.TabIndex = 29;
            this.label30.Text = "s";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label30.Click += new System.EventHandler(this.label1_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label29.ForeColor = System.Drawing.Color.Violet;
            this.label29.Location = new System.Drawing.Point(421, 354);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(96, 86);
            this.label29.TabIndex = 28;
            this.label29.Text = "s";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label29.Click += new System.EventHandler(this.label1_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label28.ForeColor = System.Drawing.Color.Violet;
            this.label28.Location = new System.Drawing.Point(317, 354);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(96, 86);
            this.label28.TabIndex = 27;
            this.label28.Text = "s";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label28.Click += new System.EventHandler(this.label1_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label27.ForeColor = System.Drawing.Color.Violet;
            this.label27.Location = new System.Drawing.Point(213, 354);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(96, 86);
            this.label27.TabIndex = 26;
            this.label27.Text = "s";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label27.Click += new System.EventHandler(this.label1_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label26.ForeColor = System.Drawing.Color.Violet;
            this.label26.Location = new System.Drawing.Point(109, 354);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(96, 86);
            this.label26.TabIndex = 25;
            this.label26.Text = "s";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.Click += new System.EventHandler(this.label1_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label25.ForeColor = System.Drawing.Color.Violet;
            this.label25.Location = new System.Drawing.Point(5, 354);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 86);
            this.label25.TabIndex = 24;
            this.label25.Text = "s";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label25.Click += new System.EventHandler(this.label1_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label24.ForeColor = System.Drawing.Color.Violet;
            this.label24.Location = new System.Drawing.Point(525, 266);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 86);
            this.label24.TabIndex = 23;
            this.label24.Text = "s";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label24.Click += new System.EventHandler(this.label1_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label23.ForeColor = System.Drawing.Color.Violet;
            this.label23.Location = new System.Drawing.Point(421, 266);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(96, 86);
            this.label23.TabIndex = 22;
            this.label23.Text = "s";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label23.Click += new System.EventHandler(this.label1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label22.ForeColor = System.Drawing.Color.Violet;
            this.label22.Location = new System.Drawing.Point(317, 266);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 86);
            this.label22.TabIndex = 21;
            this.label22.Text = "s";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Click += new System.EventHandler(this.label1_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label21.ForeColor = System.Drawing.Color.Violet;
            this.label21.Location = new System.Drawing.Point(213, 266);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 86);
            this.label21.TabIndex = 20;
            this.label21.Text = "s";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.Click += new System.EventHandler(this.label1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label20.ForeColor = System.Drawing.Color.Violet;
            this.label20.Location = new System.Drawing.Point(109, 266);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 86);
            this.label20.TabIndex = 19;
            this.label20.Text = "s";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.label1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label19.ForeColor = System.Drawing.Color.Violet;
            this.label19.Location = new System.Drawing.Point(5, 266);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 86);
            this.label19.TabIndex = 18;
            this.label19.Text = "s";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.Click += new System.EventHandler(this.label1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label18.ForeColor = System.Drawing.Color.Violet;
            this.label18.Location = new System.Drawing.Point(525, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 86);
            this.label18.TabIndex = 17;
            this.label18.Text = "s";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.label1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label17.ForeColor = System.Drawing.Color.Violet;
            this.label17.Location = new System.Drawing.Point(421, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 86);
            this.label17.TabIndex = 16;
            this.label17.Text = "s";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.label1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label16.ForeColor = System.Drawing.Color.Violet;
            this.label16.Location = new System.Drawing.Point(317, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 86);
            this.label16.TabIndex = 15;
            this.label16.Text = "s";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label15.ForeColor = System.Drawing.Color.Violet;
            this.label15.Location = new System.Drawing.Point(213, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 86);
            this.label15.TabIndex = 14;
            this.label15.Text = "s";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label14.ForeColor = System.Drawing.Color.Violet;
            this.label14.Location = new System.Drawing.Point(109, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 86);
            this.label14.TabIndex = 13;
            this.label14.Text = "s";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label13.ForeColor = System.Drawing.Color.Violet;
            this.label13.Location = new System.Drawing.Point(5, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 86);
            this.label13.TabIndex = 12;
            this.label13.Text = "s";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.ForeColor = System.Drawing.Color.Violet;
            this.label12.Location = new System.Drawing.Point(525, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 86);
            this.label12.TabIndex = 11;
            this.label12.Text = "s";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.ForeColor = System.Drawing.Color.Violet;
            this.label11.Location = new System.Drawing.Point(421, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 86);
            this.label11.TabIndex = 10;
            this.label11.Text = "s";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.ForeColor = System.Drawing.Color.Violet;
            this.label10.Location = new System.Drawing.Point(317, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 86);
            this.label10.TabIndex = 9;
            this.label10.Text = "s";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.ForeColor = System.Drawing.Color.Violet;
            this.label9.Location = new System.Drawing.Point(213, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 86);
            this.label9.TabIndex = 8;
            this.label9.Text = "s";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.ForeColor = System.Drawing.Color.Violet;
            this.label8.Location = new System.Drawing.Point(109, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 86);
            this.label8.TabIndex = 7;
            this.label8.Text = "s";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.ForeColor = System.Drawing.Color.Violet;
            this.label7.Location = new System.Drawing.Point(5, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 86);
            this.label7.TabIndex = 6;
            this.label7.Text = "s";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.ForeColor = System.Drawing.Color.Violet;
            this.label6.Location = new System.Drawing.Point(525, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 86);
            this.label6.TabIndex = 5;
            this.label6.Text = "s";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.ForeColor = System.Drawing.Color.Violet;
            this.label5.Location = new System.Drawing.Point(421, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 86);
            this.label5.TabIndex = 4;
            this.label5.Text = "s";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.ForeColor = System.Drawing.Color.Violet;
            this.label4.Location = new System.Drawing.Point(317, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 86);
            this.label4.TabIndex = 3;
            this.label4.Text = "s";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.Violet;
            this.label3.Location = new System.Drawing.Point(213, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 86);
            this.label3.TabIndex = 2;
            this.label3.Text = "s";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.Violet;
            this.label2.Location = new System.Drawing.Point(109, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 86);
            this.label2.TabIndex = 1;
            this.label2.Text = "s";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Kaksinpeli_vaikea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 789);
            this.Controls.Add(this.tlbTaulu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Kaksinpeli_vaikea";
            this.Text = "Kaksinpeli_vaikea";
            this.Load += new System.EventHandler(this.Kaksinpeli_vaikea_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tlbTaulu.ResumeLayout(false);
            this.tlbTaulu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSulje;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer tmrAika;
        private System.Windows.Forms.Timer tmrKuva;
        private System.Windows.Forms.TableLayoutPanel tlbTaulu;
        private System.Windows.Forms.ToolStripStatusLabel tsslbVuoro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
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
        private System.Windows.Forms.ToolStripStatusLabel tsslbKulunutAika;
    }
}