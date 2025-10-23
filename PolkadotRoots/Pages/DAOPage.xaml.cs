using PlutoFramework;
using PlutoFramework.Components.NetworkSelect;
using PlutoFramework.Model;

namespace PolkadotRoots.Pages;

public partial class DAOPage : ContentPage
{
    public IList<IView> Views => StackLayout?.Children ?? [];
    public static VerticalStackLayout? StackLayout { get; set; }
	public DAOPage()
	{
        NavigationPage.SetHasNavigationBar(this, false);
        Shell.SetNavBarIsVisible(this, false);

        InitializeComponent();

		BindingContext = new DAOPageViewModel();

        StackLayout = stackLayout;

        _ = SubstrateClientModel.ChangeConnectedClientsAsync(EndpointsModel.GetSelectedEndpointKeys(), CancellationToken.None);
    }
}