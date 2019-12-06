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

                var products = order.GetProductList();
                foreach (var product in products)
                {
                    FlowLayoutPanel PanelCurrentProduct = new FlowLayoutPanel();
                    PanelCurrentProduct.Name = "PanelCurrentProduct";
                    PanelCurrentProduct.Size = new System.Drawing.Size(732, 127);

                    Label LabelProductGroup = new Label();
                    LabelProductGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    LabelProductGroup.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
                    LabelProductGroup.Name = "LabelProductGroup";
                    LabelProductGroup.Size = new System.Drawing.Size(339, 24);
                    LabelProductGroup.Text = "Продуктовая группа";
                    PanelCurrentProduct.Controls.Add(LabelProductGroup);

                    Label LabelProductName = new Label();
                    LabelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    LabelProductName.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
                    LabelProductName.Name = "LabelProductName";
                    LabelProductName.Size = new System.Drawing.Size(373, 24);
                    LabelProductName.Text = "Название продукта";
                    PanelCurrentProduct.Controls.Add(LabelProductName);

                    Label LabelCurrentProductGroup = new Label();
                    LabelCurrentProductGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    LabelCurrentProductGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    LabelCurrentProductGroup.Name = "LabelCurrentProductGroup";
                    LabelCurrentProductGroup.Size = new System.Drawing.Size(339, 24);
                    LabelCurrentProductGroup.Text = product.ProductGroup;
                    PanelCurrentProduct.Controls.Add(LabelCurrentProductGroup);

                    Label LabelCurrentProductName = new Label();
                    LabelCurrentProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    LabelCurrentProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    LabelCurrentProductName.Name = "LabelCurrentProductName";
                    LabelCurrentProductName.Size = new System.Drawing.Size(372, 24);
                    LabelCurrentProductName.Text = product.ProductName;
                    PanelCurrentProduct.Controls.Add(LabelCurrentProductName);

                    Label LabelProductPrice = new Label();
                    LabelProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    LabelProductPrice.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
                    LabelProductPrice.Name = "LabelProductPrice";
                    LabelProductPrice.Size = new System.Drawing.Size(339, 24);
                    LabelProductPrice.Text = "Стоимость единицы продукта";
                    PanelCurrentProduct.Controls.Add(LabelProductPrice);

                    Label LabelNumberOfProductInOrder = new Label();
                    LabelNumberOfProductInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    LabelNumberOfProductInOrder.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
                    LabelNumberOfProductInOrder.Name = "LabelNumberOfProductInOrder";
                    LabelNumberOfProductInOrder.Size = new System.Drawing.Size(372, 24);
                    LabelNumberOfProductInOrder.Text = "Количество продукта в заказе";
                    PanelCurrentProduct.Controls.Add(LabelNumberOfProductInOrder);

                    Label LabelCurrentProductPrice = new Label();
                    LabelCurrentProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    LabelCurrentProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    LabelCurrentProductPrice.Name = "LabelCurrentProductPrice";
                    LabelCurrentProductPrice.Size = new System.Drawing.Size(339, 24);
                    LabelCurrentProductPrice.Text = product.Price.ToString() + " рубля(-ей)";
                    PanelCurrentProduct.Controls.Add(LabelCurrentProductPrice);

                    Label LabelCurrentNumberOfProductInOrder = new Label();
                    LabelCurrentNumberOfProductInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    LabelCurrentNumberOfProductInOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    LabelCurrentNumberOfProductInOrder.Name = "LabelCurrentNumberOfProductInOrder";
                    LabelCurrentNumberOfProductInOrder.Size = new System.Drawing.Size(339, 24);
                    LabelCurrentNumberOfProductInOrder.Text = product.Lot.QuantityProduct.ToString();
                    PanelCurrentProduct.Controls.Add(LabelCurrentNumberOfProductInOrder);

                    PanelOfProducts.Controls.Add(PanelCurrentProduct);
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
