using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
namespace XFormsDemo.DataAccess.Netflix.Common
{
    public class BaseClass : INotifyPropertyChanged
    {
        public BaseClass()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        protected void SetValue<T>(ref T attribute, T value, [CallerMemberName] string name = null)
        {
            if (EqualityComparer<T>.Default.Equals(attribute, value))
                return;
            attribute = value;
            OnPropertyChanged(name);
        }
    }
}
