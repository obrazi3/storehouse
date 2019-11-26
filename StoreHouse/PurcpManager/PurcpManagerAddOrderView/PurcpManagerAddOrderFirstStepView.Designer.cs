using System.ComponentModel;

namespace View
{
    partial class PurcpManagerAddOrderFirstStepView
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
            this.GroupBoxInitials = new System.Windows.Forms.GroupBox();
            this.TextBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.TextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.LabelContactNumber = new System.Windows.Forms.Label();
            this.TextBoxBankAccount = new System.Windows.Forms.MaskedTextBox();
            this.LabelBankAccount = new System.Windows.Forms.Label();
            this.TextBoxOrganizationName = new System.Windows.Forms.MaskedTextBox();
            this.LabelOrganizationName = new System.Windows.Forms.Label();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.LabelMessageRequiredFields = new System.Windows.Forms.Label();
            this.ButtonNextStep = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.GroupBoxInitials.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainContainer
            // 
            this.PanelMainContainer.Controls.Add(this.GroupBoxInitials);
            this.PanelMainContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelMainContainer.Location = new System.Drawing.Point(3, 8);
            this.PanelMainContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(1056, 144);
            this.PanelMainContainer.TabIndex = 0;
            // 
            // GroupBoxInitials
            // 
            this.GroupBoxInitials.Controls.Add(this.TextBoxEmail);
            this.GroupBoxInitials.Controls.Add(this.LabelEmail);
            this.GroupBoxInitials.Controls.Add(this.TextBoxPhoneNumber);
            this.GroupBoxInitials.Controls.Add(this.LabelContactNumber);
            this.GroupBoxInitials.Controls.Add(this.TextBoxBankAccount);
            this.GroupBoxInitials.Controls.Add(this.LabelBankAccount);
            this.GroupBoxInitials.Controls.Add(this.TextBoxOrganizationName);
            this.GroupBoxInitials.Controls.Add(this.LabelOrganizationName);
            this.GroupBoxInitials.Location = new System.Drawing.Point(3, 4);
            this.GroupBoxInitials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxInitials.Name = "GroupBoxInitials";
            this.GroupBoxInitials.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBoxInitials.Size = new System.Drawing.Size(1034, 126);
            this.GroupBoxInitials.TabIndex = 1;
            this.GroupBoxInitials.TabStop = false;
            this.GroupBoxInitials.Text = "Информация о поставщике";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(762, 62);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(223, 27);
            this.TextBoxEmail.TabIndex = 10;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEmail.Location = new System.Drawing.Point(762, 36);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(255, 24);
            this.LabelEmail.TabIndex = 9;
            this.LabelEmail.Text = "Адрес электронной почты*";
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(538, 62);
            this.TextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxPhoneNumber.Mask = "(00) 000-00-00";
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(162, 27);
            this.TextBoxPhoneNumber.TabIndex = 8;
            // 
            // LabelContactNumber
            // 
            this.LabelContactNumber.AutoSize = true;
            this.LabelContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelContactNumber.Location = new System.Drawing.Point(534, 36);
            this.LabelContactNumber.Name = "LabelContactNumber";
            this.LabelContactNumber.Size = new System.Drawing.Size(187, 24);
            this.LabelContactNumber.TabIndex = 4;
            this.LabelContactNumber.Text = "Контактный номер*";
            // 
            // TextBoxBankAccount
            // 
            this.TextBoxBankAccount.Location = new System.Drawing.Point(326, 62);
            this.TextBoxBankAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxBankAccount.Mask = "0000000";
            this.TextBoxBankAccount.Name = "TextBoxBankAccount";
            this.TextBoxBankAccount.Size = new System.Drawing.Size(150, 27);
            this.TextBoxBankAccount.TabIndex = 3;
            // 
            // LabelBankAccount
            // 
            this.LabelBankAccount.AutoSize = true;
            this.LabelBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBankAccount.Location = new System.Drawing.Point(326, 36);
            this.LabelBankAccount.Name = "LabelBankAccount";
            this.LabelBankAccount.Size = new System.Drawing.Size(169, 24);
            this.LabelBankAccount.TabIndex = 2;
            this.LabelBankAccount.Text = "Банковский счёт*";
            // 
            // TextBoxOrganizationName
            // 
            this.TextBoxOrganizationName.Location = new System.Drawing.Point(10, 64);
            this.TextBoxOrganizationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxOrganizationName.Name = "TextBoxOrganizationName";
            this.TextBoxOrganizationName.Size = new System.Drawing.Size(271, 27);
            this.TextBoxOrganizationName.TabIndex = 1;
            // 
            // LabelOrganizationName
            // 
            this.LabelOrganizationName.AutoSize = true;
            this.LabelOrganizationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOrganizationName.Location = new System.Drawing.Point(7, 36);
            this.LabelOrganizationName.Name = "LabelOrganizationName";
            this.LabelOrganizationName.Size = new System.Drawing.Size(225, 24);
            this.LabelOrganizationName.TabIndex = 0;
            this.LabelOrganizationName.Text = "Название организации*";
            // 
            // PanelControlButtons
            // 
            this.PanelControlButtons.Controls.Add(this.LabelMessageRequiredFields);
            this.PanelControlButtons.Controls.Add(this.ButtonNextStep);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(7, 179);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(2);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(1051, 161);
            this.PanelControlButtons.TabIndex = 5;
            // 
            // LabelMessageRequiredFields
            // 
            this.LabelMessageRequiredFields.AutoSize = true;
            this.LabelMessageRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessageRequiredFields.Location = new System.Drawing.Point(153, 20);
            this.LabelMessageRequiredFields.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMessageRequiredFields.Name = "LabelMessageRequiredFields";
            this.LabelMessageRequiredFields.Size = new System.Drawing.Size(844, 24);
            this.LabelMessageRequiredFields.TabIndex = 2;
            this.LabelMessageRequiredFields.Text =
                "Были введены не все обязательные поля(*). Проверьте ввод и повторите попытку ещё " + "раз.";
            this.LabelMessageRequiredFields.Visible = false;
            // 
            // ButtonNextStep
            // 
            this.ButtonNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNextStep.Location = new System.Drawing.Point(886, 101);
            this.ButtonNextStep.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonNextStep.Name = "ButtonNextStep";
            this.ButtonNextStep.Size = new System.Drawing.Size(131, 39);
            this.ButtonNextStep.TabIndex = 1;
            this.ButtonNextStep.Text = "Далее";
            this.ButtonNextStep.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(14, 101);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(131, 39);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // PurcpManagerAddOrderFirstStepView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 334);
            this.Controls.Add(this.PanelControlButtons);
            this.Controls.Add(this.PanelMainContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1082, 381);
            this.MinimumSize = new System.Drawing.Size(1082, 381);
            this.Name = "PurcpManagerAddOrderFirstStepView";
            this.Text = "Информация о поставщике";
            this.PanelMainContainer.ResumeLayout(false);
            this.GroupBoxInitials.ResumeLayout(false);
            this.GroupBoxInitials.PerformLayout();
            this.PanelControlButtons.ResumeLayout(false);
            this.PanelControlButtons.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.GroupBox GroupBoxInitials;
        private System.Windows.Forms.MaskedTextBox TextBoxPhoneNumber;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonNextStep;
        private System.Windows.Forms.Label LabelMessageRequiredFields;
        private System.Windows.Forms.Panel PanelControlButtons;
        private System.Windows.Forms.MaskedTextBox TextBoxOrganizationName;
        private System.Windows.Forms.Label LabelOrganizationName;
        private System.Windows.Forms.MaskedTextBox TextBoxEmail;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelContactNumber;
        private System.Windows.Forms.MaskedTextBox TextBoxBankAccount;
        private System.Windows.Forms.Label LabelBankAccount;
    }
}

