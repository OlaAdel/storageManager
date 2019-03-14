﻿namespace StorageManager
{
    partial class cStudents
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
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.DimGray;
            this.MinimizeButton.Location = new System.Drawing.Point(515, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(37, 31);
            this.MinimizeButton.TabIndex = 17;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.DimGray;
            this.CloseButton.Location = new System.Drawing.Point(547, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(37, 31);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(496, 415);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(51, 46);
            this.BackButton.TabIndex = 54;
            this.BackButton.Text = "↶";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(66)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(101)))));
            this.AddButton.Location = new System.Drawing.Point(203, 415);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(163, 60);
            this.AddButton.TabIndex = 53;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Data
            // 
            this.Data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn,
            this.AddressColumn});
            this.Data.Location = new System.Drawing.Point(113, 129);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(343, 207);
            this.Data.TabIndex = 52;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            // 
            // cStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StorageManager.Properties.Resources.Home_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cStudents";
            this.Text = "cStudents";
            this.Load += new System.EventHandler(this.cStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;

    }
}