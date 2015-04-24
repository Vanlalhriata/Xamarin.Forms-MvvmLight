namespace MvvmLightTemplate.ViewModels
{
    public class MainViewModel : ViewModelBaseExt
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
