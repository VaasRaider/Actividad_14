using SQLite;
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
    public partial class PageNuevo : ContentPage
    {
        public PageNuevo()
        {
            InitializeComponent();
        }

        private void Guardar(object sender, EventArgs e)
        {
            App.Persona nuevaPersona = new App.Persona() { Nombre = txtNombre.Text, Correo = txtCorreo.Text };
            //App.Personas.Add(nuevaPersona);
            using (var conn = new SQLiteConnection(App.RUTABD))
            {
                conn.Insert(nuevaPersona);
            }

                Navigation.PopAsync();
        }

        private void Cancelar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}