using Avalonia.Controls;
using Avalonia.ReactiveUI;
using FoguelMusicStore.ViewModels;
using ReactiveUI;
using System;

namespace FoguelMusicStore.Views
{
    public partial class MusicStoreWindow : ReactiveWindow<MusicStoreViewModel>
    {
        public MusicStoreWindow()
        {
            InitializeComponent();
            this.WhenActivated(d => d(ViewModel!.BuyMusicCommand.Subscribe(Close)));
        }
    }
}
