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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ticketsCount = new System.Windows.Forms.Label();
            this.isActual = new System.Windows.Forms.Label();
            this.tourTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 23);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(432, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите текст для поиска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите тип:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(432, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Только актуальные туры";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(320, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 192);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(630, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 192);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 137);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // price
            // 
            this.price.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.price.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(0, 171);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(300, 30);
            this.price.TabIndex = 1;
            this.price.Text = "price";
            this.price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tourTitle);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 201);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.isActual);
            this.panel4.Controls.Add(this.ticketsCount);
            this.panel4.Location = new System.Drawing.Point(10, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 35);
            this.panel4.TabIndex = 7;
            // 
            // ticketsCount
            // 
            this.ticketsCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.ticketsCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketsCount.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketsCount.Location = new System.Drawing.Point(150, 0);
            this.ticketsCount.Name = "ticketsCount";
            this.ticketsCount.Size = new System.Drawing.Size(150, 35);
            this.ticketsCount.TabIndex = 3;
            this.ticketsCount.Text = "TicketsCount";
            this.ticketsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // isActual
            // 
            this.isActual.Dock = System.Windows.Forms.DockStyle.Left;
            this.isActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isActual.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isActual.Location = new System.Drawing.Point(0, 0);
            this.isActual.Name = "isActual";
            this.isActual.Size = new System.Drawing.Size(150, 35);
            this.isActual.TabIndex = 4;
            this.isActual.Text = "isActual";
            this.isActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tourTitle
            // 
            this.tourTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tourTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tourTitle.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tourTitle.Location = new System.Drawing.Point(0, 0);
            this.tourTitle.Name = "tourTitle";
            this.tourTitle.Size = new System.Drawing.Size(300, 30);
            this.tourTitle.TabIndex = 2;
            this.tourTitle.Text = "tourTitle";
            this.tourTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 559);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Туры";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label price;
        private Panel panel1;
        private Panel panel4;
        private Label isActual;
        private Label ticketsCount;
        private Label tourTitle;
    }
}