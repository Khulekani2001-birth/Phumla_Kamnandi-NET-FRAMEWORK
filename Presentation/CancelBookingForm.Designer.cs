
namespace Phumla_Kamnandi.Presentation
{
    partial class CancelBookingForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.cancelBookingButton = new System.Windows.Forms.Button();
            this.cancelBookingListView = new System.Windows.Forms.ListView();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.roomNoTextBox = new System.Windows.Forms.TextBox();
            this.guestIDTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.roomNoLabel = new System.Windows.Forms.Label();
            this.guestIDLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(627, 397);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(143, 41);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cancelBookingButton
            // 
            this.cancelBookingButton.Location = new System.Drawing.Point(627, 330);
            this.cancelBookingButton.Name = "cancelBookingButton";
            this.cancelBookingButton.Size = new System.Drawing.Size(143, 38);
            this.cancelBookingButton.TabIndex = 1;
            this.cancelBookingButton.Text = "Cancel Booking";
            this.cancelBookingButton.UseVisualStyleBackColor = true;
            this.cancelBookingButton.Click += new System.EventHandler(this.cancelBookingButton_Click);
            // 
            // cancelBookingListView
            // 
            this.cancelBookingListView.HideSelection = false;
            this.cancelBookingListView.Location = new System.Drawing.Point(41, 12);
            this.cancelBookingListView.Name = "cancelBookingListView";
            this.cancelBookingListView.Size = new System.Drawing.Size(729, 179);
            this.cancelBookingListView.TabIndex = 3;
            this.cancelBookingListView.UseCompatibleStateImageBehavior = false;
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(426, 378);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(100, 20);
            this.depositTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(426, 323);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(426, 269);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 6;
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Location = new System.Drawing.Point(167, 378);
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomNoTextBox.TabIndex = 7;
            // 
            // guestIDTextBox
            // 
            this.guestIDTextBox.Location = new System.Drawing.Point(167, 323);
            this.guestIDTextBox.Name = "guestIDTextBox";
            this.guestIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.guestIDTextBox.TabIndex = 8;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(167, 269);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Booking Details";
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Location = new System.Drawing.Point(330, 381);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(66, 13);
            this.depositLabel.TabIndex = 11;
            this.depositLabel.Text = "Deposit paid";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(330, 330);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Price";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(330, 276);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Date";
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Location = new System.Drawing.Point(61, 381);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(75, 13);
            this.roomNoLabel.TabIndex = 14;
            this.roomNoLabel.Text = "Room Number";
            // 
            // guestIDLabel
            // 
            this.guestIDLabel.AutoSize = true;
            this.guestIDLabel.Location = new System.Drawing.Point(61, 330);
            this.guestIDLabel.Name = "guestIDLabel";
            this.guestIDLabel.Size = new System.Drawing.Size(49, 13);
            this.guestIDLabel.TabIndex = 15;
            this.guestIDLabel.Text = "Guest ID";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(61, 276);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(60, 13);
            this.IDLabel.TabIndex = 16;
            this.IDLabel.Text = "Booking ID";
            // 
            // CancelBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.guestIDLabel);
            this.Controls.Add(this.roomNoLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.guestIDTextBox);
            this.Controls.Add(this.roomNoTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.cancelBookingListView);
            this.Controls.Add(this.cancelBookingButton);
            this.Controls.Add(this.exitButton);
            this.Name = "CancelBookingForm";
            this.Text = "CancelBookingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button cancelBookingButton;
        private System.Windows.Forms.ListView cancelBookingListView;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox roomNoTextBox;
        private System.Windows.Forms.TextBox guestIDTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label roomNoLabel;
        private System.Windows.Forms.Label guestIDLabel;
        private System.Windows.Forms.Label IDLabel;
    }
}