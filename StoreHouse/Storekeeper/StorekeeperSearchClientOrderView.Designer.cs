using System;

namespace View
{
    partial class StorekeeperSearchClientOrderView
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
            this.PanelMainContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelHead = new System.Windows.Forms.Panel();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxOrderNumber = new System.Windows.Forms.MaskedTextBox();
            this.LabelMessageInput = new System.Windows.Forms.Label();
            this.GroupBoxClientInfo = new System.Windows.Forms.GroupBox();
            this.LabelCurrentWayToReceiveOrder = new System.Windows.Forms.Label();
            this.LabelWayToReceiveOrder = new System.Windows.Forms.Label();
            this.LabelCurrentPhoneNumber = new System.Windows.Forms.Label();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.LabelCurrentPatronymic = new System.Windows.Forms.Label();
            this.LabelCurrentName = new System.Windows.Forms.Label();
            this.LabelCurrentSurname = new System.Windows.Forms.Label();
            this.LabelPatronymic = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.GroupBoxGeneralOrderInfo = new System.Windows.Forms.GroupBox();
            this.LabelCurrentOrderCost = new System.Windows.Forms.Label();
            this.LabelOrderCost = new System.Windows.Forms.Label();
            this.LabelCurrentOrderDate = new System.Windows.Forms.Label();
            this.LabelOrderDate = new System.Windows.Forms.Label();
            this.LabelListProductsInOrder = new System.Windows.Forms.Label();
            this.PanelOfProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelSecondaryButtons = new System.Windows.Forms.Panel();
            this.ButtonConfirmGiveOut = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.PanelHead.SuspendLayout();
            this.GroupBoxClientInfo.SuspendLayout();
            this.GroupBoxGeneralOrderInfo.SuspendLayout();
            this.PanelSecondaryButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainContainer
            // 
            this.PanelMainContainer.Controls.Add(this.PanelHead);
            this.PanelMainContainer.Controls.Add(this.GroupBoxClientInfo);
            this.PanelMainContainer.Controls.Add(this.GroupBoxGeneralOrderInfo);
            this.PanelMainContainer.Controls.Add(this.LabelListProductsInOrder);
            this.PanelMainContainer.Controls.Add(this.PanelOfProducts);
            this.PanelMainContainer.Location = new System.Drawing.Point(3, 5);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(894, 670);
            this.PanelMainContainer.TabIndex = 0;
            // 
            // PanelHead
            // 
            this.PanelHead.Controls.Add(this.ButtonSearch);
            this.PanelHead.Controls.Add(this.TextBoxOrderNumber);
            this.PanelHead.Controls.Add(this.LabelMessageInput);
            this.PanelHead.Location = new System.Drawing.Point(3, 4);
            this.PanelHead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(882, 68);
            this.PanelHead.TabIndex = 1;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSearch.Location = new System.Drawing.Point(739, 6);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(135, 49);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Поиск";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.OnButtonSearchClientOrderClick);
            // 
            // TextBoxOrderNumber
            // 
            this.TextBoxOrderNumber.Location = new System.Drawing.Point(233, 19);
            this.TextBoxOrderNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxOrderNumber.Mask = "00000";
            this.TextBoxOrderNumber.Name = "TextBoxOrderNumber";
            this.TextBoxOrderNumber.Size = new System.Drawing.Size(494, 24);
            this.TextBoxOrderNumber.TabIndex = 1;
            this.TextBoxOrderNumber.ValidatingType = typeof(int);
            // 
            // LabelMessageInput
            // 
            this.LabelMessageInput.AutoSize = true;
            this.LabelMessageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessageInput.Location = new System.Drawing.Point(3, 19);
            this.LabelMessageInput.Name = "LabelMessageInput";
            this.LabelMessageInput.Size = new System.Drawing.Size(224, 24);
            this.LabelMessageInput.TabIndex = 0;
            this.LabelMessageInput.Text = "Введите номер заказа: ";
            // 
            // GroupBoxClientInfo
            // 
            this.GroupBoxClientInfo.Controls.Add(this.LabelCurrentWayToReceiveOrder);
            this.GroupBoxClientInfo.Controls.Add(this.LabelWayToReceiveOrder);
            this.GroupBoxClientInfo.Controls.Add(this.LabelCurrentPhoneNumber);
            this.GroupBoxClientInfo.Controls.Add(this.LabelPhoneNumber);
            this.GroupBoxClientInfo.Controls.Add(this.LabelCurrentPatronymic);
            this.GroupBoxClientInfo.Controls.Add(this.LabelCurrentName);
            this.GroupBoxClientInfo.Controls.Add(this.LabelCurrentSurname);
            this.GroupBoxClientInfo.Controls.Add(this.LabelPatronymic);
            this.GroupBoxClientInfo.Controls.Add(this.LabelName);
            this.GroupBoxClientInfo.Controls.Add(this.LabelSurname);
            this.GroupBoxClientInfo.Location = new System.Drawing.Point(3, 80);
            this.GroupBoxClientInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxClientInfo.Name = "GroupBoxClientInfo";
            this.GroupBoxClientInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxClientInfo.Size = new System.Drawing.Size(882, 156);
            this.GroupBoxClientInfo.TabIndex = 2;
            this.GroupBoxClientInfo.TabStop = false;
            this.GroupBoxClientInfo.Text = "Информация о заказчике";
            this.GroupBoxClientInfo.Visible = false;
            // 
            // LabelCurrentWayToReceiveOrder
            // 
            this.LabelCurrentWayToReceiveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentWayToReceiveOrder.Location = new System.Drawing.Point(277, 120);
            this.LabelCurrentWayToReceiveOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentWayToReceiveOrder.Name = "LabelCurrentWayToReceiveOrder";
            this.LabelCurrentWayToReceiveOrder.Size = new System.Drawing.Size(217, 30);
            this.LabelCurrentWayToReceiveOrder.TabIndex = 14;
            this.LabelCurrentWayToReceiveOrder.Text = "Фамилия";
            // 
            // LabelWayToReceiveOrder
            // 
            this.LabelWayToReceiveOrder.AutoSize = true;
            this.LabelWayToReceiveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelWayToReceiveOrder.Location = new System.Drawing.Point(277, 89);
            this.LabelWayToReceiveOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWayToReceiveOrder.Name = "LabelWayToReceiveOrder";
            this.LabelWayToReceiveOrder.Size = new System.Drawing.Size(240, 24);
            this.LabelWayToReceiveOrder.TabIndex = 13;
            this.LabelWayToReceiveOrder.Text = "Способ получения заказа";
            // 
            // LabelCurrentPhoneNumber
            // 
            this.LabelCurrentPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentPhoneNumber.Location = new System.Drawing.Point(10, 120);
            this.LabelCurrentPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentPhoneNumber.Name = "LabelCurrentPhoneNumber";
            this.LabelCurrentPhoneNumber.Size = new System.Drawing.Size(217, 30);
            this.LabelCurrentPhoneNumber.TabIndex = 12;
            this.LabelCurrentPhoneNumber.Text = "Фамилия";
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.AutoSize = true;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPhoneNumber.Location = new System.Drawing.Point(7, 89);
            this.LabelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(198, 24);
            this.LabelPhoneNumber.TabIndex = 11;
            this.LabelPhoneNumber.Text = "Мобильный телефон";
            // 
            // LabelCurrentPatronymic
            // 
            this.LabelCurrentPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentPatronymic.Location = new System.Drawing.Point(510, 45);
            this.LabelCurrentPatronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentPatronymic.Name = "LabelCurrentPatronymic";
            this.LabelCurrentPatronymic.Size = new System.Drawing.Size(217, 30);
            this.LabelCurrentPatronymic.TabIndex = 10;
            this.LabelCurrentPatronymic.Text = "Фамилия";
            // 
            // LabelCurrentName
            // 
            this.LabelCurrentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentName.Location = new System.Drawing.Point(277, 45);
            this.LabelCurrentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentName.Name = "LabelCurrentName";
            this.LabelCurrentName.Size = new System.Drawing.Size(217, 30);
            this.LabelCurrentName.TabIndex = 9;
            this.LabelCurrentName.Text = "Фамилия";
            // 
            // LabelCurrentSurname
            // 
            this.LabelCurrentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentSurname.Location = new System.Drawing.Point(3, 45);
            this.LabelCurrentSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentSurname.Name = "LabelCurrentSurname";
            this.LabelCurrentSurname.Size = new System.Drawing.Size(217, 30);
            this.LabelCurrentSurname.TabIndex = 8;
            this.LabelCurrentSurname.Text = "Фамилия";
            // 
            // LabelPatronymic
            // 
            this.LabelPatronymic.AutoSize = true;
            this.LabelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPatronymic.Location = new System.Drawing.Point(510, 21);
            this.LabelPatronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPatronymic.Name = "LabelPatronymic";
            this.LabelPatronymic.Size = new System.Drawing.Size(98, 24);
            this.LabelPatronymic.TabIndex = 7;
            this.LabelPatronymic.Text = "Отчество";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(277, 21);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(46, 24);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "Имя";
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSurname.Location = new System.Drawing.Point(3, 21);
            this.LabelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(91, 24);
            this.LabelSurname.TabIndex = 5;
            this.LabelSurname.Text = "Фамилия";
            // 
            // GroupBoxGeneralOrderInfo
            // 
            this.GroupBoxGeneralOrderInfo.Controls.Add(this.LabelCurrentOrderCost);
            this.GroupBoxGeneralOrderInfo.Controls.Add(this.LabelOrderCost);
            this.GroupBoxGeneralOrderInfo.Controls.Add(this.LabelCurrentOrderDate);
            this.GroupBoxGeneralOrderInfo.Controls.Add(this.LabelOrderDate);
            this.GroupBoxGeneralOrderInfo.Location = new System.Drawing.Point(3, 244);
            this.GroupBoxGeneralOrderInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxGeneralOrderInfo.Name = "GroupBoxGeneralOrderInfo";
            this.GroupBoxGeneralOrderInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxGeneralOrderInfo.Size = new System.Drawing.Size(882, 84);
            this.GroupBoxGeneralOrderInfo.TabIndex = 4;
            this.GroupBoxGeneralOrderInfo.TabStop = false;
            this.GroupBoxGeneralOrderInfo.Text = "Общая информация о заказе";
            this.GroupBoxGeneralOrderInfo.Visible = false;
            // 
            // LabelCurrentOrderCost
            // 
            this.LabelCurrentOrderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentOrderCost.Location = new System.Drawing.Point(336, 45);
            this.LabelCurrentOrderCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentOrderCost.Name = "LabelCurrentOrderCost";
            this.LabelCurrentOrderCost.Size = new System.Drawing.Size(217, 30);
            this.LabelCurrentOrderCost.TabIndex = 10;
            this.LabelCurrentOrderCost.Text = "Фамилия";
            // 
            // LabelOrderCost
            // 
            this.LabelOrderCost.AutoSize = true;
            this.LabelOrderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOrderCost.Location = new System.Drawing.Point(336, 21);
            this.LabelOrderCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOrderCost.Name = "LabelOrderCost";
            this.LabelOrderCost.Size = new System.Drawing.Size(174, 24);
            this.LabelOrderCost.TabIndex = 9;
            this.LabelOrderCost.Text = "Стоимость заказа";
            // 
            // LabelCurrentOrderDate
            // 
            this.LabelCurrentOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentOrderDate.Location = new System.Drawing.Point(7, 45);
            this.LabelCurrentOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCurrentOrderDate.Name = "LabelCurrentOrderDate";
            this.LabelCurrentOrderDate.Size = new System.Drawing.Size(217, 30);
            this.LabelCurrentOrderDate.TabIndex = 8;
            this.LabelCurrentOrderDate.Text = "Фамилия";
            // 
            // LabelOrderDate
            // 
            this.LabelOrderDate.AutoSize = true;
            this.LabelOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOrderDate.Location = new System.Drawing.Point(7, 21);
            this.LabelOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOrderDate.Name = "LabelOrderDate";
            this.LabelOrderDate.Size = new System.Drawing.Size(118, 24);
            this.LabelOrderDate.TabIndex = 5;
            this.LabelOrderDate.Text = "Дата заказа";
            // 
            // LabelListProductsInOrder
            // 
            this.LabelListProductsInOrder.AutoSize = true;
            this.LabelListProductsInOrder.Location = new System.Drawing.Point(15, 351);
            this.LabelListProductsInOrder.Margin = new System.Windows.Forms.Padding(15, 19, 3, 0);
            this.LabelListProductsInOrder.Name = "LabelListProductsInOrder";
            this.LabelListProductsInOrder.Size = new System.Drawing.Size(185, 18);
            this.LabelListProductsInOrder.TabIndex = 5;
            this.LabelListProductsInOrder.Text = "Список товаров в заказе";
            this.LabelListProductsInOrder.Visible = false;
            // 
            // PanelOfProducts
            // 
            this.PanelOfProducts.AutoScroll = true;
            this.PanelOfProducts.Location = new System.Drawing.Point(3, 373);
            this.PanelOfProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelOfProducts.Name = "PanelOfProducts";
            this.PanelOfProducts.Size = new System.Drawing.Size(882, 287);
            this.PanelOfProducts.TabIndex = 6;
            this.PanelOfProducts.Visible = false;
            // 
            // PanelSecondaryButtons
            // 
            this.PanelSecondaryButtons.Controls.Add(this.ButtonConfirmGiveOut);
            this.PanelSecondaryButtons.Controls.Add(this.ButtonBack);
            this.PanelSecondaryButtons.Location = new System.Drawing.Point(3, 682);
            this.PanelSecondaryButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.PanelSecondaryButtons.Name = "PanelSecondaryButtons";
            this.PanelSecondaryButtons.Size = new System.Drawing.Size(894, 71);
            this.PanelSecondaryButtons.TabIndex = 7;
            // 
            // ButtonConfirmGiveOut
            // 
            this.ButtonConfirmGiveOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonConfirmGiveOut.Location = new System.Drawing.Point(589, 16);
            this.ButtonConfirmGiveOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonConfirmGiveOut.Name = "ButtonConfirmGiveOut";
            this.ButtonConfirmGiveOut.Size = new System.Drawing.Size(296, 45);
            this.ButtonConfirmGiveOut.TabIndex = 3;
            this.ButtonConfirmGiveOut.Text = "Подтвердить выдачу заказа\r\n";
            this.ButtonConfirmGiveOut.UseVisualStyleBackColor = true;
            this.ButtonConfirmGiveOut.Click += new System.EventHandler(this.OnButtonConfirmGiveOutOrderClick);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(11, 16);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(117, 45);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            // 
            // StorekeeperSearchClientOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 753);
            this.Controls.Add(this.PanelSecondaryButtons);
            this.Controls.Add(this.PanelMainContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(918, 800);
            this.MinimumSize = new System.Drawing.Size(918, 800);
            this.Name = "StorekeeperSearchClientOrderView";
            this.Text = "Поиск клиентского заказа";
            this.PanelMainContainer.ResumeLayout(false);
            this.PanelMainContainer.PerformLayout();
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.GroupBoxClientInfo.ResumeLayout(false);
            this.GroupBoxClientInfo.PerformLayout();
            this.GroupBoxGeneralOrderInfo.ResumeLayout(false);
            this.GroupBoxGeneralOrderInfo.PerformLayout();
            this.PanelSecondaryButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label LabelMessageInput;
        private System.Windows.Forms.MaskedTextBox TextBoxOrderNumber;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPatronymic;
        private System.Windows.Forms.Label LabelCurrentSurname;
        private System.Windows.Forms.Label LabelCurrentName;
        private System.Windows.Forms.Label LabelCurrentPatronymic;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.Label LabelCurrentPhoneNumber;
        private System.Windows.Forms.Label LabelWayToReceiveOrder;
        private System.Windows.Forms.Label LabelCurrentWayToReceiveOrder;
        private System.Windows.Forms.GroupBox GroupBoxClientInfo;
        private System.Windows.Forms.Label LabelOrderDate;
        private System.Windows.Forms.Label LabelCurrentOrderDate;
        private System.Windows.Forms.Label LabelOrderCost;
        private System.Windows.Forms.Label LabelCurrentOrderCost;
        private System.Windows.Forms.GroupBox GroupBoxGeneralOrderInfo;
        private System.Windows.Forms.Label LabelListProductsInOrder;
        private System.Windows.Forms.FlowLayoutPanel PanelOfProducts;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Panel PanelSecondaryButtons;
        private System.Windows.Forms.Button ButtonConfirmGiveOut;
        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
    }
}
