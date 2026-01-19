using System.Drawing;

namespace SpaceJourney
{
    partial class SpaceMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceMenu));
            this.BTNSun = new System.Windows.Forms.Button();
            this.BTNMercury = new System.Windows.Forms.Button();
            this.BTNEarth = new System.Windows.Forms.Button();
            this.BTNJupiter = new System.Windows.Forms.Button();
            this.BTNMars = new System.Windows.Forms.Button();
            this.BTNVenus = new System.Windows.Forms.Button();
            this.BTNSaturn = new System.Windows.Forms.Button();
            this.BTNUranus = new System.Windows.Forms.Button();
            this.BTNNeptune = new System.Windows.Forms.Button();
            this.toolStripMainMenu = new System.Windows.Forms.ToolStrip();
            this.BTNOrderTheJourney = new System.Windows.Forms.ToolStripButton();
            this.LBLOrderTheJourney = new System.Windows.Forms.ToolStripLabel();
            this.BTNPlanetsList = new System.Windows.Forms.ToolStripButton();
            this.LBLPlanetsList = new System.Windows.Forms.ToolStripLabel();
            this.cekyndomep = new System.Windows.Forms.Timer(this.components);
            this.toolStripMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNSun
            // 
            this.BTNSun.BackColor = System.Drawing.Color.Transparent;
            this.BTNSun.BackgroundImage = global::SpaceJourney.Properties.Resources.WEBMETKAsun;
            this.BTNSun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSun.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNSun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSun.Location = new System.Drawing.Point(724, 549);
            this.BTNSun.Name = "BTNSun";
            this.BTNSun.Size = new System.Drawing.Size(75, 72);
            this.BTNSun.TabIndex = 0;
            this.BTNSun.Text = " ";
            this.BTNSun.UseVisualStyleBackColor = false;
            this.BTNSun.Click += new System.EventHandler(this.BTNSun_Click);
            // 
            // BTNMercury
            // 
            this.BTNMercury.BackColor = System.Drawing.Color.Transparent;
            this.BTNMercury.BackgroundImage = global::SpaceJourney.Properties.Resources.WEBMETKAmercury;
            this.BTNMercury.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNMercury.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNMercury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMercury.Location = new System.Drawing.Point(799, 520);
            this.BTNMercury.Name = "BTNMercury";
            this.BTNMercury.Size = new System.Drawing.Size(27, 23);
            this.BTNMercury.TabIndex = 1;
            this.BTNMercury.Text = " ";
            this.BTNMercury.UseVisualStyleBackColor = false;
            this.BTNMercury.Click += new System.EventHandler(this.BTNMercury_Click);
            // 
            // BTNEarth
            // 
            this.BTNEarth.BackColor = System.Drawing.Color.Transparent;
            this.BTNEarth.BackgroundImage = global::SpaceJourney.Properties.Resources.WEBMETKAearth;
            this.BTNEarth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNEarth.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNEarth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEarth.Location = new System.Drawing.Point(872, 446);
            this.BTNEarth.Name = "BTNEarth";
            this.BTNEarth.Size = new System.Drawing.Size(33, 32);
            this.BTNEarth.TabIndex = 2;
            this.BTNEarth.Text = " ";
            this.BTNEarth.UseVisualStyleBackColor = false;
            this.BTNEarth.Click += new System.EventHandler(this.BTNEarth_Click);
            // 
            // BTNJupiter
            // 
            this.BTNJupiter.BackColor = System.Drawing.Color.Transparent;
            this.BTNJupiter.BackgroundImage = global::SpaceJourney.Properties.Resources.WEBMETKAjupiter;
            this.BTNJupiter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNJupiter.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNJupiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNJupiter.Location = new System.Drawing.Point(943, 365);
            this.BTNJupiter.Name = "BTNJupiter";
            this.BTNJupiter.Size = new System.Drawing.Size(47, 46);
            this.BTNJupiter.TabIndex = 3;
            this.BTNJupiter.Text = " ";
            this.BTNJupiter.UseVisualStyleBackColor = false;
            this.BTNJupiter.Click += new System.EventHandler(this.BTNJupiter_Click);
            // 
            // BTNMars
            // 
            this.BTNMars.BackColor = System.Drawing.Color.Transparent;
            this.BTNMars.BackgroundImage = global::SpaceJourney.Properties.Resources.WEBMETKAmars;
            this.BTNMars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNMars.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNMars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMars.Location = new System.Drawing.Point(911, 417);
            this.BTNMars.Name = "BTNMars";
            this.BTNMars.Size = new System.Drawing.Size(26, 23);
            this.BTNMars.TabIndex = 4;
            this.BTNMars.Text = " ";
            this.BTNMars.UseVisualStyleBackColor = false;
            this.BTNMars.Click += new System.EventHandler(this.BTNMars_Click);
            // 
            // BTNVenus
            // 
            this.BTNVenus.BackColor = System.Drawing.Color.Transparent;
            this.BTNVenus.BackgroundImage = global::SpaceJourney.Properties.Resources.WEBMETKAvenus;
            this.BTNVenus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNVenus.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNVenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNVenus.Location = new System.Drawing.Point(832, 484);
            this.BTNVenus.Name = "BTNVenus";
            this.BTNVenus.Size = new System.Drawing.Size(34, 30);
            this.BTNVenus.TabIndex = 5;
            this.BTNVenus.Text = " ";
            this.BTNVenus.UseVisualStyleBackColor = false;
            this.BTNVenus.Click += new System.EventHandler(this.BTNVenus_Click);
            // 
            // BTNSaturn
            // 
            this.BTNSaturn.BackColor = System.Drawing.Color.Transparent;
            this.BTNSaturn.BackgroundImage = global::SpaceJourney.Properties.Resources.WEBMETKAsaturn;
            this.BTNSaturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSaturn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNSaturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSaturn.Location = new System.Drawing.Point(991, 317);
            this.BTNSaturn.Name = "BTNSaturn";
            this.BTNSaturn.Size = new System.Drawing.Size(54, 42);
            this.BTNSaturn.TabIndex = 6;
            this.BTNSaturn.Text = " ";
            this.BTNSaturn.UseVisualStyleBackColor = false;
            this.BTNSaturn.Click += new System.EventHandler(this.BTNSaturn_Click);
            // 
            // BTNUranus
            // 
            this.BTNUranus.BackColor = System.Drawing.Color.Transparent;
            this.BTNUranus.BackgroundImage = global::SpaceJourney.Properties.Resources.WEBMETKAuran;
            this.BTNUranus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNUranus.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNUranus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNUranus.Location = new System.Drawing.Point(1043, 277);
            this.BTNUranus.Name = "BTNUranus";
            this.BTNUranus.Size = new System.Drawing.Size(35, 34);
            this.BTNUranus.TabIndex = 7;
            this.BTNUranus.Text = " ";
            this.BTNUranus.UseVisualStyleBackColor = false;
            this.BTNUranus.Click += new System.EventHandler(this.BTNUranus_Click);
            // 
            // BTNNeptune
            // 
            this.BTNNeptune.BackColor = System.Drawing.Color.Transparent;
            this.BTNNeptune.BackgroundImage = global::SpaceJourney.Properties.Resources.WEBMETKAneptune;
            this.BTNNeptune.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNNeptune.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BTNNeptune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNeptune.Location = new System.Drawing.Point(1084, 242);
            this.BTNNeptune.Name = "BTNNeptune";
            this.BTNNeptune.Size = new System.Drawing.Size(30, 29);
            this.BTNNeptune.TabIndex = 8;
            this.BTNNeptune.Text = " ";
            this.BTNNeptune.UseVisualStyleBackColor = false;
            this.BTNNeptune.Click += new System.EventHandler(this.BTNNeptune_Click);
            // 
            // toolStripMainMenu
            // 
            this.toolStripMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripMainMenu.Font = new System.Drawing.Font("Impact", 15F);
            this.toolStripMainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNOrderTheJourney,
            this.LBLOrderTheJourney,
            this.BTNPlanetsList,
            this.LBLPlanetsList});
            this.toolStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMainMenu.Name = "toolStripMainMenu";
            this.toolStripMainMenu.Size = new System.Drawing.Size(1518, 28);
            this.toolStripMainMenu.TabIndex = 9;
            this.toolStripMainMenu.Text = " ";
            // 
            // BTNOrderTheJourney
            // 
            this.BTNOrderTheJourney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTNOrderTheJourney.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTNOrderTheJourney.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNOrderTheJourney.Image = global::SpaceJourney.Properties.Resources.btnordericon;
            this.BTNOrderTheJourney.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNOrderTheJourney.Name = "BTNOrderTheJourney";
            this.BTNOrderTheJourney.Size = new System.Drawing.Size(23, 25);
            this.BTNOrderTheJourney.Text = "toolStripButton1";
            this.BTNOrderTheJourney.Click += new System.EventHandler(this.BTNOrderTheJourney_Click);
            // 
            // LBLOrderTheJourney
            // 
            this.LBLOrderTheJourney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBLOrderTheJourney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBLOrderTheJourney.Name = "LBLOrderTheJourney";
            this.LBLOrderTheJourney.Size = new System.Drawing.Size(183, 25);
            this.LBLOrderTheJourney.Text = "ОФОРМИТЬ ПОЕЗДКУ";
            // 
            // BTNPlanetsList
            // 
            this.BTNPlanetsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTNPlanetsList.BackgroundImage = global::SpaceJourney.Properties.Resources.btnlisticon;
            this.BTNPlanetsList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTNPlanetsList.Image = global::SpaceJourney.Properties.Resources.btnlisticon;
            this.BTNPlanetsList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNPlanetsList.Name = "BTNPlanetsList";
            this.BTNPlanetsList.Size = new System.Drawing.Size(23, 25);
            this.BTNPlanetsList.Text = "toolStripButton2";
            this.BTNPlanetsList.Click += new System.EventHandler(this.BTNPlanetsList_Click);
            // 
            // LBLPlanetsList
            // 
            this.LBLPlanetsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBLPlanetsList.Name = "LBLPlanetsList";
            this.LBLPlanetsList.Size = new System.Drawing.Size(143, 25);
            this.LBLPlanetsList.Text = "СПИСОК ПЛАНЕТ";
            // 
            // cekyndomep
            // 
            this.cekyndomep.Interval = 50;
            this.cekyndomep.Tick += new System.EventHandler(this.cekyndomep_Tick);
            // 
            // SpaceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 1196);
            this.Controls.Add(this.toolStripMainMenu);
            this.Controls.Add(this.BTNNeptune);
            this.Controls.Add(this.BTNUranus);
            this.Controls.Add(this.BTNSaturn);
            this.Controls.Add(this.BTNVenus);
            this.Controls.Add(this.BTNMars);
            this.Controls.Add(this.BTNJupiter);
            this.Controls.Add(this.BTNEarth);
            this.Controls.Add(this.BTNMercury);
            this.Controls.Add(this.BTNSun);
            this.Name = "SpaceMenu";
            this.Text = "V";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripMainMenu.ResumeLayout(false);
            this.toolStripMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSun;
        private System.Windows.Forms.Button BTNMercury;
        private System.Windows.Forms.Button BTNEarth;
        private System.Windows.Forms.Button BTNJupiter;
        private System.Windows.Forms.Button BTNMars;
        private System.Windows.Forms.Button BTNVenus;
        private System.Windows.Forms.Button BTNSaturn;
        private System.Windows.Forms.Button BTNUranus;
        private System.Windows.Forms.Button BTNNeptune;
        private System.Windows.Forms.ToolStrip toolStripMainMenu;
        private System.Windows.Forms.ToolStripButton BTNOrderTheJourney;
        private System.Windows.Forms.ToolStripLabel LBLOrderTheJourney;
        private System.Windows.Forms.ToolStripButton BTNPlanetsList;
        private System.Windows.Forms.ToolStripLabel LBLPlanetsList;
        private System.Windows.Forms.Timer cekyndomep;
    }
}

