
namespace Project
{
    partial class MainForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.IconPicture = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.RightBorder = new System.Windows.Forms.PictureBox();
            this.DownBorder = new System.Windows.Forms.PictureBox();
            this.LeftBorder = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserMoney = new System.Windows.Forms.TextBox();
            this.UserGigi = new System.Windows.Forms.TextBox();
            this.UserMinutes = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.OutTextBox = new System.Windows.Forms.RichTextBox();
            this.ShowAllTariffs = new System.Windows.Forms.Button();
            this.WriteButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.MinimizeButton);
            this.MainPanel.Controls.Add(this.IconPicture);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(975, 31);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Recomendation Tariff";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinimizeButton.Location = new System.Drawing.Point(866, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(56, 32);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // IconPicture
            // 
            this.IconPicture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IconPicture.Location = new System.Drawing.Point(3, 0);
            this.IconPicture.Name = "IconPicture";
            this.IconPicture.Size = new System.Drawing.Size(19, 31);
            this.IconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPicture.TabIndex = 3;
            this.IconPicture.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(919, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(56, 32);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RightBorder
            // 
            this.RightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RightBorder.Location = new System.Drawing.Point(974, 0);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(1, 535);
            this.RightBorder.TabIndex = 12;
            this.RightBorder.TabStop = false;
            // 
            // DownBorder
            // 
            this.DownBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DownBorder.Location = new System.Drawing.Point(0, 534);
            this.DownBorder.Name = "DownBorder";
            this.DownBorder.Size = new System.Drawing.Size(975, 1);
            this.DownBorder.TabIndex = 13;
            this.DownBorder.TabStop = false;
            // 
            // LeftBorder
            // 
            this.LeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LeftBorder.Location = new System.Drawing.Point(0, 0);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(1, 535);
            this.LeftBorder.TabIndex = 14;
            this.LeftBorder.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(975, 1);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Максимально возможные затраты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Кол-во гигабайт интернета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Кол-во минут";
            // 
            // UserMoney
            // 
            this.UserMoney.Location = new System.Drawing.Point(379, 119);
            this.UserMoney.Name = "UserMoney";
            this.UserMoney.Size = new System.Drawing.Size(176, 20);
            this.UserMoney.TabIndex = 19;
            this.UserMoney.Text = "500";
            this.UserMoney.Enter += new System.EventHandler(this.UserMoney_Enter);
            this.UserMoney.Leave += new System.EventHandler(this.UserMoney_Leave);
            // 
            // UserGigi
            // 
            this.UserGigi.Location = new System.Drawing.Point(379, 169);
            this.UserGigi.Name = "UserGigi";
            this.UserGigi.Size = new System.Drawing.Size(176, 20);
            this.UserGigi.TabIndex = 20;
            this.UserGigi.Text = "10";
            this.UserGigi.Enter += new System.EventHandler(this.UserGigi_Enter);
            this.UserGigi.Leave += new System.EventHandler(this.UserGigi_Leave);
            // 
            // UserMinutes
            // 
            this.UserMinutes.Location = new System.Drawing.Point(380, 218);
            this.UserMinutes.Name = "UserMinutes";
            this.UserMinutes.Size = new System.Drawing.Size(175, 20);
            this.UserMinutes.TabIndex = 21;
            this.UserMinutes.Text = "1000";
            this.UserMinutes.Enter += new System.EventHandler(this.UserMinutes_Enter);
            this.UserMinutes.Leave += new System.EventHandler(this.UserMinutes_Leave);
            // 
            // StartButton
            // 
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(379, 330);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(176, 23);
            this.StartButton.TabIndex = 22;
            this.StartButton.Text = "Подобрать тариф";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // OutTextBox
            // 
            this.OutTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.OutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutTextBox.ForeColor = System.Drawing.Color.White;
            this.OutTextBox.Location = new System.Drawing.Point(602, 48);
            this.OutTextBox.Name = "OutTextBox";
            this.OutTextBox.ReadOnly = true;
            this.OutTextBox.Size = new System.Drawing.Size(361, 305);
            this.OutTextBox.TabIndex = 23;
            this.OutTextBox.Text = "";
            this.OutTextBox.Visible = false;
            // 
            // ShowAllTariffs
            // 
            this.ShowAllTariffs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ShowAllTariffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllTariffs.ForeColor = System.Drawing.Color.White;
            this.ShowAllTariffs.Location = new System.Drawing.Point(560, 500);
            this.ShowAllTariffs.Name = "ShowAllTariffs";
            this.ShowAllTariffs.Size = new System.Drawing.Size(176, 23);
            this.ShowAllTariffs.TabIndex = 24;
            this.ShowAllTariffs.Text = "Вывести все тарифы";
            this.ShowAllTariffs.UseVisualStyleBackColor = true;
            this.ShowAllTariffs.Click += new System.EventHandler(this.ShowAllTariffs_Click);
            // 
            // WriteButton
            // 
            this.WriteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.WriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteButton.ForeColor = System.Drawing.Color.White;
            this.WriteButton.Location = new System.Drawing.Point(742, 500);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(221, 23);
            this.WriteButton.TabIndex = 25;
            this.WriteButton.Text = "Добавить новый тариф в базу данных";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(975, 535);
            this.ControlBox = false;
            this.Controls.Add(this.WriteButton);
            this.Controls.Add(this.ShowAllTariffs);
            this.Controls.Add(this.OutTextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.UserMinutes);
            this.Controls.Add(this.UserGigi);
            this.Controls.Add(this.UserMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LeftBorder);
            this.Controls.Add(this.DownBorder);
            this.Controls.Add(this.RightBorder);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recomendation tariff";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.PictureBox IconPicture;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox RightBorder;
        private System.Windows.Forms.PictureBox DownBorder;
        private System.Windows.Forms.PictureBox LeftBorder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserMoney;
        private System.Windows.Forms.TextBox UserGigi;
        private System.Windows.Forms.TextBox UserMinutes;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RichTextBox OutTextBox;
        private System.Windows.Forms.Button ShowAllTariffs;
        private System.Windows.Forms.Button WriteButton;
    }
}

