using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace PDFGenerator.Classes
{
    public class PdfGeneratorDesign
    {
        public void PDFGenerator()
        {
            try
            {
                string dest = @"C:\temp\design.pdf";
                Directory.CreateDirectory(System.IO.Path.GetDirectoryName(dest));

                PdfWriter writer = new PdfWriter(dest);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf, PageSize.LEGAL, false);
                document.SetMargins(14, 14, 14, 14);

                #region Header
                Table headerTable = new Table(UnitValue.CreatePercentArray(new float[] { 66f, 2f, 32 }));
                headerTable.SetWidth(UnitValue.CreatePercentValue(100));
                headerTable.SetBorder(Border.NO_BORDER);
                Table insideHeaderCell = new Table(UnitValue.CreatePercentArray(new float[] { 25, 70, 5 }));
                insideHeaderCell.SetWidth(UnitValue.CreatePercentValue(100));

                ImageData imageData = ImageDataFactory.Create("C:\\temp\\logo.png");
                Image image = new Image(imageData);
                image.SetWidth(60);
                image.SetHeight(60);
                insideHeaderCell.AddCell(new Cell()
                    .Add(image
                        .SetHorizontalAlignment(HorizontalAlignment.CENTER)
                        .SetPadding(20)
                        )
                    .SetBorder(Border.NO_BORDER)
                    .SetHorizontalAlignment(HorizontalAlignment.CENTER)
                    .SetVerticalAlignment(VerticalAlignment.MIDDLE));

                // Adicione as outras células com o texto (cada uma ocupando 1 linha e 1 coluna)
                insideHeaderCell.AddCell(new Cell()
                    .Add(new Paragraph("Alarmes LOREMIPSOS Brasil S.A")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(15)
                        .SetBold()
                        .SetFixedLeading(16))
                    .SetBorder(Border.NO_BORDER)

                    .Add(new Paragraph("Alarmes e caixas de monitoramento constante, Localização Veicular, AAGH,").SetTextAlignment(TextAlignment.CENTER)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(7)
                        .SetBold()
                        .SetFixedLeading(8))
                    .Add(new Paragraph("Proteção Contra Incedios.")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(7)
                        .SetBold()
                        .SetFixedLeading(8))
                    .Add(new Paragraph()
                        .SetFixedLeading(8)
                        .Add(new Text("Belo Horizonte: ").SetBold())
                        .Add(new Text("Avda Prof. Mario Werneque Nº 518")))
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(7)
                    .Add(new Paragraph()
                        .SetFixedLeading(8)
                        .Add(new Text("Nova Lima: ").SetBold())
                        .Add(new Text("Avda. Afonso Pena, 8765, Br 040 km7")))
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(7)
                    .Add(new Paragraph()
                        .SetFixedLeading(8)
                        .Add(new Text("Joatuba: ").SetBold())
                        .Add(new Text("Rua Vinicius de Morais, Luxemburgo Nº 86")))
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(7)
                    .Add(new Paragraph()
                        .SetFixedLeading(8)
                        .Add(new Text("Piracicaba: ").SetBold())
                        .Add(new Text("Avda Prof. Mario Werneque Nº 518")))
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(7)
                    .Add(new Paragraph()
                        .SetFixedLeading(8)
                        .Add(new Text("João Molevade: ").SetBold())
                        .Add(new Text("Avda. Afonso Pena, 8765, Br 040 km7")))
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(7)
                    .Add(new Paragraph()
                        .SetFixedLeading(8)
                        .Add(new Text("Mail: ").SetBold())
                        .Add(new Text("augustonoronha03@gmail.com")))
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(7)
                     .Add(new Paragraph("Call Center 30-380-520")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(10)
                        .SetBold()
                        .SetFixedLeading(16))
                    .SetBorder(Border.NO_BORDER)

                );

                headerTable.AddCell(new Cell().Add(insideHeaderCell));
                headerTable.AddCell(new Cell().SetBorder(Border.NO_BORDER));
                headerTable.AddCell(new Cell()
                    .Add(new Paragraph("Timbrado Nº 11901489")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(14)
                        .SetBold()
                        //.SetFixedLeading(16)
                        )
                    .Add(new Paragraph("Valido ate 31/12/2025")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(10)
                        .SetBold()
                        //.SetFixedLeading(8)
                        )
                    .Add(new Paragraph("RUC: 7836245-8")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(14)
                        .SetBold()
                        //.SetFixedLeading(8)
                        )
                    .Add(new Paragraph("NotaCredito")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(14)
                        .SetBold()
                        //.SetFixedLeading(8)
                        )
                    .Add(new Paragraph("Nº 001-003-0007842")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(14)
                        .SetBold()
                        //.SetFixedLeading(8)
                        )
                );
                document.Add(headerTable);

                #endregion

                #region body
                // Crie uma nova tabela para conter a tabela principal
                Table containerTable = new Table(1); // 1 coluna
                containerTable.SetWidth(UnitValue.CreatePercentValue(100));
                containerTable.SetMarginTop(10);

                // Crie uma célula para conter a tabela principal
                Cell containerCell = new Cell();
                containerCell.SetPadding(2); // Defina o padding desejado aqui (5 pontos)
                containerCell.SetBorder(new SolidBorder(ColorConstants.BLACK, 0.5f)); // Defina a borda preta na célula контейнера

                // Crie a tabela principal (tb_f1) como antes
                Table tb_f1 = new Table(UnitValue.CreatePercentArray(new float[] { 12.82f, 25.64f, 19.23f, 10.26f, 12.82f, 19.23f }));
                tb_f1.SetWidth(UnitValue.CreatePercentValue(100));


                #region linha1
                tb_f1.AddCell(new Cell().Add(new Paragraph("Data Emissão"))
                    .SetFontSize(10)
                    .SetBorder(Border.NO_BORDER)
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("31/12/2024"))
                    .SetFontSize(10)
                    .SetBorder(Border.NO_BORDER));

                tb_f1.AddCell(new Cell().Add(new Paragraph("Data de Vencimento"))
                    .SetFontSize(10)
                    .SetBorder(Border.NO_BORDER)
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("31/12/2025"))
                    .SetFontSize(10)
                    .SetBorder(Border.NO_BORDER));

                tb_f1.AddCell(new Cell().Add(new Paragraph("Fatura Nro:"))
                    .SetFontSize(10)
                    .SetBorder(Border.NO_BORDER)
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("A009-007-0996654"))
                    .SetFontSize(10)
                    .SetBorder(Border.NO_BORDER));

                #endregion
                #region linha2
                tb_f1.AddCell(new Cell().Add(new Paragraph("Razão Social"))
                    .SetFontSize(10)
                    .SetBorder(Border.NO_BORDER)
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell(1, 3).Add(new Paragraph("Augusto Noronha Leite SA"))
                    .SetFontSize(10)
                    .SetBorder(Border.NO_BORDER));

                tb_f1.AddCell(new Cell().Add(new Paragraph("LCA/I.A"))
                    .SetFontSize(10)
                    .SetBorder(Border.NO_BORDER)
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("00097878-5"))
                    .SetFontSize(10)
                    .SetBorder(Border.NO_BORDER));
                #endregion

                // Adicione a tabela principal à célula контейнера
                containerCell.Add(tb_f1);

                // Adicione a célula контейнера à tabela контейнера
                containerTable.AddCell(containerCell);

                document.Add(containerTable);
                #endregion


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
