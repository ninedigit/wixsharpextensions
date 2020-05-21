using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NineDigit.WixSharpExtensions.Mvvm
{
    public abstract class NotifyPropertyChangedObject : INotifyPropertyChanged, INotifyPropertyChanging
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        protected virtual bool SetValue<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            bool isChanged = !EqualityComparer<T>.Default.Equals(field, value);

            if (isChanged)
            {
                this.RaisePropertyChanging(propertyName);
                field = value;
                this.RaisePropertyChanged(propertyName);
            }

            return isChanged;
        }

        protected void RaisePropertiesChanging(params string[] propertyNames)
        {
            if (propertyNames is null)
                throw new ArgumentNullException(nameof(propertyNames));

            for (var i = 0; i < propertyNames.Length; i++)
                this.RaisePropertyChanging(propertyNames[i]);
        }

        protected virtual void RaisePropertyChanging([CallerMemberName] string propertyName = null)
        {
            this.OnPropertyChanging(this, propertyName);
            this.PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.OnPropertyChanged(this, propertyName);
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanging(object sender, string propertyName) { }
        protected virtual void OnPropertyChanged(object sender, string propertyName) { }
    }
}
