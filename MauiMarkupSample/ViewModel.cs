using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace MauiMarkupSample
{
    public partial class ViewModel : ObservableObject
    {
        public ViewModel()
        {
            TestCommand = new RelayCommand(Test);
        }

        [ObservableProperty]
        private string _registrationCode;

        public ICommand TestCommand { get; private set; }

        private void Test()
        {
            string code = this.RegistrationCode;
        }
    }
}
