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
using baithi.Entity;
using Windows.Storage;
using Windows.Storage.Pickers;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace baithi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Save_click(object sender, RoutedEventArgs e)
        {
            file contentt = new file();
            contentt.content = this.Text.Text;

            Windows.Storage.StorageFolder storageFolder =
    Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile =
                await storageFolder.CreateFileAsync("filename",
                    Windows.Storage.CreationCollisionOption.ReplaceExisting);

            Windows.Storage.StorageFolder file =
    Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile storageFile =
                await storageFolder.GetFileAsync(this.filename.Text);
            var buffer = await Windows.Storage.FileIO.ReadBufferAsync(sampleFile);
            using (var dataReader = Windows.Storage.Streams.DataReader.FromBuffer(buffer))
            {
                string text = dataReader.ReadString(buffer.Length);
            }

            //var savePicker = new FileSavePicker();
            //savePicker.SuggestedStartLocation =
            //Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            //// Dropdown of file types the user can save the file as
            //savePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".txt" });
            //// Default file name if the user does not type one in or select a file to replace
            //savePicker.SuggestedFileName = "New File";

            //Windows.Storage.StorageFile file = await savePicker.PickSaveFileAsync();
            //if (file != null)
            //{

            //    Windows.Storage.CachedFileManager.DeferUpdates(file);

            //    await Windows.Storage.FileIO.WriteTextAsync(contentt, "filename");

            //    Windows.Storage.Provider.FileUpdateStatus status =
            //        await CachedFileManager.CompleteUpdatesAsync(file);

            //}

        }

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
