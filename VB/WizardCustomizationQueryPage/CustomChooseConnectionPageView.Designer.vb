Namespace WizardCustomizationQueryPage
    Partial Public Class CustomChooseConnectionPageView
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
            Me.lbConnections = New DevExpress.XtraEditors.ListBoxControl()
            DirectCast(Me.layoutControlBase, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControlBase.SuspendLayout()
            DirectCast(Me.layoutControlGroupBase, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutItemFinishButton, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutItemNextButton, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItemBase, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutItemHeaderLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutItemSeparatorTop, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutItemSeparatorBottom, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutItemPreviousButton, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.baseContentPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.baseContentPanel.SuspendLayout()
            DirectCast(Me.layoutItemBaseContentPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lbConnections, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.layoutControlBase.Controls.SetChildIndex(Me.separatorBottom, 0)
            ' 
            ' baseContentPanel
            ' 
            Me.baseContentPanel.Controls.Add(Me.lbConnections)
            ' 
            ' lbConnections
            ' 
            Me.lbConnections.Location = New System.Drawing.Point(50, 40)
            Me.lbConnections.Name = "lbConnections"
            Me.lbConnections.Size = New System.Drawing.Size(500, 155)
            Me.lbConnections.TabIndex = 0
            ' 
            ' CustomChooseConnectionPageView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.Name = "CustomChooseConnectionPageView"
            DirectCast(Me.layoutControlBase, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControlBase.ResumeLayout(False)
            DirectCast(Me.layoutControlGroupBase, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutItemFinishButton, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutItemNextButton, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItemBase, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutItemHeaderLabel, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutItemSeparatorTop, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutItemSeparatorBottom, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutItemPreviousButton, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.baseContentPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.baseContentPanel.ResumeLayout(False)
            DirectCast(Me.layoutItemBaseContentPanel, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lbConnections, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
    End Class
End Namespace
