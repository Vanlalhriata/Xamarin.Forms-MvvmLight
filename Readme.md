# Xamarin.Forms-MvvmLight

An Mvvm Light template for a Xamarin.Forms solution. The solution includes projects for Android, iOS and Windows Phone.

---

### Features usage:

* ##### Project template file for Visual Studio:
  If the project template file is all you need, the file is _XamarinFormsMvvmLight.zip_ in the root folder. The files may have to be extracted.
  
  There will be references to the old project name (MvvmLightTemplate) in the generated projects, most notably in _MainPage.xaml.cs_ in the WinPhone project. A quick fix for this is to replace the word _MvvmLightTemplate_ with your project name throughout the solution.

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
* The exported template still has references to the old project name.
* There is no method/event for the application exit event. Separate subscription to events on each platform may be necessary.
* Test the WinPhone implementation
* Setup the iOS build and test it