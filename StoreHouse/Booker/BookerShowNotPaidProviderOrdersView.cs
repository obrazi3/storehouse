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

                Label LabelBankAccount = new Label();
                LabelBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelBankAccount.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
                LabelBankAccount.Name = "LabelOrderDate";
                LabelBankAccount.Size = new System.Drawing.Size(140, 22);
                LabelBankAccount.TabIndex = 4;
                LabelBankAccount.Text = "Банковский счёт:";
                PanelCurrentOrder.Controls.Add(LabelBankAccount);

                Label LabelCurrentBankAccount = new Label();
                LabelCurrentBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                LabelCurrentBankAccount.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
                LabelCurrentBankAccount.Name = "LabelCurrentOrderDate";
                LabelCurrentBankAccount.Size = new System.Drawing.Size(722, 22);
                LabelCurrentBankAccount.TabIndex = 5;
                LabelCurrentBankAccount.Text = order.Provider.BankAccountNumber;
                PanelCurrentOrder.Controls.Add(LabelCurrentBankAccount);

                PanelNotPaidOrders.Controls.Add(PanelCurrentOrder);
            }
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
