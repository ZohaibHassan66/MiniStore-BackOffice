using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App.Core.Models;






using App.Core.Contracts;
using App.Core.Utilities;
using App.WindowsApp.Forms;

namespace App.WindowsApp.Views

{
    public partial class ProductView : UserControl
    {
        BindingSource _dgvBindingSource = new BindingSource();
        //private IProductService service;
        private readonly IProductService _service;
        public ProductView(IProductService service)
        {
            _service = service;
            InitializeComponent();

            dgvProducts.DataSource = _dgvBindingSource;
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            cmdCategory.Items.Clear();
            cmdCategory.Items.Add("--All--");
            cmdCategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmdCategory.SelectedIndex = 0;

            cmdStock.Items.Clear();
            cmdStock.Items.Add("--All--");
            cmdStock.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmdStock.SelectedIndex = 0;

            if (_service == null)
                return;

            _service.GetAll();
            _dgvBindingSource.DataSource = _service.GetAll();

        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null);
            prodForm.ShowDialog();
        }

        private void tbEdit_Click(object sender, EventArgs e)

        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)

            {

                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct);
                prodForm.ShowDialog();
            }
        }
        private void tbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)

            {

                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct);
                prodForm.ShowDialog();
            }

        }
    }
}
