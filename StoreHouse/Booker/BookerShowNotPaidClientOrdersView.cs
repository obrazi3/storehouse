using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class BookerShowNotPaidClientOrdersView : Form, IBookerShowNotPaidClientOrdersView
    {
        private readonly ApplicationContext _context;

        public event Action Back;

        public BookerShowNotPaidClientOrdersView(ApplicationContext context)
        {
            this._context = context;
            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public void ShowOrders(List<ClientOrder> orders)
        {
            foreach (var order in orders)
            {
                FlowLayoutPanel panelCurrentOrder = new FlowLayoutPanel();
                panelCurrentOrder.AutoScroll = true;
                panelCurrentOrder.Name = "PanelCurrentOrder";
                panelCurrentOrder.Size = new System.Drawing.Size(916, 90);

                Label labelClientName = new Label();
                labelClientName.AutoSize = true;
                labelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                labelClientName.Margin = new Padding(3, 3, 0, 0);
                labelClientName.Name = "LabelClientName";
                labelClientName.TabIndex = 0;
                labelClientName.Text = "Имя заказчика:";
                panelCurrentOrder.Controls.Add(labelClientName);

                Label labelCurrentClientName = new Label();
                //LabelClientName.AutoSize = true;
                labelCurrentClientName.Size = new System.Drawing.Size(700, 22);
                labelCurrentClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                labelCurrentClientName.Margin = new Padding(3, 3, 0, 0);
                labelCurrentClientName.Name = "LabelClientName";
                labelCurrentClientName.TabIndex = 0;
                labelCurrentClientName.Text = order.ClientInfo.Surname + " " + order.ClientInfo.Name + " " +
                                              order.ClientInfo.Patronymic;
                panelCurrentOrder.Controls.Add(labelCurrentClientName);

                Label labelOrderId = new Label();
                labelOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                labelOrderId.Margin = new Padding(3, 3, 0, 0);
                labelOrderId.Name = "LabelOrderId";
                labelOrderId.Size = new System.Drawing.Size(112, 22);
                labelOrderId.TabIndex = 0;
                labelOrderId.Text = "Номер заказа:";
                panelCurrentOrder.Controls.Add(labelOrderId);

                Label labelCurrentOrderId = new Label();
                labelCurrentOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                labelCurrentOrderId.Margin = new Padding(3, 3, 0, 0);
                labelCurrentOrderId.Name = "LabelCurrentOrderId";
                labelCurrentOrderId.Size = new System.Drawing.Size(750, 22);
                labelCurrentOrderId.TabIndex = 1;
                labelCurrentOrderId.Text = order.OrderId.ToString();
                panelCurrentOrder.Controls.Add(labelCurrentOrderId);

                Label labelSum = new Label();
                labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                labelSum.Margin = new Padding(3, 3, 0, 0);
                labelSum.Name = "LabelSum";
                labelSum.Size = new System.Drawing.Size(112, 22);
                labelSum.TabIndex = 2;
                labelSum.Text = "Cумма:";
                panelCurrentOrder.Controls.Add(labelSum);

                Label labelCurrentSum = new Label();
                labelCurrentSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                labelCurrentSum.Margin = new Padding(3, 3, 0, 0);
                labelCurrentSum.Name = "LabelCurrentSum";
                labelCurrentSum.Size = new System.Drawing.Size(750, 22);
                labelCurrentSum.TabIndex = 3;
                labelCurrentSum.Text = order.TotalCost.ToString();
                panelCurrentOrder.Controls.Add(labelCurrentSum);

                PanelNotPaidOrders.Controls.Add(panelCurrentOrder);
            }
        }


        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
