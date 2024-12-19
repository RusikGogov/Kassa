using Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Databases;

namespace Kassa
{
    public partial class NewSupply : Form
    {
        db db = new db();


        public NewSupply()
        {
            InitializeComponent();
            createColumns();
        }

        private void createColumns()
        {
            dataGridView1.Columns.Add("product_name", "Наименование");
            dataGridView1.Columns[0].Width = 375;

            dataGridView1.Columns.Add("id_class", "Тип");
            dataGridView1.Columns[1].Width = 300;

            dataGridView1.Columns.Add("manufacturer_id", "Поставщик");
            dataGridView1.Columns[2].Width = 300;

            dataGridView1.Columns.Add("product_price", "Цена");
            dataGridView1.Columns[3].Width = 100;

            dataGridView1.Columns.Add("kolvo", "Кол-во");
            dataGridView1.Columns[4].Width = 100;

        }

        private void Zelebobchik(DataGridView zeleboba)
        {
            zeleboba.Rows.Clear();
            string querryString = $"Select product_name,class_name, manufacturer_name, product_price, kolvo from l_product inner join manufacturers on manufacturer_id = id_manufacturer inner join product_classes on id_class = class_id";
            MySqlCommand commanda = new MySqlCommand(querryString, db.getConnection());
            db.openConnection();
            MySqlDataReader reader = commanda.ExecuteReader();
            while (reader.Read())
            {
                readSingleRow(zeleboba, reader);
            }
            reader.Close();
            db.closeConnection();
        }

        private void giveType(ComboBox types)
        {
            string querryString = $"Select class_name from product_classes;";
            MySqlCommand command = new MySqlCommand(querryString, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                types.Items.Add(reader.GetString(0));
            }
            reader.Close();

            db.closeConnection();
        }
        private void giveManufacturer(ComboBox manufacturer)
        {
            string querryString = $"Select manufacturer_name from manufacturers;";
            MySqlCommand command = new MySqlCommand(querryString, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                manufacturer.Items.Add(reader.GetString(0));
            }
            reader.Close();

            db.closeConnection();
        }

        private void readSingleRow(DataGridView zeleboba, IDataRecord record)
        {
            zeleboba.Rows.Add(record.GetString(0),record.GetString(1), record.GetString(2), record.GetDouble(3), record.GetString(4));
        }
        private void NewSupply_Load(object sender, EventArgs e)
        {
            Zelebobchik(dataGridView1);
            giveType(comboBoxTypes);
            giveManufacturer(comboBoxManufacturer);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kassa recoveryform = new Kassa();
            recoveryform.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            string querryString = $"insert into l_product (product_name,description,id_manufacturer,id_class,kolvo,product_price) values ('{textBoxName.Text}', '{textBoxDescription.Text}', (select manufacturer_id from manufacturers where manufacturer_name Like '{comboBoxManufacturer.Text}'),(select class_id from product_classes where class_name Like '{comboBoxTypes.Text}'), '{textBoxKolvo.Text}','{textBoxPrice.Text}')";
            MySqlCommand command = new MySqlCommand(querryString, db.getConnection());

            db.openConnection();

            command.ExecuteNonQuery();
            Zelebobchik(dataGridView1);

            db.closeConnection();
        }

        private void comboBoxManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
