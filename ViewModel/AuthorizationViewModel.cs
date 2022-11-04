using EntityFramework_Exam.Model;
using EntityFramework_Exam.Service;
using EntityFramework_Exam.Service.Commands;
using EntityFramework_Exam.Service.Encryptor;
using EntityFramework_Exam.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EntityFramework_Exam.ViewModel
{
    public class AuthorizationViewModel
    {
        public AuthorizationViewModel()
        {
            CmdOpenRegistrationWindow = new Command(OpenRegistrationWindow);

            CmdAuthorization = new Command(Authorization, CanExecuteAuthorization);
        }

        //Command for Opening Registration Window
        public ICommand CmdOpenRegistrationWindow { get; }
        private void OpenRegistrationWindow(object? obj)
        {
            if (obj is Window sender)
            {
                sender.Hide();
                sender.IsEnabled = false;
                RegistrationWindow registrationWindow = new RegistrationWindow();

                registrationWindow.Closed += (a, b) => { sender.IsEnabled = true; sender.Show(); };
                registrationWindow.Show();
            }
        }


        //Command for Authorization ()
        public ICommand CmdAuthorization { get; }
        private void Authorization(object? obj)
        {
            if (obj is KeyValuePair<User,Window> pair)
            {
                User? AuthorizedUser = 
                    DbAccessor.GetUserByUsernameAndPassword(pair.Key.Username, pair.Key.Password);

                if (AuthorizedUser != null)
                {
                    MainViewModel.CurrentUserId = AuthorizedUser.Id;

                    pair.Value.Hide();
                    pair.Value.IsEnabled = false;
                    MainWindow mainWindow = new MainWindow();

                    mainWindow.Closed += (a, b) => { pair.Value.IsEnabled = true; pair.Value.Show(); };
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Username or/and Password is/are incorrect!", "Authorization error.", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private bool CanExecuteAuthorization(object? obj)
        {
            if (obj is KeyValuePair<User,Window> pair)
            {
                if (!string.IsNullOrEmpty(pair.Key.Username)
                    && !string.IsNullOrEmpty(pair.Key.Password))
                    return true;
            }
            return false;
        }
    }
}
