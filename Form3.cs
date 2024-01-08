using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Configuration.Provider;
using System.Xml.Linq;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FurnitSotre
{
    public partial class Form3 : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=DB_FurnitStore;User Id=postgres;Password=0228;");

        public Form3()
        {
            InitializeComponent();
            filling_datagridview();
            maxlength_textbox();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void maxlength_textbox() // Ограничения ввода textBox
        {
            textBox4.MaxLength = 100;
            textBox5.MaxLength = 11;
            textBox6.MaxLength = 100;
        }

        public void filling_datagridview() // Метод заполнения DataGridView
        {
            NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter("SELECT * FROM \"Delivery_view\"", con);
            DataSet db = new DataSet();

            DataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Мебель";
            dataGridView1.Columns[2].HeaderText = "Доп.элемент";
            dataGridView1.Columns[3].HeaderText = "Адрес";
            dataGridView1.Columns[4].HeaderText = "Телефон";
            dataGridView1.Columns[5].HeaderText = "Стоимость";
            load_combobox1();
            load_combobox2();
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

        private async void load_combobox1() // Заполнение comboBox1
        {
            await con.OpenAsync();
            using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"Furniture\"", con))
            {
                command.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                adapter.Fill(table);
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID_furniture";
                comboBox1.DataSource = table;
            }
            con.Close();
        }

        private async void load_combobox2() // Заполнение comboBox2
        {
            await con.OpenAsync();
            using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM \"Add\"", con))
            {
                command.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                adapter.Fill(table);
                comboBox2.DisplayMember = "Name_add";
                comboBox2.ValueMember = "ID_add";
                comboBox2.DataSource = table;
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBox1.SelectedValue!.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox2.SelectedValue!.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
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
                    NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"Delivery\" (\"ID_furniture\", \"ID_add\", \"Address\", \"Phone\", \"Cost\") VALUES (@ID_furniture, @ID_add, @Address, @Phone, @Cost)", con);

                    command.Parameters.AddWithValue("ID_furniture", int.Parse(textBox2.Text));
                    command.Parameters.AddWithValue("ID_add", int.Parse(textBox3.Text));
                    command.Parameters.AddWithValue("Address", textBox4.Text);
                    command.Parameters.AddWithValue("Phone", long.Parse(textBox5.Text));
                    command.Parameters.AddWithValue("Cost", long.Parse(textBox6.Text));

                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Добавлена новая доставка.");

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

        private async void button4_Click(object sender, EventArgs e)  // Удаление строки
        {
            try
            {
                if (textBox2.Text != (""))
                {
                    await con.OpenAsync();
                    NpgsqlCommand command = new NpgsqlCommand("DELETE FROM \"Delivery\" WHERE \"ID_delivery\" = @ID_delivery", con);

                    command.Parameters.AddWithValue("ID_delivery", int.Parse(textBox1.Text));

                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Доставка удалена.");

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

        private async void button3_Click(object sender, EventArgs e)
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
                    NpgsqlCommand command = new NpgsqlCommand("UPDATE \"Delivery\" SET \"ID_furniture\" = @ID_furniture, \"ID_add\" = @ID_add, \"Address\" = @Address, \"Phone\" = @Phone, \"Cost\" = @Cost WHERE \"ID_delivery\" = @ID_delivery", con);

                    command.Parameters.AddWithValue("ID_delivery", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("ID_furniture", int.Parse(textBox2.Text));
                    command.Parameters.AddWithValue("ID_add", int.Parse(textBox3.Text));
                    command.Parameters.AddWithValue("Address", textBox4.Text);
                    command.Parameters.AddWithValue("Phone", long.Parse(textBox5.Text));
                    command.Parameters.AddWithValue("Cost", long.Parse(textBox6.Text));

                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Доставка изменена.");

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
