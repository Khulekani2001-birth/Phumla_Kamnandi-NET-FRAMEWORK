
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
            this.depositComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.promptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cancelBookingButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cancelBookingListView.Location = new System.Drawing.Point(41, 59);
            this.cancelBookingListView.Name = "cancelBookingListView";
            this.cancelBookingListView.Size = new System.Drawing.Size(729, 179);
            this.cancelBookingListView.TabIndex = 3;
            this.cancelBookingListView.UseCompatibleStateImageBehavior = false;
            this.cancelBookingListView.SelectedIndexChanged += new System.EventHandler(this.cancelBookingListView_SelectedIndexChanged_1);
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
            this.dateTextBox.Location = new System.Drawing.Point(426, 276);
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
            this.IDTextBox.Location = new System.Drawing.Point(167, 276);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Booking Details";
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.Location = new System.Drawing.Point(310, 376);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(98, 20);
            this.depositLabel.TabIndex = 11;
            this.depositLabel.Text = "Deposit paid";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(330, 323);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Price";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(330, 276);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 20);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Date";
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNoLabel.Location = new System.Drawing.Point(49, 378);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(112, 20);
            this.roomNoLabel.TabIndex = 14;
            this.roomNoLabel.Text = "Room Number";
            // 
            // guestIDLabel
            // 
            this.guestIDLabel.AutoSize = true;
            this.guestIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestIDLabel.Location = new System.Drawing.Point(61, 323);
            this.guestIDLabel.Name = "guestIDLabel";
            this.guestIDLabel.Size = new System.Drawing.Size(74, 20);
            this.guestIDLabel.TabIndex = 15;
            this.guestIDLabel.Text = "Guest ID";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(61, 276);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(88, 20);
            this.IDLabel.TabIndex = 16;
            this.IDLabel.Text = "Booking ID";
            // 
            // depositComboBox
            // 
            this.depositComboBox.FormattingEnabled = true;
            this.depositComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.depositComboBox.Location = new System.Drawing.Point(426, 378);
            this.depositComboBox.Name = "depositComboBox";
            this.depositComboBox.Size = new System.Drawing.Size(100, 21);
            this.depositComboBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Phumla_Kamnandi.Properties.Resources.Phumla_Kamnandi_Hotels;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Location = new System.Drawing.Point(8, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 51);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(231, 7);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(447, 46);
            this.promptLabel.TabIndex = 23;
            this.promptLabel.Text = "Select booking to cancel";
            // 
            // CancelBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.depositComboBox);
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
        private System.Windows.Forms.ComboBox depositComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label promptLabel;
    }
}