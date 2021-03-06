﻿using System.ComponentModel;

namespace View
{
    partial class BookerPayProviderOrderView
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
            this.PanelInputInformation = new System.Windows.Forms.Panel();
            this.TextBoxSumPayment = new System.Windows.Forms.MaskedTextBox();
            this.LabelSumPayment = new System.Windows.Forms.Label();
            this.TextBoxBankAccount = new System.Windows.Forms.MaskedTextBox();
            this.LabelInputBankAccount = new System.Windows.Forms.Label();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.ButtonPayOrder = new System.Windows.Forms.Button();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.PanelInputInformation.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainContainer
            // 
            this.PanelMainContainer.Controls.Add(this.PanelInputInformation);
            this.PanelMainContainer.Controls.Add(this.PanelControlButtons);
            this.PanelMainContainer.Location = new System.Drawing.Point(4, 9);
            this.PanelMainContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(752, 348);
            this.PanelMainContainer.TabIndex = 0;
            // 
            // PanelInputInformation
            // 
            this.PanelInputInformation.Controls.Add(this.TextBoxSumPayment);
            this.PanelInputInformation.Controls.Add(this.LabelSumPayment);
            this.PanelInputInformation.Controls.Add(this.TextBoxBankAccount);
            this.PanelInputInformation.Controls.Add(this.LabelInputBankAccount);
            this.PanelInputInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PanelInputInformation.Location = new System.Drawing.Point(4, 5);
            this.PanelInputInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelInputInformation.Name = "PanelInputInformation";
            this.PanelInputInformation.Size = new System.Drawing.Size(744, 179);
            this.PanelInputInformation.TabIndex = 1;
            // 
            // TextBoxSumPayment
            // 
            this.TextBoxSumPayment.Location = new System.Drawing.Point(4, 129);
            this.TextBoxSumPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxSumPayment.Mask = "00000";
            this.TextBoxSumPayment.Name = "TextBoxSumPayment";
            this.TextBoxSumPayment.Size = new System.Drawing.Size(724, 28);
            this.TextBoxSumPayment.TabIndex = 3;
            this.TextBoxSumPayment.ValidatingType = typeof(int);
            // 
            // LabelSumPayment
            // 
            this.LabelSumPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSumPayment.Location = new System.Drawing.Point(4, 92);
            this.LabelSumPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSumPayment.Name = "LabelSumPayment";
            this.LabelSumPayment.Size = new System.Drawing.Size(415, 32);
            this.LabelSumPayment.TabIndex = 2;
            this.LabelSumPayment.Text = "Введите стоимость заказа:";
            // 
            // TextBoxBankAccount
            // 
            this.TextBoxBankAccount.Location = new System.Drawing.Point(4, 38);
            this.TextBoxBankAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxBankAccount.Mask = "00000";
            this.TextBoxBankAccount.Name = "TextBoxBankAccount";
            this.TextBoxBankAccount.Size = new System.Drawing.Size(724, 28);
            this.TextBoxBankAccount.TabIndex = 1;
            this.TextBoxBankAccount.ValidatingType = typeof(int);
            // 
            // LabelInputBankAccount
            // 
            this.LabelInputBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInputBankAccount.Location = new System.Drawing.Point(4, 1);
            this.LabelInputBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInputBankAccount.Name = "LabelInputBankAccount";
            this.LabelInputBankAccount.Size = new System.Drawing.Size(415, 32);
            this.LabelInputBankAccount.TabIndex = 0;
            this.LabelInputBankAccount.Text = "Введите номер счёта поставщика:";
            // 
            // PanelControlButtons
            // 
            this.PanelControlButtons.Controls.Add(this.ButtonPayOrder);
            this.PanelControlButtons.Controls.Add(this.LabelMessage);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(3, 190);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(745, 168);
            this.PanelControlButtons.TabIndex = 8;
            // 
            // ButtonPayOrder
            // 
            this.ButtonPayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPayOrder.Location = new System.Drawing.Point(541, 115);
            this.ButtonPayOrder.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPayOrder.Name = "ButtonPayOrder";
            this.ButtonPayOrder.Size = new System.Drawing.Size(189, 39);
            this.ButtonPayOrder.TabIndex = 14;
            this.ButtonPayOrder.Text = "Оплатить";
            this.ButtonPayOrder.UseVisualStyleBackColor = true;
            this.ButtonPayOrder.Click += new System.EventHandler(this.OnButtonPayClick);
            // 
            // LabelMessage
            // 
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LabelMessage.Location = new System.Drawing.Point(7, 14);
            this.LabelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(735, 82);
            this.LabelMessage.TabIndex = 2;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(5, 115);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(131, 39);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            // 
            // BookerPayProviderOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 360);
            this.Controls.Add(this.PanelMainContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(775, 407);
            this.MinimumSize = new System.Drawing.Size(775, 407);
            this.Name = "BookerPayProviderOrderView";
            this.Text = "Оплата поставки от поставщика";
            this.PanelMainContainer.ResumeLayout(false);
            this.PanelInputInformation.ResumeLayout(false);
            this.PanelInputInformation.PerformLayout();
            this.PanelControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.Panel PanelInputInformation;
        private System.Windows.Forms.MaskedTextBox TextBoxBankAccount;
        private System.Windows.Forms.Label LabelInputBankAccount;
        private System.Windows.Forms.Panel PanelControlButtons;
        private System.Windows.Forms.Button ButtonPayOrder;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.MaskedTextBox TextBoxSumPayment;
        private System.Windows.Forms.Label LabelSumPayment;
    }
}

