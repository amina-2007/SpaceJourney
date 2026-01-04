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
            this.LBLOrder = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.TXTName = new System.Windows.Forms.TextBox();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.TXTPhone = new System.Windows.Forms.TextBox();
            this.TXTSnils = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.labelSomeText = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSnils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRocket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonReturnToMenu = new System.Windows.Forms.Button();
            this.BTNSadlySave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnPhone,
            this.ColumnSnils,
            this.ColumnRocket});
            this.dataGridOrders.GridColor = System.Drawing.Color.Black;
            this.dataGridOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.ReadOnly = true;
            this.dataGridOrders.Size = new System.Drawing.Size(493, 870);
            this.dataGridOrders.TabIndex = 0;
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButton1.Location = new System.Drawing.Point(686, 436);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(212, 27);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "РАКЕТА ОТЕЧЕСТВЕННАЯ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // TXTName
            // 
            this.TXTName.Location = new System.Drawing.Point(686, 121);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(310, 20);
            this.TXTName.TabIndex = 3;
            // 
            // btnSumbit
            // 
            this.btnSumbit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSumbit.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSumbit.Location = new System.Drawing.Point(686, 568);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(128, 40);
            this.btnSumbit.TabIndex = 4;
            this.btnSumbit.Text = "ЗАКАЗАТЬ";
            this.btnSumbit.UseVisualStyleBackColor = false;
            // 
            // TXTPhone
            // 
            this.TXTPhone.Location = new System.Drawing.Point(686, 208);
            this.TXTPhone.Name = "TXTPhone";
            this.TXTPhone.Size = new System.Drawing.Size(310, 20);
            this.TXTPhone.TabIndex = 5;
            // 
            // TXTSnils
            // 
            this.TXTSnils.Location = new System.Drawing.Point(686, 304);
            this.TXTSnils.Name = "TXTSnils";
            this.TXTSnils.Size = new System.Drawing.Size(310, 20);
            this.TXTSnils.TabIndex = 6;
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
            this.label2.Location = new System.Drawing.Point(681, 176);
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
            this.label3.Location = new System.Drawing.Point(681, 272);
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
            this.label4.Location = new System.Drawing.Point(681, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "ТИП ТРАНСПОРТА";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButton2.Location = new System.Drawing.Point(911, 436);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 27);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "НЛО";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButton3.Location = new System.Drawing.Point(686, 499);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 27);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "КОВРИК";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioButton4.Location = new System.Drawing.Point(911, 499);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 27);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "SPACEX";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(868, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "ПЕРЕДУМАТЬ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // labelSomeText
            // 
            this.labelSomeText.AutoSize = true;
            this.labelSomeText.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSomeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelSomeText.Location = new System.Drawing.Point(687, 760);
            this.labelSomeText.Name = "labelSomeText";
            this.labelSomeText.Size = new System.Drawing.Size(50, 29);
            this.labelSomeText.TabIndex = 15;
            this.labelSomeText.Text = "test";
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
            // buttonReturnToMenu
            // 
            this.buttonReturnToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonReturnToMenu.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturnToMenu.Location = new System.Drawing.Point(868, 665);
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
            this.BTNSadlySave.Location = new System.Drawing.Point(686, 665);
            this.BTNSadlySave.Name = "BTNSadlySave";
            this.BTNSadlySave.Size = new System.Drawing.Size(128, 40);
            this.BTNSadlySave.TabIndex = 17;
            this.BTNSadlySave.Text = "СОХРАНИТЬ";
            this.BTNSadlySave.UseVisualStyleBackColor = false;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1108, 894);
            this.Controls.Add(this.BTNSadlySave);
            this.Controls.Add(this.buttonReturnToMenu);
            this.Controls.Add(this.labelSomeText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.TXTSnils);
            this.Controls.Add(this.TXTPhone);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.TXTName);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.LBLOrder);
            this.Controls.Add(this.dataGridOrders);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Label LBLOrder;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox TXTName;
        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.TextBox TXTPhone;
        private System.Windows.Forms.TextBox TXTSnils;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSnils;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRocket;
        private System.Windows.Forms.Label labelSomeText;
        private System.Windows.Forms.Button buttonReturnToMenu;
        private System.Windows.Forms.Button BTNSadlySave;
    }
}