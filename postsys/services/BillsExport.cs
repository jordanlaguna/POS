using iTextSharp.text;
using iTextSharp.text.pdf;
using postsys.model;

public class BillsExport
{
    public void BillsExportAsPdf(BillsModel bills)
    {
        string carpetaFacturas = Path.Combine(Application.StartupPath, "Facturas");
        Directory.CreateDirectory(carpetaFacturas);

        string ruta = Path.Combine(carpetaFacturas, $"Factura_{bills.Number}.pdf");

        Document doc = new Document(PageSize.A4, 50, 50, 25, 25);
        PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
        doc.Open();

        // title
        doc.Add(new Paragraph($"Factura #{bills.Number}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)));
        doc.Add(new Paragraph($"Fecha: {bills.Date_now:dd/MM/yyyy HH:mm:ss}\n\n"));

        // header of the bill
        doc.Add(new Paragraph("---------------- Detalle de productos:----------------\n", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));

        foreach (var p in bills.Product)
        {
            string linea = $" - {p.name} x {p.quantity} -> ₡{p.price:0.00} -> ₡{p.quantity * p.price:0.00}";
            doc.Add(new Paragraph(linea));
        }

        doc.Add(new Paragraph("\n-------------------------------------\n"));

        // totals
        doc.Add(new Paragraph($"Subtotal: ₡{bills.Subtotal:0.00}"));
        doc.Add(new Paragraph($"IVA: ₡{bills.IVA:0.00}"));
        doc.Add(new Paragraph($"Total a pagar: ₡{bills.Total:0.00}"));
        doc.Add(new Paragraph($"Efectivo recibido: ₡{bills.Cash:0.00}"));
        doc.Add(new Paragraph($"Vuelto entregado: ₡{bills.Change:0.00}"));

        doc.Add(new Paragraph("\nGracias por su compra.", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 11)));

        doc.Close();

        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
        {
            FileName = ruta,
            UseShellExecute = true
        });
    }
}
