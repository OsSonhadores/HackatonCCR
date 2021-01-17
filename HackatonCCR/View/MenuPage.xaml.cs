using HackatonCCR.Model;
using HackatonCCR.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackatonCCR.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : MasterDetailPage
    {
        private ObservableCollection<MenuPageItem> _menuLista;

        public MenuPage()
        {
            InitializeComponent();

            _menuLista = MenuItemService.GetMenuItens();
            lstMenuNavegacao.ItemsSource = _menuLista;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(AlunosPage)));
        }

        private void lstMenuNavegacao_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MenuPageItem)e.SelectedItem;
            Type pagina = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
            IsPresented = false;
        }


    }
}