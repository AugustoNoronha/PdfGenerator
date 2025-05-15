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
                document.SetMargins(10, 10, 10, 10);

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
                Table containerTable = new Table(1); 
                containerTable.SetWidth(UnitValue.CreatePercentValue(100));
                containerTable.SetMarginTop(5);

                Cell containerCell = new Cell();
                containerCell.SetPadding(2);
                containerCell.SetBorder(new SolidBorder(ColorConstants.BLACK, 0.5f));

                Table tb_f1 = new Table(UnitValue.CreatePercentArray(new float[] { 22.82f, 23.64f, 19.23f, 10.26f, 12.82f, 19.23f }));
                tb_f1.SetWidth(UnitValue.CreatePercentValue(100));


                #region linha1
                tb_f1.AddCell(new Cell().Add(new Paragraph("Data Emissão"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200,200,200),0.5f))
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("31/12/2024"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("Data de Vencimento"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f))
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("31/12/2025"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("Fatura Nro:"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f))
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("A009-007-0996654"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f)));

                #endregion
                #region linha2
                tb_f1.AddCell(new Cell().Add(new Paragraph("Razão Social"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f))
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell(1, 3).Add(new Paragraph("Augusto Noronha Leite SA"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("LCA/I.A"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f))
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("00097878-5"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f)));
                #endregion
                #region linha3
                tb_f1.AddCell(new Cell().Add(new Paragraph("Direção"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f))
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell(1, 3).Add(new Paragraph("HU BBHGU123 - OPS - GUIANA - 1087 - LOREUS . (8888) BRASIL"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("TEl."))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f))
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("13850978680"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f)));
                #endregion
                #region linha3
                tb_f1.AddCell(new Cell().Add(new Paragraph("NOTA DE LORENISPS Nº"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f))
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell(1, 3).Add(new Paragraph(" "))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f)));

                tb_f1.AddCell(new Cell().Add(new Paragraph("DATA"))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f))
                    .SetBackgroundColor(new DeviceRgb(229, 229, 229)));

                tb_f1.AddCell(new Cell().Add(new Paragraph(""))
                    .SetFontSize(8)
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(new DeviceRgb(200, 200, 200), 0.5f)));
                #endregion

                containerCell.Add(tb_f1);
                containerTable.AddCell(containerCell);
                document.Add(containerTable);
                #endregion

                #region tab_dif
                Table tab_dif = new Table(UnitValue.CreatePercentArray(new float[] { 10f, 50f, 20, 10, 10, 10 }));
                tab_dif.SetWidth(UnitValue.CreatePercentValue(100));
                tab_dif.SetMarginTop(5);
                tab_dif.SetPadding(0);
                tab_dif.SetBorder(new SolidBorder(ColorConstants.BLACK, 0.5f));
                tab_dif.AddCell(CreateCell("CANT.", 7, TextAlignment.CENTER, true, bgColor:new DeviceRgb(229,229,229))
                    .SetVerticalAlignment(VerticalAlignment.MIDDLE));
                tab_dif.AddCell(CreateCell("DESCRIÇÃO", 7, TextAlignment.CENTER, true, bgColor: new DeviceRgb(229, 229, 229))
                    .SetVerticalAlignment(VerticalAlignment.MIDDLE));
                tab_dif.AddCell(CreateCell("PRECO UNITARIO", 7, TextAlignment.CENTER, true, bgColor: new DeviceRgb(229, 229, 229))
                    .SetVerticalAlignment(VerticalAlignment.MIDDLE));


                Table aux_table_dif = new Table(UnitValue.CreatePercentArray(new float[] { 33.33f, 33.33f, 33.33f }));
                aux_table_dif.SetWidth(UnitValue.CreatePercentValue(100));
                aux_table_dif.SetPadding(0);
                aux_table_dif.AddCell(new Cell(1, 3).Add(new Paragraph("Valor Venta")
                    .SetFontSize(10)
                    .SetBold()
                    .SetTextAlignment(TextAlignment.CENTER))
                    .SetBorder(Border.NO_BORDER)
                    .SetBorderBottom(new SolidBorder(ColorConstants.BLACK, 0.5f))
                    .SetBackgroundColor(new DeviceRgb(229,229,229)));
                aux_table_dif.AddCell(CreateCell("Extentas", 7, TextAlignment.CENTER, true, false, new DeviceRgb(229, 229, 229))
                    .SetBorderRight(new SolidBorder(ColorConstants.BLACK, 0.5f)));
                aux_table_dif.AddCell(CreateCell("5%", 7, TextAlignment.CENTER, true, false, new DeviceRgb(229, 229, 229))
                    .SetBorderRight(new SolidBorder(ColorConstants.BLACK, 0.5f)));
                aux_table_dif.AddCell(CreateCell("10%", 7, TextAlignment.CENTER, true, false, new DeviceRgb(229, 229, 229)));

                tab_dif.AddCell(new Cell(1, 3).Add(aux_table_dif)
                    .SetBorder(Border.NO_BORDER)
                    .SetPadding(0));

                #endregion
                document.Add(tab_dif);
                #region tab_dif_2
                Table tb_f2 = new Table(UnitValue.CreatePercentArray(new float[] { 10f, 50f, 20, 10, 10, 10f }));
                tb_f2.SetWidth(UnitValue.CreatePercentValue(100));
                tb_f2.SetBorderTop(Border.NO_BORDER);
                tb_f2.SetHeight(180f);
                tb_f2.AddCell(CreateCell("1", 7, TextAlignment.CENTER).SetBorderTop(Border.NO_BORDER));
                tb_f2.AddCell(CreateCell("LOREM IPSUSU QUERES 10/03/2015 ate 31/05/2026 TER NE QUANDO JOGAR al  ", 7, TextAlignment.CENTER).SetBorderTop(Border.NO_BORDER));
                tb_f2.AddCell(CreateCell("", 7, TextAlignment.CENTER).SetBorderTop(Border.NO_BORDER));
                tb_f2.AddCell(CreateCell("", 7, TextAlignment.CENTER).SetBorderTop(Border.NO_BORDER));
                tb_f2.AddCell(CreateCell("", 7, TextAlignment.CENTER).SetBorderTop(Border.NO_BORDER));
                tb_f2.AddCell(CreateCell("105.001,00", 7, TextAlignment.RIGHT).SetBorderTop(Border.NO_BORDER));

                #endregion
                document.Add(tb_f2);

                #region tab_dif_3
                Table tb_f3 = new Table(UnitValue.CreatePercentArray(new float[] { 10f, 50f, 20, 10, 10, 10f }));
                tb_f3.SetWidth(UnitValue.CreatePercentValue(100));
                tb_f3.SetPadding(0);
                tb_f3.SetBorderTop(Border.NO_BORDER);
                tb_f3.AddCell(CreateCell("SUB-TOTAL", 7, TextAlignment.LEFT, bold:true, colSpan:2).SetBorderTop(Border.NO_BORDER));
                tb_f3.AddCell(CreateCell("", 7, TextAlignment.CENTER).SetBorderTop(Border.NO_BORDER));
                tb_f3.AddCell(CreateCell("", 7, TextAlignment.CENTER).SetBorderTop(Border.NO_BORDER));
                tb_f3.AddCell(CreateCell("", 7, TextAlignment.CENTER).SetBorderTop(Border.NO_BORDER));
                tb_f3.AddCell(CreateCell("105.001,00", 7, TextAlignment.RIGHT).SetBorderTop(Border.NO_BORDER));
                tb_f3.AddCell(CreateCell("TOTAL A PAGAR EOHFIOI: CENTO E CINCO MIL E UM", 7, TextAlignment.LEFT, bold:true, colSpan:5).SetBorderTop(Border.NO_BORDER));
                tb_f3.AddCell(CreateCell("105.001,00", 7, TextAlignment.RIGHT   ).SetBorderTop(Border.NO_BORDER));
                document.Add(tb_f3);

                Table tb_f3_aux = new Table(UnitValue.CreatePercentArray(new float[] { 25f, 25f, 25f, 25f }));
                tb_f3_aux.SetWidth(UnitValue.CreatePercentValue(100));
                tb_f3_aux.SetPadding(0);
                tb_f3_aux.AddCell(CreateCell("LIQUIDAÇÃO DE I.PT.U.:", 7, TextAlignment.LEFT, bold: true)
                    .SetBorderTop(Border.NO_BORDER)
                    .SetBorderRight(Border.NO_BORDER));
                tb_f3_aux.AddCell(CreateCell("5%:", 7, TextAlignment.CENTER, bold: true)
                    .SetBorderTop(Border.NO_BORDER)
                    .SetBorderLeft(Border.NO_BORDER)
                    .SetBorderRight(Border.NO_BORDER));
                tb_f3_aux.AddCell(CreateCell("10%:9.546,00", 7, TextAlignment.CENTER, bold: true)
                    .SetBorderTop(Border.NO_BORDER)
                    .SetBorderLeft(Border.NO_BORDER)
                    .SetBorderRight(Border.NO_BORDER));
                tb_f3_aux.AddCell(CreateCell("TOTAL DE I.PT.U.:9.546,00", 7, TextAlignment.LEFT, bold: true)
                    .SetBorderTop(Border.NO_BORDER)
                    .SetBorderLeft(Border.NO_BORDER));
                #endregion
                document.Add(tb_f3_aux);


                document.Close();
                Console.WriteLine("PDF criado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public Cell CreateCell(String Text, float fontSize, TextAlignment textAlignment, bool bold = false, bool border = true, DeviceRgb bgColor = null, int rowSpan = 1, int colSpan  = 1)
        {
            Cell cell = new Cell(rowSpan, colSpan).Add(new Paragraph(Text)
                .SetTextAlignment(textAlignment)
                .SetFontSize(fontSize));
              
            if(bgColor != null)
                cell.SetBackgroundColor(bgColor);
            
            if(bold)
                cell.SetBold();

            if (!border)
                cell.SetBorder(Border.NO_BORDER);

            return cell;
        }
    }
}
