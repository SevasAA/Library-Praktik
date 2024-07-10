namespace Library2
{
    partial class MainForm
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
            this.buttonDownload = new System.Windows.Forms.Button();
            this.labelStore = new System.Windows.Forms.Label();
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelUploadDate = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonDownToUser = new System.Windows.Forms.Button();
            this.pictureBoxreturn = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.paneltop.SuspendLayout();
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
            this.paneltop.TabIndex = 7;
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
            this.labelauth.Size = new System.Drawing.Size(148, 47);
            this.labelauth.TabIndex = 1;
            this.labelauth.Text = "Главная";
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
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.buttonDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.Font = new System.Drawing.Font("TangoDi", 24F);
            this.buttonDownload.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDownload.Location = new System.Drawing.Point(83, 469);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(314, 60);
            this.buttonDownload.TabIndex = 14;
            this.buttonDownload.Text = "Загрузка";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Font = new System.Drawing.Font("TangoDi", 24F);
            this.labelStore.ForeColor = System.Drawing.Color.Maroon;
            this.labelStore.Location = new System.Drawing.Point(123, 81);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(423, 47);
            this.labelStore.TabIndex = 10;
            this.labelStore.Text = "Список доступных файлов";
            this.labelStore.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // listBoxList
            // 
            this.listBoxList.Font = new System.Drawing.Font("TangoDi", 14F);
            this.listBoxList.ForeColor = System.Drawing.Color.Maroon;
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.ItemHeight = 27;
            this.listBoxList.Location = new System.Drawing.Point(131, 140);
            this.listBoxList.MaximumSize = new System.Drawing.Size(848, 220);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.ScrollAlwaysVisible = true;
            this.listBoxList.Size = new System.Drawing.Size(848, 220);
            this.listBoxList.TabIndex = 15;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("TangoDi", 24F);
            this.buttonDelete.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDelete.Location = new System.Drawing.Point(403, 469);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(314, 60);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("TangoDi", 14F);
            this.labelAuthor.ForeColor = System.Drawing.Color.Maroon;
            this.labelAuthor.Location = new System.Drawing.Point(126, 375);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(73, 28);
            this.labelAuthor.TabIndex = 17;
            this.labelAuthor.Text = "Автор";
            // 
            // labelUploadDate
            // 
            this.labelUploadDate.AutoSize = true;
            this.labelUploadDate.Font = new System.Drawing.Font("TangoDi", 14F);
            this.labelUploadDate.ForeColor = System.Drawing.Color.Maroon;
            this.labelUploadDate.Location = new System.Drawing.Point(126, 420);
            this.labelUploadDate.Name = "labelUploadDate";
            this.labelUploadDate.Size = new System.Drawing.Size(147, 28);
            this.labelUploadDate.TabIndex = 18;
            this.labelUploadDate.Text = "Дата загрузки";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("TangoDi", 14F);
            this.labelSize.ForeColor = System.Drawing.Color.Maroon;
            this.labelSize.Location = new System.Drawing.Point(660, 420);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(78, 28);
            this.labelSize.TabIndex = 19;
            this.labelSize.Text = "Размер";
            // 
            // buttonDownToUser
            // 
            this.buttonDownToUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.buttonDownToUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownToUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownToUser.Font = new System.Drawing.Font("TangoDi", 24F);
            this.buttonDownToUser.ForeColor = System.Drawing.Color.Maroon;
            this.buttonDownToUser.Location = new System.Drawing.Point(723, 469);
            this.buttonDownToUser.Name = "buttonDownToUser";
            this.buttonDownToUser.Size = new System.Drawing.Size(314, 60);
            this.buttonDownToUser.TabIndex = 20;
            this.buttonDownToUser.Text = "Скачать";
            this.buttonDownToUser.UseVisualStyleBackColor = false;
            this.buttonDownToUser.Click += new System.EventHandler(this.buttonDownToUser_Click);
            // 
            // pictureBoxreturn
            // 
            this.pictureBoxreturn.Image = global::Library2.Properties.Resources.Снимок;
            this.pictureBoxreturn.Location = new System.Drawing.Point(1070, 81);
            this.pictureBoxreturn.Name = "pictureBoxreturn";
            this.pictureBoxreturn.Size = new System.Drawing.Size(101, 78);
            this.pictureBoxreturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxreturn.TabIndex = 22;
            this.pictureBoxreturn.TabStop = false;
            this.pictureBoxreturn.Click += new System.EventHandler(this.pictureBoxreturn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("TangoDi", 24F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(197, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(749, 60);
            this.button1.TabIndex = 23;
            this.button1.Text = "Дать доступ другому пользователю";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1183, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxreturn);
            this.Controls.Add(this.buttonDownToUser);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelUploadDate);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBoxList);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.labelStore);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личная библиотека";
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxreturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labelexit;
        private System.Windows.Forms.Label labelauth;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelUploadDate;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonDownToUser;
        private System.Windows.Forms.PictureBox pictureBoxreturn;
        private System.Windows.Forms.Button button1;
    }
}