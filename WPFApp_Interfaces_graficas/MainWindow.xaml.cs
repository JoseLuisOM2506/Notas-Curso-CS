/* ------------------------------------------ Interfaces gráficas ------------------------------------------------------
 *  
 * Una manera de hacer interfaces gráficas con el lenguaje C# es mediante la creación de una aplicación de WPF, sucesora de 
 * Windows Forms, la cual es una API (Applications Programming Interfaz) que pertenece al framework .NET y la cual permite
 * crear aplicaciones graficas (vectoriales) de escritorio en Windows.
 * 
 * WPF puede trabajar con la arquitectura de desarrollo de aplicaciones backend y frontend como lo hace una página web, para 
 * el desarrollo del código que le dará funcionalidad a la interfaz gráfica se utiliza el lenguaje de programación C#, mientras
 * que la parte visual se desarrolla con un lenguaje de marcado o etiquetas conocido como XAML, el cual es muy similar a HTML.
 * 
 * Al crear un proyecto de WPF, se crearán dos archivos importantes:
 *      - MainWindow.xaml.cs : En este se programan las funcionalidades de la interfaz con el lenguaje C#.
 *      - MainWindow.xaml : Este representa el código que utiliza el lenguaje de etiquetas XAML.
 * 
 * ---------- Herramientas de una interfaz gráfica
 * 
 * Para agregar herramientas a la interfaz gráfica, se debe acceder a la pestaña de "cuadro de herramientas" y arrastrar una de
 * ellas a la vista de diseño de la interfaz en el documento MainWindow.xaml. Automáticamente Visual Studio agregará una 
 * línea de código, en la vista XAML del archivo MainWindow.xaml, que corresponde a la herramienta arrastrada.
 * 
 * Otra forma de agregar herramientas a la interfaz es mediante la creación de los objetos correspondientes en código de C#, en este 
 * documento (MainWindow.xaml.cs). Nota: Los objetos no se verán reflejados en la interfaz gráfica hasta que se ejecute el código.
 *
 * 
 * ---------- Propiedad "Name"
 * 
 * Esta propiedad se utiliza en el lenguaje XAML para darle un identificador a las herramientas que se crean en la interfaz con la
 * vista diseño o XAML. La utilidad de definir esta propiedad es que ahora es posible utilizar la herramienta XAML en el código de 
 * C# como si se tratase de un objeto ya creado.
 * 
 * ---------- Eventos en botones
 * 
 * Para agregar acciones que debe realizar el botón al ser pulsado, es necesario ligar un evento al botón. La manera en que se hace
 * esto es mediante la escritura de la propiedad "Click" al boton requerido. En dicha propiedad se deberá de asignar el nombre del
 * controlador de evento definido en C#, la mejor manera de hacer esto es utilizando la ayuda que proporciona el Intellinsense.
 * 
 * Como el controlador de evento es un método que es llamado cuando se le da click al botón, es posible escribir en su ámbito las
 * líneas de código que se quieran ejecutar al dar click al botón.
 * 
 * ---------- Eventos enrutados en WPF
 * 
 * Los eventos enrutados se llaman así por el mero hecho de que siguen una ruta, camino o orden de ejecución. 
 * 
 * Eventos directos: En estos eventos no existe una propagación, directamente ejecutan el código en su interior.
 * 
 * Eventos burbuja(bubbling): Los eventos se propagan hacia arriba (primero se ejecuta el objeto con menor jerarquía) con la siguiente jerarquía:
 * 
 *   +----------------Window----------------+         * Window                          ^
 *   | +--------------Stack---------------+ |             * Stack                       |    
 *   | | +------------Button------------+ | |                 * Button                  |
 *   | | |+---------TextButton--------+ | | |                    * TextButton           |
 *   | | +------------------------------+ | |
 *   | +----------------------------------+ |                    
 *   +--------------------------------------+
 * 
 * Eventos tunelados(tunneling): Los eventos se propagan hacia abajo (Siempre con "preview" delante del nombre del evento), primero se ejecuta el 
 * objeto con mayor jerarquía.
 * 
 *   +---------------Windows----------------+         * Window                          |
 *   | +---------------Stack--------------+ |             * Stack                       |    
 *   | | +------------Button------------+ | |                 * Button                  |
 *   | | |+---------TextButton--------+ | | |                    * TextButton           v
 *   | | +------------------------------+ | |
 *   | +----------------------------------+ |                    
 *   +--------------------------------------+
 * 
 * ---------- El grid (malla)
 * 
 * Un grid es el contenedor de herramientas más versátil de WPF que divide su contenido en columnas y filas, donde cada columna y
 * fila puede tomar diferentes valores de tamaño, como:
 * 
 *      - Absoluto: Valores en pixeles ("<número de pixeles>").
 *      - Automático: Valor que necesita el elemento del interior ("auto")
 *      - Proporcional: Valor disponible asignado de forma proporcional ("<número proporción>*").
 * 
 * Las celdas que se crean por dividir el grid en columnas y filas se ordenan de la misma forma que una matriz, empezando con el 
 * elemento <0,0>.
 * 
 * Nota. Es posible que una herramienta ocupe más de un espacio del grid, utilizando la propiedad "Grid.<Column/Row>Span".
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

namespace WPFApp_Interfaces_graficas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Ejemplo para crear herramientas de la interfaz gráfica en C#
            Button miBoton = new Button();          //Se crea el objeto de tipo Botton
            miBoton.Content = "botón desde c#";     //Se pueden modificar sus propiedades 
            miBoton.Width = 150;
            miBoton.Height = 25;
            miBoton.Background = Brushes.Orange;
            miGrid.Children.Add(miBoton);           //Se utiliza el método del Grid creado en XAML para agregar el botón


        }

        //El código en el interior de este evento se ejecutará cuando el botón se aprete.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Haz dado click al boton");   //Esta sentencia únicamente imprime en consola lo especifidado
            MessageBox.Show("Haz dado click al boton");     //Mientras que esta sentencia imprime en una ventana emergente lo especificado
        }

        //Controlador de evento bubbling
        private void miStackPanel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Haz dado click al stackPanel1");
        }

        //Controlador de evento tunneling
        private void miSatackPanel2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Haz dado click al stackPanel2");
        }
    }
}
