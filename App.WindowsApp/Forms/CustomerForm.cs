using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class CustomerForm : Form
    {
        private ICustomerService _customerService;
        private CustomerFormModeEnum _mode;
        private Customer _customer;
        public CustomerForm(ICustomerService customerService, CustomerFormModeEnum mode, Customer customer = null)
        {
            InitializeComponent();
            _customerService = customerService;
            _mode = mode;
            _customer = customer ?? new Customer();

            PopulateFields();
            SetupMode();
        }

        private void PopulateFields()
        {
            txtName.Text = _customer.Name;
            txtPhone.Text = _customer.Phone;
            txtEmail.Text = _customer.Email;
            txtAddress.Text = _customer.Address;
            txtId.Text = _customer.Id;
        }
        private void SetupMode()
        {
            switch (_mode)
            {
                case CustomerFormModeEnum.Add:
                    this.Text = "AddCustomer";
                    lblId.Visible = false;
                    txtId.Visible = false;
                    break;
                case CustomerFormModeEnum.Edit:
                    this.Text = "Edit Customer";
                    break;
                case CustomerFormModeEnum.View:
                    this.Text = "View Customer";
                    txtId.ReadOnly = true;
                    txtName.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    btnSave.Visible = false;
                    break;

            }
        }


        private bool validateData()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Nmae cannot be empty", "Validating data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone cannot be empty", "Validating data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateData())
                {
                    _customer.Name = txtName.Text;
                    _customer.Phone = txtPhone.Text;
                    _customer.Email = txtEmail.Text;
                    _customer.Address = txtAddress.Text;

                    if (_mode == CustomerFormModeEnum.Add)
                    {
                        _customerService.Add(_customer);
                    }
                    else
                    {
                        _customerService.Update(_customer);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Saving customer:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close ();
        }
    }
}
