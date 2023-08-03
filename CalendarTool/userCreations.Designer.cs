
namespace CalendarTool
{
    partial class userCreation
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
            this.cbUserNum = new System.Windows.Forms.ComboBox();
            this.createdDGV = new System.Windows.Forms.DataGridView();
            this.userNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.createdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUserNum
            // 
            this.cbUserNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserNum.FormattingEnabled = true;
            this.cbUserNum.Location = new System.Drawing.Point(36, 191);
            this.cbUserNum.Name = "cbUserNum";
            this.cbUserNum.Size = new System.Drawing.Size(191, 37);
            this.cbUserNum.TabIndex = 0;
            this.cbUserNum.SelectedValueChanged += new System.EventHandler(this.cbCustNum_SelectedValueChanged);
            // 
            // createdDGV
            // 
            this.createdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createdDGV.Location = new System.Drawing.Point(253, 38);
            this.createdDGV.Name = "createdDGV";
            this.createdDGV.Size = new System.Drawing.Size(535, 357);
            this.createdDGV.TabIndex = 1;
            // 
            // userNumLabel
            // 
            this.userNumLabel.AutoSize = true;
            this.userNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNumLabel.Location = new System.Drawing.Point(33, 151);
            this.userNumLabel.Name = "userNumLabel";
            this.userNumLabel.Size = new System.Drawing.Size(157, 29);
            this.userNumLabel.TabIndex = 2;
            this.userNumLabel.Text = "User Number";
            // 
            // userCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userNumLabel);
            this.Controls.Add(this.createdDGV);
            this.Controls.Add(this.cbUserNum);
            this.Name = "userCreation";
            this.Text = "customerSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.createdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUserNum;
        private System.Windows.Forms.DataGridView createdDGV;
        private System.Windows.Forms.Label userNumLabel;
    }
}