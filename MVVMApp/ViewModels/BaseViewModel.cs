using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMApp.ViewModels
{
    public partial class BaseViewModel:ObservableObject
    {

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy;

        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private bool isEnable;

        public bool IsNotBusy => !IsBusy;
       
        

    }
}
