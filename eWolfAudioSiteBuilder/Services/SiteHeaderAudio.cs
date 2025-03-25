using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Interfaces;
using System.Text;

namespace eWolfAudioSiteBuilder.Services
{
    public class SiteHeaderAudio : IPageHeaderDetails
    {
        public string Output(PageDetails pageDetails, string extraOffSet)
        {
            StringBuilder _stringBuilder = new StringBuilder();

            var offSet = pageDetails.GetRooloffSet();
            _stringBuilder.Append("<!DOCTYPE html><html lang='en' >");
            _stringBuilder.Append("	<head>");
            AddSiteTracker(_stringBuilder);
            _stringBuilder.Append("		<meta charset='UTF-8'>");
            _stringBuilder.Append($"		<title>{pageDetails.DisplayTitle}</title>");
            _stringBuilder.Append("		<meta http-equiv='Content -Type' content='text/html; charset=UTF-8'>");
            _stringBuilder.Append($"		<meta name='description' content='{pageDetails.DisplayTitle}'/>");
            _stringBuilder.Append($"		<meta name='keywords' content='{string.Join(",", pageDetails.Keywords)}'/>");
            _stringBuilder.Append($"		<meta name='title' content='{pageDetails.DisplayTitle}'/>");
            _stringBuilder.Append("		<meta name='author' content='Electric Wolf'>");
            _stringBuilder.Append("		<meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>");
            _stringBuilder.Append($"		<link rel='stylesheet' href='{offSet}Scripts/style.css'>");
            _stringBuilder.Append("<link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css'>");
            _stringBuilder.Append("<script src='https://cdn.jsdelivr.net/npm/jquery@3.6.4/dist/jquery.slim.min.js'></script>");
            _stringBuilder.Append("<script src='https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js'></script>");
            _stringBuilder.Append("<script src='https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js'></script>");
            _stringBuilder.Append("</head>");

            return _stringBuilder.ToString();
        }

        private static void AddSiteTracker(StringBuilder sb)
        {
            sb.Append("<!-- Google tag (gtag.js) -->" +
                "<script async src=\"https://www.googletagmanager.com/gtag/js?id=G-SJNLQ51KZ5\"></script>" +
                "<script>" +
                "  window.dataLayer = window.dataLayer || [];" +
                "  function gtag(){dataLayer.push(arguments);}" +
                "  gtag('js', new Date());" +
                "  gtag('config', 'G-SJNLQ51KZ5');" +
                "</script>");
        }
    }
}