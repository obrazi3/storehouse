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

        private readonly ApplicationContext _context;
        private int _numberProducts;

        public PurcpManagerAddOrderSecondStepView(ApplicationContext context)
        {
            this._context = context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _numberProducts = 0;
        }


        public void SetNumberProductsInOrder(int number)
        {
            _numberProducts = number;
            LabelNumberOfProductInDelivery.Text += number.ToString();
        }

        public new void Show()
        {
            _context.MainForm = this;
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
            if (_numberProducts == 0)
                return false;

            return true;
        }
    }
}
