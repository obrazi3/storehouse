using System;
using System.ComponentModel;

namespace View
{
    partial class BookerCheckPaymentClientOrderView
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
            this.TextBoxClientOrderNumber = new System.Windows.Forms.MaskedTextBox();
            this.LabelInputBankAccount = new System.Windows.Forms.Label();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.ButtonCheckPaymentOrder = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.PanelInputInformation.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            this.PanelMainContainer.Controls.Add(this.PanelInputInformation);
            this.PanelMainContainer.Controls.Add(this.PanelControlButtons);
            this.PanelMainContainer.Location = new System.Drawing.Point(2, 14);
            this.PanelMainContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(752, 264);
            this.PanelMainContainer.TabIndex = 1;
            this.PanelInputInformation.Controls.Add(this.TextBoxSumPayment);
            this.PanelInputInformation.Controls.Add(this.LabelSumPayment);
            this.PanelInputInformation.Controls.Add(this.TextBoxClientOrderNumber);
            this.PanelInputInformation.Controls.Add(this.LabelInputBankAccount);
            this.PanelInputInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PanelInputInformation.Location = new System.Drawing.Point(4, 5);
            this.PanelInputInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelInputInformation.Name = "PanelInputInformation";
            this.PanelInputInformation.Size = new System.Drawing.Size(744, 179);
            this.PanelInputInformation.TabIndex = 1;
            this.TextBoxSumPayment.Location = new System.Drawing.Point(4, 129);
            this.TextBoxSumPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxSumPayment.Mask = "00000";
            this.TextBoxSumPayment.Name = "TextBoxSumPayment";
            this.TextBoxSumPayment.Size = new System.Drawing.Size(724, 28);
            this.TextBoxSumPayment.TabIndex = 3;
            this.TextBoxSumPayment.ValidatingType = typeof(int);
            this.LabelSumPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSumPayment.Location = new System.Drawing.Point(4, 92);
            this.LabelSumPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSumPayment.Name = "LabelSumPayment";
            this.LabelSumPayment.Size = new System.Drawing.Size(415, 32);
            this.LabelSumPayment.TabIndex = 2;
            this.LabelSumPayment.Text = "Введите стоимость заказа:";
            this.TextBoxClientOrderNumber.Location = new System.Drawing.Point(4, 38);
            this.TextBoxClientOrderNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxClientOrderNumber.Mask = "00000";
            this.TextBoxClientOrderNumber.Name = "TextBoxClientOrderNumber";
            this.TextBoxClientOrderNumber.Size = new System.Drawing.Size(724, 28);
            this.TextBoxClientOrderNumber.TabIndex = 1;
            this.TextBoxClientOrderNumber.ValidatingType = typeof(int);
            this.LabelInputBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInputBankAccount.Location = new System.Drawing.Point(4, 1);
            this.LabelInputBankAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInputBankAccount.Name = "LabelInputBankAccount";
            this.LabelInputBankAccount.Size = new System.Drawing.Size(415, 32);
            this.LabelInputBankAccount.TabIndex = 0;
            this.LabelInputBankAccount.Text = "Введите номер заказа клиента:";
            this.PanelControlButtons.Controls.Add(this.ButtonCheckPaymentOrder);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(3, 190);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(745, 71);
            this.PanelControlButtons.TabIndex = 8;
            this.ButtonCheckPaymentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCheckPaymentOrder.Location = new System.Drawing.Point(540, 15);
            this.ButtonCheckPaymentOrder.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCheckPaymentOrder.Name = "ButtonCheckPaymentOrder";
            this.ButtonCheckPaymentOrder.Size = new System.Drawing.Size(189, 39);
            this.ButtonCheckPaymentOrder.TabIndex = 14;
            this.ButtonCheckPaymentOrder.Text = "Проверить";
            this.ButtonCheckPaymentOrder.UseVisualStyleBackColor = true;
            this.ButtonCheckPaymentOrder.Click+=new EventHandler(OnButtonCheckOrderClick);
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(5, 15);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(131, 39);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click+=new EventHandler(OnButtonBackClick);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 279);
            this.Controls.Add(this.PanelMainContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookerCheckPaymentClientOrderView";
            this.Text = "Проверка оплата заказа клиентом";
            this.PanelMainContainer.ResumeLayout(false);
            this.PanelInputInformation.ResumeLayout(false);
            this.PanelInputInformation.PerformLayout();
            this.PanelControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Panel PanelControlButtons;
        private System.Windows.Forms.Label LabelInputBankAccount;
        private System.Windows.Forms.MaskedTextBox TextBoxClientOrderNumber;
        private System.Windows.Forms.Label LabelSumPayment;
        private System.Windows.Forms.MaskedTextBox TextBoxSumPayment;
        private System.Windows.Forms.Panel PanelInputInformation;
        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.Button ButtonCheckPaymentOrder;
    }
}

