using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using WpfRelativeSourceSample.DataTypes;

namespace WpfRelativeSourceSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {

        public ObservableCollection<Item> Items { get; private set; }

        /// <summary>
        /// Item 削除コマンド。
        /// </summary>
        public DelegateCommand<Item> DeleteItemCommand { get; private set; }

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>()
            {
                new Item() { Id = Guid.NewGuid().ToString(), Name = "Item1" },
                new Item() { Id = Guid.NewGuid().ToString(), Name = "Item2" },
                new Item() { Id = Guid.NewGuid().ToString(), Name = "Item3" },
                new Item() { Id = Guid.NewGuid().ToString(), Name = "Item4" },
                new Item() { Id = Guid.NewGuid().ToString(), Name = "Item5" },
            };

            DeleteItemCommand = new DelegateCommand<Item>((item) => DeleteItemCommandExecute(item));
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
