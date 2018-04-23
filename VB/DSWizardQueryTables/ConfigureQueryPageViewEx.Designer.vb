Imports Microsoft.VisualBasic
Imports System
Namespace DSWizardCustomizationNoSP
	Partial Public Class ConfigureQueryPageViewEx
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.listBoxTables = New DevExpress.XtraEditors.ListBoxControl()
			Me.panelTables = New DevExpress.XtraEditors.PanelControl()
			Me.listBoxDsTables = New DevExpress.XtraEditors.ListBoxControl()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.layoutItemTables = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.layoutControlContent, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControlContent.SuspendLayout()
			CType(Me.radioGroupQueryType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutGroupContent, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemQueryType, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemQuery, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControlButtons.SuspendLayout()
			CType(Me.layoutGroupButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemQueryBuilderButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.emptySpaceButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlBase, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControlBase.SuspendLayout()
			CType(Me.layoutGroupBase, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemFinishButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemNextButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemHeaderLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemSeparatorTop, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemPreviousButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelBaseContent, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelBaseContent.SuspendLayout()
			CType(Me.layoutItemBaseContentPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemAdditionalButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelAdditionalButtons, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelAdditionalButtons.SuspendLayout()
			CType(Me.listBoxTables, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelTables, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelTables.SuspendLayout()
			CType(Me.listBoxDsTables, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemTables, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControlContent
			' 
			Me.layoutControlContent.Controls.Add(Me.panelTables)
			Me.layoutControlContent.Location = New System.Drawing.Point(20, 20)
			Me.layoutControlContent.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(898, 239, 990, 690)
			Me.layoutControlContent.Size = New System.Drawing.Size(566, 297)
			Me.layoutControlContent.Controls.SetChildIndex(Me.radioGroupQueryType, 0)
			Me.layoutControlContent.Controls.SetChildIndex(Me.panel, 0)
			Me.layoutControlContent.Controls.SetChildIndex(Me.panelTables, 0)
			' 
			' radioGroupQueryType
			' 
			Me.radioGroupQueryType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.radioGroupQueryType.Properties.Appearance.Options.UseBackColor = True
			Me.radioGroupQueryType.Size = New System.Drawing.Size(542, 52)
			' 
			' layoutGroupContent
			' 
			Me.layoutGroupContent.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutItemTables})
			Me.layoutGroupContent.Size = New System.Drawing.Size(566, 297)
			' 
			' layoutItemQueryType
			' 
			Me.layoutItemQueryType.Size = New System.Drawing.Size(546, 56)
			' 
			' panel
			' 
			Me.panel.Location = New System.Drawing.Point(14, 170)
			Me.panel.Size = New System.Drawing.Size(540, 97)
			' 
			' layoutItemQuery
			' 
			Me.layoutItemQuery.Location = New System.Drawing.Point(0, 156)
			Me.layoutItemQuery.Size = New System.Drawing.Size(546, 119)
			' 
			' layoutControlButtons
			' 
			Me.layoutControlButtons.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2786, 241, 735, 782)
			Me.layoutControlButtons.Controls.SetChildIndex(Me.buttonQueryBuilder, 0)
			' 
			' layoutControlBase
			' 
			Me.layoutControlBase.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(864, 200, 749, 738)
			Me.layoutControlBase.Controls.SetChildIndex(Me.buttonFinish, 0)
			Me.layoutControlBase.Controls.SetChildIndex(Me.buttonNext, 0)
			Me.layoutControlBase.Controls.SetChildIndex(Me.buttonPrevious, 0)
			Me.layoutControlBase.Controls.SetChildIndex(Me.panelBaseContent, 0)
			Me.layoutControlBase.Controls.SetChildIndex(Me.labelHeader, 0)
			Me.layoutControlBase.Controls.SetChildIndex(Me.separatorTop, 0)
			Me.layoutControlBase.Controls.SetChildIndex(Me.panelAdditionalButtons, 0)
			' 
			' labelHeader
			' 
			Me.labelHeader.Size = New System.Drawing.Size(216, 13)
			Me.labelHeader.Text = "Create a query or select a stored procedure."
			' 
			' panelBaseContent
			' 
			Me.panelBaseContent.Controls.Add(Me.listBoxTables)
			Me.panelBaseContent.Padding = New System.Windows.Forms.Padding(20)
			Me.panelBaseContent.Controls.SetChildIndex(Me.listBoxTables, 0)
			Me.panelBaseContent.Controls.SetChildIndex(Me.layoutControlContent, 0)
			' 
			' listBoxTables
			' 
			Me.listBoxTables.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBoxTables.Location = New System.Drawing.Point(20, 20)
			Me.listBoxTables.Name = "listBoxTables"
			Me.listBoxTables.Size = New System.Drawing.Size(566, 297)
			Me.listBoxTables.TabIndex = 0
			' 
			' panelTables
			' 
			Me.panelTables.Controls.Add(Me.listBoxDsTables)
			Me.panelTables.Location = New System.Drawing.Point(12, 70)
			Me.panelTables.Name = "panelTables"
			Me.panelTables.Padding = New System.Windows.Forms.Padding(10)
			Me.panelTables.Size = New System.Drawing.Size(542, 96)
			Me.panelTables.TabIndex = 1
			' 
			' listBoxDsTables
			' 
			Me.listBoxDsTables.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBoxDsTables.Location = New System.Drawing.Point(12, 12)
			Me.listBoxDsTables.Name = "listBoxDsTables"
			Me.listBoxDsTables.Size = New System.Drawing.Size(518, 72)
			Me.listBoxDsTables.TabIndex = 0
'			Me.listBoxDsTables.SelectedIndexChanged += New System.EventHandler(Me.listBoxDsTables_SelectedIndexChanged);
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBoxControl1.Location = New System.Drawing.Point(12, 12)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(176, 76)
			Me.listBoxControl1.TabIndex = 0
			' 
			' layoutItemTables
			' 
			Me.layoutItemTables.Control = Me.panelTables
			Me.layoutItemTables.Location = New System.Drawing.Point(0, 56)
			Me.layoutItemTables.Name = "layoutItemTables"
			Me.layoutItemTables.Size = New System.Drawing.Size(546, 100)
			Me.layoutItemTables.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutItemTables.TextVisible = False
			' 
			' CustomConfigureQueryPageView
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "CustomConfigureQueryPageView"
			CType(Me.layoutControlContent, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControlContent.ResumeLayout(False)
			CType(Me.radioGroupQueryType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutGroupContent, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemQueryType, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemQuery, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlButtons, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControlButtons.ResumeLayout(False)
			CType(Me.layoutGroupButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemQueryBuilderButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.emptySpaceButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlBase, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControlBase.ResumeLayout(False)
			CType(Me.layoutGroupBase, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemFinishButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemNextButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemHeaderLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemSeparatorTop, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemPreviousButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelBaseContent, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelBaseContent.ResumeLayout(False)
			CType(Me.layoutItemBaseContentPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemAdditionalButtons, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelAdditionalButtons, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelAdditionalButtons.ResumeLayout(False)
			CType(Me.listBoxTables, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelTables, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelTables.ResumeLayout(False)
			CType(Me.listBoxDsTables, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemTables, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private listBoxTables As DevExpress.XtraEditors.ListBoxControl
		Private panelTables As DevExpress.XtraEditors.PanelControl
		Private WithEvents listBoxDsTables As DevExpress.XtraEditors.ListBoxControl
		Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private layoutItemTables As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace
