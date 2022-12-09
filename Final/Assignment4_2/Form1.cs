using Assignment4_2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_2
{
    public partial class Title : Form
    {
        string optionSelected = "";
        double dimension1 = 0;
        double dimension2 = 0;
        double dimension3 = 0;
        public Title()
        {
            InitializeComponent();
            this.setComboBox();
            this.hideForm();
            this.hideResult();
            errorLabel.Hide();
        }
        // Hide the form and the results
        private void hideForm()
        {
            dimension1label.Hide();
            dimension2label.Hide();
            dimension3label.Hide();
            dimension1textbox.Hide();
            dimension2textbox.Hide();
            dimension3textbox.Hide();
            dimension1textbox.Text = "";
            dimension2textbox.Text = "";
            dimension3textbox.Text = "";
            errorLabel.Hide();
            calculateButton.Hide();
            this.hideResult();
        }
        // Hide the results
        private void hideResult()
        {
            areaLabel.Hide();
            areaResultLabel.Hide();
            perimeterLabel.Hide();
            perimeterResultLabel.Hide();
        }
        // Show the results labels
        private void showResults()
        {
            areaLabel.Show();
            areaResultLabel.Show();
            perimeterLabel.Show();
            perimeterResultLabel.Show();
        }
        // Add items to the combobox
        private void setComboBox()
        {
            shapeComboBox.Items.Add("Square");
            shapeComboBox.Items.Add("Rectangle");
            shapeComboBox.Items.Add("Triangle");
            shapeComboBox.Items.Add("Circle");
            shapeComboBox.Items.Add("Ellipse");
        }

        private void shapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide result from previous calculation
            this.hideResult();
            // Hide the form to start clean
            this.hideForm();
            // Show button
            calculateButton.Show();
            // Set the option selected
            optionSelected = shapeComboBox.Text;
            // Based on the selection load the correct form
            if (shapeComboBox.SelectedIndex == 0)
            {
                loadSquareForm();
            } 
            else if (shapeComboBox.SelectedIndex == 1)
            {
                loadRectangelForm();
            } 
            else if (shapeComboBox.SelectedIndex == 2)
            {
                loadTriangleForm();
            } 
            else if (shapeComboBox.SelectedIndex == 3)
            {
                loadCircleForm();
            } 
            else if (shapeComboBox.SelectedIndex == 4)
            {
                loadEllipseForm();
            }
        }
        // Load the square form with just one input
        private void loadSquareForm()
        {
            dimension1label.Show();
            dimension1label.Text = "Side: ";
            dimension1textbox.Show();
        }
        // Load the rectangle form with two inputs
        private void loadRectangelForm()
        {
            dimension1label.Show();
            dimension1label.Text = "Side 1: ";
            dimension1textbox.Show();

            dimension2label.Show();
            dimension2label.Text = "Side 2: ";
            dimension2textbox.Show();
        }
        // Load the rectangle form with three inputs
        private void loadTriangleForm()
        {
            dimension1label.Show();
            dimension1label.Text = "Side 1";
            dimension1textbox.Show();

            dimension2label.Show();
            dimension2label.Text = "Side 2";
            dimension2textbox.Show();

            dimension3label.Show();
            dimension3label.Text = "Side 3";
            dimension3textbox.Show();
        }
        // Load the circle form with just one input
        private void loadCircleForm()
        {
            dimension1label.Show();
            dimension1label.Text = "Radius: ";
            dimension1textbox.Show();
        }
        // Load the ellipse form with two inputs
        private void loadEllipseForm()
        {
            dimension1label.Show();
            dimension1label.Text = "Axis 1: ";
            dimension1textbox.Show();

            dimension2label.Show();
            dimension2label.Text = "Axis 2: ";
            dimension2textbox.Show();
        }
        // Onclick event to show the results
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (this.optionSelected != "")
            {
                this.getResults();
            }
        }
        // Get the data and perform error handling
        private void getResults()
        {
            // Keeps track if everything is good to continue
            bool cont = true;
            try
            {
                // Try and get data from textboxes
                // The first demension is always used
                dimension1 = Convert.ToDouble(dimension1textbox.Text);
                // if its a square or circle only dimension 1 is equal to 1 else its equal to the value from the text form
                dimension2 = (optionSelected == "Square" || optionSelected == "Circle") 
                    ?  1
                    : Convert.ToDouble(dimension2textbox.Text);
                // if its a square, circle, rectangle or ellipse do the same
                dimension3 = (optionSelected == "Square" || optionSelected == "Circle" || optionSelected == "Rectangle" || optionSelected == "Ellipse")
                    ? 1
                    : Convert.ToDouble(dimension3textbox.Text);
            // if things don't check out display an error and do not allow to continue
            } catch (FormatException) {
                errorLabel.Show();
                errorLabel.Text = "Inputs must be numerical.";
                cont = false;
            }
            // if the value of either textbox is not a positive number, display the error and do not allow to continue
            if (dimension1 <= 0 || dimension2 <= 0)
            {
                cont = false;
                errorLabel.Text = "Inputs must be a positive number.";
            }
            // If everything is good then clear the error, calculate and show results
            if (cont)
            {
                errorLabel.Hide();
                this.calculate();
            }
            
        }

        private void calculate()
        {
            // Perform calculations using the classes created for each shape
            if (optionSelected == "Square")
            {
                Square square = new Square(dimension1);
                areaResultLabel.Text = Math.Round(square.getArea(), 2).ToString();
                perimeterResultLabel.Text = Math.Round(square.getPerimeter(), 2).ToString();
            }
            else if (optionSelected == "Rectangle")
            {
                Classes.Rectangle rectangle = new Classes.Rectangle(dimension1, dimension2);
                areaResultLabel.Text = Math.Round(rectangle.getArea(), 2).ToString();
                perimeterResultLabel.Text = Math.Round(rectangle.getPerimeter(), 2).ToString();
            }
            else if (optionSelected == "Triangle")
            {
                Triangle triangle = new Triangle(dimension1, dimension2, dimension3);
                areaResultLabel.Text = Math.Round(triangle.getArea(), 2).ToString();
                perimeterResultLabel.Text = Math.Round(triangle.getPerimeter(), 2).ToString();
            }
            else if (optionSelected == "Circle")
            {
                Circle circle = new Circle(dimension1);
                areaResultLabel.Text= Math.Round(circle.getArea(), 2).ToString();
                perimeterResultLabel.Text = Math.Round(circle.getPerimeter(), 2).ToString();
            }
            else if (optionSelected == "Ellipse")
            {
                Ellipse ellipse = new Ellipse(dimension1, dimension2);
                areaResultLabel.Text = Math.Round(ellipse.getArea(), 2).ToString();
                perimeterResultLabel.Text = Math.Round(ellipse.getPerimeter(), 2).ToString();
            }
            // Show the results labels
            this.showResults();
        }
    }
}
