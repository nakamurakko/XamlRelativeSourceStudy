using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsRelativeSourceSample.DataTypes
{
    public class Item : BindableBase
    {
        private string _id;
        public string Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
    }
}
