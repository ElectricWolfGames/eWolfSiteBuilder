using eWolfAudioSiteBuilder.Process;
using eWolfAudioSiteBuilder.Services;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Interfaces;
using System.Reflection;
using System.Windows;

namespace eWolfAudioSiteBuilder;

public partial class MainWindow : Window
{
    private readonly BuildSite _buildSite = new();

    public MainWindow()
    {
        InitializeComponent();

        _buildSite.WebSiteRootAddress = @"E:\eWolfSiteUploads\";

        SiteBuilderServiceLocator.Instance.InjectService<IPageHeaderDetails>(new SiteHeaderAudio());
        SiteBuilderServiceLocator.Instance.InjectService<IBuildSite>(_buildSite);
        SiteBuilderServiceLocator.Instance.InjectService<INavigationBuilder>(new NavigationBuilder());

        SiteBuilderServiceLocator.Instance.InjectService<AudioEpisodesShowServies>(new AudioEpisodesShowServies());

        _buildSite.PreProcess(Assembly.GetExecutingAssembly());

        OutputHelperText.OutputAudioEpisodesShow();

        _buildSite.Create();
        _buildSite.OpenHomePage();

        Close();
    }
}