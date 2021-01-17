using HackatonCCR.Model;using HackatonCCR.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HackatonCCR.Service
{
    public class MenuItemService
    {
        private static ObservableCollection<MenuPageItem> menuLista;

        public static ObservableCollection<MenuPageItem> GetMenuItens()
        {
            menuLista = new ObservableCollection<MenuPageItem>();

            var pagina1 = new MenuPageItem()
            {
                Title = "Alunos",
                Icon = "AlunosIcon",
                TargetType = typeof(AlunosPage)
            };

            var pagina2 = new MenuPageItem()
            {
                Title = "Sei la",
                Icon = "AlunosIcon",
                TargetType = typeof(AlunosPage)
            };

            menuLista.Add(pagina1);
            menuLista.Add(pagina2);

            return menuLista;
        }

    }
}
