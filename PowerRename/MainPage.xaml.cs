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
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<ExplorerItem> ExplorerItems { get; set; }
        public ObservableCollection<RegExShortcut> RegExShortcuts { get; set; }

        public MainPage()
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

            RegExShortcuts = new ObservableCollection<RegExShortcut>
            {
                new RegExShortcut() { Code = "\\.", Description = "Matches any character" },
                new RegExShortcut() { Code = "\\d", Description = "Any digit, short for [0-9]" },
                new RegExShortcut() { Code = "\\D", Description = "A non-digit, short for [^0-9]" },
                new RegExShortcut() { Code = "\\w", Description = "A non-whitespace character, short for [^\\s]" },
                new RegExShortcut() { Code = "\\S", Description = "A word character, short for [a-zA-Z_0-9]" },
                new RegExShortcut() { Code = "\\S+", Description = "Several non-whitespace characters" },
                new RegExShortcut() { Code = "\\b", Description = "Matches a word boundary where a word character is [a-zA-Z0-9_]." },
            };
        }

     
    }
    public class RegExShortcut
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
