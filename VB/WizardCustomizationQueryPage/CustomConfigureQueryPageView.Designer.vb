Imports Microsoft.VisualBasic
Imports System
Namespace WizardCustomizationQueryPage
	Partial Public Class CustomConfigureQueryPageView
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
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.layoutControlBase, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControlBase.SuspendLayout()
			CType(Me.layoutControlGroupBase, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemFinishButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemNextButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemHeaderLabel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemSeparatorTop, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutItemPreviousButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.baseContentPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.baseContentPanel.SuspendLayout()
			CType(Me.layoutItemBaseContentPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControlBase
			' 
			Me.layoutControlBase.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(864, 200, 749, 738)
			Me.layoutControlBase.Controls.SetChildIndex(Me.finishButton, 0)
			Me.layoutControlBase.Controls.SetChildIndex(Me.nextButton, 0)
			Me.layoutControlBase.Controls.SetChildIndex(Me.previousButton, 0)
			Me.layoutControlBase.Controls.SetChildIndex(Me.baseContentPanel, 0)
			Me.layoutControlBase.Controls.SetChildIndex(Me.headerLabel, 0)
			Me.layoutControlBase.Controls.SetChildIndex(Me.separatorTop, 0)
			' 
			' baseContentPanel
			' 
			Me.baseContentPanel.Controls.Add(Me.labelControl1)
			Me.baseContentPanel.Controls.Add(Me.listBoxControl1)
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Location = New System.Drawing.Point(48, 46)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(511, 234)
			Me.listBoxControl1.TabIndex = 0
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(48, 26)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(69, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Select a table:"
			' 
			' CustomConfigureQueryPageView
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "CustomConfigureQueryPageView"
			CType(Me.layoutControlBase, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControlBase.ResumeLayout(False)
			CType(Me.layoutControlGroupBase, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemFinishButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemNextButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemHeaderLabel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemSeparatorTop, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutItemPreviousButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.baseContentPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.baseContentPanel.ResumeLayout(False)
			Me.baseContentPanel.PerformLayout()
			CType(Me.layoutItemBaseContentPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace
