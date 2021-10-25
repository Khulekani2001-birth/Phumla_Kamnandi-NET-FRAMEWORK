
namespace Phumla_Kamnandi.Presentation
{
    partial class ChangeBookingForm
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
            this.changeBookingListView = new System.Windows.Forms.ListView();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.roomNoTextBox = new System.Windows.Forms.TextBox();
            this.guestIDTextBox = new System.Windows.Forms.TextBox();
            this.changeBookingButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.changeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IDLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.roomNoLabel = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.guestIDLabel = new System.Windows.Forms.Label();
            this.despositComboBox = new System.Windows.Forms.ComboBox();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeBookingListView
            // 
            this.changeBookingListView.HideSelection = false;
            this.changeBookingListView.Location = new System.Drawing.Point(12, 12);
            this.changeBookingListView.Name = "changeBookingListView";
            this.changeBookingListView.Size = new System.Drawing.Size(776, 203);
            this.changeBookingListView.TabIndex = 0;
            this.changeBookingListView.UseCompatibleStateImageBehavior = false;
            this.changeBookingListView.SelectedIndexChanged += new System.EventHandler(this.changeBookingListView_SelectedIndexChanged_1);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(166, 247);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(467, 371);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 2;
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Location = new System.Drawing.Point(467, 247);
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomNoTextBox.TabIndex = 4;
            // 
            // guestIDTextBox
            // 
            this.guestIDTextBox.Location = new System.Drawing.Point(166, 307);
            this.guestIDTextBox.Name = "guestIDTextBox";
            this.guestIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.guestIDTextBox.TabIndex = 6;
            // 
            // changeBookingButton
            // 
            this.changeBookingButton.Location = new System.Drawing.Point(596, 392);
            this.changeBookingButton.Name = "changeBookingButton";
            this.changeBookingButton.Size = new System.Drawing.Size(175, 23);
            this.changeBookingButton.TabIndex = 7;
            this.changeBookingButton.Text = "Make changes to booking";
            this.changeBookingButton.UseVisualStyleBackColor = true;
            this.changeBookingButton.Click += new System.EventHandler(this.changeBookingButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(696, 345);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // changeDateTimePicker
            // 
            this.changeDateTimePicker.CustomFormat = "";
            this.changeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.changeDateTimePicker.Location = new System.Drawing.Point(467, 307);
            this.changeDateTimePicker.Name = "changeDateTimePicker";
            this.changeDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.changeDateTimePicker.TabIndex = 11;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(58, 250);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(60, 13);
            this.IDLabel.TabIndex = 12;
            this.IDLabel.Text = "Booking ID";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(363, 374);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "Price";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(363, 310);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 14;
            this.dateLabel.Text = "Date";
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Location = new System.Drawing.Point(363, 250);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(75, 13);
            this.roomNoLabel.TabIndex = 15;
            this.roomNoLabel.Text = "Room Number";
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Location = new System.Drawing.Point(58, 374);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(66, 13);
            this.depositLabel.TabIndex = 16;
            this.depositLabel.Text = "Deposit paid";
            // 
            // guestIDLabel
            // 
            this.guestIDLabel.AutoSize = true;
            this.guestIDLabel.Location = new System.Drawing.Point(58, 314);
            this.guestIDLabel.Name = "guestIDLabel";
            this.guestIDLabel.Size = new System.Drawing.Size(49, 13);
            this.guestIDLabel.TabIndex = 17;
            this.guestIDLabel.Text = "Guest ID";
            // 
            // despositComboBox
            // 
            this.despositComboBox.FormattingEnabled = true;
            this.despositComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.despositComboBox.Location = new System.Drawing.Point(166, 366);
            this.despositComboBox.Name = "despositComboBox";
            this.despositComboBox.Size = new System.Drawing.Size(100, 21);
            this.despositComboBox.TabIndex = 18;
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = global::Phumla_Kamnandi.Properties.Resources.draw_edit_pen_pencil_text_write_icon_1320162307919760358;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Location = new System.Drawing.Point(635, 239);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(40, 47);
            this.editButton.TabIndex = 19;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ChangeBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.despositComboBox);
            this.Controls.Add(this.guestIDLabel);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.roomNoLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.changeDateTimePicker);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.changeBookingButton);
            this.Controls.Add(this.guestIDTextBox);
            this.Controls.Add(this.roomNoTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.changeBookingListView);
            this.Name = "ChangeBookingForm";
            this.Text = "ChangeBookingForm";
            this.Load += new System.EventHandler(this.ChangeBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView changeBookingListView;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox roomNoTextBox;
        private System.Windows.Forms.TextBox guestIDTextBox;
        private System.Windows.Forms.Button changeBookingButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DateTimePicker changeDateTimePicker;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label roomNoLabel;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label guestIDLabel;
        private System.Windows.Forms.ComboBox despositComboBox;
        private System.Windows.Forms.Button editButton;
    }
}