using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemBox.Document;
using System.Data.SqlClient;
using System.Diagnostics;
using RawPrint;
using Microsoft.Win32;

namespace SlimlineRevisedUI.Classes
{
    class PackingLabel
    {

        public void printSmallPackingLabel(string doorID)
        {

            Door d = new Door(Convert.ToDouble(doorID));

            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            DocumentModel document = DocumentModel.Load(@"\\designsvr1\apps\Design and Supply CSharp\ShopFloorApps\SlimlineRevised\PackingLabelSmall.docx");
            PrintOptions p = new PrintOptions();
            p.CopyCount = 3;


            document.Bookmarks["CustomerName"].GetContent(false).LoadText(d._customerName);
            document.Bookmarks["DoorNumber"].GetContent(false).LoadText(d._doorID.ToString());
            document.Bookmarks["DoorType"].GetContent(false).LoadText(d._doorType);
            document.Bookmarks["OrderNumber"].GetContent(false).LoadText(d._orderNumber);
            document.Bookmarks["Ref"].GetContent(false).LoadText(d._ref);

           document.Print("ZDesigner GK420d",p);
        }

        public void printLargePackingLabel(string doorID)
        {
            string documentLocation = @"c:\temp\";
            string packLabelName = "largepacklabel.pdf";
            string warningLabelName = @"c:\temp\PackLabelWarning.pdf";
            string printerName = "HP LaserJet P2035";
            //string printerName = "RICOH MP C4503";
            string tempDocLocation = documentLocation + packLabelName;
            


            Door d = new Door(Convert.ToDouble(doorID));

            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            DocumentModel document = DocumentModel.Load(@"\\designsvr1\apps\Design and Supply CSharp\ShopFloorApps\SlimlineRevised\PackLabelLarge.docx");


            PrintOptions p = new PrintOptions();
            p.CopyCount = 1;
          

            document.Bookmarks["CustomerName"].GetContent(false).LoadText(d._customerName);
            document.Bookmarks["DoorNumber"].GetContent(false).LoadText(d._doorID.ToString());
            document.Bookmarks["DoorType"].GetContent(false).LoadText(d._doorType);
            document.Bookmarks["OrderNumber"].GetContent(false).LoadText(d._orderNumber);
            document.Bookmarks["Ref"].GetContent(false).LoadText(d._ref);
            document.Bookmarks["PackDate"].GetContent(false).LoadText(d._packDate.ToShortDateString());

            document.Save(tempDocLocation);


            var exePath = Registry.LocalMachine.OpenSubKey(
            @"SOFTWARE\Microsoft\Windows\CurrentVersion" +
            @"\App Paths\SumatraPDF.exe").GetValue("").ToString();

            var args = $"-print-to \"{printerName}\" {tempDocLocation}";
            var args2 = $"-print-to \"{printerName}\" {warningLabelName}";

            var process = Process.Start(exePath, args);
            process.WaitForExit();

            var processWarning = Process.Start(exePath, args2);
            processWarning.WaitForExit();


        }
    }
}
