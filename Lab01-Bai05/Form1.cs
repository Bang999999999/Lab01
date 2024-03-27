using System;
using System.Windows.Forms;

namespace MathOperationsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu nhập vào
            if (!int.TryParse(txtNumberA.Text, out int numberA) || !int.TryParse(txtNumberB.Text, out int numberB))
            {
                MessageBox.Show("Vui lòng nhập vào hai số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Bảng cửu chương
            richTextBoxResult.Text = "Bảng cửu chương từ " + numberA + " đến " + numberB + ":\n";
            for (int i = numberA; i <= numberB; i++)
            {
                richTextBoxResult.Text += "Bảng cửu chương của " + i + ":\n";
                for (int j = 1; j <= 10; j++)
                {
                    richTextBoxResult.Text += i + " x " + j + " = " + (i * j) + "\n";
                }
                richTextBoxResult.Text += "\n";
            }

            // Tính toán (A - B)!
            long factorialDifference = Factorial(numberA - numberB);

            richTextBoxResult.Text += "\n(A - B)! = " + factorialDifference + "\n";

            // Tính tổng S = A^1 + A^2 + A^3 + ... + A^B
            long sum = 0;
            for (int i = 1; i <= numberB; i++)
            {
                sum += (long)Math.Pow(numberA, i);
            }
            richTextBoxResult.Text += "Tổng S = " + sum;
        }

        private long Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
