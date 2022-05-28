using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameStore2.ViewModels
{
    class StoreWindowModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public event EventHandler EventCloseWindow;

        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
