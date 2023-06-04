using System.Globalization;

namespace MauiValueConverter.Services;

public class ConverteDoubleToColor : IValueConverter
{
    Color color = new Color();
    public object Convert(object value, Type targetType, object parameter,
        CultureInfo culture)
    {
        double nota = (double)value;
        return nota < 6.9 ? Color.FromRgb(255, 0, 0) : Color.FromRgba(0, 38, 255, 255);
    }

    public object ConvertBack(object value, Type targetType, object parameter,
        CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
