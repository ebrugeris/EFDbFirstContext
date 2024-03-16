using EFDbFirstContext.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDbFirstContext.Forms
{
    public partial class FrmFilter : Form
    {
        public FrmFilter()
        {
            InitializeComponent();
        }

        private void FrmFilter_Load(object sender, EventArgs e)
        {
            NorthwndContext db = new NorthwndContext();
            var products = db.Products.ToList();
            dgvProducts.DataSource = products;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            NorthwndContext db = new NorthwndContext();

            int min = Convert.ToInt32(txtMin.Text);
            int max = Convert.ToInt32(txtMax.Text);

            List<Product> productsByUnitPrice = db.Products.Where(x => x.UnitPrice >= min && x.UnitPrice <= max).ToList();
            dgvProducts.DataSource = productsByUnitPrice;
        }
    }
}
