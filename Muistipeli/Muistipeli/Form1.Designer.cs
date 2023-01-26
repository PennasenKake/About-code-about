namespace Muistipeli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlpTaulu = new System.Windows.Forms.TableLayoutPanel();
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
            this.tmrKuva = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslbArvaukset = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbKulunutAika = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pelimuotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yksinpeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helppoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaikeaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaksinpeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helppoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vaikeaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbSulje = new System.Windows.Forms.ToolStripButton();
            this.tmrAika = new System.Windows.Forms.Timer(this.components);
            this.tlpTaulu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTaulu
            // 
            this.tlpTaulu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tlpTaulu.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpTaulu.ColumnCount = 4;
            this.tlpTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTaulu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
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
            this.tlpTaulu.Location = new System.Drawing.Point(104, 83);
            this.tlpTaulu.Name = "tlpTaulu";
            this.tlpTaulu.RowCount = 3;
            this.tlpTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTaulu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTaulu.Size = new System.Drawing.Size(568, 400);
            this.tlpTaulu.TabIndex = 0;
            this.tlpTaulu.Visible = false;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label12.Location = new System.Drawing.Point(428, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 132);
            this.label12.TabIndex = 11;
            this.label12.Text = "s";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label11.Location = new System.Drawing.Point(287, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 132);
            this.label11.TabIndex = 10;
            this.label11.Text = "s";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label10.Location = new System.Drawing.Point(146, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 132);
            this.label10.TabIndex = 9;
            this.label10.Text = "s";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label9.Location = new System.Drawing.Point(5, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 132);
            this.label9.TabIndex = 8;
            this.label9.Text = "s";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label8.Location = new System.Drawing.Point(428, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 130);
            this.label8.TabIndex = 7;
            this.label8.Text = "s";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label7.Location = new System.Drawing.Point(287, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 130);
            this.label7.TabIndex = 6;
            this.label7.Text = "s";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label6.Location = new System.Drawing.Point(146, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 130);
            this.label6.TabIndex = 5;
            this.label6.Text = "s";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Location = new System.Drawing.Point(5, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 130);
            this.label5.TabIndex = 4;
            this.label5.Text = "s";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Location = new System.Drawing.Point(428, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 130);
            this.label4.TabIndex = 3;
            this.label4.Text = "s";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Location = new System.Drawing.Point(287, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 130);
            this.label3.TabIndex = 2;
            this.label3.Text = "s";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(146, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 130);
            this.label2.TabIndex = 1;
            this.label2.Text = "s";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 130);
            this.label1.TabIndex = 0;
            this.label1.Text = "s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(813, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslbArvaukset
            // 
            this.sslbArvaukset.Name = "sslbArvaukset";
            this.sslbArvaukset.Size = new System.Drawing.Size(97, 25);
            this.sslbArvaukset.Text = "Arvauksia: ";
            // 
            // tsslbKulunutAika
            // 
            this.tsslbKulunutAika.Name = "tsslbKulunutAika";
            this.tsslbKulunutAika.Size = new System.Drawing.Size(117, 25);
            this.tsslbKulunutAika.Text = "Kulunut aika: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.tsbSulje});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(813, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pelimuotoToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(86, 29);
            this.toolStripDropDownButton1.Tag = "1";
            this.toolStripDropDownButton1.Text = "Valikko";
            // 
            // pelimuotoToolStripMenuItem
            // 
            this.pelimuotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yksinpeliToolStripMenuItem,
            this.kaksinpeliToolStripMenuItem});
            this.pelimuotoToolStripMenuItem.Name = "pelimuotoToolStripMenuItem";
            this.pelimuotoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pelimuotoToolStripMenuItem.Tag = "2";
            this.pelimuotoToolStripMenuItem.Text = "Pelimuoto";
            // 
            // yksinpeliToolStripMenuItem
            // 
            this.yksinpeliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helppoToolStripMenuItem,
            this.vaikeaToolStripMenuItem});
            this.yksinpeliToolStripMenuItem.Name = "yksinpeliToolStripMenuItem";
            this.yksinpeliToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.yksinpeliToolStripMenuItem.Tag = "3";
            this.yksinpeliToolStripMenuItem.Text = "Yksinpeli";
            // 
            // helppoToolStripMenuItem
            // 
            this.helppoToolStripMenuItem.Name = "helppoToolStripMenuItem";
            this.helppoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.helppoToolStripMenuItem.Tag = "4";
            this.helppoToolStripMenuItem.Text = "Helppo";
            this.helppoToolStripMenuItem.Click += new System.EventHandler(this.helppoToolStripMenuItem_Click);
            // 
            // vaikeaToolStripMenuItem
            // 
            this.vaikeaToolStripMenuItem.Name = "vaikeaToolStripMenuItem";
            this.vaikeaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.vaikeaToolStripMenuItem.Tag = "5";
            this.vaikeaToolStripMenuItem.Text = "Vaikea";
            this.vaikeaToolStripMenuItem.Click += new System.EventHandler(this.vaikeaToolStripMenuItem_Click);
            // 
            // kaksinpeliToolStripMenuItem
            // 
            this.kaksinpeliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helppoToolStripMenuItem1,
            this.vaikeaToolStripMenuItem1});
            this.kaksinpeliToolStripMenuItem.Name = "kaksinpeliToolStripMenuItem";
            this.kaksinpeliToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.kaksinpeliToolStripMenuItem.Tag = "6";
            this.kaksinpeliToolStripMenuItem.Text = "Kaksinpeli";
            // 
            // helppoToolStripMenuItem1
            // 
            this.helppoToolStripMenuItem1.Name = "helppoToolStripMenuItem1";
            this.helppoToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.helppoToolStripMenuItem1.Tag = "7";
            this.helppoToolStripMenuItem1.Text = "Helppo";
            this.helppoToolStripMenuItem1.Click += new System.EventHandler(this.helppoToolStripMenuItem1_Click);
            // 
            // vaikeaToolStripMenuItem1
            // 
            this.vaikeaToolStripMenuItem1.Name = "vaikeaToolStripMenuItem1";
            this.vaikeaToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.vaikeaToolStripMenuItem1.Tag = "8";
            this.vaikeaToolStripMenuItem1.Text = "Vaikea";
            this.vaikeaToolStripMenuItem1.Click += new System.EventHandler(this.vaikeaToolStripMenuItem1_Click);
            // 
            // tsbSulje
            // 
            this.tsbSulje.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSulje.Image = ((System.Drawing.Image)(resources.GetObject("tsbSulje.Image")));
            this.tsbSulje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSulje.Name = "tsbSulje";
            this.tsbSulje.Size = new System.Drawing.Size(53, 29);
            this.tsbSulje.Tag = "9";
            this.tsbSulje.Text = "Sulje";
            this.tsbSulje.Click += new System.EventHandler(this.tsbSulje_Click);
            // 
            // tmrAika
            // 
            this.tmrAika.Interval = 1000;
            this.tmrAika.Tick += new System.EventHandler(this.tmrAika_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 542);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tlpTaulu);
            this.Name = "Form1";
            this.Text = "Muistipeli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpTaulu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTaulu;
        private System.Windows.Forms.Timer tmrKuva;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSulje;
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
        private System.Windows.Forms.ToolStripStatusLabel sslbArvaukset;
        private System.Windows.Forms.ToolStripStatusLabel tsslbKulunutAika;
        private System.Windows.Forms.Timer tmrAika;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem pelimuotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yksinpeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helppoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vaikeaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaksinpeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helppoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vaikeaToolStripMenuItem1;
    }
}

