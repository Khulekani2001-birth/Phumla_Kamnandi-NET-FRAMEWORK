
namespace Phumla_Kamnandi.Presentation
{
    partial class CreateBookingForm
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
            this.enterButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.guestIDTextBox = new System.Windows.Forms.TextBox();
            this.pickDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.guestIDLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(599, 214);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(119, 23);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Make Booking";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(93, 75);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(60, 13);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "Booking ID";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(192, 68);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // guestIDTextBox
            // 
            this.guestIDTextBox.Location = new System.Drawing.Point(192, 125);
            this.guestIDTextBox.Name = "guestIDTextBox";
            this.guestIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.guestIDTextBox.TabIndex = 6;
            // 
            // pickDateTimePicker
            // 
            this.pickDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDateTimePicker.Location = new System.Drawing.Point(496, 65);
            this.pickDateTimePicker.Name = "pickDateTimePicker";
            this.pickDateTimePicker.Size = new System.Drawing.Size(128, 20);
            this.pickDateTimePicker.TabIndex = 7;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(410, 68);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(61, 13);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Pick a date";
            // 
            // guestIDLabel
            // 
            this.guestIDLabel.AutoSize = true;
            this.guestIDLabel.Location = new System.Drawing.Point(93, 132);
            this.guestIDLabel.Name = "guestIDLabel";
            this.guestIDLabel.Size = new System.Drawing.Size(49, 13);
            this.guestIDLabel.TabIndex = 10;
            this.guestIDLabel.Text = "Guest ID";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(599, 299);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CreateBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.guestIDLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.pickDateTimePicker);
            this.Controls.Add(this.guestIDTextBox);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.enterButton);
            this.Name = "CreateBookingForm";
            this.Text = "CreateBookingForm";
            this.Load += new System.EventHandler(this.CreateBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox guestIDTextBox;
        private System.Windows.Forms.DateTimePicker pickDateTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label guestIDLabel;
        private System.Windows.Forms.Button exitButton;
    }
}