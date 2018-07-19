using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemBox.Document;
using System.Data.SqlClient;

namespace SlimlineRevisedUI.Classes
{
    class Label
    {

       
        private string _sc { get; set; }
        private int _itemID { get; set; }

        private string _desc
        { get
            {
                //UPDATES OPERATIONS DATAGRID
                SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);

                con.Open();
                //UPDATES THE PAINT TO DOOR DATAGRID
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select description from dbo.stock where stock_code = @sc";
                cmd.Parameters.AddWithValue("@sc", _sc);


                return cmd.ExecuteScalar().ToString();
               
            }
        }



        private string _descStock
        {
            get
            {
                //UPDATES OPERATIONS DATAGRID
                SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);

                con.Open();
                //UPDATES THE PAINT TO DOOR DATAGRID
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select description from dbo.po_item where id = @itemId";
                cmd.Parameters.AddWithValue("@itemID", _itemID);


                return cmd.ExecuteScalar().ToString();

            }
        }


        public Label(string stockCode, int itemID)
        {
            _sc = stockCode;
            _itemID = itemID;
          
        }




        public void printSmallStockLabel()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            DocumentModel document = DocumentModel.Load(@"\\designsvr1\apps\Design and Supply CSharp\ShopFloorApps\SlimlineRevised\BarcodeLabel2.docx");

            

            document.Bookmarks["SC"].GetContent(false).LoadText(_sc.ToString());
            document.Bookmarks["DESC"].GetContent(false).LoadText(_desc);
            document.Bookmarks["BC"].GetContent(false).LoadText("*" + _sc.ToString() + "*");
            

            document.Print("ZDesigner GK420d");
        }



        public void printSmallStockLabelDoor(string doorID)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            DocumentModel document = DocumentModel.Load(@"\\designsvr1\apps\Design and Supply CSharp\ShopFloorApps\SlimlineRevised\BarcodeLabel2Door.docx");



            document.Bookmarks["SC"].GetContent(false).LoadText(_sc.ToString());
            document.Bookmarks["DESC"].GetContent(false).LoadText(_descStock);
            document.Bookmarks["BC"].GetContent(false).LoadText(doorID);


            document.Print("ZDesigner GK420d");
        }


        public void printSmallStockLabelPO(string doorID)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            DocumentModel document = DocumentModel.Load(@"\\designsvr1\apps\Design and Supply CSharp\ShopFloorApps\SlimlineRevised\BarcodeLabel2Door.docx");



            document.Bookmarks["SC"].GetContent(false).LoadText(_sc.ToString());
            document.Bookmarks["DESC"].GetContent(false).LoadText(_descStock);
            document.Bookmarks["BC"].GetContent(false).LoadText(doorID);


            document.Print("ZDesigner GK420d");
        }



        public void printSmallPackingLabel(string doorID)
        {

            Door d = new Door(Convert.ToDouble(doorID));

            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            DocumentModel document = DocumentModel.Load(@"\\designsvr1\apps\Design and Supply CSharp\ShopFloorApps\SlimlineRevised\PackingLabelSmall.docx");

            document.Bookmarks["CustomerName"].GetContent(false).LoadText(d._customerName);
            document.Bookmarks["DoorNumber"].GetContent(false).LoadText(d._doorID.ToString());
            document.Bookmarks["DoorType"].GetContent(false).LoadText(d._doorType);
            document.Bookmarks["OrderNumber"].GetContent(false).LoadText(d._orderNumber);
            document.Bookmarks["Ref"].GetContent(false).LoadText(d._ref);
            
            document.Print("ZDesigner GK420d");
        }



    }



    
}
