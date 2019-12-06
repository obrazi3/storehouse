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

        private readonly ApplicationContext context;


        public ClientManagerShowListOrdersView(ApplicationContext _context)
        {
            context = _context;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public new void Show()
        {
            context.MainForm = this;
            base.Show();
        }

        public void SetInformation(List<ClientOrder> orders)
        {
            foreach (var order in orders)
            {
                FlowLayoutPanel PanelCurrentOrder = new FlowLayoutPanel();
                PanelCurrentOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                PanelCurrentOrder.Name = "PanelCurrentOrder";
                PanelCurrentOrder.Size = new System.Drawing.Size(751, 96);

                Label LabelClientName = new Label();
                LabelClientName.AutoSize = true;
                LabelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelClientName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
                LabelClientName.Name = "LabelClientName";
                // this.LabelClientName.Size = new System.Drawing.Size(153, 24);
                LabelClientName.Text = "Имя покупателя";
                PanelCurrentOrder.Controls.Add(LabelClientName);

                Label LabelCurrentClientName = new Label();
                LabelCurrentClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                    System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelCurrentClientName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
                LabelCurrentClientName.Name = "LabelCurrentClientName";
                LabelCurrentClientName.Size = new System.Drawing.Size(574, 30);
                LabelCurrentClientName.Text = order.ClientInfo.Surname + " " + order.ClientInfo.Name + " " +
                                              order.ClientInfo.Patronymic;
                PanelCurrentOrder.Controls.Add(LabelCurrentClientName);

                Label LabelOrderNumber = new Label();
                LabelOrderNumber.AutoSize = true;
                LabelOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelOrderNumber.Margin = new System.Windows.Forms.Padding(4, 5, 0, 0);
                LabelOrderNumber.Name = "LabelOrderNumber";
                // this.LabelOrderNumber.Size = new System.Drawing.Size(133, 24);
                LabelOrderNumber.Text = "Номер заказа";
                PanelCurrentOrder.Controls.Add(LabelOrderNumber);

                Label LabelCurrentOrderNumber = new Label();
                LabelCurrentOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                    System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelCurrentOrderNumber.Margin = new System.Windows.Forms.Padding(0, 5, 4, 0);
                LabelCurrentOrderNumber.Name = "LabelCurrentOrderNumber";
                LabelCurrentOrderNumber.Size = new System.Drawing.Size(124, 30);
                LabelCurrentOrderNumber.Text = order.OrderId.ToString();
                PanelCurrentOrder.Controls.Add(LabelCurrentOrderNumber);

                Label LabelCost = new Label();
                LabelCost.AutoSize = true;
                LabelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelCost.Margin = new System.Windows.Forms.Padding(4, 5, 0, 0);
                LabelCost.Name = "LabelCost";
                // this.LabelCost.Size = new System.Drawing.Size(68, 24);
                LabelCost.Text = "Сумма";
                PanelCurrentOrder.Controls.Add(LabelCost);

                Label LabelCurrentCost = new Label();
                LabelCurrentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                    System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelCurrentCost.Margin = new System.Windows.Forms.Padding(0, 5, 4, 0);
                LabelCurrentCost.Name = "LabelCurrentCost";
                LabelCurrentCost.Size = new System.Drawing.Size(125, 30);
                LabelCurrentCost.Text = order.TotalCost.ToString();
                PanelCurrentOrder.Controls.Add(LabelCurrentCost);

                Label LabelDate = new Label();
                LabelDate.AutoSize = true;
                LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelDate.Margin = new System.Windows.Forms.Padding(4, 5, 0, 0);
                LabelDate.Name = "LabelDate";
                //this.LabelDate.Size = new System.Drawing.Size(54, 24);
                LabelDate.Text = "Дата";
                PanelCurrentOrder.Controls.Add(LabelDate);

                Label LabelCurrentDate = new Label();
                LabelCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                    System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                LabelCurrentDate.Margin = new System.Windows.Forms.Padding(0, 5, 4, 0);
                LabelCurrentDate.Name = "LabelCurrentDate";
                LabelCurrentDate.Size = new System.Drawing.Size(142, 30);
                LabelCurrentDate.Text = order.OrderDate.ToShortDateString();
                PanelCurrentOrder.Controls.Add(LabelCurrentDate);


                PanelForOrders.Controls.Add(PanelCurrentOrder);
            }
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
