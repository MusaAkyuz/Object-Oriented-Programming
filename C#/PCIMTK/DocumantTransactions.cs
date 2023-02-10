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
using System.Windows;
using System.Configuration;

namespace PCIMTK
{
	internal class DocumantTransactions
	{
		[Obsolete]
		public static Document CreateDocumant(FileInterface item)
		{
			try
			{
				List<string> configSettings = new List<string>(ConfigurationSettings.AppSettings["CompanyCode"].Split(new char[] { ';' }));

				DatabaseTransactions db = new DatabaseTransactions();
				string boxcode = db.GetBoxCode();
				if (String.IsNullOrEmpty(boxcode))
				{
					db.AddNewCompanyBoxCode(1);
					boxcode = "1";
				}
				const int codeLength = 20;
				var companyCode = configSettings[0].ToString();
				var yearLast2Char = DateTime.Now.ToString("yy");
				var lastBoxCode = db.GetBoxCode();
				var digit = codeLength - companyCode.Length - yearLast2Char.Length - lastBoxCode.Length;
				var zeros = new string('0', digit);

				var newBoxCode = companyCode + yearLast2Char + zeros + boxcode;

				// Create a new MigraDoc document
				Document document = new Document();
				
				// Add a section to the document
				Section section = document.AddSection();
				section.PageSetup.TopMargin = "1.1cm";
				section.PageSetup.LeftMargin = "1.2cm";
				section.PageSetup.RightMargin = "1.2cm";
				section.PageSetup.PageFormat = PageFormat.A6;

				/*
				 * 
				 * Arcelik and QR code Section on top of PDF
				 * 
				 */
				// Printing Arcelik image
				#region PrintingArcelikImage
				var image = section.AddImage("icons\\arcelik.png");
				image.Width = new Unit(60, UnitType.Point); ;
				image.Height = new Unit(60, UnitType.Point);
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
									  newBoxCode + ">" +
									  qrCodeDateFormatProduction + ">" +
									  (count2 / numOfBox2).ToString() + ">" +
									  item.Unit + ">" +
									  (count2 / numOfBox2).ToString();

				QRCodeGenerator qrGenerator = new QRCodeGenerator();
				QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrCodeString, QRCodeGenerator.ECCLevel.Q);
				QRCode qrCode = new QRCode(qrCodeData);
				Bitmap qrCodeImage = qrCode.GetGraphic(20);
				qrCodeImage.Save("TempDocument\\qr" + newBoxCode + ".png", ImageFormat.Png);
				#endregion

				// Printing qr code image
				#region PrintingQrCodeImage
				image = section.AddImage("TempDocument\\qr" + newBoxCode + ".png");
				image.Width = new Unit(60, UnitType.Point);
				image.Height = new Unit(60, UnitType.Point);
				image.Left = ShapePosition.Right;
				image.WrapFormat.Style = WrapStyle.Through;
				#endregion

				// Arcelik image bottom description
				#region ArcelikImageDescription
				Paragraph par;

				int fontSize = 8;
				int bigFontSize = 12;


				//Arçelik A.Ş.
				par = section.AddParagraph();
				par.Format.SpaceBefore = new Unit(65, UnitType.Point);
				par.Format.Alignment = ParagraphAlignment.Center;
				par.Format.Font.Size = fontSize;
				par.Format.Font.Bold = true;
				par.AddText("Arçelik A.Ş.");

				//PCI
				par = section.AddParagraph();
				par.Format.Alignment = ParagraphAlignment.Center;
				par.Format.Font.Size = 10;
				par.AddText("PCI");

				//Malzeme Tanıtım Kartı
				par = section.AddParagraph();
				par.Format.Alignment = ParagraphAlignment.Center;
				par.Format.Font.Size = fontSize;
				par.AddText("Malzeme Tanitim Karti");
				par.Format.SpaceAfter = "0.1cm";
				#endregion

				// REACH /POH ROHS GKK 
				AddLeftBox(section);

				//All information about receiver from Application Form
				#region InfromationTab
				Table table = section.AddTable();
				table.Format.SpaceBefore = "0.15cm";
				Column _headers = table.AddColumn("2.5cm");
				Column _doublePoint = table.AddColumn("0.5cm");
				Column _values = table.AddColumn("3cm");
				_headers.Borders.Visible = false;
				_doublePoint.Borders.Visible = false;
				_values.Borders.Visible = false;

				Row row = table.AddRow();
				//row.Format.Alignment = ParagraphAlignment.Center;

				row = table.AddRow();
				row.Cells[0].AddParagraph("Malzeme Kodu");
				row.Cells[0].Format.Font.Size = fontSize;
				row.Cells[1].AddParagraph(":");
				row.Cells[1].Format.Font.Size = fontSize;
				row.Cells[2].AddParagraph(item.MaterialCode);
				row.Cells[2].Format.Font.Bold = true;
				row.Cells[2].Format.Font.Size = bigFontSize;

				row = table.AddRow();
				row.Cells[0].AddParagraph("Lot No");
				row.Cells[0].Format.Font.Size = fontSize;
				row.Cells[1].AddParagraph(":");
				row.Cells[1].Format.Font.Size = fontSize;
				row.Cells[2].AddParagraph(item.LotNo);
				row.Cells[2].Format.Font.Size = fontSize;

				row = table.AddRow();
				row.Cells[0].AddParagraph("Firma Adı");
				row.Cells[0].Format.Font.Size = fontSize;
				row.Cells[1].AddParagraph(":");
				row.Cells[1].Format.Font.Size = fontSize;
				row.Cells[2].AddParagraph(item.CompanyName);
				row.Cells[2].Format.Font.Size = fontSize;

				row = table.AddRow();
				row.Cells[0].AddParagraph("İrsaliye No");
				row.Cells[0].Format.Font.Size = fontSize;
				row.Cells[1].AddParagraph(":");
				row.Cells[1].Format.Font.Size = fontSize;
				row.Cells[2].AddParagraph(item.BillNo);
				row.Cells[2].Format.Font.Size = fontSize;

				row = table.AddRow();
				row.Cells[0].AddParagraph("İrsaliye Tarihi");
				row.Cells[0].Format.Font.Size = fontSize;
				row.Cells[1].AddParagraph(":");
				row.Cells[1].Format.Font.Size = fontSize;
				row.Cells[2].AddParagraph(qrCodeDateFormatBill + "");
				row.Cells[2].Format.Font.Size = fontSize;

				row = table.AddRow();
				row.Cells[0].AddParagraph("Kutu Kodu");
				row.Cells[0].Format.Font.Size = fontSize;
				row.Cells[1].AddParagraph(":");
				row.Cells[1].Format.Font.Size = fontSize;
				row.Cells[2].AddParagraph(newBoxCode);
				row.Cells[2].Format.Font.Size = fontSize;

				row = table.AddRow();
				row.Cells[0].AddParagraph("Üretim Tarihi");
				row.Cells[0].Format.Font.Size = fontSize;
				row.Cells[1].AddParagraph(":");
				row.Cells[1].Format.Font.Size = fontSize;
				row.Cells[2].AddParagraph(qrCodeDateFormatProduction + "");
				row.Cells[2].Format.Font.Size = fontSize;

				row = table.AddRow();
				row.Cells[0].AddParagraph("Miktar");
				row.Cells[0].Format.Font.Size = fontSize;
				row.Cells[1].AddParagraph(":");
				row.Cells[1].Format.Font.Size = fontSize;
				row.Cells[2].AddParagraph((count2 / numOfBox2).ToString());
				row.Cells[2].Format.Font.Bold = true;
				row.Cells[2].Format.Font.Size = bigFontSize;

				row = table.AddRow();
				row.Cells[0].AddParagraph("Birim");
				row.Cells[0].Format.Font.Size = fontSize;
				row.Cells[1].AddParagraph(":");
				row.Cells[1].Format.Font.Size = fontSize;
				row.Cells[2].AddParagraph(item.Unit);
				row.Cells[2].Format.Font.Size = fontSize;

				row = table.AddRow();
				row.Cells[0].AddParagraph("Toplam Adet");
				row.Cells[0].Format.Font.Size = fontSize;
				row.Cells[1].AddParagraph(":");
				row.Cells[1].Format.Font.Size = fontSize;
				row.Cells[2].AddParagraph((Convert.ToDecimal(item.Quantity) / item.NumberOfBox).ToString("0."));
				row.Cells[2].Format.Font.Size = fontSize;
				#endregion

				db.UpdateBoxCode(Convert.ToInt32(boxcode) + 1);

				return document;
			}
			catch
			{
				string logtxt = ConfigurationSettings.AppSettings["LogFilePath"].ToString();
				System.Windows.MessageBox.Show("Error while creating document!", "Error", MessageBoxButton.OK);

				// Logging Error 013
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR013-CreateDocument");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR013-CreateDocument");
					tw.Close();
				}
				#endregion
			}

			return null;
		}

		// TextFreme REACH/PAH ROSH GKK
		[Obsolete]
		private static void AddLeftBox(Section section)
		{
			try
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

				int fontSize = 8;
				int borderWidth = 1;

				reach = table.AddColumn("1.95cm");
				_empty = table.AddColumn("0.3cm");
				rohs = table.AddColumn("1.95cm");
				_empty2 = table.AddColumn("0.3cm");
				gkk = table.AddColumn("1.95cm");

				Row row = new Row();
				row = table.AddRow();
				row.Cells[0].AddParagraph("REACH \n/ PAH");
				row.Cells[0].Format.Alignment = ParagraphAlignment.Center;
				row.Cells[0].Format.Font.Bold = true;
				row.Cells[0].Format.Font.Size = fontSize;
				row.Cells[0].Borders.Visible = true;
				row.Cells[0].Borders.Width = borderWidth;
				row.Cells[0].Format.SpaceAfter = "0.25cm";
				row.Cells[0].Format.SpaceBefore = "0.25cm";

				row.Cells[1].Borders.Width = borderWidth;
				row.Cells[1].Borders.Right.Visible = true;
				row.Cells[1].Borders.Top.Visible = false;
				row.Cells[1].Borders.Bottom.Visible = false;
				row.Cells[1].Borders.Left.Visible = true;

				row.Cells[2].AddParagraph("ROHS");
				row.Cells[2].Format.Alignment = ParagraphAlignment.Center;
				row.Cells[2].Format.Font.Bold = true;
				row.Cells[2].Format.Font.Size = fontSize;
				row.Cells[2].Borders.Visible = true;
				row.Cells[2].Borders.Width = borderWidth;
				row.Cells[2].Format.SpaceAfter = "0.4cm";
				row.Cells[2].Format.SpaceBefore = "0.4cm";

				row.Cells[3].Borders.Width = borderWidth;
				row.Cells[3].Borders.Right.Visible = true;
				row.Cells[3].Borders.Top.Visible = false;
				row.Cells[3].Borders.Bottom.Visible = false;
				row.Cells[3].Borders.Left.Visible = true;

				row.Cells[4].AddParagraph("GKK");
				row.Cells[4].Format.Alignment = ParagraphAlignment.Center;
				row.Cells[4].Format.Font.Bold = true;
				row.Cells[4].Borders.Visible = true;
				row.Cells[4].Borders.Width = borderWidth;
				row.Cells[4].Format.Font.Size = fontSize;
				row.Cells[4].Format.SpaceAfter = "0.4cm";
				row.Cells[4].Format.SpaceBefore = "0.4cm";

				frame.Add(table);
			}
			catch
			{
				string logtxt = ConfigurationSettings.AppSettings["LogFilePath"].ToString();
				System.Windows.MessageBox.Show("Error while creating document!", "Error", MessageBoxButton.OK);

				// Logging Error 014
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR014-AddLeftBox");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR014-AddLeftBox");
					tw.Close();
				}
				#endregion
			}
		}

		[Obsolete]
		public static string RenderDocument(Form1 f)
		{
			try
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
					section2.PageSetup.PageFormat = PageFormat.A6;
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
					if (System.Text.RegularExpressions.Regex.IsMatch(file.Name.ToString(), "[q]"))
					{
						file.Delete();
					}
				}

				return filename2;
			}
			catch
			{
				string logtxt = ConfigurationSettings.AppSettings["LogFilePath"].ToString();
				System.Windows.MessageBox.Show("Error while rendering document!", "Error", MessageBoxButton.OK);

				// Logging Error 015
				#region Logging
				if (!File.Exists(logtxt))
				{
					File.Create(logtxt);
					TextWriter tw = new StreamWriter(logtxt);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR015-RenderDocument");
					tw.Close();
				}
				else if (File.Exists(logtxt))
				{
					TextWriter tw = new StreamWriter(logtxt, true);
					tw.WriteLine(DateTime.Now.ToString() + " : ERROR015-RenderDocument");
					tw.Close();
				}
				#endregion
			}

			return null;
		}
	}
}
