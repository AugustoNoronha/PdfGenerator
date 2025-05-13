using System;
using System.IO;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace PDFGenerator.Classes
{
    public class PdfGenerator
    {
        public void CriarPrimeiroPDF()
        {
            try
            {
                string dest = @"C:\temp\primeiro.pdf";
                Directory.CreateDirectory(Path.GetDirectoryName(dest));

                PdfWriter writer = new PdfWriter(dest);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                document.Add(new Paragraph("Titulo do PDF").SetFontSize(24));
                document.Add(new Paragraph("Este é o um parágrafo de exemplo no PDF."));

                Table table = new Table(4);
                table.SetWidth(UnitValue.CreatePercentValue(100));

                table.AddHeaderCell(new Cell(1, 4)
                    .Add(new Paragraph("Essa celula ocupa o espaço de colunas"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY));


                table.AddHeaderCell("coluna 1");
                table.AddHeaderCell("coluna 2");
                table.AddHeaderCell("coluna 3");
                table.AddHeaderCell("coluna 4");

                for(int i = 0; i < 3; i++)
                {
                    table.AddCell("linha " + (i + 1) + ", Coluna 1");
                    table.AddCell("linha " + (i + 1) + ", Coluna 2");
                    table.AddCell("linha " + (i + 1) + ", Coluna 3");
                    table.AddCell("linha " + (i + 1) + ", Coluna 4");
                }
                document.Add(table);

                float[] columnWidths = { 60, 5, 35 };
                Table subTable = new Table(UnitValue.CreatePercentArray(columnWidths));
                subTable.SetWidth(UnitValue.CreatePercentValue(100));
                subTable.SetMarginTop(10);
                subTable.SetBorder(Border.NO_BORDER);

                subTable.AddCell(new Cell().Add(new Paragraph("Celular 60%"))
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY))
                    .SetTextAlignment(TextAlignment.CENTER);

                subTable.AddCell(new Cell().SetBorder(Border.NO_BORDER));

                subTable.AddCell(new Cell()
                    .Add(new Paragraph("Celula 40%"))
                    .Add(new Paragraph()
                        .Add(new Text("Número de telefone").SetBold()))
                    .Add(new Paragraph("(31) 99999-8765:"))
                    .SetTextAlignment(TextAlignment.CENTER));

                document.Add(subTable.SetBorder(Border.NO_BORDER));

                Table table3 = new Table(6);
                table3.SetMarginTop(10);
                table3.SetWidth(UnitValue.CreatePercentValue(100));


                table3.AddHeaderCell("coluna 1");
                table3.AddHeaderCell("coluna 2");
                table3.AddHeaderCell("coluna 3");
                table3.AddHeaderCell("coluna 4");

                table3.AddCell(new Cell().Add(new Paragraph("Augusto Noronha")));
                table3.AddCell(new Cell().Add(new Paragraph("Augusto Noronha")));

                Table tabela_interna = new Table(UnitValue.CreatePercentArray(new float[] {33,33,33}));
                tabela_interna.SetWidth(UnitValue.CreatePercentValue(100));
                tabela_interna.SetBorder(Border.NO_BORDER);
                tabela_interna.SetPadding(0);
                #region cabecalhos tabela interna
                tabela_interna.AddHeaderCell(new Cell(1,3).Add(new Paragraph("Qtd. Itens Aplicado Desconto"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(0.5f))
                    .SetPadding(0));
                tabela_interna.AddCell(new Cell().Add(new Paragraph("5%"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderRight(new SolidBorder(0.5f)))
                    .SetPadding(0);
                tabela_interna.AddCell(new Cell().Add(new Paragraph("10%"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderRight(new SolidBorder(0.5f)))
                    .SetPadding(0);
                tabela_interna.AddCell(new Cell().Add(new Paragraph("15%"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .SetPaddingBottom(0));
                #endregion

                #region corpo tabela interna
                tabela_interna.AddCell(new Cell().Add(new Paragraph(" - "))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderTop(new SolidBorder(0.5f))
                    .SetBorderRight(new SolidBorder(0.5f)))
                    .SetPadding(0);
                    tabela_interna.AddCell(new Cell().Add(new Paragraph("64 itens"))
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetBorder(Border.NO_BORDER)
                        .SetBorderTop(new SolidBorder(0.5f))
                        .SetBorderRight(new SolidBorder(0.5f)))
                        .SetPadding(0);
                    tabela_interna.AddCell(new Cell().Add(new Paragraph("10 itens"))
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetBorder(Border.NO_BORDER)
                        .SetBorderTop(new SolidBorder(0.5f))
                        .SetPaddingBottom(0));
                #endregion
                table3.AddCell(new Cell(1,2).Add(tabela_interna).SetPadding(0));


                document.Add(table3);
                document.Close();
                Console.WriteLine("PDF criado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
