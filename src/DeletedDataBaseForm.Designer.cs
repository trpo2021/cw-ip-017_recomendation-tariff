
namespace Project
{
    partial class DeletedDataBaseForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CloseButton2 = new System.Windows.Forms.Button();
            this.MinimizeButton2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.IconPicture = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.RightBorder = new System.Windows.Forms.PictureBox();
            this.LeftBorder = new System.Windows.Forms.PictureBox();
            this.DownBorder = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpBorder = new System.Windows.Forms.PictureBox();
            this.DeletedOperator = new System.Windows.Forms.TextBox();
            this.DeletedTariff = new System.Windows.Forms.TextBox();
            this.StartDeletingButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Black;
            this.MainPanel.Controls.Add(this.CloseButton2);
            this.MainPanel.Controls.Add(this.MinimizeButton2);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.MinimizeButton);
            this.MainPanel.Controls.Add(this.IconPicture);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(500, 31);
            this.MainPanel.TabIndex = 19;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // CloseButton2
            // 
            this.CloseButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseButton2.FlatAppearance.BorderSize = 0;
            this.CloseButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.CloseButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton2.Location = new System.Drawing.Point(444, -1);
            this.CloseButton2.Name = "CloseButton2";
            this.CloseButton2.Size = new System.Drawing.Size(56, 32);
            this.CloseButton2.TabIndex = 12;
            this.CloseButton2.Text = "X";
            this.CloseButton2.UseVisualStyleBackColor = false;
            this.CloseButton2.Click += new System.EventHandler(this.CloseButton2_Click);
            // 
            // MinimizeButton2
            // 
            this.MinimizeButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimizeButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimizeButton2.FlatAppearance.BorderSize = 0;
            this.MinimizeButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MinimizeButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MinimizeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinimizeButton2.Location = new System.Drawing.Point(390, 0);
            this.MinimizeButton2.Name = "MinimizeButton2";
            this.MinimizeButton2.Size = new System.Drawing.Size(56, 32);
            this.MinimizeButton2.TabIndex = 11;
            this.MinimizeButton2.Text = "-";
            this.MinimizeButton2.UseVisualStyleBackColor = false;
            this.MinimizeButton2.Click += new System.EventHandler(this.MinimizeButton2_Click);
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
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinimizeButton.Location = new System.Drawing.Point(866, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(56, 32);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = false;
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
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(919, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(56, 32);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // RightBorder
            // 
            this.RightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.RightBorder.Location = new System.Drawing.Point(499, 5);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(1, 350);
            this.RightBorder.TabIndex = 21;
            this.RightBorder.TabStop = false;
            // 
            // LeftBorder
            // 
            this.LeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LeftBorder.Location = new System.Drawing.Point(0, 3);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(1, 350);
            this.LeftBorder.TabIndex = 22;
            this.LeftBorder.TabStop = false;
            // 
            // DownBorder
            // 
            this.DownBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DownBorder.Location = new System.Drawing.Point(0, 349);
            this.DownBorder.Name = "DownBorder";
            this.DownBorder.Size = new System.Drawing.Size(500, 1);
            this.DownBorder.TabIndex = 23;
            this.DownBorder.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 1);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // UpBorder
            // 
            this.UpBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.UpBorder.Location = new System.Drawing.Point(0, 0);
            this.UpBorder.Name = "UpBorder";
            this.UpBorder.Size = new System.Drawing.Size(500, 1);
            this.UpBorder.TabIndex = 25;
            this.UpBorder.TabStop = false;
            // 
            // DeletedOperator
            // 
            this.DeletedOperator.Location = new System.Drawing.Point(162, 86);
            this.DeletedOperator.Name = "DeletedOperator";
            this.DeletedOperator.Size = new System.Drawing.Size(176, 20);
            this.DeletedOperator.TabIndex = 26;
            this.DeletedOperator.Enter += new System.EventHandler(this.DeletedOperator_Enter);
            this.DeletedOperator.Leave += new System.EventHandler(this.DeletedOperator_Leave);
            // 
            // DeletedTariff
            // 
            this.DeletedTariff.Location = new System.Drawing.Point(162, 112);
            this.DeletedTariff.Name = "DeletedTariff";
            this.DeletedTariff.Size = new System.Drawing.Size(176, 20);
            this.DeletedTariff.TabIndex = 27;
            this.DeletedTariff.Enter += new System.EventHandler(this.DeletedTariff_Enter);
            this.DeletedTariff.Leave += new System.EventHandler(this.DeletedTariff_Leave);
            // 
            // StartDeletingButton
            // 
            this.StartDeletingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StartDeletingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartDeletingButton.ForeColor = System.Drawing.Color.White;
            this.StartDeletingButton.Location = new System.Drawing.Point(162, 261);
            this.StartDeletingButton.Name = "StartDeletingButton";
            this.StartDeletingButton.Size = new System.Drawing.Size(176, 23);
            this.StartDeletingButton.TabIndex = 28;
            this.StartDeletingButton.Text = "Удалить тариф";
            this.StartDeletingButton.UseVisualStyleBackColor = true;
            this.StartDeletingButton.Click += new System.EventHandler(this.StartDeletingButton_Click);
            // 
            // DeletedDataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.StartDeletingButton);
            this.Controls.Add(this.DeletedTariff);
            this.Controls.Add(this.DeletedOperator);
            this.Controls.Add(this.UpBorder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DownBorder);
            this.Controls.Add(this.LeftBorder);
            this.Controls.Add(this.RightBorder);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletedDataBaseForm";
            this.Text = "DeletedDataBaseForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button CloseButton2;
        private System.Windows.Forms.Button MinimizeButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.PictureBox IconPicture;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox RightBorder;
        private System.Windows.Forms.PictureBox LeftBorder;
        private System.Windows.Forms.PictureBox DownBorder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox UpBorder;
        private System.Windows.Forms.TextBox DeletedOperator;
        private System.Windows.Forms.TextBox DeletedTariff;
        private System.Windows.Forms.Button StartDeletingButton;
    }
}