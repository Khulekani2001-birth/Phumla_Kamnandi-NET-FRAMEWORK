
namespace Phumla_Kamnandi.Presentation
{
    partial class MainForm
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
            this.changeBookingButton = new System.Windows.Forms.Button();
            this.cancelBookingButton = new System.Windows.Forms.Button();
            this.listBookingsButton = new System.Windows.Forms.Button();
            this.newBookingButton = new System.Windows.Forms.Button();
            this.newGuestButton = new System.Windows.Forms.Button();
            this.AvalabilityListView = new System.Windows.Forms.ListView();
            this.checkAvailabilityLabel = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.availabledateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.avLabel = new System.Windows.Forms.Label();
            this.OccupancyButton = new System.Windows.Forms.Button();
            this.monthlyButtons = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeBookingButton
            // 
            this.changeBookingButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBookingButton.Location = new System.Drawing.Point(29, 375);
            this.changeBookingButton.Name = "changeBookingButton";
            this.changeBookingButton.Size = new System.Drawing.Size(111, 33);
            this.changeBookingButton.TabIndex = 0;
            this.changeBookingButton.Text = "Change Booking";
            this.changeBookingButton.UseVisualStyleBackColor = true;
            this.changeBookingButton.Click += new System.EventHandler(this.changeBookingButton_Click);
            // 
            // cancelBookingButton
            // 
            this.cancelBookingButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBookingButton.Location = new System.Drawing.Point(197, 375);
            this.cancelBookingButton.Name = "cancelBookingButton";
            this.cancelBookingButton.Size = new System.Drawing.Size(103, 33);
            this.cancelBookingButton.TabIndex = 1;
            this.cancelBookingButton.Text = "Cancel Booking";
            this.cancelBookingButton.UseVisualStyleBackColor = true;
            this.cancelBookingButton.Click += new System.EventHandler(this.cancelBookingButton_Click);
            // 
            // listBookingsButton
            // 
            this.listBookingsButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBookingsButton.Location = new System.Drawing.Point(361, 374);
            this.listBookingsButton.Name = "listBookingsButton";
            this.listBookingsButton.Size = new System.Drawing.Size(98, 33);
            this.listBookingsButton.TabIndex = 2;
            this.listBookingsButton.Text = "list Bookings";
            this.listBookingsButton.UseVisualStyleBackColor = true;
            this.listBookingsButton.Click += new System.EventHandler(this.listBookingsButton_Click);
            // 
            // newBookingButton
            // 
            this.newBookingButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBookingButton.Location = new System.Drawing.Point(528, 375);
            this.newBookingButton.Name = "newBookingButton";
            this.newBookingButton.Size = new System.Drawing.Size(90, 33);
            this.newBookingButton.TabIndex = 3;
            this.newBookingButton.Text = "New Booking";
            this.newBookingButton.UseVisualStyleBackColor = true;
            this.newBookingButton.Click += new System.EventHandler(this.newBookingButton_Click);
            // 
            // newGuestButton
            // 
            this.newGuestButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGuestButton.Location = new System.Drawing.Point(680, 375);
            this.newGuestButton.Name = "newGuestButton";
            this.newGuestButton.Size = new System.Drawing.Size(90, 32);
            this.newGuestButton.TabIndex = 4;
            this.newGuestButton.Text = "New Guest";
            this.newGuestButton.UseVisualStyleBackColor = true;
            this.newGuestButton.Click += new System.EventHandler(this.newGuestButton_Click);
            // 
            // AvalabilityListView
            // 
            this.AvalabilityListView.GridLines = true;
            this.AvalabilityListView.HideSelection = false;
            this.AvalabilityListView.Location = new System.Drawing.Point(240, 49);
            this.AvalabilityListView.Name = "AvalabilityListView";
            this.AvalabilityListView.Size = new System.Drawing.Size(530, 189);
            this.AvalabilityListView.TabIndex = 23;
            this.AvalabilityListView.UseCompatibleStateImageBehavior = false;
            // 
            // checkAvailabilityLabel
            // 
            this.checkAvailabilityLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAvailabilityLabel.Location = new System.Drawing.Point(29, 217);
            this.checkAvailabilityLabel.Name = "checkAvailabilityLabel";
            this.checkAvailabilityLabel.Size = new System.Drawing.Size(154, 27);
            this.checkAvailabilityLabel.TabIndex = 24;
            this.checkAvailabilityLabel.Text = "Check Availability";
            this.checkAvailabilityLabel.UseVisualStyleBackColor = true;
            this.checkAvailabilityLabel.Click += new System.EventHandler(this.checkAvailabilityLabel_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(25, 130);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(119, 23);
            this.dateLabel.TabIndex = 25;
            this.dateLabel.Text = "Check_in Date";
            // 
            // availabledateTimePicker
            // 
            this.availabledateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.availabledateTimePicker.Location = new System.Drawing.Point(29, 172);
            this.availabledateTimePicker.Name = "availabledateTimePicker";
            this.availabledateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.availabledateTimePicker.TabIndex = 26;
            // 
            // avLabel
            // 
            this.avLabel.AutoSize = true;
            this.avLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avLabel.Location = new System.Drawing.Point(236, 27);
            this.avLabel.Name = "avLabel";
            this.avLabel.Size = new System.Drawing.Size(86, 19);
            this.avLabel.TabIndex = 28;
            this.avLabel.Text = "Report Info:";
            // 
            // OccupancyButton
            // 
            this.OccupancyButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OccupancyButton.Location = new System.Drawing.Point(361, 244);
            this.OccupancyButton.Name = "OccupancyButton";
            this.OccupancyButton.Size = new System.Drawing.Size(154, 32);
            this.OccupancyButton.TabIndex = 29;
            this.OccupancyButton.Text = "Occupancy report";
            this.OccupancyButton.UseVisualStyleBackColor = true;
            this.OccupancyButton.Click += new System.EventHandler(this.OccupancyButton_Click);
            // 
            // monthlyButtons
            // 
            this.monthlyButtons.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyButtons.Location = new System.Drawing.Point(595, 244);
            this.monthlyButtons.Name = "monthlyButtons";
            this.monthlyButtons.Size = new System.Drawing.Size(154, 32);
            this.monthlyButtons.TabIndex = 30;
            this.monthlyButtons.Text = "Monthly report";
            this.monthlyButtons.UseVisualStyleBackColor = true;
            this.monthlyButtons.Click += new System.EventHandler(this.monthlyButtons_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackgroundImage = global::Phumla_Kamnandi.Properties.Resources.images;
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearButton.Location = new System.Drawing.Point(240, 244);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(37, 40);
            this.ClearButton.TabIndex = 27;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Phumla_Kamnandi.Properties.Resources.Phumla_Kamnandi_Hotels;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Location = new System.Drawing.Point(6, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 67);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthlyButtons);
            this.Controls.Add(this.OccupancyButton);
            this.Controls.Add(this.avLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.availabledateTimePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.checkAvailabilityLabel);
            this.Controls.Add(this.AvalabilityListView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newGuestButton);
            this.Controls.Add(this.newBookingButton);
            this.Controls.Add(this.listBookingsButton);
            this.Controls.Add(this.cancelBookingButton);
            this.Controls.Add(this.changeBookingButton);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeBookingButton;
        private System.Windows.Forms.Button cancelBookingButton;
        private System.Windows.Forms.Button listBookingsButton;
        private System.Windows.Forms.Button newBookingButton;
        private System.Windows.Forms.Button newGuestButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView AvalabilityListView;
        private System.Windows.Forms.Button checkAvailabilityLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker availabledateTimePicker;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label avLabel;
        private System.Windows.Forms.Button OccupancyButton;
        private System.Windows.Forms.Button monthlyButtons;
    }
}