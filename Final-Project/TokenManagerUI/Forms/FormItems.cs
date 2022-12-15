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

namespace TokenManagerUI.Forms
{
    public partial class FormItems : Form
    {
        private int itemId = 0;
        public FormItems()
        {
            InitializeComponent();

            this.resetErrors();
            this.getItemIds();
        }

        private void getItemIds()
        {
            listBox1.Items.Clear();
            DatabaseConnection databaseConnection = new DatabaseConnection();
            string query = "Select * from item where event_id = " + SessionInfo.id + " AND type = 'shop'";
            MySqlDataReader reader = databaseConnection.Query(query);

            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "id";

            while (reader.Read())
            {
                listBox1.Items.Add(new ComboboxValue(Convert.ToInt32(reader["id"].ToString()), reader["name"].ToString()));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.resetErrors();
            ComboboxValue tmpComboboxValue = (ComboboxValue)listBox1.SelectedItem;
            if (tmpComboboxValue != null)
            {
                this.itemId = tmpComboboxValue.Id;
            }
            else
            {
                this.itemId = 0;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validated = true;
            string error = "Required";
            this.resetErrors();

            if (textBox1.Text == "")
            {
                validated = false;
                labelError1.Text = error;
            }

            if (textBox2.Text == "")
            {
                validated = false;
                labelError2.Text = error;
            }

            if (validated)
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                string query = "INSERT INTO item (id, event_id, name, price, type) VALUES (NULL, '" + SessionInfo.id + "', '" + textBox1.Text + "', '" + textBox2.Text + "', 'shop')";
                MySqlDataReader reader = databaseConnection.Query(query);

                this.getItemIds();

                textBox1.Text = "";
                textBox2.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.resetErrors();
            if (this.itemId != 0)
            {
                try
                {
                    DatabaseConnection databaseConnection = new DatabaseConnection();
                    string query = "DELETE FROM item WHERE id = " + this.itemId;
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection.connect());
                    MySqlDataReader reader = cmd.ExecuteReader();
                }
                catch (MySqlException)
                {
                    labelError3.Text = "This item is part of an event.";
                }

                this.getItemIds();
            }
            else
            {
                labelError3.Text = "Select an item.";
            }
        }

        private void resetErrors()
        {
            labelError1.Text = "";
            labelError2.Text = "";
            labelError3.Text = "";
        }

        private void FormItems_Load(object sender, EventArgs e)
        {

        }


    }
}
