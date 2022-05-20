using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Interfaces;
using eWolfSiteBuilder.SiteDetails;
using System.Reflection;
using System.Windows;

namespace eWolfSiteBuilder
{
    public partial class MainWindow : Window
    {
        private readonly BuildSite _buildSite = new BuildSite();

        public MainWindow()
        {
            InitializeComponent();

            _buildSite.WebSiteRootAddress = @"E:\Projects\ElectricWolfWebBuilder\eWolfSiteBuilder\DemoSite\";

            SiteBuilderServiceLocator.Instance.InjectService<IPageHeaderDetails>(new SiteHeader());
            SiteBuilderServiceLocator.Instance.InjectService<IBuildSite>(_buildSite);
            SiteBuilderServiceLocator.Instance.InjectService<INavigationBuilder>(new NavigationBuilder());

            _buildSite.PreProcess(Assembly.GetExecutingAssembly());
            _buildSite.Create();
            _buildSite.OpenHomePage();
            //BuildSite();
            Close();
        }
    }
}