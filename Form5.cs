using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FurnitSotre
{
    public partial class Form5 : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=DB_FurnitStore;User Id=postgres;Password=0228;");

        public Form5()
        {
            InitializeComponent();
            filling_datagridview();
            maxlength_textbox();
        }

        private void maxlength_textbox() // Ограничения ввода textBox
        {
            textBox2.MaxLength = 100;
            textBox3.MaxLength = 100;
        }

        public void filling_datagridview() // Метод заполнения DataGridView
        {
            NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter("SELECT * FROM \"Add\"", con);
            DataSet db = new DataSet();

            DataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Материал";
            con.Close();
        }

        public void textbox_clearing()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
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
                    (textBox3.Text != ("")))
                {
                    await con.OpenAsync();
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"Add\" (\"Name_add\", \"Material\") VALUES (@Name_add, @Material)", con);

                    command.Parameters.AddWithValue("Name_add", textBox2.Text);
                    command.Parameters.AddWithValue("Material", textBox3.Text);

                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Добавлен новый доп.элемент.");

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // Выборочное заполнение TextBox из DataGridVie
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private async void button4_Click(object sender, EventArgs e) // Удаление строки
        {
            try
            {
                if (textBox1.Text != (""))
                {
                    await con.OpenAsync();
                    NpgsqlCommand command = new NpgsqlCommand("DELETE FROM \"Add\" WHERE \"ID_add\" = @ID_add", con);

                    command.Parameters.AddWithValue("ID_add", int.Parse(textBox1.Text));

                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Доп.элемент удален.");

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

        private async void button3_Click(object sender, EventArgs e) // Изменение строки
        {
            try
            {
                if ((textBox1.Text != ("")) &&
                    (textBox2.Text != ("")) &&
                    (textBox3.Text != ("")))
                {
                    await con.OpenAsync();
                    NpgsqlCommand command = new NpgsqlCommand("UPDATE \"Add\" SET \"Name_add\" = @Name_add, \"Material\" = @Material WHERE \"ID_add\" = @ID_add", con);

                    command.Parameters.AddWithValue("ID_add", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("Name_add", textBox2.Text);
                    command.Parameters.AddWithValue("Material", textBox3.Text);

                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Доп.элемент изменен.");

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
