﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.Controllers;
using WindowsFormsApp8.Models;

namespace WindowsFormsApp8.Views
{
    public partial class DwarvesView : Form
    {

        dwarfController dwarfController = new dwarfController();

        public DwarvesView()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            dgvdwarf.DataSource = dwarfController.GetDwarves();
        }
        private void DwarvesView_Load(object sender, EventArgs e)
        {
            dgvdwarf.DataSource = dwarfController.GetDwarves();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dwarf dwarf = new Dwarf();
            dwarf.Name = txtName.Text;
            dwarf.BeardLenght = int.Parse(txtBeardLenght.Text);
            dwarfController.CreateDwarf(dwarf);
            RefreshTable();
        }

        private void btn_UpdateDwarf_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvdwarf.CurrentRow;
            int id = int.Parse(row.Cells["Id"].Value.ToString());
            Dwarf d = new Dwarf();
            d.Id = id;
            d.Name = txtName.Text;
            d.BeardLenght = int.Parse(txtBeardLenght.Text);
            dwarfController.UpdateDwarf(id, d);
            RefreshTable();


        }
    }
}
