namespace Data_progect
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_remkarta = new System.Windows.Forms.TextBox();
            this.label_remKarta = new System.Windows.Forms.Label();
            this.textBox_kontragent = new System.Windows.Forms.TextBox();
            this.textBox_baraban = new System.Windows.Forms.TextBox();
            this.textBox_Value_ = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_material = new System.Windows.Forms.TextBox();
            this.label_kontragent = new System.Windows.Forms.Label();
            this.label_baraban = new System.Windows.Forms.Label();
            this.label_Value_ = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Price_material = new System.Windows.Forms.Label();
            this.button_delete_pos = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textBox_remkarta
            // 
            this.textBox_remkarta.Location = new System.Drawing.Point(655, 12);
            this.textBox_remkarta.Name = "textBox_remkarta";
            this.textBox_remkarta.Size = new System.Drawing.Size(99, 20);
            this.textBox_remkarta.TabIndex = 1;
            // 
            // label_remKarta
            // 
            this.label_remKarta.AutoSize = true;
            this.label_remKarta.BackColor = System.Drawing.Color.Transparent;
            this.label_remKarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_remKarta.ForeColor = System.Drawing.Color.Black;
            this.label_remKarta.Location = new System.Drawing.Point(472, 9);
            this.label_remKarta.Name = "label_remKarta";
            this.label_remKarta.Size = new System.Drawing.Size(177, 20);
            this.label_remKarta.TabIndex = 2;
            this.label_remKarta.Text = "Ремонтная карта №";
            // 
            // textBox_kontragent
            // 
            this.textBox_kontragent.Location = new System.Drawing.Point(585, 38);
            this.textBox_kontragent.Name = "textBox_kontragent";
            this.textBox_kontragent.Size = new System.Drawing.Size(169, 20);
            this.textBox_kontragent.TabIndex = 3;
            // 
            // textBox_baraban
            // 
            this.textBox_baraban.Location = new System.Drawing.Point(681, 64);
            this.textBox_baraban.Name = "textBox_baraban";
            this.textBox_baraban.Size = new System.Drawing.Size(73, 20);
            this.textBox_baraban.TabIndex = 4;
            // 
            // textBox_Value_
            // 
            this.textBox_Value_.Location = new System.Drawing.Point(642, 90);
            this.textBox_Value_.Name = "textBox_Value_";
            this.textBox_Value_.Size = new System.Drawing.Size(112, 20);
            this.textBox_Value_.TabIndex = 5;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(612, 114);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(142, 20);
            this.textBox_Price.TabIndex = 6;
            // 
            // textBox_material
            // 
            this.textBox_material.Location = new System.Drawing.Point(681, 136);
            this.textBox_material.Name = "textBox_material";
            this.textBox_material.Size = new System.Drawing.Size(73, 20);
            this.textBox_material.TabIndex = 7;
            // 
            // label_kontragent
            // 
            this.label_kontragent.AutoSize = true;
            this.label_kontragent.BackColor = System.Drawing.Color.Transparent;
            this.label_kontragent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_kontragent.ForeColor = System.Drawing.Color.Black;
            this.label_kontragent.Location = new System.Drawing.Point(472, 36);
            this.label_kontragent.Name = "label_kontragent";
            this.label_kontragent.Size = new System.Drawing.Size(108, 20);
            this.label_kontragent.TabIndex = 9;
            this.label_kontragent.Text = "Контрагент";
            // 
            // label_baraban
            // 
            this.label_baraban.AutoSize = true;
            this.label_baraban.BackColor = System.Drawing.Color.Transparent;
            this.label_baraban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_baraban.ForeColor = System.Drawing.Color.Black;
            this.label_baraban.Location = new System.Drawing.Point(472, 62);
            this.label_baraban.Name = "label_baraban";
            this.label_baraban.Size = new System.Drawing.Size(208, 20);
            this.label_baraban.TabIndex = 10;
            this.label_baraban.Text = "Кол-во фотобарабанов\r\n";
            // 
            // label_Value_
            // 
            this.label_Value_.AutoSize = true;
            this.label_Value_.BackColor = System.Drawing.Color.Transparent;
            this.label_Value_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Value_.ForeColor = System.Drawing.Color.Black;
            this.label_Value_.Location = new System.Drawing.Point(472, 88);
            this.label_Value_.Name = "label_Value_";
            this.label_Value_.Size = new System.Drawing.Size(170, 20);
            this.label_Value_.TabIndex = 11;
            this.label_Value_.Text = "Общее количество";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.BackColor = System.Drawing.Color.Transparent;
            this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Price.ForeColor = System.Drawing.Color.Black;
            this.label_Price.Location = new System.Drawing.Point(472, 114);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(124, 20);
            this.label_Price.TabIndex = 12;
            this.label_Price.Text = "Счёт клиенту";
            // 
            // label_Price_material
            // 
            this.label_Price_material.AutoSize = true;
            this.label_Price_material.BackColor = System.Drawing.Color.Transparent;
            this.label_Price_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Price_material.ForeColor = System.Drawing.Color.Black;
            this.label_Price_material.Location = new System.Drawing.Point(472, 134);
            this.label_Price_material.Name = "label_Price_material";
            this.label_Price_material.Size = new System.Drawing.Size(210, 20);
            this.label_Price_material.TabIndex = 13;
            this.label_Price_material.Text = "Стоимость материалов";
            // 
            // button_delete_pos
            // 
            this.button_delete_pos.BackgroundImage = global::Data_progect.Properties.Resources.coffee_caffeine_beverage_photo;
            this.button_delete_pos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete_pos.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete_pos.Location = new System.Drawing.Point(624, 209);
            this.button_delete_pos.Name = "button_delete_pos";
            this.button_delete_pos.Size = new System.Drawing.Size(137, 41);
            this.button_delete_pos.TabIndex = 15;
            this.button_delete_pos.Text = "УДАЛИТЬ";
            this.button_delete_pos.UseVisualStyleBackColor = true;
            this.button_delete_pos.Click += new System.EventHandler(this.button_delete_pos_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackgroundImage = global::Data_progect.Properties.Resources.coffee_caffeine_beverage_photo;
            this.button_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Clear.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(476, 210);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(131, 40);
            this.button_Clear.TabIndex = 16;
            this.button_Clear.Text = "ОЧИСТИТЬ";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_info
            // 
            this.button_info.BackColor = System.Drawing.Color.Transparent;
            this.button_info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_info.BackgroundImage")));
            this.button_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_info.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_info.Location = new System.Drawing.Point(760, 9);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(25, 23);
            this.button_info.TabIndex = 17;
            this.button_info.UseVisualStyleBackColor = false;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Data_progect.Properties.Resources.coffee_caffeine_beverage_photo;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(797, 372);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_delete_pos);
            this.Controls.Add(this.label_Price_material);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_Value_);
            this.Controls.Add(this.label_baraban);
            this.Controls.Add(this.label_kontragent);
            this.Controls.Add(this.textBox_material);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Value_);
            this.Controls.Add(this.textBox_baraban);
            this.Controls.Add(this.textBox_kontragent);
            this.Controls.Add(this.label_remKarta);
            this.Controls.Add(this.textBox_remkarta);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(817, 415);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1С на минималках";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_remkarta;
        private System.Windows.Forms.Label label_remKarta;
        private System.Windows.Forms.TextBox textBox_kontragent;
        private System.Windows.Forms.TextBox textBox_baraban;
        private System.Windows.Forms.TextBox textBox_Value_;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_material;
        private System.Windows.Forms.Label label_kontragent;
        private System.Windows.Forms.Label label_baraban;
        private System.Windows.Forms.Label label_Value_;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Price_material;
        private System.Windows.Forms.Button button_delete_pos;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_info;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

