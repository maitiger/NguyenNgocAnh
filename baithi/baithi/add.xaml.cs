using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace baithi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class add : Page
    {
        public add()
        {
            this.InitializeComponent();
        }


        //var picker = new FileOpenPicker();
        //picker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
        //    picker.FileTypeFilter.Add(".txt");
        //    Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
        //    if (file != null)
        //    {
        //        var json = await FileIO.ReadTextAsync(file);
        //var Us = JsonConvert.DeserializeObject<User>(json);
        //        this.name11.Text = Us.name;
        //        this.email11.Text = Us.email;
        //        this.phone11.Text = Us.phone;
        private void Add_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void View_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(add));
        }
    }

}
