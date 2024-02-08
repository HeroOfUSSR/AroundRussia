namespace AroundRussia.Forms
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.pickPointLabel = new System.Windows.Forms.Label();
            this.pickComboBox = new System.Windows.Forms.ComboBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(762, 575);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonOrder);
            this.panel2.Controls.Add(this.pickPointLabel);
            this.panel2.Controls.Add(this.pickComboBox);
            this.panel2.Controls.Add(this.labelCost);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 128);
            this.panel2.TabIndex = 2;
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Location = new System.Drawing.Point(129, 86);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(505, 30);
            this.buttonOrder.TabIndex = 9;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // pickPointLabel
            // 
            this.pickPointLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pickPointLabel.Location = new System.Drawing.Point(0, 32);
            this.pickPointLabel.Name = "pickPointLabel";
            this.pickPointLabel.Size = new System.Drawing.Size(409, 37);
            this.pickPointLabel.TabIndex = 8;
            this.pickPointLabel.Text = "Выберите пункт выдачи:";
            this.pickPointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pickComboBox
            // 
            this.pickComboBox.FormattingEnabled = true;
            this.pickComboBox.Location = new System.Drawing.Point(415, 40);
            this.pickComboBox.Name = "pickComboBox";
            this.pickComboBox.Size = new System.Drawing.Size(315, 23);
            this.pickComboBox.TabIndex = 7;
            // 
            // labelCost
            // 
            this.labelCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCost.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCost.Location = new System.Drawing.Point(0, 0);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(762, 37);
            this.labelCost.TabIndex = 6;
            this.labelCost.Text = "Сумма заказа";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orders";
            this.Text = "Просмотр заказа";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label labelCost;
        private Label pickPointLabel;
        private ComboBox pickComboBox;
        private Button buttonOrder;
    }
}