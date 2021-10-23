
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
            this.SuspendLayout();
            // 
            // changeBookingButton
            // 
            this.changeBookingButton.Location = new System.Drawing.Point(65, 375);
            this.changeBookingButton.Name = "changeBookingButton";
            this.changeBookingButton.Size = new System.Drawing.Size(75, 23);
            this.changeBookingButton.TabIndex = 0;
            this.changeBookingButton.Text = "changeBookingButton";
            this.changeBookingButton.UseVisualStyleBackColor = true;
            this.changeBookingButton.Click += new System.EventHandler(this.changeBookingButton_Click);
            // 
            // cancelBookingButton
            // 
            this.cancelBookingButton.Location = new System.Drawing.Point(259, 375);
            this.cancelBookingButton.Name = "cancelBookingButton";
            this.cancelBookingButton.Size = new System.Drawing.Size(75, 23);
            this.cancelBookingButton.TabIndex = 1;
            this.cancelBookingButton.Text = "cancelBookingButton";
            this.cancelBookingButton.UseVisualStyleBackColor = true;
            this.cancelBookingButton.Click += new System.EventHandler(this.cancelBookingButton_Click);
            // 
            // listBookingsButton
            // 
            this.listBookingsButton.Location = new System.Drawing.Point(486, 375);
            this.listBookingsButton.Name = "listBookingsButton";
            this.listBookingsButton.Size = new System.Drawing.Size(75, 23);
            this.listBookingsButton.TabIndex = 2;
            this.listBookingsButton.Text = "listBookingsButton";
            this.listBookingsButton.UseVisualStyleBackColor = true;
            this.listBookingsButton.Click += new System.EventHandler(this.listBookingsButton_Click);
            // 
            // newBookingButton
            // 
            this.newBookingButton.Location = new System.Drawing.Point(647, 375);
            this.newBookingButton.Name = "newBookingButton";
            this.newBookingButton.Size = new System.Drawing.Size(75, 23);
            this.newBookingButton.TabIndex = 3;
            this.newBookingButton.Text = "newBookingButton";
            this.newBookingButton.UseVisualStyleBackColor = true;
            this.newBookingButton.Click += new System.EventHandler(this.newBookingButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newBookingButton);
            this.Controls.Add(this.listBookingsButton);
            this.Controls.Add(this.cancelBookingButton);
            this.Controls.Add(this.changeBookingButton);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeBookingButton;
        private System.Windows.Forms.Button cancelBookingButton;
        private System.Windows.Forms.Button listBookingsButton;
        private System.Windows.Forms.Button newBookingButton;
    }
}