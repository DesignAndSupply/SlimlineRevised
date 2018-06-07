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

        private int _mode { get; set; }
        private int _sc { get; set; }

        private string _desc
        { get
            {
                //UPDATES OPERATIONS DATAGRID
                SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);

                con.Open();
                //UPDATES THE PAINT TO DOOR DATAGRID
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select description from dbo.stock where stock_code = @sc order by stock_code";
                cmd.Parameters.AddWithValue("@sc", _sc);


                return cmd.ExecuteScalar().ToString();
               
            }
        }


        public Label(int mode, int stockCode)
        {
            _mode = mode;
            _sc = stockCode;
        }




        public void printSmallStockLabel()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            DocumentModel document = DocumentModel.Load(@"\\designsvr1\apps\Design and Supply CSharp\ShopFloorApps\SlimlineRevised\BarcodeLabel2.docx");



            document.Bookmarks["SC"].GetContent(false).LoadText(_sc.ToString());
            document.Bookmarks["DESC"].GetContent(false).LoadText(_desc);
            document.Bookmarks["BC"].GetContent(false).LoadText("*" + _sc.ToString() + "*");
            

            document.Print();
        }



    }



    
}
