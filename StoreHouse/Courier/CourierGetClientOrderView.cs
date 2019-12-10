using System;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class CourierGetClientOrderView : Form, ICourierGetOrderView
    {
        public event Action ConfirmDelivery;
        public event Action Back;

        private readonly ApplicationContext _context;

        public CourierGetClientOrderView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public void SetOrderInfo(ClientOrder order)
        {
            if (order != null)
            {
                var clientInfo = order.ClientInfo;
                LabelCurrentSurname.Text = clientInfo.Surname;
                LabelCurrentName.Text = clientInfo.Name;
                LabelCurrentPatronymic.Text = clientInfo.Patronymic;
                LabelCurrentPhoneNumber.Text = clientInfo.PhoneNumber;

                var address = clientInfo.Address;
                LabelCurrentCity.Text = address.City;
                LabelCurrentStreet.Text = address.Street;
                LabelCurrentHouseNumber.Text = address.HomeNumber;
                LabelCurrentPavilion.Text = address.PavilionNumber;
                LabelCurrentPorch.Text = address.PorchNumber;
                LabelCurrentFloor.Text = address.FloorNumber;
                LabelCurrentFlat.Text = address.FlatNumber;

                GroupBoxClientAddress.Visible = true;

                LabelCurrentOrderCost.Text = order.TotalCost.ToString() + " рубля(-ей)";

                var products = order.GetCloneProductList();
                foreach (var product in products)
                {
                    FlowLayoutPanel panelCurrentProduct = new FlowLayoutPanel();
                    panelCurrentProduct.Name = "PanelCurrentProduct";
                    panelCurrentProduct.Size = new System.Drawing.Size(732, 127);

                    Label labelProductGroup = new Label();
                    labelProductGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
                    labelProductGroup.Margin = new Padding(4, 10, 4, 0);
                    labelProductGroup.Name = "LabelProductGroup";
                    labelProductGroup.Size = new System.Drawing.Size(339, 24);
                    labelProductGroup.Text = "Продуктовая группа";
                    panelCurrentProduct.Controls.Add(labelProductGroup);

                    Label labelProductName = new Label();
                    labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
                    labelProductName.Margin = new Padding(4, 10, 4, 0);
                    labelProductName.Name = "LabelProductName";
                    labelProductName.Size = new System.Drawing.Size(373, 24);
                    labelProductName.Text = "Название продукта";
                    panelCurrentProduct.Controls.Add(labelProductName);

                    Label labelCurrentProductGroup = new Label();
                    labelCurrentProductGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
                    labelCurrentProductGroup.Margin = new Padding(4, 0, 4, 0);
                    labelCurrentProductGroup.Name = "LabelCurrentProductGroup";
                    labelCurrentProductGroup.Size = new System.Drawing.Size(339, 24);
                    labelCurrentProductGroup.Text = product.ProductGroup;
                    panelCurrentProduct.Controls.Add(labelCurrentProductGroup);

                    Label labelCurrentProductName = new Label();
                    labelCurrentProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
                    labelCurrentProductName.Margin = new Padding(4, 0, 4, 0);
                    labelCurrentProductName.Name = "LabelCurrentProductName";
                    labelCurrentProductName.Size = new System.Drawing.Size(372, 24);
                    labelCurrentProductName.Text = product.ProductName;
                    panelCurrentProduct.Controls.Add(labelCurrentProductName);

                    Label labelProductPrice = new Label();
                    labelProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
                    labelProductPrice.Margin = new Padding(4, 10, 4, 0);
                    labelProductPrice.Name = "LabelProductPrice";
                    labelProductPrice.Size = new System.Drawing.Size(339, 24);
                    labelProductPrice.Text = "Стоимость единицы продукта";
                    panelCurrentProduct.Controls.Add(labelProductPrice);

                    Label labelNumberOfProductInOrder = new Label();
                    labelNumberOfProductInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
                    labelNumberOfProductInOrder.Margin = new Padding(4, 10, 4, 0);
                    labelNumberOfProductInOrder.Name = "LabelNumberOfProductInOrder";
                    labelNumberOfProductInOrder.Size = new System.Drawing.Size(372, 24);
                    labelNumberOfProductInOrder.Text = "Количество продукта в заказе";
                    panelCurrentProduct.Controls.Add(labelNumberOfProductInOrder);

                    Label labelCurrentProductPrice = new Label();
                    labelCurrentProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
                    labelCurrentProductPrice.Margin = new Padding(4, 0, 4, 0);
                    labelCurrentProductPrice.Name = "LabelCurrentProductPrice";
                    labelCurrentProductPrice.Size = new System.Drawing.Size(339, 24);
                    labelCurrentProductPrice.Text = product.Price.ToString() + " рубля(-ей)";
                    panelCurrentProduct.Controls.Add(labelCurrentProductPrice);

                    Label labelCurrentNumberOfProductInOrder = new Label();
                    labelCurrentNumberOfProductInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
                    labelCurrentNumberOfProductInOrder.Margin = new Padding(4, 0, 4, 0);
                    labelCurrentNumberOfProductInOrder.Name = "LabelCurrentNumberOfProductInOrder";
                    labelCurrentNumberOfProductInOrder.Size = new System.Drawing.Size(339, 24);
                    labelCurrentNumberOfProductInOrder.Text = product.Lot.QuantityProduct.ToString();
                    panelCurrentProduct.Controls.Add(labelCurrentNumberOfProductInOrder);

                    PanelOfProducts.Controls.Add(panelCurrentProduct);
                }

                GroupBoxClientInfoAndOrderInfo.Visible = true;
                LabelListProductsInOrder.Visible = true;
                PanelOfProducts.Visible = true;
            }
            else
            {
                MessageBox.Show(
                    "На данный момент отсутствуют заказы для доставки.",
                    "Заказ не найден");
                GroupBoxClientAddress.Visible = false;
                GroupBoxClientInfoAndOrderInfo.Visible = false;
                PanelOfProducts.Visible = false;
            }
        }

        public void ShowMessageSuccessConfirm()
        {
            GroupBoxClientAddress.Visible = false;
            GroupBoxClientInfoAndOrderInfo.Visible = false;
            LabelListProductsInOrder.Visible = false;
            PanelOfProducts.Visible = false;
            MessageBox.Show("Доставка заказа подтверждена.", "Успешное подтверждение");
        }

        private void OnButtonCancelDeliveryClick(object o, EventArgs e) { Back?.Invoke(); }
        private void OnButtonConfirmDeliveryClick(object o, EventArgs e) { ConfirmDelivery?.Invoke(); }
    }
}
