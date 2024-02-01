namespace AroundRussia.Forms
{
    partial class TourEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TourEdit));
            this.nameLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.ticketsNumeric = new System.Windows.Forms.NumericUpDown();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.isInternationalChecked = new System.Windows.Forms.CheckBox();
            this.isActualChecked = new System.Windows.Forms.CheckBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(34, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costLabel.Location = new System.Drawing.Point(34, 68);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(92, 23);
            this.costLabel.TabIndex = 1;
            this.costLabel.Text = "Стоимость";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountLabel.Location = new System.Drawing.Point(34, 113);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(153, 23);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "Билеты в наличии";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Страна пребывания";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(151, 32);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(254, 30);
            this.nameTextBox.TabIndex = 4;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(151, 68);
            this.costTextBox.Multiline = true;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(254, 30);
            this.costTextBox.TabIndex = 5;
            // 
            // ticketsNumeric
            // 
            this.ticketsNumeric.Location = new System.Drawing.Point(211, 113);
            this.ticketsNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ticketsNumeric.Name = "ticketsNumeric";
            this.ticketsNumeric.Size = new System.Drawing.Size(194, 23);
            this.ticketsNumeric.TabIndex = 6;
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(211, 152);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(194, 23);
            this.countryComboBox.TabIndex = 7;
            // 
            // isInternationalChecked
            // 
            this.isInternationalChecked.AutoSize = true;
            this.isInternationalChecked.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isInternationalChecked.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isInternationalChecked.Location = new System.Drawing.Point(77, 328);
            this.isInternationalChecked.Name = "isInternationalChecked";
            this.isInternationalChecked.Size = new System.Drawing.Size(157, 27);
            this.isInternationalChecked.TabIndex = 8;
            this.isInternationalChecked.Text = "Международный";
            this.isInternationalChecked.UseVisualStyleBackColor = true;
            // 
            // isActualChecked
            // 
            this.isActualChecked.AutoSize = true;
            this.isActualChecked.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActualChecked.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isActualChecked.Location = new System.Drawing.Point(240, 328);
            this.isActualChecked.Name = "isActualChecked";
            this.isActualChecked.Size = new System.Drawing.Size(101, 27);
            this.isActualChecked.TabIndex = 9;
            this.isActualChecked.Text = "Актуален";
            this.isActualChecked.UseVisualStyleBackColor = true;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(211, 194);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(194, 23);
            this.typeComboBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Тип туризма";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(34, 380);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(371, 30);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(34, 416);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(371, 30);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(86)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(34, 452);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(371, 30);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(151, 238);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(254, 69);
            this.descTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Описание";
            // 
            // TourEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isActualChecked);
            this.Controls.Add(this.isInternationalChecked);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.ticketsNumeric);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TourEdit";
            this.Text = "Редактирование туров";
            ((System.ComponentModel.ISupportInitialize)(this.ticketsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Label costLabel;
        private Label amountLabel;
        private Label label1;
        private TextBox nameTextBox;
        private TextBox costTextBox;
        private NumericUpDown ticketsNumeric;
        private ComboBox countryComboBox;
        private CheckBox isInternationalChecked;
        private CheckBox isActualChecked;
        private ComboBox typeComboBox;
        private Label label2;
        private Button addButton;
        private Button cancelButton;
        private Button deleteButton;
        private TextBox descTextBox;
        private Label label3;
    }
}