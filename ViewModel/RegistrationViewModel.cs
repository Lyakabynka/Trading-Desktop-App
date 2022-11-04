using EntityFramework_Exam.Model;
using EntityFramework_Exam.Service;
using EntityFramework_Exam.Service.Commands;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace EntityFramework_Exam.ViewModel
{
    public class RegistrationViewModel : DependencyObject
    {
        //For ability to list in ComboBox
        private ObservableCollection<Town> Towns;
        public ICollectionView TownsCollectionView
        {
            get { return (ICollectionView)GetValue(TownsCollectionViewProperty); }
            set { SetValue(TownsCollectionViewProperty, value); }
        }
        // Using a DependencyProperty as the backing store for TownsCollectionView.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TownsCollectionViewProperty =
            DependencyProperty.Register("TownsCollectionView", typeof(ICollectionView), typeof(RegistrationViewModel), new PropertyMetadata(null));


        //Register User ( add to database )
        public ICommand CmdRegistration { get; }
        private void Registration(object? obj)
        {
            if (obj is KeyValuePair<User,Window> pair)
            {
                DbAccessor.AddUser(pair.Key);
                DbAccessor.SaveChanges();

                pair.Value.Close();
            }
        }
        private bool CanExecuteRegistration(object? obj)
        {
            if (obj is KeyValuePair<User,Window> pair)
            {
                if (!DbAccessor.ExistsUser(pair.Key.Username) &&
                    pair.Key.Username != string.Empty &&
                    pair.Key.Password != string.Empty &&
                    pair.Key.Town != null)
                    return true;
            }
            return false;
        }


        public RegistrationViewModel()
        {
            CmdRegistration = new Command(Registration, CanExecuteRegistration);


            Towns = new ObservableCollection<Town>(DbAccessor.GetAllTowns());
            TownsCollectionView = CollectionViewSource.GetDefaultView(Towns);
        }
    }
}
