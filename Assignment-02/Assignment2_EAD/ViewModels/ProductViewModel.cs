using Assignment2_EAD.Commands;
using Assignment2_EAD.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Assignment2_EAD.ViewModels
{
    class ProductViewModel:BasicViewModel
    {
        public Products product { get; set; }
        public DelegateCmnd cmd1 { get; set; }
        public DelegateCmnd cmd2 { get; set; }
        public DelegateCmnd cmd3 { get; set; }
        public DelegateCmnd cmd4 { get; set; }
        public DelegateCmnd cmd5 { get; set; }
        public ObservableCollection<Products> productList1 { get; set; }
        public ObservableCollection<Products> productList2 { get; set; }
        public ProductViewModel()
        {
            product = new Products();
            productList1 = new ObservableCollection<Products>();
            productList2 = new ObservableCollection<Products>();
            productList1 = product.DisplayProducts();

            cmd1 = new DelegateCmnd(addProduct, canExecute);
            cmd2 = new DelegateCmnd(deleteProduct, canExecute);
            cmd3 = new DelegateCmnd(addtoCart, canExecute);
          
        }
        private void addProduct(object obj)
        {
            product.addProduct();
        }

        private bool canExecute(object obj)
        {
            return true;
        }

        private void deleteProduct(object obj)
        {
            product.DeleteProduct();
        }
        private void addtoCart(object obj)
        {
            product.DisplayProducts();
        }
        

    }
}
