using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace MvvmLightTemplate.ViewModels
{
    public partial class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (!ViewModelBase.IsInDesignModeStatic)
                registerServices();
            else
                registerDesignServices();

            registerViewModels();
        }

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
            // TODO: MessagingCenter.Send<object>(null, MessengerMessages.FRAMEWORK_CLEANUP);
        }
    }
}
