using PlutoFramework.Components.WebView;

namespace PolkadotRoots.Components;

public partial class DAOButtonsView : ContentView
{
	public DAOButtonsView()
	{
		InitializeComponent();

        BindingContext = new DAOButtonsViewModel();
    }
}