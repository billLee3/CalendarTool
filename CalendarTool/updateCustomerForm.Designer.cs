using System.Drawing;
using System.Windows.Forms;

namespace CalendarTool
{
    partial class updateCustomerForm
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
            this.updateCustomerTitleLabel = new System.Windows.Forms.Label();
            this.customerNumLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.zipcodeLabel = new System.Windows.Forms.Label();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.customerNumTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumTextBox = new System.Windows.Forms.TextBox();
            this.activeTextbox = new System.Windows.Forms.TextBox();
            this.createCustomerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.activeDisclaimerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateCustomerTitleLabel
            // 
            this.updateCustomerTitleLabel.AutoSize = true;
            this.updateCustomerTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.updateCustomerTitleLabel.Location = new System.Drawing.Point(143, 17);
            this.updateCustomerTitleLabel.Name = "updateCustomerTitleLabel";
            this.updateCustomerTitleLabel.Size = new System.Drawing.Size(277, 45);
            this.updateCustomerTitleLabel.TabIndex = 1;
            this.updateCustomerTitleLabel.Text = "Update Customer";
            // 
            // customerNumLabel
            // 
            this.customerNumLabel.AutoSize = true;
            this.customerNumLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.customerNumLabel.Location = new System.Drawing.Point(45, 74);
            this.customerNumLabel.Name = "customerNumLabel";
            this.customerNumLabel.Size = new System.Drawing.Size(139, 32);
            this.customerNumLabel.TabIndex = 2;
            this.customerNumLabel.Text = "Customer #";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(224, 474);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(65, 32);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "Error";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.customerNameLabel.Location = new System.Drawing.Point(45, 116);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(79, 32);
            this.customerNameLabel.TabIndex = 4;
            this.customerNameLabel.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label3.Location = new System.Drawing.Point(45, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address Line 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label4.Location = new System.Drawing.Point(45, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address Line 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label5.Location = new System.Drawing.Point(45, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "City";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.countryLabel.Location = new System.Drawing.Point(45, 286);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(100, 32);
            this.countryLabel.TabIndex = 8;
            this.countryLabel.Text = "Country";
            // 
            // zipcodeLabel
            // 
            this.zipcodeLabel.AutoSize = true;
            this.zipcodeLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.zipcodeLabel.Location = new System.Drawing.Point(45, 329);
            this.zipcodeLabel.Name = "zipcodeLabel";
            this.zipcodeLabel.Size = new System.Drawing.Size(101, 32);
            this.zipcodeLabel.TabIndex = 9;
            this.zipcodeLabel.Text = "Zipcode";
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.phoneNumLabel.Location = new System.Drawing.Point(45, 371);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(104, 32);
            this.phoneNumLabel.TabIndex = 10;
            this.phoneNumLabel.Text = "Phone #";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.activeLabel.Location = new System.Drawing.Point(45, 444);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(80, 32);
            this.activeLabel.TabIndex = 11;
            this.activeLabel.Text = "Active";
            // 
            // customerNumTextBox
            // 
            this.customerNumTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.customerNumTextBox.Location = new System.Drawing.Point(287, 71);
            this.customerNumTextBox.Name = "customerNumTextBox";
            this.customerNumTextBox.Size = new System.Drawing.Size(256, 35);
            this.customerNumTextBox.TabIndex = 12;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.cityTextBox.Location = new System.Drawing.Point(287, 243);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(256, 35);
            this.cityTextBox.TabIndex = 13;
            // 
            // address2TextBox
            // 
            this.address2TextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.address2TextBox.Location = new System.Drawing.Point(287, 200);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(256, 35);
            this.address2TextBox.TabIndex = 14;
            // 
            // address1TextBox
            // 
            this.address1TextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.address1TextBox.Location = new System.Drawing.Point(287, 159);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(256, 35);
            this.address1TextBox.TabIndex = 15;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.customerNameTextBox.Location = new System.Drawing.Point(287, 114);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(256, 35);
            this.customerNameTextBox.TabIndex = 16;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.countryTextBox.Location = new System.Drawing.Point(287, 286);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(256, 35);
            this.countryTextBox.TabIndex = 17;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.zipTextBox.Location = new System.Drawing.Point(287, 328);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(256, 35);
            this.zipTextBox.TabIndex = 18;
            // 
            // phoneNumTextBox
            // 
            this.phoneNumTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.phoneNumTextBox.Location = new System.Drawing.Point(287, 370);
            this.phoneNumTextBox.Name = "phoneNumTextBox";
            this.phoneNumTextBox.Size = new System.Drawing.Size(256, 35);
            this.phoneNumTextBox.TabIndex = 19;
            // 
            // activeTextbox
            // 
            this.activeTextbox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.activeTextbox.Location = new System.Drawing.Point(287, 441);
            this.activeTextbox.Name = "activeTextbox";
            this.activeTextbox.Size = new System.Drawing.Size(256, 35);
            this.activeTextbox.TabIndex = 20;
            // 
            // createCustomerButton
            // 
            this.createCustomerButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.createCustomerButton.Location = new System.Drawing.Point(123, 518);
            this.createCustomerButton.Name = "createCustomerButton";
            this.createCustomerButton.Size = new System.Drawing.Size(85, 37);
            this.createCustomerButton.TabIndex = 24;
            this.createCustomerButton.Text = "Create";
            this.createCustomerButton.UseVisualStyleBackColor = true;
            this.createCustomerButton.Click += new System.EventHandler(this.createCustomerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.cancelButton.Location = new System.Drawing.Point(286, 518);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 37);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // activeDisclaimerLabel
            // 
            this.activeDisclaimerLabel.AutoSize = true;
            this.activeDisclaimerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDisclaimerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.activeDisclaimerLabel.Location = new System.Drawing.Point(45, 412);
            this.activeDisclaimerLabel.Name = "activeDisclaimerLabel";
            this.activeDisclaimerLabel.Size = new System.Drawing.Size(501, 25);
            this.activeDisclaimerLabel.TabIndex = 26;
            this.activeDisclaimerLabel.Text = "If a customer is active use 1. If a customer is inactive use 0.";
            // 
            // updateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 560);
            this.Controls.Add(this.activeDisclaimerLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createCustomerButton);
            this.Controls.Add(this.activeTextbox);
            this.Controls.Add(this.phoneNumTextBox);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.customerNumTextBox);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.phoneNumLabel);
            this.Controls.Add(this.zipcodeLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.customerNumLabel);
            this.Controls.Add(this.updateCustomerTitleLabel);
            this.Name = "updateCustomerForm";
            this.Text = "addCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label updateCustomerTitleLabel;
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
        private Button createCustomerButton;
        private Button cancelButton;
        private Label activeDisclaimerLabel;
    }
}