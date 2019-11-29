using System;

namespace View
{
    partial class StorekeeperSearchProviderOrderView
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
            this.GeneralPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelInputLine = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelInputNumberOrder = new System.Windows.Forms.Label();
            this.TextBoxOrderNumber = new System.Windows.Forms.MaskedTextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.PanelNotFoundOrder = new System.Windows.Forms.Panel();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.PanelOrderInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelNumberOrder = new System.Windows.Forms.Label();
            this.LabelCurrentNumberOrder = new System.Windows.Forms.Label();
            this.LabelNameOrganization = new System.Windows.Forms.Label();
            this.LabelNameCurrentOrganization = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelCurrentCost = new System.Windows.Forms.Label();
            this.LabelOrderContent = new System.Windows.Forms.Label();
            this.PanelProductsInOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonConfirmAdmission = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelForButtons = new System.Windows.Forms.Panel();
            this.GeneralPanel.SuspendLayout();
            this.PanelInputLine.SuspendLayout();
            this.PanelNotFoundOrder.SuspendLayout();
            this.PanelOrderInfo.SuspendLayout();
            this.PanelForButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.AutoScroll = true;
            this.GeneralPanel.Controls.Add(this.PanelInputLine);
            this.GeneralPanel.Controls.Add(this.PanelNotFoundOrder);
            this.GeneralPanel.Controls.Add(this.PanelOrderInfo);
            this.GeneralPanel.Controls.Add(this.LabelOrderContent);
            this.GeneralPanel.Controls.Add(this.PanelProductsInOrder);
            this.GeneralPanel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneralPanel.Location = new System.Drawing.Point(14, 12);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(873, 433);
            this.GeneralPanel.TabIndex = 0;
            // 
            // PanelInputLine
            // 
            this.PanelInputLine.Controls.Add(this.LabelInputNumberOrder);
            this.PanelInputLine.Controls.Add(this.TextBoxOrderNumber);
            this.PanelInputLine.Controls.Add(this.ButtonSearch);
            this.PanelInputLine.Location = new System.Drawing.Point(0, 0);
            this.PanelInputLine.Margin = new System.Windows.Forms.Padding(0);
            this.PanelInputLine.Name = "PanelInputLine";
            this.PanelInputLine.Size = new System.Drawing.Size(869, 36);
            this.PanelInputLine.TabIndex = 2;
            // 
            // LabelInputNumberOrder
            // 
            this.LabelInputNumberOrder.AutoSize = true;
            this.LabelInputNumberOrder.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInputNumberOrder.Location = new System.Drawing.Point(1, 7);
            this.LabelInputNumberOrder.Margin = new System.Windows.Forms.Padding(1, 7, 1, 1);
            this.LabelInputNumberOrder.Name = "LabelInputNumberOrder";
            this.LabelInputNumberOrder.Size = new System.Drawing.Size(166, 17);
            this.LabelInputNumberOrder.TabIndex = 0;
            this.LabelInputNumberOrder.Text = "Введите номер поставки:";
            // 
            // TextBoxOrderNumber
            // 
            this.TextBoxOrderNumber.Location = new System.Drawing.Point(171, 3);
            this.TextBoxOrderNumber.Mask = "00000";
            this.TextBoxOrderNumber.Name = "TextBoxOrderNumber";
            this.TextBoxOrderNumber.Size = new System.Drawing.Size(557, 23);
            this.TextBoxOrderNumber.TabIndex = 1;
            this.TextBoxOrderNumber.ValidatingType = typeof(int);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(756, 3);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(25, 3, 0, 3);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(112, 27);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Поиск";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.OnButtonSearchClick);
            // 
            // PanelNotFoundOrder
            // 
            this.PanelNotFoundOrder.Controls.Add(this.LabelMessage);
            this.PanelNotFoundOrder.Location = new System.Drawing.Point(3, 39);
            this.PanelNotFoundOrder.Name = "PanelNotFoundOrder";
            this.PanelNotFoundOrder.Size = new System.Drawing.Size(866, 55);
            this.PanelNotFoundOrder.TabIndex = 5;
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessage.Location = new System.Drawing.Point(38, 25);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(0, 19);
            this.LabelMessage.TabIndex = 0;
            this.LabelMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelMessage.Visible = false;
            // 
            // PanelOrderInfo
            // 
            this.PanelOrderInfo.Controls.Add(this.LabelNumberOrder);
            this.PanelOrderInfo.Controls.Add(this.LabelCurrentNumberOrder);
            this.PanelOrderInfo.Controls.Add(this.LabelNameOrganization);
            this.PanelOrderInfo.Controls.Add(this.LabelNameCurrentOrganization);
            this.PanelOrderInfo.Controls.Add(this.LabelCost);
            this.PanelOrderInfo.Controls.Add(this.LabelCurrentCost);
            this.PanelOrderInfo.Location = new System.Drawing.Point(3, 100);
            this.PanelOrderInfo.Name = "PanelOrderInfo";
            this.PanelOrderInfo.Size = new System.Drawing.Size(866, 29);
            this.PanelOrderInfo.TabIndex = 7;
            // 
            // LabelNumberOrder
            // 
            this.LabelNumberOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNumberOrder.AutoSize = true;
            this.LabelNumberOrder.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumberOrder.Location = new System.Drawing.Point(1, 3);
            this.LabelNumberOrder.Margin = new System.Windows.Forms.Padding(1, 3, 3, 0);
            this.LabelNumberOrder.Name = "LabelNumberOrder";
            this.LabelNumberOrder.Size = new System.Drawing.Size(128, 17);
            this.LabelNumberOrder.TabIndex = 2;
            this.LabelNumberOrder.Text = "Номер поставки:";
            // 
            // LabelCurrentNumberOrder
            // 
            this.LabelCurrentNumberOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCurrentNumberOrder.AutoSize = true;
            this.LabelCurrentNumberOrder.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentNumberOrder.Location = new System.Drawing.Point(133, 3);
            this.LabelCurrentNumberOrder.Margin = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.LabelCurrentNumberOrder.Name = "LabelCurrentNumberOrder";
            this.LabelCurrentNumberOrder.Size = new System.Drawing.Size(43, 17);
            this.LabelCurrentNumberOrder.TabIndex = 3;
            this.LabelCurrentNumberOrder.Text = "12345";
            // 
            // LabelNameOrganization
            // 
            this.LabelNameOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNameOrganization.AutoSize = true;
            this.LabelNameOrganization.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameOrganization.Location = new System.Drawing.Point(180, 3);
            this.LabelNameOrganization.Margin = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.LabelNameOrganization.Name = "LabelNameOrganization";
            this.LabelNameOrganization.Size = new System.Drawing.Size(175, 17);
            this.LabelNameOrganization.TabIndex = 0;
            this.LabelNameOrganization.Text = "Название организации: ";
            // 
            // LabelNameCurrentOrganization
            // 
            this.LabelNameCurrentOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNameCurrentOrganization.AutoSize = true;
            this.LabelNameCurrentOrganization.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameCurrentOrganization.Location = new System.Drawing.Point(356, 3);
            this.LabelNameCurrentOrganization.Margin = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.LabelNameCurrentOrganization.Name = "LabelNameCurrentOrganization";
            this.LabelNameCurrentOrganization.Size = new System.Drawing.Size(212, 17);
            this.LabelNameCurrentOrganization.TabIndex = 1;
            this.LabelNameCurrentOrganization.Text = "ОАО \"Брестский мясокомбинат\"";
            // 
            // LabelCost
            // 
            this.LabelCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCost.AutoSize = true;
            this.LabelCost.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCost.Location = new System.Drawing.Point(572, 3);
            this.LabelCost.Margin = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(62, 17);
            this.LabelCost.TabIndex = 4;
            this.LabelCost.Text = "Сумма: ";
            // 
            // LabelCurrentCost
            // 
            this.LabelCurrentCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCurrentCost.AutoSize = true;
            this.LabelCurrentCost.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentCost.Location = new System.Drawing.Point(635, 3);
            this.LabelCurrentCost.Margin = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.LabelCurrentCost.Name = "LabelCurrentCost";
            this.LabelCurrentCost.Size = new System.Drawing.Size(90, 17);
            this.LabelCurrentCost.TabIndex = 5;
            this.LabelCurrentCost.Text = "10324 рублей";
            // 
            // LabelOrderContent
            // 
            this.LabelOrderContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelOrderContent.AutoSize = true;
            this.LabelOrderContent.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOrderContent.Location = new System.Drawing.Point(5, 135);
            this.LabelOrderContent.Margin = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.LabelOrderContent.Name = "LabelOrderContent";
            this.LabelOrderContent.Size = new System.Drawing.Size(170, 17);
            this.LabelOrderContent.TabIndex = 6;
            this.LabelOrderContent.Text = "Содержимое поставки:";
            // 
            // PanelProductsInOrder
            // 
            this.PanelProductsInOrder.AutoScroll = true;
            this.PanelProductsInOrder.Location = new System.Drawing.Point(3, 155);
            this.PanelProductsInOrder.Name = "PanelProductsInOrder";
            this.PanelProductsInOrder.Size = new System.Drawing.Size(866, 266);
            this.PanelProductsInOrder.TabIndex = 8;
            // 
            // ButtonConfirmAdmission
            // 
            this.ButtonConfirmAdmission.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonConfirmAdmission.Location = new System.Drawing.Point(679, 16);
            this.ButtonConfirmAdmission.Name = "ButtonConfirmAdmission";
            this.ButtonConfirmAdmission.Size = new System.Drawing.Size(190, 33);
            this.ButtonConfirmAdmission.TabIndex = 2;
            this.ButtonConfirmAdmission.Text = "Подтвердить приём заказа";
            this.ButtonConfirmAdmission.UseVisualStyleBackColor = true;
            this.ButtonConfirmAdmission.Click += new System.EventHandler(this.OnButtonConfirmGettingOrderClick);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(3, 15);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(126, 33);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            // 
            // PanelForButtons
            // 
            this.PanelForButtons.Controls.Add(this.ButtonBack);
            this.PanelForButtons.Controls.Add(this.ButtonConfirmAdmission);
            this.PanelForButtons.Location = new System.Drawing.Point(14, 451);
            this.PanelForButtons.Name = "PanelForButtons";
            this.PanelForButtons.Size = new System.Drawing.Size(872, 51);
            this.PanelForButtons.TabIndex = 1;
            // 
            // StorekeeperSearchProviderOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 514);
            this.Controls.Add(this.PanelForButtons);
            this.Controls.Add(this.GeneralPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(918, 553);
            this.MinimumSize = new System.Drawing.Size(918, 553);
            this.Name = "StorekeeperSearchProviderOrderView";
            this.Text = "Поиск приходной накладной";
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.PanelInputLine.ResumeLayout(false);
            this.PanelInputLine.PerformLayout();
            this.PanelNotFoundOrder.ResumeLayout(false);
            this.PanelNotFoundOrder.PerformLayout();
            this.PanelOrderInfo.ResumeLayout(false);
            this.PanelOrderInfo.PerformLayout();
            this.PanelForButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel GeneralPanel;
        private System.Windows.Forms.Label LabelInputNumberOrder;
        private System.Windows.Forms.FlowLayoutPanel PanelInputLine;
        private System.Windows.Forms.MaskedTextBox TextBoxOrderNumber;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Panel PanelNotFoundOrder;
        private System.Windows.Forms.Button ButtonConfirmAdmission;
        private System.Windows.Forms.FlowLayoutPanel PanelOrderInfo;
        private System.Windows.Forms.Label LabelNameOrganization;
        private System.Windows.Forms.Label LabelNumberOrder;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.FlowLayoutPanel PanelProductsInOrder;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Panel PanelForButtons;
        private System.Windows.Forms.Label LabelOrderContent;


        private System.Windows.Forms.Label LabelCurrentCost;
        private System.Windows.Forms.Label LabelCurrentNumberOrder;
        private System.Windows.Forms.Label LabelNameCurrentOrganization;
        private System.Windows.Forms.Label LabelMessage;
    }
}
