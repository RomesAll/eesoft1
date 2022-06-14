
namespace Eesoft2
{
    partial class Menu
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
            this.SelectLideBtn = new System.Windows.Forms.Button();
            this.SelectCallBtn = new System.Windows.Forms.Button();
            this.SelectUserBtn = new System.Windows.Forms.Button();
            this.ExidBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectLideBtn
            // 
            this.SelectLideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectLideBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.SelectLideBtn.Location = new System.Drawing.Point(12, 99);
            this.SelectLideBtn.Name = "SelectLideBtn";
            this.SelectLideBtn.Size = new System.Drawing.Size(435, 64);
            this.SelectLideBtn.TabIndex = 0;
            this.SelectLideBtn.Text = "Список лидов";
            this.SelectLideBtn.UseVisualStyleBackColor = true;
            this.SelectLideBtn.Click += new System.EventHandler(this.SelectLideBtn_Click);
            // 
            // SelectCallBtn
            // 
            this.SelectCallBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectCallBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.SelectCallBtn.Location = new System.Drawing.Point(12, 169);
            this.SelectCallBtn.Name = "SelectCallBtn";
            this.SelectCallBtn.Size = new System.Drawing.Size(435, 64);
            this.SelectCallBtn.TabIndex = 1;
            this.SelectCallBtn.Text = "Звонки";
            this.SelectCallBtn.UseVisualStyleBackColor = true;
            // 
            // SelectUserBtn
            // 
            this.SelectUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.SelectUserBtn.Location = new System.Drawing.Point(12, 239);
            this.SelectUserBtn.Name = "SelectUserBtn";
            this.SelectUserBtn.Size = new System.Drawing.Size(435, 64);
            this.SelectUserBtn.TabIndex = 2;
            this.SelectUserBtn.Text = "Пользователи";
            this.SelectUserBtn.UseVisualStyleBackColor = true;
            // 
            // ExidBtn
            // 
            this.ExidBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExidBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.ExidBtn.Location = new System.Drawing.Point(350, 357);
            this.ExidBtn.Name = "ExidBtn";
            this.ExidBtn.Size = new System.Drawing.Size(106, 39);
            this.ExidBtn.TabIndex = 3;
            this.ExidBtn.Text = "Назад";
            this.ExidBtn.UseVisualStyleBackColor = true;
            this.ExidBtn.Click += new System.EventHandler(this.ExidBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eesoft2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExidBtn);
            this.Controls.Add(this.SelectUserBtn);
            this.Controls.Add(this.SelectCallBtn);
            this.Controls.Add(this.SelectLideBtn);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectLideBtn;
        private System.Windows.Forms.Button SelectCallBtn;
        private System.Windows.Forms.Button SelectUserBtn;
        private System.Windows.Forms.Button ExidBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}