using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PlutoFramework.Components.MessagePopup;
using PlutoFramework.Components.TransferView;
using PlutoFramework.Components.UniversalScannerView;
using PlutoFramework.Components.Vault;
using PlutoFramework.Model;
using Plutonication;

namespace PolkadotRoots.Pages
{
    public partial class CreateDAOPageViewModel : ObservableObject
    {

        [ObservableProperty]
        private bool isRefreshing = false;

        [RelayCommand]
        public async Task RefreshAsync()
        {
            IsRefreshing = true;

            _ = SubstrateClientModel.ChangeConnectedClientsAsync(EndpointsModel.GetSelectedEndpointKeys(), CancellationToken.None);

            await Task.Delay(5000);

            IsRefreshing = false;
        }

    }
}
