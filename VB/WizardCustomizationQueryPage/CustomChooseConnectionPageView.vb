﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DataAccess.Wizard.Views
Imports DevExpress.DataAccess.UI.Wizard.Views
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess
Imports DevExpress.DataAccess.Native
Imports DevExpress.DataAccess.UI.Native

Namespace WizardCustomizationQueryPage
	Partial Public Class CustomChooseConnectionPageView
		Inherits WizardViewBase
		Implements IChooseConnectionPageView
		Private anyExceptions_Renamed As Boolean = False

		Public Sub New(ByVal connections As IEnumerable(Of SqlDataConnection))
			InitializeComponent()
			AddHandler lbConnections.SelectedIndexChanged, AddressOf listBoxControl1_SelectedIndexChanged
			Me.lbConnections.Items.Clear()
			For Each dataConnection As SqlDataConnection In connections
				If TypeOf dataConnection Is DataConnection Then
					Me.lbConnections.Items.Add(New ConnectionListBoxItem(dataConnection))
				End If
			Next dataConnection
		End Sub

		Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			RaiseEvent Changed(Me, New EventArgs())
		End Sub

        Public Overrides ReadOnly Property HeaderDescription() As String
            Get
                Return "Choose one connection from the list."
            End Get
        End Property
        Public Event Changed As EventHandler Implements IChooseConnectionPageView.Changed

        Public ReadOnly Property ExistingConnectionName() As String Implements IChooseConnectionPageView.ExistingConnectionName
            Get
                Return (CType((CType(lbConnections.SelectedItem, ConnectionListBoxItem)).Connection, INamedItem)).Name
            End Get
        End Property

        Public Sub SetSelectedConnection(ByVal connection As INamedItem) Implements IChooseConnectionPageView.SetSelectedConnection
            If connection IsNot Nothing Then
                For Each connectionListBoxItem As ConnectionListBoxItem In Me.lbConnections.Items
                    If (CType(connectionListBoxItem.Connection, INamedItem)).Name = connection.Name Then
                        lbConnections.SelectedItem = connectionListBoxItem
                        Exit For
                    End If
                Next connectionListBoxItem
            End If
        End Sub

        Public ReadOnly Property ShouldCreateNewConnection() As Boolean Implements IChooseConnectionPageView.ShouldCreateNewConnection
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property WaitFormActivator() As IWaitFormActivator Implements IChooseConnectionPageView.WaitFormActivator
            Get
                Return New WaitFormActivator(FindForm(), GetType(WaitFormWithCancel), True)
            End Get
        End Property

        Public ReadOnly Property AnyExceptions() As Boolean Implements IChooseConnectionPageView.AnyExceptions
            Get
                Return anyExceptions_Renamed
            End Get
        End Property

        Public Sub HandleException(ByVal exception As Exception) Implements IChooseConnectionPageView.HandleException
            MessageBox.Show(exception.Message)
        End Sub
	End Class
	Public Class ConnectionListBoxItem
		Private privateConnection As SqlDataConnection
		Public Property Connection() As SqlDataConnection
			Get
				Return privateConnection
			End Get
			Private Set(ByVal value As SqlDataConnection)
				privateConnection = value
			End Set
		End Property
		Public Sub New(ByVal connection As SqlDataConnection)
            Me.Connection = connection
		End Sub
		Public Overrides Function ToString() As String
			Return Connection.Name
		End Function
	End Class
End Namespace
