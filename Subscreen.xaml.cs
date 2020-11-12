using iidx_ui_uwp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace iidx_ui_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Game> Games;

        public MainPage()
        {
            this.InitializeComponent();

            Games = Game.GetGames();
            MasterListView.ItemsSource = Games;
            MasterListView.SelectedIndex = 0;
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void OnItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
