using System.Drawing;
using System.Windows.Forms;

namespace CalendarTool

{
    partial class addCustomerForm
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
            newCustomerTitleLabel = new Label();
            customerNumLabel = new Label();
            errorLabel = new Label();
            customerNameLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            countryLabel = new Label();
            zipcodeLabel = new Label();
            phoneNumLabel = new Label();
            activeLabel = new Label();
            customerNumTextBox = new TextBox();
            cityTextBox = new TextBox();
            address2TextBox = new TextBox();
            address1TextBox = new TextBox();
            customerNameTextBox = new TextBox();
            countryTextBox = new TextBox();
            zipTextBox = new TextBox();
            phoneNumTextBox = new TextBox();
            activeTextbox = new TextBox();
            label2 = new Label();
            stateTextBox = new TextBox();
            createCustomerButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // newCustomerTitleLabel
            // 
            newCustomerTitleLabel.AutoSize = true;
            newCustomerTitleLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            newCustomerTitleLabel.Location = new Point(167, 20);
            newCustomerTitleLabel.Name = "newCustomerTitleLabel";
            newCustomerTitleLabel.Size = new Size(236, 45);
            newCustomerTitleLabel.TabIndex = 1;
            newCustomerTitleLabel.Text = "New Customer";
            // 
            // customerNumLabel
            // 
            customerNumLabel.AutoSize = true;
            customerNumLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customerNumLabel.Location = new Point(52, 85);
            customerNumLabel.Name = "customerNumLabel";
            customerNumLabel.Size = new Size(138, 32);
            customerNumLabel.TabIndex = 2;
            customerNumLabel.Text = "Customer #";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.FromArgb(192, 0, 0);
            errorLabel.Location = new Point(261, 547);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(64, 32);
            errorLabel.TabIndex = 3;
            errorLabel.Text = "Error";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customerNameLabel.Location = new Point(52, 134);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(78, 32);
            customerNameLabel.TabIndex = 4;
            customerNameLabel.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 183);
            label3.Name = "label3";
            label3.Size = new Size(169, 32);
            label3.TabIndex = 5;
            label3.Text = "Address Line 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 234);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
            label4.TabIndex = 6;
            label4.Text = "Address Line 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 281);
            label5.Name = "label5";
            label5.Size = new Size(55, 32);
            label5.TabIndex = 7;
            label5.Text = "City";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            countryLabel.Location = new Point(52, 330);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(99, 32);
            countryLabel.TabIndex = 8;
            countryLabel.Text = "Country";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            zipcodeLabel.Location = new Point(52, 414);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(100, 32);
            zipcodeLabel.TabIndex = 9;
            zipcodeLabel.Text = "Zipcode";
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumLabel.Location = new Point(52, 463);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(103, 32);
            phoneNumLabel.TabIndex = 10;
            phoneNumLabel.Text = "Phone #";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            activeLabel.Location = new Point(52, 512);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new Size(79, 32);
            activeLabel.TabIndex = 11;
            activeLabel.Text = "Active";
            // 
            // customerNumTextBox
            // 
            customerNumTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customerNumTextBox.Location = new Point(235, 82);
            customerNumTextBox.Name = "customerNumTextBox";
            customerNumTextBox.Size = new Size(298, 35);
            customerNumTextBox.TabIndex = 12;
            // 
            // cityTextBox
            // 
            cityTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cityTextBox.Location = new Point(235, 280);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(298, 35);
            cityTextBox.TabIndex = 13;
            // 
            // address2TextBox
            // 
            address2TextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            address2TextBox.Location = new Point(235, 231);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.Size = new Size(298, 35);
            address2TextBox.TabIndex = 14;
            // 
            // address1TextBox
            // 
            address1TextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            address1TextBox.Location = new Point(235, 183);
            address1TextBox.Name = "address1TextBox";
            address1TextBox.Size = new Size(298, 35);
            address1TextBox.TabIndex = 15;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customerNameTextBox.Location = new Point(235, 131);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(298, 35);
            customerNameTextBox.TabIndex = 16;
            // 
            // countryTextBox
            // 
            countryTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            countryTextBox.Location = new Point(235, 330);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(298, 35);
            countryTextBox.TabIndex = 17;
            // 
            // zipTextBox
            // 
            zipTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            zipTextBox.Location = new Point(235, 413);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(298, 35);
            zipTextBox.TabIndex = 18;
            // 
            // phoneNumTextBox
            // 
            phoneNumTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumTextBox.Location = new Point(235, 462);
            phoneNumTextBox.Name = "phoneNumTextBox";
            phoneNumTextBox.Size = new Size(298, 35);
            phoneNumTextBox.TabIndex = 19;
            // 
            // activeTextbox
            // 
            activeTextbox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            activeTextbox.Location = new Point(235, 509);
            activeTextbox.Name = "activeTextbox";
            activeTextbox.Size = new Size(298, 35);
            activeTextbox.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 372);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 22;
            label2.Text = "State/Province";
            // 
            // stateTextBox
            // 
            stateTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            stateTextBox.Location = new Point(235, 372);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(298, 35);
            stateTextBox.TabIndex = 23;
            // 
            // createCustomerButton
            // 
            createCustomerButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createCustomerButton.Location = new Point(144, 598);
            createCustomerButton.Name = "createCustomerButton";
            createCustomerButton.Size = new Size(99, 43);
            createCustomerButton.TabIndex = 24;
            createCustomerButton.Text = "Create";
            createCustomerButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(334, 598);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(99, 43);
            cancelButton.TabIndex = 25;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // addCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 646);
            Controls.Add(cancelButton);
            Controls.Add(createCustomerButton);
            Controls.Add(stateTextBox);
            Controls.Add(label2);
            Controls.Add(activeTextbox);
            Controls.Add(phoneNumTextBox);
            Controls.Add(zipTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(customerNameTextBox);
            Controls.Add(address1TextBox);
            Controls.Add(address2TextBox);
            Controls.Add(cityTextBox);
            Controls.Add(customerNumTextBox);
            Controls.Add(activeLabel);
            Controls.Add(phoneNumLabel);
            Controls.Add(zipcodeLabel);
            Controls.Add(countryLabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(customerNameLabel);
            Controls.Add(errorLabel);
            Controls.Add(customerNumLabel);
            Controls.Add(newCustomerTitleLabel);
            Name = "addCustomerForm";
            Text = "addCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newCustomerTitleLabel;
        private Label customerNumLabel;
        private Label errorLabel;
        private Label customerNameLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label countryLabel;
        private Label zipcodeLabel;
        private Label phoneNumLabel;
        private Label activeLabel;
        private TextBox customerNumTextBox;
        private TextBox cityTextBox;
        private TextBox address2TextBox;
        private TextBox address1TextBox;
        private TextBox customerNameTextBox;
        private TextBox countryTextBox;
        private TextBox zipTextBox;
        private TextBox phoneNumTextBox;
        private TextBox activeTextbox;
        private Label label2;
        private TextBox stateTextBox;
        private Button createCustomerButton;
        private Button cancelButton;
    }
}