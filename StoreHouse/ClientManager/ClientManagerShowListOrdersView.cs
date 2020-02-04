using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class ClientManagerShowListOrdersView : Form, IClientManagerShowListOrdersView
    {
        public event Action Back;

        private readonly ApplicationContext _context;


        public ClientManagerShowListOrdersView(ApplicationContext context)
        {
            this._context = context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public void SetInformation(List<ClientOrder> orders)
        {
            foreach (var order in orders)
            {
                FlowLayoutPanel panelCurrentOrder = new FlowLayoutPanel();
                panelCurrentOrder.Margin = new Padding(3, 2, 3, 2);
                panelCurrentOrder.Name = "PanelCurrentOrder";
                panelCurrentOrder.Size = new System.Drawing.Size(751, 96);

                Label labelClientName = new Label();
                labelClientName.AutoSize = true;
                labelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
                labelClientName.Margin = new Padding(4, 5, 4, 0);
                labelClientName.Name = "LabelClientName";
                // this.LabelClientName.Size = new System.Drawing.Size(153, 24);
                labelClientName.Text = "Имя покупателя";
                panelCurrentOrder.Controls.Add(labelClientName);

                Label labelCurrentClientName = new Label();
                labelCurrentClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                    System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
                labelCurrentClientName.Margin = new Padding(4, 5, 4, 0);
                labelCurrentClientName.Name = "LabelCurrentClientName";
                labelCurrentClientName.Size = new System.Drawing.Size(574, 30);
                labelCurrentClientName.Text = order.ClientInfo.Surname + " " + order.ClientInfo.Name + " " +
                                              order.ClientInfo.Patronymic;
                panelCurrentOrder.Controls.Add(labelCurrentClientName);

                Label labelOrderNumber = new Label();
                labelOrderNumber.AutoSize = true;
                labelOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
                labelOrderNumber.Margin = new Padding(4, 5, 0, 0);
                labelOrderNumber.Name = "LabelOrderNumber";
                // this.LabelOrderNumber.Size = new System.Drawing.Size(133, 24);
                labelOrderNumber.Text = "Номер заказа";
                panelCurrentOrder.Controls.Add(labelOrderNumber);

                Label labelCurrentOrderNumber = new Label();
                labelCurrentOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                    System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
                labelCurrentOrderNumber.Margin = new Padding(0, 5, 4, 0);
                labelCurrentOrderNumber.Name = "LabelCurrentOrderNumber";
                labelCurrentOrderNumber.Size = new System.Drawing.Size(124, 30);
                labelCurrentOrderNumber.Text = order.OrderId.ToString();
                panelCurrentOrder.Controls.Add(labelCurrentOrderNumber);

                Label labelCost = new Label();
                labelCost.AutoSize = true;
                labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, 204);
                labelCost.Margin = new Padding(4, 5, 0, 0);
                labelCost.Name = "LabelCost";
                // this.LabelCost.Size = new System.Drawing.Size(68, 24);
                labelCost.Text = "Сумма";
                panelCurrentOrder.Controls.Add(labelCost);

                Label labelCurrentCost = new Label();
                labelCurrentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                    System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
                labelCurrentCost.Margin = new Padding(0, 5, 4, 0);
                labelCurrentCost.Name = "LabelCurrentCost";
                labelCurrentCost.Size = new System.Drawing.Size(125, 30);
                labelCurrentCost.Text = order.TotalCost.ToString();
                panelCurrentOrder.Controls.Add(labelCurrentCost);

                Label labelDate = new Label();
                labelDate.AutoSize = true;
                labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, 204);
                labelDate.Margin = new Padding(4, 5, 0, 0);
                labelDate.Name = "LabelDate";
                //this.LabelDate.Size = new System.Drawing.Size(54, 24);
                labelDate.Text = "Дата";
                panelCurrentOrder.Controls.Add(labelDate);

                Label labelCurrentDate = new Label();
                labelCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                    System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
                labelCurrentDate.Margin = new Padding(0, 5, 4, 0);
                labelCurrentDate.Name = "LabelCurrentDate";
                labelCurrentDate.Size = new System.Drawing.Size(142, 30);
                labelCurrentDate.Text = order.OrderDate.ToShortDateString();
                panelCurrentOrder.Controls.Add(labelCurrentDate);


                PanelForOrders.Controls.Add(panelCurrentOrder);
            }
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
