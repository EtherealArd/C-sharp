namespace ShipmentWinFormApp
{
    partial class ShipmentMain
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
            this.gridViewShipment = new System.Windows.Forms.DataGridView();
            this.groupCheckBoxes = new System.Windows.Forms.GroupBox();
            this.btnGetAllData = new System.Windows.Forms.Button();
            this.checkBoxManager = new System.Windows.Forms.CheckBox();
            this.checkBoxCountry = new System.Windows.Forms.CheckBox();
            this.checkBoxCity = new System.Windows.Forms.CheckBox();
            this.checkBoxOrganization = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewShipment)).BeginInit();
            this.groupCheckBoxes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewShipment
            // 
            this.gridViewShipment.BackgroundColor = System.Drawing.Color.White;
            this.gridViewShipment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewShipment.Location = new System.Drawing.Point(2, 87);
            this.gridViewShipment.Name = "gridViewShipment";
            this.gridViewShipment.Size = new System.Drawing.Size(758, 356);
            this.gridViewShipment.TabIndex = 0;
            // 
            // groupCheckBoxes
            // 
            this.groupCheckBoxes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupCheckBoxes.Controls.Add(this.btnGetAllData);
            this.groupCheckBoxes.Controls.Add(this.checkBoxManager);
            this.groupCheckBoxes.Controls.Add(this.checkBoxCountry);
            this.groupCheckBoxes.Controls.Add(this.checkBoxCity);
            this.groupCheckBoxes.Controls.Add(this.checkBoxOrganization);
            this.groupCheckBoxes.Controls.Add(this.checkBoxDate);
            this.groupCheckBoxes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupCheckBoxes.Location = new System.Drawing.Point(2, 45);
            this.groupCheckBoxes.Name = "groupCheckBoxes";
            this.groupCheckBoxes.Size = new System.Drawing.Size(758, 43);
            this.groupCheckBoxes.TabIndex = 1;
            this.groupCheckBoxes.TabStop = false;
            this.groupCheckBoxes.Text = "Группирование";
            // 
            // btnGetAllData
            // 
            this.btnGetAllData.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGetAllData.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGetAllData.Location = new System.Drawing.Point(503, 8);
            this.btnGetAllData.Name = "btnGetAllData";
            this.btnGetAllData.Size = new System.Drawing.Size(219, 31);
            this.btnGetAllData.TabIndex = 1;
            this.btnGetAllData.Text = "Все данные";
            this.btnGetAllData.UseVisualStyleBackColor = false;
            this.btnGetAllData.Click += new System.EventHandler(this.btnGetAllData_Click);
            // 
            // checkBoxManager
            // 
            this.checkBoxManager.AutoSize = true;
            this.checkBoxManager.Location = new System.Drawing.Point(391, 19);
            this.checkBoxManager.Name = "checkBoxManager";
            this.checkBoxManager.Size = new System.Drawing.Size(79, 17);
            this.checkBoxManager.TabIndex = 0;
            this.checkBoxManager.Tag = "Manager";
            this.checkBoxManager.Text = "Менеджер";
            this.checkBoxManager.UseVisualStyleBackColor = true;
            // 
            // checkBoxCountry
            // 
            this.checkBoxCountry.AutoSize = true;
            this.checkBoxCountry.Location = new System.Drawing.Point(292, 19);
            this.checkBoxCountry.Name = "checkBoxCountry";
            this.checkBoxCountry.Size = new System.Drawing.Size(62, 17);
            this.checkBoxCountry.TabIndex = 0;
            this.checkBoxCountry.Tag = "Country";
            this.checkBoxCountry.Text = "Страна";
            this.checkBoxCountry.UseVisualStyleBackColor = true;
            // 
            // checkBoxCity
            // 
            this.checkBoxCity.AutoSize = true;
            this.checkBoxCity.Location = new System.Drawing.Point(194, 19);
            this.checkBoxCity.Name = "checkBoxCity";
            this.checkBoxCity.Size = new System.Drawing.Size(56, 17);
            this.checkBoxCity.TabIndex = 0;
            this.checkBoxCity.Tag = "City";
            this.checkBoxCity.Text = "Город";
            this.checkBoxCity.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrganization
            // 
            this.checkBoxOrganization.AutoSize = true;
            this.checkBoxOrganization.Location = new System.Drawing.Point(85, 19);
            this.checkBoxOrganization.Name = "checkBoxOrganization";
            this.checkBoxOrganization.Size = new System.Drawing.Size(93, 17);
            this.checkBoxOrganization.TabIndex = 0;
            this.checkBoxOrganization.Tag = "Organization";
            this.checkBoxOrganization.Text = "Организация";
            this.checkBoxOrganization.UseVisualStyleBackColor = true;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(8, 19);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(52, 17);
            this.checkBoxDate.TabIndex = 0;
            this.checkBoxDate.Tag = "Date";
            this.checkBoxDate.Text = "Дата";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Меню";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ShipmentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 455);
            this.Controls.Add(this.groupCheckBoxes);
            this.Controls.Add(this.gridViewShipment);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShipmentMain";
            this.Text = "Shipment";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewShipment)).EndInit();
            this.groupCheckBoxes.ResumeLayout(false);
            this.groupCheckBoxes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewShipment;
        private System.Windows.Forms.GroupBox groupCheckBoxes;
        private System.Windows.Forms.Button btnGetAllData;
        private System.Windows.Forms.CheckBox checkBoxManager;
        private System.Windows.Forms.CheckBox checkBoxCountry;
        private System.Windows.Forms.CheckBox checkBoxCity;
        private System.Windows.Forms.CheckBox checkBoxOrganization;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}

