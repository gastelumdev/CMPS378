namespace Assignment4_2
{
    partial class Title
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeSelectLabel = new System.Windows.Forms.Label();
            this.dimension1label = new System.Windows.Forms.Label();
            this.dimension2label = new System.Windows.Forms.Label();
            this.dimension1textbox = new System.Windows.Forms.TextBox();
            this.dimension2textbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.areaLabel = new System.Windows.Forms.Label();
            this.perimeterLabel = new System.Windows.Forms.Label();
            this.areaResultLabel = new System.Windows.Forms.Label();
            this.perimeterResultLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.dimension3textbox = new System.Windows.Forms.TextBox();
            this.dimension3label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shapeComboBox
            // 
            this.shapeComboBox.FormattingEnabled = true;
            this.shapeComboBox.Location = new System.Drawing.Point(750, 181);
            this.shapeComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.shapeComboBox.Name = "shapeComboBox";
            this.shapeComboBox.Size = new System.Drawing.Size(238, 33);
            this.shapeComboBox.TabIndex = 1;
            this.shapeComboBox.SelectedIndexChanged += new System.EventHandler(this.shapeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Area and Perimeter of an Object";
            // 
            // shapeSelectLabel
            // 
            this.shapeSelectLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeSelectLabel.Location = new System.Drawing.Point(305, 169);
            this.shapeSelectLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.shapeSelectLabel.Name = "shapeSelectLabel";
            this.shapeSelectLabel.Size = new System.Drawing.Size(433, 45);
            this.shapeSelectLabel.TabIndex = 3;
            this.shapeSelectLabel.Text = "Shape:";
            this.shapeSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dimension1label
            // 
            this.dimension1label.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimension1label.Location = new System.Drawing.Point(313, 332);
            this.dimension1label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dimension1label.Name = "dimension1label";
            this.dimension1label.Size = new System.Drawing.Size(425, 45);
            this.dimension1label.TabIndex = 4;
            this.dimension1label.Text = "Dimension 1:";
            this.dimension1label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dimension2label
            // 
            this.dimension2label.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimension2label.Location = new System.Drawing.Point(321, 401);
            this.dimension2label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dimension2label.Name = "dimension2label";
            this.dimension2label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dimension2label.Size = new System.Drawing.Size(417, 45);
            this.dimension2label.TabIndex = 5;
            this.dimension2label.Text = "Dimension 2:";
            this.dimension2label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dimension1textbox
            // 
            this.dimension1textbox.Location = new System.Drawing.Point(752, 346);
            this.dimension1textbox.Margin = new System.Windows.Forms.Padding(6);
            this.dimension1textbox.Name = "dimension1textbox";
            this.dimension1textbox.Size = new System.Drawing.Size(236, 31);
            this.dimension1textbox.TabIndex = 6;
            // 
            // dimension2textbox
            // 
            this.dimension2textbox.Location = new System.Drawing.Point(750, 415);
            this.dimension2textbox.Margin = new System.Windows.Forms.Padding(6);
            this.dimension2textbox.Name = "dimension2textbox";
            this.dimension2textbox.Size = new System.Drawing.Size(236, 31);
            this.dimension2textbox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(752, 554);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(6);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 44);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Go";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // areaLabel
            // 
            this.areaLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.Location = new System.Drawing.Point(342, 684);
            this.areaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(396, 45);
            this.areaLabel.TabIndex = 9;
            this.areaLabel.Text = "Area:";
            this.areaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // perimeterLabel
            // 
            this.perimeterLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perimeterLabel.Location = new System.Drawing.Point(334, 742);
            this.perimeterLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.perimeterLabel.Name = "perimeterLabel";
            this.perimeterLabel.Size = new System.Drawing.Size(404, 45);
            this.perimeterLabel.TabIndex = 10;
            this.perimeterLabel.Text = "Perimeter:";
            this.perimeterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // areaResultLabel
            // 
            this.areaResultLabel.AutoSize = true;
            this.areaResultLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaResultLabel.Location = new System.Drawing.Point(744, 684);
            this.areaResultLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.areaResultLabel.Name = "areaResultLabel";
            this.areaResultLabel.Size = new System.Drawing.Size(37, 45);
            this.areaResultLabel.TabIndex = 11;
            this.areaResultLabel.Text = "0";
            // 
            // perimeterResultLabel
            // 
            this.perimeterResultLabel.AutoSize = true;
            this.perimeterResultLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perimeterResultLabel.Location = new System.Drawing.Point(744, 742);
            this.perimeterResultLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.perimeterResultLabel.Name = "perimeterResultLabel";
            this.perimeterResultLabel.Size = new System.Drawing.Size(37, 45);
            this.perimeterResultLabel.TabIndex = 12;
            this.perimeterResultLabel.Text = "0";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(745, 483);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(74, 37);
            this.errorLabel.TabIndex = 13;
            this.errorLabel.Text = "Error";
            // 
            // dimension3textbox
            // 
            this.dimension3textbox.Location = new System.Drawing.Point(752, 483);
            this.dimension3textbox.Margin = new System.Windows.Forms.Padding(6);
            this.dimension3textbox.Name = "dimension3textbox";
            this.dimension3textbox.Size = new System.Drawing.Size(236, 31);
            this.dimension3textbox.TabIndex = 15;
            // 
            // dimension3label
            // 
            this.dimension3label.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimension3label.Location = new System.Drawing.Point(319, 469);
            this.dimension3label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dimension3label.Name = "dimension3label";
            this.dimension3label.Size = new System.Drawing.Size(419, 45);
            this.dimension3label.TabIndex = 14;
            this.dimension3label.Text = "Dimension 3:";
            this.dimension3label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.dimension3textbox);
            this.Controls.Add(this.dimension3label);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.perimeterResultLabel);
            this.Controls.Add(this.areaResultLabel);
            this.Controls.Add(this.perimeterLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.dimension2textbox);
            this.Controls.Add(this.dimension1textbox);
            this.Controls.Add(this.dimension2label);
            this.Controls.Add(this.dimension1label);
            this.Controls.Add(this.shapeSelectLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeComboBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Title";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox shapeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label shapeSelectLabel;
        private System.Windows.Forms.Label dimension1label;
        private System.Windows.Forms.Label dimension2label;
        private System.Windows.Forms.TextBox dimension1textbox;
        private System.Windows.Forms.TextBox dimension2textbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label perimeterLabel;
        private System.Windows.Forms.Label areaResultLabel;
        private System.Windows.Forms.Label perimeterResultLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox dimension3textbox;
        private System.Windows.Forms.Label dimension3label;
    }
}

