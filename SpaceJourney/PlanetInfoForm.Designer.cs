using System.Windows.Forms;

namespace SpaceJourney
{
    partial class PlanetInfoForm
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
            this.dataGridPlanetInfo = new System.Windows.Forms.DataGridView();
            this.ColumnSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSSnils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSRocket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSPlanet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCHPlanet = new System.Windows.Forms.Label();
            this.RTBPlanetInfo = new System.Windows.Forms.RichTextBox();
            this.labelFirstImage = new System.Windows.Forms.Label();
            this.labelLastImage = new System.Windows.Forms.Label();
            this.labelSurfaceImage = new System.Windows.Forms.Label();
            this.buttonOkPonyatno = new System.Windows.Forms.Button();
            this.labelOrderCount = new System.Windows.Forms.Label();
            this.pictureBoxSurface = new System.Windows.Forms.PictureBox();
            this.pictureBoxLastImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxFirstImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlanetInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSurface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPlanetInfo
            // 
            this.dataGridPlanetInfo.AllowUserToResizeColumns = false;
            this.dataGridPlanetInfo.AllowUserToResizeRows = false;
            this.dataGridPlanetInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridPlanetInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlanetInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSName,
            this.ColumnSPhone,
            this.ColumnSSnils,
            this.ColumnSRocket,
            this.ColumnSPlanet});
            this.dataGridPlanetInfo.Location = new System.Drawing.Point(12, 12);
            this.dataGridPlanetInfo.Name = "dataGridPlanetInfo";
            this.dataGridPlanetInfo.ReadOnly = true;
            this.dataGridPlanetInfo.Size = new System.Drawing.Size(591, 870);
            this.dataGridPlanetInfo.TabIndex = 0;
            // 
            // ColumnSName
            // 
            this.ColumnSName.HeaderText = "ИМЯ";
            this.ColumnSName.Name = "ColumnSName";
            this.ColumnSName.ReadOnly = true;
            this.ColumnSName.Width = 125;
            // 
            // ColumnSPhone
            // 
            this.ColumnSPhone.HeaderText = "НОМЕР ТЕЛЕФОНА";
            this.ColumnSPhone.Name = "ColumnSPhone";
            this.ColumnSPhone.ReadOnly = true;
            this.ColumnSPhone.Width = 125;
            // 
            // ColumnSSnils
            // 
            this.ColumnSSnils.HeaderText = "СНИЛС";
            this.ColumnSSnils.Name = "ColumnSSnils";
            this.ColumnSSnils.ReadOnly = true;
            // 
            // ColumnSRocket
            // 
            this.ColumnSRocket.HeaderText = "ТИП ТРАНСПОРТА";
            this.ColumnSRocket.Name = "ColumnSRocket";
            this.ColumnSRocket.ReadOnly = true;
            // 
            // ColumnSPlanet
            // 
            this.ColumnSPlanet.HeaderText = "ПЛАНЕТА";
            this.ColumnSPlanet.Name = "ColumnSPlanet";
            this.ColumnSPlanet.ReadOnly = true;
            // 
            // labelCHPlanet
            // 
            this.labelCHPlanet.AutoSize = true;
            this.labelCHPlanet.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCHPlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelCHPlanet.Location = new System.Drawing.Point(897, 12);
            this.labelCHPlanet.Name = "labelCHPlanet";
            this.labelCHPlanet.Size = new System.Drawing.Size(365, 29);
            this.labelCHPlanet.TabIndex = 1;
            this.labelCHPlanet.Text = "ВЫ НЕ ДОЛЖНЫ ВИДЕТЬ ЭТОТ ТЕКСТ";
            // 
            // RTBPlanetInfo
            // 
            this.RTBPlanetInfo.BackColor = System.Drawing.Color.White;
            this.RTBPlanetInfo.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RTBPlanetInfo.Location = new System.Drawing.Point(902, 44);
            this.RTBPlanetInfo.Name = "RTBPlanetInfo";
            this.RTBPlanetInfo.ReadOnly = true;
            this.RTBPlanetInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RTBPlanetInfo.Size = new System.Drawing.Size(389, 838);
            this.RTBPlanetInfo.TabIndex = 2;
            this.RTBPlanetInfo.Text = "";
            // 
            // labelFirstImage
            // 
            this.labelFirstImage.AutoSize = true;
            this.labelFirstImage.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelFirstImage.Location = new System.Drawing.Point(642, 226);
            this.labelFirstImage.Name = "labelFirstImage";
            this.labelFirstImage.Size = new System.Drawing.Size(228, 29);
            this.labelFirstImage.TabIndex = 6;
            this.labelFirstImage.Text = "ПЕРВОЕ ИЗОБРАЖЕНИЕ";
            // 
            // labelLastImage
            // 
            this.labelLastImage.AutoSize = true;
            this.labelLastImage.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelLastImage.Location = new System.Drawing.Point(630, 510);
            this.labelLastImage.Name = "labelLastImage";
            this.labelLastImage.Size = new System.Drawing.Size(254, 29);
            this.labelLastImage.TabIndex = 7;
            this.labelLastImage.Text = "НЕДАВНЕЕ ИЗОБРАЖЕНИЕ";
            // 
            // labelSurfaceImage
            // 
            this.labelSurfaceImage.AutoSize = true;
            this.labelSurfaceImage.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurfaceImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelSurfaceImage.Location = new System.Drawing.Point(677, 853);
            this.labelSurfaceImage.Name = "labelSurfaceImage";
            this.labelSurfaceImage.Size = new System.Drawing.Size(149, 29);
            this.labelSurfaceImage.TabIndex = 8;
            this.labelSurfaceImage.Text = "ПОВЕРХНОСТЬ";
            // 
            // buttonOkPonyatno
            // 
            this.buttonOkPonyatno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOkPonyatno.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOkPonyatno.ForeColor = System.Drawing.Color.Black;
            this.buttonOkPonyatno.Location = new System.Drawing.Point(938, 901);
            this.buttonOkPonyatno.Name = "buttonOkPonyatno";
            this.buttonOkPonyatno.Size = new System.Drawing.Size(324, 65);
            this.buttonOkPonyatno.TabIndex = 9;
            this.buttonOkPonyatno.Text = "ОК, ПОНЯТНО";
            this.buttonOkPonyatno.UseVisualStyleBackColor = false;
            this.buttonOkPonyatno.Click += new System.EventHandler(this.buttonOkPonyatno_Click);
            // 
            // labelOrderCount
            // 
            this.labelOrderCount.AutoSize = true;
            this.labelOrderCount.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelOrderCount.Location = new System.Drawing.Point(12, 885);
            this.labelOrderCount.Name = "labelOrderCount";
            this.labelOrderCount.Size = new System.Drawing.Size(278, 29);
            this.labelOrderCount.TabIndex = 10;
            this.labelOrderCount.Text = "ЗАКАЗАЛО ПОЕЗДКУ СЮДА:";
            // 
            // pictureBoxSurface
            // 
            this.pictureBoxSurface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSurface.Location = new System.Drawing.Point(609, 671);
            this.pictureBoxSurface.Name = "pictureBoxSurface";
            this.pictureBoxSurface.Size = new System.Drawing.Size(287, 179);
            this.pictureBoxSurface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSurface.TabIndex = 5;
            this.pictureBoxSurface.TabStop = false;
            // 
            // pictureBoxLastImage
            // 
            this.pictureBoxLastImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLastImage.Location = new System.Drawing.Point(609, 328);
            this.pictureBoxLastImage.Name = "pictureBoxLastImage";
            this.pictureBoxLastImage.Size = new System.Drawing.Size(287, 179);
            this.pictureBoxLastImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLastImage.TabIndex = 4;
            this.pictureBoxLastImage.TabStop = false;
            // 
            // pictureBoxFirstImage
            // 
            this.pictureBoxFirstImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFirstImage.Location = new System.Drawing.Point(609, 44);
            this.pictureBoxFirstImage.Name = "pictureBoxFirstImage";
            this.pictureBoxFirstImage.Size = new System.Drawing.Size(287, 179);
            this.pictureBoxFirstImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFirstImage.TabIndex = 3;
            this.pictureBoxFirstImage.TabStop = false;
            // 
            // PlanetInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1303, 1012);
            this.Controls.Add(this.labelOrderCount);
            this.Controls.Add(this.buttonOkPonyatno);
            this.Controls.Add(this.labelSurfaceImage);
            this.Controls.Add(this.labelLastImage);
            this.Controls.Add(this.labelFirstImage);
            this.Controls.Add(this.pictureBoxSurface);
            this.Controls.Add(this.pictureBoxLastImage);
            this.Controls.Add(this.pictureBoxFirstImage);
            this.Controls.Add(this.RTBPlanetInfo);
            this.Controls.Add(this.labelCHPlanet);
            this.Controls.Add(this.dataGridPlanetInfo);
            this.Name = "PlanetInfoForm";
            this.Text = "PlanetInfoForm";
            this.Load += new System.EventHandler(this.PlanetInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlanetInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSurface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirstImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPlanetInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSSnils;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSRocket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSPlanet;
        private System.Windows.Forms.Label labelCHPlanet;
        private System.Windows.Forms.RichTextBox RTBPlanetInfo;
        private System.Windows.Forms.PictureBox pictureBoxFirstImage;
        private System.Windows.Forms.PictureBox pictureBoxLastImage;
        private System.Windows.Forms.PictureBox pictureBoxSurface;
        private System.Windows.Forms.Label labelFirstImage;
        private System.Windows.Forms.Label labelLastImage;
        private System.Windows.Forms.Label labelSurfaceImage;
        private System.Windows.Forms.Button buttonOkPonyatno;
        private Label labelOrderCount;
    }
}