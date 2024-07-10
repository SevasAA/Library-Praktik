namespace Library2
{
    partial class FormPerson
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
            this.labelStore = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.labellogin = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.pictureBoxreturn = new System.Windows.Forms.PictureBox();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxreturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
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
            this.paneltop.TabIndex = 21;
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
            this.labelauth.Size = new System.Drawing.Size(138, 47);
            this.labelauth.TabIndex = 1;
            this.labelauth.Text = "Обо мне";
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
            // labelStore
            // 
            this.labelStore.AutoSize = true;
            this.labelStore.Font = new System.Drawing.Font("TangoDi", 24F);
            this.labelStore.ForeColor = System.Drawing.Color.Maroon;
            this.labelStore.Location = new System.Drawing.Point(64, 102);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(252, 47);
            this.labelStore.TabIndex = 24;
            this.labelStore.Text = "О пользователе";
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("TangoDi", 24F);
            this.labeluser.ForeColor = System.Drawing.Color.Maroon;
            this.labeluser.Location = new System.Drawing.Point(255, 183);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(0, 47);
            this.labeluser.TabIndex = 25;
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("TangoDi", 24F);
            this.labellogin.ForeColor = System.Drawing.Color.Maroon;
            this.labellogin.Location = new System.Drawing.Point(255, 279);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(0, 47);
            this.labellogin.TabIndex = 26;
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.Font = new System.Drawing.Font("TangoDi", 24F);
            this.labelpass.ForeColor = System.Drawing.Color.Maroon;
            this.labelpass.Location = new System.Drawing.Point(255, 379);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(0, 47);
            this.labelpass.TabIndex = 27;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.buttonChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Font = new System.Drawing.Font("TangoDi", 24F);
            this.buttonChange.ForeColor = System.Drawing.Color.Maroon;
            this.buttonChange.Location = new System.Drawing.Point(72, 503);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(314, 60);
            this.buttonChange.TabIndex = 28;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TangoDi", 24F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(64, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 47);
            this.label1.TabIndex = 32;
            this.label1.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TangoDi", 24F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(64, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 47);
            this.label2.TabIndex = 31;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TangoDi", 24F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(64, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 47);
            this.label3.TabIndex = 30;
            this.label3.Text = "Имя:";
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // pictureBoxreturn
            // 
            this.pictureBoxreturn.Image = global::Library2.Properties.Resources.Снимок;
            this.pictureBoxreturn.Location = new System.Drawing.Point(1070, 91);
            this.pictureBoxreturn.Name = "pictureBoxreturn";
            this.pictureBoxreturn.Size = new System.Drawing.Size(101, 78);
            this.pictureBoxreturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxreturn.TabIndex = 33;
            this.pictureBoxreturn.TabStop = false;
            this.pictureBoxreturn.Click += new System.EventHandler(this.pictureBoxreturn_Click);
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.GridColor = System.Drawing.Color.Maroon;
            this.dataGridViewRecords.Location = new System.Drawing.Point(491, 183);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.RowHeadersVisible = false;
            this.dataGridViewRecords.RowHeadersWidth = 51;
            this.dataGridViewRecords.RowTemplate.Height = 24;
            this.dataGridViewRecords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRecords.Size = new System.Drawing.Size(661, 380);
            this.dataGridViewRecords.TabIndex = 29;
            this.dataGridViewRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStore_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TangoDi", 24F);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(483, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 47);
            this.label4.TabIndex = 34;
            this.label4.Text = "История действий";
            // 
            // FormPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1183, 616);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxreturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewRecords);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.labelStore);
            this.Controls.Add(this.paneltop);
            this.Name = "FormPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личная библиотека";
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxreturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labelexit;
        private System.Windows.Forms.Label labelauth;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private System.Windows.Forms.PictureBox pictureBoxreturn;
        private System.Windows.Forms.DataGridView dataGridViewRecords;
        private System.Windows.Forms.Label label4;
    }
}