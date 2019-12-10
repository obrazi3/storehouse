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

        private ApplicationContext _context;

        public BookerShowNotPaidProviderOrdersView(ApplicationContext context)
        {
            this._context = context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        public void ShowOrders(List<ProductProviderOrder> list)
        {
            foreach (var order in list)
            {
                FlowLayoutPanel panelCurrentOrder = new FlowLayoutPanel();
                panelCurrentOrder.AutoScroll = true;
                panelCurrentOrder.Name = "PanelCurrentOrder";
                panelCurrentOrder.Size = new System.Drawing.Size(916, 90);

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
                labelCurrentSum.Text = order.TotalSumOrder.ToString();
                panelCurrentOrder.Controls.Add(labelCurrentSum);

                Label labelBankAccount = new Label();
                labelBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                labelBankAccount.Margin = new Padding(3, 3, 0, 0);
                labelBankAccount.Name = "LabelOrderDate";
                labelBankAccount.Size = new System.Drawing.Size(140, 22);
                labelBankAccount.TabIndex = 4;
                labelBankAccount.Text = "Банковский счёт:";
                panelCurrentOrder.Controls.Add(labelBankAccount);

                Label labelCurrentBankAccount = new Label();
                labelCurrentBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
                labelCurrentBankAccount.Margin = new Padding(3, 3, 0, 0);
                labelCurrentBankAccount.Name = "LabelCurrentOrderDate";
                labelCurrentBankAccount.Size = new System.Drawing.Size(722, 22);
                labelCurrentBankAccount.TabIndex = 5;
                labelCurrentBankAccount.Text = order.Provider.BankAccountNumber;
                panelCurrentOrder.Controls.Add(labelCurrentBankAccount);

                PanelNotPaidOrders.Controls.Add(panelCurrentOrder);
            }
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
