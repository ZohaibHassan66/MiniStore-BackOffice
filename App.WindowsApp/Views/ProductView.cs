using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using App.WindowsApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            var categories = new List<object> { "--ALL--" };
            categories.AddRange (Enum.GetValues(typeof(ProductCategoryEnum)).Cast<object>());
            cmdCategory.DataSource = categories;
            cmdCategory.SelectedIndex = 0;



            cmdStock.Items.Clear();
            var stock = new List<object> { "--ALL--" };
            stock.AddRange(Enum.GetValues(typeof(ProductStatusEnum)).Cast<object>());
            cmdStock.DataSource = stock;
            cmdStock.SelectedIndex = 0;

            if (_service == null)
                return;

            // _service.GetAll();
            _dgvBindingSource.DataSource = _service.GetAll();

        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null, _service);
            prodForm.ShowDialog();

            RefreshGrid();
        }

        private void tbEdit_Click(object sender, EventArgs e)

        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)

            {

                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct, _service);
                prodForm.ShowDialog();

                RefreshGrid();
            }
        }
        private void tbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)

            {

                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct, _service);

                prodForm.ShowDialog();
            }

        }

        private void RefreshGrid()
        {
            string searchText = txtSearch.Text;

            ProductCategoryEnum? selectedCategory = null;
            if(cmdCategory.SelectedItem != null )
            {
                if(cmdCategory.SelectedItem.ToString().Equals("--ALL--"))
                {
                    selectedCategory = null;
                }
                else
                {
                    selectedCategory = (ProductCategoryEnum)cmdCategory.SelectedItem;
                }
            }


            ProductStatusEnum? selectedStatus = null;
            if (cmdStock.SelectedItem != null)
            {
                if (cmdStock.SelectedItem.ToString().Equals("--ALL--"))
                {
                    selectedStatus = null;
                }
                else
                {
                    selectedStatus = (ProductStatusEnum)cmdStock.SelectedItem;
                }
            }



            _dgvBindingSource.DataSource = _service.Search(searchText, selectedCategory, selectedStatus);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        
        private void cmdCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmdStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}

