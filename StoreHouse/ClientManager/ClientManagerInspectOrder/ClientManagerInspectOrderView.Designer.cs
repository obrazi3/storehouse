using System;

namespace View
{
    partial class ClientManagerInspectOrderView
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
            this.PanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelHead = new System.Windows.Forms.Panel();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxOrderNumber = new System.Windows.Forms.MaskedTextBox();
            this.LabelMessageInput = new System.Windows.Forms.Label();
            this.PanelOrderInfo = new System.Windows.Forms.FlowLayoutPanel();
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
            this.GroupBoxClientAddress = new System.Windows.Forms.GroupBox();
            this.LabelCurrentFlat = new System.Windows.Forms.Label();
            this.LabelCurrentFloor = new System.Windows.Forms.Label();
            this.LabelCurrentPorch = new System.Windows.Forms.Label();
            this.LabelCurrentPavilion = new System.Windows.Forms.Label();
            this.LabelCurrentHouseNumber = new System.Windows.Forms.Label();
            this.LabelCurrentStreet = new System.Windows.Forms.Label();
            this.LabelCurrentCity = new System.Windows.Forms.Label();
            this.LabelFloor = new System.Windows.Forms.Label();
            this.LabelPorch = new System.Windows.Forms.Label();
            this.LabelFlat = new System.Windows.Forms.Label();
            this.LabelPavilion = new System.Windows.Forms.Label();
            this.LabelStreet = new System.Windows.Forms.Label();
            this.LabelHouseNumber = new System.Windows.Forms.Label();
            this.LabelCity = new System.Windows.Forms.Label();
            this.GroupBoxGeneralOrderInfo = new System.Windows.Forms.GroupBox();
            this.LabelCurrentOrderCost = new System.Windows.Forms.Label();
            this.LabelOrderCost = new System.Windows.Forms.Label();
            this.LabelCurrentOrderDate = new System.Windows.Forms.Label();
            this.LabelOrderDate = new System.Windows.Forms.Label();
            this.LabelListProductsInOrder = new System.Windows.Forms.Label();
            this.PanelOfProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelSecondaryButtons = new System.Windows.Forms.Panel();
            this.ButtonRemoveOrder = new System.Windows.Forms.Button();
            this.ButtonEditOrder = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMain.SuspendLayout();
            this.PanelHead.SuspendLayout();
            this.PanelOrderInfo.SuspendLayout();
            this.GroupBoxClientInfo.SuspendLayout();
            this.GroupBoxClientAddress.SuspendLayout();
            this.GroupBoxGeneralOrderInfo.SuspendLayout();
            this.PanelSecondaryButtons.SuspendLayout();
            this.SuspendLayout();
            this.PanelMain.Controls.Add(this.PanelHead);
            this.PanelMain.Controls.Add(this.PanelOrderInfo);
            this.PanelMain.Controls.Add(this.PanelSecondaryButtons);
            this.PanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelMain.Location = new System.Drawing.Point(11, 15);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1006, 1009);
            this.PanelMain.TabIndex = 0;
            this.PanelHead.Controls.Add(this.ButtonSearch);
            this.PanelHead.Controls.Add(this.TextBoxOrderNumber);
            this.PanelHead.Controls.Add(this.LabelMessageInput);
            this.PanelHead.Location = new System.Drawing.Point(3, 4);
            this.PanelHead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(1002, 72);
            this.PanelHead.TabIndex = 0;
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSearch.Location = new System.Drawing.Point(854, 6);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(135, 49);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Поиск";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.OnButtonSearchOrderClick);
            this.TextBoxOrderNumber.Location = new System.Drawing.Point(233, 19);
            this.TextBoxOrderNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxOrderNumber.Mask = "00000";
            this.TextBoxOrderNumber.Name = "TextBoxOrderNumber";
            this.TextBoxOrderNumber.Size = new System.Drawing.Size(613, 27);
            this.TextBoxOrderNumber.TabIndex = 1;
            this.TextBoxOrderNumber.ValidatingType = typeof(int);
            this.LabelMessageInput.AutoSize = true;
            this.LabelMessageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessageInput.Location = new System.Drawing.Point(3, 19);
            this.LabelMessageInput.Name = "LabelMessageInput";
            this.LabelMessageInput.Size = new System.Drawing.Size(224, 24);
            this.LabelMessageInput.TabIndex = 0;
            this.LabelMessageInput.Text = "Введите номер заказа: ";
            this.PanelOrderInfo.Controls.Add(this.GroupBoxClientInfo);
            this.PanelOrderInfo.Controls.Add(this.GroupBoxClientAddress);
            this.PanelOrderInfo.Controls.Add(this.GroupBoxGeneralOrderInfo);
            this.PanelOrderInfo.Controls.Add(this.LabelListProductsInOrder);
            this.PanelOrderInfo.Controls.Add(this.PanelOfProducts);
            this.PanelOrderInfo.Location = new System.Drawing.Point(3, 84);
            this.PanelOrderInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelOrderInfo.Name = "PanelOrderInfo";
            this.PanelOrderInfo.Size = new System.Drawing.Size(1002, 842);
            this.PanelOrderInfo.TabIndex = 1;
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
            this.GroupBoxClientInfo.Location = new System.Drawing.Point(3, 4);
            this.GroupBoxClientInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxClientInfo.Name = "GroupBoxClientInfo";
            this.GroupBoxClientInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxClientInfo.Size = new System.Drawing.Size(985, 159);
            this.GroupBoxClientInfo.TabIndex = 0;
            this.GroupBoxClientInfo.TabStop = false;
            this.GroupBoxClientInfo.Text = "Информация о заказчике";
            this.GroupBoxClientInfo.Visible = false;
            this.LabelCurrentWayToReceiveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentWayToReceiveOrder.Location = new System.Drawing.Point(6, 101);
            this.LabelCurrentWayToReceiveOrder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentWayToReceiveOrder.Name = "LabelCurrentWayToReceiveOrder";
            this.LabelCurrentWayToReceiveOrder.Size = new System.Drawing.Size(217, 29);
            this.LabelCurrentWayToReceiveOrder.TabIndex = 14;
            this.LabelCurrentWayToReceiveOrder.Text = "Фамилия";
            this.LabelWayToReceiveOrder.AutoSize = true;
            this.LabelWayToReceiveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelWayToReceiveOrder.Location = new System.Drawing.Point(6, 78);
            this.LabelWayToReceiveOrder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelWayToReceiveOrder.Name = "LabelWayToReceiveOrder";
            this.LabelWayToReceiveOrder.Size = new System.Drawing.Size(240, 24);
            this.LabelWayToReceiveOrder.TabIndex = 13;
            this.LabelWayToReceiveOrder.Text = "Способ получения заказа";
            this.LabelCurrentPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentPhoneNumber.Location = new System.Drawing.Point(736, 48);
            this.LabelCurrentPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentPhoneNumber.Name = "LabelCurrentPhoneNumber";
            this.LabelCurrentPhoneNumber.Size = new System.Drawing.Size(217, 29);
            this.LabelCurrentPhoneNumber.TabIndex = 12;
            this.LabelCurrentPhoneNumber.Text = "Фамилия";
            this.LabelPhoneNumber.AutoSize = true;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPhoneNumber.Location = new System.Drawing.Point(736, 24);
            this.LabelPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(198, 24);
            this.LabelPhoneNumber.TabIndex = 11;
            this.LabelPhoneNumber.Text = "Мобильный телефон";
            this.LabelCurrentPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentPatronymic.Location = new System.Drawing.Point(502, 48);
            this.LabelCurrentPatronymic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentPatronymic.Name = "LabelCurrentPatronymic";
            this.LabelCurrentPatronymic.Size = new System.Drawing.Size(217, 29);
            this.LabelCurrentPatronymic.TabIndex = 10;
            this.LabelCurrentPatronymic.Text = "Фамилия";
            this.LabelCurrentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentName.Location = new System.Drawing.Point(277, 48);
            this.LabelCurrentName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentName.Name = "LabelCurrentName";
            this.LabelCurrentName.Size = new System.Drawing.Size(217, 29);
            this.LabelCurrentName.TabIndex = 9;
            this.LabelCurrentName.Text = "Фамилия";
            this.LabelCurrentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentSurname.Location = new System.Drawing.Point(7, 48);
            this.LabelCurrentSurname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentSurname.Name = "LabelCurrentSurname";
            this.LabelCurrentSurname.Size = new System.Drawing.Size(217, 29);
            this.LabelCurrentSurname.TabIndex = 8;
            this.LabelCurrentSurname.Text = "Фамилия";
            this.LabelPatronymic.AutoSize = true;
            this.LabelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPatronymic.Location = new System.Drawing.Point(505, 24);
            this.LabelPatronymic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelPatronymic.Name = "LabelPatronymic";
            this.LabelPatronymic.Size = new System.Drawing.Size(98, 24);
            this.LabelPatronymic.TabIndex = 7;
            this.LabelPatronymic.Text = "Отчество";
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(277, 24);
            this.LabelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(46, 24);
            this.LabelName.TabIndex = 6;
            this.LabelName.Text = "Имя";
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSurname.Location = new System.Drawing.Point(7, 24);
            this.LabelSurname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(91, 24);
            this.LabelSurname.TabIndex = 5;
            this.LabelSurname.Text = "Фамилия";
            this.GroupBoxClientAddress.Controls.Add(this.LabelCurrentFlat);
            this.GroupBoxClientAddress.Controls.Add(this.LabelCurrentFloor);
            this.GroupBoxClientAddress.Controls.Add(this.LabelCurrentPorch);
            this.GroupBoxClientAddress.Controls.Add(this.LabelCurrentPavilion);
            this.GroupBoxClientAddress.Controls.Add(this.LabelCurrentHouseNumber);
            this.GroupBoxClientAddress.Controls.Add(this.LabelCurrentStreet);
            this.GroupBoxClientAddress.Controls.Add(this.LabelCurrentCity);
            this.GroupBoxClientAddress.Controls.Add(this.LabelFloor);
            this.GroupBoxClientAddress.Controls.Add(this.LabelPorch);
            this.GroupBoxClientAddress.Controls.Add(this.LabelFlat);
            this.GroupBoxClientAddress.Controls.Add(this.LabelPavilion);
            this.GroupBoxClientAddress.Controls.Add(this.LabelStreet);
            this.GroupBoxClientAddress.Controls.Add(this.LabelHouseNumber);
            this.GroupBoxClientAddress.Controls.Add(this.LabelCity);
            this.GroupBoxClientAddress.Location = new System.Drawing.Point(3, 171);
            this.GroupBoxClientAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxClientAddress.Name = "GroupBoxClientAddress";
            this.GroupBoxClientAddress.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxClientAddress.Size = new System.Drawing.Size(985, 149);
            this.GroupBoxClientAddress.TabIndex = 1;
            this.GroupBoxClientAddress.TabStop = false;
            this.GroupBoxClientAddress.Text = "Адрес проживания заказчика";
            this.GroupBoxClientAddress.Visible = false;
            this.LabelCurrentFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentFlat.Location = new System.Drawing.Point(505, 112);
            this.LabelCurrentFlat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentFlat.Name = "LabelCurrentFlat";
            this.LabelCurrentFlat.Size = new System.Drawing.Size(110, 29);
            this.LabelCurrentFlat.TabIndex = 27;
            this.LabelCurrentFlat.Text = "Фамилия";
            this.LabelCurrentFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentFloor.Location = new System.Drawing.Point(344, 112);
            this.LabelCurrentFloor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentFloor.Name = "LabelCurrentFloor";
            this.LabelCurrentFloor.Size = new System.Drawing.Size(110, 29);
            this.LabelCurrentFloor.TabIndex = 26;
            this.LabelCurrentFloor.Text = "Фамилия";
            this.LabelCurrentPorch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentPorch.Location = new System.Drawing.Point(170, 112);
            this.LabelCurrentPorch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentPorch.Name = "LabelCurrentPorch";
            this.LabelCurrentPorch.Size = new System.Drawing.Size(110, 29);
            this.LabelCurrentPorch.TabIndex = 25;
            this.LabelCurrentPorch.Text = "Фамилия";
            this.LabelCurrentPavilion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentPavilion.Location = new System.Drawing.Point(7, 112);
            this.LabelCurrentPavilion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentPavilion.Name = "LabelCurrentPavilion";
            this.LabelCurrentPavilion.Size = new System.Drawing.Size(110, 29);
            this.LabelCurrentPavilion.TabIndex = 24;
            this.LabelCurrentPavilion.Text = "Фамилия";
            this.LabelCurrentHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentHouseNumber.Location = new System.Drawing.Point(573, 48);
            this.LabelCurrentHouseNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentHouseNumber.Name = "LabelCurrentHouseNumber";
            this.LabelCurrentHouseNumber.Size = new System.Drawing.Size(162, 29);
            this.LabelCurrentHouseNumber.TabIndex = 23;
            this.LabelCurrentHouseNumber.Text = "Фамилия";
            this.LabelCurrentStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentStreet.Location = new System.Drawing.Point(235, 48);
            this.LabelCurrentStreet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentStreet.Name = "LabelCurrentStreet";
            this.LabelCurrentStreet.Size = new System.Drawing.Size(305, 29);
            this.LabelCurrentStreet.TabIndex = 22;
            this.LabelCurrentStreet.Text = "Фамилия";
            this.LabelCurrentCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentCity.Location = new System.Drawing.Point(7, 48);
            this.LabelCurrentCity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentCity.Name = "LabelCurrentCity";
            this.LabelCurrentCity.Size = new System.Drawing.Size(198, 29);
            this.LabelCurrentCity.TabIndex = 21;
            this.LabelCurrentCity.Text = "Фамилия";
            this.LabelFloor.AutoSize = true;
            this.LabelFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFloor.Location = new System.Drawing.Point(344, 89);
            this.LabelFloor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelFloor.Name = "LabelFloor";
            this.LabelFloor.Size = new System.Drawing.Size(57, 24);
            this.LabelFloor.TabIndex = 20;
            this.LabelFloor.Text = "Этаж";
            this.LabelPorch.AutoSize = true;
            this.LabelPorch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPorch.Location = new System.Drawing.Point(170, 89);
            this.LabelPorch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelPorch.Name = "LabelPorch";
            this.LabelPorch.Size = new System.Drawing.Size(90, 24);
            this.LabelPorch.TabIndex = 19;
            this.LabelPorch.Text = "Подъезд";
            this.LabelFlat.AutoSize = true;
            this.LabelFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFlat.Location = new System.Drawing.Point(505, 89);
            this.LabelFlat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelFlat.Name = "LabelFlat";
            this.LabelFlat.Size = new System.Drawing.Size(96, 24);
            this.LabelFlat.TabIndex = 18;
            this.LabelFlat.Text = "Квартира";
            this.LabelPavilion.AutoSize = true;
            this.LabelPavilion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPavilion.Location = new System.Drawing.Point(7, 89);
            this.LabelPavilion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelPavilion.Name = "LabelPavilion";
            this.LabelPavilion.Size = new System.Drawing.Size(74, 24);
            this.LabelPavilion.TabIndex = 17;
            this.LabelPavilion.Text = "Корпус";
            this.LabelStreet.AutoSize = true;
            this.LabelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStreet.Location = new System.Drawing.Point(235, 24);
            this.LabelStreet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelStreet.Name = "LabelStreet";
            this.LabelStreet.Size = new System.Drawing.Size(64, 24);
            this.LabelStreet.TabIndex = 7;
            this.LabelStreet.Text = "Улица";
            this.LabelHouseNumber.AutoSize = true;
            this.LabelHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHouseNumber.Location = new System.Drawing.Point(573, 24);
            this.LabelHouseNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelHouseNumber.Name = "LabelHouseNumber";
            this.LabelHouseNumber.Size = new System.Drawing.Size(48, 24);
            this.LabelHouseNumber.TabIndex = 6;
            this.LabelHouseNumber.Text = "Дом";
            this.LabelCity.AutoSize = true;
            this.LabelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCity.Location = new System.Drawing.Point(7, 24);
            this.LabelCity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(66, 24);
            this.LabelCity.TabIndex = 5;
            this.LabelCity.Text = "Город";
            this.GroupBoxGeneralOrderInfo.Controls.Add(this.LabelCurrentOrderCost);
            this.GroupBoxGeneralOrderInfo.Controls.Add(this.LabelOrderCost);
            this.GroupBoxGeneralOrderInfo.Controls.Add(this.LabelCurrentOrderDate);
            this.GroupBoxGeneralOrderInfo.Controls.Add(this.LabelOrderDate);
            this.GroupBoxGeneralOrderInfo.Location = new System.Drawing.Point(3, 328);
            this.GroupBoxGeneralOrderInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxGeneralOrderInfo.Name = "GroupBoxGeneralOrderInfo";
            this.GroupBoxGeneralOrderInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxGeneralOrderInfo.Size = new System.Drawing.Size(985, 82);
            this.GroupBoxGeneralOrderInfo.TabIndex = 2;
            this.GroupBoxGeneralOrderInfo.TabStop = false;
            this.GroupBoxGeneralOrderInfo.Text = "Общая информация о заказе";
            this.GroupBoxGeneralOrderInfo.Visible = false;
            this.LabelCurrentOrderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentOrderCost.Location = new System.Drawing.Point(336, 48);
            this.LabelCurrentOrderCost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentOrderCost.Name = "LabelCurrentOrderCost";
            this.LabelCurrentOrderCost.Size = new System.Drawing.Size(217, 29);
            this.LabelCurrentOrderCost.TabIndex = 10;
            this.LabelCurrentOrderCost.Text = "Фамилия";
            this.LabelOrderCost.AutoSize = true;
            this.LabelOrderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOrderCost.Location = new System.Drawing.Point(336, 24);
            this.LabelOrderCost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelOrderCost.Name = "LabelOrderCost";
            this.LabelOrderCost.Size = new System.Drawing.Size(174, 24);
            this.LabelOrderCost.TabIndex = 9;
            this.LabelOrderCost.Text = "Стоимость заказа";
            this.LabelCurrentOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentOrderDate.Location = new System.Drawing.Point(7, 48);
            this.LabelCurrentOrderDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelCurrentOrderDate.Name = "LabelCurrentOrderDate";
            this.LabelCurrentOrderDate.Size = new System.Drawing.Size(217, 29);
            this.LabelCurrentOrderDate.TabIndex = 8;
            this.LabelCurrentOrderDate.Text = "Фамилия";
            this.LabelOrderDate.AutoSize = true;
            this.LabelOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOrderDate.Location = new System.Drawing.Point(7, 24);
            this.LabelOrderDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelOrderDate.Name = "LabelOrderDate";
            this.LabelOrderDate.Size = new System.Drawing.Size(118, 24);
            this.LabelOrderDate.TabIndex = 5;
            this.LabelOrderDate.Text = "Дата заказа";
            this.LabelListProductsInOrder.AutoSize = true;
            this.LabelListProductsInOrder.Location = new System.Drawing.Point(15, 433);
            this.LabelListProductsInOrder.Margin = new System.Windows.Forms.Padding(15, 19, 3, 0);
            this.LabelListProductsInOrder.Name = "LabelListProductsInOrder";
            this.LabelListProductsInOrder.Size = new System.Drawing.Size(181, 20);
            this.LabelListProductsInOrder.TabIndex = 3;
            this.LabelListProductsInOrder.Text = "Список товаров в заказе";
            this.LabelListProductsInOrder.Visible = false;
            this.PanelOfProducts.AutoScroll = true;
            this.PanelOfProducts.Location = new System.Drawing.Point(3, 457);
            this.PanelOfProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelOfProducts.Name = "PanelOfProducts";
            this.PanelOfProducts.Size = new System.Drawing.Size(985, 374);
            this.PanelOfProducts.TabIndex = 4;
            this.PanelOfProducts.Visible = false;
            this.PanelSecondaryButtons.Controls.Add(this.ButtonRemoveOrder);
            this.PanelSecondaryButtons.Controls.Add(this.ButtonEditOrder);
            this.PanelSecondaryButtons.Controls.Add(this.ButtonBack);
            this.PanelSecondaryButtons.Location = new System.Drawing.Point(3, 934);
            this.PanelSecondaryButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.PanelSecondaryButtons.Name = "PanelSecondaryButtons";
            this.PanelSecondaryButtons.Size = new System.Drawing.Size(1002, 71);
            this.PanelSecondaryButtons.TabIndex = 2;
            this.ButtonRemoveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRemoveOrder.Location = new System.Drawing.Point(576, 16);
            this.ButtonRemoveOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonRemoveOrder.Name = "ButtonRemoveOrder";
            this.ButtonRemoveOrder.Size = new System.Drawing.Size(181, 45);
            this.ButtonRemoveOrder.TabIndex = 4;
            this.ButtonRemoveOrder.Text = "Удалить заказ";
            this.ButtonRemoveOrder.UseVisualStyleBackColor = true;
            this.ButtonRemoveOrder.Click += new System.EventHandler(this.OnButtonRemoveOrderClick);
            this.ButtonEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEditOrder.Location = new System.Drawing.Point(817, 16);
            this.ButtonEditOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonEditOrder.Name = "ButtonEditOrder";
            this.ButtonEditOrder.Size = new System.Drawing.Size(171, 45);
            this.ButtonEditOrder.TabIndex = 3;
            this.ButtonEditOrder.Text = "Редактировать";
            this.ButtonEditOrder.UseVisualStyleBackColor = true;
            this.ButtonEditOrder.Click += new System.EventHandler(this.OnButtonEditOrderClick);
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(3, 16);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(117, 45);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 1026);
            this.Controls.Add(this.PanelMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1047, 1073);
            this.MinimumSize = new System.Drawing.Size(1047, 1039);
            this.Name = "ClientManagerInspectOrderView";
            this.Text = "Просмотреть заказ";
            this.PanelMain.ResumeLayout(false);
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.PanelOrderInfo.ResumeLayout(false);
            this.PanelOrderInfo.PerformLayout();
            this.GroupBoxClientInfo.ResumeLayout(false);
            this.GroupBoxClientInfo.PerformLayout();
            this.GroupBoxClientAddress.ResumeLayout(false);
            this.GroupBoxClientAddress.PerformLayout();
            this.GroupBoxGeneralOrderInfo.ResumeLayout(false);
            this.GroupBoxGeneralOrderInfo.PerformLayout();
            this.PanelSecondaryButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelMain;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.MaskedTextBox TextBoxOrderNumber;
        private System.Windows.Forms.Label LabelMessageInput;
        private System.Windows.Forms.FlowLayoutPanel PanelOrderInfo;
        private System.Windows.Forms.Panel PanelSecondaryButtons;
        private System.Windows.Forms.Button ButtonEditOrder;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonRemoveOrder;
        private System.Windows.Forms.GroupBox GroupBoxClientInfo;
        private System.Windows.Forms.Label LabelCurrentName;
        private System.Windows.Forms.Label LabelCurrentSurname;
        private System.Windows.Forms.Label LabelPatronymic;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.Label LabelCurrentPatronymic;
        private System.Windows.Forms.Label LabelCurrentWayToReceiveOrder;
        private System.Windows.Forms.Label LabelWayToReceiveOrder;
        private System.Windows.Forms.Label LabelCurrentPhoneNumber;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.GroupBox GroupBoxClientAddress;
        private System.Windows.Forms.Label LabelStreet;
        private System.Windows.Forms.Label LabelHouseNumber;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.Label LabelCurrentHouseNumber;
        private System.Windows.Forms.Label LabelCurrentStreet;
        private System.Windows.Forms.Label LabelCurrentCity;
        private System.Windows.Forms.Label LabelFloor;
        private System.Windows.Forms.Label LabelPorch;
        private System.Windows.Forms.Label LabelFlat;
        private System.Windows.Forms.Label LabelPavilion;
        private System.Windows.Forms.Label LabelCurrentFlat;
        private System.Windows.Forms.Label LabelCurrentFloor;
        private System.Windows.Forms.Label LabelCurrentPorch;
        private System.Windows.Forms.Label LabelCurrentPavilion;
        private System.Windows.Forms.GroupBox GroupBoxGeneralOrderInfo;
        private System.Windows.Forms.Label LabelCurrentOrderCost;
        private System.Windows.Forms.Label LabelOrderCost;
        private System.Windows.Forms.Label LabelCurrentOrderDate;
        private System.Windows.Forms.Label LabelOrderDate;
        private System.Windows.Forms.Label LabelListProductsInOrder;
        private System.Windows.Forms.FlowLayoutPanel PanelOfProducts;
    }
}
