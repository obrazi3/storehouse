using System;
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
            this.TextBoxIDProvider = new System.Windows.Forms.MaskedTextBox();
            this.LabelMesageInputID = new System.Windows.Forms.Label();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.ButtonRemoveProvider = new System.Windows.Forms.Button();
            this.LabelMessageRequiredFields = new System.Windows.Forms.Label();
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
            this.PanelMainContainer.Location = new System.Drawing.Point(4, 4);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(562, 147);
            this.PanelMainContainer.TabIndex = 0;
            // 
            // PanelInputInformation
            // 
            this.PanelInputInformation.Controls.Add(this.TextBoxIDProvider);
            this.PanelInputInformation.Controls.Add(this.LabelMesageInputID);
            this.PanelInputInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PanelInputInformation.Location = new System.Drawing.Point(3, 3);
            this.PanelInputInformation.Name = "PanelInputInformation";
            this.PanelInputInformation.Size = new System.Drawing.Size(558, 58);
            this.PanelInputInformation.TabIndex = 0;
            // 
            // TextBoxIDProvider
            // 
            this.TextBoxIDProvider.Location = new System.Drawing.Point(3, 24);
            this.TextBoxIDProvider.Name = "TextBoxIDProvider";
            this.TextBoxIDProvider.Size = new System.Drawing.Size(544, 24);
            this.TextBoxIDProvider.TabIndex = 1;
            // 
            // LabelMesageInputID
            // 
            this.LabelMesageInputID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMesageInputID.Location = new System.Drawing.Point(3, 1);
            this.LabelMesageInputID.Name = "LabelMesageInputID";
            this.LabelMesageInputID.Size = new System.Drawing.Size(311, 21);
            this.LabelMesageInputID.TabIndex = 0;
            this.LabelMesageInputID.Text = "Введите номер поставщика:\r\n";
            // 
            // PanelControlButtons
            // 
            this.PanelControlButtons.Controls.Add(this.ButtonRemoveProvider);
            this.PanelControlButtons.Controls.Add(this.LabelMessageRequiredFields);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(2, 65);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(559, 79);
            this.PanelControlButtons.TabIndex = 7;
            // 
            // ButtonRemoveProvider
            // 
            this.ButtonRemoveProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRemoveProvider.Location = new System.Drawing.Point(405, 47);
            this.ButtonRemoveProvider.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRemoveProvider.Name = "ButtonRemoveProvider";
            this.ButtonRemoveProvider.Size = new System.Drawing.Size(142, 25);
            this.ButtonRemoveProvider.TabIndex = 14;
            this.ButtonRemoveProvider.Text = "Удалить Поставщика";
            this.ButtonRemoveProvider.UseVisualStyleBackColor = true;
            this.ButtonRemoveProvider.Click += new System.EventHandler(this.OnButtonRemoveProviderClick);
            // 
            // LabelMessageRequiredFields
            // 
            this.LabelMessageRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LabelMessageRequiredFields.Location = new System.Drawing.Point(5, 9);
            this.LabelMessageRequiredFields.Name = "LabelMessageRequiredFields";
            this.LabelMessageRequiredFields.Size = new System.Drawing.Size(551, 38);
            this.LabelMessageRequiredFields.TabIndex = 2;
            this.LabelMessageRequiredFields.Text = "Введите номер поставщика, чтобы осуществить удаление.\r\n";
            this.LabelMessageRequiredFields.Visible = false;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(5, 47);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(98, 25);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            // 
            // PurcpManagerRemoveProviderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 152);
            this.Controls.Add(this.PanelMainContainer);
            this.MaximumSize = new System.Drawing.Size(586, 191);
            this.MinimumSize = new System.Drawing.Size(586, 191);
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

