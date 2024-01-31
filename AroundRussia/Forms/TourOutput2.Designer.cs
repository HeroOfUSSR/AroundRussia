namespace AroundRussia.Forms
{
    partial class TourOutput2
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelisActual = new System.Windows.Forms.Label();
            this.labelTickets = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTour)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureTour
            // 
            this.pictureTour.Image = global::AroundRussia.Properties.Resources.picture;
            this.pictureTour.Location = new System.Drawing.Point(0, 40);
            this.pictureTour.Name = "pictureTour";
            this.pictureTour.Size = new System.Drawing.Size(300, 139);
            this.pictureTour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelisActual);
            this.panel1.Controls.Add(this.labelTickets);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 78);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Билеты:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelisActual
            // 
            this.labelisActual.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelisActual.Location = new System.Drawing.Point(2, 35);
            this.labelisActual.Name = "labelisActual";
            this.labelisActual.Size = new System.Drawing.Size(118, 37);
            this.labelisActual.TabIndex = 5;
            this.labelisActual.Text = "isActual";
            this.labelisActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTickets
            // 
            this.labelTickets.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTickets.Location = new System.Drawing.Point(207, 35);
            this.labelTickets.Name = "labelTickets";
            this.labelTickets.Size = new System.Drawing.Size(92, 37);
            this.labelTickets.TabIndex = 4;
            this.labelTickets.Text = "Tickets";
            this.labelTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(0, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(300, 41);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.editButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(0, 0);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(148, 40);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.addButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(152, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(148, 40);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.editButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 40);
            this.panel2.TabIndex = 3;
            // 
            // TourOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureTour);
            this.Name = "TourOutput";
            this.Size = new System.Drawing.Size(300, 297);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureTour;
        private Label labelName;
        private Panel panel1;
        private Label labelisActual;
        private Label labelTickets;
        private Label labelPrice;
        private Label label1;
        private Button editButton;
        private Button addButton;
        private Panel panel2;
    }
}
