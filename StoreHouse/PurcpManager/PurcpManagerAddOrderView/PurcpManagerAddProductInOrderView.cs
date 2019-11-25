using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class PurcpManagerAddProductInOrderView : Form, IPurcpManagerAddProductInOrderView
    {
        public event Action Back;
        public event Action AddProduct;

        public PurcpManagerAddProductInOrderView()
        {
            InitializeComponent();
        }


        public new void Show()
        {
            //TO-DO
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnButtonAddProductClick(object o, EventArgs e)
        {
            //TO-DO
        }
    }
}
