
namespace Tyuiu.IsaevMA.Sprint7.Project.V3
{
    partial class Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.panelTop_DDA = new System.Windows.Forms.Panel();
            this.textBoxTitle_DDA = new System.Windows.Forms.TextBox();
            this.panelLeft_DDA = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFill_DDA = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelTop_DDA.SuspendLayout();
            this.panelFill_DDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_DDA
            // 
            this.panelTop_DDA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelTop_DDA.Controls.Add(this.textBoxTitle_DDA);
            this.panelTop_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_DDA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_DDA.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop_DDA.Name = "panelTop_DDA";
            this.panelTop_DDA.Size = new System.Drawing.Size(845, 48);
            this.panelTop_DDA.TabIndex = 2;
            // 
            // textBoxTitle_DDA
            // 
            this.textBoxTitle_DDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxTitle_DDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTitle_DDA.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle_DDA.ForeColor = System.Drawing.Color.Black;
            this.textBoxTitle_DDA.Location = new System.Drawing.Point(0, 0);
            this.textBoxTitle_DDA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitle_DDA.Name = "textBoxTitle_DDA";
            this.textBoxTitle_DDA.ReadOnly = true;
            this.textBoxTitle_DDA.Size = new System.Drawing.Size(845, 45);
            this.textBoxTitle_DDA.TabIndex = 1;
            this.textBoxTitle_DDA.TabStop = false;
            this.textBoxTitle_DDA.Text = "Руководство пользователя";
            this.textBoxTitle_DDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTitle_DDA.TextChanged += new System.EventHandler(this.textBoxTitle_DDA_TextChanged);
            // 
            // panelLeft_DDA
            // 
            this.panelLeft_DDA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelLeft_DDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_DDA.Location = new System.Drawing.Point(0, 48);
            this.panelLeft_DDA.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft_DDA.Name = "panelLeft_DDA";
            this.panelLeft_DDA.Size = new System.Drawing.Size(10, 396);
            this.panelLeft_DDA.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(835, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 396);
            this.panel1.TabIndex = 4;
            // 
            // panelFill_DDA
            // 
            this.panelFill_DDA.Controls.Add(this.textBox1);
            this.panelFill_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_DDA.Location = new System.Drawing.Point(10, 48);
            this.panelFill_DDA.Margin = new System.Windows.Forms.Padding(4);
            this.panelFill_DDA.Name = "panelFill_DDA";
            this.panelFill_DDA.Size = new System.Drawing.Size(825, 396);
            this.panelFill_DDA.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(825, 396);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.panelFill_DDA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft_DDA);
            this.Controls.Add(this.panelTop_DDA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(861, 481);
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.panelTop_DDA.ResumeLayout(false);
            this.panelTop_DDA.PerformLayout();
            this.panelFill_DDA.ResumeLayout(false);
            this.panelFill_DDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_DDA;
        private System.Windows.Forms.TextBox textBoxTitle_DDA;
        private System.Windows.Forms.Panel panelLeft_DDA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFill_DDA;
        private System.Windows.Forms.TextBox textBox1;
    }
}