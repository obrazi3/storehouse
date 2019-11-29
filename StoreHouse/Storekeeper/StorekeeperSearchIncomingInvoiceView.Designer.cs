using System;

namespace View
{
    partial class StorekeeperSearchIncomingInvoiceView
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNumberInvoice = new System.Windows.Forms.MaskedTextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.PanelNotFoundInvoice = new System.Windows.Forms.Panel();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.PanelInvoiceInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelCurrentNumber = new System.Windows.Forms.Label();
            this.LabelNameOrganization = new System.Windows.Forms.Label();
            this.LabelNameCurrentOrganization = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelCurrentCost = new System.Windows.Forms.Label();
            this.LabelOrderContent = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelCurrentProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.LabelCurrentProductName = new System.Windows.Forms.Label();
            this.LabelNumberProduct = new System.Windows.Forms.Label();
            this.LabelCurrentNumberProduct = new System.Windows.Forms.Label();
            this.BtnConfirmAdmission = new System.Windows.Forms.Button();
            this.LabelFoundInvoice = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GeneralPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.PanelNotFoundInvoice.SuspendLayout();
            this.PanelInvoiceInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelCurrentProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            this.GeneralPanel.AutoScroll = true;
            this.GeneralPanel.Controls.Add(this.flowLayoutPanel2);
            this.GeneralPanel.Controls.Add(this.PanelNotFoundInvoice);
            this.GeneralPanel.Controls.Add(this.PanelInvoiceInfo);
            this.GeneralPanel.Controls.Add(this.LabelOrderContent);
            this.GeneralPanel.Controls.Add(this.flowLayoutPanel1);
            this.GeneralPanel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneralPanel.Location = new System.Drawing.Point(14, 12);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(873, 375);
            this.GeneralPanel.TabIndex = 0;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.TextBoxNumberInvoice);
            this.flowLayoutPanel2.Controls.Add(this.BtnSearch);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(869, 36);
            this.flowLayoutPanel2.TabIndex = 2;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 7, 1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер приходной накладной:";
            this.TextBoxNumberInvoice.Location = new System.Drawing.Point(246, 3);
            this.TextBoxNumberInvoice.Mask = "00000";
            this.TextBoxNumberInvoice.Name = "TextBoxNumberInvoice";
            this.TextBoxNumberInvoice.Size = new System.Drawing.Size(482, 23);
            this.TextBoxNumberInvoice.TabIndex = 1;
            this.TextBoxNumberInvoice.ValidatingType = typeof(int);
            this.BtnSearch.Location = new System.Drawing.Point(756, 3);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(25, 3, 0, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(112, 27);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Поиск";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click+=new EventHandler(OnButtonSearchClick);
            this.PanelNotFoundInvoice.Controls.Add(this.LabelMessage);
            this.PanelNotFoundInvoice.Location = new System.Drawing.Point(3, 39);
            this.PanelNotFoundInvoice.Name = "PanelNotFoundInvoice";
            this.PanelNotFoundInvoice.Size = new System.Drawing.Size(866, 55);
            this.PanelNotFoundInvoice.TabIndex = 5;
            this.PanelNotFoundInvoice.Visible = false;
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessage.Location = new System.Drawing.Point(38, 11);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(794, 19);
            this.LabelMessage.TabIndex = 0;
            this.LabelMessage.Text =
                (("К сожалению, накладная с таким номером не найдена. Проверьте правильность ввода и" + "" + "") +
                 " повторите поиска ещё раз.");
            this.LabelMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PanelInvoiceInfo.Controls.Add(this.LabelNumber);
            this.PanelInvoiceInfo.Controls.Add(this.LabelCurrentNumber);
            this.PanelInvoiceInfo.Controls.Add(this.LabelNameOrganization);
            this.PanelInvoiceInfo.Controls.Add(this.LabelNameCurrentOrganization);
            this.PanelInvoiceInfo.Controls.Add(this.LabelCost);
            this.PanelInvoiceInfo.Controls.Add(this.LabelCurrentCost);
            this.PanelInvoiceInfo.Location = new System.Drawing.Point(3, 100);
            this.PanelInvoiceInfo.Name = "PanelInvoiceInfo";
            this.PanelInvoiceInfo.Size = new System.Drawing.Size(866, 29);
            this.PanelInvoiceInfo.TabIndex = 7;
            this.LabelNumber.Anchor =
                ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top |
                                                      System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumber.Location = new System.Drawing.Point(1, 3);
            this.LabelNumber.Margin = new System.Windows.Forms.Padding(1, 3, 3, 0);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(128, 17);
            this.LabelNumber.TabIndex = 2;
            this.LabelNumber.Text = "Номер поставки:";
            this.LabelCurrentNumber.Anchor =
                ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top |
                                                      System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCurrentNumber.AutoSize = true;
            this.LabelCurrentNumber.Font = new System.Drawing.Font("Times New Roman", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentNumber.Location = new System.Drawing.Point(133, 3);
            this.LabelCurrentNumber.Margin = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.LabelCurrentNumber.Name = "LabelCurrentNumber";
            this.LabelCurrentNumber.Size = new System.Drawing.Size(43, 17);
            this.LabelCurrentNumber.TabIndex = 3;
            this.LabelCurrentNumber.Text = "12345";
            this.LabelNameOrganization.Anchor =
                ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top |
                                                      System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNameOrganization.AutoSize = true;
            this.LabelNameOrganization.Font = new System.Drawing.Font("Times New Roman", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameOrganization.Location = new System.Drawing.Point(180, 3);
            this.LabelNameOrganization.Margin = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.LabelNameOrganization.Name = "LabelNameOrganization";
            this.LabelNameOrganization.Size = new System.Drawing.Size(175, 17);
            this.LabelNameOrganization.TabIndex = 0;
            this.LabelNameOrganization.Text = "Название организации: ";
            this.LabelNameCurrentOrganization.Anchor =
                ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top |
                                                      System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNameCurrentOrganization.AutoSize = true;
            this.LabelNameCurrentOrganization.Font = new System.Drawing.Font("Times New Roman", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameCurrentOrganization.Location = new System.Drawing.Point(356, 3);
            this.LabelNameCurrentOrganization.Margin = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.LabelNameCurrentOrganization.Name = "LabelNameCurrentOrganization";
            this.LabelNameCurrentOrganization.Size = new System.Drawing.Size(212, 17);
            this.LabelNameCurrentOrganization.TabIndex = 1;
            this.LabelNameCurrentOrganization.Text = "ОАО \"Брестский мясокомбинат\"";
            this.LabelCost.Anchor =
                ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top |
                                                      System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCost.AutoSize = true;
            this.LabelCost.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCost.Location = new System.Drawing.Point(572, 3);
            this.LabelCost.Margin = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(62, 17);
            this.LabelCost.TabIndex = 4;
            this.LabelCost.Text = "Сумма: ";
            this.LabelCurrentCost.Anchor =
                ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top |
                                                      System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCurrentCost.AutoSize = true;
            this.LabelCurrentCost.Font = new System.Drawing.Font("Times New Roman", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentCost.Location = new System.Drawing.Point(635, 3);
            this.LabelCurrentCost.Margin = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.LabelCurrentCost.Name = "LabelCurrentCost";
            this.LabelCurrentCost.Size = new System.Drawing.Size(90, 17);
            this.LabelCurrentCost.TabIndex = 5;
            this.LabelCurrentCost.Text = "10324 рублей";
            this.LabelOrderContent.Anchor =
                ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top |
                                                      System.Windows.Forms.AnchorStyles.Right)));
            this.LabelOrderContent.AutoSize = true;
            this.LabelOrderContent.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOrderContent.Location = new System.Drawing.Point(5, 135);
            this.LabelOrderContent.Margin = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.LabelOrderContent.Name = "LabelOrderContent";
            this.LabelOrderContent.Size = new System.Drawing.Size(170, 17);
            this.LabelOrderContent.TabIndex = 6;
            this.LabelOrderContent.Text = "Содержимое поставки:";
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.PanelCurrentProduct);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 155);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(866, 210);
            this.flowLayoutPanel1.TabIndex = 8;
            this.PanelCurrentProduct.Controls.Add(this.LabelProductName);
            this.PanelCurrentProduct.Controls.Add(this.LabelCurrentProductName);
            this.PanelCurrentProduct.Controls.Add(this.LabelNumberProduct);
            this.PanelCurrentProduct.Controls.Add(this.LabelCurrentNumberProduct);
            this.PanelCurrentProduct.Location = new System.Drawing.Point(3, 3);
            this.PanelCurrentProduct.Name = "PanelCurrentProduct";
            this.PanelCurrentProduct.Size = new System.Drawing.Size(842, 28);
            this.PanelCurrentProduct.TabIndex = 3;
            this.LabelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductName.Location = new System.Drawing.Point(3, 5);
            this.LabelProductName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(166, 19);
            this.LabelProductName.TabIndex = 2;
            this.LabelProductName.Text = "Название продукта: ";
            this.LabelCurrentProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentProductName.Location = new System.Drawing.Point(175, 5);
            this.LabelCurrentProductName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.LabelCurrentProductName.Name = "LabelCurrentProductName";
            this.LabelCurrentProductName.Size = new System.Drawing.Size(318, 19);
            this.LabelCurrentProductName.TabIndex = 1;
            this.LabelCurrentProductName.Text = "Название продукта: ";
            this.LabelNumberProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumberProduct.Location = new System.Drawing.Point(499, 5);
            this.LabelNumberProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.LabelNumberProduct.Name = "LabelNumberProduct";
            this.LabelNumberProduct.Size = new System.Drawing.Size(146, 19);
            this.LabelNumberProduct.TabIndex = 0;
            this.LabelNumberProduct.Text = "Кол-во продукта:\r\n";
            this.LabelCurrentNumberProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentNumberProduct.Location = new System.Drawing.Point(651, 5);
            this.LabelCurrentNumberProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.LabelCurrentNumberProduct.Name = "LabelCurrentNumberProduct";
            this.LabelCurrentNumberProduct.Size = new System.Drawing.Size(178, 19);
            this.LabelCurrentNumberProduct.TabIndex = 3;
            this.LabelCurrentNumberProduct.Text = "Кол-во продукта:\r\n";
            this.BtnConfirmAdmission.Font = new System.Drawing.Font("Times New Roman", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnConfirmAdmission.Location = new System.Drawing.Point(679, 69);
            this.BtnConfirmAdmission.Name = "BtnConfirmAdmission";
            this.BtnConfirmAdmission.Size = new System.Drawing.Size(190, 33);
            this.BtnConfirmAdmission.TabIndex = 2;
            this.BtnConfirmAdmission.Text = "Подтвердить приём заказа";
            this.BtnConfirmAdmission.UseVisualStyleBackColor = true;
            this.BtnConfirmAdmission.Visible = false;
            this.BtnConfirmAdmission.Click+=new EventHandler(OnButtonConfirmGettingOrderClick);
            this.LabelFoundInvoice.Anchor =
                ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left |
                                                      System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFoundInvoice.AutoSize = true;
            this.LabelFoundInvoice.Font = new System.Drawing.Font("Times New Roman", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFoundInvoice.Location = new System.Drawing.Point(187, 39);
            this.LabelFoundInvoice.Margin = new System.Windows.Forms.Padding(3);
            this.LabelFoundInvoice.Name = "LabelFoundInvoice";
            this.LabelFoundInvoice.Size = new System.Drawing.Size(476, 19);
            this.LabelFoundInvoice.TabIndex = 0;
            this.LabelFoundInvoice.Text = "Накладная была найдена в системе. Выберите дальнейшее действие:";
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBack.Location = new System.Drawing.Point(3, 68);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(126, 33);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.OnButtonBackClick);
            this.panel1.Controls.Add(this.LabelFoundInvoice);
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Controls.Add(this.BtnConfirmAdmission);
            this.panel1.Location = new System.Drawing.Point(14, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 114);
            this.panel1.TabIndex = 1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GeneralPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(918, 553);
            this.MinimumSize = new System.Drawing.Size(918, 553);
            this.Name = "StorekeeperSearchIncomingInvoiceView";
            this.Text = "Поиск приходной накладной";
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.PanelNotFoundInvoice.ResumeLayout(false);
            this.PanelNotFoundInvoice.PerformLayout();
            this.PanelInvoiceInfo.ResumeLayout(false);
            this.PanelInvoiceInfo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanelCurrentProduct.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel GeneralPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.MaskedTextBox TextBoxNumberInvoice;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel PanelNotFoundInvoice;
        private System.Windows.Forms.Button BtnConfirmAdmission;
        private System.Windows.Forms.Label LabelFoundInvoice;
        private System.Windows.Forms.FlowLayoutPanel PanelInvoiceInfo;
        private System.Windows.Forms.Label LabelNameOrganization;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel PanelCurrentProduct;
        private System.Windows.Forms.Label LabelOrderContent;
        private System.Windows.Forms.Label LabelProductName;
        private System.Windows.Forms.Label LabelCurrentNumberProduct;
        private System.Windows.Forms.Label LabelCurrentProductName;
        private System.Windows.Forms.Label LabelNumberProduct;
        private System.Windows.Forms.Label LabelCurrentCost;
        private System.Windows.Forms.Label LabelCurrentNumber;
        private System.Windows.Forms.Label LabelNameCurrentOrganization;
        private System.Windows.Forms.Label LabelMessage;
    }
}
