using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PlutoFramework.Components.WebView;
using PlutoFramework.Model;
using Substrate.NetApi;
using PolkadotRoots.Pages;

namespace PolkadotRoots.Components
{
    public partial class DAOButtonsViewModel : ObservableObject
    {
        [RelayCommand]
        public Task CreateDAOButtonPressedCommand() => Shell.Current.Navigation.PushAsync(new CreateDAOPage());

        [RelayCommand]
        public Task JoinDAOButtonPressedCommand() => Shell.Current.Navigation.PushAsync(new CreateDAOPage());
    }
}
