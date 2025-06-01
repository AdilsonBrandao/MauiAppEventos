using System.Globalization;

namespace MauiAppEventos.Converters
{
    public class DateAddDaysConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime date && parameter is string daysStr && int.TryParse(daysStr, out int days))
            {
                return date.AddDays(days);
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}