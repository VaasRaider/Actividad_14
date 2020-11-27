using System;
using System.Collections.Generic;
using Xamarin.Forms;using System.Linq;
using Xamarin.Forms.Xaml;
using System.IO;
using SQLite;

namespace App10
{
    public partial class App : Application
    {
        static public List<Persona> Personas { get; set; }
        static public List<notes> notas { get; set; }
        static public string temp_nombre, temp_correo, RUTABD, temp2_Id;
        static public int temp_Id;
        public static bool press = false;


        public App()
        {
            InitializeComponent();
            Personas = new List<Persona>();
            notas = new List<notes>();
            MainPage = new NavigationPage(new MainPage());

        }

        public App( string ruta_bd )
        {
            InitializeComponent();
            Personas = new List<Persona>();
            notas = new List<notes>();
            RUTABD = ruta_bd;
            MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        public class Persona
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Correo { get; set; }
        }
        public class notes
        {
      
            public string _id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string user { get; set; }
            public string createdAt { get; set; }
            public string updateAt { get; set; }

        }
    }
}
