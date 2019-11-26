﻿using System.ComponentModel;

namespace View
{
    partial class PurcpManagerInfoProviderView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelInputInformation = new System.Windows.Forms.Panel();
            this.LabelMessageRequiredFields = new System.Windows.Forms.Label();
            this.ButtonRemoveProvider = new System.Windows.Forms.Button();
            this.TextBoxIDProvider = new System.Windows.Forms.MaskedTextBox();
            this.LabelMesageInputID = new System.Windows.Forms.Label();
            this.GroupBoxInformation = new System.Windows.Forms.GroupBox();
            this.LabelCurrentEmail = new System.Windows.Forms.Label();
            this.LabelCurrentContactNumber = new System.Windows.Forms.Label();
            this.LabelProductCategories = new System.Windows.Forms.Label();
            this.LabelCurrentBankAccount = new System.Windows.Forms.Label();
            this.LabelCurrentNameOrganization = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelContactNumber = new System.Windows.Forms.Label();
            this.LabelBankAccount = new System.Windows.Forms.Label();
            this.LabelOrganizationName = new System.Windows.Forms.Label();
            this.PanelProductCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelInputInformation.SuspendLayout();
            this.GroupBoxInformation.SuspendLayout();
            this.PanelProductCategories.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.PanelInputInformation);
            this.flowLayoutPanel1.Controls.Add(this.GroupBoxInformation);
            this.flowLayoutPanel1.Controls.Add(this.PanelProductCategories);
            this.flowLayoutPanel1.Controls.Add(this.PanelControlButtons);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(926, 512);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // PanelInputInformation
            // 
            this.PanelInputInformation.Controls.Add(this.LabelMessageRequiredFields);
            this.PanelInputInformation.Controls.Add(this.ButtonRemoveProvider);
            this.PanelInputInformation.Controls.Add(this.TextBoxIDProvider);
            this.PanelInputInformation.Controls.Add(this.LabelMesageInputID);
            this.PanelInputInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PanelInputInformation.Location = new System.Drawing.Point(3, 3);
            this.PanelInputInformation.Name = "PanelInputInformation";
            this.PanelInputInformation.Size = new System.Drawing.Size(920, 105);
            this.PanelInputInformation.TabIndex = 1;
            // 
            // LabelMessageRequiredFields
            // 
            this.LabelMessageRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LabelMessageRequiredFields.Location = new System.Drawing.Point(3, 69);
            this.LabelMessageRequiredFields.Name = "LabelMessageRequiredFields";
            this.LabelMessageRequiredFields.Size = new System.Drawing.Size(897, 27);
            this.LabelMessageRequiredFields.TabIndex = 16;
            this.LabelMessageRequiredFields.Text =
                "К сожалению, поставщик с таким номером не найден. Проверьте правильность введённо" +
                "го номера и повторите попытку.\r\n";
            this.LabelMessageRequiredFields.Visible = false;
            // 
            // ButtonRemoveProvider
            // 
            this.ButtonRemoveProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRemoveProvider.Location = new System.Drawing.Point(794, 27);
            this.ButtonRemoveProvider.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRemoveProvider.Name = "ButtonRemoveProvider";
            this.ButtonRemoveProvider.Size = new System.Drawing.Size(106, 29);
            this.ButtonRemoveProvider.TabIndex = 15;
            this.ButtonRemoveProvider.Text = "Поиск";
            this.ButtonRemoveProvider.UseVisualStyleBackColor = true;
            // 
            // TextBoxIDProvider
            // 
            this.TextBoxIDProvider.Location = new System.Drawing.Point(3, 28);
            this.TextBoxIDProvider.Name = "TextBoxIDProvider";
            this.TextBoxIDProvider.Size = new System.Drawing.Size(748, 24);
            this.TextBoxIDProvider.TabIndex = 1;
            // 
            // LabelMesageInputID
            // 
            this.LabelMesageInputID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMesageInputID.Location = new System.Drawing.Point(3, 1);
            this.LabelMesageInputID.Name = "LabelMesageInputID";
            this.LabelMesageInputID.Size = new System.Drawing.Size(363, 24);
            this.LabelMesageInputID.TabIndex = 0;
            this.LabelMesageInputID.Text = "Введите идентификационный номер поставщика:";
            // 
            // GroupBoxInformation
            // 
            this.GroupBoxInformation.Controls.Add(this.LabelCurrentEmail);
            this.GroupBoxInformation.Controls.Add(this.LabelCurrentContactNumber);
            this.GroupBoxInformation.Controls.Add(this.LabelProductCategories);
            this.GroupBoxInformation.Controls.Add(this.LabelCurrentBankAccount);
            this.GroupBoxInformation.Controls.Add(this.LabelCurrentNameOrganization);
            this.GroupBoxInformation.Controls.Add(this.LabelEmail);
            this.GroupBoxInformation.Controls.Add(this.LabelContactNumber);
            this.GroupBoxInformation.Controls.Add(this.LabelBankAccount);
            this.GroupBoxInformation.Controls.Add(this.LabelOrganizationName);
            this.GroupBoxInformation.Location = new System.Drawing.Point(2, 114);
            this.GroupBoxInformation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBoxInformation.Name = "GroupBoxInformation";
            this.GroupBoxInformation.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBoxInformation.Size = new System.Drawing.Size(921, 177);
            this.GroupBoxInformation.TabIndex = 3;
            this.GroupBoxInformation.TabStop = false;
            this.GroupBoxInformation.Text = "Информация о поставщике";
            // 
            // LabelCurrentEmail
            // 
            this.LabelCurrentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LabelCurrentEmail.Location = new System.Drawing.Point(238, 119);
            this.LabelCurrentEmail.Name = "LabelCurrentEmail";
            this.LabelCurrentEmail.Size = new System.Drawing.Size(663, 18);
            this.LabelCurrentEmail.TabIndex = 13;
            // 
            // LabelCurrentContactNumber
            // 
            this.LabelCurrentContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LabelCurrentContactNumber.Location = new System.Drawing.Point(238, 89);
            this.LabelCurrentContactNumber.Name = "LabelCurrentContactNumber";
            this.LabelCurrentContactNumber.Size = new System.Drawing.Size(663, 18);
            this.LabelCurrentContactNumber.TabIndex = 12;
            // 
            // LabelProductCategories
            // 
            this.LabelProductCategories.AutoSize = true;
            this.LabelProductCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductCategories.Location = new System.Drawing.Point(6, 155);
            this.LabelProductCategories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProductCategories.Name = "LabelProductCategories";
            this.LabelProductCategories.Size = new System.Drawing.Size(145, 18);
            this.LabelProductCategories.TabIndex = 14;
            this.LabelProductCategories.Text = "Категория товаров:\r\n";
            // 
            // LabelCurrentBankAccount
            // 
            this.LabelCurrentBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LabelCurrentBankAccount.Location = new System.Drawing.Point(238, 57);
            this.LabelCurrentBankAccount.Name = "LabelCurrentBankAccount";
            this.LabelCurrentBankAccount.Size = new System.Drawing.Size(663, 18);
            this.LabelCurrentBankAccount.TabIndex = 11;
            // 
            // LabelCurrentNameOrganization
            // 
            this.LabelCurrentNameOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LabelCurrentNameOrganization.Location = new System.Drawing.Point(238, 27);
            this.LabelCurrentNameOrganization.Name = "LabelCurrentNameOrganization";
            this.LabelCurrentNameOrganization.Size = new System.Drawing.Size(663, 18);
            this.LabelCurrentNameOrganization.TabIndex = 10;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEmail.Location = new System.Drawing.Point(6, 119);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(195, 18);
            this.LabelEmail.TabIndex = 9;
            this.LabelEmail.Text = "Адрес электронной почты:";
            // 
            // LabelContactNumber
            // 
            this.LabelContactNumber.AutoSize = true;
            this.LabelContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelContactNumber.Location = new System.Drawing.Point(6, 89);
            this.LabelContactNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelContactNumber.Name = "LabelContactNumber";
            this.LabelContactNumber.Size = new System.Drawing.Size(144, 18);
            this.LabelContactNumber.TabIndex = 4;
            this.LabelContactNumber.Text = "Контактный номер:";
            // 
            // LabelBankAccount
            // 
            this.LabelBankAccount.AutoSize = true;
            this.LabelBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBankAccount.Location = new System.Drawing.Point(6, 57);
            this.LabelBankAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBankAccount.Name = "LabelBankAccount";
            this.LabelBankAccount.Size = new System.Drawing.Size(130, 18);
            this.LabelBankAccount.TabIndex = 2;
            this.LabelBankAccount.Text = "Банковский счёт:";
            // 
            // LabelOrganizationName
            // 
            this.LabelOrganizationName.AutoSize = true;
            this.LabelOrganizationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOrganizationName.Location = new System.Drawing.Point(6, 27);
            this.LabelOrganizationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelOrganizationName.Name = "LabelOrganizationName";
            this.LabelOrganizationName.Size = new System.Drawing.Size(170, 18);
            this.LabelOrganizationName.TabIndex = 0;
            this.LabelOrganizationName.Text = "Название организации:";
            // 
            // PanelProductCategories
            // 
            this.PanelProductCategories.AutoScroll = true;
            this.PanelProductCategories.Controls.Add(this.label4);
            this.PanelProductCategories.Location = new System.Drawing.Point(3, 297);
            this.PanelProductCategories.Name = "PanelProductCategories";
            this.PanelProductCategories.Size = new System.Drawing.Size(920, 118);
            this.PanelProductCategories.TabIndex = 4;
            // 
            // PanelControlButtons
            // 
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(2, 419);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(921, 91);
            this.PanelControlButtons.TabIndex = 8;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(6, 54);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(114, 29);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(897, 18);
            this.label4.TabIndex = 14;
            // 
            // PurcpManagerInfoProviderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PurcpManagerInfoProviderView";
            this.Text = "Просмотреть информацию о поставщике";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanelInputInformation.ResumeLayout(false);
            this.PanelInputInformation.PerformLayout();
            this.GroupBoxInformation.ResumeLayout(false);
            this.GroupBoxInformation.PerformLayout();
            this.PanelProductCategories.ResumeLayout(false);
            this.PanelControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LabelMesageInputID;
        private System.Windows.Forms.MaskedTextBox TextBoxIDProvider;
        private System.Windows.Forms.Panel PanelInputInformation;
        private System.Windows.Forms.Button ButtonRemoveProvider;
        private System.Windows.Forms.Label LabelMessageRequiredFields;
        private System.Windows.Forms.Label LabelProductCategories;
        private System.Windows.Forms.Label LabelOrganizationName;
        private System.Windows.Forms.Label LabelBankAccount;
        private System.Windows.Forms.Label LabelContactNumber;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelCurrentBankAccount;
        private System.Windows.Forms.Label LabelCurrentContactNumber;
        private System.Windows.Forms.Label LabelCurrentEmail;
        private System.Windows.Forms.Label LabelCurrentNameOrganization;
        private System.Windows.Forms.GroupBox GroupBoxInformation;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Panel PanelControlButtons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel PanelProductCategories;
    }
}

