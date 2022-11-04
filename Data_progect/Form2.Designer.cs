namespace Data_progect
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button_show_data_f2 = new System.Windows.Forms.Button();
            this.button_del_f2 = new System.Windows.Forms.Button();
            this.button_update_f2 = new System.Windows.Forms.Button();
            this.button_Add_f2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_show_data_f2
            // 
            this.button_show_data_f2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_show_data_f2.BackgroundImage")));
            this.button_show_data_f2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_show_data_f2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_show_data_f2.Location = new System.Drawing.Point(321, 2);
            this.button_show_data_f2.Name = "button_show_data_f2";
            this.button_show_data_f2.Size = new System.Drawing.Size(100, 94);
            this.button_show_data_f2.TabIndex = 3;
            this.button_show_data_f2.UseVisualStyleBackColor = true;
            this.button_show_data_f2.Click += new System.EventHandler(this.button_show_data_f2_Click);
            // 
            // button_del_f2
            // 
            this.button_del_f2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_del_f2.BackgroundImage")));
            this.button_del_f2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_del_f2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_del_f2.Location = new System.Drawing.Point(215, 2);
            this.button_del_f2.Name = "button_del_f2";
            this.button_del_f2.Size = new System.Drawing.Size(100, 94);
            this.button_del_f2.TabIndex = 2;
            this.button_del_f2.UseVisualStyleBackColor = true;
            this.button_del_f2.Click += new System.EventHandler(this.button_del_f2_Click);
            // 
            // button_update_f2
            // 
            this.button_update_f2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_update_f2.BackgroundImage")));
            this.button_update_f2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_update_f2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update_f2.Location = new System.Drawing.Point(109, 2);
            this.button_update_f2.Name = "button_update_f2";
            this.button_update_f2.Size = new System.Drawing.Size(100, 94);
            this.button_update_f2.TabIndex = 1;
            this.button_update_f2.UseVisualStyleBackColor = true;
            this.button_update_f2.Click += new System.EventHandler(this.button_update_f2_Click);
            // 
            // button_Add_f2
            // 
            this.button_Add_f2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Add_f2.BackgroundImage")));
            this.button_Add_f2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Add_f2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add_f2.Location = new System.Drawing.Point(3, 2);
            this.button_Add_f2.Name = "button_Add_f2";
            this.button_Add_f2.Size = new System.Drawing.Size(100, 94);
            this.button_Add_f2.TabIndex = 0;
            this.button_Add_f2.UseVisualStyleBackColor = true;
            this.button_Add_f2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 99);
            this.Controls.Add(this.button_show_data_f2);
            this.Controls.Add(this.button_del_f2);
            this.Controls.Add(this.button_update_f2);
            this.Controls.Add(this.button_Add_f2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1C_on_Mininal";
           
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Add_f2;
        private System.Windows.Forms.Button button_update_f2;
        private System.Windows.Forms.Button button_del_f2;
        private System.Windows.Forms.Button button_show_data_f2;
    }
}