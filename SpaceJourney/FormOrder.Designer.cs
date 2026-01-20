namespace SpaceJourney
{
    partial class FormOrder
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
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSnils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRocket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlanet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBLOrder = new System.Windows.Forms.Label();
            this.radioButtonRus = new System.Windows.Forms.RadioButton();
            this.TXTName = new System.Windows.Forms.TextBox();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.TXTPhone = new System.Windows.Forms.TextBox();
            this.TXTSnils = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonUFO = new System.Windows.Forms.RadioButton();
            this.radioButtonCarpet = new System.Windows.Forms.RadioButton();
            this.radioButtonMusk = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.labelSomeText = new System.Windows.Forms.Label();
            this.buttonReturnToMenu = new System.Windows.Forms.Button();
            this.BTNSadlySave = new System.Windows.Forms.Button();
            this.buttonSadlyLoad = new System.Windows.Forms.Button();
            this.buttonEraseFromGrid = new System.Windows.Forms.Button();
            this.comboBoxPlanets = new System.Windows.Forms.ComboBox();
            this.labelChosenPlaned = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.AllowUserToResizeColumns = false;
            this.dataGridOrders.AllowUserToResizeRows = false;
            this.dataGridOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnPhone,
            this.ColumnSnils,
            this.ColumnRocket,
            this.ColumnPlanet});
            this.dataGridOrders.GridColor = System.Drawing.Color.Black;
            this.dataGridOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.ReadOnly = true;
            this.dataGridOrders.Size = new System.Drawing.Size(591, 870);
            this.dataGridOrders.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "ИМЯ";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 125;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.HeaderText = "НОМЕР ТЕЛЕФОНА";
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            this.ColumnPhone.Width = 125;
            // 
            // ColumnSnils
            // 
            this.ColumnSnils.HeaderText = "СНИЛС";
            this.ColumnSnils.Name = "ColumnSnils";
            this.ColumnSnils.ReadOnly = true;
            // 
            // ColumnRocket
            // 
            this.ColumnRocket.HeaderText = "ТИП ТРАНСПОРТА";
            this.ColumnRocket.Name = "ColumnRocket";
            this.ColumnRocket.ReadOnly = true;
            // 
            // ColumnPlanet
            // 
            this.ColumnPlanet.HeaderText = "ПЛАНЕТА";
            this.ColumnPlanet.Name = "ColumnPlanet";
            this.ColumnPlanet.ReadOnly = true;
            // 
            // LBLOrder
            // 
            this.LBLOrder.AutoSize = true;
            this.LBLOrder.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBLOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LBLOrder.Location = new System.Drawing.Point(678, 12);
            this.LBLOrder.Name = "LBLOrder";
            this.LBLOrder.Size = new System.Drawing.Size(318, 43);
            this.LBLOrder.TabIndex = 1;
            this.LBLOrder.Text = "ОФОРМИТЬ ПОЕЗДКУ";
            // 
            // radioButtonRus
            // 
            this.radioButtonRus.AutoSize = true;
            this.radioButtonRus.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonRus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonRus.Location = new System.Drawing.Point(686, 382);
            this.radioButtonRus.Name = "radioButtonRus";
            this.radioButtonRus.Size = new System.Drawing.Size(212, 27);
            this.radioButtonRus.TabIndex = 2;
            this.radioButtonRus.TabStop = true;
            this.radioButtonRus.Text = "РАКЕТА ОТЕЧЕСТВЕННАЯ";
            this.radioButtonRus.UseVisualStyleBackColor = true;
            // 
            // TXTName
            // 
            this.TXTName.Location = new System.Drawing.Point(686, 121);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(310, 20);
            this.TXTName.TabIndex = 3;
            this.TXTName.TextChanged += new System.EventHandler(this.TXTName_TextChanged);
            // 
            // btnSumbit
            // 
            this.btnSumbit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSumbit.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSumbit.Location = new System.Drawing.Point(680, 573);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(128, 40);
            this.btnSumbit.TabIndex = 4;
            this.btnSumbit.Text = "ЗАКАЗАТЬ";
            this.btnSumbit.UseVisualStyleBackColor = false;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // TXTPhone
            // 
            this.TXTPhone.Location = new System.Drawing.Point(686, 203);
            this.TXTPhone.Name = "TXTPhone";
            this.TXTPhone.Size = new System.Drawing.Size(310, 20);
            this.TXTPhone.TabIndex = 5;
            this.TXTPhone.TextChanged += new System.EventHandler(this.TXTPhone_TextChanged);
            // 
            // TXTSnils
            // 
            this.TXTSnils.Location = new System.Drawing.Point(686, 288);
            this.TXTSnils.Name = "TXTSnils";
            this.TXTSnils.Size = new System.Drawing.Size(310, 20);
            this.TXTSnils.TabIndex = 6;
            this.TXTSnils.TextChanged += new System.EventHandler(this.TXTSnils_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelName.Location = new System.Drawing.Point(681, 89);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 29);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "ИМЯ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(681, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "НОМЕР ТЕЛЕФОНА";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(681, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "СНИЛС";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(681, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "ТИП ТРАНСПОРТА";
            // 
            // radioButtonUFO
            // 
            this.radioButtonUFO.AutoSize = true;
            this.radioButtonUFO.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonUFO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonUFO.Location = new System.Drawing.Point(911, 382);
            this.radioButtonUFO.Name = "radioButtonUFO";
            this.radioButtonUFO.Size = new System.Drawing.Size(60, 27);
            this.radioButtonUFO.TabIndex = 11;
            this.radioButtonUFO.TabStop = true;
            this.radioButtonUFO.Text = "НЛО";
            this.radioButtonUFO.UseVisualStyleBackColor = true;
            // 
            // radioButtonCarpet
            // 
            this.radioButtonCarpet.AutoSize = true;
            this.radioButtonCarpet.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCarpet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonCarpet.Location = new System.Drawing.Point(686, 445);
            this.radioButtonCarpet.Name = "radioButtonCarpet";
            this.radioButtonCarpet.Size = new System.Drawing.Size(89, 27);
            this.radioButtonCarpet.TabIndex = 12;
            this.radioButtonCarpet.TabStop = true;
            this.radioButtonCarpet.Text = "КОВРИК";
            this.radioButtonCarpet.UseVisualStyleBackColor = true;
            // 
            // radioButtonMusk
            // 
            this.radioButtonMusk.AutoSize = true;
            this.radioButtonMusk.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMusk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButtonMusk.Location = new System.Drawing.Point(911, 445);
            this.radioButtonMusk.Name = "radioButtonMusk";
            this.radioButtonMusk.Size = new System.Drawing.Size(85, 27);
            this.radioButtonMusk.TabIndex = 13;
            this.radioButtonMusk.TabStop = true;
            this.radioButtonMusk.Text = "SPACEX";
            this.radioButtonMusk.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(862, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "ПЕРЕДУМАТЬ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelSomeText
            // 
            this.labelSomeText.AutoSize = true;
            this.labelSomeText.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSomeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelSomeText.Location = new System.Drawing.Point(687, 760);
            this.labelSomeText.Name = "labelSomeText";
            this.labelSomeText.Size = new System.Drawing.Size(17, 29);
            this.labelSomeText.TabIndex = 15;
            this.labelSomeText.Text = " ";
            // 
            // buttonReturnToMenu
            // 
            this.buttonReturnToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonReturnToMenu.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturnToMenu.Location = new System.Drawing.Point(862, 670);
            this.buttonReturnToMenu.Name = "buttonReturnToMenu";
            this.buttonReturnToMenu.Size = new System.Drawing.Size(128, 40);
            this.buttonReturnToMenu.TabIndex = 16;
            this.buttonReturnToMenu.Text = "В МЕНЮ";
            this.buttonReturnToMenu.UseVisualStyleBackColor = false;
            this.buttonReturnToMenu.Click += new System.EventHandler(this.buttonReturnToMenu_Click);
            // 
            // BTNSadlySave
            // 
            this.BTNSadlySave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTNSadlySave.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNSadlySave.Location = new System.Drawing.Point(680, 619);
            this.BTNSadlySave.Name = "BTNSadlySave";
            this.BTNSadlySave.Size = new System.Drawing.Size(128, 40);
            this.BTNSadlySave.TabIndex = 17;
            this.BTNSadlySave.Text = "СОХРАНИТЬ";
            this.BTNSadlySave.UseVisualStyleBackColor = false;
            this.BTNSadlySave.Click += new System.EventHandler(this.BTNSadlySave_Click);
            // 
            // buttonSadlyLoad
            // 
            this.buttonSadlyLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSadlyLoad.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSadlyLoad.Location = new System.Drawing.Point(680, 670);
            this.buttonSadlyLoad.Name = "buttonSadlyLoad";
            this.buttonSadlyLoad.Size = new System.Drawing.Size(128, 40);
            this.buttonSadlyLoad.TabIndex = 18;
            this.buttonSadlyLoad.Text = "ЗАГРУЗИТЬ";
            this.buttonSadlyLoad.UseVisualStyleBackColor = false;
            this.buttonSadlyLoad.Click += new System.EventHandler(this.buttonSadlyLoad_Click);
            // 
            // buttonEraseFromGrid
            // 
            this.buttonEraseFromGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonEraseFromGrid.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEraseFromGrid.Location = new System.Drawing.Point(862, 619);
            this.buttonEraseFromGrid.Name = "buttonEraseFromGrid";
            this.buttonEraseFromGrid.Size = new System.Drawing.Size(128, 40);
            this.buttonEraseFromGrid.TabIndex = 19;
            this.buttonEraseFromGrid.Text = "УДАЛИТЬ";
            this.buttonEraseFromGrid.UseVisualStyleBackColor = false;
            this.buttonEraseFromGrid.Click += new System.EventHandler(this.buttonEraseFromGrid_Click);
            // 
            // comboBoxPlanets
            // 
            this.comboBoxPlanets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlanets.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPlanets.Items.AddRange(new object[] {
            "Меркурий",
            "Венера",
            "Земля",
            "Марс",
            "Юпитер",
            "Сатурн",
            "Уран",
            "Нептун"});
            this.comboBoxPlanets.Location = new System.Drawing.Point(680, 522);
            this.comboBoxPlanets.Name = "comboBoxPlanets";
            this.comboBoxPlanets.Size = new System.Drawing.Size(310, 34);
            this.comboBoxPlanets.TabIndex = 20;
            // 
            // labelChosenPlaned
            // 
            this.labelChosenPlaned.AutoSize = true;
            this.labelChosenPlaned.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChosenPlaned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelChosenPlaned.Location = new System.Drawing.Point(675, 490);
            this.labelChosenPlaned.Name = "labelChosenPlaned";
            this.labelChosenPlaned.Size = new System.Drawing.Size(223, 29);
            this.labelChosenPlaned.TabIndex = 21;
            this.labelChosenPlaned.Text = "ВЫБРАННАЯ ПЛАНЕТА";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1049, 894);
            this.Controls.Add(this.labelChosenPlaned);
            this.Controls.Add(this.comboBoxPlanets);
            this.Controls.Add(this.buttonEraseFromGrid);
            this.Controls.Add(this.buttonSadlyLoad);
            this.Controls.Add(this.BTNSadlySave);
            this.Controls.Add(this.buttonReturnToMenu);
            this.Controls.Add(this.labelSomeText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButtonMusk);
            this.Controls.Add(this.radioButtonCarpet);
            this.Controls.Add(this.radioButtonUFO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.TXTSnils);
            this.Controls.Add(this.TXTPhone);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.TXTName);
            this.Controls.Add(this.radioButtonRus);
            this.Controls.Add(this.LBLOrder);
            this.Controls.Add(this.dataGridOrders);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Label LBLOrder;
        private System.Windows.Forms.RadioButton radioButtonRus;
        private System.Windows.Forms.TextBox TXTName;
        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.TextBox TXTPhone;
        private System.Windows.Forms.TextBox TXTSnils;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonUFO;
        private System.Windows.Forms.RadioButton radioButtonCarpet;
        private System.Windows.Forms.RadioButton radioButtonMusk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSnils;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRocket;
        private System.Windows.Forms.Label labelSomeText;
        private System.Windows.Forms.Button buttonReturnToMenu;
        private System.Windows.Forms.Button BTNSadlySave;
        private System.Windows.Forms.Button buttonSadlyLoad;
        private System.Windows.Forms.Button buttonEraseFromGrid;
        private System.Windows.Forms.ComboBox comboBoxPlanets;
        private System.Windows.Forms.Label labelChosenPlaned;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlanet;
    }
}