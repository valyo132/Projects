using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Note_Taking
{
    public partial class Form1 : Form
    {
        private DataSet set;
        private DataTable table;
        bool editing;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            titleText.Text = string.Empty;
            noteText.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (titleText.Text != "" && noteText.Text != "")
            {
                if (editing)
                {
                    table.Rows[grid.CurrentCell.RowIndex]["Title"] = titleText.Text;
                    table.Rows[grid.CurrentCell.RowIndex]["Note"] = titleText.Text;
                }
                else
                {
                    table.Rows.Add(titleText.Text, noteText.Text);
                }
            }

            editing = false;
            titleText.Text = "";
            noteText.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            set = new DataSet("app");
            table = new DataTable("Notes");

            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Note", typeof(string));

            set.Tables.Add(table);
            grid.DataSource = set.Tables["Notes"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            titleText.Text = table.Rows[grid.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteText.Text = table.Rows[grid.CurrentCell.RowIndex].ItemArray[1].ToString();

            editing = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table.Rows[grid.CurrentCell.RowIndex].Delete();
        }
    }
}
