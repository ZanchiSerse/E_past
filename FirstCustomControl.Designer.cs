namespace C__project
{
    partial class FirstCustomControl
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstCustomControl));
            this.panel_home = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_mappa = new System.Windows.Forms.Panel();
            this.Mappa = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.Panel_Carrello = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.DGV_carrello = new System.Windows.Forms.DataGridView();
            this.panel_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_mappa.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.Panel_Carrello.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_carrello)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_home
            // 
            this.panel_home.Controls.Add(this.panel1);
            this.panel_home.Controls.Add(this.panel_mappa);
            this.panel_home.Controls.Add(this.pictureBox1);
            this.panel_home.Controls.Add(this.label5);
            this.panel_home.Controls.Add(this.label2);
            this.panel_home.Location = new System.Drawing.Point(0, 0);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(1042, 576);
            this.panel_home.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(471, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(427, 168);
            this.label5.TabIndex = 8;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(36, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 123);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chi siamo?";
            // 
            // panel_mappa
            // 
            this.panel_mappa.Controls.Add(this.Mappa);
            this.panel_mappa.Location = new System.Drawing.Point(23, 175);
            this.panel_mappa.Name = "panel_mappa";
            this.panel_mappa.Size = new System.Drawing.Size(1042, 549);
            this.panel_mappa.TabIndex = 47;
            // 
            // Mappa
            // 
            this.Mappa.Bearing = 0F;
            this.Mappa.CanDragMap = true;
            this.Mappa.EmptyTileColor = System.Drawing.Color.Navy;
            this.Mappa.GrayScaleMode = false;
            this.Mappa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Mappa.LevelsKeepInMemory = 5;
            this.Mappa.Location = new System.Drawing.Point(87, 27);
            this.Mappa.MarkersEnabled = true;
            this.Mappa.MaxZoom = 2;
            this.Mappa.MinZoom = 2;
            this.Mappa.MouseWheelZoomEnabled = true;
            this.Mappa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Mappa.Name = "Mappa";
            this.Mappa.NegativeMode = false;
            this.Mappa.PolygonsEnabled = true;
            this.Mappa.RetryLoadTile = 0;
            this.Mappa.RoutesEnabled = true;
            this.Mappa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Mappa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Mappa.ShowTileGridLines = false;
            this.Mappa.Size = new System.Drawing.Size(901, 499);
            this.Mappa.TabIndex = 1;
            this.Mappa.Zoom = 0D;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Panel_Carrello);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 557);
            this.panel1.TabIndex = 48;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.InitialImage")));
            this.pictureBox10.Location = new System.Drawing.Point(471, 163);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(536, 380);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(53, 208);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(427, 168);
            this.label35.TabIndex = 8;
            this.label35.Text = resources.GetString("label35.Text");
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.label36.Location = new System.Drawing.Point(36, 34);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(586, 123);
            this.label36.TabIndex = 7;
            this.label36.Text = "Chi siamo?";
            // 
            // Panel_Carrello
            // 
            this.Panel_Carrello.Controls.Add(this.label18);
            this.Panel_Carrello.Controls.Add(this.DGV_carrello);
            this.Panel_Carrello.Location = new System.Drawing.Point(-16, 2);
            this.Panel_Carrello.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Carrello.Name = "Panel_Carrello";
            this.Panel_Carrello.Size = new System.Drawing.Size(1074, 552);
            this.Panel_Carrello.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(444, 72);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 32);
            this.label18.TabIndex = 6;
            this.label18.Text = "Il tuo ordine:";
            // 
            // DGV_carrello
            // 
            this.DGV_carrello.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_carrello.Location = new System.Drawing.Point(211, 125);
            this.DGV_carrello.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_carrello.Name = "DGV_carrello";
            this.DGV_carrello.RowHeadersWidth = 51;
            this.DGV_carrello.RowTemplate.Height = 24;
            this.DGV_carrello.Size = new System.Drawing.Size(650, 388);
            this.DGV_carrello.TabIndex = 5;
            // 
            // FirstCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_home);
            this.Name = "FirstCustomControl";
            this.Size = new System.Drawing.Size(1042, 576);
            this.Load += new System.EventHandler(this.FirstCustomControl_Load);
            this.panel_home.ResumeLayout(false);
            this.panel_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_mappa.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.Panel_Carrello.ResumeLayout(false);
            this.Panel_Carrello.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_carrello)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_mappa;
        private GMap.NET.WindowsForms.GMapControl Mappa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel Panel_Carrello;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView DGV_carrello;
    }
}
