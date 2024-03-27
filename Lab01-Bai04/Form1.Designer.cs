namespace MovieTicketBookingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbMovies = new System.Windows.Forms.ComboBox();
            this.checkedListBoxSeats = new System.Windows.Forms.CheckedListBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbMovies
            // 
            this.cmbMovies.FormattingEnabled = true;
            this.cmbMovies.Location = new System.Drawing.Point(37, 34);
            this.cmbMovies.Name = "cmbMovies";
            this.cmbMovies.Size = new System.Drawing.Size(266, 21);
            this.cmbMovies.TabIndex = 0;
            this.cmbMovies.SelectedIndexChanged += new System.EventHandler(this.cmbMovies_SelectedIndexChanged);
            // 
            // checkedListBoxSeats
            // 
            this.checkedListBoxSeats.FormattingEnabled = true;
            this.checkedListBoxSeats.Location = new System.Drawing.Point(37, 72);
            this.checkedListBoxSeats.Name = "checkedListBoxSeats";
            this.checkedListBoxSeats.Size = new System.Drawing.Size(266, 109);
            this.checkedListBoxSeats.TabIndex = 1;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(105, 220);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(120, 23);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Đặt vé";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 326);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.checkedListBoxSeats);
            this.Controls.Add(this.cmbMovies);
            this.Name = "Form1";
            this.Text = "Movie Ticket Booking";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cmbMovies;
        private System.Windows.Forms.CheckedListBox checkedListBoxSeats;
        private System.Windows.Forms.Button btnBook;
    }
}
