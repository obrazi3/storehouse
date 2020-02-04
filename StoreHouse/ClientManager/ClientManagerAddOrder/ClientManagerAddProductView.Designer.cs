using System;

namespace View
{
    partial class ClientManagerAddProductView
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
            this.PanelProductCharacteristic = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.LabelCurrentProductName = new System.Windows.Forms.Label();
            this.LabelProductGroup = new System.Windows.Forms.Label();
            this.LabelCurrentProductGroup = new System.Windows.Forms.Label();
            this.LabelProductCategory = new System.Windows.Forms.Label();
            this.LabelCurrentProductCategory = new System.Windows.Forms.Label();
            this.LabelProductionCountry = new System.Windows.Forms.Label();
            this.LabelCurrentCountryProduction = new System.Windows.Forms.Label();
            this.LabelMeasure = new System.Windows.Forms.Label();
            this.LabelCurrentMeasure = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelCurrentCost = new System.Windows.Forms.Label();
            this.LabelChoiceNumberOfProduct = new System.Windows.Forms.Label();
            this.NumericUpDownNumberProduct = new System.Windows.Forms.NumericUpDown();
            this.PanelForButtons = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.PanelProductCharacteristic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumberProduct)).BeginInit();
            this.PanelForButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainContainer
            // 
            this.PanelMainContainer.Controls.Add(this.PanelProductCharacteristic);
            this.PanelMainContainer.Controls.Add(this.PanelForButtons);
            this.PanelMainContainer.Location = new System.Drawing.Point(4, 2);
            this.PanelMainContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(592, 426);
            this.PanelMainContainer.TabIndex = 0;
            // 
            // PanelProductCharacteristic
            // 
            this.PanelProductCharacteristic.Controls.Add(this.LabelProductName);
            this.PanelProductCharacteristic.Controls.Add(this.LabelCurrentProductName);
            this.PanelProductCharacteristic.Controls.Add(this.LabelProductGroup);
            this.PanelProductCharacteristic.Controls.Add(this.LabelCurrentProductGroup);
            this.PanelProductCharacteristic.Controls.Add(this.LabelProductCategory);
            this.PanelProductCharacteristic.Controls.Add(this.LabelCurrentProductCategory);
            this.PanelProductCharacteristic.Controls.Add(this.LabelProductionCountry);
            this.PanelProductCharacteristic.Controls.Add(this.LabelCurrentCountryProduction);
            this.PanelProductCharacteristic.Controls.Add(this.LabelMeasure);
            this.PanelProductCharacteristic.Controls.Add(this.LabelCurrentMeasure);
            this.PanelProductCharacteristic.Controls.Add(this.LabelCost);
            this.PanelProductCharacteristic.Controls.Add(this.LabelCurrentCost);
            this.PanelProductCharacteristic.Controls.Add(this.LabelChoiceNumberOfProduct);
            this.PanelProductCharacteristic.Controls.Add(this.NumericUpDownNumberProduct);
            this.PanelProductCharacteristic.Location = new System.Drawing.Point(2, 2);
            this.PanelProductCharacteristic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelProductCharacteristic.Name = "PanelProductCharacteristic";
            this.PanelProductCharacteristic.Size = new System.Drawing.Size(590, 349);
            this.PanelProductCharacteristic.TabIndex = 3;
            // 
            // LabelProductName
            // 
            this.LabelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductName.Location = new System.Drawing.Point(2, 4);
            this.LabelProductName.Margin = new System.Windows.Forms.Padding(2, 4, 0, 4);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(152, 19);
            this.LabelProductName.TabIndex = 0;
            this.LabelProductName.Text = "Название продукта:";
            // 
            // LabelCurrentProductName
            // 
            this.LabelCurrentProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentProductName.Location = new System.Drawing.Point(154, 4);
            this.LabelCurrentProductName.Margin = new System.Windows.Forms.Padding(0, 4, 2, 4);
            this.LabelCurrentProductName.Name = "LabelCurrentProductName";
            this.LabelCurrentProductName.Size = new System.Drawing.Size(434, 19);
            this.LabelCurrentProductName.TabIndex = 1;
            this.LabelCurrentProductName.Text = "конктретный продукт";
            // 
            // LabelProductGroup
            // 
            this.LabelProductGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductGroup.Location = new System.Drawing.Point(2, 31);
            this.LabelProductGroup.Margin = new System.Windows.Forms.Padding(2, 4, 0, 4);
            this.LabelProductGroup.Name = "LabelProductGroup";
            this.LabelProductGroup.Size = new System.Drawing.Size(135, 19);
            this.LabelProductGroup.TabIndex = 2;
            this.LabelProductGroup.Text = "Группа продукта:";
            // 
            // LabelCurrentProductGroup
            // 
            this.LabelCurrentProductGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentProductGroup.Location = new System.Drawing.Point(137, 31);
            this.LabelCurrentProductGroup.Margin = new System.Windows.Forms.Padding(0, 4, 2, 4);
            this.LabelCurrentProductGroup.Name = "LabelCurrentProductGroup";
            this.LabelCurrentProductGroup.Size = new System.Drawing.Size(442, 19);
            this.LabelCurrentProductGroup.TabIndex = 3;
            this.LabelCurrentProductGroup.Text = "конкретная группа";
            // 
            // LabelProductCategory
            // 
            this.LabelProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductCategory.Location = new System.Drawing.Point(2, 58);
            this.LabelProductCategory.Margin = new System.Windows.Forms.Padding(2, 4, 0, 4);
            this.LabelProductCategory.Name = "LabelProductCategory";
            this.LabelProductCategory.Size = new System.Drawing.Size(152, 19);
            this.LabelProductCategory.TabIndex = 4;
            this.LabelProductCategory.Text = "Категория продукта:";
            // 
            // LabelCurrentProductCategory
            // 
            this.LabelCurrentProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentProductCategory.Location = new System.Drawing.Point(154, 58);
            this.LabelCurrentProductCategory.Margin = new System.Windows.Forms.Padding(0, 4, 2, 4);
            this.LabelCurrentProductCategory.Name = "LabelCurrentProductCategory";
            this.LabelCurrentProductCategory.Size = new System.Drawing.Size(428, 19);
            this.LabelCurrentProductCategory.TabIndex = 5;
            this.LabelCurrentProductCategory.Text = "Категория конкретная ";
            // 
            // LabelProductionCountry
            // 
            this.LabelProductionCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductionCountry.Location = new System.Drawing.Point(2, 85);
            this.LabelProductionCountry.Margin = new System.Windows.Forms.Padding(2, 4, 0, 4);
            this.LabelProductionCountry.Name = "LabelProductionCountry";
            this.LabelProductionCountry.Size = new System.Drawing.Size(287, 19);
            this.LabelProductionCountry.TabIndex = 6;
            this.LabelProductionCountry.Text = "Страна производства(происхождения):";
            // 
            // LabelCurrentCountryProduction
            // 
            this.LabelCurrentCountryProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentCountryProduction.Location = new System.Drawing.Point(289, 85);
            this.LabelCurrentCountryProduction.Margin = new System.Windows.Forms.Padding(0, 4, 2, 4);
            this.LabelCurrentCountryProduction.Name = "LabelCurrentCountryProduction";
            this.LabelCurrentCountryProduction.Size = new System.Drawing.Size(299, 19);
            this.LabelCurrentCountryProduction.TabIndex = 7;
            this.LabelCurrentCountryProduction.Text = "конкретная страна";
            // 
            // LabelMeasure
            // 
            this.LabelMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMeasure.Location = new System.Drawing.Point(2, 112);
            this.LabelMeasure.Margin = new System.Windows.Forms.Padding(2, 4, 0, 4);
            this.LabelMeasure.Name = "LabelMeasure";
            this.LabelMeasure.Size = new System.Drawing.Size(163, 19);
            this.LabelMeasure.TabIndex = 8;
            this.LabelMeasure.Text = "Единицы измерения: ";
            // 
            // LabelCurrentMeasure
            // 
            this.LabelCurrentMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentMeasure.Location = new System.Drawing.Point(165, 112);
            this.LabelCurrentMeasure.Margin = new System.Windows.Forms.Padding(0, 4, 2, 4);
            this.LabelCurrentMeasure.Name = "LabelCurrentMeasure";
            this.LabelCurrentMeasure.Size = new System.Drawing.Size(415, 19);
            this.LabelCurrentMeasure.TabIndex = 9;
            this.LabelCurrentMeasure.Text = "Конкретные единицы измерения: ";
            // 
            // LabelCost
            // 
            this.LabelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCost.Location = new System.Drawing.Point(2, 139);
            this.LabelCost.Margin = new System.Windows.Forms.Padding(2, 4, 0, 4);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(90, 19);
            this.LabelCost.TabIndex = 10;
            this.LabelCost.Text = "Стоимость: ";
            // 
            // LabelCurrentCost
            // 
            this.LabelCurrentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCurrentCost.Location = new System.Drawing.Point(92, 139);
            this.LabelCurrentCost.Margin = new System.Windows.Forms.Padding(0, 4, 2, 4);
            this.LabelCurrentCost.Name = "LabelCurrentCost";
            this.LabelCurrentCost.Size = new System.Drawing.Size(488, 19);
            this.LabelCurrentCost.TabIndex = 11;
            this.LabelCurrentCost.Text = "Конкретная стоимость";
            // 
            // LabelChoiceNumberOfProduct
            // 
            this.LabelChoiceNumberOfProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelChoiceNumberOfProduct.Location = new System.Drawing.Point(2, 174);
            this.LabelChoiceNumberOfProduct.Margin = new System.Windows.Forms.Padding(2, 12, 2, 4);
            this.LabelChoiceNumberOfProduct.Name = "LabelChoiceNumberOfProduct";
            this.LabelChoiceNumberOfProduct.Size = new System.Drawing.Size(378, 19);
            this.LabelChoiceNumberOfProduct.TabIndex = 12;
            this.LabelChoiceNumberOfProduct.Text = "Выберите количество товара для добавления в заказ:";
            // 
            // NumericUpDownNumberProduct
            // 
            this.NumericUpDownNumberProduct.Location = new System.Drawing.Point(384, 176);
            this.NumericUpDownNumberProduct.Margin = new System.Windows.Forms.Padding(2, 14, 2, 2);
            this.NumericUpDownNumberProduct.Name = "NumericUpDownNumberProduct";
            this.NumericUpDownNumberProduct.Size = new System.Drawing.Size(90, 20);
            this.NumericUpDownNumberProduct.TabIndex = 13;
            // 
            // PanelForButtons
            // 
            this.PanelForButtons.Controls.Add(this.ButtonCancel);
            this.PanelForButtons.Controls.Add(this.ButtonAddProduct);
            this.PanelForButtons.Location = new System.Drawing.Point(2, 355);
            this.PanelForButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelForButtons.Name = "PanelForButtons";
            this.PanelForButtons.Size = new System.Drawing.Size(590, 68);
            this.PanelForButtons.TabIndex = 4;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancel.Location = new System.Drawing.Point(5, 40);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(76, 25);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.OnButtonCancelClick);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddProduct.Location = new System.Drawing.Point(449, 40);
            this.ButtonAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(141, 25);
            this.ButtonAddProduct.TabIndex = 3;
            this.ButtonAddProduct.Text = "Добавить продукт";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.OnButtonAddProductClick);
            // 
            // ClientManagerAddProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 438);
            this.Controls.Add(this.PanelMainContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(618, 477);
            this.MinimumSize = new System.Drawing.Size(618, 477);
            this.Name = "ClientManagerAddProductView";
            this.Text = "Добавление продукта";
            this.PanelMainContainer.ResumeLayout(false);
            this.PanelProductCharacteristic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownNumberProduct)).EndInit();
            this.PanelForButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.FlowLayoutPanel PanelProductCharacteristic;
        private System.Windows.Forms.Label LabelProductName;
        private System.Windows.Forms.Label LabelCurrentProductName;
        private System.Windows.Forms.Label LabelProductGroup;
        private System.Windows.Forms.Label LabelCurrentProductGroup;
        private System.Windows.Forms.Label LabelProductCategory;
        private System.Windows.Forms.Label LabelCurrentProductCategory;
        private System.Windows.Forms.Label LabelProductionCountry;
        private System.Windows.Forms.Label LabelCurrentCountryProduction;
        private System.Windows.Forms.Label LabelMeasure;
        private System.Windows.Forms.Label LabelCurrentMeasure;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelCurrentCost;
        private System.Windows.Forms.Label LabelChoiceNumberOfProduct;
        private System.Windows.Forms.NumericUpDown NumericUpDownNumberProduct;
        private System.Windows.Forms.Panel PanelForButtons;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAddProduct;
    }
}
