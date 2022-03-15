using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp8.Controllers;

namespace WindowsFormsApp8.Views
{
    public partial class DwarvesView : Form
    {

        dwarfController dwarfController = new dwarfController();

        public DwarvesView()
        {
            InitializeComponent();
        }

        private void DwarvesView_Load(object sender, EventArgs e)
        {
            dgvdwarf.DataSource = dwarfController.GetDwarves();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
