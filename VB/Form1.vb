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
		Private sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
		Private sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
		Private sqlConnection1 As System.Data.SqlClient.SqlConnection
		Private dataSet11 As WindowsApplication87.DataSet1
		Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
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
			Dim configurationAppSettings As New System.Configuration.AppSettingsReader()
			Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.dataSet11 = New WindowsApplication87.DataSet1()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
			Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
			Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cardView1
			' 
			Me.cardView1.FocusedCardTopFieldIndex = 0
			Me.cardView1.GridControl = Me.gridControl1
			Me.cardView1.Name = "cardView1"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.dataSet11.Customers
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
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
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCompanyName})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsDetail.ShowDetailTabs = False
'			Me.gridView1.MasterRowGetLevelDefaultView += New DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventHandler(Me.gridView1_MasterRowGetLevelDefaultView);
'			Me.gridView1.MasterRowEmpty += New DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(Me.gridView1_MasterRowEmpty);
'			Me.gridView1.MasterRowGetChildList += New DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(Me.gridView1_MasterRowGetChildList);
'			Me.gridView1.MasterRowGetRelationCount += New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(Me.gridView1_MasterRowGetRelationCount);
			' 
			' colCompanyName
			' 
			Me.colCompanyName.Caption = "CompanyName"
			Me.colCompanyName.FieldName = "CompanyName"
			Me.colCompanyName.Name = "colCompanyName"
			Me.colCompanyName.Visible = True
			Me.colCompanyName.VisibleIndex = 0
			' 
			' sqlDataAdapter1
			' 
			Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
			Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax")})})
			' 
			' sqlSelectCommand1
			' 
			Me.sqlSelectCommand1.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region," & " PostalCode, Country, Phone, Fax FROM Customers"
			Me.sqlSelectCommand1.Connection = Me.sqlConnection1
			' 
			' sqlConnection1
			' 
			Me.sqlConnection1.ConnectionString = (CStr(configurationAppSettings.GetValue("sqlConnection1.ConnectionString", GetType(String))))
			Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
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
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			sqlDataAdapter1.Fill(dataSet11)
			cardView1.PopulateColumns(dataSet11.Customers)
		End Sub

		Private Sub gridView1_MasterRowEmpty(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs) Handles gridView1.MasterRowEmpty
			e.IsEmpty = False
		End Sub

		Private Sub gridView1_MasterRowGetChildList(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs) Handles gridView1.MasterRowGetChildList
			Dim clone As DataTable = dataSet11.Customers.Clone()
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
