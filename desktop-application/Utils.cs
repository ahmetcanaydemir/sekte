using System;
using System.Drawing;
using System.IO;

namespace Sekte
{
    public static class Utils
    {
        public static Image Base64ToImage(string base64String)
        {
            base64String = base64String.Replace(@"\n", "").Replace(@"'", "").Substring(1);
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        public static void ResmiAc(string dosyaAdi, Image resim)
        {
            string path = Path.Combine(Path.GetTempPath(), dosyaAdi);
            resim.Save(path);
            System.Diagnostics.Process.Start(path);
        }

    }
}
