namespace WhatToEatApp
{
    partial class Form18
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
            this.lstFavoriteFoods = new System.Windows.Forms.ListBox();
            this.txtNewFood = new System.Windows.Forms.TextBox();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnRandomFood = new System.Windows.Forms.Button();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.btnFindFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFavoriteFoods
            // 
            this.lstFavoriteFoods.FormattingEnabled = true;
            this.lstFavoriteFoods.Location = new System.Drawing.Point(13, 13);
            this.lstFavoriteFoods.Name = "lstFavoriteFoods";
            this.lstFavoriteFoods.Size = new System.Drawing.Size(120, 147);
            this.lstFavoriteFoods.TabIndex = 0;
            // 
            // txtNewFood
            // 
            this.txtNewFood.Location = new System.Drawing.Point(139, 13);
            this.txtNewFood.Name = "txtNewFood";
            this.txtNewFood.Size = new System.Drawing.Size(100, 20);
            this.txtNewFood.TabIndex = 1;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(139, 40);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(100, 23);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món ăn";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnRandomFood
            // 
            this.btnRandomFood.Location = new System.Drawing.Point(245, 137);
            this.btnRandomFood.Name = "btnRandomFood";
            this.btnRandomFood.Size = new System.Drawing.Size(100, 23);
            this.btnRandomFood.TabIndex = 3;
            this.btnRandomFood.Text = "Hôm nay ăn gì?";
            this.btnRandomFood.UseVisualStyleBackColor = true;
            this.btnRandomFood.Click += new System.EventHandler(this.btnRandomFood_Click);
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Location = new System.Drawing.Point(245, 13);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(100, 20);
            this.txtSearchFood.TabIndex = 4;
            // 
            // btnFindFood
            // 
            this.btnFindFood.Location = new System.Drawing.Point(245, 40);
            this.btnFindFood.Name = "btnFindFood";
            this.btnFindFood.Size = new System.Drawing.Size(100, 23);
            this.btnFindFood.TabIndex = 5;
            this.btnFindFood.Text = "Tìm món ăn";
            this.btnFindFood.UseVisualStyleBackColor = true;
            this.btnFindFood.Click += new System.EventHandler(this.btnFindFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(245, 69);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteFood.TabIndex = 6;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(139, 104);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 174);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnFindFood);
            this.Controls.Add(this.txtSearchFood);
            this.Controls.Add(this.btnRandomFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.txtNewFood);
            this.Controls.Add(this.lstFavoriteFoods);
            this.Name = "Form18";
            this.Text = "Hôm nay ăn gì?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox lstFavoriteFoods;
        private System.Windows.Forms.TextBox txtNewFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnRandomFood;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Button btnFindFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnExit;
    }
}
