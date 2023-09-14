using ScientificArticleManagerWPF.Models;
using System;
using System.Globalization;
using System.Windows.Data;

namespace ScientificArticleManagerWPF.Converters
{
    internal class AuthorNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as ScientificArticleAuthorsList).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
