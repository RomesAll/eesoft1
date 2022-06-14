
namespace Eesoft2
{
    partial class Autorizacie
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginTx = new System.Windows.Forms.TextBox();
            this.PasswordTx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VxodBtn = new System.Windows.Forms.Button();
            this.ChekPassword = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTx
            // 
            this.LoginTx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.LoginTx.Location = new System.Drawing.Point(284, 72);
            this.LoginTx.Name = "LoginTx";
            this.LoginTx.Size = new System.Drawing.Size(211, 27);
            this.LoginTx.TabIndex = 1;
            this.LoginTx.Text = "abdulina";
            // 
            // PasswordTx
            // 
            this.PasswordTx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.PasswordTx.Location = new System.Drawing.Point(284, 133);
            this.PasswordTx.Name = "PasswordTx";
            this.PasswordTx.Size = new System.Drawing.Size(211, 27);
            this.PasswordTx.TabIndex = 2;
            this.PasswordTx.Text = "1";
            this.PasswordTx.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(280, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(280, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // VxodBtn
            // 
            this.VxodBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.VxodBtn.Location = new System.Drawing.Point(323, 298);
            this.VxodBtn.Name = "VxodBtn";
            this.VxodBtn.Size = new System.Drawing.Size(152, 40);
            this.VxodBtn.TabIndex = 5;
            this.VxodBtn.Text = "Войти";
            this.VxodBtn.UseVisualStyleBackColor = true;
            this.VxodBtn.Click += new System.EventHandler(this.VxodBtn_Click);
            // 
            // ChekPassword
            // 
            this.ChekPassword.AutoSize = true;
            this.ChekPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.ChekPassword.Location = new System.Drawing.Point(323, 166);
            this.ChekPassword.Name = "ChekPassword";
            this.ChekPassword.Size = new System.Drawing.Size(152, 23);
            this.ChekPassword.TabIndex = 6;
            this.ChekPassword.Text = "Показать пароль";
            this.ChekPassword.UseVisualStyleBackColor = true;
            this.ChekPassword.CheckedChanged += new System.EventHandler(this.ChekPassword_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eesoft2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Autorizacie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 350);
            this.Controls.Add(this.ChekPassword);
            this.Controls.Add(this.VxodBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTx);
            this.Controls.Add(this.LoginTx);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Autorizacie";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LoginTx;
        private System.Windows.Forms.TextBox PasswordTx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VxodBtn;
        private System.Windows.Forms.CheckBox ChekPassword;
    }
}

