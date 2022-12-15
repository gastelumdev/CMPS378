using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using USB_Barcode_Scanner;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TokenManagerUI.Forms
{
    public partial class FormCardScanner2 : Form
    {
        private int itemTokensRequired = 0;
        private int currentItem = 0;
        private int item1id = 0;
        private int item1Price = 0;
        private int item2id = 0;
        private int item2Price = 0;
        private int item3id = 0;
        private int item3Price = 0;
        private int item4id = 0;
        private int item4Price = 0;
        private bool addItems = true;

        public FormCardScanner2()
        {
            InitializeComponent();
            this.hideButtons();
            // Update the items in the drop down
            this.getItemIds();
            addButton.BackColor = Color.LightGreen;
            
            // Create an barcode scannner and pass in the desired textbox target
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBox1);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }
        // Method called when the barcode scanner is scans a barcode
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            // Set the barcode number to the textbox and set the class variable
            textBox1.Text = e.Barcode;
            this.resetErrors();
            label3.ForeColor = Colors.heading;

            // Get the card
            DatabaseConnection databaseConnection = new DatabaseConnection();
            string query = "Select * from card where ticket_number = " + e.Barcode + " AND event_id = " + SessionInfo.id;
            MySqlDataReader reader = databaseConnection.Query(query);
            // If the card does not exist, display error
            if (!reader.Read())
            {
                label3.Text = "Card " + e.Barcode + " does not exist";
                label3.ForeColor = Color.FromArgb(192, 0, 0);
            }
            // Otherwise, check if the amount of tokens is greater or equal to the amount of tokens required
            // adn update the card value by subtracting the amount of tokens required from the amount
            // Also display the amount of tokens left in the card
            else
            {
                int tokens = (int)reader["token_quantity"];
                if (tokens >= this.itemTokensRequired)
                {
                    int updatedCardValue = tokens - this.itemTokensRequired;
                    this.updateCard(e.Barcode, updatedCardValue);
                    label3.Text = "Tokens Available: " + (tokens - this.itemTokensRequired).ToString();
                    label3.ForeColor = Color.Green;
                }
                // Display that tokens are insufficient
                else
                {
                    label3.Text = "Tokens are not sufficient: " + tokens.ToString() + " tokens";
                    label3.ForeColor = Color.FromArgb(192, 0, 0);
                }
            }
        }
        // Update a card's token quantity based on it's card number
        private void updateCard(string cardNumber, int updatedValue)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            string query = "UPDATE card SET token_quantity = " + updatedValue.ToString() + " WHERE ticket_number = " + cardNumber + " AND event_id = " + SessionInfo.id;
            MySqlDataReader reader = databaseConnection.Query(query);
        }

        private void getItemIds()
        {

            DatabaseConnection databaseConnection = new DatabaseConnection();
            string query = "Select * from item where event_id = " + SessionInfo.id + " AND type = 'shop'";
            MySqlDataReader reader = databaseConnection.Query(query);
            // Pass the items to the set list view method
            //this.setListView(reader);
            this.setButtons(reader);
        }

        private void setButtons(MySqlDataReader r)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            string query = "Select COUNT(*) from item where event_id = " + SessionInfo.id + " AND type = 'shop'";
            MySqlDataReader reader = databaseConnection.Query(query);

            reader.Read();
            int result = Convert.ToInt32(reader[0].ToString());

            for (int i = 0; i < result; i++)
            {
                if (i == 0)
                {
                    r.Read();
                    button1.Show();
                    button1.Text = r["name"].ToString() + " " + r["price"].ToString();
                    this.item1id = Convert.ToInt32(r["id"].ToString());
                    this.item1Price = Convert.ToInt32(r["price"].ToString());
                }
                else if (i == 1)
                {
                    r.Read();
                    button2.Show();
                    button2.Text = r["name"].ToString() + " " + r["price"].ToString();
                    this.item2id = Convert.ToInt32(r["id"].ToString());
                    this.item2Price = Convert.ToInt32(r["price"].ToString());
                }
                else if (i == 2)
                {
                    r.Read();
                    button3.Show();
                    button3.Text = r["name"].ToString() + " " + r["price"].ToString();
                    this.item3id = Convert.ToInt32(r["id"].ToString());
                    this.item3Price = Convert.ToInt32(r["price"].ToString());
                }
                else if (i == 3)
                {
                    r.Read();
                    button4.Show();
                    button4.Text = r["name"].ToString() + " " + r["price"].ToString();
                    this.item4id = Convert.ToInt32(r["id"].ToString());
                    this.item4Price = Convert.ToInt32(r["price"].ToString());
                }
            }
        }

        private void resetErrors()
        {
            labelError.Text = "";
        }

        private void hideButtons()
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.addItems)
            {
                this.itemTokensRequired += this.item1Price;
            }
            else
            {
                this.itemTokensRequired -= this.item1Price;
            }
            
            label2.Text = "Total: " + this.itemTokensRequired.ToString();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.addItems)
            {
                this.itemTokensRequired += this.item2Price;
            }
            else
            {
                this.itemTokensRequired -= this.item2Price;
            }
            label2.Text = "Total: " + this.itemTokensRequired.ToString();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.addItems)
            {
                this.itemTokensRequired += this.item3Price;
            }
            else
            {
                this.itemTokensRequired -= this.item3Price;
            }
            label2.Text = "Total: " + this.itemTokensRequired.ToString();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.addItems)
            {
                this.itemTokensRequired += this.item4Price;
            }
            else
            {
                this.itemTokensRequired -= this.item4Price;
            }
            label2.Text = "Total: " + this.itemTokensRequired.ToString();
            textBox1.Focus();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.addItems = true;
            addButton.BackColor = Color.LightGreen;
            removeButton.BackColor = Color.GhostWhite;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.addItems = false;
            addButton.BackColor = Color.GhostWhite;
            removeButton.BackColor = Color.LightGreen;
        }
    }

    
}
