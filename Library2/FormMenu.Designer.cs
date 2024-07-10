namespace Library2
{
    partial class FormMenu
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
            this.paneltop = new System.Windows.Forms.Panel();
            this.labelexit = new System.Windows.Forms.Label();
            this.labelauth = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelStore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.Beige;
            this.paneltop.Controls.Add(this.labelexit);
            this.paneltop.Controls.Add(this.labelauth);
            this.paneltop.Controls.Add(this.labelname);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1183, 74);
            this.paneltop.TabIndex = 30;
            // 
            // labelexit
            // 
            this.labelexit.AutoSize = true;
            this.labelexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.labelexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelexit.Font = new System.Drawing.Font("TangoDi", 24F);
            this.labelexit.ForeColor = System.Drawing.Color.Maroon;
            this.labelexit.Location = new System.Drawing.Point(1041, 14);
            this.labelexit.Name = "labelexit";
            this.labelexit.Size = new System.Drawing.Size(130, 47);
            this.labelexit.TabIndex = 2;
            this.labelexit.Text = "Выйти";
            this.labelexit.Click += new System.EventHandler(this.labelexit_Click);
            // 
            // labelauth
            // 
            this.labelauth.AutoSize = true;
            this.labelauth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.labelauth.Font = new System.Drawing.Font("TangoDi", 24F);
            this.labelauth.ForeColor = System.Drawing.Color.Maroon;
            this.labelauth.Location = new System.Drawing.Point(12, 14);
            this.labelauth.Name = "labelauth";
            this.labelauth.Size = new System.Drawing.Size(108, 47);
            this.labelauth.TabIndex = 1;
            this.labelauth.Text = "Меню";
            // 
            // labelname
            // 
            this.labelname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.labelname.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelname.Font = new System.Drawing.Font("TangoDi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelname.ForeColor = System.Drawing.Color.Maroon;
            this.labelname.Location = new System.Drawing.Point(0, 0);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(1183, 74);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Личная библиотека";
            this.labelname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("TangoDi", 24F);
            this.buttonDelete.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDelete.Location = new System.Drawing.Point(37, 229);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(314, 60);
            this.buttonDelete.TabIndex = 35;
            this.buttonDelete.Text = "Моя библиотека";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Font = new System.Drawing.Font("TangoDi", 24F);
            this.labelStore.ForeColor = System.Drawing.Color.Maroon;
            this.labelStore.Location = new System.Drawing.Point(29, 123);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(324, 47);
            this.labelStore.TabIndex = 31;
            this.labelStore.Text = "Выберите действие";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("TangoDi", 24F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(37, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 60);
            this.button1.TabIndex = 36;
            this.button1.Text = "Обо мне";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library2.Properties.Resources.lib2;
            this.pictureBox1.Location = new System.Drawing.Point(376, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("TangoDi", 24F);
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(37, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 60);
            this.button2.TabIndex = 47;
            this.button2.Text = "Чужие библиотеки";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1183, 616);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelStore);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личная библиотека";
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labelexit;
        private System.Windows.Forms.Label labelauth;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}