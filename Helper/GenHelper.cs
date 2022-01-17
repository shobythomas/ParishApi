using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParishApi.Helper
{
    public static class GenHelper
    {

        public static string ToAmount(this double value, string NumberFormat = "N2")
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            return value.ToString(NumberFormat, nfi);
        }
        public static string ToUpperCase(this string value)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToUpper(value);
        }
        public static DateTime ToDateTime(string value)
        {
            DateTime time;

            time = DateTime.ParseExact(value, "dd/MM/yyyy", null);
            return time;
        }

        //public static DateTime ToDateWithOutYear(string value)
        //{

        //    DateTime selectedDate;
        //    selectedDate = DateTime.ParseExact(value, "dd/MMM", null);
        //    return selectedDate.Date;
        //}

        public static DateTime ToDate(string value)
        {

            DateTime selectedDate;
            selectedDate = DateTime.ParseExact(value, "dd/MM/yyyy", null);
            return selectedDate.Date;
        }
        public static string ReturnExtension(string fileExtension)
        {
            switch (fileExtension)
            {
                case ".htm":
                case ".html":
                case ".log":
                    return "text/HTML";
                case ".txt":
                    return "text/plain";
                case ".docx":
                    return "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                case ".doc":
                    return "application/msword";
                case ".tiff":
                case ".tif":
                    return "image/tiff";
                case ".asf":
                    return "video/x-ms-asf";
                case ".avi":
                    return "video/avi";
                case ".zip":
                    return "application/zip";
                case ".xls":
                case ".csv":
                    return "application/vnd.ms-excel";
                case ".gif":
                    return "image/gif";
                case ".jpg":
                case "jpeg":
                    return "image/jpeg";
                case ".bmp":
                    return "image/bmp";
                case ".wav":
                    return "audio/wav";
                case ".mp3":
                    return "audio/mpeg3";
                case ".mpg":
                case "mpeg":
                    return "video/mpeg";
                case ".rtf":
                    return "application/rtf";
                case ".asp":
                    return "text/asp";
                case ".pdf":
                    return "application/pdf";
                case ".fdf":
                    return "application/vnd.fdf";
                case ".ppt":
                    return "application/mspowerpoint";
                case ".dwg":
                    return "image/vnd.dwg";
                case ".msg":
                    return "application/msoutlook";
                case ".xml":
                case ".sdxl":
                    return "application/xml";
                case ".xdp":
                    return "application/vnd.adobe.xdp+xml";
                default:
                    return "application/octet-stream";
            }

        }
        //public static void WriteToFile(string text)
        //{
        //    if (!HttpContext.Current.IsDebuggingEnabled)
        //    {
        //        string path = System.Web.Configuration.WebConfigurationManager.AppSettings["DefaultPath"];
        //        if (path != string.Empty)
        //        {
        //            using (StreamWriter writer = new StreamWriter(path, true))
        //            {
        //                writer.WriteLine(string.Format(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt") + " - " + text));
        //                writer.Close();
        //            }
        //        }
        //    }
        //}
    }
}
