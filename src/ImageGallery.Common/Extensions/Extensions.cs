using System;

namespace ImageGallery.Common.Extensions
{
    public static class Extensions
    {
        public static string Decode(this string encodedString)
        {
            var decodedBytes = Convert.FromBase64String(encodedString);
            return System.Text.Encoding.UTF8.GetString(decodedBytes);
        }

        public static string Encode(this string unencodedString)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(unencodedString);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
