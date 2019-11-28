using System;
using System.Windows.Forms;
using Presenter;

namespace View
{
    public partial class PurcpManagerAddOrderSecondStepView : Form, IPurcpManagerAddOrderSecondStepView
    {
        public event Action Back;
        public event Action ConfirmOrder;
        public event Action AddProduct;

        private readonly ApplicationContext context;
        private int numberProducts;

        public PurcpManagerAddOrderSecondStepView(ApplicationContext _context)
        {
            context = _context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            numberProducts = 0;
        }


        public void SetNumberProductsInOrder(int number)
        {
            numberProducts = number;
            LabelNumberOfProductInDelivery.Text += number.ToString();
        }

        public new void Show()
        {
            context.MainForm = this;
            base.Show();
        }

        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        private void OnButtonConfirmOrderClick(object o, EventArgs e)
        {
            LabelMessageNotEnoughProducts.Visible = false;
            if (CheckNumberProducts())
                ConfirmOrder?.Invoke();
            else
                LabelMessageNotEnoughProducts.Visible = true;
        }

        private void OnButtonAddProductClick(object o, EventArgs e)
        {
            AddProduct?.Invoke();
        }

        private bool CheckNumberProducts()
        {
            if (numberProducts == 0)
                return false;

            return true;
        }
    }
}
