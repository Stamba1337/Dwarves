namespace WindowsFormsApp8.Views
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
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBeardLenght = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBeardLenght = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_UpdateDwarf = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beardLenghtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Id,
            this.beardLenghtDataGridViewTextBoxColumn});
            this.dgvdwarf.DataSource = this.bindingSource1;
            this.dgvdwarf.Location = new System.Drawing.Point(27, 12);
            this.dgvdwarf.Name = "dgvdwarf";
            this.dgvdwarf.Size = new System.Drawing.Size(389, 243);
            this.dgvdwarf.TabIndex = 0;
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
            this.btnAdd.Location = new System.Drawing.Point(463, 157);
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
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtName.Location = new System.Drawing.Point(648, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 38);
            this.txtName.TabIndex = 4;
            // 
            // txtBeardLenght
            // 
            this.txtBeardLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtBeardLenght.Location = new System.Drawing.Point(648, 92);
            this.txtBeardLenght.Name = "txtBeardLenght";
            this.txtBeardLenght.Size = new System.Drawing.Size(100, 38);
            this.txtBeardLenght.TabIndex = 5;
            // 
            // btn_UpdateDwarf
            // 
            this.btn_UpdateDwarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_UpdateDwarf.Location = new System.Drawing.Point(598, 157);
            this.btn_UpdateDwarf.Name = "btn_UpdateDwarf";
            this.btn_UpdateDwarf.Size = new System.Drawing.Size(116, 98);
            this.btn_UpdateDwarf.TabIndex = 6;
            this.btn_UpdateDwarf.Text = "Update Dwarf";
            this.btn_UpdateDwarf.UseVisualStyleBackColor = true;
            this.btn_UpdateDwarf.Click += new System.EventHandler(this.btn_UpdateDwarf_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsApp8.Models.Dwarf);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // beardLenghtDataGridViewTextBoxColumn
            // 
            this.beardLenghtDataGridViewTextBoxColumn.DataPropertyName = "BeardLenght";
            this.beardLenghtDataGridViewTextBoxColumn.HeaderText = "BeardLenght";
            this.beardLenghtDataGridViewTextBoxColumn.Name = "beardLenghtDataGridViewTextBoxColumn";
            // 
            // DwarvesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp8.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_UpdateDwarf);
            this.Controls.Add(this.txtBeardLenght);
            this.Controls.Add(this.txtName);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdwarf;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBeardLenght;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBeardLenght;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_UpdateDwarf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn beardLenghtDataGridViewTextBoxColumn;
    }
}