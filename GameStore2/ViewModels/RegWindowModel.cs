using System;
using GameStore2.Commands;

namespace GameStore2.ViewModels
{
    class RegWindowModel
    {
        public event EventHandler EventCloseWindow;

        private BaseCommands changeToMainWindow;

        public BaseCommands ChangeToMainWindow
        {
            get
            {
                return changeToMainWindow??
                    (changeToMainWindow = new BaseCommands(obj =>
                    {
                        WindowsBuilder.ShowMainWindow();
                        CloseWindow();
                    }));
            }
        }

        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
