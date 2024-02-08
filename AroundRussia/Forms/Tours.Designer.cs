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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sumLabel = new System.Windows.Forms.Label();
            this.isActualcheckBox = new System.Windows.Forms.CheckBox();
            this.sumLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelo = new System.Windows.Forms.Label();
            this.orderCountLabel = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.buttonHotel = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sumLabel);
            this.panel1.Controls.Add(this.isActualcheckBox);
            this.panel1.Controls.Add(this.sumLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sortComboBox);
            this.panel1.Controls.Add(this.searchLabel);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 113);
            this.panel1.TabIndex = 0;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumLabel.Location = new System.Drawing.Point(771, 36);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(18, 19);
            this.sumLabel.TabIndex = 7;
            this.sumLabel.Text = "0";
            this.sumLabel.TextChanged += new System.EventHandler(this.sumLabel_TextChanged);
            // 
            // isActualcheckBox
            // 
            this.isActualcheckBox.AutoSize = true;
            this.isActualcheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActualcheckBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isActualcheckBox.Location = new System.Drawing.Point(390, 80);
            this.isActualcheckBox.Name = "isActualcheckBox";
            this.isActualcheckBox.Size = new System.Drawing.Size(222, 27);
            this.isActualcheckBox.TabIndex = 5;
            this.isActualcheckBox.Text = "Только актуальные туры";
            this.isActualcheckBox.UseVisualStyleBackColor = true;
            this.isActualcheckBox.CheckedChanged += new System.EventHandler(this.isActualcheckBox_CheckedChanged);
            // 
            // sumLabel1
            // 
            this.sumLabel1.AutoSize = true;
            this.sumLabel1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumLabel1.Location = new System.Drawing.Point(771, 17);
            this.sumLabel1.Name = "sumLabel1";
            this.sumLabel1.Size = new System.Drawing.Size(166, 19);
            this.sumLabel1.TabIndex = 6;
            this.sumLabel1.Text = "Общая стоимость туров";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сортировка по типу";
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(470, 46);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(229, 23);
            this.sortComboBox.TabIndex = 3;
            this.sortComboBox.SelectedValueChanged += new System.EventHandler(this.sortComboBox_SelectedValueChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.Location = new System.Drawing.Point(300, 17);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(65, 23);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Поиск:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(371, 12);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(328, 28);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelo);
            this.panel2.Controls.Add(this.orderCountLabel);
            this.panel2.Controls.Add(this.orderButton);
            this.panel2.Controls.Add(this.buttonHotel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 47);
            this.panel2.TabIndex = 1;
            // 
            // labelo
            // 
            this.labelo.AutoSize = true;
            this.labelo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelo.Location = new System.Drawing.Point(552, 15);
            this.labelo.Name = "labelo";
            this.labelo.Size = new System.Drawing.Size(125, 23);
            this.labelo.TabIndex = 8;
            this.labelo.Text = "Туров в заказе:";
            this.labelo.Click += new System.EventHandler(this.orderCountLabel_Click);
            // 
            // orderCountLabel
            // 
            this.orderCountLabel.AutoSize = true;
            this.orderCountLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderCountLabel.Location = new System.Drawing.Point(679, 15);
            this.orderCountLabel.Name = "orderCountLabel";
            this.orderCountLabel.Size = new System.Drawing.Size(20, 23);
            this.orderCountLabel.TabIndex = 9;
            this.orderCountLabel.Text = "0";
            this.orderCountLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Location = new System.Drawing.Point(713, 6);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(244, 35);
            this.orderButton.TabIndex = 2;
            this.orderButton.Text = "Просмотреть заказ";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // buttonHotel
            // 
            this.buttonHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.buttonHotel.FlatAppearance.BorderSize = 0;
            this.buttonHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHotel.Location = new System.Drawing.Point(3, 6);
            this.buttonHotel.Name = "buttonHotel";
            this.buttonHotel.Size = new System.Drawing.Size(244, 35);
            this.buttonHotel.TabIndex = 1;
            this.buttonHotel.Text = "Открыть отели";
            this.buttonHotel.UseVisualStyleBackColor = false;
            this.buttonHotel.Click += new System.EventHandler(this.buttonHotel_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 113);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(960, 406);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // Tours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 566);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Туры";
            this.Load += new System.EventHandler(this.Tours_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private CheckBox isActualcheckBox;
        private Label label1;
        private ComboBox sortComboBox;
        private Label searchLabel;
        private TextBox searchTextBox;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel;
        private Button buttonHotel;
        private Button orderButton;
        private Label sumLabel1;
        private Label sumLabel;
        private Label labelo;
        private Label orderCountLabel;
    }
}