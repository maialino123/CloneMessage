using CloneMessage.Model;
using CloneMessage.Services;
using CloneMessage.Services.IService;
using FreshMvvm;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("materialdesignicons-webfont.ttf", Alias = "materialFont")]
namespace CloneMessage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            FreshIOC.Container.Register<IDataService<CouponModel>, CouponService>();

            var page = FreshPageModelResolver.ResolvePageModel<FrameTestPageModel>();
            var basicNavContainer = new FreshNavigationContainer(page);
            MainPage = basicNavContainer;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
