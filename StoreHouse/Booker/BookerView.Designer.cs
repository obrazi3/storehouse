namespace View
{
    partial class BookerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonShowNotPaidClientOrders = new System.Windows.Forms.Button();
            this.CheckClientPaymentButton = new System.Windows.Forms.Button();
            this.ButtonShowNotPaidDeliveriesFromProvider = new System.Windows.Forms.Button();
            this.ButtonPayOrderProvider = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.flowLayoutPanel1.Controls.Add(this.ButtonShowNotPaidClientOrders);
            this.flowLayoutPanel1.Controls.Add(this.CheckClientPaymentButton);
            this.flowLayoutPanel1.Controls.Add(this.ButtonShowNotPaidDeliveriesFromProvider);
            this.flowLayoutPanel1.Controls.Add(this.ButtonPayOrderProvider);
            this.flowLayoutPanel1.Controls.Add(this.ButtonExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(223, 635);
            this.flowLayoutPanel1.TabIndex = 0;
            this.ButtonShowNotPaidClientOrders.Location = new System.Drawing.Point(6, 6);
            this.ButtonShowNotPaidClientOrders.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonShowNotPaidClientOrders.Name = "ButtonShowNotPaidClientOrders";
            this.ButtonShowNotPaidClientOrders.Size = new System.Drawing.Size(211, 112);
            this.ButtonShowNotPaidClientOrders.TabIndex = 4;
            this.ButtonShowNotPaidClientOrders.Text = "Просмотреть список неоплаченных платежей клиентов";
            this.ButtonShowNotPaidClientOrders.UseVisualStyleBackColor = true;
            this.CheckClientPaymentButton.Location = new System.Drawing.Point(6, 130);
            this.CheckClientPaymentButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CheckClientPaymentButton.Name = "CheckClientPaymentButton";
            this.CheckClientPaymentButton.Size = new System.Drawing.Size(211, 119);
            this.CheckClientPaymentButton.TabIndex = 0;
            this.CheckClientPaymentButton.Text = "Проверить платеж клиента";
            this.CheckClientPaymentButton.UseVisualStyleBackColor = true;
            this.ButtonShowNotPaidDeliveriesFromProvider.Location = new System.Drawing.Point(6, 261);
            this.ButtonShowNotPaidDeliveriesFromProvider.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonShowNotPaidDeliveriesFromProvider.Name = "ButtonShowNotPaidDeliveriesFromProvider";
            this.ButtonShowNotPaidDeliveriesFromProvider.Size = new System.Drawing.Size(211, 112);
            this.ButtonShowNotPaidDeliveriesFromProvider.TabIndex = 3;
            this.ButtonShowNotPaidDeliveriesFromProvider.Text = "Просмотреть список неоплаченных заказов у поставщика";
            this.ButtonShowNotPaidDeliveriesFromProvider.UseVisualStyleBackColor = true;
            this.ButtonShowNotPaidDeliveriesFromProvider.Click +=
                new System.EventHandler(this.ButtonShowNotPaidDeliveriesFromProviderClick);
            this.ButtonPayOrderProvider.Location = new System.Drawing.Point(6, 385);
            this.ButtonPayOrderProvider.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonPayOrderProvider.Name = "ButtonPayOrderProvider";
            this.ButtonPayOrderProvider.Size = new System.Drawing.Size(211, 119);
            this.ButtonPayOrderProvider.TabIndex = 1;
            this.ButtonPayOrderProvider.Text = "Оплатить заказ у поставщика";
            this.ButtonPayOrderProvider.UseVisualStyleBackColor = true;
            this.ButtonExit.Location = new System.Drawing.Point(6, 516);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(211, 112);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Выйти из Бухгалтера";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.OnButtonExitClick);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 635);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(239, 674);
            this.MinimumSize = new System.Drawing.Size(239, 674);
            this.Name = "BookerView";
            this.Text = "BookerView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CheckClientPaymentButton;
        private System.Windows.Forms.Button ButtonShowNotPaidClientOrders;
        private System.Windows.Forms.Button ButtonShowNotPaidDeliveriesFromProvider;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonPayOrderProvider;
    }
}
