using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TablaPeriodicaApp1
{
    public partial class MasterDetailPage : Xamarin.Forms.MasterDetailPage
    {
        public MasterDetailPage()
        {
            InitializeComponent();
            MenuListView.ItemSelected += OnMenuItemSelected;
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as string;
            if (item == null)
                return;

            Page page = null;
            switch (item)
            {
                case "Inicio":
                    page = new MainPage();
                    break;
                case "Historia de la Tabla Periódica":
                    page = new HistoriaTablaPeriodica();
                    break;
                case "Quiz de Elementos":
                    page = new QuizPage(); 
                    break;
            }

            if (page != null)
            {
                Detail = new NavigationPage(page);
                IsPresented = false;
            }

            MenuListView.SelectedItem = null; 
        }
    }
}