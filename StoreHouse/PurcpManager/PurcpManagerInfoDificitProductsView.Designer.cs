using System.ComponentModel;

namespace View
{
    partial class PurcpManagerInfoDificitProductsView
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
            this.PanelDificitProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMainContainer.SuspendLayout();
            this.PanelDificitProducts.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            this.PanelMainContainer.Controls.Add(this.PanelDificitProducts);
            this.PanelMainContainer.Controls.Add(this.PanelControlButtons);
            this.PanelMainContainer.Location = new System.Drawing.Point(3, 3);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(926, 800);
            this.PanelMainContainer.TabIndex = 0;
            this.PanelDificitProducts.AutoScroll = true;
            this.PanelDificitProducts.Location = new System.Drawing.Point(3, 3);
            this.PanelDificitProducts.Name = "PanelDificitProducts";
            this.PanelDificitProducts.Size = new System.Drawing.Size(918, 710);
            this.PanelDificitProducts.TabIndex = 0;
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(2, 717);
            this.PanelControlButtons.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(920, 83);
            this.PanelControlButtons.TabIndex = 9;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(6, 48);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(114, 29);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 807);
            this.Controls.Add(this.PanelMainContainer);
            this.Name = "PurcpManagerInfoDificitProductsView";
            this.Text = "Информация о закончившихся и заканчивающихся товарах";
            this.PanelMainContainer.ResumeLayout(false);
            this.PanelDificitProducts.ResumeLayout(false);
            this.PanelControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelDificitProducts;
        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Panel PanelControlButtons;
       

    }
}

