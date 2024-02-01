namespace AroundRussia.Forms
{
    partial class TourView
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
            this.labelName = new System.Windows.Forms.Label();
            this.pictureTour = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTickets = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelisActual = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(302, 37);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureTour
            // 
            this.pictureTour.Image = global::AroundRussia.Properties.Resources.picture;
            this.pictureTour.Location = new System.Drawing.Point(26, 38);
            this.pictureTour.Name = "pictureTour";
            this.pictureTour.Size = new System.Drawing.Size(248, 161);
            this.pictureTour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTour.TabIndex = 3;
            this.pictureTour.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelTickets);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelisActual);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Location = new System.Drawing.Point(0, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 79);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 39);
            this.panel2.TabIndex = 5;
            // 
            // labelTickets
            // 
            this.labelTickets.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTickets.Location = new System.Drawing.Point(208, 42);
            this.labelTickets.Name = "labelTickets";
            this.labelTickets.Size = new System.Drawing.Size(92, 37);
            this.labelTickets.TabIndex = 8;
            this.labelTickets.Text = "Tickets";
            this.labelTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Билеты:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelisActual
            // 
            this.labelisActual.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelisActual.Location = new System.Drawing.Point(0, 42);
            this.labelisActual.Name = "labelisActual";
            this.labelisActual.Size = new System.Drawing.Size(118, 37);
            this.labelisActual.TabIndex = 6;
            this.labelisActual.Text = "isActual";
            this.labelisActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(0, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(300, 41);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(169, 278);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 40);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(26, 278);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(111, 40);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click_1);
            // 
            // TourView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureTour);
            this.Controls.Add(this.labelName);
            this.Name = "TourView";
            this.Size = new System.Drawing.Size(302, 318);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelName;
        private PictureBox pictureTour;
        private Panel panel1;
        private Label labelPrice;
        private Label labelisActual;
        private Label label1;
        private Label labelTickets;
        private Panel panel2;
        private Button addButton;
        private Button editButton;
    }
}
