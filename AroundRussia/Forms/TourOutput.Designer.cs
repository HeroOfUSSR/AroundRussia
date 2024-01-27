namespace AroundRussia.Forms
{
    partial class TourOutput
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureTour = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTickets = new System.Windows.Forms.Label();
            this.labelisActual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureTour
            // 
            this.pictureTour.Location = new System.Drawing.Point(0, 40);
            this.pictureTour.Name = "pictureTour";
            this.pictureTour.Size = new System.Drawing.Size(300, 145);
            this.pictureTour.TabIndex = 0;
            this.pictureTour.TabStop = false;
            this.pictureTour.Click += new System.EventHandler(this.pictureTour_Click);
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(300, 37);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelisActual);
            this.panel1.Controls.Add(this.labelTickets);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 78);
            this.panel1.TabIndex = 2;
            // 
            // labelPrice
            // 
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(0, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(300, 37);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTickets
            // 
            this.labelTickets.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTickets.Location = new System.Drawing.Point(151, 41);
            this.labelTickets.Name = "labelTickets";
            this.labelTickets.Size = new System.Drawing.Size(149, 37);
            this.labelTickets.TabIndex = 4;
            this.labelTickets.Text = "Tickets";
            this.labelTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelisActual
            // 
            this.labelisActual.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelisActual.Location = new System.Drawing.Point(0, 41);
            this.labelisActual.Name = "labelisActual";
            this.labelisActual.Size = new System.Drawing.Size(145, 37);
            this.labelisActual.TabIndex = 5;
            this.labelisActual.Text = "isActual";
            this.labelisActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TourOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureTour);
            this.Name = "TourOutput";
            this.Size = new System.Drawing.Size(300, 260);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureTour;
        private Label labelName;
        private Panel panel1;
        private Label labelisActual;
        private Label labelTickets;
        private Label labelPrice;
    }
}
