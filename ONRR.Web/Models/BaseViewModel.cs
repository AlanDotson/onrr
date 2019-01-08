using System;
using System.ComponentModel;

namespace QEP.ONRR.Web.Models
{
    public abstract class BaseViewModel : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; }

        public void Dispose()
        {
        }
    }
}