namespace Library2
{
    partial class FormAdmin
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
            this.buttonShowUsers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBoxreturn = new System.Windows.Forms.PictureBox();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxreturn)).BeginInit();
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
            this.paneltop.TabIndex = 15;
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
            this.labelauth.Size = new System.Drawing.Size(249, 47);
            this.labelauth.TabIndex = 1;
            this.labelauth.Text = "Главная админ";
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
            // buttonShowUsers
            // 
            this.buttonShowUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.buttonShowUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowUsers.Font = new System.Drawing.Font("TangoDi", 24F);
            this.buttonShowUsers.ForeColor = System.Drawing.Color.Maroon;
            this.buttonShowUsers.Location = new System.Drawing.Point(267, 131);
            this.buttonShowUsers.Name = "buttonShowUsers";
            this.buttonShowUsers.Size = new System.Drawing.Size(661, 60);
            this.buttonShowUsers.TabIndex = 19;
            this.buttonShowUsers.Text = "Вывести всех пользователей";
            this.buttonShowUsers.UseVisualStyleBackColor = false;
            this.buttonShowUsers.Click += new System.EventHandler(this.buttonShowUsers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView1.Location = new System.Drawing.Point(267, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(661, 326);
            this.dataGridView1.TabIndex = 20;
            // 
            // pictureBoxreturn
            // 
            this.pictureBoxreturn.Image = global::Library2.Properties.Resources.Снимок;
            this.pictureBoxreturn.Location = new System.Drawing.Point(1070, 80);
            this.pictureBoxreturn.Name = "pictureBoxreturn";
            this.pictureBoxreturn.Size = new System.Drawing.Size(101, 78);
            this.pictureBoxreturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxreturn.TabIndex = 21;
            this.pictureBoxreturn.TabStop = false;
            this.pictureBoxreturn.Click += new System.EventHandler(this.pictureBoxreturn_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1183, 616);
            this.Controls.Add(this.pictureBoxreturn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.buttonShowUsers);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личная библиотека";
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxreturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labelexit;
        private System.Windows.Forms.Label labelauth;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button buttonShowUsers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBoxreturn;
    }
}