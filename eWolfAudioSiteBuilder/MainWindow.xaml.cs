using eWolfAudioSiteBuilder.Services;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Interfaces;
using System.Reflection;
using System.Windows;
using eWolfAudioSiteBuilder._SiteDetails;

namespace eWolfAudioSiteBuilder;

public partial class MainWindow : Window
{
    private readonly BuildSite _buildSite = new BuildSite();

    public MainWindow()
    {
        InitializeComponent();

        _buildSite.WebSiteRootAddress = @"E:\Projects\GitHub\eWolfSiteBuilder\DemoSiteAudio\";

        SiteBuilderServiceLocator.Instance.InjectService<IPageHeaderDetails>(new SiteHeader());
        SiteBuilderServiceLocator.Instance.InjectService<IBuildSite>(_buildSite);
        SiteBuilderServiceLocator.Instance.InjectService<INavigationBuilder>(new NavigationBuilder());

        SiteBuilderServiceLocator.Instance.InjectService<AudioShowServies>(new AudioShowServies());

        _buildSite.PreProcess(Assembly.GetExecutingAssembly());
        _buildSite.Create();
        _buildSite.OpenHomePage();

        Close();
    }
}