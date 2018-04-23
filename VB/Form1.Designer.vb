Imports Microsoft.VisualBasic
Imports System
Namespace CombineLinks
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colSupplierID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colHomePage = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.button1 = New System.Windows.Forms.Button()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.nwindDataSet = New CombineLinks.nwindDataSet()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.categoriesTableAdapter = New CombineLinks.nwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.suppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.suppliersTableAdapter = New CombineLinks.nwindDataSetTableAdapters.SuppliersTableAdapter()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.suppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl2
			' 
			Me.gridControl2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridControl2.DataSource = Me.suppliersBindingSource
			Me.gridControl2.Location = New System.Drawing.Point(12, 231)
			Me.gridControl2.MainView = Me.gridView3
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.Size = New System.Drawing.Size(547, 229)
			Me.gridControl2.TabIndex = 6
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView3, Me.gridView4})
			' 
			' gridView3
			' 
			Me.gridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colSupplierID, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colPhone, Me.colFax, Me.colHomePage})
			Me.gridView3.GridControl = Me.gridControl2
			Me.gridView3.Name = "gridView3"
			' 
			' colSupplierID
			' 
			Me.colSupplierID.Caption = "SupplierID"
			Me.colSupplierID.FieldName = "SupplierID"
			Me.colSupplierID.Name = "colSupplierID"
			Me.colSupplierID.Visible = True
			Me.colSupplierID.VisibleIndex = 0
			' 
			' colCompanyName
			' 
			Me.colCompanyName.Caption = "CompanyName"
			Me.colCompanyName.FieldName = "CompanyName"
			Me.colCompanyName.Name = "colCompanyName"
			Me.colCompanyName.Visible = True
			Me.colCompanyName.VisibleIndex = 1
			' 
			' colContactName
			' 
			Me.colContactName.Caption = "ContactName"
			Me.colContactName.FieldName = "ContactName"
			Me.colContactName.Name = "colContactName"
			Me.colContactName.Visible = True
			Me.colContactName.VisibleIndex = 2
			' 
			' colContactTitle
			' 
			Me.colContactTitle.Caption = "ContactTitle"
			Me.colContactTitle.FieldName = "ContactTitle"
			Me.colContactTitle.Name = "colContactTitle"
			Me.colContactTitle.Visible = True
			Me.colContactTitle.VisibleIndex = 3
			' 
			' colAddress
			' 
			Me.colAddress.Caption = "Address"
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			Me.colAddress.Visible = True
			Me.colAddress.VisibleIndex = 4
			' 
			' colCity
			' 
			Me.colCity.Caption = "City"
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			Me.colCity.Visible = True
			Me.colCity.VisibleIndex = 5
			' 
			' colRegion
			' 
			Me.colRegion.Caption = "Region"
			Me.colRegion.FieldName = "Region"
			Me.colRegion.Name = "colRegion"
			Me.colRegion.Visible = True
			Me.colRegion.VisibleIndex = 6
			' 
			' colPostalCode
			' 
			Me.colPostalCode.Caption = "PostalCode"
			Me.colPostalCode.FieldName = "PostalCode"
			Me.colPostalCode.Name = "colPostalCode"
			Me.colPostalCode.Visible = True
			Me.colPostalCode.VisibleIndex = 7
			' 
			' colCountry
			' 
			Me.colCountry.Caption = "Country"
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			Me.colCountry.Visible = True
			Me.colCountry.VisibleIndex = 8
			' 
			' colPhone
			' 
			Me.colPhone.Caption = "Phone"
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			Me.colPhone.Visible = True
			Me.colPhone.VisibleIndex = 9
			' 
			' colFax
			' 
			Me.colFax.Caption = "Fax"
			Me.colFax.FieldName = "Fax"
			Me.colFax.Name = "colFax"
			Me.colFax.Visible = True
			Me.colFax.VisibleIndex = 10
			' 
			' colHomePage
			' 
			Me.colHomePage.Caption = "HomePage"
			Me.colHomePage.FieldName = "HomePage"
			Me.colHomePage.Name = "colHomePage"
			Me.colHomePage.Visible = True
			Me.colHomePage.VisibleIndex = 11
			' 
			' gridView4
			' 
			Me.gridView4.GridControl = Me.gridControl2
			Me.gridView4.Name = "gridView4"
			' 
			' button1
			' 
			Me.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
			Me.button1.Location = New System.Drawing.Point(192, 466)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(162, 50)
			Me.button1.TabIndex = 5
			Me.button1.Text = "Show Preview"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' gridControl1
			' 
			Me.gridControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridControl1.DataSource = Me.categoriesBindingSource
			Me.gridControl1.Location = New System.Drawing.Point(12, 12)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(547, 213)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryID, Me.colCategoryName, Me.colDescription})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colCategoryID
			' 
			Me.colCategoryID.Caption = "CategoryID"
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 0
			Me.colCategoryID.Width = 36
			' 
			' colCategoryName
			' 
			Me.colCategoryName.Caption = "CategoryName"
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 1
			Me.colCategoryName.Width = 121
			' 
			' colDescription
			' 
			Me.colDescription.Caption = "Description"
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 2
			Me.colDescription.Width = 277
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' suppliersBindingSource
			' 
			Me.suppliersBindingSource.DataMember = "Suppliers"
			Me.suppliersBindingSource.DataSource = Me.nwindDataSet
			' 
			' suppliersTableAdapter
			' 
			Me.suppliersTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(571, 528)
			Me.Controls.Add(Me.gridControl2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.suppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colSupplierID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactName As DevExpress.XtraGrid.Columns.GridColumn
		Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
		Private colAddress As DevExpress.XtraGrid.Columns.GridColumn
		Private colCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colRegion As DevExpress.XtraGrid.Columns.GridColumn
		Private colPostalCode As DevExpress.XtraGrid.Columns.GridColumn
		Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhone As DevExpress.XtraGrid.Columns.GridColumn
		Private colFax As DevExpress.XtraGrid.Columns.GridColumn
		Private colHomePage As DevExpress.XtraGrid.Columns.GridColumn
		Private gridView4 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents button1 As System.Windows.Forms.Button
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private nwindDataSet As nwindDataSet
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private categoriesTableAdapter As CombineLinks.nwindDataSetTableAdapters.CategoriesTableAdapter
		Private suppliersBindingSource As System.Windows.Forms.BindingSource
		Private suppliersTableAdapter As CombineLinks.nwindDataSetTableAdapters.SuppliersTableAdapter

	End Class
End Namespace

