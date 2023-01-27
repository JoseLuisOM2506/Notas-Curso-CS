/*----------------------------------------------------- Controles-------------------------------------------------------------
 * 
 * 
 * ---------- ListBox
 * 
 * Es una lista de elementos(valores de cualquier tipo de dato u objetos) que se colocan uno debajo de otro, además es posible 
 * seleccionar un elemento de la listbox y desencadenar algún evento como si se tratase de un botón. Usando las propiedades 
 * de las ListBox, se puede modificar la plantilla para darle diferentes formas a la lista, como agregar un grid que divida
 * la lista en columnas.
 * 
 * ---------- ComboBox
 * 
 * Se trata de una casilla inicia que despliega un menú al darle un click inicial a este control, el formato de este menú es como 
 * el de una lista y al seleccionar un elemento de esta lista se mostrara en la casilla inicial el elemento que se seleccionó. 
 * Al igual que las listbox, es posible modificar la plantilla de este control para darle diferente formato.
 * 
 * ---------- CheckBox
 * 
 * Son casillas de verificación que inicialmente están desactivadas, pero al darles clicks, estas pueden tener dos o tres estados 
 * diferentes: Activado, desactivado (nuevamente) o el estado neutro (si es que se habilita). Para cada estado del checkbox es
 * posible desencadenar un evento.
 * 
 * ----------- RadioButton
 * 
 * Son casillas circulares que mantienen un estado de activado o desactivado (inicial). Una característica interesante de estos
 * controles es que trabajan en conjunto con otros radiobutton que se encuentran en el mismo contenedor, de modo que al activar un
 * radiobutton, los demás se desactivan. Para cada estado del radiobutton es posible desencadenar un evento.
 * 
 * ---------- Agregar imágenes a la aplicación de escritorio WPF.
 * 
 * Para agregar una imagen a la aplicación de escritorio WPF primero es necesario agregar una carpeta con el nombre "imágenes" al 
 * proyecto y después agregar la imagen como "elemento existente", todo desde Visual Studio.
 * 
 * Una vez agregada la imagen al proyecto, se debe utilizar la siguiente sentencia desde XAML para agregar la imagen a la 
 * aplicación de escritorio:
 * 
 *          <Image Source="Imágenes/Semaforo.png"></Image>
 *          
 * Nota. Es posible agregar la imagen a la aplicación desde el código C# y mediante el uso de la vista de diseño.
 *          
 * ---------- Agregar figuras a la aplicación de escritorio
 * 
 * Es posible agregar figuras y dibujos que tienen por defecto las aplicaciones de escritorio WPF desde la vista XAML. Como por
 * ejemplo: elipses, rectángulos ,etc.
 * 
 * Nota. Es posible agregar una figura a la aplicación desde el código C# y mediante el uso de la vista de diseño.
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp_Controles
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Ejemplo para el uso de listbox
            List<Lugares> lugares = new List<Lugares>(); //Se crea una lista donde se almacenan los objetos

            //Las siguientes sentencias agregan 4 objetos a la lista
            lugares.Add(new Lugares() { Poblacion1 = "New York", Temperatura1 = 17, Poblacion2 = "Otawa", Temperatura2 = 5 });
            lugares.Add(new Lugares() { Poblacion1 = "Madrid", Temperatura1 = 20, Poblacion2 = "Yucatan", Temperatura2 = 35 });
            lugares.Add(new Lugares() { Poblacion1 = "Roma", Temperatura1 = 15, Poblacion2 = "Paris", Temperatura2 = 7 });
            lugares.Add(new Lugares() { Poblacion1 = "Tokio", Temperatura1 = 20, Poblacion2 = "Sinaloa", Temperatura2 = 40 });

            listaLugares.ItemsSource = lugares;            //Al haber agregado un nombre a la listbox, se puede usar para asignarle una lista como origen de datos.

            //Ejemplo para el uso de comboBox
            menuLugares.ItemsSource = lugares;          //Se asigna un origen de datos al comboBox

            //Ejemplo para el uso de checkBox;
            //Se agrega el contenido a cada uno de los checkbox
            check1.Content = lugares[0].Poblacion2;
            check2.Content = lugares[1].Poblacion2;
            check3.Content = lugares[2].Poblacion2;
            check4.Content = lugares[3].Poblacion2;

        }

        //Controladores de eventos
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listaLugares.SelectedItem != null)
                MessageBox.Show($"Lugar 1: {(listaLugares.SelectedItem as Lugares).Poblacion1} {(listaLugares.SelectedItem as Lugares).Temperatura1} °C  " +
                $" Lugar 2:  {(listaLugares.SelectedItem as Lugares).Poblacion2} {(listaLugares.SelectedItem as Lugares).Temperatura2} °C");
            else
                MessageBox.Show("Selecciona un elemento de la listbox");
        }

        private void ProgressBar_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaLugares.SelectedItem != null)
                MessageBox.Show($"Diferencia de temperatura: {(listaLugares.SelectedItem as Lugares).DiferenciaTemp} °C");
            else
                MessageBox.Show("Selecciona un elemento de la listbox");
        }

        private void TodosCheck_Checked(object sender, RoutedEventArgs e)
        {
            check1.IsChecked = check2.IsChecked = check3.IsChecked = check4.IsChecked = true;
        }

        private void TodosCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            check1.IsChecked = check2.IsChecked = check3.IsChecked = check4.IsChecked = false;
        }

        private void individual_Checked(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == true && check2.IsChecked == true && check3.IsChecked == true && check4.IsChecked == true)
            {
                TodosCheck.IsChecked = true;
            }
            else TodosCheck.IsChecked = null;
        }

        private void individual_Unchecked(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == false && check2.IsChecked == false && check3.IsChecked == false && check4.IsChecked == false)
            {
                TodosCheck.IsChecked = false;
            }
            else TodosCheck.IsChecked = null;
        }

        private void Rojo_Checked(object sender, RoutedEventArgs e)
        {
            eRojo.Visibility = Visibility.Visible;
            eAmarillo.Visibility = Visibility.Hidden;
            eVerde.Visibility = Visibility.Hidden;
        }

        private void Amarillo_Checked(object sender, RoutedEventArgs e)
        {
            eRojo.Visibility = Visibility.Hidden;
            eAmarillo.Visibility = Visibility.Visible;
            eVerde.Visibility = Visibility.Hidden;
        }

        private void Verde_Checked(object sender, RoutedEventArgs e)
        {
            eRojo.Visibility = Visibility.Hidden;
            eAmarillo.Visibility = Visibility.Hidden;
            eVerde.Visibility = Visibility.Visible;
        }
    }

    //Clase para crear objetos de ejemplo
    class Lugares
    {
        public string Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }

        public int Temperatura2 { get; set; }

        public int DiferenciaTemp { get => Math.Abs(Temperatura2 - Temperatura1); }
    }
}
