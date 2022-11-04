using EntityFramework_Exam.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace EntityFramework_Exam.Service.Converters
{
    public class UserMainConverter : IMultiValueConverter
    {
        object IMultiValueConverter.Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new KeyValuePair<User, Window>((User)values[0], (Window)values[1]);
        }

        object[] IMultiValueConverter.ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            if (value is User user)
            {
                return new object[] { user.Id, user.Username, user.Password, user.Town, user.SaleTrades, user.PurschaseTrades, user.Properties, user.Items };
            }
            return null;
        }
    }
}
