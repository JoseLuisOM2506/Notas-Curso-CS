/* ----------------------------------------------- Dependency properties --------------------------------------------------------
 * 
 * Son propiedades que dependen del sistema de propiedades de WPF para que funcionen completamente, por lo general, estas 
 * dependecy properties dotan a las herramientas/controles de características especiales. El sistema de propiedades de
 * WPF es un conjunto de servicios que se pueden utilizar para así ampliar la funcionalidad de una propiedad.
 * 
 * Representación hipotética:
 *
 *  +---------------------+                                    +------------------------------+
 *  |                     |  Propiedad 1     Dependencia       |                              |
 *  |     Control WPF     |  Propiedad 2  ------------------>  |  Sistema de propiedades WPF  |
 *  |                     |  Propiedad 3                       |                              |
 *  +---------------------+                                    +------------------------------+

 * El sistema de dependencia se utiliza para establecer las propiedades de una herramienta en función de los siguientes
 * parámetros:
 *  - Propiedades del sistema (temas y preferencias de usuarios)
 *  - Data binding (Just in Time)
 *  - Animaciones
 *  - Estilos
 *  - Entre otros
 * 
 * ---------- Crear dependency propertie (propia)
 * 
 * Para declarar una dependecy propertie propia, es necesario hacerlo en la clase MainWindow con la siguiente sintaxis:
 * 
 *      public <tipo de dato> <identificador de la property>
 *      {
 *          get{return (<tipo de dato>)GetValue(<identificador de la dependency property>);}
 *          set{SetValue(<identificador de la dependency property>,value);}
 *      }
 * 
 * Después se debería de registrar la depency property en la clase MainWindow con la siguiente sintaxis para que el proyecto la 
 * pueda utilizar:
 * 
 *      public static readonly DependencyProperty <identificador de la dependecy property> =
 *      DependencyProperty.Registrer("<identicador de la property>,typeof(<tipo de dato>),typeof(<clase owner de la property>),new PropertyMetadata(0));
 * 
 * Nota. Se desconoce la manera de utilizar la dependency propertie propia, se sugiere la consulta de la documentación oficial.
 * 
 * ---------- Data Binding (enlace de datos)
 * 
 * Para que una herramienta/control de WPF pueda enviar y recibir datos con otro control, objeto o BBDD se hace uso del Data 
 * Binding. Existen distintos data binding, estos son:
 * 
 *                                                      Target                                Source                                         
 *
 * OneWay (Un solo camino)                           Control WPF   <----------     BBDD, Objetos, Control WPF
 * OneWayToSource (Un solo camino a source)          Control WPF   ---------->     BBDD, Objetos, Control WPF
 * TwoWays (Dos caminos)                             Control WPF   <--------->     BBDD, Objetos, Control WPF
 * OneTime (Una vez)                                 Control WPF   <----------     BBDD, Objetos, Control WPF
 *
 * La manera en la que se realiza el data binding, es mediante la codificación de las propiedades de un control en la vista XAML.
 * 
 * ---------- Interfaz INotifyPropertyChanged
 * 
 * Se trata de una interfaz que se encarga de reunir todos los eventos que puede desencadenar un objeto en uno solo. Esto se 
 * utiliza comúnmente para detectar cambios en las propiedades.
 * 
 * Representación hipotética:
 * 
 *            +-                          Evento1
 *            |     Text                --------->
 *            |                           Evento2
 *            |     Backgroud           --------->
 *   Objeto  -+                           Evento3              Usuario
 *            |     Color               --------->
 *            |                           Evento4
 *            |     Border              --------->
 *            +-
 *
 *            +-                     INotifyPropertyChanged     
 *            |     Text                +---------+
 *            |                         |         |
 *            |     Backgroud           |         |
 *   Objeto  -+                     ----| Eventos |---->        Usuario
 *            |     Color               |         |
 *            |                         |         | 
 *            |     Border              +---------+
 *            +-           
 *
 * Para utilizar esta interfaz, es necesario implementarla en una clase definida en el código de C#.
 *
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;                        //Se agregó esta librería para usar la interfaz  INotifyPropertyChanged
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


namespace WPFApp_Properties_Y_Data_Binding
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


            elNombre = new JuntarNombre { NOMBRE = "Juan", APELLIDO = "Pérez" }; //Se inicializa el objeto antes creado

            this.DataContext = elNombre; //Se utiliza esta sentencia para poder utilizar el objeto en la vista XAML
        }

        //Se debe colocar la property en la clase MainWindow
        public int miProperty
        {
            get { return (int)GetValue(miDependency); }
            set { SetValue(miDependency, value); }
        }
        //Se crea la dependency property
        public static readonly DependencyProperty miDependency = DependencyProperty.Register("miProperty", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public JuntarNombre elNombre;       //Se crea un objeto de la clase que implementa la interfaz INotifyPropertyChanged
    }

    //Ejemplo de una clase que implementa la interfaz INotifyPropertyChanged
    public class JuntarNombre : INotifyPropertyChanged
    {
        private string nombre, apellido, nombreCompleto;

        public event PropertyChangedEventHandler PropertyChanged;       //Se implementa la interfaz con esta sentencia

        private void OnPropertyChanged(string property)                //Este será el evento que se ejecutará cuando cambie la propiedad
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property));

        }
        //Propiedades
        public string NOMBRE { get => nombre; set { this.nombre = value; OnPropertyChanged("NOMBRE_COMPLETO"); } }
        public string APELLIDO { get => apellido; set { this.apellido = value; OnPropertyChanged("NOMBRE_COMPLETO"); } }
        public string NOMBRE_COMPLETO { get => nombre + " " + apellido; set => nombreCompleto = value; }
    }


}
