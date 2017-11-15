using DemoLinQ.Code;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoLinQ.Views
    {/// <summary>
    /// Clase que servirá de demostracion de LinQ
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]

    
    public partial class MainView : ContentPage
    {
        /// <summary>
        /// Variable con los contenidos del XML que cargaremos.
        /// </summary>
        private List<Contacto> lista;
        /// <summary>
        /// Lista que servirá para filtrar para sacar solo un usuario.
        /// </summary>
        private List<Contacto> listaFiltro = new List<Contacto>();


        public MainView()
        {
            InitializeComponent();

            LeerXML();

        }
        /// <summary>
        /// Metodo para cargar el contenido del XML.
        /// </summary>
        private void LeerXML()
        {

            Stream stream = Leer.GenerateStreamFromString(Properties.Resources.Info);

            StreamReader objReader = new StreamReader(stream);

            var doc = XDocument.Load(stream);

            lista = new List<Contacto>();
            foreach (XElement element in doc.Root.Elements())
            {
                lista.Add(new Contacto(element.Element("NOMBRE").Value, element.Element("EDAD").Value, element.Element("DNI").Value));
            }
            // Despues de recoger el XML y guardarlo en una List lo mostraremos en el ListView creado.
            mostrarLista(lista);
        }
        /// <summary>
        /// Metodo para rellenar el ListView y mostrarlo al usuario.
        /// </summary>
        /// <param name="lista">ListView con el que rellenaremos el ListView.</param>
        private void mostrarLista(List<Contacto> lista)
        {
            // Pasamos al ListView la List.
            lstContactos.ItemsSource = lista;
        }

        /// <summary>
        /// Metodo para mostrar un solo usuario en el ListView.
        /// </summary>
        /// <param name="contacto">Le pasamos el contacto que mostraremos en la pantalla.</param>
        private void mostrarLista(Contacto contacto)
        {
            listaFiltro.Clear();

            listaFiltro.Add(contacto);

            // Pasamos al ListView la List.
            lstContactos.ItemsSource = listaFiltro;


        }
        /// <summary>
        /// Metodo para el Clicl del boton Where.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWhere_Clicked(object sender, EventArgs e)
        {
            if (controlarNombre())
            {
                var personasLista = lista.Where(p => p.Nombre.Contains(entryName.Text)).ToList();

                mostrarLista(personasLista);

            };
        }
        /// <summary>
        /// Metodo para el Clicl del boton FirstOrDefault.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFirst_Clicked(object sender, EventArgs e)
        {
            if (controlarEdad())
            {
                var personaFirstExiste = lista.FirstOrDefault(p => p.Edad == int.Parse(entryAge.Text));

                mostrarLista(personaFirstExiste);
            }

           
        }

        /// <summary>
        /// Metodo para el Clicl del boton SingleOrDefault.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSingle_Clicked(object sender, EventArgs e)
        {
            if (controlarEdad()&&controlarNombre())
            {
                var personaSODMúltiple = lista.Where(p => p.Nombre.Contains(entryName.Text));

                var listaFil = personaSODMúltiple.SingleOrDefault(p => p.Edad == int.Parse(entryAge.Text));

                mostrarLista(listaFil);
            }
            else
            {
                lblError.Text = "Introduce los parámetros correctamente.";
            }

        }

        /// <summary>
        /// Metodo para el Clicl del boton LastOrDefault.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLast_Clicked(object sender, EventArgs e)
        {
            if (controlarEdad())
            {
                var personaLODExiste = lista.LastOrDefault(p => p.Edad == int.Parse(entryAge.Text));
                mostrarLista(personaLODExiste); 
            }
        }

        /// <summary>
        /// Metodo para el Clicl del boton OrderByAscending.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrderAsc_Clicked(object sender, EventArgs e)
        {
            var listaAscendente = lista.OrderBy(p => p.Nombre).ToList();

            mostrarLista(listaAscendente);
        }

        /// <summary>
        /// Metodo para el Clicl del boton OrderByDescending.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrderDesc_Clicked(object sender, EventArgs e)
        {
            var listaDescendente = lista.OrderByDescending(p => p.Nombre).ToList();

            mostrarLista(listaDescendente);
        }

        /// <summary>
        /// Metodo para el Clicl del boton SkipWhile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSkip_Clicked(object sender, EventArgs e)
        {
            if (controlarEdad())
            {
                var listaSkipWhile = lista.SkipWhile(p => p.Edad >= int.Parse(entryAge.Text)).ToList();

                mostrarLista(listaSkipWhile); 
            }

        }

        /// <summary>
        /// Metodo para el Clicl del boton TakeWhile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTake_Clicked(object sender, EventArgs e)
        {
            if (controlarEdad())
            {
                var listaTakeWhile = lista.TakeWhile(p => p.Edad >= int.Parse(entryAge.Text)).ToList();

                mostrarLista(listaTakeWhile); 
            }
        }

        /// <summary>
        /// Metodo para restaurar la ListView con la lista del XML.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestaurar_Clicked(object sender, EventArgs e)
        {
            mostrarLista(lista);
        }
        /// <summary>
        /// Metodo para controlar que los parámetros introducidos para la edad son correctos.
        /// </summary>
        /// <returns>Devuelve true si la edad esta bien introducida y false si no.</returns>
        private Boolean controlarEdad()
        {
            int num;
            bool edad = false;

            //Controla que el entry para el nombre no este vacio.
            if (entryAge.Text != "" && entryName != null)
            {
                //Controla que ha introducido un numero para la edad y no ningun otro caracter.
                if (int.TryParse(entryAge.Text, out num))
                {
                    if (num>0) {
                        edad = true;
                    } else
                    {
                        edad = false;

                        lblError.Text = "Introduce un numero mayor a 0.";
                    }
                }
                else
                {
                    edad = false;

                    lblError.Text = "Introduce un número para la edad.";
                }
            }
            else
            {
                edad = false;

                lblError.Text = "Introduce un parámetro para la edad.";
            }

            return edad;
        }

        /// <summary>
        /// Metodo para controlar que los parámetros introducidos para la nombre son correctos.
        /// </summary>
        /// <returns>Devuelve true si la nombre esta bien introducida y false si no.</returns>
        private Boolean controlarNombre()
        {
            bool nombre = false;

            //Controla que el entry para el nombre no este vacio.
            if (entryName.Text != "" && entryName.Text != null)
            {
                nombre = true;
            }
            else
            {
                nombre = false;

                lblError.Text = "Introduce un parámetro para el nombre.";
            }

            return nombre;
        }
    }
}