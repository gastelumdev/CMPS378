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
using USB_Barcode_Scanner;

namespace TokenManagerUI.Forms
{
    public partial class FormCards : Form
    {
        private string barcode = "";
        private string cardId;
        private string cardNumber;
        private int tokenAmount = 0;
        public FormCards()
        {
            InitializeComponent();
            // Create an barcode scannner and pass in the desired textbox target
            BarcodeScanner barcodeScanner = new BarcodeScanner(textBox1);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;

            // Hide Results
            this.hideResults();
            // Set token price
            this.setTokenPrice();

        }
        // Method called when the barcode scanner is scans a barcode
        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            // Hide Results
            this.hideResults();
            // Set the barcode number to the textbox and set the class variable
            textBox1.Text = e.Barcode;
            this.barcode = e.Barcode;

            label3.Text = "Tokens: ";
            this.setTokenPrice();

            // Find the card based on the card number scanned
            DatabaseConnection databaseConnection = new DatabaseConnection();
            string query = "Select * from card where ticket_number = " + this.barcode + " AND event_id = " + SessionInfo.id;
            MySqlDataReader reader = databaseConnection.Query(query);
            // If nothing found set the instance card number to the barcode number scanned
            if (!reader.Read())
            {
                label4.Text = "0";
            }
            else
            {
                // Set the card to the card from the database
                label4.Text = reader["token_quantity"].ToString();
            }
        }

        private void setCard()
        {
            // If barcode is not set then set it to what is on the text box
            if (this.barcode == "")
            {
                this.barcode = textBox1.Text;
            }

            
            // Find the card based on the card number scanned
            DatabaseConnection databaseConnection = new DatabaseConnection();
            string query = "Select * from card where ticket_number = " + this.barcode + " AND event_id = " + SessionInfo.id;
            MySqlDataReader reader = databaseConnection.Query(query);
            // If nothing found set the instance card number to the barcode number scanned
            if (!reader.Read())
            {
                this.cardId = null;
                this.cardNumber = this.barcode;
                this.tokenAmount = 0;
            }
            else
            {
                // Set the card to the card from the database
                this.cardId = reader["id"].ToString();
                this.cardNumber = reader["ticket_number"].ToString();
                this.tokenAmount = Convert.ToInt32(reader["token_quantity"].ToString());
            }
        }

        private string getTokenPrice()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            string query = "Select * from event where id = " + SessionInfo.id;
            MySqlDataReader reader = databaseConnection.Query(query);

            reader.Read();
            return reader["token_price"].ToString();
        }

        private void FormCards_Activated(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set validation errors
            bool validated = true;
            string error = "Required";
            this.resetErrors();
            int tokenValue = 0;
            this.setTokenPrice();

            // If any of the fields are empty set to not validated
            if (textBox1.Text == "")
            {
                validated = false;
                labelError.Text = error;
            }

            if (textBox2.Text == "")
            {
                validated = false;
                labelError2.Text = error;
            }
            else
            {
                // also check if the value is 1 or more
                try
                {
                    tokenValue = Convert.ToInt32(textBox2.Text);
                    if (tokenValue < 1)
                    {
                        validated = false;
                        labelError2.Text = "Token amount should be 1 or more";
                    }
                    // Display error
                }
                catch (Exception err)
                {
                    labelError2.Text = err.Message;
                    textBox2.Text = "0";
                }

            }
            // If everything checks out update of insert into database 
            if (validated)
            {
                // Set Card
                this.setCard();
                label3.Text = "Tokens: ";
                label8.Text = "Total: ";
                this.tokenAmount += Convert.ToInt32(textBox2.Text);

                DatabaseConnection databaseConnection = new DatabaseConnection();

                if (this.cardId == null)
                {
                    string query = "INSERT INTO card (id, event_id, ticket_number, token_quantity) VALUES (NULL, " + SessionInfo.id + ", " + this.cardNumber + ", " + this.tokenAmount + ")";
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection.connect());
                    MySqlDataReader reader = cmd.ExecuteReader();
                }
                else
                {
                    string query = "UPDATE card SET event_id = " + SessionInfo.id + ", ticket_number = " + this.cardNumber + ", token_quantity = " + this.tokenAmount + " WHERE id = " + this.cardId + " AND event_id = " + SessionInfo.id;
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection.connect());
                    MySqlDataReader reader = cmd.ExecuteReader();
                }

                label4.Text = this.tokenAmount.ToString();

                // Get Price and make a calculation of the total
                int price = Convert.ToInt32(this.getTokenPrice()) * Convert.ToInt32(textBox2.Text);
                label7.Text = "$" + price.ToString();
            }
            textBox1.Focus();
        }

        private void resetErrors()
        {
            labelError.Text = "";
            labelError2.Text = "";
        }

        private void hideResults()
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void setTokenPrice()
        {
            // Set Price
            label5.Text = "Price: ";
            label6.Text = "$" + this.getTokenPrice();
        }
    }

    
}
