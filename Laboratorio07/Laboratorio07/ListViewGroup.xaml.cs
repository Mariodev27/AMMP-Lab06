using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio07
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<Tecsup> Tecsupx { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
            Tecsupx = new ObservableCollection<Tecsup>
        {
            new Tecsup("Sección A")
            {
                new Person { Title = "Emily", lastname = "Cooper", Age = "18", Code = "986422" },
                new Person { Title = "Gabriela", lastname = "Saravia", Age = "21", Code = "775432" },
                new Person { Title = "Bryan", lastname = "Delgadillo", Age = "22", Code = "287121" },
                new Person { Title = "Estefany", lastname = "Taipe", Age = "22", Code = "637890" },
            },
            new Tecsup("Sección B")
            {
                new Person { Title = "Carmen", lastname = "Rudas", Age = "23", Code = "478922" },
                new Person { Title = "Mario", lastname = "Santisteban", Age = "19", Code = "201534" },
                new Person { Title = "Eber", lastname = "Solano", Age = "17", Code = "945712" },
                new Person { Title = "Liam", lastname = "Trujillo", Age = "25", Code = "884567" },
            },
            new Tecsup("Sección C")
            {
                new Person { Title = "Bill", lastname = "Ortiz", Age = "20", Code = "112255" },
                new Person { Title = "Jose", lastname = "Roberto", Age = "24", Code = "516823" },
                new Person { Title = "Yadhira", lastname = "Choncen", Age = "21", Code = "245780" },
                new Person { Title = "Amelia", lastname = "Pari", Age = "21", Code = "134567" },
                new Person { Title = "Ariana", lastname = "Rosado", Age = "19", Code = "389752" },
            },
        };
            TecsupView.ItemsSource = Tecsupx;
        }
    }
}