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
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace EntityFramework_Exam.ViewModel
{
    public class TradingViewModel : DependencyObject
    {
        static public int CurrentUserId;
        static public int UserToTradeId;

        public User CurrentUser { get; set; }
        public User UserToTrade { get; set; }


        private ObservableCollection<Item> CurrentUser_Items;
        public ICollectionView CurrentUser_ItemsCollectionView
        {
            get { return (ICollectionView)GetValue(CurrentUser_ItemsCollectionViewProperty); }
            set { SetValue(CurrentUser_ItemsCollectionViewProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ItemsCollectionView.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentUser_ItemsCollectionViewProperty =
            DependencyProperty.Register("CurrentUser_ItemsCollectionView", typeof(ICollectionView), typeof(TradingViewModel), new PropertyMetadata(null));


        private ObservableCollection<Item> UserToTrade_Items;
        public ICollectionView UserToTrade_ItemsCollectionView
        {
            get { return (ICollectionView)GetValue(UserToTrade_ItemsCollectionViewProperty); }
            set { SetValue(UserToTrade_ItemsCollectionViewProperty, value); }
        }
        // Using a DependencyProperty as the backing store for ItemsCollectionView.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserToTrade_ItemsCollectionViewProperty =
            DependencyProperty.Register("UserToTrade_ItemsCollectionView", typeof(ICollectionView), typeof(TradingViewModel), new PropertyMetadata(null));


        public ICommand TradingCmd { get; }
        private void Trading(object? obj)
        {
            //if (obj is KeyValuePair<ICollection<Item>, ICollection<Item>> pair)
            //{
                //Item item;

                foreach (Item item in CurrentUser_Items.ToList())
                {
                    if (item.IsChecked == true)
                    {
                        //item = dbContext.Items.Where(I => I.Id == itemCurrentUser.Id).Include(I => I.ItemType).First();
                        CurrentUser.Items.Remove(item);
                        //Updating CollectionView!
                        CurrentUser_Items.Remove(item);
                        /*======================================================*/
                        UserToTrade.Items.Add(item);
                        //Updating CollectionView!
                        UserToTrade_Items.Add(item);

                        item.IsChecked = false;
                    }
                }

                foreach (Item item in UserToTrade_Items.ToList())
                {
                    if (item.IsChecked == true)
                    {
                        //item = dbContext.Items.Where(I => I.Id == itemUserToTrade.Id).Include(I => I.ItemType).First();
                        UserToTrade.Items.Remove(item);
                        //Updating CollectionView!
                        UserToTrade_Items.Remove(item);
                        /*======================================================*/
                        CurrentUser.Items.Add(item);
                        //Updating CollectionView!
                        CurrentUser_Items.Add(item);

                        item.IsChecked = false;
                    }
                }

                DbAccessor.SaveChanges();
            //}
        }

        public TradingViewModel()
        {
            CurrentUser = DbAccessor.GetUserAndTownById(CurrentUserId)!;

            UserToTrade = DbAccessor.GetUserAndTownById(UserToTradeId)!;

            CurrentUser_Items = new ObservableCollection<Item>(DbAccessor.GetItemsByUserId(CurrentUser.Id));
            CurrentUser_ItemsCollectionView = CollectionViewSource.GetDefaultView(CurrentUser_Items);

            UserToTrade_Items = new ObservableCollection<Item>(DbAccessor.GetItemsByUserId(UserToTrade.Id));
            UserToTrade_ItemsCollectionView = CollectionViewSource.GetDefaultView(UserToTrade_Items);

            TradingCmd = new Command(Trading);
        }

    }
}
