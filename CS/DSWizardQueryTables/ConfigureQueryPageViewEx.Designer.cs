namespace DSWizardCustomizationNoSP
{
    partial class ConfigureQueryPageViewEx
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxTables = new DevExpress.XtraEditors.ListBoxControl();
            this.panelTables = new DevExpress.XtraEditors.PanelControl();
            this.listBoxDsTables = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutItemTables = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlContent)).BeginInit();
            this.layoutControlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupQueryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutGroupContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemQueryType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButtons)).BeginInit();
            this.layoutControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutGroupButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemQueryBuilderButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlBase)).BeginInit();
            this.layoutControlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutGroupBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemFinishButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemNextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemHeaderLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemSeparatorTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemPreviousButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseContent)).BeginInit();
            this.panelBaseContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemBaseContentPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemAdditionalButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAdditionalButtons)).BeginInit();
            this.panelAdditionalButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTables)).BeginInit();
            this.panelTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDsTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemTables)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlContent
            // 
            this.layoutControlContent.Controls.Add(this.panelTables);
            this.layoutControlContent.Location = new System.Drawing.Point(20, 20);
            this.layoutControlContent.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(898, 239, 990, 690);
            this.layoutControlContent.Size = new System.Drawing.Size(566, 297);
            this.layoutControlContent.Controls.SetChildIndex(this.radioGroupQueryType, 0);
            this.layoutControlContent.Controls.SetChildIndex(this.panel, 0);
            this.layoutControlContent.Controls.SetChildIndex(this.panelTables, 0);
            // 
            // radioGroupQueryType
            // 
            this.radioGroupQueryType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupQueryType.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupQueryType.Size = new System.Drawing.Size(542, 52);
            // 
            // layoutGroupContent
            // 
            this.layoutGroupContent.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutItemTables});
            this.layoutGroupContent.Size = new System.Drawing.Size(566, 297);
            // 
            // layoutItemQueryType
            // 
            this.layoutItemQueryType.Size = new System.Drawing.Size(546, 56);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(14, 170);
            this.panel.Size = new System.Drawing.Size(540, 97);
            // 
            // layoutItemQuery
            // 
            this.layoutItemQuery.Location = new System.Drawing.Point(0, 156);
            this.layoutItemQuery.Size = new System.Drawing.Size(546, 119);
            // 
            // layoutControlButtons
            // 
            this.layoutControlButtons.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2786, 241, 735, 782);
            this.layoutControlButtons.Controls.SetChildIndex(this.buttonQueryBuilder, 0);
            // 
            // layoutControlBase
            // 
            this.layoutControlBase.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(864, 200, 749, 738);
            this.layoutControlBase.Controls.SetChildIndex(this.buttonFinish, 0);
            this.layoutControlBase.Controls.SetChildIndex(this.buttonNext, 0);
            this.layoutControlBase.Controls.SetChildIndex(this.buttonPrevious, 0);
            this.layoutControlBase.Controls.SetChildIndex(this.panelBaseContent, 0);
            this.layoutControlBase.Controls.SetChildIndex(this.labelHeader, 0);
            this.layoutControlBase.Controls.SetChildIndex(this.separatorTop, 0);
            this.layoutControlBase.Controls.SetChildIndex(this.panelAdditionalButtons, 0);
            // 
            // labelHeader
            // 
            this.labelHeader.Size = new System.Drawing.Size(216, 13);
            this.labelHeader.Text = "Create a query or select a stored procedure.";
            // 
            // panelBaseContent
            // 
            this.panelBaseContent.Controls.Add(this.listBoxTables);
            this.panelBaseContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelBaseContent.Controls.SetChildIndex(this.listBoxTables, 0);
            this.panelBaseContent.Controls.SetChildIndex(this.layoutControlContent, 0);
            // 
            // listBoxTables
            // 
            this.listBoxTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTables.Location = new System.Drawing.Point(20, 20);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.Size = new System.Drawing.Size(566, 297);
            this.listBoxTables.TabIndex = 0;
            // 
            // panelTables
            // 
            this.panelTables.Controls.Add(this.listBoxDsTables);
            this.panelTables.Location = new System.Drawing.Point(12, 70);
            this.panelTables.Name = "panelTables";
            this.panelTables.Padding = new System.Windows.Forms.Padding(10);
            this.panelTables.Size = new System.Drawing.Size(542, 96);
            this.panelTables.TabIndex = 1;
            // 
            // listBoxDsTables
            // 
            this.listBoxDsTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDsTables.Location = new System.Drawing.Point(12, 12);
            this.listBoxDsTables.Name = "listBoxDsTables";
            this.listBoxDsTables.Size = new System.Drawing.Size(518, 72);
            this.listBoxDsTables.TabIndex = 0;
            this.listBoxDsTables.SelectedIndexChanged += new System.EventHandler(this.listBoxDsTables_SelectedIndexChanged);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl1.Location = new System.Drawing.Point(12, 12);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(176, 76);
            this.listBoxControl1.TabIndex = 0;
            // 
            // layoutItemTables
            // 
            this.layoutItemTables.Control = this.panelTables;
            this.layoutItemTables.Location = new System.Drawing.Point(0, 56);
            this.layoutItemTables.Name = "layoutItemTables";
            this.layoutItemTables.Size = new System.Drawing.Size(546, 100);
            this.layoutItemTables.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemTables.TextVisible = false;
            // 
            // CustomConfigureQueryPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CustomConfigureQueryPageView";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlContent)).EndInit();
            this.layoutControlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupQueryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutGroupContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemQueryType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlButtons)).EndInit();
            this.layoutControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutGroupButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemQueryBuilderButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlBase)).EndInit();
            this.layoutControlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutGroupBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemFinishButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemNextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemHeaderLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemSeparatorTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemPreviousButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseContent)).EndInit();
            this.panelBaseContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemBaseContentPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemAdditionalButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAdditionalButtons)).EndInit();
            this.panelAdditionalButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTables)).EndInit();
            this.panelTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDsTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxTables;
        private DevExpress.XtraEditors.PanelControl panelTables;
        private DevExpress.XtraEditors.ListBoxControl listBoxDsTables;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemTables;
    }
}
