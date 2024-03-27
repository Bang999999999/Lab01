using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WhatToEatApp
{
    public partial class Form18 : Form
    {
        private List<string> favoriteFoods = new List<string> { "Cơm", "Phở", "Bún", "Gà", "Bò", "Cá" };

        public Form18()
        {
            InitializeComponent();
            UpdateFavoriteFoodsList();
        }

        private void UpdateFavoriteFoodsList()
        {
            lstFavoriteFoods.Items.Clear();
            foreach (string food in favoriteFoods)
            {
                lstFavoriteFoods.Items.Add(food);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string newFood = txtNewFood.Text.Trim();
            if (!string.IsNullOrEmpty(newFood))
            {
                favoriteFoods.Add(newFood);
                UpdateFavoriteFoodsList();
                txtNewFood.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên món ăn mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRandomFood_Click(object sender, EventArgs e)
        {
            if (favoriteFoods.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(0, favoriteFoods.Count);
                string randomFood = favoriteFoods[index];
                MessageBox.Show("Hôm nay ăn: " + randomFood, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Danh sách món ăn trống. Vui lòng thêm món ăn trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFindFood_Click(object sender, EventArgs e)
        {
            string searchFood = txtSearchFood.Text.Trim();
            if (!string.IsNullOrEmpty(searchFood))
            {
                int index = favoriteFoods.FindIndex(food => food.Equals(searchFood, StringComparison.OrdinalIgnoreCase));
                if (index != -1)
                {
                    lstFavoriteFoods.SelectedIndex = index;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy món ăn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên món ăn cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (lstFavoriteFoods.SelectedIndex != -1)
            {
                favoriteFoods.RemoveAt(lstFavoriteFoods.SelectedIndex);
                UpdateFavoriteFoodsList();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món ăn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
