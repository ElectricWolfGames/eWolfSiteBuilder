using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Interfaces;
using System.Text;

namespace eWolfAudioSiteBuilder.Services;

public class SiteHeaderAudio : IPageHeaderDetails
{
    public string Output(PageDetails pageDetails, string extraOffSet)
    {
        StringBuilder _stringBuilder = new();

        var offSet = pageDetails.GetRooloffSet();
        _stringBuilder.AppendLine("<!DOCTYPE html><html lang='en' >");
        _stringBuilder.AppendLine("	<head>");
        AddSiteTracker(_stringBuilder);
        _stringBuilder.AppendLine("		<meta charset='UTF-8'>");
        _stringBuilder.AppendLine($"		<title>{pageDetails.DisplayTitle}</title>");

        _stringBuilder.AppendLine("		<meta http-equiv='Content -Type' content='text/html; charset=UTF-8'>");
        _stringBuilder.AppendLine($"		<meta name='description' content='{pageDetails.MetaDescription}'/>");
        _stringBuilder.AppendLine($"		<meta name='keywords' content='{string.Join(",", pageDetails.Keywords)}'/>");
        _stringBuilder.AppendLine($"		<meta name='title' content='{pageDetails.DisplayTitle}'/>");

        _stringBuilder.AppendLine("		<meta name='author' content='Electric Wolf'>");
        _stringBuilder.AppendLine("		<meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>");
        _stringBuilder.AppendLine($"		<link rel='stylesheet' href='{offSet}Scripts/style.css'>");
        _stringBuilder.AppendLine("<link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css'>");
        _stringBuilder.AppendLine("<script src='https://cdn.jsdelivr.net/npm/jquery@3.6.4/dist/jquery.slim.min.js'></script>");
        _stringBuilder.AppendLine("<script src='https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js'></script>");
        _stringBuilder.AppendLine("<script src='https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js'></script>");
        _stringBuilder.AppendLine("</head>");

        return _stringBuilder.ToString();
    }

    private static void AddSiteTracker(StringBuilder sb)
    {
        sb.Append(@"<!-- Google tag (gtag.js) -->
<script async src=""https://www.googletagmanager.com/gtag/js?id=G-SJNLQ51KZ5""></script>
<script>
  window.dataLayer = window.dataLayer || [];
  function gtag(){dataLayer.push(arguments);}
  gtag('js', new Date());

  gtag('config', 'G-SJNLQ51KZ5');
</script>");

        // Add the Ad Scene
        sb.Append("<script async src=\"https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js?client=ca-pub-5100298817928604\"\r\n     crossorigin=\"anonymous\"></script>");
    }
}