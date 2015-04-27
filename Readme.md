# Xamarin.Forms-MvvmLight

An Mvvm Light template for a Xamarin.Forms solution. The solution includes projects for Android, iOS and Windows Phone.

---

### Features usage:

In addition to the in-code examples and instructions, here are some examples:

* ##### ViewModelLoator:
   The `ViewModelLocator` is a static property in `App` and can be referred to in code as `App.Locator`.
   
   Being a static property, it can be referred to from XAML as follows:
   ```
   <Label Text="{Binding Main.AProperty, Source={x:Static local:App.Locator}}"/>
   ```
   `local` namespace has to be declared with the assembly reference as required by Xamarin:
   ```
   xmlns:local="clr-namespace:MvvmLightTemplate;assembly=MvvmLightTemplate"
   ```

---

### Roadmap:
* There is no method/event for the application exit event. Separate subscription to events on each platform may be necessary.
* Test the WinPhone implementation
* Setup the iOS build and test it