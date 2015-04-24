using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Xamarin.Forms;

namespace MvvmLightTemplate.ViewModels
{
    public partial class ViewModelLocator
    {

        private static void registerDesignServices()
        {
            // Register design time services here. Example:
            // SimpleIoc.Default.Register<IDataService, Design.DesignDataService>();
        }

        private static void registerServices()
        {
            // Register services here. Example:
            // SimpleIoc.Default.Register<IDataService, DataService>();

            // For platform specific services registered on Xamarin's DependecyService
            // IDataService dataService = DependencyService.Get<IDataService>();
            // SimpleIoc.Default.Register<IDataService>(() => dataService);
        }

        private static void registerViewModels()
        {
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

    }
}
