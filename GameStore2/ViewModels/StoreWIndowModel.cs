using GameStore2.Commands;
using GameStore2.Views;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace GameStore2.ViewModels
{
    class StoreWindowModel : INotifyPropertyChanged
    {
        StoreWindow window = new StoreWindow();
        ProfileControl pc = new ProfileControl();

        private UserControl currentControl;
        public UserControl CurrentControl
        {
            get { return currentControl; }
            set
            {
                currentControl = value;
                OnPropertyChanged("CurrentControl");
            }
        }

        private BaseCommands changeToProfileControl;
        public BaseCommands ChangeToProfileControl
        {
            get
            {
                return changeToProfileControl ??
                    (changeToProfileControl = new BaseCommands(obj =>
                    {
                        WindowsBuilder.ShowProfileControl();
                        if (CurrentControl != null)
                            window.ContentGrid.Children.Remove(CurrentControl);
                        CurrentControl = pc;
                    }));
            }
        }

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
