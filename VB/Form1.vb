Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
' ...

Namespace CombineLinks
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Suppliers' table. You can move, or remove it, as needed.
			Me.suppliersTableAdapter.Fill(Me.nwindDataSet.Suppliers)
			' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create objects and define event handlers.
			Dim composLink As New CompositeLink(New PrintingSystem())
			AddHandler composLink.CreateMarginalHeaderArea, AddressOf composLink_CreateMarginalHeaderArea
			Dim pcLink1 As New PrintableComponentLink()
			Dim pcLink2 As New PrintableComponentLink()
			Dim linkMainReport As New Link()
			AddHandler linkMainReport.CreateDetailArea, AddressOf linkMainReport_CreateDetailArea
			Dim linkGrid1Report As New Link()
			AddHandler linkGrid1Report.CreateDetailArea, AddressOf linkGrid1Report_CreateDetailArea
			Dim linkGrid2Report As New Link()
			AddHandler linkGrid2Report.CreateDetailArea, AddressOf linkGrid2Report_CreateDetailArea

			' Assign the controls to the printing links.
			pcLink1.Component = Me.gridControl1
			pcLink2.Component = Me.gridControl2

			' Populate the collection of links in the composite link.
			' The order of operations corresponds to the document structure.
			composLink.Links.Add(linkGrid1Report)
			composLink.Links.Add(pcLink1)
			composLink.Links.Add(linkMainReport)
			composLink.Links.Add(linkGrid2Report)
			composLink.Links.Add(pcLink2)

			' Create the report and show the preview window.
			composLink.ShowPreviewDialog()
		End Sub

		' Inserts a PageInfoBrick into the top margin to display the time.
		Private Sub composLink_CreateMarginalHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
			e.Graph.DrawPageInfo(PageInfo.DateTime, "{0:hhhh:mmmm:ssss}", Color.Black, New RectangleF(0, 0, 200, 50), BorderSide.None)
		End Sub

		' Creates a text header for the first grid.
		Private Sub linkGrid1Report_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
			Dim tb As New TextBrick()
			tb.Text = "Northwind Traders"
			tb.Font = New Font("Arial", 15)
			tb.Rect = New RectangleF(0, 0, 300, 25)
			tb.BorderWidth = 0
			tb.BackColor = Color.Transparent
			tb.HorzAlignment = DevExpress.Utils.HorzAlignment.Near
			e.Graph.DrawBrick(tb)
		End Sub

		' Creates an interval between grids and fills it with color.
		Private Sub linkMainReport_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)

			Dim tb As New TextBrick()
			tb.Rect = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
			tb.BackColor = Color.Gray
			e.Graph.DrawBrick(tb)
		End Sub

		' Creates a text header for the second grid.
		Private Sub linkGrid2Report_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
			Dim tb As New TextBrick()
			tb.Text = "Suppliers"
			tb.Font = New Font("Arial", 15)
			tb.Rect = New RectangleF(0, 0, 300, 25)
			tb.BorderWidth = 0
			tb.BackColor = Color.Transparent
			tb.HorzAlignment = DevExpress.Utils.HorzAlignment.Near
			e.Graph.DrawBrick(tb)
		End Sub

	End Class
End Namespace