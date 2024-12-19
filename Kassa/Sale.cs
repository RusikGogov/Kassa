using Databases;
using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kassa
{
    public partial class Sale : Form
    {
        db db = new db();
        public Sale()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kassa recoveryform = new Kassa();
            recoveryform.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string querryString = $"update l_product SET kolvo = kolvo -'{textBox1.Text}' WHERE product_name = '{comboBox1.Text}'; " +
                                  $"update l_product SET kolvo = kolvo -'{textBox2.Text}' WHERE product_name = '{comboBox2.Text}'; " +
                                  $"update l_product SET kolvo = kolvo -'{textBox3.Text}' WHERE product_name = '{comboBox3.Text}'; " +
                                  $"update l_product SET kolvo = kolvo -'{textBox4.Text}' WHERE product_name = '{comboBox4.Text}'; " +
                                  $"update l_product SET kolvo = kolvo -'{textBox5.Text}' WHERE product_name = '{comboBox5.Text}'; " +
                                  $"update l_product SET kolvo = kolvo -'{textBox6.Text}' WHERE product_name = '{comboBox6.Text}'; " +
                                  $"update l_product SET kolvo = kolvo -'{textBox7.Text}' WHERE product_name = '{comboBox7.Text}'";
            MySqlCommand command = new MySqlCommand(querryString, db.getConnection());

            db.openConnection();

            command.ExecuteNonQuery();

            db.closeConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sale_Load(object sender, EventArgs e)
        {
            string querryString = $"Select product_name from l_product;";
            MySqlCommand command = new MySqlCommand(querryString, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(0));
                comboBox2.Items.Add(reader.GetString(0));
                comboBox3.Items.Add(reader.GetString(0));
                comboBox4.Items.Add(reader.GetString(0));
                comboBox5.Items.Add(reader.GetString(0));
                comboBox6.Items.Add(reader.GetString(0));
                comboBox7.Items.Add(reader.GetString(0));

            }
            reader.Close();

            db.closeConnection();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
