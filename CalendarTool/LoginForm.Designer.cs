using System.Drawing;
using System.Windows.Forms;

namespace CalendarTool
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTitleLabel = new System.Windows.Forms.Label();
            this.timezoneLabel = new System.Windows.Forms.Label();
            this.actualTimeZoneLabel = new System.Windows.Forms.Label();
            this.loginExitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            // 
            // usernameTextbox
            // 
            resources.ApplyResources(this.usernameTextbox, "usernameTextbox");
            this.usernameTextbox.Name = "usernameTextbox";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // loginTitleLabel
            // 
            resources.ApplyResources(this.loginTitleLabel, "loginTitleLabel");
            this.loginTitleLabel.Name = "loginTitleLabel";
            // 
            // timezoneLabel
            // 
            resources.ApplyResources(this.timezoneLabel, "timezoneLabel");
            this.timezoneLabel.Name = "timezoneLabel";
            // 
            // actualTimeZoneLabel
            // 
            resources.ApplyResources(this.actualTimeZoneLabel, "actualTimeZoneLabel");
            this.actualTimeZoneLabel.Name = "actualTimeZoneLabel";
            // 
            // loginExitButton
            // 
            resources.ApplyResources(this.loginExitButton, "loginExitButton");
            this.loginExitButton.Name = "loginExitButton";
            this.loginExitButton.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            resources.ApplyResources(this.errorLabel, "errorLabel");
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Name = "errorLabel";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.loginExitButton);
            this.Controls.Add(this.actualTimeZoneLabel);
            this.Controls.Add(this.timezoneLabel);
            this.Controls.Add(this.loginTitleLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginButton;
        private TextBox passwordTextBox;
        private TextBox usernameTextbox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Label loginTitleLabel;
        private Label timezoneLabel;
        private Label actualTimeZoneLabel;
        private Button loginExitButton;
        private Label errorLabel;
    }
}