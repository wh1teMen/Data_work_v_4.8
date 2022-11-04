namespace Data_progect
{
    partial class Form5_delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5_delete));
            this.label_remKarta = new System.Windows.Forms.Label();
            this.textBox_remkarta = new System.Windows.Forms.TextBox();
            this.button_del_f5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_remKarta
            // 
            this.label_remKarta.AutoSize = true;
            this.label_remKarta.BackColor = System.Drawing.Color.Transparent;
            this.label_remKarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_remKarta.ForeColor = System.Drawing.Color.Transparent;
            this.label_remKarta.Location = new System.Drawing.Point(12, 27);
            this.label_remKarta.Name = "label_remKarta";
            this.label_remKarta.Size = new System.Drawing.Size(206, 24);
            this.label_remKarta.TabIndex = 21;
            this.label_remKarta.Text = "Ремонтная карта №";
            // 
            // textBox_remkarta
            // 
            this.textBox_remkarta.Location = new System.Drawing.Point(224, 31);
            this.textBox_remkarta.Name = "textBox_remkarta";
            this.textBox_remkarta.Size = new System.Drawing.Size(125, 20);
            this.textBox_remkarta.TabIndex = 20;
            // 
            // button_del_f5
            // 
            this.button_del_f5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_del_f5.BackgroundImage")));
            this.button_del_f5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_del_f5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_del_f5.Location = new System.Drawing.Point(413, 14);
            this.button_del_f5.Name = "button_del_f5";
            this.button_del_f5.Size = new System.Drawing.Size(120, 54);
            this.button_del_f5.TabIndex = 22;
            this.button_del_f5.UseVisualStyleBackColor = true;
            this.button_del_f5.Click += new System.EventHandler(this.button_del_f5_Click);
            // 
            // Form5_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 97);
            this.Controls.Add(this.button_del_f5);
            this.Controls.Add(this.label_remKarta);
            this.Controls.Add(this.textBox_remkarta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5_delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_remKarta;
        private System.Windows.Forms.TextBox textBox_remkarta;
        private System.Windows.Forms.Button button_del_f5;
    }
}