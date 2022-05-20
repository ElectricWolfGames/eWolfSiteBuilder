using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Interfaces;
using System.Text;

namespace eWolfSiteBuilder.SiteDetails
{
    public class SiteHeader : IPageHeaderDetails
    {
        public string Output(PageDetails pageDetails)
        {
            StringBuilder _stringBuilder = new StringBuilder();

            var offSet = pageDetails.GetRooloffSet();
            _stringBuilder.Append("<!DOCTYPE html><html lang='en' >");
            _stringBuilder.Append("	<head>");
            _stringBuilder.Append("		<meta charset='UTF-8'>");
            _stringBuilder.Append($"		<title>{pageDetails.DisplayTitle}</title>");
            _stringBuilder.Append("		<meta http-equiv='Content -Type' content='text/html; charset=UTF-8'>");
            _stringBuilder.Append($"		<meta name='description' content='{pageDetails.DisplayTitle}'/>");
            _stringBuilder.Append("		<meta name='keywords' content=''/>");
            _stringBuilder.Append($"		<meta name='title' content='{pageDetails.DisplayTitle}'/>");
            _stringBuilder.Append("		<meta name='author' content='Electric Wolf'>");
            _stringBuilder.Append("		<meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>");
            _stringBuilder.Append($"		<link rel='stylesheet' href='{offSet}Scripts/style.css'>");
            _stringBuilder.Append("		<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
            _stringBuilder.Append("		<script src='https://code.jquery.com/jquery-3.3.1.slim.min.js' integrity='sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo' crossorigin='anonymous'></script>");
            _stringBuilder.Append("		<script src='https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js' integrity='sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1' crossorigin='anonymous'></script>");
            //Dont't need the charts _stringBuilder.Append($"		<script type='text/javascript' src='{offSet}Scripts/chart.js'></script>");
            _stringBuilder.Append("		<script src='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js' integrity='sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM' crossorigin='anonymous'></script>");
            _stringBuilder.Append("<!-- Global site tag (gtag.js) - Google Analytics -->");
            _stringBuilder.Append("<script async src='https://www.googletagmanager.com/gtag/js?id=UA-180928318-1'></script>");
            _stringBuilder.Append("<script>");
            _stringBuilder.Append("  window.dataLayer = window.dataLayer || [];  function gtag(){dataLayer.push(arguments);} gtag('js', new Date());  gtag('config', 'UA-180928318-1');");
            _stringBuilder.Append("</script></head>             ");

            return _stringBuilder.ToString();
        }
    }
}