﻿namespace WindowsFormsApp8.Views
{
    partial class DwarvesView
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
            this.dgvdwarf = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beardLenghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBeardLenght = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdwarf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdwarf
            // 
            this.dgvdwarf.AutoGenerateColumns = false;
            this.dgvdwarf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdwarf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.beardLenghtDataGridViewTextBoxColumn});
            this.dgvdwarf.DataSource = this.bindingSource1;
            this.dgvdwarf.Location = new System.Drawing.Point(27, 12);
            this.dgvdwarf.Name = "dgvdwarf";
            this.dgvdwarf.Size = new System.Drawing.Size(389, 243);
            this.dgvdwarf.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // beardLenghtDataGridViewTextBoxColumn
            // 
            this.beardLenghtDataGridViewTextBoxColumn.DataPropertyName = "BeardLenght";
            this.beardLenghtDataGridViewTextBoxColumn.HeaderText = "BeardLenght";
            this.beardLenghtDataGridViewTextBoxColumn.Name = "beardLenghtDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp8.Models.Dwarf);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblName.Location = new System.Drawing.Point(457, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(169, 41);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnAdd.Location = new System.Drawing.Point(644, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 98);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Dwarf";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBeardLenght
            // 
            this.lblBeardLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblBeardLenght.Location = new System.Drawing.Point(457, 92);
            this.lblBeardLenght.Name = "lblBeardLenght";
            this.lblBeardLenght.Size = new System.Drawing.Size(169, 41);
            this.lblBeardLenght.TabIndex = 3;
            this.lblBeardLenght.Text = "BeardLenght";
            this.lblBeardLenght.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DwarvesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp8.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBeardLenght);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvdwarf);
            this.Name = "DwarvesView";
            this.Text = "DwarvesView";
            this.Load += new System.EventHandler(this.DwarvesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdwarf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdwarf;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beardLenghtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBeardLenght;
    }
}