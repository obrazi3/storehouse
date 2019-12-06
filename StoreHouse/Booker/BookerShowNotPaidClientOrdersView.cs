using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class BookerShowNotPaidClientOrdersView : Form, IBookerShowNotPaidClientOrdersView
    {
        private readonly ApplicationContext context;

        public event Action Back;

        public BookerShowNotPaidClientOrdersView(ApplicationContext _context)
        {
            context = _context;
            InitializeComponent();
        }

        public new void Show()
        {
            context.MainForm = this;
            base.Show();
        }

        public void ShowOrders(List<ClientOrder> orders)
        {
            foreach (var order in orders)
            {
                FlowLayoutPanel PanelCurrentOrder = new FlowLayoutPanel();
                PanelCurrentOrder.AutoScroll = true;
                PanelCurrentOrder.Name = "PanelCurrentOrder";
                PanelCurrentOrder.Size = new System.Drawing.Size(916, 90);

                Label LabelClientName = new Label();
                LabelClientName.AutoSize = true;
                LabelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelClientName.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
                LabelClientName.Name = "LabelClientName";
                LabelClientName.TabIndex = 0;
                LabelClientName.Text = "Имя заказчика:";
                PanelCurrentOrder.Controls.Add(LabelClientName);

                Label LabelCurrentClientName = new Label();
                //LabelClientName.AutoSize = true;
                LabelCurrentClientName.Size = new System.Drawing.Size(700, 22);
                LabelCurrentClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelCurrentClientName.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
                LabelCurrentClientName.Name = "LabelClientName";
                LabelCurrentClientName.TabIndex = 0;
                LabelCurrentClientName.Text = order.ClientInfo.Surname + " " + order.ClientInfo.Name + " " +
                                              order.ClientInfo.Patronymic;
                PanelCurrentOrder.Controls.Add(LabelCurrentClientName);

                Label LabelOrderId = new Label();
                LabelOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelOrderId.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
                LabelOrderId.Name = "LabelOrderId";
                LabelOrderId.Size = new System.Drawing.Size(112, 22);
                LabelOrderId.TabIndex = 0;
                LabelOrderId.Text = "Номер заказа:";
                PanelCurrentOrder.Controls.Add(LabelOrderId);

                Label LabelCurrentOrderId = new Label();
                LabelCurrentOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelCurrentOrderId.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
                LabelCurrentOrderId.Name = "LabelCurrentOrderId";
                LabelCurrentOrderId.Size = new System.Drawing.Size(750, 22);
                LabelCurrentOrderId.TabIndex = 1;
                LabelCurrentOrderId.Text = order.OrderId.ToString();
                PanelCurrentOrder.Controls.Add(LabelCurrentOrderId);

                Label LabelSum = new Label();
                LabelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelSum.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
                LabelSum.Name = "LabelSum";
                LabelSum.Size = new System.Drawing.Size(112, 22);
                LabelSum.TabIndex = 2;
                LabelSum.Text = "Cумма:";
                PanelCurrentOrder.Controls.Add(LabelSum);

                Label LabelCurrentSum = new Label();
                LabelCurrentSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelCurrentSum.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
                LabelCurrentSum.Name = "LabelCurrentSum";
                LabelCurrentSum.Size = new System.Drawing.Size(750, 22);
                LabelCurrentSum.TabIndex = 3;
                LabelCurrentSum.Text = order.TotalCost.ToString();
                PanelCurrentOrder.Controls.Add(LabelCurrentSum);

                PanelNotPaidOrders.Controls.Add(PanelCurrentOrder);
            }
        }


        private void OnButtonBackClick(object o, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
