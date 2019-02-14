Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace WindowsApplication87
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cardView1
			' 
			Me.cardView1.GridControl = Me.gridControl1
			Me.cardView1.Name = "cardView1"
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.LevelTemplate = Me.cardView1
			gridLevelNode1.RelationName = "Details"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(504, 362)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.cardView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsDetail.ShowDetailTabs = False
'			Me.gridView1.MasterRowEmpty += New DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(Me.gridView1_MasterRowEmpty);
'			Me.gridView1.MasterRowGetLevelDefaultView += New DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventHandler(Me.gridView1_MasterRowGetLevelDefaultView);
'			Me.gridView1.MasterRowGetChildList += New DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(Me.gridView1_MasterRowGetChildList);
'			Me.gridView1.MasterRowGetRelationCount += New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(Me.gridView1_MasterRowGetRelationCount);
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "gridColumn1"
			Me.gridColumn1.FieldName = "ID"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(504, 362)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Function GetCustomerDataTable() As DataTable
			Dim table As New DataTable()
			table.TableName = "Customers"
			table.Columns.Add(New DataColumn("Items", GetType(String)))
			table.Columns.Add(New DataColumn("Money", GetType(Double)))
			table.Columns.Add(New DataColumn("ID", GetType(Integer)))
			For i As Integer = 0 To 9
				table.Rows.Add("Product " & i, 3000 + i * 298.55D, i)
			Next i
			Return table
		End Function
		Private customers As DataTable
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			customers = GetCustomerDataTable()
			gridControl1.DataSource = customers
			cardView1.PopulateColumns(customers)
		End Sub

		Private Sub gridView1_MasterRowEmpty(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs) Handles gridView1.MasterRowEmpty
			e.IsEmpty = False
		End Sub

		Private Sub gridView1_MasterRowGetChildList(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs) Handles gridView1.MasterRowGetChildList
			Dim clone As DataTable = customers.Clone()
			Dim row As DataRow = gridView1.GetDataRow(e.RowHandle)
			clone.Rows.Add(row.ItemArray)
			e.ChildList = clone.DefaultView
		End Sub

		Private Sub gridView1_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles gridView1.MasterRowGetLevelDefaultView
			e.DefaultView = cardView1
		End Sub

		Private Sub gridView1_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs) Handles gridView1.MasterRowGetRelationCount
			e.RelationCount = 1
		End Sub
	End Class
End Namespace
