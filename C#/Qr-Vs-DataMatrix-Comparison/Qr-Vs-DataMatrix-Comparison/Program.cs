using Spire.Barcode;
using System.Drawing;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace Qr_Vs_DataMatrix_Comparison
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (var data = 1; data < 50; data++)
            {
                string src = "a1c";

                BarcodeSettings settings = new BarcodeSettings();
                settings.X = 0.5f;
                settings.Type = BarCodeType.Code93;
                settings.ShowText = false;
                settings.Data = String.Concat(Enumerable.Repeat("Hello", data));
                //settings.Data2D = String.Concat(Enumerable.Repeat("Hello", data));
                settings.DataMatrixSymbolShape = DataMatrixSymbolShape.Square;
                BarCodeGenerator generator = new BarCodeGenerator(settings);
                Image image = generator.GenerateImage();
                image.Save("Temp\\DataMatrix" + data.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);

                BarcodeSettings settings2 = new BarcodeSettings();
                settings2.Type = BarCodeType.QRCode;
                settings2.X = 0.5f;
                settings2.Data = String.Concat(Enumerable.Repeat("Hello", data));
                //settings2.Data2D = String.Concat(Enumerable.Repeat("Hello", data));
                settings2.QRCodeDataMode = QRCodeDataMode.AlphaNumber;
                settings2.QRCodeECL = QRCodeECL.L;
                BarCodeGenerator generator2 = new BarCodeGenerator(settings2);
                Image image2 = generator2.GenerateImage();
                image2.Save("Temp\\QRCode" + data.ToString() + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
            //int id = 50;

            //List<FileModel> allFiles = new List<FileModel>();
            //int numPDFs = (id / 10);

            //if (id % 10 != 0)
            //    numPDFs++;

            //PdfUnitConvertor unitCvtr = new PdfUnitConvertor();
            //float h = unitCvtr.ConvertUnits(20, PdfGraphicsUnit.Millimeter, PdfGraphicsUnit.Point);
            //float unit = h / 10.0f;
            //PdfFont font = new PdfFont(PdfFontFamily.Helvetica, 6.0f);
            //PdfSolidBrush brush = new PdfSolidBrush(Color.Black);
            //PdfStringFormat centerAlignment = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);



        }

        //public static bool PrintMultiplePagePDF(string QR, string footer, int id, string printerName)
        //{
        //    //-------------------------------------------------
        //    var watch = new System.Diagnostics.Stopwatch();
        //    watch.Start();
        //    //-------------------------------------------------

        //    List<FileModel> allFiles = new List<FileModel>();
        //    int numPDFs = (id / 10);

        //    if (id % 10 != 0)
        //        numPDFs++;

        //    PdfUnitConvertor unitCvtr = new PdfUnitConvertor();
        //    float h = unitCvtr.ConvertUnits(20, PdfGraphicsUnit.Millimeter, PdfGraphicsUnit.Point);
        //    float unit = h / 10.0f;
        //    PdfFont font = new PdfFont(PdfFontFamily.Helvetica, 6.0f);
        //    PdfSolidBrush brush = new PdfSolidBrush(Color.Black);
        //    PdfStringFormat centerAlignment = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);

        //    int j = 1;
        //    for (int i = 0; i < numPDFs; i++)
        //    {
        //        PdfDocument doc = new PdfDocument();
        //        while (j <= id)
        //        {
        //            Image qrcodeImage = StringToPng(QR, j);
        //            PdfImage img = PdfImage.FromImage(qrcodeImage);
        //            PdfPageBase page = doc.Pages.Add(new SizeF(h, h), new PdfMargins(0.0f));
        //            page.Canvas.DrawImage(img, new PointF(1.5f * unit, 2.5f * unit), new SizeF(7.0f * unit, 7.0f * unit));
        //            //page.Canvas.DrawString(footer, font, brush, page.Canvas.ClientSize.Width / 2, unit * 10.5f, centerAlignment);
        //            page.Canvas.Save();

        //            j++;

        //            if (j % 10 == 1 && j != 1)
        //                break;
        //        }

        //        string filePath = "Temp\\labelGroup" + i.ToString() + ".pdf";
        //        doc.SaveToFile(filePath, FileFormat.PDF);
        //    }


        //    int pageCount = 10;
        //    for (int i = 0; i < numPDFs; i++)
        //    {
        //        if (i == numPDFs - 1 && id % 10 != 0)
        //            pageCount = id % 10;

        //        string filePath = "Temp\\labelGroup" + i.ToString() + ".pdf";
        //        allFiles.Add(new FileModel
        //        {
        //            filePath = filePath,
        //            pageCount = pageCount
        //        });
        //    }

        //    //-------------------------------------------------
        //    watch.Stop();
        //    using (StreamWriter writer = new StreamWriter("C:\\Users\\muss\\Desktop\\log.txt", true))
        //    {
        //        writer.WriteLine("Create Document : Dosyayı Oluşturma " + watch.ElapsedMilliseconds.ToString() + " ms");
        //        //Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        //    }
        //    //-------------------------------------------------


        //    RawPrinterHelper.SendBytesToPrinter(printerName, allFiles);

        //    allFiles.Clear();

        //    return true;

        //}

        //private static Image StringToPng(string src, int id)
        //{ 

        //    return (Image)qrCodeImage;

        //}
    }
}
