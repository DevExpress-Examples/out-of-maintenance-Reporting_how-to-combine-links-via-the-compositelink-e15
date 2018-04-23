using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
// ...

namespace CombineLinks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.nwindDataSet.Suppliers);
            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create objects and define event handlers.
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            composLink.CreateMarginalHeaderArea += new CreateAreaEventHandler(composLink_CreateMarginalHeaderArea);
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            PrintableComponentLink pcLink2 = new PrintableComponentLink();
            Link linkMainReport = new Link();
            linkMainReport.CreateDetailArea += new CreateAreaEventHandler(linkMainReport_CreateDetailArea);
            Link linkGrid1Report = new Link();
            linkGrid1Report.CreateDetailArea += new CreateAreaEventHandler(linkGrid1Report_CreateDetailArea);
            Link linkGrid2Report = new Link();
            linkGrid2Report.CreateDetailArea += new CreateAreaEventHandler(linkGrid2Report_CreateDetailArea);

            // Assign the controls to the printing links.
            pcLink1.Component = this.gridControl1;
            pcLink2.Component = this.gridControl2;

            // Populate the collection of links in the composite link.
            // The order of operations corresponds to the document structure.
            composLink.Links.Add(linkGrid1Report);
            composLink.Links.Add(pcLink1);
            composLink.Links.Add(linkMainReport);
            composLink.Links.Add(linkGrid2Report);
            composLink.Links.Add(pcLink2);

            // Create the report and show the preview window.
            composLink.ShowPreviewDialog();
        }

        // Inserts a PageInfoBrick into the top margin to display the time.
        void composLink_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e) {
            e.Graph.DrawPageInfo(PageInfo.DateTime, "{0:hhhh:mmmm:ssss}", Color.Black, new RectangleF(0, 0, 200, 50), BorderSide.None);
        }

        // Creates a text header for the first grid.
        void linkGrid1Report_CreateDetailArea(object sender, CreateAreaEventArgs e) {
            TextBrick tb = new TextBrick();
            tb.Text = "Northwind Traders";
            tb.Font = new Font("Arial", 15);
            tb.Rect = new RectangleF(0, 0, 300, 25);
            tb.BorderWidth = 0;
            tb.BackColor = Color.Transparent;
            tb.HorzAlignment = DevExpress.Utils.HorzAlignment.Near;
            e.Graph.DrawBrick(tb);
        }

        // Creates an interval between grids and fills it with color.
        void linkMainReport_CreateDetailArea(object sender, CreateAreaEventArgs e) {

            TextBrick tb = new TextBrick();
            tb.Rect = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            tb.BackColor = Color.Gray;
            e.Graph.DrawBrick(tb);
        }

        // Creates a text header for the second grid.
        void linkGrid2Report_CreateDetailArea(object sender, CreateAreaEventArgs e) {
            TextBrick tb = new TextBrick();
            tb.Text = "Suppliers";
            tb.Font = new Font("Arial", 15);
            tb.Rect = new RectangleF(0, 0, 300, 25);
            tb.BorderWidth = 0;
            tb.BackColor = Color.Transparent;
            tb.HorzAlignment = DevExpress.Utils.HorzAlignment.Near;
            e.Graph.DrawBrick(tb);
        }

    }
}