using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinFormsRelativeSourceSample.DataTypes;

namespace XamarinFormsRelativeSourceSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; private set; }

        /// <summary>
        /// Item 削除コマンド。
        /// </summary>
        public Command<Item> DeleteItemCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "XamarinFormsRelativeSourceSample";

            Items = new ObservableCollection<Item>()
            {
                new Item() { Id = Guid.NewGuid().ToString(), Name = "Item1" },
                new Item() { Id = Guid.NewGuid().ToString(), Name = "Item2" },
                new Item() { Id = Guid.NewGuid().ToString(), Name = "Item3" },
                new Item() { Id = Guid.NewGuid().ToString(), Name = "Item4" },
                new Item() { Id = Guid.NewGuid().ToString(), Name = "Item5" },
            };

            DeleteItemCommand = new Command<Item>((item) => DeleteItemCommandExecute(item));
        }

        /// <summary>
        /// Item 削除処理。
        /// </summary>
        /// <param name="item">対象の Item。</param>
        private void DeleteItemCommandExecute(Item item)
        {
            Items.Remove(item);
        }
    }
}
