using System.Drawing;
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
            dashboardTitleLabel = new Label();
            appointmentsLabel = new Label();
            customersLabel = new Label();
            appointmentsDGV = new DataGridView();
            customersDGV = new DataGridView();
            deleteApptButton = new Button();
            updateApptButton = new Button();
            createApptButton = new Button();
            createCustomerButton = new Button();
            updateCustomerButton = new Button();
            deleteCustomerButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            report1 = new Button();
            report2 = new Button();
            report3 = new Button();
            ((System.ComponentModel.ISupportInitialize)appointmentsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customersDGV).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dashboardTitleLabel
            // 
            dashboardTitleLabel.AutoSize = true;
            dashboardTitleLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardTitleLabel.Location = new Point(315, 9);
            dashboardTitleLabel.Name = "dashboardTitleLabel";
            dashboardTitleLabel.Size = new Size(348, 45);
            dashboardTitleLabel.TabIndex = 2;
            dashboardTitleLabel.Text = "Scheduling Dashboard";
            dashboardTitleLabel.Click += newCustomerTitleLabel_Click;
            // 
            // appointmentsLabel
            // 
            appointmentsLabel.AutoSize = true;
            appointmentsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            appointmentsLabel.Location = new Point(13, 2);
            appointmentsLabel.Name = "appointmentsLabel";
            appointmentsLabel.Size = new Size(177, 32);
            appointmentsLabel.TabIndex = 3;
            appointmentsLabel.Text = "Appointments";
            // 
            // customersLabel
            // 
            customersLabel.AutoSize = true;
            customersLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            customersLabel.Location = new Point(12, 10);
            customersLabel.Name = "customersLabel";
            customersLabel.Size = new Size(135, 32);
            customersLabel.TabIndex = 4;
            customersLabel.Text = "Customers";
            // 
            // appointmentsDGV
            // 
            appointmentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsDGV.Location = new Point(48, 94);
            appointmentsDGV.Name = "appointmentsDGV";
            appointmentsDGV.RowTemplate.Height = 25;
            appointmentsDGV.Size = new Size(884, 212);
            appointmentsDGV.TabIndex = 5;
            // 
            // customersDGV
            // 
            customersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersDGV.Location = new Point(12, 45);
            customersDGV.Name = "customersDGV";
            customersDGV.RowTemplate.Height = 25;
            customersDGV.Size = new Size(884, 212);
            customersDGV.TabIndex = 6;
            // 
            // deleteApptButton
            // 
            deleteApptButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteApptButton.Location = new Point(552, 253);
            deleteApptButton.Name = "deleteApptButton";
            deleteApptButton.Size = new Size(103, 44);
            deleteApptButton.TabIndex = 12;
            deleteApptButton.Text = "Delete";
            deleteApptButton.UseVisualStyleBackColor = true;
            // 
            // updateApptButton
            // 
            updateApptButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateApptButton.Location = new Point(412, 253);
            updateApptButton.Name = "updateApptButton";
            updateApptButton.Size = new Size(103, 44);
            updateApptButton.TabIndex = 11;
            updateApptButton.Text = "Update";
            updateApptButton.UseVisualStyleBackColor = true;
            // 
            // createApptButton
            // 
            createApptButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createApptButton.Location = new Point(282, 253);
            createApptButton.Name = "createApptButton";
            createApptButton.Size = new Size(103, 44);
            createApptButton.TabIndex = 10;
            createApptButton.Text = "Create";
            createApptButton.UseVisualStyleBackColor = true;
            // 
            // createCustomerButton
            // 
            createCustomerButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createCustomerButton.Location = new Point(272, 263);
            createCustomerButton.Name = "createCustomerButton";
            createCustomerButton.Size = new Size(103, 44);
            createCustomerButton.TabIndex = 10;
            createCustomerButton.Text = "Create";
            createCustomerButton.UseVisualStyleBackColor = true;
            // 
            // updateCustomerButton
            // 
            updateCustomerButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateCustomerButton.Location = new Point(412, 263);
            updateCustomerButton.Name = "updateCustomerButton";
            updateCustomerButton.Size = new Size(103, 44);
            updateCustomerButton.TabIndex = 11;
            updateCustomerButton.Text = "Update";
            updateCustomerButton.UseVisualStyleBackColor = true;
            // 
            // deleteCustomerButton
            // 
            deleteCustomerButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCustomerButton.Location = new Point(552, 263);
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.Size = new Size(103, 44);
            deleteCustomerButton.TabIndex = 12;
            deleteCustomerButton.Text = "Delete";
            deleteCustomerButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Controls.Add(deleteCustomerButton);
            panel1.Controls.Add(customersLabel);
            panel1.Controls.Add(customersDGV);
            panel1.Controls.Add(updateCustomerButton);
            panel1.Controls.Add(createCustomerButton);
            panel1.Location = new Point(32, 376);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 314);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(createApptButton);
            panel2.Controls.Add(appointmentsLabel);
            panel2.Controls.Add(updateApptButton);
            panel2.Controls.Add(deleteApptButton);
            panel2.Location = new Point(35, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 302);
            panel2.TabIndex = 14;
            // 
            // report1
            // 
            report1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            report1.Location = new Point(149, 696);
            report1.Name = "report1";
            report1.Size = new Size(103, 44);
            report1.TabIndex = 13;
            report1.Text = "Report";
            report1.UseVisualStyleBackColor = true;
            // 
            // report2
            // 
            report2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            report2.Location = new Point(293, 696);
            report2.Name = "report2";
            report2.Size = new Size(103, 44);
            report2.TabIndex = 15;
            report2.Text = "Report";
            report2.UseVisualStyleBackColor = true;
            // 
            // report3
            // 
            report3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            report3.Location = new Point(444, 696);
            report3.Name = "report3";
            report3.Size = new Size(103, 44);
            report3.TabIndex = 16;
            report3.Text = "Report";
            report3.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 748);
            Controls.Add(report3);
            Controls.Add(report2);
            Controls.Add(report1);
            Controls.Add(appointmentsDGV);
            Controls.Add(dashboardTitleLabel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "dashboard";
            Text = "dashboard";
            ((System.ComponentModel.ISupportInitialize)appointmentsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)customersDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button report1;
        private Button report2;
        private Button report3;
    }
}