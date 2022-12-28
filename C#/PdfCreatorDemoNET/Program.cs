using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using Section = MigraDoc.DocumentObjectModel.Section;

namespace PdfCreatorDemoNET
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// Create a MigraDoc document
			Document document = CreateDocument();
			document.UseCmykColor = true;

			// ===== Unicode encoding and font program embedding in MigraDoc is demonstrated here =====

			// A flag indicating whether to create a Unicode PDF or a WinAnsi PDF file.
			// This setting applies to all fonts used in the PDF document.
			// This setting has no effect on the RTF renderer.
			const bool unicode = false;

			// An enum indicating whether to embed fonts or not.
			// This setting applies to all font programs used in the document.
			// This setting has no effect on the RTF renderer.
			// (The term 'font program' is used by Adobe for a file containing a font. Technically a 'font file'
			// is a collection of small programs and each program renders the glyph of a character when executed.
			// Using a font in PDFsharp may lead to the embedding of one or more font programms, because each outline
			// (regular, bold, italic, bold+italic, ...) has its own fontprogram)
			//PdfFontEmbedding embedding = PdfFontEmbedding.Always;

			// ========================================================================================

			// Create a renderer for the MigraDoc document.
			PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(unicode);

			// Associate the MigraDoc document with a renderer
			pdfRenderer.Document = document;

			// Layout and render document to PDF
			pdfRenderer.RenderDocument();

			// Save the document...
			const string filename = "HelloWorld.pdf";
			pdfRenderer.PdfDocument.Save(filename);
			// ...and start a viewer.
			Process.Start(filename);
		}

		/// <summary>
		/// Creates an absolutely minimalistic document.
		/// </summary>
		static Document CreateDocument()
		{
			// Create a new MigraDoc document
			Document document = new Document();

			// Add a section to the document
			Section section = document.AddSection();
			section.PageSetup.TopMargin = "1.5cm";
			// Add a paragraph to the section
			//Paragraph paragraph = section.AddParagraph();


			//Add some text to the paragraph
			//paragraph.AddFormattedText("Hello, World!", TextFormat.Bold);
			var image = section.AddImage("arcelik.png");
			image.Width = new Unit(150, UnitType.Point); ;
			image.Height = new Unit(150, UnitType.Point);
			image.Left = ShapePosition.Center;
			image.RelativeVertical = RelativeVertical.Line;
			image.RelativeHorizontal = RelativeHorizontal.Margin;
			image.Top = ShapePosition.Top;
			image.WrapFormat.Style = WrapStyle.Through;
			image = section.AddImage("qr.png");
			image.Width = new Unit(80, UnitType.Point); ;
			image.Height = new Unit(80, UnitType.Point);
			image.Left = ShapePosition.Right;
			
			Paragraph par =	section.AddParagraph("Deneme");

			//Table pageFormatTable = section.AddTable();
			//Column first = pageFormatTable.AddColumn("5cm");
			//first.Format.Alignment = ParagraphAlignment.Center;
			//Column second = pageFormatTable.AddColumn("5cm");
			//second.Format.Alignment = ParagraphAlignment.Center;
			//Column third = pageFormatTable.AddColumn("5cm");
			//third.Format.Alignment = ParagraphAlignment.Left;

			//Row r = pageFormatTable.AddRow();
			//Paragraph header = r.Cells[0].AddParagraph();
			//var image = r.Cells[1].AddImage("arcelik.png");
			//var image2 = r.Cells[2].AddImage("Tardis1.png");
			//image.Left = ShapePosition.Center;

			//r.Cells[0].VerticalAlignment = VerticalAlignment.Center;
			//r.Cells[1].VerticalAlignment = VerticalAlignment.Center;
			//r.Cells[2].VerticalAlignment = VerticalAlignment.Center;

			return document;
		}
	}
}
