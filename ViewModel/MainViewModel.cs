using EntityFramework_Exam.Model;
using EntityFramework_Exam.Model.Types;
using EntityFramework_Exam.Service;
using EntityFramework_Exam.Service.Commands;
using EntityFramework_Exam.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace EntityFramework_Exam.ViewModel
{
    public class MainViewModel : DependencyObject
    {
        public static int CurrentUserId { get; set; }



        public User CurrentUser { get; set; }


        private ObservableCollection<Item> CurrentUser_Items;
        public ICollectionView CurrentUser_ItemsCollectionView
        {
            get { return (ICollectionView)GetValue(ItemsCollectionViewProperty); }
            set { SetValue(ItemsCollectionViewProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ItemsCollectionView.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsCollectionViewProperty =
            DependencyProperty.Register("ItemsCollectionView", typeof(ICollectionView), typeof(MainViewModel), new PropertyMetadata(null));


        private ObservableCollection<User> CurrentUser_UsersInTown;
        public ICollectionView CurrentUser_UsersInTownCollectionView
        {
            get { return (ICollectionView)GetValue(CurrentUser_UsersInTownCollectionViewProperty); }
            set { SetValue(CurrentUser_UsersInTownCollectionViewProperty, value); }
        }
        // Using a DependencyProperty as the backing store for CurrentUser_UsersInTownCollectionView.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentUser_UsersInTownCollectionViewProperty =
            DependencyProperty.Register("CurrentUser_UsersInTownCollectionView", typeof(ICollectionView), typeof(MainViewModel), new PropertyMetadata(null));


        private ObservableCollection<Property> CurrentUser_Properties;
        public ICollectionView CurrentUser_PropertiesCollectionView
        {
            get { return (ICollectionView)GetValue(CurrentUser_PropertiesCollectionViewProperty); }
            set { SetValue(CurrentUser_PropertiesCollectionViewProperty, value); }
        }
        // Using a DependencyProperty as the backing store for CurrentUser_UsersInTownCollectionView.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentUser_PropertiesCollectionViewProperty =
            DependencyProperty.Register("CurrentUser_PropertiesCollectionView", typeof(ICollectionView), typeof(MainViewModel), new PropertyMetadata(null));


        public ICommand TradeWithUserCmd { get; }
        private void TradeWithUser(object? obj)
        {
            if (obj is KeyValuePair<User,Window> pair)
            {
                TradingViewModel.CurrentUserId = CurrentUser.Id;
                TradingViewModel.UserToTradeId = pair.Key.Id;

                pair.Value.Hide();
                pair.Value.IsEnabled = false;
                TradingWindow tradingWindow = new TradingWindow();

                tradingWindow.Closed += (a, b) => { 
                    pair.Value.IsEnabled = true; 
                    pair.Value.Show();

                    CurrentUser_Items.Clear();
                    foreach (var item in DbAccessor.GetItemsByUserId(CurrentUser.Id))
                    {
                        CurrentUser_Items.Add(item);
                    }
                };
                tradingWindow.Show();
            }
        }
        

        public MainViewModel()  
        {

            //Current User Contains only basic info about current user. (Username, Password, TownId and Town)
            CurrentUser = DbAccessor.GetUserAndTownById(CurrentUserId)!;

            CurrentUser_Items = new ObservableCollection<Item>(
                DbAccessor.GetItemsByUserId(CurrentUser.Id)
                );
            CurrentUser_ItemsCollectionView = CollectionViewSource.GetDefaultView(CurrentUser_Items);


            CurrentUser_UsersInTown = new ObservableCollection<User>(DbAccessor.GetAllUsersInUsersTown(CurrentUser));
            CurrentUser_UsersInTownCollectionView = CollectionViewSource.GetDefaultView(CurrentUser_UsersInTown);

            CurrentUser_Properties = new ObservableCollection<Property>(
                DbAccessor.GetPropertiesByUserId(CurrentUser.Id)
                );
            CurrentUser_PropertiesCollectionView = CollectionViewSource.GetDefaultView(CurrentUser_Properties);


            TradeWithUserCmd = new Command(TradeWithUser);
        }

    }
}
