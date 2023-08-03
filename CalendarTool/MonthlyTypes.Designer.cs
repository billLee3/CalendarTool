
namespace CalendarTool
{
    partial class MonthlyTypes
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
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.monthSelectorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.presentationNum = new System.Windows.Forms.Label();
            this.scrumNum = new System.Windows.Forms.Label();
            this.standUpNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMonth
            // 
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(47, 136);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(168, 37);
            this.cbMonth.TabIndex = 0;
            this.cbMonth.SelectedValueChanged += new System.EventHandler(this.cbMonth_SelectedValueChanged);
            // 
            // monthSelectorLabel
            // 
            this.monthSelectorLabel.AutoSize = true;
            this.monthSelectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthSelectorLabel.Location = new System.Drawing.Point(42, 94);
            this.monthSelectorLabel.Name = "monthSelectorLabel";
            this.monthSelectorLabel.Size = new System.Drawing.Size(175, 29);
            this.monthSelectorLabel.TabIndex = 1;
            this.monthSelectorLabel.Text = "Month Selector";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Presentation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Scrum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stand-up:";
            // 
            // presentationNum
            // 
            this.presentationNum.AutoSize = true;
            this.presentationNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentationNum.Location = new System.Drawing.Point(496, 98);
            this.presentationNum.Name = "presentationNum";
            this.presentationNum.Size = new System.Drawing.Size(24, 25);
            this.presentationNum.TabIndex = 5;
            this.presentationNum.Text = "0";
            // 
            // scrumNum
            // 
            this.scrumNum.AutoSize = true;
            this.scrumNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrumNum.Location = new System.Drawing.Point(496, 169);
            this.scrumNum.Name = "scrumNum";
            this.scrumNum.Size = new System.Drawing.Size(24, 25);
            this.scrumNum.TabIndex = 6;
            this.scrumNum.Text = "0";
            // 
            // standUpNum
            // 
            this.standUpNum.AutoSize = true;
            this.standUpNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standUpNum.Location = new System.Drawing.Point(496, 229);
            this.standUpNum.Name = "standUpNum";
            this.standUpNum.Size = new System.Drawing.Size(24, 25);
            this.standUpNum.TabIndex = 7;
            this.standUpNum.Text = "0";
            // 
            // MonthlyTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.standUpNum);
            this.Controls.Add(this.scrumNum);
            this.Controls.Add(this.presentationNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthSelectorLabel);
            this.Controls.Add(this.cbMonth);
            this.Name = "MonthlyTypes";
            this.Text = "MonthlyTypes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label monthSelectorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label presentationNum;
        private System.Windows.Forms.Label scrumNum;
        private System.Windows.Forms.Label standUpNum;
    }
}