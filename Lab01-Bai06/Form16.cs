using System;
using System.Windows.Forms;

namespace ZodiacSignApp
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu nhập vào
            if (!int.TryParse(txtDay.Text, out int day) || !int.TryParse(txtMonth.Text, out int month) || !int.TryParse(txtYear.Text, out int year))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng ngày tháng năm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra tính hợp lệ của ngày và tháng
            if (day < 1 || day > 31 || month < 1 || month > 12)
            {
                MessageBox.Show("Ngày hoặc tháng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string zodiacSign = GetZodiacSign(day, month);
            MessageBox.Show("Cung hoàng đạo của bạn là: " + zodiacSign, "Thông tin");
        }

        private string GetZodiacSign(int day, int month)
        {
            switch (month)
            {
                case 1:
                    if (day >= 21)
                        return "Bảo Bình";
                    else
                        return "Ma Kết";
                case 2:
                    if (day >= 20)
                        return "Song Ngư";
                    else
                        return "Bảo Bình";
                case 3:
                    if (day >= 21)
                        return "Bạch Dương";
                    else
                        return "Song Ngư";
                case 4:
                    if (day >= 21)
                        return "Kim Ngưu";
                    else
                        return "Bạch Dương";
                case 5:
                    if (day >= 22)
                        return "Song Tử";
                    else
                        return "Kim Ngưu";
                case 6:
                    if (day >= 22)
                        return "Cự Giải";
                    else
                        return "Song Tử";
                case 7:
                    if (day >= 23)
                        return "Sư Tử";
                    else
                        return "Cự Giải";
                case 8:
                    if (day >= 23)
                        return "Xử Nữ";
                    else
                        return "Sư Tử";
                case 9:
                    if (day >= 23)
                        return "Thiên Bình";
                    else
                        return "Xử Nữ";
                case 10:
                    if (day >= 24)
                        return "Thần Nông";
                    else
                        return "Thiên Bình";
                case 11:
                    if (day >= 23)
                        return "Nhân Mã";
                    else
                        return "Thần Nông";
                case 12:
                    if (day >= 22)
                        return "Ma Kết";
                    else
                        return "Nhân Mã";
                default:
                    return "";
            }
        }
    }
}
