using EntityFramework_Exam.Model;
using EntityFramework_Exam.Service.Encryptor;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace EntityFramework_Exam.Service.Converters
{
    public class UserRegistrationConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values != null)
            {
                return new KeyValuePair<User,Window>(
                    new User((string)values[0], Encryptor.Encryptor.ToSha256((string)values[1]), (Town)values[2]),
                    (Window)values[3]);
            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            if (value is User user)
            {
                return new object[] { user.Id, user.Username, user.Password, user.Town, user.SaleTrades, user.PurschaseTrades, user.Properties, user.Items };
            }
            return null;
        }
    }
}
