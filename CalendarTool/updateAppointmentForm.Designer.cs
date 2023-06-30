using System.Drawing;
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
            updateApptTitleLabel = new Label();
            apptIDLabel = new Label();
            apptIDTextBox = new TextBox();
            userIDLabel = new Label();
            customerNumLabel = new Label();
            apptTitleLabel = new Label();
            apptDescriptionLabel = new Label();
            apptTypeLabel = new Label();
            pocLabel = new Label();
            urlLabel = new Label();
            startDateLabel = new Label();
            locationLabel = new Label();
            startTimeLabel = new Label();
            endDateLabel = new Label();
            endTimeLabel = new Label();
            createApptButton = new Button();
            cancelNewApptButton = new Button();
            newApptErrorLabel = new Label();
            userIDTextBox = new TextBox();
            customerIDTextBox = new TextBox();
            apptTitleTextBox = new TextBox();
            pocTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            errorLabel = new Label();
            apptTypeTextBox = new TextBox();
            locationTextBox = new TextBox();
            urlTextBox = new TextBox();
            endDateTimePicker = new DateTimePicker();
            startDateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // updateApptTitleLabel
            // 
            updateApptTitleLabel.AutoSize = true;
            updateApptTitleLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            updateApptTitleLabel.Location = new Point(293, 9);
            updateApptTitleLabel.Name = "updateApptTitleLabel";
            updateApptTitleLabel.Size = new Size(329, 45);
            updateApptTitleLabel.TabIndex = 0;
            updateApptTitleLabel.Text = "Update Appointment";
            // 
            // apptIDLabel
            // 
            apptIDLabel.AutoSize = true;
            apptIDLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            apptIDLabel.Location = new Point(48, 94);
            apptIDLabel.Name = "apptIDLabel";
            apptIDLabel.Size = new Size(95, 32);
            apptIDLabel.TabIndex = 1;
            apptIDLabel.Text = "Appt ID";
            // 
            // apptIDTextBox
            // 
            apptIDTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            apptIDTextBox.Location = new Point(160, 94);
            apptIDTextBox.Name = "apptIDTextBox";
            apptIDTextBox.Size = new Size(100, 35);
            apptIDTextBox.TabIndex = 2;
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userIDLabel.Location = new Point(311, 95);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new Size(82, 32);
            userIDLabel.TabIndex = 3;
            userIDLabel.Text = "User #";
            // 
            // customerNumLabel
            // 
            customerNumLabel.AutoSize = true;
            customerNumLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customerNumLabel.Location = new Point(548, 98);
            customerNumLabel.Name = "customerNumLabel";
            customerNumLabel.Size = new Size(138, 32);
            customerNumLabel.TabIndex = 4;
            customerNumLabel.Text = "Customer #";
            // 
            // apptTitleLabel
            // 
            apptTitleLabel.AutoSize = true;
            apptTitleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            apptTitleLabel.Location = new Point(25, 162);
            apptTitleLabel.Name = "apptTitleLabel";
            apptTitleLabel.Size = new Size(118, 32);
            apptTitleLabel.TabIndex = 5;
            apptTitleLabel.Text = "Appt Title";
            // 
            // apptDescriptionLabel
            // 
            apptDescriptionLabel.AutoSize = true;
            apptDescriptionLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            apptDescriptionLabel.Location = new Point(8, 228);
            apptDescriptionLabel.Name = "apptDescriptionLabel";
            apptDescriptionLabel.Size = new Size(135, 32);
            apptDescriptionLabel.TabIndex = 6;
            apptDescriptionLabel.Text = "Description";
            // 
            // apptTypeLabel
            // 
            apptTypeLabel.AutoSize = true;
            apptTypeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            apptTypeLabel.Location = new Point(12, 316);
            apptTypeLabel.Name = "apptTypeLabel";
            apptTypeLabel.Size = new Size(123, 32);
            apptTypeLabel.TabIndex = 7;
            apptTypeLabel.Text = "Appt Type";
            // 
            // pocLabel
            // 
            pocLabel.AutoSize = true;
            pocLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pocLabel.Location = new Point(626, 158);
            pocLabel.Name = "pocLabel";
            pocLabel.Size = new Size(60, 32);
            pocLabel.TabIndex = 8;
            pocLabel.Text = "POC";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            urlLabel.Location = new Point(12, 378);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(73, 32);
            urlLabel.TabIndex = 9;
            urlLabel.Text = "URL? ";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            startDateLabel.Location = new Point(16, 440);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(119, 32);
            startDateLabel.TabIndex = 10;
            startDateLabel.Text = "Start Date";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            locationLabel.Location = new Point(399, 316);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(104, 32);
            locationLabel.TabIndex = 11;
            locationLabel.Text = "Location";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            startTimeLabel.Location = new Point(399, 440);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(122, 32);
            startTimeLabel.TabIndex = 12;
            startTimeLabel.Text = "Start Time";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            endDateLabel.Location = new Point(16, 503);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(111, 32);
            endDateLabel.TabIndex = 13;
            endDateLabel.Text = "End Date";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            endTimeLabel.Location = new Point(407, 503);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(114, 32);
            endTimeLabel.TabIndex = 14;
            endTimeLabel.Text = "End Time";
            // 
            // createApptButton
            // 
            createApptButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            createApptButton.Location = new Point(16, 622);
            createApptButton.Name = "createApptButton";
            createApptButton.Size = new Size(134, 39);
            createApptButton.TabIndex = 15;
            createApptButton.Text = "Create";
            createApptButton.UseVisualStyleBackColor = true;
            // 
            // cancelNewApptButton
            // 
            cancelNewApptButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelNewApptButton.Location = new Point(399, 622);
            cancelNewApptButton.Name = "cancelNewApptButton";
            cancelNewApptButton.Size = new Size(134, 39);
            cancelNewApptButton.TabIndex = 16;
            cancelNewApptButton.Text = "Cancel";
            cancelNewApptButton.UseVisualStyleBackColor = true;
            // 
            // newApptErrorLabel
            // 
            newApptErrorLabel.AutoSize = true;
            newApptErrorLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            newApptErrorLabel.ForeColor = Color.FromArgb(192, 0, 0);
            newApptErrorLabel.Location = new Point(232, 744);
            newApptErrorLabel.Name = "newApptErrorLabel";
            newApptErrorLabel.Size = new Size(0, 25);
            newApptErrorLabel.TabIndex = 17;
            // 
            // userIDTextBox
            // 
            userIDTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            userIDTextBox.Location = new Point(399, 95);
            userIDTextBox.Name = "userIDTextBox";
            userIDTextBox.Size = new Size(100, 35);
            userIDTextBox.TabIndex = 18;
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customerIDTextBox.Location = new Point(692, 98);
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.Size = new Size(100, 35);
            customerIDTextBox.TabIndex = 19;
            // 
            // apptTitleTextBox
            // 
            apptTitleTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            apptTitleTextBox.Location = new Point(160, 161);
            apptTitleTextBox.Name = "apptTitleTextBox";
            apptTitleTextBox.Size = new Size(339, 35);
            apptTitleTextBox.TabIndex = 20;
            // 
            // pocTextBox
            // 
            pocTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            pocTextBox.Location = new Point(692, 158);
            pocTextBox.Name = "pocTextBox";
            pocTextBox.Size = new Size(100, 35);
            pocTextBox.TabIndex = 21;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTextBox.Location = new Point(12, 263);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(780, 35);
            descriptionTextBox.TabIndex = 22;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.FromArgb(192, 0, 0);
            errorLabel.Location = new Point(15, 569);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(64, 32);
            errorLabel.TabIndex = 23;
            errorLabel.Text = "Error";
            // 
            // apptTypeTextBox
            // 
            apptTypeTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            apptTypeTextBox.Location = new Point(160, 316);
            apptTypeTextBox.Name = "apptTypeTextBox";
            apptTypeTextBox.Size = new Size(233, 35);
            apptTypeTextBox.TabIndex = 24;
            // 
            // locationTextBox
            // 
            locationTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            locationTextBox.Location = new Point(509, 316);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(283, 35);
            locationTextBox.TabIndex = 25;
            // 
            // urlTextBox
            // 
            urlTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            urlTextBox.Location = new Point(91, 375);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.Size = new Size(701, 35);
            urlTextBox.TabIndex = 26;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(160, 511);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(200, 23);
            endDateTimePicker.TabIndex = 27;
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(160, 449);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(200, 23);
            startDateTimePicker.TabIndex = 28;
            // 
            // updateAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 674);
            Controls.Add(startDateTimePicker);
            Controls.Add(endDateTimePicker);
            Controls.Add(urlTextBox);
            Controls.Add(locationTextBox);
            Controls.Add(apptTypeTextBox);
            Controls.Add(errorLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(pocTextBox);
            Controls.Add(apptTitleTextBox);
            Controls.Add(customerIDTextBox);
            Controls.Add(userIDTextBox);
            Controls.Add(newApptErrorLabel);
            Controls.Add(cancelNewApptButton);
            Controls.Add(createApptButton);
            Controls.Add(endTimeLabel);
            Controls.Add(endDateLabel);
            Controls.Add(startTimeLabel);
            Controls.Add(locationLabel);
            Controls.Add(startDateLabel);
            Controls.Add(urlLabel);
            Controls.Add(pocLabel);
            Controls.Add(apptTypeLabel);
            Controls.Add(apptDescriptionLabel);
            Controls.Add(apptTitleLabel);
            Controls.Add(customerNumLabel);
            Controls.Add(userIDLabel);
            Controls.Add(apptIDTextBox);
            Controls.Add(apptIDLabel);
            Controls.Add(updateApptTitleLabel);
            Name = "updateAppointmentForm";
            Text = "addAppointmentForm";
            ResumeLayout(false);
            PerformLayout();
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
        private Label startTimeLabel;
        private Label endDateLabel;
        private Label endTimeLabel;
        private Button createApptButton;
        private Button cancelNewApptButton;
        private Label newApptErrorLabel;
        private TextBox userIDTextBox;
        private TextBox customerIDTextBox;
        private TextBox apptTitleTextBox;
        private TextBox pocTextBox;
        private TextBox descriptionTextBox;
        private Label errorLabel;
        private TextBox apptTypeTextBox;
        private TextBox locationTextBox;
        private TextBox urlTextBox;
        private DateTimePicker endDateTimePicker;
        private DateTimePicker startDateTimePicker;
    }
}