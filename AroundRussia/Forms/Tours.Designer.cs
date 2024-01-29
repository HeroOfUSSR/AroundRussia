namespace AroundRussia.Forms
{
    partial class Tours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tours));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tourOutput1 = new AroundRussia.Forms.TourOutput();
            this.tourOutput2 = new AroundRussia.Forms.TourOutput();
            this.tourOutput3 = new AroundRussia.Forms.TourOutput();
            this.tourOutput4 = new AroundRussia.Forms.TourOutput();
            this.tourOutput5 = new AroundRussia.Forms.TourOutput();
            this.tourOutput6 = new AroundRussia.Forms.TourOutput();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(481, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 23);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(392, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(264, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите текст для поиска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(264, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите тип:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(401, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 22);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Только актуальные туры";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 125);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tourOutput1);
            this.flowLayoutPanel1.Controls.Add(this.tourOutput2);
            this.flowLayoutPanel1.Controls.Add(this.tourOutput3);
            this.flowLayoutPanel1.Controls.Add(this.tourOutput4);
            this.flowLayoutPanel1.Controls.Add(this.tourOutput5);
            this.flowLayoutPanel1.Controls.Add(this.tourOutput6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 125);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(960, 434);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // tourOutput1
            // 
            this.tourOutput1.Location = new System.Drawing.Point(10, 10);
            this.tourOutput1.Margin = new System.Windows.Forms.Padding(10);
            this.tourOutput1.Name = "tourOutput1";
            this.tourOutput1.Size = new System.Drawing.Size(300, 260);
            this.tourOutput1.TabIndex = 0;
            // 
            // tourOutput2
            // 
            this.tourOutput2.Location = new System.Drawing.Point(330, 10);
            this.tourOutput2.Margin = new System.Windows.Forms.Padding(10);
            this.tourOutput2.Name = "tourOutput2";
            this.tourOutput2.Size = new System.Drawing.Size(300, 260);
            this.tourOutput2.TabIndex = 1;
            // 
            // tourOutput3
            // 
            this.tourOutput3.Location = new System.Drawing.Point(650, 10);
            this.tourOutput3.Margin = new System.Windows.Forms.Padding(10);
            this.tourOutput3.Name = "tourOutput3";
            this.tourOutput3.Size = new System.Drawing.Size(300, 260);
            this.tourOutput3.TabIndex = 2;
            // 
            // tourOutput4
            // 
            this.tourOutput4.Location = new System.Drawing.Point(10, 290);
            this.tourOutput4.Margin = new System.Windows.Forms.Padding(10);
            this.tourOutput4.Name = "tourOutput4";
            this.tourOutput4.Size = new System.Drawing.Size(300, 260);
            this.tourOutput4.TabIndex = 3;
            // 
            // tourOutput5
            // 
            this.tourOutput5.Location = new System.Drawing.Point(330, 290);
            this.tourOutput5.Margin = new System.Windows.Forms.Padding(10);
            this.tourOutput5.Name = "tourOutput5";
            this.tourOutput5.Size = new System.Drawing.Size(300, 260);
            this.tourOutput5.TabIndex = 4;
            // 
            // tourOutput6
            // 
            this.tourOutput6.Location = new System.Drawing.Point(650, 290);
            this.tourOutput6.Margin = new System.Windows.Forms.Padding(10);
            this.tourOutput6.Name = "tourOutput6";
            this.tourOutput6.Size = new System.Drawing.Size(300, 260);
            this.tourOutput6.TabIndex = 5;
            // 
            // Tours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 559);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Туры";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TourOutput tourOutput1;
        private TourOutput tourOutput2;
        private TourOutput tourOutput3;
        private TourOutput tourOutput4;
        private TourOutput tourOutput5;
        private TourOutput tourOutput6;
    }
}