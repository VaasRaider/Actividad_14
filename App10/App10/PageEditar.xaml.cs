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
    public partial class PageEditar : ContentPage
    {
        public PageEditar()
        {
            InitializeComponent();
        }

        private void Guardar(object sender, EventArgs e)
        {
            //App.Personas.RemoveAll(n => n.Nombre == App.temp_nombre);
            App.Persona nuevaPersona = new App.Persona() { Id= App.temp_Id, Nombre = txtNombre.Text, Correo = txtCorreo.Text };
            //App.Personas.Add(nuevaPersona);
            using (var conn = new SQLiteConnection(App.RUTABD))
            {
                if (nuevaPersona.Id > 0)
                {
                    conn.Update(nuevaPersona);
                }
                else 
                { conn.Insert(nuevaPersona); }
                    

            }
            Navigation.PopAsync();
        }

        private void Cancelar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}