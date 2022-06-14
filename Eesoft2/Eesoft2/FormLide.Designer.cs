
namespace Eesoft2
{
    partial class FormLide
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExidBtn = new System.Windows.Forms.Button();
            this.DeleteLide = new System.Windows.Forms.Button();
            this.InterfaceLideBtn = new System.Windows.Forms.Button();
            this.OtmenaBtn = new System.Windows.Forms.Button();
            this.ActiveLideCh = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectUserCm = new System.Windows.Forms.ComboBox();
            this.SelectLideDg = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectLideDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.ExidBtn);
            this.panel1.Controls.Add(this.DeleteLide);
            this.panel1.Controls.Add(this.InterfaceLideBtn);
            this.panel1.Controls.Add(this.OtmenaBtn);
            this.panel1.Controls.Add(this.ActiveLideCh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SelectUserCm);
            this.panel1.Location = new System.Drawing.Point(2, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 408);
            this.panel1.TabIndex = 6;
            // 
            // ExidBtn
            // 
            this.ExidBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExidBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExidBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.ExidBtn.Location = new System.Drawing.Point(0, 369);
            this.ExidBtn.Name = "ExidBtn";
            this.ExidBtn.Size = new System.Drawing.Size(287, 39);
            this.ExidBtn.TabIndex = 8;
            this.ExidBtn.Text = "Назад";
            this.ExidBtn.UseVisualStyleBackColor = true;
            this.ExidBtn.Click += new System.EventHandler(this.ExidBtn_Click);
            // 
            // DeleteLide
            // 
            this.DeleteLide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(109)))));
            this.DeleteLide.Location = new System.Drawing.Point(19, 223);
            this.DeleteLide.Name = "DeleteLide";
            this.DeleteLide.Size = new System.Drawing.Size(253, 40);
            this.DeleteLide.TabIndex = 7;
            this.DeleteLide.Text = "Удалить лид";
            this.DeleteLide.UseVisualStyleBackColor = true;
            this.DeleteLide.Click += new System.EventHandler(this.DeleteLide_Click);
            // 
            // InterfaceLideBtn
            // 
            this.InterfaceLideBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.InterfaceLideBtn.Location = new System.Drawing.Point(19, 177);
            this.InterfaceLideBtn.Name = "InterfaceLideBtn";
            this.InterfaceLideBtn.Size = new System.Drawing.Size(253, 40);
            this.InterfaceLideBtn.TabIndex = 6;
            this.InterfaceLideBtn.Text = "Интерфейс лида";
            this.InterfaceLideBtn.UseVisualStyleBackColor = true;
            this.InterfaceLideBtn.Click += new System.EventHandler(this.InterfaceLideBtn_Click);
            // 
            // OtmenaBtn
            // 
            this.OtmenaBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtmenaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.OtmenaBtn.Location = new System.Drawing.Point(19, 131);
            this.OtmenaBtn.Name = "OtmenaBtn";
            this.OtmenaBtn.Size = new System.Drawing.Size(253, 40);
            this.OtmenaBtn.TabIndex = 3;
            this.OtmenaBtn.Text = "Отменить отбор";
            this.OtmenaBtn.UseVisualStyleBackColor = true;
            this.OtmenaBtn.Click += new System.EventHandler(this.OtmenaBtn_Click);
            // 
            // ActiveLideCh
            // 
            this.ActiveLideCh.AutoSize = true;
            this.ActiveLideCh.Checked = true;
            this.ActiveLideCh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActiveLideCh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ActiveLideCh.Location = new System.Drawing.Point(79, 102);
            this.ActiveLideCh.Name = "ActiveLideCh";
            this.ActiveLideCh.Size = new System.Drawing.Size(143, 23);
            this.ActiveLideCh.TabIndex = 2;
            this.ActiveLideCh.Text = "Активные лиды";
            this.ActiveLideCh.UseVisualStyleBackColor = true;
            this.ActiveLideCh.CheckedChanged += new System.EventHandler(this.ActiveLideCh_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отбор лидов пользователя";
            // 
            // SelectUserCm
            // 
            this.SelectUserCm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectUserCm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.SelectUserCm.FormattingEnabled = true;
            this.SelectUserCm.Location = new System.Drawing.Point(19, 69);
            this.SelectUserCm.Name = "SelectUserCm";
            this.SelectUserCm.Size = new System.Drawing.Size(253, 27);
            this.SelectUserCm.TabIndex = 0;
            this.SelectUserCm.SelectedIndexChanged += new System.EventHandler(this.SelectUserCm_SelectedIndexChanged);
            // 
            // SelectLideDg
            // 
            this.SelectLideDg.AllowUserToAddRows = false;
            this.SelectLideDg.AllowUserToDeleteRows = false;
            this.SelectLideDg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectLideDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectLideDg.BackgroundColor = System.Drawing.Color.White;
            this.SelectLideDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectLideDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.SelectLideDg.Location = new System.Drawing.Point(295, 132);
            this.SelectLideDg.Name = "SelectLideDg";
            this.SelectLideDg.ReadOnly = true;
            this.SelectLideDg.Size = new System.Drawing.Size(491, 408);
            this.SelectLideDg.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Eesoft2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ID";
            this.Column8.HeaderText = "Номер лида";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Fio";
            this.Column1.HeaderText = "Фио пользователя";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Phone";
            this.Column2.HeaderText = "Телефон лида";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HandlingObjections";
            this.Column3.HeaderText = "HandlingObjections";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SellTechniques";
            this.Column4.HeaderText = "SellTechniques";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ProductKnowledge";
            this.Column5.HeaderText = "ProductKnowledge";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CreateDateTime";
            this.Column6.HeaderText = "Дата создания";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "IsActive";
            this.Column7.HeaderText = "Активность лида";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormLide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 543);
            this.Controls.Add(this.SelectLideDg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(805, 582);
            this.Name = "FormLide";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список лидов";
            this.Load += new System.EventHandler(this.FormLide_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectLideDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView SelectLideDg;
        private System.Windows.Forms.Button OtmenaBtn;
        private System.Windows.Forms.CheckBox ActiveLideCh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectUserCm;
        private System.Windows.Forms.Button InterfaceLideBtn;
        private System.Windows.Forms.Button DeleteLide;
        private System.Windows.Forms.Button ExidBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
    }
}