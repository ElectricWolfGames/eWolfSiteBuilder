namespace eWolfSiteBuilder.SiteDetails
{
    public interface IHomePagePreview
    {
        PreviewItem GetHomePagePreview();
    }

    public interface IUnityList
    {
        int UnityListOrder { get; set; }

        PreviewItem GetHomePagePreview();
    }
}