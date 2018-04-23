Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon

Namespace DSWizardCustomizationNoSP
	Partial Public Class Form1
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
			dashboardDesigner1.DataSourceWizardCustomization = New DataSourceWizardCustomization()
		End Sub
	End Class
End Namespace
