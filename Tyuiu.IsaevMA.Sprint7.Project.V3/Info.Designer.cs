
namespace Tyuiu.IsaevMA.Sprint7.Project.V3
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.pictureBox_DDA = new System.Windows.Forms.PictureBox();
            this.labelInfo_DDA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DDA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_DDA
            // 
            this.pictureBox_DDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox_DDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_DDA.Image")));
            this.pictureBox_DDA.Location = new System.Drawing.Point(160, 187);
            this.pictureBox_DDA.Name = "pictureBox_DDA";
            this.pictureBox_DDA.Size = new System.Drawing.Size(648, 263);
            this.pictureBox_DDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_DDA.TabIndex = 0;
            this.pictureBox_DDA.TabStop = false;
            this.pictureBox_DDA.Click += new System.EventHandler(this.pictureBox_DDA_Click);
            // 
            // labelInfo_DDA
            // 
            this.labelInfo_DDA.AutoSize = true;
            this.labelInfo_DDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelInfo_DDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F, System.Drawing.FontStyle.Bold);
            this.labelInfo_DDA.Location = new System.Drawing.Point(290, 114);
            this.labelInfo_DDA.Name = "labelInfo_DDA";
            this.labelInfo_DDA.Size = new System.Drawing.Size(407, 74);
            this.labelInfo_DDA.TabIndex = 1;
            this.labelInfo_DDA.Text = "Разработчик: Исаев.М.А.\r\nГруппа АСОИУБ-23-3";
            this.labelInfo_DDA.Click += new System.EventHandler(this.labelInfo_DDA_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.labelInfo_DDA);
            this.Controls.Add(this.pictureBox_DDA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_DDA;
        private System.Windows.Forms.Label labelInfo_DDA;
    }
}