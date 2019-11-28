using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace View
{
    partial class PurcpManagerInfoOrdersProdView
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
            this.PanelOrdersInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelForButtons = new System.Windows.Forms.Panel();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.PanelForButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMainContainer
            // 
            this.PanelMainContainer.Controls.Add(this.PanelOrdersInfo);
            this.PanelMainContainer.Controls.Add(this.PanelForButtons);
            this.PanelMainContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelMainContainer.Location = new System.Drawing.Point(2, 5);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(795, 693);
            this.PanelMainContainer.TabIndex = 0;
            // 
            // PanelOrdersInfo
            // 
            this.PanelOrdersInfo.AutoScroll = true;
            this.PanelOrdersInfo.Location = new System.Drawing.Point(0, 0);
            this.PanelOrdersInfo.Margin = new System.Windows.Forms.Padding(0);
            this.PanelOrdersInfo.Name = "PanelOrdersInfo";
            this.PanelOrdersInfo.Size = new System.Drawing.Size(794, 623);
            this.PanelOrdersInfo.TabIndex = 0;
            // 
            // PanelForButtons
            // 
            this.PanelForButtons.Controls.Add(this.ButtonRemove);
            this.PanelForButtons.Controls.Add(this.ButtonBack);
            this.PanelForButtons.Location = new System.Drawing.Point(0, 625);
            this.PanelForButtons.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.PanelForButtons.Name = "PanelForButtons";
            this.PanelForButtons.Size = new System.Drawing.Size(794, 61);
            this.PanelForButtons.TabIndex = 0;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ButtonRemove.Location = new System.Drawing.Point(685, 22);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(102, 36);
            this.ButtonRemove.TabIndex = 1;
            this.ButtonRemove.Text = "Удалить";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.OnButtonRemoveOrdersClick);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ButtonBack.Location = new System.Drawing.Point(9, 22);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(64, 36);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            // 
            // PurcpManagerInfoOrdersProdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 700);
            this.Controls.Add(this.PanelMainContainer);
            this.MaximumSize = new System.Drawing.Size(817, 739);
            this.MinimumSize = new System.Drawing.Size(817, 739);
            this.Name = "PurcpManagerInfoOrdersProdView";
            this.Text = "Информация о сделанных заказах";
            this.PanelMainContainer.ResumeLayout(false);
            this.PanelForButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.Panel PanelForButtons;
        private System.Windows.Forms.FlowLayoutPanel PanelOrdersInfo;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonBack;
    }
}

