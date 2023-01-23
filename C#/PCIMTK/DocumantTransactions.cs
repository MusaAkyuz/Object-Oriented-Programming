using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
//using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using QRCoder;
using MigraDoc.Rendering;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PCIMTK
{
	internal class DocumantTransactions
	{
		[Obsolete]
		public static Document CreateDocumant(FileInterface item)
		{
			DatabaseTransactions db = new DatabaseTransactions();
			// Create a new MigraDoc document
			Document document = new Document();
			string boxcode = db.GetBoxCode();

			// Add a section to the document
			Section section = document.AddSection();
			section.PageSetup.TopMargin = "1.5cm";

			/*
			 * 
			 * Arcelik and QR code Section on top of PDF
			 * 
			 */
			// Printing Arcelik image
			#region PrintingArcelikImage
			var image = section.AddImage("icons\\arcelik.png");
			image.Width = new Unit(150, UnitType.Point); ;
			image.Height = new Unit(150, UnitType.Point);
			image.Left = ShapePosition.Center;
			image.Top = ShapePosition.Top;
			image.RelativeVertical = RelativeVertical.Line;
			image.RelativeHorizontal = RelativeHorizontal.Margin;
			image.WrapFormat.Style = WrapStyle.Through;
			#endregion

			// Creating qr code temp picture
			#region QrCodeCreating
			string qrCodeDateFormatBill = null;
			string qrCodeDateFormatProduction = null;

			int count2 = item.Quantity;
			decimal numOfBox2 = item.NumberOfBox;

			if (String.IsNullOrEmpty(item.BillNo))
			{
				item.BillDate = null;
			}
			if (!String.IsNullOrEmpty(item.BillDate))
			{
				DateTime dateForQrCode = DateTime.Parse(item.BillDate);
				qrCodeDateFormatBill = dateForQrCode.ToString("dd.MM.yyyy");
			}

			if (!String.IsNullOrEmpty(item.ProductionDate))
			{
				DateTime dateForQrCode = DateTime.Parse(item.ProductionDate);
				qrCodeDateFormatProduction = dateForQrCode.ToString("dd.MM.yyyy");
			}

			string qrCodeString = item.MaterialCode + ">" +
								  item.LotNo + ">" +
								  item.CompanyCode + ">" +
								  item.BillNo + ">" +
								  qrCodeDateFormatBill + ">" +
								  boxcode + ">" +
								  qrCodeDateFormatProduction + ">" +
								  (count2 / numOfBox2).ToString() + ">" +
								  item.Unit + ">" +
								  (count2 / numOfBox2).ToString();

			QRCodeGenerator qrGenerator = new QRCodeGenerator();
			QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrCodeString, QRCodeGenerator.ECCLevel.Q);
			QRCode qrCode = new QRCode(qrCodeData);
			Bitmap qrCodeImage = qrCode.GetGraphic(20);
			qrCodeImage.Save("qr" + boxcode + ".png", ImageFormat.Png);
			#endregion

			// Printing qr code image
			#region PrintingQrCodeImage
			image = section.AddImage("qr" + boxcode + ".png");
			image.Width = new Unit(120, UnitType.Point);
			image.Height = new Unit(120, UnitType.Point);
			image.Left = ShapePosition.Right;
			image.WrapFormat.Style = WrapStyle.Through;
			#endregion

			// Arcelik image bottom description
			#region ArcelikImageDescription
			Paragraph par;

			//Arçelik A.Ş.
			par = section.AddParagraph();
			par.Format.SpaceBefore = "5.4cm";
			par.Format.Alignment = ParagraphAlignment.Center;
			par.Format.Font.Size = 20;
			par.Format.Font.Bold = true;
			par.AddText("Arçelik A.Ş.");

			//PCI
			par = section.AddParagraph();
			par.Format.Alignment = ParagraphAlignment.Center;
			par.Format.Font.Size = 16;
			par.AddText("PCI");

			//Malzeme Tanıtım Kartı
			par = section.AddParagraph();
			par.Format.Alignment = ParagraphAlignment.Center;
			par.Format.Font.Size = 16;
			par.AddText("Malzeme Tanitim Karti");
			par.Format.SpaceAfter = "0.2cm";
			#endregion

			// REACH /POH ROHS GKK 
			AddLeftBox(section);

			//All information about receiver from Application Form
			#region InfromationTab
			Table table = section.AddTable();
			table.Format.SpaceBefore = "0.3cm";
			Column _headers = table.AddColumn("5cm");
			Column _doublePoint = table.AddColumn("0.5cm");
			Column _values = table.AddColumn("5cm");
			_headers.Borders.Visible = false;
			_doublePoint.Borders.Visible = false;
			_values.Borders.Visible = false;

			Row row = table.AddRow();
			//row.Format.Alignment = ParagraphAlignment.Center;

			row = table.AddRow();
			row.Cells[0].AddParagraph("Malzeme Kodu");
			row.Cells[0].Format.Font.Size = 16;
			row.Cells[1].AddParagraph(":");
			row.Cells[1].Format.Font.Size = 16;
			row.Cells[2].AddParagraph(item.MaterialCode);
			row.Cells[2].Format.Font.Bold = true;
			row.Cells[2].Format.Font.Size = 25;

			row = table.AddRow();
			row.Cells[0].AddParagraph("Lot No");
			row.Cells[0].Format.Font.Size = 16;
			row.Cells[1].AddParagraph(":");
			row.Cells[1].Format.Font.Size = 16;
			row.Cells[2].AddParagraph(item.LotNo);
			row.Cells[2].Format.Font.Size = 16;

			row = table.AddRow();
			row.Cells[0].AddParagraph("Firma Adı");
			row.Cells[0].Format.Font.Size = 16;
			row.Cells[1].AddParagraph(":");
			row.Cells[1].Format.Font.Size = 16;
			row.Cells[2].AddParagraph(item.CompanyName);
			row.Cells[2].Format.Font.Size = 16;

			row = table.AddRow();
			row.Cells[0].AddParagraph("İrsaliye No");
			row.Cells[0].Format.Font.Size = 16;
			row.Cells[1].AddParagraph(":");
			row.Cells[1].Format.Font.Size = 16;
			row.Cells[2].AddParagraph(item.BillNo);
			row.Cells[2].Format.Font.Size = 16;

			row = table.AddRow();
			row.Cells[0].AddParagraph("İrsaliye Tarihi");
			row.Cells[0].Format.Font.Size = 16;
			row.Cells[1].AddParagraph(":");
			row.Cells[1].Format.Font.Size = 16;
			row.Cells[2].AddParagraph(qrCodeDateFormatBill + "");
			row.Cells[2].Format.Font.Size = 16;

			row = table.AddRow();
			row.Cells[0].AddParagraph("Kutu Kodu");
			row.Cells[0].Format.Font.Size = 16;
			row.Cells[1].AddParagraph(":");
			row.Cells[1].Format.Font.Size = 16;
			row.Cells[2].AddParagraph(boxcode);
			row.Cells[2].Format.Font.Size = 16;

			row = table.AddRow();
			row.Cells[0].AddParagraph("Üretim Tarihi");
			row.Cells[0].Format.Font.Size = 16;
			row.Cells[1].AddParagraph(":");
			row.Cells[1].Format.Font.Size = 16;
			row.Cells[2].AddParagraph(qrCodeDateFormatProduction + "");
			row.Cells[2].Format.Font.Size = 16;

			row = table.AddRow();
			row.Cells[0].AddParagraph("Miktar");
			row.Cells[0].Format.Font.Size = 16;
			row.Cells[1].AddParagraph(":");
			row.Cells[1].Format.Font.Size = 16;
			row.Cells[2].AddParagraph((count2 / numOfBox2).ToString());
			row.Cells[2].Format.Font.Bold = true;
			row.Cells[2].Format.Font.Size = 25;

			row = table.AddRow();
			row.Cells[0].AddParagraph("Birim");
			row.Cells[0].Format.Font.Size = 16;
			row.Cells[1].AddParagraph(":");
			row.Cells[1].Format.Font.Size = 16;
			row.Cells[2].AddParagraph(item.Unit);
			row.Cells[2].Format.Font.Size = 16;

			row = table.AddRow();
			row.Cells[0].AddParagraph("Toplam Adet");
			row.Cells[0].Format.Font.Size = 16;
			row.Cells[1].AddParagraph(":");
			row.Cells[1].Format.Font.Size = 16;
			row.Cells[2].AddParagraph((Convert.ToDecimal(item.Quantity) / item.NumberOfBox).ToString("0."));
			row.Cells[2].Format.Font.Size = 16;
			#endregion

			db.UpdateBoxCode();

			return document;
		}

		// TextFreme REACH/PAH ROSH GKK
		private static void AddLeftBox(Section section)
		{
			var frame = section.AddTextFrame();
			//frame.RelativeVertical = RelativeVertical.Line;
			frame.WrapFormat.Style = WrapStyle.Through;
			//frame.LineFormat.Width = Unit.FromPoint(1.6);
			frame.Left = ShapePosition.Right;
			frame.Width = new Unit(70);
			frame.Height = new Unit(100);
			frame.Orientation = TextOrientation.Downward;

			Table table = new Table();
			Column reach = new Column();
			Column _empty = new Column();
			Column rohs = new Column();
			Column _empty2 = new Column();
			Column gkk = new Column();

			reach = table.AddColumn("4cm");
			_empty = table.AddColumn("0.8cm");
			rohs = table.AddColumn("4cm");
			_empty2 = table.AddColumn("0.8cm");
			gkk = table.AddColumn("4cm");

			Row row = new Row();
			row = table.AddRow();
			row.Cells[0].AddParagraph("REACH \n/ PAH");
			row.Cells[0].Format.Alignment = ParagraphAlignment.Center;
			row.Cells[0].Format.Font.Bold = true;
			row.Cells[0].Format.Font.Size = 16;
			row.Cells[0].Borders.Visible = true;
			row.Cells[0].Borders.Width = 1.6;
			row.Cells[0].Format.SpaceAfter = "0.5cm";
			row.Cells[0].Format.SpaceBefore = "0.5cm";

			row.Cells[1].Borders.Width = 1.6;
			row.Cells[1].Borders.Right.Visible = true;
			row.Cells[1].Borders.Top.Visible = false;
			row.Cells[1].Borders.Bottom.Visible = false;
			row.Cells[1].Borders.Left.Visible = true;

			row.Cells[2].AddParagraph("ROHS");
			row.Cells[2].Format.Alignment = ParagraphAlignment.Center;
			row.Cells[2].Format.Font.Bold = true;
			row.Cells[2].Format.Font.Size = 16;
			row.Cells[2].Borders.Visible = true;
			row.Cells[2].Borders.Width = 1.6;
			row.Cells[2].Format.SpaceAfter = "0.8cm";
			row.Cells[2].Format.SpaceBefore = "0.8cm";

			row.Cells[3].Borders.Width = 1.6;
			row.Cells[3].Borders.Right.Visible = true;
			row.Cells[3].Borders.Top.Visible = false;
			row.Cells[3].Borders.Bottom.Visible = false;
			row.Cells[3].Borders.Left.Visible = true;

			row.Cells[4].AddParagraph("GKK");
			row.Cells[4].Format.Alignment = ParagraphAlignment.Center;
			row.Cells[4].Format.Font.Bold = true;
			row.Cells[4].Borders.Visible = true;
			row.Cells[4].Borders.Width = 1.6;
			row.Cells[4].Format.Font.Size = 16;
			row.Cells[4].Format.SpaceAfter = "0.8cm";
			row.Cells[4].Format.SpaceBefore = "0.8cm";


			frame.Add(table);
		}

		[Obsolete]
		public static string RenderDocument(Form1 f)
		{
			Document splicedDocument = new Document();
			var data = FileInterface.UpdateList(f);

			f.progressBar.Minimum = 0;
			f.progressBar.Maximum = data.Count;
			int barControl = 0;

			foreach (var item in data)
			{
				barControl++;
				f.progressBar.Value = barControl;
				var document = DocumantTransactions.CreateDocumant(item);
				var section2 = document.Sections[0].Clone();
				splicedDocument.Add(section2);
			}

			PdfDocumentRenderer pdfRenderer2 = new PdfDocumentRenderer();
			// Associate the MigraDoc document with a renderer
			pdfRenderer2.Document = splicedDocument;
			// Layout and render document to PDF
			pdfRenderer2.RenderDocument();
			// Save the document...
			string filename2 = "TempDocument\\LastReceiver";
			filename2 += ".pdf";
			pdfRenderer2.PdfDocument.Save(filename2);
			// ...and start a viewer.

			DirectoryInfo directory = new DirectoryInfo("TempDocument\\");

			foreach (var file in directory.GetFiles())
			{
				if (file.Name == "qr*")
				{
					file.Delete();
				}
			}

			return filename2;
		}
	}
}
