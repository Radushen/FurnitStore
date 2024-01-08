using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace FurnitSotre
{
    public partial class Form4 : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=DB_FurnitStore;User Id=postgres;Password=0228;");

        public Form4()
        {
            InitializeComponent();
            filling_datagridview();
            maxlength_textbox();
        }

        private void maxlength_textbox() // Ограничения ввода textBox
        {
            textBox2.MaxLength = 100;
            textBox3.MaxLength = 100;
            textBox4.MaxLength = 100;
            textBox5.MaxLength = 100;
            textBox6.MaxLength = 100;
        }

        public void filling_datagridview() // Метод заполнения DataGridView
        {
            NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter("SELECT * FROM \"Furniture\"", con);
            DataSet db = new DataSet();

            DataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Материал";
            dataGridView1.Columns[3].HeaderText = "Механизм";
            dataGridView1.Columns[4].HeaderText = "Обивка";
            dataGridView1.Columns[5].HeaderText = "Размер";
            con.Close();
        }

        public void textbox_clearing()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private async void button1_Click(object sender, EventArgs e) // Добавление строки
        {
            try
            {
                if ((textBox2.Text != ("")) &&
                    (textBox3.Text != ("")) &&
                    (textBox4.Text != ("")) &&
                    (textBox5.Text != ("")) &&
                    (textBox6.Text != ("")))
                {
                    await con.OpenAsync();
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"Furniture\" (\"Name\", \"Material\", \"Mechanism\", \"Filler\", \"Size\") VALUES (@Name, @Material, @Mechanism, @Filler, @Size)", con);

                    command.Parameters.AddWithValue("Name", textBox2.Text);
                    command.Parameters.AddWithValue("Material", textBox3.Text);
                    command.Parameters.AddWithValue("Mechanism", textBox4.Text);
                    command.Parameters.AddWithValue("Filler", textBox5.Text);
                    command.Parameters.AddWithValue("Size", textBox6.Text);

                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Добавлена новая мебель.");

                    con.Close();
                    textbox_clearing();
                    filling_datagridview(); // Вызов метода заполнения DataGridView
                }
                else MessageBox.Show("Поля пусты!");
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // Выборочное заполнение TextBox из DataGridView
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private async void button4_Click(object sender, EventArgs e) // Удаление строки
        {
            try
            {
                if (textBox2.Text != (""))
                {
                    await con.OpenAsync();
                    NpgsqlCommand command = new NpgsqlCommand("DELETE FROM \"Furniture\" WHERE \"ID_furniture\" = @ID_furniture", con);

                    command.Parameters.AddWithValue("ID_furniture", int.Parse(textBox1.Text));

                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Мебель удалена.");

                    con.Close();
                    textbox_clearing();
                    filling_datagridview(); // Вызов метода заполнения DataGridView
                }
                else MessageBox.Show("Поля пусты!");
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        public async void button3_Click(object sender, EventArgs e) // Изменение строки
        {
            try
            {
                if ((textBox1.Text != ("")) && 
                    (textBox2.Text != ("")) &&
                    (textBox3.Text != ("")) &&
                    (textBox4.Text != ("")) &&
                    (textBox5.Text != ("")) &&
                    (textBox6.Text != ("")))
                {
                    await con.OpenAsync();
                    NpgsqlCommand command = new NpgsqlCommand("UPDATE \"Furniture\" SET \"Name\" = @Name, \"Material\" = @Material, \"Mechanism\" = @Mechanism, \"Filler\" = @Filler, \"Size\" = @Size WHERE \"ID_furniture\" = @ID_furniture", con);

                    command.Parameters.AddWithValue("ID_furniture", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("Name", textBox2.Text);
                    command.Parameters.AddWithValue("Material", textBox3.Text);
                    command.Parameters.AddWithValue("Mechanism", textBox4.Text);
                    command.Parameters.AddWithValue("Filler", textBox5.Text);
                    command.Parameters.AddWithValue("Size", textBox6.Text);

                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Мебель изменена.");

                    con.Close();
                    textbox_clearing();
                    filling_datagridview(); // Вызов метода заполнения DataGridView
                }
                else MessageBox.Show("Поля пусты!");
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}

