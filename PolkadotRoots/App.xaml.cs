﻿using PlutoFramework.Components.Account;
using PlutoFramework.Components.Password;
using PlutoFramework.Model;
using PolkadotRoots.Components.BottomNavBar;

namespace PolkadotRoots
{
    public partial class App : Application
    {
        public static Task NewMainPageNavigationAsync()
        {
            App.Current.MainPage = new AppShell();
            return Task.FromResult(0);
        }

        public static async Task GenerateNewAccountAsync()
        {
            await KeysModel.GenerateNewAccountAsync();

            App.Current.MainPage = new AppShell();
        }

        public App()
        {
            var noAccountViewModel = DependencyService.Get<NoAccountPopupViewModel>();
            noAccountViewModel.AfterCreateAccountNavigation = NewMainPageNavigationAsync;

            InitializeComponent();


            DependencyService.Register<BottomNavBarViewModel>();


            if (!KeysModel.HasSubstrateKey())
            {
                MainPage = new OnboardingShell();
            }
            else
            {
                MainPage = new AppShell();
            }
        }
    }
}