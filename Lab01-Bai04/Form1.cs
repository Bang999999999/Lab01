using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovieTicketBookingApp
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> moviePrices = new Dictionary<string, double>()
        {
            { "Đào, phở và piano", 45000 },
            { "Mai", 100000 },
            { "Gặp lại chị bầu", 70000 },
            { "Tarot", 90000 }
        };

        Dictionary<string, List<string>> seatStatus = new Dictionary<string, List<string>>()
        {
            { "A", new List<string>() { "A1", "A2", "A3", "A4", "A5" } },
            { "B", new List<string>() { "B1", "B2", "B3", "B4", "B5" } },
            { "C", new List<string>() { "C1", "C2", "C3", "C4", "C5" } }
        };

        Dictionary<string, string> movieRooms = new Dictionary<string, string>()
        {
            { "Đào, phở và piano", "Phòng 1, 2, 3" },
            { "Mai", "Phòng 2, 3" },
            { "Gặp lại chị bầu", "Phòng 1" },
            { "Tarot", "Phòng 3" }
        };

        double GetTicketPrice(string movieName, string seat)
        {
            double basePrice = moviePrices[movieName];
            if (seat == "A1" || seat == "A5" || seat == "C1" || seat == "C5")
                return basePrice / 4; // Vé vớt
            else if (seat.StartsWith("B"))
                return basePrice * 2; // Vé VIP
            else
                return basePrice; // Vé thường
        }

        public Form1()
        {
            InitializeComponent();
            cmbMovies.DataSource = new BindingSource(moviePrices, null);
            cmbMovies.DisplayMember = "Key";
            cmbMovies.ValueMember = "Value";
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            string movieName = cmbMovies.Text;
            string selectedSeat = "";
            foreach (var item in checkedListBoxSeats.CheckedItems)
            {
                selectedSeat = item.ToString();
                break;
            }

            double totalPrice = GetTicketPrice(movieName, selectedSeat);
            string room = movieRooms[movieName];

            MessageBox.Show("Thông tin khách hàng:\n" +
                            "Tên phim: " + movieName + "\n" +
                            "Phòng chiếu: " + room + "\n" +
                            "Chỗ ngồi: " + selectedSeat + "\n" +
                            "Giá vé: " + totalPrice.ToString("C"));
        }

        private void cmbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxSeats.Items.Clear();
            string selectedMovie = cmbMovies.Text;
            foreach (var seat in seatStatus)
            {
                foreach (var s in seat.Value)
                {
                    checkedListBoxSeats.Items.Add(seat.Key + s);
                }
            }
        }
    }
}
