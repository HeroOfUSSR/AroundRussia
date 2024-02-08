namespace AroundRussia.Forms
{
    partial class OrderView
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
            this.labelisActual = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTickets = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countryLabel2 = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureTour
            // 
            this.pictureTour.Image = global::AroundRussia.Properties.Resources.picture;
            this.pictureTour.Location = new System.Drawing.Point(21, 40);
            this.pictureTour.Name = "pictureTour";
            this.pictureTour.Size = new System.Drawing.Size(248, 161);
            this.pictureTour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTour.TabIndex = 4;
            this.pictureTour.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(289, 37);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelisActual
            // 
            this.labelisActual.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelisActual.ForeColor = System.Drawing.Color.Green;
            this.labelisActual.Location = new System.Drawing.Point(21, 375);
            this.labelisActual.Name = "labelisActual";
            this.labelisActual.Size = new System.Drawing.Size(86, 37);
            this.labelisActual.TabIndex = 7;
            this.labelisActual.Text = "Актуален";
            this.labelisActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(0, 204);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(289, 41);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTickets
            // 
            this.labelTickets.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTickets.Location = new System.Drawing.Point(115, 245);
            this.labelTickets.Name = "labelTickets";
            this.labelTickets.Size = new System.Drawing.Size(98, 37);
            this.labelTickets.TabIndex = 10;
            this.labelTickets.Text = "Tickets";
            this.labelTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Билеты:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countryLabel2
            // 
            this.countryLabel2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryLabel2.Location = new System.Drawing.Point(21, 282);
            this.countryLabel2.Name = "countryLabel2";
            this.countryLabel2.Size = new System.Drawing.Size(98, 37);
            this.countryLabel2.TabIndex = 11;
            this.countryLabel2.Text = "Страна:";
            this.countryLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countryLabel
            // 
            this.countryLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryLabel.Location = new System.Drawing.Point(115, 282);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(98, 37);
            this.countryLabel.TabIndex = 12;
            this.countryLabel.Text = "Страна";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descLabel
            // 
            this.descLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descLabel.Location = new System.Drawing.Point(0, 319);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(289, 56);
            this.descLabel.TabIndex = 13;
            this.descLabel.Text = "Описание";
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(194, 384);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(75, 23);
            this.numericUpDown.TabIndex = 14;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.countryLabel2);
            this.Controls.Add(this.labelTickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelisActual);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureTour);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(289, 426);
            this.Load += new System.EventHandler(this.OrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureTour;
        private Label labelName;
        private Label labelisActual;
        private Label labelPrice;
        private Label labelTickets;
        private Label label1;
        private Label countryLabel2;
        private Label countryLabel;
        private Label descLabel;
        private NumericUpDown numericUpDown;
    }
}
