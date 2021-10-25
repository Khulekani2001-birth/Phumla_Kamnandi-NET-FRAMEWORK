
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeBookingListView
            // 
            this.changeBookingListView.HideSelection = false;
            this.changeBookingListView.Location = new System.Drawing.Point(12, 82);
            this.changeBookingListView.Name = "changeBookingListView";
            this.changeBookingListView.Size = new System.Drawing.Size(776, 203);
            this.changeBookingListView.TabIndex = 0;
            this.changeBookingListView.UseCompatibleStateImageBehavior = false;
            this.changeBookingListView.SelectedIndexChanged += new System.EventHandler(this.changeBookingListView_SelectedIndexChanged_1);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(166, 291);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(467, 393);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 2;
            // 
            // roomNoTextBox
            // 
            this.roomNoTextBox.Location = new System.Drawing.Point(467, 291);
            this.roomNoTextBox.Name = "roomNoTextBox";
            this.roomNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomNoTextBox.TabIndex = 4;
            // 
            // guestIDTextBox
            // 
            this.guestIDTextBox.Location = new System.Drawing.Point(166, 345);
            this.guestIDTextBox.Name = "guestIDTextBox";
            this.guestIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.guestIDTextBox.TabIndex = 6;
            // 
            // changeBookingButton
            // 
            this.changeBookingButton.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBookingButton.Location = new System.Drawing.Point(613, 341);
            this.changeBookingButton.Name = "changeBookingButton";
            this.changeBookingButton.Size = new System.Drawing.Size(175, 43);
            this.changeBookingButton.TabIndex = 7;
            this.changeBookingButton.Text = "Make changes to booking";
            this.changeBookingButton.UseVisualStyleBackColor = true;
            this.changeBookingButton.Click += new System.EventHandler(this.changeBookingButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(699, 393);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 54);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // changeDateTimePicker
            // 
            this.changeDateTimePicker.CustomFormat = "";
            this.changeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.changeDateTimePicker.Location = new System.Drawing.Point(467, 341);
            this.changeDateTimePicker.Name = "changeDateTimePicker";
            this.changeDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.changeDateTimePicker.TabIndex = 11;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(58, 298);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(88, 20);
            this.IDLabel.TabIndex = 12;
            this.IDLabel.Text = "Booking ID";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(350, 393);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "Price";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(350, 343);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 20);
            this.dateLabel.TabIndex = 14;
            this.dateLabel.Text = "Date";
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNoLabel.Location = new System.Drawing.Point(349, 291);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(112, 20);
            this.roomNoLabel.TabIndex = 15;
            this.roomNoLabel.Text = "Room Number";
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.Location = new System.Drawing.Point(58, 401);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(98, 20);
            this.depositLabel.TabIndex = 16;
            this.depositLabel.Text = "Deposit paid";
            // 
            // guestIDLabel
            // 
            this.guestIDLabel.AutoSize = true;
            this.guestIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestIDLabel.Location = new System.Drawing.Point(58, 348);
            this.guestIDLabel.Name = "guestIDLabel";
            this.guestIDLabel.Size = new System.Drawing.Size(74, 20);
            this.guestIDLabel.TabIndex = 17;
            this.guestIDLabel.Text = "Guest ID";
            // 
            // despositComboBox
            // 
            this.despositComboBox.FormattingEnabled = true;
            this.despositComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.despositComboBox.Location = new System.Drawing.Point(166, 393);
            this.despositComboBox.Name = "despositComboBox";
            this.despositComboBox.Size = new System.Drawing.Size(100, 21);
            this.despositComboBox.TabIndex = 18;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(142, 9);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(658, 64);
            this.promptLabel.TabIndex = 20;
            this.promptLabel.Text = "Enter new booking details";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Phumla_Kamnandi.Properties.Resources.Phumla_Kamnandi_Hotels;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 67);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = global::Phumla_Kamnandi.Properties.Resources.draw_edit_pen_pencil_text_write_icon_1320162307919760358;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Location = new System.Drawing.Point(721, 291);
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
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.promptLabel);
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
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button button1;
    }
}