﻿namespace AroundRussia.Forms
{
    partial class Hotels
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotels));
            this.panel1 = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataHotel = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfStars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aroundRussiaContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aroundRussiaContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(810, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 560);
            this.panel1.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Location = new System.Drawing.Point(6, 48);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(257, 30);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(6, 120);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(257, 30);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Закрыть";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(86)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(6, 84);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(257, 30);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(6, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(257, 30);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 100);
            this.panel2.TabIndex = 1;
            // 
            // dataHotel
            // 
            this.dataHotel.AllowUserToAddRows = false;
            this.dataHotel.AllowUserToDeleteRows = false;
            this.dataHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameHotel,
            this.CountOfStars,
            this.DescriptionHotel,
            this.CountryHotel});
            this.dataHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHotel.Location = new System.Drawing.Point(0, 0);
            this.dataHotel.MultiSelect = false;
            this.dataHotel.Name = "dataHotel";
            this.dataHotel.ReadOnly = true;
            this.dataHotel.RowTemplate.Height = 25;
            this.dataHotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHotel.Size = new System.Drawing.Size(810, 460);
            this.dataHotel.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID Отеля";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NameHotel
            // 
            this.NameHotel.DataPropertyName = "Name";
            this.NameHotel.HeaderText = "Название";
            this.NameHotel.Name = "NameHotel";
            this.NameHotel.ReadOnly = true;
            // 
            // CountOfStars
            // 
            this.CountOfStars.DataPropertyName = "CountOfStars";
            this.CountOfStars.HeaderText = "Количество звёзд";
            this.CountOfStars.Name = "CountOfStars";
            this.CountOfStars.ReadOnly = true;
            // 
            // DescriptionHotel
            // 
            this.DescriptionHotel.DataPropertyName = "Description";
            this.DescriptionHotel.HeaderText = "Описание";
            this.DescriptionHotel.Name = "DescriptionHotel";
            this.DescriptionHotel.ReadOnly = true;
            // 
            // CountryHotel
            // 
            this.CountryHotel.DataPropertyName = "CountryCode";
            this.CountryHotel.HeaderText = "Страна";
            this.CountryHotel.Name = "CountryHotel";
            this.CountryHotel.ReadOnly = true;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataSource = typeof(AroundRussia.Models.Hotel);
            // 
            // aroundRussiaContextBindingSource
            // 
            this.aroundRussiaContextBindingSource.DataSource = typeof(AroundRussia.DBContext.AroundRussiaContext);
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 560);
            this.Controls.Add(this.dataHotel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hotels";
            this.Text = "Отели";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aroundRussiaContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataHotel;
        private Button addButton;
        private Button deleteButton;
        private Button cancelButton;
        private BindingSource hotelBindingSource;
        private BindingSource aroundRussiaContextBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameHotel;
        private DataGridViewTextBoxColumn CountOfStars;
        private DataGridViewTextBoxColumn DescriptionHotel;
        private DataGridViewTextBoxColumn CountryHotel;
        private Button editButton;
    }
}