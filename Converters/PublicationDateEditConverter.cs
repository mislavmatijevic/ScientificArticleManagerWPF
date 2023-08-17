using System;
using System.Globalization;
using System.Windows.Data;

namespace ScientificArticleManagerWPF.Converters
{
    internal class PublicationDateEditConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime date = (DateTime)value;
            return date.ToString("dd. MM. yyyy.");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime date = DateTime.Parse((string)value);
            return date;
        }
    }
}
