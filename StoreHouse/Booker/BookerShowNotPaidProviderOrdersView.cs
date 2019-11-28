using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using Presenter;

namespace View
{
    public partial class BookerShowNotPaidProviderOrdersView : Form, IBookerShowNotPaidProviderOrdersView
    {
        public event Action Back;

        private ApplicationContext context;

        public BookerShowNotPaidProviderOrdersView(ApplicationContext _context)
        {
            context = _context;
            InitializeComponent();
        }

        public void Show()
        {
            context.MainForm = this;
            base.Show();
        }

        public void ShowOrders(List<ProductProviderOrder> list)
        {
            foreach (var order in list)
            {
                FlowLayoutPanel PanelCurrentOrder = new FlowLayoutPanel();
                PanelCurrentOrder.AutoScroll = true;
                PanelCurrentOrder.Name = "PanelCurrentOrder";
                PanelCurrentOrder.Size = new System.Drawing.Size(916, 90);

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
                LabelCurrentSum.Text = order.TotalSumOrder.ToString();
                PanelCurrentOrder.Controls.Add(LabelCurrentSum);

                Label LabelOrderDate = new Label();
                LabelOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelOrderDate.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
                LabelOrderDate.Name = "LabelOrderDate";
                LabelOrderDate.Size = new System.Drawing.Size(112, 22);
                LabelOrderDate.TabIndex = 4;
                LabelOrderDate.Text = "Дата заказа:";
                PanelCurrentOrder.Controls.Add(LabelOrderDate);

                Label LabelCurrentOrderDate = new Label();
                LabelCurrentOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelCurrentOrderDate.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
                LabelCurrentOrderDate.Name = "LabelCurrentOrderDate";
                LabelCurrentOrderDate.Size = new System.Drawing.Size(750, 22);
                LabelCurrentOrderDate.TabIndex = 5;
                LabelCurrentOrderDate.Text = order.OrderDate.ToShortDateString();
                PanelCurrentOrder.Controls.Add(LabelCurrentOrderDate);

                PanelNotPaidOrders.Controls.Add(PanelCurrentOrder);
            }
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
