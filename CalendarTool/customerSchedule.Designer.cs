
namespace CalendarTool
{
    partial class customerSchedule
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
            this.cbCustNum = new System.Windows.Forms.ComboBox();
            this.scheduleDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCustNum
            // 
            this.cbCustNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustNum.FormattingEnabled = true;
            this.cbCustNum.Location = new System.Drawing.Point(36, 191);
            this.cbCustNum.Name = "cbCustNum";
            this.cbCustNum.Size = new System.Drawing.Size(191, 37);
            this.cbCustNum.TabIndex = 0;
            this.cbCustNum.SelectedValueChanged += new System.EventHandler(this.cbCustNum_SelectedValueChanged);
            // 
            // scheduleDGV
            // 
            this.scheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDGV.Location = new System.Drawing.Point(253, 38);
            this.scheduleDGV.Name = "scheduleDGV";
            this.scheduleDGV.Size = new System.Drawing.Size(535, 357);
            this.scheduleDGV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Number";
            // 
            // customerSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduleDGV);
            this.Controls.Add(this.cbCustNum);
            this.Name = "customerSchedule";
            this.Text = "customerSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustNum;
        private System.Windows.Forms.DataGridView scheduleDGV;
        private System.Windows.Forms.Label label1;
    }
}