using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QRCoder;

namespace QRandBarCode_Project
{
    public partial class BarandQRCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Image1.ImageUrl = "https://barcode.tec-it.com/barcode.ashx?data=" + TextBox1.Text + "&code=Code128&translate-es=om";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string gerenatedbarcode = TextBox1.Text;
            System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
            imgBarCode.Height = 150;
            imgBarCode.Width = 150;
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(gerenatedbarcode, QRCodeGenerator.ECCLevel.Q))
            using (PngByteQRCode qrCode = new PngByteQRCode(qrCodeData))
            {
                byte[] qrCodeImage = qrCode.GetGraphic(20);

                imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(qrCodeImage);
            }
            PlaceHolder1.Controls.Add(imgBarCode);
            Literal1.Text = TextBox1.Text;
        }
    }
}