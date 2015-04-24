using GalaSoft.MvvmLight;

namespace MvvmLightTemplate.ViewModels
{
    public abstract class ViewModelBaseExt : ViewModelBase
    {

        public ViewModelLocator Locator
        {
            get
            {
                return App.Locator;
            }
        }

    }
}
