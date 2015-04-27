using GalaSoft.MvvmLight;

namespace MvvmLightTemplate.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public string TextFromBinding {
            get
            {
                return "Text from Binding";
            }
        }

        public string TextFromLocator
        {
            get
            {
                return "Text from Locator";
            }
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}
