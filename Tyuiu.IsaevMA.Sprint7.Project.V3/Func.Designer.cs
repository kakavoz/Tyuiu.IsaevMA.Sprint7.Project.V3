
namespace Tyuiu.IsaevMA.Sprint7.Project.V3
{
    partial class Func
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Func));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelLeft_DDA = new System.Windows.Forms.Panel();
            this.buttonLoadLesson_DDA = new System.Windows.Forms.Button();
            this.buttonLoadDepartment_DDA = new System.Windows.Forms.Button();
            this.buttonLoadClass_DDA = new System.Windows.Forms.Button();
            this.buttonLoadTeacher_DDA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartPre_DDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip_DDA = new System.Windows.Forms.ToolTip(this.components);
            this.panelLeft_DDA.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPre_DDA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft_DDA
            // 
            this.panelLeft_DDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelLeft_DDA.Controls.Add(this.buttonLoadLesson_DDA);
            this.panelLeft_DDA.Controls.Add(this.buttonLoadDepartment_DDA);
            this.panelLeft_DDA.Controls.Add(this.buttonLoadClass_DDA);
            this.panelLeft_DDA.Controls.Add(this.buttonLoadTeacher_DDA);
            this.panelLeft_DDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_DDA.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_DDA.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft_DDA.Name = "panelLeft_DDA";
            this.panelLeft_DDA.Size = new System.Drawing.Size(267, 617);
            this.panelLeft_DDA.TabIndex = 2;
            // 
            // buttonLoadLesson_DDA
            // 
            this.buttonLoadLesson_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadLesson_DDA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLoadLesson_DDA.FlatAppearance.BorderSize = 0;
            this.buttonLoadLesson_DDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadLesson_DDA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoadLesson_DDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadLesson_DDA.Image")));
            this.buttonLoadLesson_DDA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadLesson_DDA.Location = new System.Drawing.Point(0, 459);
            this.buttonLoadLesson_DDA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoadLesson_DDA.Name = "buttonLoadLesson_DDA";
            this.buttonLoadLesson_DDA.Size = new System.Drawing.Size(267, 153);
            this.buttonLoadLesson_DDA.TabIndex = 3;
            this.buttonLoadLesson_DDA.Text = "Предметы";
            this.toolTip_DDA.SetToolTip(this.buttonLoadLesson_DDA, "Представление количества часов в виде диаграммы");
            this.buttonLoadLesson_DDA.UseVisualStyleBackColor = true;
            // 
            // buttonLoadDepartment_DDA
            // 
            this.buttonLoadDepartment_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadDepartment_DDA.Enabled = false;
            this.buttonLoadDepartment_DDA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLoadDepartment_DDA.FlatAppearance.BorderSize = 0;
            this.buttonLoadDepartment_DDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadDepartment_DDA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoadDepartment_DDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadDepartment_DDA.Image")));
            this.buttonLoadDepartment_DDA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadDepartment_DDA.Location = new System.Drawing.Point(0, 306);
            this.buttonLoadDepartment_DDA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoadDepartment_DDA.Name = "buttonLoadDepartment_DDA";
            this.buttonLoadDepartment_DDA.Size = new System.Drawing.Size(267, 153);
            this.buttonLoadDepartment_DDA.TabIndex = 2;
            this.buttonLoadDepartment_DDA.Text = "Кафедры";
            this.toolTip_DDA.SetToolTip(this.buttonLoadDepartment_DDA, "Представление в виде диаграммы, пока что не доступно");
            this.buttonLoadDepartment_DDA.UseVisualStyleBackColor = true;
            // 
            // buttonLoadClass_DDA
            // 
            this.buttonLoadClass_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadClass_DDA.Enabled = false;
            this.buttonLoadClass_DDA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLoadClass_DDA.FlatAppearance.BorderSize = 0;
            this.buttonLoadClass_DDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadClass_DDA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoadClass_DDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadClass_DDA.Image")));
            this.buttonLoadClass_DDA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadClass_DDA.Location = new System.Drawing.Point(0, 153);
            this.buttonLoadClass_DDA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoadClass_DDA.Name = "buttonLoadClass_DDA";
            this.buttonLoadClass_DDA.Size = new System.Drawing.Size(267, 153);
            this.buttonLoadClass_DDA.TabIndex = 1;
            this.buttonLoadClass_DDA.Text = "Аудитории";
            this.toolTip_DDA.SetToolTip(this.buttonLoadClass_DDA, "Представление в виде диаграммы, пока что не доступно");
            this.buttonLoadClass_DDA.UseVisualStyleBackColor = true;
            // 
            // buttonLoadTeacher_DDA
            // 
            this.buttonLoadTeacher_DDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonLoadTeacher_DDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLoadTeacher_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadTeacher_DDA.Enabled = false;
            this.buttonLoadTeacher_DDA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLoadTeacher_DDA.FlatAppearance.BorderSize = 0;
            this.buttonLoadTeacher_DDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadTeacher_DDA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLoadTeacher_DDA.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadTeacher_DDA.Image")));
            this.buttonLoadTeacher_DDA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadTeacher_DDA.Location = new System.Drawing.Point(0, 0);
            this.buttonLoadTeacher_DDA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLoadTeacher_DDA.Name = "buttonLoadTeacher_DDA";
            this.buttonLoadTeacher_DDA.Size = new System.Drawing.Size(267, 153);
            this.buttonLoadTeacher_DDA.TabIndex = 0;
            this.buttonLoadTeacher_DDA.Text = "Преподаватели";
            this.toolTip_DDA.SetToolTip(this.buttonLoadTeacher_DDA, "Представление в виде диаграммы, пока что не доступно");
            this.buttonLoadTeacher_DDA.UseVisualStyleBackColor = false;
            this.buttonLoadTeacher_DDA.Click += new System.EventHandler(this.buttonLoadTeacher_DDA_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartPre_DDA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(267, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 617);
            this.panel1.TabIndex = 3;
            // 
            // chartPre_DDA
            // 
            this.chartPre_DDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chartPre_DDA.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            chartArea1.Name = "ChartArea1";
            this.chartPre_DDA.ChartAreas.Add(chartArea1);
            this.chartPre_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartPre_DDA.Legends.Add(legend1);
            this.chartPre_DDA.Location = new System.Drawing.Point(0, 0);
            this.chartPre_DDA.Margin = new System.Windows.Forms.Padding(4);
            this.chartPre_DDA.Name = "chartPre_DDA";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPre_DDA.Series.Add(series1);
            this.chartPre_DDA.Size = new System.Drawing.Size(945, 617);
            this.chartPre_DDA.TabIndex = 0;
            this.chartPre_DDA.Text = "chart1";
            this.chartPre_DDA.Click += new System.EventHandler(this.chartPre_DDA_Click);
            // 
            // Func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft_DDA);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1227, 654);
            this.Name = "Func";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изображение значений таблиц в виде диаграммы";
            this.Load += new System.EventHandler(this.FormFunc_Load);
            this.panelLeft_DDA.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPre_DDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft_DDA;
        private System.Windows.Forms.Button buttonLoadLesson_DDA;
        private System.Windows.Forms.Button buttonLoadDepartment_DDA;
        private System.Windows.Forms.Button buttonLoadClass_DDA;
        private System.Windows.Forms.Button buttonLoadTeacher_DDA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPre_DDA;
        private System.Windows.Forms.ToolTip toolTip_DDA;
    }
}