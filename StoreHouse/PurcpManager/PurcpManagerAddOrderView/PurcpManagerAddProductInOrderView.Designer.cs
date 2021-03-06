﻿using System;
using System.ComponentModel;

namespace View
{
    partial class PurcpManagerAddProductInOrderView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.GroupBoxProductInfo = new System.Windows.Forms.GroupBox();
            this.LabelMeasure = new System.Windows.Forms.Label();
            this.CheckBoxMeasure = new System.Windows.Forms.CheckedListBox();
            this.TextBoxProductCost = new System.Windows.Forms.MaskedTextBox();
            this.LabelProductCost = new System.Windows.Forms.Label();
            this.TextBoxExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.LabelExpirationDate = new System.Windows.Forms.Label();
            this.TextBoxCountryProduction = new System.Windows.Forms.MaskedTextBox();
            this.LabelCountryProduction = new System.Windows.Forms.Label();
            this.TextBoxProductGroup = new System.Windows.Forms.MaskedTextBox();
            this.LabelProductGroup = new System.Windows.Forms.Label();
            this.TextBoxProductCategory = new System.Windows.Forms.MaskedTextBox();
            this.LabelProductCategory = new System.Windows.Forms.Label();
            this.TextBoxProductName = new System.Windows.Forms.MaskedTextBox();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.GroupBoxLotInfo = new System.Windows.Forms.GroupBox();
            this.TextBoxNumberOfProduct = new System.Windows.Forms.MaskedTextBox();
            this.LabelNumberOfProduct = new System.Windows.Forms.Label();
            this.TextBoxProductionDate = new System.Windows.Forms.MaskedTextBox();
            this.LabelProductionDate = new System.Windows.Forms.Label();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.LabelMessageRequiredFields = new System.Windows.Forms.Label();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.GroupBoxProductInfo.SuspendLayout();
            this.GroupBoxLotInfo.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainContainer
            // 
            this.PanelMainContainer.Controls.Add(this.GroupBoxProductInfo);
            this.PanelMainContainer.Controls.Add(this.GroupBoxLotInfo);
            this.PanelMainContainer.Controls.Add(this.PanelControlButtons);
            this.PanelMainContainer.Location = new System.Drawing.Point(2, 1);
            this.PanelMainContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(1058, 545);
            this.PanelMainContainer.TabIndex = 0;
            // 
            // GroupBoxProductInfo
            // 
            this.GroupBoxProductInfo.Controls.Add(this.LabelMeasure);
            this.GroupBoxProductInfo.Controls.Add(this.CheckBoxMeasure);
            this.GroupBoxProductInfo.Controls.Add(this.TextBoxProductCost);
            this.GroupBoxProductInfo.Controls.Add(this.LabelProductCost);
            this.GroupBoxProductInfo.Controls.Add(this.TextBoxExpirationDate);
            this.GroupBoxProductInfo.Controls.Add(this.LabelExpirationDate);
            this.GroupBoxProductInfo.Controls.Add(this.TextBoxCountryProduction);
            this.GroupBoxProductInfo.Controls.Add(this.LabelCountryProduction);
            this.GroupBoxProductInfo.Controls.Add(this.TextBoxProductGroup);
            this.GroupBoxProductInfo.Controls.Add(this.LabelProductGroup);
            this.GroupBoxProductInfo.Controls.Add(this.TextBoxProductCategory);
            this.GroupBoxProductInfo.Controls.Add(this.LabelProductCategory);
            this.GroupBoxProductInfo.Controls.Add(this.TextBoxProductName);
            this.GroupBoxProductInfo.Controls.Add(this.LabelProductName);
            this.GroupBoxProductInfo.Location = new System.Drawing.Point(2, 3);
            this.GroupBoxProductInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBoxProductInfo.Name = "GroupBoxProductInfo";
            this.GroupBoxProductInfo.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBoxProductInfo.Size = new System.Drawing.Size(1055, 282);
            this.GroupBoxProductInfo.TabIndex = 0;
            this.GroupBoxProductInfo.TabStop = false;
            this.GroupBoxProductInfo.Text = "Информация о продукте";
            // 
            // LabelMeasure
            // 
            this.LabelMeasure.AutoSize = true;
            this.LabelMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMeasure.Location = new System.Drawing.Point(22, 191);
            this.LabelMeasure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMeasure.Name = "LabelMeasure";
            this.LabelMeasure.Size = new System.Drawing.Size(203, 24);
            this.LabelMeasure.TabIndex = 15;
            this.LabelMeasure.Text = "Единицы измерения*";
            // 
            // CheckBoxMeasure
            // 
            this.CheckBoxMeasure.FormattingEnabled = true;
            this.CheckBoxMeasure.Items.AddRange(new object[] {
            "Литры",
            "Килограммы",
            "Штуки"});
            this.CheckBoxMeasure.Location = new System.Drawing.Point(22, 213);
            this.CheckBoxMeasure.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CheckBoxMeasure.Name = "CheckBoxMeasure";
            this.CheckBoxMeasure.Size = new System.Drawing.Size(206, 38);
            this.CheckBoxMeasure.TabIndex = 14;
            // 
            // TextBoxProductCost
            // 
            this.TextBoxProductCost.Location = new System.Drawing.Point(790, 135);
            this.TextBoxProductCost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxProductCost.Mask = "00000";
            this.TextBoxProductCost.Name = "TextBoxProductCost";
            this.TextBoxProductCost.Size = new System.Drawing.Size(236, 22);
            this.TextBoxProductCost.TabIndex = 13;
            this.TextBoxProductCost.ValidatingType = typeof(int);
            // 
            // LabelProductCost
            // 
            this.LabelProductCost.AutoSize = true;
            this.LabelProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductCost.Location = new System.Drawing.Point(738, 113);
            this.LabelProductCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProductCost.Name = "LabelProductCost";
            this.LabelProductCost.Size = new System.Drawing.Size(316, 24);
            this.LabelProductCost.TabIndex = 12;
            this.LabelProductCost.Text = "Стоимость единицы товара, руб.*";
            // 
            // TextBoxExpirationDate
            // 
            this.TextBoxExpirationDate.Location = new System.Drawing.Point(393, 135);
            this.TextBoxExpirationDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxExpirationDate.Mask = "000";
            this.TextBoxExpirationDate.Name = "TextBoxExpirationDate";
            this.TextBoxExpirationDate.Size = new System.Drawing.Size(270, 22);
            this.TextBoxExpirationDate.TabIndex = 11;
            // 
            // LabelExpirationDate
            // 
            this.LabelExpirationDate.AutoSize = true;
            this.LabelExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelExpirationDate.Location = new System.Drawing.Point(393, 113);
            this.LabelExpirationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelExpirationDate.Name = "LabelExpirationDate";
            this.LabelExpirationDate.Size = new System.Drawing.Size(151, 24);
            this.LabelExpirationDate.TabIndex = 10;
            this.LabelExpirationDate.Text = "Срок годности*";
            // 
            // TextBoxCountryProduction
            // 
            this.TextBoxCountryProduction.Location = new System.Drawing.Point(22, 135);
            this.TextBoxCountryProduction.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxCountryProduction.Name = "TextBoxCountryProduction";
            this.TextBoxCountryProduction.Size = new System.Drawing.Size(258, 22);
            this.TextBoxCountryProduction.TabIndex = 9;
            // 
            // LabelCountryProduction
            // 
            this.LabelCountryProduction.AutoSize = true;
            this.LabelCountryProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCountryProduction.Location = new System.Drawing.Point(22, 113);
            this.LabelCountryProduction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCountryProduction.Name = "LabelCountryProduction";
            this.LabelCountryProduction.Size = new System.Drawing.Size(216, 24);
            this.LabelCountryProduction.TabIndex = 8;
            this.LabelCountryProduction.Text = "Страна производства*";
            // 
            // TextBoxProductGroup
            // 
            this.TextBoxProductGroup.Location = new System.Drawing.Point(790, 51);
            this.TextBoxProductGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxProductGroup.Name = "TextBoxProductGroup";
            this.TextBoxProductGroup.Size = new System.Drawing.Size(236, 22);
            this.TextBoxProductGroup.TabIndex = 7;
            // 
            // LabelProductGroup
            // 
            this.LabelProductGroup.AutoSize = true;
            this.LabelProductGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductGroup.Location = new System.Drawing.Point(790, 29);
            this.LabelProductGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProductGroup.Name = "LabelProductGroup";
            this.LabelProductGroup.Size = new System.Drawing.Size(200, 24);
            this.LabelProductGroup.TabIndex = 6;
            this.LabelProductGroup.Text = "Продуктовая группа*";
            // 
            // TextBoxProductCategory
            // 
            this.TextBoxProductCategory.Location = new System.Drawing.Point(393, 51);
            this.TextBoxProductCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxProductCategory.Name = "TextBoxProductCategory";
            this.TextBoxProductCategory.Size = new System.Drawing.Size(270, 22);
            this.TextBoxProductCategory.TabIndex = 5;
            // 
            // LabelProductCategory
            // 
            this.LabelProductCategory.AutoSize = true;
            this.LabelProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductCategory.Location = new System.Drawing.Point(393, 29);
            this.LabelProductCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProductCategory.Name = "LabelProductCategory";
            this.LabelProductCategory.Size = new System.Drawing.Size(231, 24);
            this.LabelProductCategory.TabIndex = 4;
            this.LabelProductCategory.Text = "Продуктовая категория*";
            // 
            // TextBoxProductName
            // 
            this.TextBoxProductName.Location = new System.Drawing.Point(22, 51);
            this.TextBoxProductName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxProductName.Name = "TextBoxProductName";
            this.TextBoxProductName.Size = new System.Drawing.Size(258, 22);
            this.TextBoxProductName.TabIndex = 3;
            // 
            // LabelProductName
            // 
            this.LabelProductName.AutoSize = true;
            this.LabelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductName.Location = new System.Drawing.Point(22, 29);
            this.LabelProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(192, 24);
            this.LabelProductName.TabIndex = 2;
            this.LabelProductName.Text = "Название продукта*";
            // 
            // GroupBoxLotInfo
            // 
            this.GroupBoxLotInfo.Controls.Add(this.TextBoxNumberOfProduct);
            this.GroupBoxLotInfo.Controls.Add(this.LabelNumberOfProduct);
            this.GroupBoxLotInfo.Controls.Add(this.TextBoxProductionDate);
            this.GroupBoxLotInfo.Controls.Add(this.LabelProductionDate);
            this.GroupBoxLotInfo.Location = new System.Drawing.Point(2, 291);
            this.GroupBoxLotInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBoxLotInfo.Name = "GroupBoxLotInfo";
            this.GroupBoxLotInfo.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBoxLotInfo.Size = new System.Drawing.Size(1055, 137);
            this.GroupBoxLotInfo.TabIndex = 1;
            this.GroupBoxLotInfo.TabStop = false;
            this.GroupBoxLotInfo.Text = "Информация о поставке";
            // 
            // TextBoxNumberOfProduct
            // 
            this.TextBoxNumberOfProduct.Location = new System.Drawing.Point(327, 54);
            this.TextBoxNumberOfProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxNumberOfProduct.Mask = "00000";
            this.TextBoxNumberOfProduct.Name = "TextBoxNumberOfProduct";
            this.TextBoxNumberOfProduct.Size = new System.Drawing.Size(270, 22);
            this.TextBoxNumberOfProduct.TabIndex = 15;
            this.TextBoxNumberOfProduct.ValidatingType = typeof(int);
            // 
            // LabelNumberOfProduct
            // 
            this.LabelNumberOfProduct.AutoSize = true;
            this.LabelNumberOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumberOfProduct.Location = new System.Drawing.Point(327, 32);
            this.LabelNumberOfProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNumberOfProduct.Name = "LabelNumberOfProduct";
            this.LabelNumberOfProduct.Size = new System.Drawing.Size(264, 24);
            this.LabelNumberOfProduct.TabIndex = 14;
            this.LabelNumberOfProduct.Text = "Количество единиц товара*";
            // 
            // TextBoxProductionDate
            // 
            this.TextBoxProductionDate.Location = new System.Drawing.Point(7, 54);
            this.TextBoxProductionDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxProductionDate.Mask = "00/00/0000";
            this.TextBoxProductionDate.Name = "TextBoxProductionDate";
            this.TextBoxProductionDate.Size = new System.Drawing.Size(270, 22);
            this.TextBoxProductionDate.TabIndex = 13;
            this.TextBoxProductionDate.ValidatingType = typeof(System.DateTime);
            // 
            // LabelProductionDate
            // 
            this.LabelProductionDate.AutoSize = true;
            this.LabelProductionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductionDate.Location = new System.Drawing.Point(7, 32);
            this.LabelProductionDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProductionDate.Name = "LabelProductionDate";
            this.LabelProductionDate.Size = new System.Drawing.Size(195, 24);
            this.LabelProductionDate.TabIndex = 12;
            this.LabelProductionDate.Text = "Дата производства*";
            // 
            // PanelControlButtons
            // 
            this.PanelControlButtons.Controls.Add(this.LabelMessageRequiredFields);
            this.PanelControlButtons.Controls.Add(this.ButtonAddProduct);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(2, 432);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(1050, 113);
            this.PanelControlButtons.TabIndex = 6;
            // 
            // LabelMessageRequiredFields
            // 
            this.LabelMessageRequiredFields.AutoSize = true;
            this.LabelMessageRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessageRequiredFields.Location = new System.Drawing.Point(115, 22);
            this.LabelMessageRequiredFields.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMessageRequiredFields.Name = "LabelMessageRequiredFields";
            this.LabelMessageRequiredFields.Size = new System.Drawing.Size(844, 24);
            this.LabelMessageRequiredFields.TabIndex = 2;
            this.LabelMessageRequiredFields.Text = "Были введены не все обязательные поля(*). Проверьте ввод и повторите попытку ещё " +
    "раз.";
            this.LabelMessageRequiredFields.Visible = false;
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddProduct.Location = new System.Drawing.Point(847, 81);
            this.ButtonAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(170, 31);
            this.ButtonAddProduct.TabIndex = 1;
            this.ButtonAddProduct.Text = "Добавить продукт";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.OnButtonAddProductClick);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(14, 81);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(130, 31);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            // 
            // PurcpManagerAddProductInOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 549);
            this.Controls.Add(this.PanelMainContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1082, 596);
            this.MinimumSize = new System.Drawing.Size(1082, 596);
            this.Name = "PurcpManagerAddProductInOrderView";
            this.Text = "PurcpManagerAddOrderSecondStepView";
            this.PanelMainContainer.ResumeLayout(false);
            this.GroupBoxProductInfo.ResumeLayout(false);
            this.GroupBoxProductInfo.PerformLayout();
            this.GroupBoxLotInfo.ResumeLayout(false);
            this.GroupBoxLotInfo.PerformLayout();
            this.PanelControlButtons.ResumeLayout(false);
            this.PanelControlButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelMessageRequiredFields;
        private System.Windows.Forms.Panel PanelControlButtons;
        private System.Windows.Forms.MaskedTextBox TextBoxProductGroup;
        private System.Windows.Forms.Label LabelProductGroup;
        private System.Windows.Forms.MaskedTextBox TextBoxProductCategory;
        private System.Windows.Forms.Label LabelProductCategory;
        private System.Windows.Forms.MaskedTextBox TextBoxProductName;
        private System.Windows.Forms.Label LabelProductName;
        private System.Windows.Forms.MaskedTextBox TextBoxCountryProduction;
        private System.Windows.Forms.Label LabelCountryProduction;
        private System.Windows.Forms.MaskedTextBox TextBoxExpirationDate;
        private System.Windows.Forms.Label LabelExpirationDate;
        private System.Windows.Forms.MaskedTextBox TextBoxProductCost;
        private System.Windows.Forms.Label LabelProductCost;
        private System.Windows.Forms.MaskedTextBox TextBoxNumberOfProduct;
        private System.Windows.Forms.Label LabelNumberOfProduct;
        private System.Windows.Forms.MaskedTextBox TextBoxProductionDate;
        private System.Windows.Forms.Label LabelProductionDate;
        private System.Windows.Forms.GroupBox GroupBoxLotInfo;
        private System.Windows.Forms.Label LabelMeasure;
        private System.Windows.Forms.CheckedListBox CheckBoxMeasure;
        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.GroupBox GroupBoxProductInfo;
        private System.Windows.Forms.Button ButtonAddProduct;
    }
}

