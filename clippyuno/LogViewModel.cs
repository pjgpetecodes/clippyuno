using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace clippyuno
{
    public class LogViewModel : INotifyPropertyChanged
    {
        private string logMessage;

        public string LogMessage
        {
            get => logMessage;
            set
            {
                logMessage = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}