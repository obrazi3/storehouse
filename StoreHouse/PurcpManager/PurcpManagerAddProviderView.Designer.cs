using System.ComponentModel;

namespace View
{
    partial class PurcpManagerAddProviderView
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
            this.LabelProductCategories = new System.Windows.Forms.Label();
            this.ButtonAddCategory = new System.Windows.Forms.Button();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.LabelExplanatoryNote = new System.Windows.Forms.Label();
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
            this.ButtonAddProvider = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.GroupBoxInitials.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            this.PanelMainContainer.Controls.Add(this.GroupBoxInitials);
            this.PanelMainContainer.Controls.Add(this.PanelControlButtons);
            this.PanelMainContainer.Location = new System.Drawing.Point(2, 2);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(927, 363);
            this.PanelMainContainer.TabIndex = 0;
            this.GroupBoxInitials.Controls.Add(this.LabelProductCategories);
            this.GroupBoxInitials.Controls.Add(this.ButtonAddCategory);
            this.GroupBoxInitials.Controls.Add(this.TextBoxCategory);
            this.GroupBoxInitials.Controls.Add(this.LabelExplanatoryNote);
            this.GroupBoxInitials.Controls.Add(this.TextBoxEmail);
            this.GroupBoxInitials.Controls.Add(this.LabelEmail);
            this.GroupBoxInitials.Controls.Add(this.TextBoxPhoneNumber);
            this.GroupBoxInitials.Controls.Add(this.LabelContactNumber);
            this.GroupBoxInitials.Controls.Add(this.TextBoxBankAccount);
            this.GroupBoxInitials.Controls.Add(this.LabelBankAccount);
            this.GroupBoxInitials.Controls.Add(this.TextBoxOrganizationName);
            this.GroupBoxInitials.Controls.Add(this.LabelOrganizationName);
            this.GroupBoxInitials.Location = new System.Drawing.Point(2, 3);
            this.GroupBoxInitials.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBoxInitials.Name = "GroupBoxInitials";
            this.GroupBoxInitials.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBoxInitials.Size = new System.Drawing.Size(925, 237);
            this.GroupBoxInitials.TabIndex = 2;
            this.GroupBoxInitials.TabStop = false;
            this.GroupBoxInitials.Text = "Информация о поставщике";
            this.LabelProductCategories.AutoSize = true;
            this.LabelProductCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProductCategories.Location = new System.Drawing.Point(9, 100);
            this.LabelProductCategories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProductCategories.Name = "LabelProductCategories";
            this.LabelProductCategories.Size = new System.Drawing.Size(147, 18);
            this.LabelProductCategories.TabIndex = 14;
            this.LabelProductCategories.Text = "Категория товаров*\r\n";
            this.ButtonAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddCategory.Location = new System.Drawing.Point(742, 178);
            this.ButtonAddCategory.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddCategory.Name = "ButtonAddCategory";
            this.ButtonAddCategory.Size = new System.Drawing.Size(166, 33);
            this.ButtonAddCategory.TabIndex = 13;
            this.ButtonAddCategory.Text = "Добавить категорию";
            this.ButtonAddCategory.UseVisualStyleBackColor = true;
            this.ButtonAddCategory.Click += this.OnButtonAddCategoryClick;
            this.TextBoxCategory.Location = new System.Drawing.Point(9, 185);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(705, 23);
            this.TextBoxCategory.TabIndex = 12;
            this.LabelExplanatoryNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LabelExplanatoryNote.Location = new System.Drawing.Point(9, 127);
            this.LabelExplanatoryNote.Name = "LabelExplanatoryNote";
            this.LabelExplanatoryNote.Size = new System.Drawing.Size(898, 42);
            this.LabelExplanatoryNote.TabIndex = 11;
            this.LabelExplanatoryNote.Text =
                (("Для добавления категории товара введите название категории, а затем нажмите кнопк" + "" +
                  "у \"Добавить\". Если необходимо ввести несколько категорий, то повторите данное де") +
                 "йствие необходимое количество раз.");
            this.TextBoxEmail.Location = new System.Drawing.Point(667, 46);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(195, 23);
            this.TextBoxEmail.TabIndex = 10;
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEmail.Location = new System.Drawing.Point(667, 27);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(197, 18);
            this.LabelEmail.TabIndex = 9;
            this.LabelEmail.Text = "Адрес электронной почты*";
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(471, 46);
            this.TextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxPhoneNumber.Mask = "(00) 000-00-00";
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(142, 23);
            this.TextBoxPhoneNumber.TabIndex = 8;
            this.LabelContactNumber.AutoSize = true;
            this.LabelContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelContactNumber.Location = new System.Drawing.Point(467, 27);
            this.LabelContactNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelContactNumber.Name = "LabelContactNumber";
            this.LabelContactNumber.Size = new System.Drawing.Size(146, 18);
            this.LabelContactNumber.TabIndex = 4;
            this.LabelContactNumber.Text = "Контактный номер*";
            this.TextBoxBankAccount.Location = new System.Drawing.Point(285, 46);
            this.TextBoxBankAccount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxBankAccount.Mask = "0000000";
            this.TextBoxBankAccount.Name = "TextBoxBankAccount";
            this.TextBoxBankAccount.Size = new System.Drawing.Size(132, 23);
            this.TextBoxBankAccount.TabIndex = 3;
            this.LabelBankAccount.AutoSize = true;
            this.LabelBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBankAccount.Location = new System.Drawing.Point(285, 27);
            this.LabelBankAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBankAccount.Name = "LabelBankAccount";
            this.LabelBankAccount.Size = new System.Drawing.Size(132, 18);
            this.LabelBankAccount.TabIndex = 2;
            this.LabelBankAccount.Text = "Банковский счёт*";
            this.TextBoxOrganizationName.Location = new System.Drawing.Point(9, 48);
            this.TextBoxOrganizationName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TextBoxOrganizationName.Name = "TextBoxOrganizationName";
            this.TextBoxOrganizationName.Size = new System.Drawing.Size(237, 23);
            this.TextBoxOrganizationName.TabIndex = 1;
            this.LabelOrganizationName.AutoSize = true;
            this.LabelOrganizationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOrganizationName.Location = new System.Drawing.Point(6, 27);
            this.LabelOrganizationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelOrganizationName.Name = "LabelOrganizationName";
            this.LabelOrganizationName.Size = new System.Drawing.Size(172, 18);
            this.LabelOrganizationName.TabIndex = 0;
            this.LabelOrganizationName.Text = "Название организации*";
            this.PanelControlButtons.Controls.Add(this.LabelMessageRequiredFields);
            this.PanelControlButtons.Controls.Add(this.ButtonAddProvider);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(2, 244);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(919, 111);
            this.PanelControlButtons.TabIndex = 6;
            this.LabelMessageRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LabelMessageRequiredFields.Location = new System.Drawing.Point(6, 10);
            this.LabelMessageRequiredFields.Name = "LabelMessageRequiredFields";
            this.LabelMessageRequiredFields.Size = new System.Drawing.Size(901, 44);
            this.LabelMessageRequiredFields.TabIndex = 2;
            this.LabelMessageRequiredFields.Text =
                ("Были заполнены не все поля либо отсутствуют категории товаров. Введите все необхо" + "" +
                 "димые поля(*) и добавьте хотя бы одну категорию товаров.\r\n\r\n");
            this.LabelMessageRequiredFields.Visible = false;
            this.ButtonAddProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddProvider.Location = new System.Drawing.Point(709, 76);
            this.ButtonAddProvider.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddProvider.Name = "ButtonAddProvider";
            this.ButtonAddProvider.Size = new System.Drawing.Size(198, 29);
            this.ButtonAddProvider.TabIndex = 1;
            this.ButtonAddProvider.Text = "Добавить поставщика";
            this.ButtonAddProvider.UseVisualStyleBackColor = true;
            this.ButtonAddProvider.Click += this.OnButtonAddProviderClick;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(12, 76);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(114, 29);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            this.ButtonBack.Click += this.OnButtonBackClick;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 369);
            this.Controls.Add(this.PanelMainContainer);
            this.MaximumSize = new System.Drawing.Size(949, 408);
            this.MinimumSize = new System.Drawing.Size(949, 408);
            this.Name = "PurcpManagerAddProviderView";
            this.Text = "Добавление поставщика";
            this.PanelMainContainer.ResumeLayout(false);
            this.GroupBoxInitials.ResumeLayout(false);
            this.GroupBoxInitials.PerformLayout();
            this.PanelControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label LabelOrganizationName;
        private System.Windows.Forms.MaskedTextBox TextBoxOrganizationName;
        private System.Windows.Forms.Label LabelBankAccount;
        private System.Windows.Forms.MaskedTextBox TextBoxBankAccount;
        private System.Windows.Forms.Label LabelContactNumber;
        private System.Windows.Forms.MaskedTextBox TextBoxPhoneNumber;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.MaskedTextBox TextBoxEmail;
        private System.Windows.Forms.GroupBox GroupBoxInitials;
        private System.Windows.Forms.Panel PanelControlButtons;
        private System.Windows.Forms.Label LabelProductCategories;
        private System.Windows.Forms.Button ButtonAddCategory;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.Label LabelExplanatoryNote;
        private System.Windows.Forms.Label LabelMessageRequiredFields;
        private System.Windows.Forms.Button ButtonAddProvider;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
    }
}

