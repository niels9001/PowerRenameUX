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
        public ObservableCollection<PatternSnippet> RegExShortcuts { get; set; }
        public ObservableCollection<PatternSnippet> DateTimeShortcuts { get; set; }

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

            RegExShortcuts = new ObservableCollection<PatternSnippet>
            {
                new PatternSnippet() { Code = "\\.", Description = "Matches any character" },
                new PatternSnippet() { Code = "\\d", Description = "Any digit, short for [0-9]" },
                new PatternSnippet() { Code = "\\D", Description = "A non-digit, short for [^0-9]" },
                new PatternSnippet() { Code = "\\w", Description = "A non-whitespace character, short for [^\\s]" },
                new PatternSnippet() { Code = "\\S", Description = "A word character, short for [a-zA-Z_0-9]" },
                new PatternSnippet() { Code = "\\S+", Description = "Several non-whitespace characters" },
                new PatternSnippet() { Code = "\\b", Description = "Matches a word boundary where a word character is [a-zA-Z0-9_]." },
            };

            DateTimeShortcuts = new ObservableCollection<PatternSnippet>
            {
                new PatternSnippet() { Code = "$YYYY", Description = "Year represented by a full four or five digits, depending on the calendar used" },
                new PatternSnippet() { Code = "$YY", Description = "Year represented only by the last two digits. A leading zero is added for single-digit years" },
                new PatternSnippet() { Code = "$Y", Description = "Year represented only by the last digit." },
                new PatternSnippet() { Code = "$MMMM", Description = "Name of the month" },
                new PatternSnippet() { Code = "$MMM", Description = "Abbreviated name of the month" },
                new PatternSnippet() { Code = "$MM", Description = "Month as digits with leading zeros for single-digit months" },
                new PatternSnippet() { Code = "$M", Description = "Month as digits without leading zeros for single-digit months" },
                new PatternSnippet() { Code = "$DDDD", Description = "Name of the day of the week" },
                new PatternSnippet() { Code = "$DDD", Description = "Abbreviated name of the day of the week" },
                new PatternSnippet() { Code = "$DD", Description = "Day of the month as digits with leading zeros for single-digit days" },
                new PatternSnippet() { Code = "$D", Description = "Day of the month as digits without leading zeros for single-digit days" },
                new PatternSnippet() { Code = "$hh", Description = "Hours with leading zeros for single-digit hours" },
                new PatternSnippet() { Code = "$h", Description = "Hours without leading zeros for single-digit hours" },
                new PatternSnippet() { Code = "$mm", Description = "Minutes with leading zeros for single-digit minutes" },
                new PatternSnippet() { Code = "$m", Description = "Minutes without leading zeros for single-digit minutes" },
                new PatternSnippet() { Code = "$ss", Description = "Seconds with leading zeros for single-digit seconds" },
                new PatternSnippet() { Code = "$s", Description = "Seconds without leading zeros for single-digit seconds" },
                new PatternSnippet() { Code = "$fff", Description = "Milliseconds represented by full three digits" },
                new PatternSnippet() { Code = "$ff", Description = "Milliseconds represented only by the first two digit" },
                new PatternSnippet() { Code = "$f", Description = "Milliseconds represented only by the first digit" },
            };
        }

        private void DateTime_ItemClick(object sender, ItemClickEventArgs e)
        {
            PatternSnippet s = e.ClickedItem as PatternSnippet;
            DateTimeFlyout.Hide();
            ReplaceForTxt.Text = ReplaceForTxt.Text + s.Code;

        }

        private void RegEx_ItemClick(object sender, ItemClickEventArgs e)
        {
            PatternSnippet s = e.ClickedItem as PatternSnippet;
            RegExFlyout.Hide();
            SearchForTxt.Text = SearchForTxt.Text + s.Code;
        }
    }
    public class PatternSnippet
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
