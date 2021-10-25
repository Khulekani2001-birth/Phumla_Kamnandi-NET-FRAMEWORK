
namespace Phumla_Kamnandi.Presentation
{
    partial class BookingListingForm
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
            this.queryBookingListView = new System.Windows.Forms.ListView();
            this.exitButton = new System.Windows.Forms.Button();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.roomNoTextBox = new System.Windows.Forms.TextBox();
            this.guestIDTextBox = new System.Windows.Forms.TextBox();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.guestIDLabel = new System.Windows.Forms.Label();
            this.roomNoLabel = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // queryBookingListView
            // 
            this.queryBookingListView.HideSelection = false;
            this.queryBookingListView.Location = new System.Drawing.Point(12, 87);
            this.queryBookingListView.Name = "queryBookingListView";
            this.queryBookingListView.Size = new System.Drawing.Size(776, 232);
            this.queryBookingListView.TabIndex = 0;
            this.queryBookingListView.UseCompatibleStateImageBehavior = false;
            this.queryBookingListView.SelectedIndexChanged += new System.EventHandler(this.queryBookingListView_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(688, 358);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 56);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(178, 325);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(100, 20);
            this.IDTextbox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(441, 368);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 3;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(441, 325);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 4;
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Location = new System.Drawing.Point(178, 416);
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomNoTextBox.TabIndex = 5;
            // 
            // guestIDTextBox
            // 
            this.guestIDTextBox.Location = new System.Drawing.Point(178, 370);
            this.guestIDTextBox.Name = "guestIDTextBox";
            this.guestIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.guestIDTextBox.TabIndex = 6;
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(441, 418);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(100, 20);
            this.depositTextBox.TabIndex = 7;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(62, 323);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(88, 20);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "Booking ID";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(354, 368);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Price";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(354, 325);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 20);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Date";
            // 
            // guestIDLabel
            // 
            this.guestIDLabel.AutoSize = true;
            this.guestIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestIDLabel.Location = new System.Drawing.Point(62, 368);
            this.guestIDLabel.Name = "guestIDLabel";
            this.guestIDLabel.Size = new System.Drawing.Size(74, 20);
            this.guestIDLabel.TabIndex = 11;
            this.guestIDLabel.Text = "Guest ID";
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNoLabel.Location = new System.Drawing.Point(40, 414);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(110, 20);
            this.roomNoLabel.TabIndex = 12;
            this.roomNoLabel.Text = "Room number";
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.Location = new System.Drawing.Point(321, 416);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(98, 20);
            this.depositLabel.TabIndex = 13;
            this.depositLabel.Text = "Deposit paid";
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(265, 9);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(255, 64);
            this.promptLabel.TabIndex = 15;
            this.promptLabel.Text = "Bookings";
            // 
            // BookingListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.roomNoLabel);
            this.Controls.Add(this.guestIDLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.guestIDTextBox);
            this.Controls.Add(this.roomNoTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.queryBookingListView);
            this.Name = "BookingListingForm";
            this.Text = "BookingListingForm";
            this.Activated += new System.EventHandler(this.BookingListingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookingListingForm_FormClosed);
            this.Load += new System.EventHandler(this.BookingListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView queryBookingListView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox IDTextbox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox roomNoTextBox;
        private System.Windows.Forms.TextBox guestIDTextBox;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label guestIDLabel;
        private System.Windows.Forms.Label roomNoLabel;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label promptLabel;
    }
}