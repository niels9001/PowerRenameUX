using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace PowerRename
{
    public class ExplorerItem
    {
        public ExplorerItemType Type { get; set; }
        public string Original { get; set; }
        public string Renamed { get; set; }
        public List<ExplorerItem> Children { get; set; }
    }

    public enum ExplorerItemType
    {
        Folder = 0,
        File = 1
    }

    public class ExplorerItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FileTemplate
        {
            get;
            set;
        }

        public DataTemplate FolderTemplate
        {
            get;
            set;
        }


        protected override DataTemplate SelectTemplateCore(object item)
        {
            ExplorerItem SelectedItem = item as ExplorerItem;

            if (SelectedItem.Type == ExplorerItemType.File)
            {
                return this.FileTemplate;
            }
            else
            {
                return this.FolderTemplate;
            }
        }
    }

    public sealed class GridLengthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            double val = (double)value;
            GridLength gridLength = new GridLength(val, GridUnitType.Pixel);
            return gridLength;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            GridLength val = (GridLength)value;

            return val.Value;
        }
    }
}
