# Xamarin.Forms-MvvmLight

An Mvvm Light template for a Xamarin.Forms solution. The solution includes projects for Android, iOS and Windows Phone.

##### Roadmap:
* `ViewModelLocator` has to be a static resource for easy reference from XAML, as opposed to being a property on `ViewModelBaseExt`.
* There is no method/event for the application exit event. Separate subscription to events on each platform may be necessary.
* Test the WinPhone implementation
* Setup the iOS build and test it