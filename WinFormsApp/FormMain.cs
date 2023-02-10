﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*CONTROLLER
 Added read only DAL object.
 */

namespace WinFormsApp
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly DataAccessLayer _layer;
        public FormMain()
        {
            _layer = new();
            InitializeComponent();
        }

        // RibbonForm2_Load can be removed right?
        private void RibbonForm2_Load(object sender, EventArgs e)
        {

        }

        private void barButtonManageProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManageProducts form = new FormManageProducts();
            form.ShowDialog();
        }

        private void barButtonManageEmployees_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManageEmployees form = new FormManageEmployees();
            form.ShowDialog();
        }

        private void barButtonManageCustomers_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManageCustomers form = new FormManageCustomers();
            form.ShowDialog();
        }

        private void barButtonManageOrders_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManageOrders form = new FormManageOrders();
            form.ShowDialog();
        }

        private void barButtonManageSuppliers_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManageSuppliers form = new FormManageSuppliers();
            form.ShowDialog();
        }
    }
}