namespace pr12_var6_Savitsin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBuy = new Button();
            btnInfo = new Button();
            btnMood = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(270, 448);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(213, 29);
            btnBuy.TabIndex = 5;
            btnBuy.Text = "Купить";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(508, 448);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(213, 29);
            btnInfo.TabIndex = 7;
            btnInfo.Text = "Информация";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnMood
            // 
            btnMood.Location = new Point(749, 448);
            btnMood.Name = "btnMood";
            btnMood.Size = new Size(213, 29);
            btnMood.TabIndex = 8;
            btnMood.Text = "Настроение";
            btnMood.UseVisualStyleBackColor = true;
            btnMood.Click += btnMood_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1041, 413);
            dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 614);
            Controls.Add(dataGridView1);
            Controls.Add(btnMood);
            Controls.Add(btnInfo);
            Controls.Add(btnBuy);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnBuy;
        private Button btnInfo;
        private Button btnMood;
        private DataGridView dataGridView1;
    }
}
