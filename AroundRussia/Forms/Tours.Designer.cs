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
            this.isActualcheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.isActualcheckBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.searchLabel);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 113);
            this.panel1.TabIndex = 0;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(331, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(410, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.Location = new System.Drawing.Point(331, 17);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(65, 23);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Поиск:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(410, 12);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(229, 28);
            this.searchTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 44);
            this.panel2.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(3, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(244, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить туры";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 113);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(960, 402);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // Tours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 559);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private CheckBox isActualcheckBox;
        private Label label1;
        private ComboBox comboBox1;
        private Label searchLabel;
        private TextBox searchTextBox;
        private Panel panel2;
        private Button addButton;
        private FlowLayoutPanel flowLayoutPanel;
    }
}