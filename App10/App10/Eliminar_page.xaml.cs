using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Eliminar_page : ContentPage
    {

        public Eliminar_page()
        {
            InitializeComponent();


        }

        private void regresar(object sender, EventArgs e)
        {
            var persona = BindingContext as App.Persona;
            //App.Personas.Add(persona);
            Navigation.PopAsync();
            


        }
    }
}