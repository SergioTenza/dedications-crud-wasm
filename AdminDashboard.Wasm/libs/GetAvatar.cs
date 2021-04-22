using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using System;
using System.IO;

namespace AdminDashboard.Wasm.libs
{
    public static class GetAvatar
    {
        public static Image LoadBase64(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.Load(ms);  
            }
            return image;
        }

        public static string ConvertBase64(Image _image)
        {
           
            // Convert byte[] to Base64 String
            string base64String;
            base64String = _image.ToBase64String(PngFormat.Instance);
            return base64String;
        }        
    }
}