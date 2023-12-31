﻿using System.Drawing;
using System.Windows.Forms;

namespace CalendarTool
{
    partial class dashboard
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
            this.dashboardTitleLabel = new System.Windows.Forms.Label();
            this.appointmentsLabel = new System.Windows.Forms.Label();
            this.customersLabel = new System.Windows.Forms.Label();
            this.appointmentsDGV = new System.Windows.Forms.DataGridView();
            this.customersDGV = new System.Windows.Forms.DataGridView();
            this.deleteApptButton = new System.Windows.Forms.Button();
            this.updateApptButton = new System.Windows.Forms.Button();
            this.createApptButton = new System.Windows.Forms.Button();
            this.createCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.calendarView = new System.Windows.Forms.Button();
            this.typebyMonthButton = new System.Windows.Forms.Button();
            this.customerScheduleButton = new System.Windows.Forms.Button();
            this.userCreationsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardTitleLabel
            // 
            this.dashboardTitleLabel.AutoSize = true;
            this.dashboardTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.dashboardTitleLabel.Location = new System.Drawing.Point(270, 8);
            this.dashboardTitleLabel.Name = "dashboardTitleLabel";
            this.dashboardTitleLabel.Size = new System.Drawing.Size(348, 45);
            this.dashboardTitleLabel.TabIndex = 2;
            this.dashboardTitleLabel.Text = "Scheduling Dashboard";
            // 
            // appointmentsLabel
            // 
            this.appointmentsLabel.AutoSize = true;
            this.appointmentsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.appointmentsLabel.Location = new System.Drawing.Point(11, 2);
            this.appointmentsLabel.Name = "appointmentsLabel";
            this.appointmentsLabel.Size = new System.Drawing.Size(178, 32);
            this.appointmentsLabel.TabIndex = 3;
            this.appointmentsLabel.Text = "Appointments";
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.customersLabel.Location = new System.Drawing.Point(10, 9);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(136, 32);
            this.customersLabel.TabIndex = 4;
            this.customersLabel.Text = "Customers";
            // 
            // appointmentsDGV
            // 
            this.appointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDGV.Location = new System.Drawing.Point(41, 81);
            this.appointmentsDGV.Name = "appointmentsDGV";
            this.appointmentsDGV.RowTemplate.Height = 25;
            this.appointmentsDGV.Size = new System.Drawing.Size(758, 184);
            this.appointmentsDGV.TabIndex = 5;
            this.appointmentsDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // customersDGV
            // 
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDGV.Location = new System.Drawing.Point(10, 39);
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.RowTemplate.Height = 25;
            this.customersDGV.Size = new System.Drawing.Size(758, 184);
            this.customersDGV.TabIndex = 6;
            this.customersDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.customerBindingComplete);
            // 
            // deleteApptButton
            // 
            this.deleteApptButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.deleteApptButton.Location = new System.Drawing.Point(473, 219);
            this.deleteApptButton.Name = "deleteApptButton";
            this.deleteApptButton.Size = new System.Drawing.Size(88, 38);
            this.deleteApptButton.TabIndex = 12;
            this.deleteApptButton.Text = "Delete";
            this.deleteApptButton.UseVisualStyleBackColor = true;
            this.deleteApptButton.Click += new System.EventHandler(this.deleteApptButton_Click);
            // 
            // updateApptButton
            // 
            this.updateApptButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.updateApptButton.Location = new System.Drawing.Point(353, 219);
            this.updateApptButton.Name = "updateApptButton";
            this.updateApptButton.Size = new System.Drawing.Size(88, 38);
            this.updateApptButton.TabIndex = 11;
            this.updateApptButton.Text = "Update";
            this.updateApptButton.UseVisualStyleBackColor = true;
            this.updateApptButton.Click += new System.EventHandler(this.updateApptButton_Click);
            // 
            // createApptButton
            // 
            this.createApptButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.createApptButton.Location = new System.Drawing.Point(242, 219);
            this.createApptButton.Name = "createApptButton";
            this.createApptButton.Size = new System.Drawing.Size(88, 38);
            this.createApptButton.TabIndex = 10;
            this.createApptButton.Text = "Create";
            this.createApptButton.UseVisualStyleBackColor = true;
            this.createApptButton.Click += new System.EventHandler(this.createApptButton_Click);
            // 
            // createCustomerButton
            // 
            this.createCustomerButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.createCustomerButton.Location = new System.Drawing.Point(233, 228);
            this.createCustomerButton.Name = "createCustomerButton";
            this.createCustomerButton.Size = new System.Drawing.Size(88, 38);
            this.createCustomerButton.TabIndex = 10;
            this.createCustomerButton.Text = "Create";
            this.createCustomerButton.UseVisualStyleBackColor = true;
            this.createCustomerButton.Click += new System.EventHandler(this.createCustomerButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.updateCustomerButton.Location = new System.Drawing.Point(353, 228);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(88, 38);
            this.updateCustomerButton.TabIndex = 11;
            this.updateCustomerButton.Text = "Update";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.deleteCustomerButton.Location = new System.Drawing.Point(473, 228);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(88, 38);
            this.deleteCustomerButton.TabIndex = 12;
            this.deleteCustomerButton.Text = "Delete";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.deleteCustomerButton);
            this.panel1.Controls.Add(this.customersLabel);
            this.panel1.Controls.Add(this.customersDGV);
            this.panel1.Controls.Add(this.updateCustomerButton);
            this.panel1.Controls.Add(this.createCustomerButton);
            this.panel1.Location = new System.Drawing.Point(27, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 272);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.createApptButton);
            this.panel2.Controls.Add(this.appointmentsLabel);
            this.panel2.Controls.Add(this.updateApptButton);
            this.panel2.Controls.Add(this.deleteApptButton);
            this.panel2.Location = new System.Drawing.Point(30, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 262);
            this.panel2.TabIndex = 14;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(361, 123);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Week";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // calendarView
            // 
            this.calendarView.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.calendarView.Location = new System.Drawing.Point(27, 604);
            this.calendarView.Name = "calendarView";
            this.calendarView.Size = new System.Drawing.Size(169, 38);
            this.calendarView.TabIndex = 13;
            this.calendarView.Text = "CalendarView";
            this.calendarView.UseVisualStyleBackColor = true;
            this.calendarView.Click += new System.EventHandler(this.calendarView_Click);
            // 
            // typebyMonthButton
            // 
            this.typebyMonthButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.typebyMonthButton.Location = new System.Drawing.Point(202, 604);
            this.typebyMonthButton.Name = "typebyMonthButton";
            this.typebyMonthButton.Size = new System.Drawing.Size(217, 38);
            this.typebyMonthButton.TabIndex = 15;
            this.typebyMonthButton.Text = "Types by Month";
            this.typebyMonthButton.UseVisualStyleBackColor = true;
            this.typebyMonthButton.Click += new System.EventHandler(this.typebyMonthButton_Click);
            // 
            // customerScheduleButton
            // 
            this.customerScheduleButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.customerScheduleButton.Location = new System.Drawing.Point(425, 604);
            this.customerScheduleButton.Name = "customerScheduleButton";
            this.customerScheduleButton.Size = new System.Drawing.Size(215, 38);
            this.customerScheduleButton.TabIndex = 16;
            this.customerScheduleButton.Text = "Customer Schedule";
            this.customerScheduleButton.UseVisualStyleBackColor = true;
            this.customerScheduleButton.Click += new System.EventHandler(this.customerScheduleButton_Click);
            // 
            // userCreationsButton
            // 
            this.userCreationsButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.userCreationsButton.Location = new System.Drawing.Point(646, 604);
            this.userCreationsButton.Name = "userCreationsButton";
            this.userCreationsButton.Size = new System.Drawing.Size(161, 38);
            this.userCreationsButton.TabIndex = 17;
            this.userCreationsButton.Text = "User Creations";
            this.userCreationsButton.UseVisualStyleBackColor = true;
            this.userCreationsButton.Click += new System.EventHandler(this.userCreationsButton_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 648);
            this.Controls.Add(this.userCreationsButton);
            this.Controls.Add(this.customerScheduleButton);
            this.Controls.Add(this.typebyMonthButton);
            this.Controls.Add(this.calendarView);
            this.Controls.Add(this.appointmentsDGV);
            this.Controls.Add(this.dashboardTitleLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "dashboard";
            this.Text = "dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label dashboardTitleLabel;
        private Label appointmentsLabel;
        private Label customersLabel;
        private DataGridView appointmentsDGV;
        private DataGridView customersDGV;
        private Button deleteApptButton;
        private Button updateApptButton;
        private Button createApptButton;
        private Button createCustomerButton;
        private Button updateCustomerButton;
        private Button deleteCustomerButton;
        private Panel panel1;
        private Panel panel2;
        private Button calendarView;
        private Button typebyMonthButton;
        private Button customerScheduleButton;
        private RadioButton radioButton1;
        private Button userCreationsButton;
    }
}