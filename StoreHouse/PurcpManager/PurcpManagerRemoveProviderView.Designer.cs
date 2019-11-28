﻿using System;
using System.ComponentModel;

namespace View
{
    partial class PurcpManagerRemoveProviderView
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
            this.ButtonRemoveProvider = new System.Windows.Forms.Button();
            this.TextBoxIDProvider = new System.Windows.Forms.MaskedTextBox();
            this.LabelMesageInputID = new System.Windows.Forms.Label();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.LabelMessageRequiredFields = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.PanelInputInformation.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            this.PanelMainContainer.Controls.Add(this.PanelInputInformation);
            this.PanelMainContainer.Controls.Add(this.PanelControlButtons);
            this.PanelMainContainer.Location = new System.Drawing.Point(5, 5);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(656, 170);
            this.PanelMainContainer.TabIndex = 0;
            this.PanelInputInformation.Controls.Add(this.TextBoxIDProvider);
            this.PanelInputInformation.Controls.Add(this.LabelMesageInputID);
            this.PanelInputInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PanelInputInformation.Location = new System.Drawing.Point(3, 3);
            this.PanelInputInformation.Name = "PanelInputInformation";
            this.PanelInputInformation.Size = new System.Drawing.Size(651, 67);
            this.PanelInputInformation.TabIndex = 0;
            this.ButtonRemoveProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRemoveProvider.Location = new System.Drawing.Point(472, 54);
            this.ButtonRemoveProvider.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRemoveProvider.Name = "ButtonRemoveProvider";
            this.ButtonRemoveProvider.Size = new System.Drawing.Size(166, 29);
            this.ButtonRemoveProvider.TabIndex = 14;
            this.ButtonRemoveProvider.Text = "Удалить Поставщика";
            this.ButtonRemoveProvider.UseVisualStyleBackColor = true;
            this.ButtonRemoveProvider.Click+=new EventHandler(OnButtonRemoveProviderClick);
            this.TextBoxIDProvider.Location = new System.Drawing.Point(3, 28);
            this.TextBoxIDProvider.Name = "TextBoxIDProvider";
            this.TextBoxIDProvider.Size = new System.Drawing.Size(634, 24);
            this.TextBoxIDProvider.TabIndex = 1;
            this.LabelMesageInputID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMesageInputID.Location = new System.Drawing.Point(3, 1);
            this.LabelMesageInputID.Name = "LabelMesageInputID";
            this.LabelMesageInputID.Size = new System.Drawing.Size(363, 24);
            this.LabelMesageInputID.TabIndex = 0;
            this.LabelMesageInputID.Text = "Введите идентификационный номер поставщика:";
            this.PanelControlButtons.Controls.Add(this.ButtonRemoveProvider);
            this.PanelControlButtons.Controls.Add(this.LabelMessageRequiredFields);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(2, 74);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(652, 91);
            this.PanelControlButtons.TabIndex = 7;
            this.LabelMessageRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LabelMessageRequiredFields.Location = new System.Drawing.Point(6, 10);
            this.LabelMessageRequiredFields.Name = "LabelMessageRequiredFields";
            this.LabelMessageRequiredFields.Size = new System.Drawing.Size(643, 44);
            this.LabelMessageRequiredFields.TabIndex = 2;
            this.LabelMessageRequiredFields.Text = "Введите номер поставщика, чтобы осуществить удаление.\r\n";
            this.LabelMessageRequiredFields.Visible = false;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(6, 54);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(114, 29);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 175);
            this.Controls.Add(this.PanelMainContainer);
            this.MaximumSize = new System.Drawing.Size(681, 214);
            this.MinimumSize = new System.Drawing.Size(681, 214);
            this.Name = "PurcpManagerRemoveProviderView";
            this.Text = "Удаление поставщика";
            this.PanelMainContainer.ResumeLayout(false);
            this.PanelInputInformation.ResumeLayout(false);
            this.PanelInputInformation.PerformLayout();
            this.PanelControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TextBoxIDProvider;
        private System.Windows.Forms.Button ButtonRemoveProvider;
        private System.Windows.Forms.Label LabelMesageInputID;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelMessageRequiredFields;
        private System.Windows.Forms.Panel PanelControlButtons;
        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.Panel PanelInputInformation;
    }
}

