using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PowerRename
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage2 : Page
    {
        public ObservableCollection<ExplorerItem> ExplorerItems { get; set; }

        public MainPage2()
        {
            this.InitializeComponent();

            List<ExplorerItem> SubItems = new List<ExplorerItem>();
            SubItems.Add(new ExplorerItem()
            {
                Original = "Surface 15_wallpaper.jpg",
                Renamed = "15_wallpaper.jpg",
                Type = ExplorerItemType.File
            });
            SubItems.Add(new ExplorerItem()
            {
                Original = "Surface 16_wallpaper.jpg",
                Renamed = "16_wallpaper.jpg",
                Type = ExplorerItemType.File
            });

            ExplorerItems = new ObservableCollection<ExplorerItem>
            {
                new ExplorerItem() { Original = "Surface 1_wallpaper.jpg", Renamed = "1_wallpaper.jpg", Type = ExplorerItemType.Folder, Children = SubItems },
                new ExplorerItem() { Original = "Surface 2_wallpaper.jpg", Renamed = "2_wallpaper.jpg", Type = ExplorerItemType.File },
                new ExplorerItem() { Original = "Surface 3_wallpaper.jpg", Renamed = "3_wallpaper.jpg", Type = ExplorerItemType.File },
                new ExplorerItem() { Original = "Surface 4_wallpaper.jpg", Renamed = "4_wallpaper.jpg", Type = ExplorerItemType.Folder, Children = SubItems },
                new ExplorerItem() { Original = "Surface 5_wallpaper.jpg", Renamed = "5_wallpaper.jpg", Type = ExplorerItemType.File },
                new ExplorerItem() { Original = "Surface 6_wallpaper.jpg", Renamed = "6_wallpaper.jpg", Type = ExplorerItemType.Folder, Children = SubItems },
                new ExplorerItem() { Original = "Surface 7_wallpaper.jpg", Renamed = "7_wallpaper.jpg", Type = ExplorerItemType.File },
            };
        }

        
    }
}
