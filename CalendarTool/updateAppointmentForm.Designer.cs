﻿using System.Drawing;
using System.Windows.Forms;

namespace CalendarTool
{
    partial class updateAppointmentForm
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
            this.updateApptTitleLabel = new System.Windows.Forms.Label();
            this.apptIDLabel = new System.Windows.Forms.Label();
            this.apptIDTextBox = new System.Windows.Forms.TextBox();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.customerNumLabel = new System.Windows.Forms.Label();
            this.apptTitleLabel = new System.Windows.Forms.Label();
            this.apptDescriptionLabel = new System.Windows.Forms.Label();
            this.apptTypeLabel = new System.Windows.Forms.Label();
            this.pocLabel = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.createApptButton = new System.Windows.Forms.Button();
            this.cancelNewApptButton = new System.Windows.Forms.Button();
            this.newApptErrorLabel = new System.Windows.Forms.Label();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.apptTitleTextBox = new System.Windows.Forms.TextBox();
            this.pocTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.custIDcomboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // updateApptTitleLabel
            // 
            this.updateApptTitleLabel.AutoSize = true;
            this.updateApptTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.updateApptTitleLabel.Location = new System.Drawing.Point(251, 8);
            this.updateApptTitleLabel.Name = "updateApptTitleLabel";
            this.updateApptTitleLabel.Size = new System.Drawing.Size(329, 45);
            this.updateApptTitleLabel.TabIndex = 0;
            this.updateApptTitleLabel.Text = "Update Appointment";
            // 
            // apptIDLabel
            // 
            this.apptIDLabel.AutoSize = true;
            this.apptIDLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.apptIDLabel.Location = new System.Drawing.Point(41, 81);
            this.apptIDLabel.Name = "apptIDLabel";
            this.apptIDLabel.Size = new System.Drawing.Size(96, 32);
            this.apptIDLabel.TabIndex = 1;
            this.apptIDLabel.Text = "Appt ID";
            // 
            // apptIDTextBox
            // 
            this.apptIDTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.apptIDTextBox.Location = new System.Drawing.Point(137, 81);
            this.apptIDTextBox.Name = "apptIDTextBox";
            this.apptIDTextBox.Size = new System.Drawing.Size(86, 35);
            this.apptIDTextBox.TabIndex = 2;
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.userIDLabel.Location = new System.Drawing.Point(267, 82);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(83, 32);
            this.userIDLabel.TabIndex = 3;
            this.userIDLabel.Text = "User #";
            // 
            // customerNumLabel
            // 
            this.customerNumLabel.AutoSize = true;
            this.customerNumLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.customerNumLabel.Location = new System.Drawing.Point(441, 85);
            this.customerNumLabel.Name = "customerNumLabel";
            this.customerNumLabel.Size = new System.Drawing.Size(139, 32);
            this.customerNumLabel.TabIndex = 4;
            this.customerNumLabel.Text = "Customer #";
            // 
            // apptTitleLabel
            // 
            this.apptTitleLabel.AutoSize = true;
            this.apptTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.apptTitleLabel.Location = new System.Drawing.Point(21, 140);
            this.apptTitleLabel.Name = "apptTitleLabel";
            this.apptTitleLabel.Size = new System.Drawing.Size(119, 32);
            this.apptTitleLabel.TabIndex = 5;
            this.apptTitleLabel.Text = "Appt Title";
            // 
            // apptDescriptionLabel
            // 
            this.apptDescriptionLabel.AutoSize = true;
            this.apptDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.apptDescriptionLabel.Location = new System.Drawing.Point(7, 198);
            this.apptDescriptionLabel.Name = "apptDescriptionLabel";
            this.apptDescriptionLabel.Size = new System.Drawing.Size(136, 32);
            this.apptDescriptionLabel.TabIndex = 6;
            this.apptDescriptionLabel.Text = "Description";
            // 
            // apptTypeLabel
            // 
            this.apptTypeLabel.AutoSize = true;
            this.apptTypeLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.apptTypeLabel.Location = new System.Drawing.Point(10, 274);
            this.apptTypeLabel.Name = "apptTypeLabel";
            this.apptTypeLabel.Size = new System.Drawing.Size(124, 32);
            this.apptTypeLabel.TabIndex = 7;
            this.apptTypeLabel.Text = "Appt Type";
            // 
            // pocLabel
            // 
            this.pocLabel.AutoSize = true;
            this.pocLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.pocLabel.Location = new System.Drawing.Point(537, 137);
            this.pocLabel.Name = "pocLabel";
            this.pocLabel.Size = new System.Drawing.Size(61, 32);
            this.pocLabel.TabIndex = 8;
            this.pocLabel.Text = "POC";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.urlLabel.Location = new System.Drawing.Point(10, 328);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(74, 32);
            this.urlLabel.TabIndex = 9;
            this.urlLabel.Text = "URL? ";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.startDateLabel.Location = new System.Drawing.Point(14, 381);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(120, 32);
            this.startDateLabel.TabIndex = 10;
            this.startDateLabel.Text = "Start Date";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.locationLabel.Location = new System.Drawing.Point(342, 274);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(105, 32);
            this.locationLabel.TabIndex = 11;
            this.locationLabel.Text = "Location";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.endDateLabel.Location = new System.Drawing.Point(14, 436);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(112, 32);
            this.endDateLabel.TabIndex = 13;
            this.endDateLabel.Text = "End Date";
            // 
            // createApptButton
            // 
            this.createApptButton.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.createApptButton.Location = new System.Drawing.Point(14, 539);
            this.createApptButton.Name = "createApptButton";
            this.createApptButton.Size = new System.Drawing.Size(115, 34);
            this.createApptButton.TabIndex = 15;
            this.createApptButton.Text = "Create";
            this.createApptButton.UseVisualStyleBackColor = true;
            this.createApptButton.Click += new System.EventHandler(this.createApptButton_Click);
            // 
            // cancelNewApptButton
            // 
            this.cancelNewApptButton.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.cancelNewApptButton.Location = new System.Drawing.Point(342, 539);
            this.cancelNewApptButton.Name = "cancelNewApptButton";
            this.cancelNewApptButton.Size = new System.Drawing.Size(115, 34);
            this.cancelNewApptButton.TabIndex = 16;
            this.cancelNewApptButton.Text = "Cancel";
            this.cancelNewApptButton.UseVisualStyleBackColor = true;
            this.cancelNewApptButton.Click += new System.EventHandler(this.cancelNewApptButton_Click);
            // 
            // newApptErrorLabel
            // 
            this.newApptErrorLabel.AutoSize = true;
            this.newApptErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.newApptErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newApptErrorLabel.Location = new System.Drawing.Point(199, 645);
            this.newApptErrorLabel.Name = "newApptErrorLabel";
            this.newApptErrorLabel.Size = new System.Drawing.Size(0, 25);
            this.newApptErrorLabel.TabIndex = 17;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.userIDTextBox.Location = new System.Drawing.Point(342, 82);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(86, 35);
            this.userIDTextBox.TabIndex = 18;
            // 
            // apptTitleTextBox
            // 
            this.apptTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.apptTitleTextBox.Location = new System.Drawing.Point(137, 140);
            this.apptTitleTextBox.Name = "apptTitleTextBox";
            this.apptTitleTextBox.Size = new System.Drawing.Size(291, 35);
            this.apptTitleTextBox.TabIndex = 20;
            // 
            // pocTextBox
            // 
            this.pocTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.pocTextBox.Location = new System.Drawing.Point(593, 137);
            this.pocTextBox.Name = "pocTextBox";
            this.pocTextBox.Size = new System.Drawing.Size(86, 35);
            this.pocTextBox.TabIndex = 21;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.descriptionTextBox.Location = new System.Drawing.Point(10, 228);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(669, 35);
            this.descriptionTextBox.TabIndex = 22;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(13, 493);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 32);
            this.errorLabel.TabIndex = 23;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.locationTextBox.Location = new System.Drawing.Point(436, 274);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(243, 35);
            this.locationTextBox.TabIndex = 25;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.urlTextBox.Location = new System.Drawing.Point(78, 325);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(601, 35);
            this.urlTextBox.TabIndex = 26;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(137, 443);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(213, 20);
            this.endDateTimePicker.TabIndex = 27;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.endDateTimePicker_ValueChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(137, 393);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(213, 20);
            this.startDateTimePicker.TabIndex = 28;
            // 
            // custIDcomboBox
            // 
            this.custIDcomboBox.FormattingEnabled = true;
            this.custIDcomboBox.Location = new System.Drawing.Point(585, 93);
            this.custIDcomboBox.Name = "custIDcomboBox";
            this.custIDcomboBox.Size = new System.Drawing.Size(121, 21);
            this.custIDcomboBox.TabIndex = 32;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(137, 285);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(199, 21);
            this.typeComboBox.TabIndex = 33;
            // 
            // updateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 584);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.custIDcomboBox);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.pocTextBox);
            this.Controls.Add(this.apptTitleTextBox);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.newApptErrorLabel);
            this.Controls.Add(this.cancelNewApptButton);
            this.Controls.Add(this.createApptButton);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.pocLabel);
            this.Controls.Add(this.apptTypeLabel);
            this.Controls.Add(this.apptDescriptionLabel);
            this.Controls.Add(this.apptTitleLabel);
            this.Controls.Add(this.customerNumLabel);
            this.Controls.Add(this.userIDLabel);
            this.Controls.Add(this.apptIDTextBox);
            this.Controls.Add(this.apptIDLabel);
            this.Controls.Add(this.updateApptTitleLabel);
            this.Name = "updateAppointmentForm";
            this.Text = "addAppointmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label updateApptTitleLabel;
        private Label apptIDLabel;
        private TextBox apptIDTextBox;
        private Label userIDLabel;
        private Label customerNumLabel;
        private Label apptTitleLabel;
        private Label apptDescriptionLabel;
        private Label apptTypeLabel;
        private Label pocLabel;
        private Label urlLabel;
        private Label startDateLabel;
        private Label locationLabel;
        private Label endDateLabel;
        private Button createApptButton;
        private Button cancelNewApptButton;
        private Label newApptErrorLabel;
        private TextBox userIDTextBox;
        private TextBox apptTitleTextBox;
        private TextBox pocTextBox;
        private TextBox descriptionTextBox;
        private Label errorLabel;
        private TextBox locationTextBox;
        private TextBox urlTextBox;
        private DateTimePicker endDateTimePicker;
        private DateTimePicker startDateTimePicker;
        private ComboBox custIDcomboBox;
        private ComboBox typeComboBox;
    }
}