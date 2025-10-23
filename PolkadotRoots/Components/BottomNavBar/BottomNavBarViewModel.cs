using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PolkadotRoots.Components.BottomNavBar
{

    public partial class BottomNavBarViewModel : ObservableObject
    {
        public enum NavBarSelection
        {
            Assets,
            Nfts,
            DAO
        }

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(AssetsIsSelected))]
        [NotifyPropertyChangedFor(nameof(NftsIsSelected))]
        [NotifyPropertyChangedFor(nameof(DAOIsSelected))]
        private NavBarSelection selected = NavBarSelection.Nfts;

        public bool AssetsIsSelected => Selected == NavBarSelection.Assets;

        public bool NftsIsSelected => Selected == NavBarSelection.Nfts;

        public bool DAOIsSelected => Selected == NavBarSelection.DAO;

        [RelayCommand]
        public async Task SelectAssetsAsync()
        {
            if (AssetsIsSelected)
            {
                return;
            }

            Selected = NavBarSelection.Assets;

            await Shell.Current.GoToAsync("//Assets", animate: false);
        }

        [RelayCommand]
        public async Task SelectNftsAsync()
        {
            if (NftsIsSelected)
            {
                return;
            }

            Selected = NavBarSelection.Nfts;

            await Shell.Current.GoToAsync("//MainPage", animate: false);
        }

        [RelayCommand]
        public async Task SelectDAOAsync()
        {
            if (DAOIsSelected)
            {
                return;
            }

            Selected = NavBarSelection.DAO;

            await Shell.Current.GoToAsync("//DAOPage", animate: false);
        }
    }
}
