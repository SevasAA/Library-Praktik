using MySqlX.XDevAPI.Relational;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{
    public partial class FormAdmin : Form
    {
        private DataTable Table;
        private NpgsqlDataAdapter adapter;

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void labelexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm formRegistr = new loginForm();
            formRegistr.Show();
        }
        


        public DataTable UserShow() {
            ClassDataBase db = new ClassDataBase();
            Table = new DataTable();
            adapter = new NpgsqlDataAdapter();

            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users;", db.connection);

            db.openConnection();

            adapter.SelectCommand = command;
            adapter.Fill(Table);

            db.closeConnection();

            return Table;
            
           

        }

        private void buttonShowUsers_Click(object sender, EventArgs e)
        {
            Table = UserShow();
            
          
            dataGridView1.DataSource = Table.DefaultView.ToTable(false, "id", "login", "name", "dostup");

          //  dataGridView1.ReadOnly = false;
           // dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;


        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView rowView = dataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (rowView != null)
            {
                adapter.Update(new DataRow[] { rowView.Row });
            }
        }

        private void pictureBoxreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuAdmin formRegistr = new FormMenuAdmin();
            formRegistr.Show();
        }
    }
}
