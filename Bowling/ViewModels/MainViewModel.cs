using Bowling.Services;
using GalaSoft.MvvmLight.Command;

namespace Bowling.ViewModels
{
    internal class MainViewModel
    {
        private bool disableRoll;
        private readonly IUiControlService service;
        public RelayCommand RollCommand { get; set; }

        public MainViewModel(IUiControlService service)
        {
            this.service = service;
            service.DisableRoll = DisableRoll;
            RollCommand = new RelayCommand(Roll, CanDisableRoll);
        }
        private void DisableRoll()
        {
            disableRoll = true;
            RollCommand.RaiseCanExecuteChanged();
        }
        private bool CanDisableRoll() => !disableRoll;
        private void Roll() => service.InvokeRollAction();
    }
}