using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentScoresApp
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();

            // Kiểm tra xem chuỗi nhập vào có hợp lệ hay không
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập danh sách điểm của sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] parts = input.Split(',');

            // Kiểm tra xem có đúng định dạng không
            if (parts.Length < 2 || !parts.Skip(1).All(x => double.TryParse(x, out _)))
            {
                MessageBox.Show("Định dạng không hợp lệ. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tách họ và tên của sinh viên
            string fullName = parts[0].Trim();
            string[] scores = parts.Skip(1).ToArray();

            // Hiển thị tên sinh viên
            lblFullName.Text = "Họ và tên: " + fullName;

            // Hiển thị danh sách điểm
            for (int i = 0; i < scores.Length; i++)
            {
                lblScores.Text += $"Môn {i + 1}: {scores[i]} ";
            }

            // Tính điểm trung bình
            double sum = scores.Select(double.Parse).Sum();
            double average = sum / scores.Length;
            lblAverage.Text = $"Điểm trung bình: {average:F2}";

            // Tìm điểm cao nhất và thấp nhất
            double maxScore = scores.Select(double.Parse).Max();
            double minScore = scores.Select(double.Parse).Min();
            lblMaxMinScore.Text = $"Điểm cao nhất: {maxScore}, Điểm thấp nhất: {minScore}";

            // Tìm số môn đậu và không đậu
            int passCount = scores.Count(s => double.Parse(s) >= 5);
            int failCount = scores.Length - passCount;
            lblPassFailCount.Text = $"Số môn đậu: {passCount}, Số môn không đậu: {failCount}";

            // Xếp loại sinh viên
            if (average >= 8 && scores.All(s => double.Parse(s) >= 6.5))
            {
                lblClassification.Text = "Xếp loại: Giỏi";
            }
            else if (average >= 6.5 && scores.All(s => double.Parse(s) >= 5))
            {
                lblClassification.Text = "Xếp loại: Khá";
            }
            else if (average >= 5 && scores.All(s => double.Parse(s) >= 3.5))
            {
                lblClassification.Text = "Xếp loại: TB";
            }
            else if (average >= 3.5 && scores.All(s => double.Parse(s) >= 2))
            {
                lblClassification.Text = "Xếp loại: Yếu";
            }
            else
            {
                lblClassification.Text = "Xếp loại: Kém";
            }
        }
    }
}
