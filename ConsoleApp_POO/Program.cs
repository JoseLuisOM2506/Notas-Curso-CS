/*-------------------------------------------Programación orientada a objetos-------------------------------------------------------
 * 
 * El paradigma de programación conocido como POO ( Programación Orientada a Objetos) es aquel que tiene como finalidad trasladar 
 * la naturaleza de los objetos de la vida real a una sintaxis que pudiese programarse en código.
 * 
 * El funcionamiento de la POO es mediante el uso de las "Clases", las cuales son "platillas" o "modelos" donde se definen las 
 * características que comparten un conjunto de "Objetos". 
 * 
 * Los "objetos" en la POO son entidades que tienen sus propios atributos/campos (variables o constantes) y comportamientos 
 * (métodos). Estos propios atributos y métodos se definen en la clase a la cual pertenecen.
 * 
 * ------------- Clases
 * Para crear una clase en C# es necesario hacerlo en el ámbito del namespace y se utiliza la siguiente sintaxis:
 * 
 *      class <nombre de la clase>{
 *          <Atributos/Variables/Constantes>
 *          ....
 *          <Métodos>
 *          ...
 *      }
 * 
 * Por convención, se suelen escribir primero los atributos y luego los métodos.
 * 
 * ---------- Instancias
 * 
 * Las instancias son aquellos objetos que creamos en el código y los cuales deben pertenecer a una clase existente, ya que al
 * crearlas, estas instancias harán una "copia" del código que está dentro del ámbito de la clase y solo se podrá acceder a este 
 * código copiado a través de ellas. Para declarar o crear una instancia se utiliza la siguiente sintaxis:
 * 
 *      <nombre de la clase> <identificador>;
 * 
 * Para poder inicializar el objeto creado, a lo que se conoce como instanciar una clase, se utiliza la sintaxis siguiente:
 * 
 *      <identificador> = new <nombre de la clase/constructor>();
 * 
 * Nota. Como con las variables, es posible declarar e inicializar una instancia en una sola línea de código.
 * 
 * ------------ Modificadores de acceso (Encapsulamiento)
 * Los modificadores de acceso forman parte del "encapsulamiento" que posee la POO, lo que restringe el nivel de acceso de los 
 * atributos o métodos entre clases. Estos modificadores de acceso se escriben antes del tipo de dato de cada atributo y método,
 * utilizando las siguientes palabras reservadas:
 * 
 *      por defecto: accesible desde el ámbito donde se declara.
 *      public: accesible desde cualquier parte del código.
 *      private: accesible desde la propia clase.
 *      protected: accesible desde la clase derivada.
 *      internal: accesible desde el mismo ensamblado.
 *      protected internal: accesible desde el mismo ensamblado o clase derivada de otro ensamblado.
 *      private protected: accesible desde la misma clase o clase derivada del mismo ensamblado.
 *      static: accesible solo como método de una clase.
 *      
 * ---------- Acceso a atributos y métodos de instancias
 * 
 * Para acceder a los atributos y métodos de una instancia ya inicializada, se utiliza la siguiente sintaxis:
 * 
 *      <identificador de la instancia>.<atributo>
 *      
 *      <identificador de la instancia>.<método>();
 *      
 * ---------- Notación PascalCase/camelCase
 * 
 * Por convención los atributos y métodos public utilizan la notación PascalCase (mayúscula inicial) y los private usan la notación
 * camelCase(minúscula inicial).
 * 
 * ---------- Constructores
 * 
 * Cuando se inicializa un objeto, es necesario el uso de un "constructor" para definir su estado inicial. Los constructores son un
 * método especial de cada clase, donde por lo general se inicializan los atributos del objeto y se omite la definición de un tipo 
 * de dato en su sintaxis. Estos constructores se definen con el mismo nombre que tiene la clase. Su sintaxis es la siguiente:
 * 
 *      class <identificador de la clase>
 *      {
 *          <Atributos>
 *          
 *          public <mismo identificador de la clase> (<parámetros>)
 *          {
 *              <Sentencias>
 *          }
 *          
 *          <Métodos>
 *      }
 *      
 * En el momento en el que se inicializa un objeto de una clase con constructor, lo que se hace es llamar al método constructor
 * y ejecutar el código que hay en este para darle el estado inicial al objeto.
 * 
 * Si una clase no tiene un constructor, el compilador genera un constructor por defecto que no tiene parámetros ni código en su 
 * ámbito.
 * 
 * ---------- Sobrecarga de constructores
 * 
 * Al igual que los métodos, es posible realizar una sobrecarga en el constructor de una clase para así poder inicializarla de 
 * diferentes maneras a los objetos. Para realizar la sobrecarga de constructores, se deben respetar las mimas reglas que en los
 * métodos, donde se debe de cambiar el tipo de dato de los parámetros y la cantidad que hay de estos.
 * 
 * ----- Métodos GETTER y SETTER
 * 
 * Son métodos que se usan por convención para acceder y modificar los atributos de un objeto. Se utilizan de esta forma para 
 * mantener el un nivel de protección alto en los atributos.
 *      
 *      Se dice que un método getter será aquel que permita "acceder" al valor de un atributo privado del objeto que deseemos.
 *      Por convención, para definir un método getter se debe escribir la palabra "get" al inicio del identificador y este debe
 *      poder devolver un tipo de dato.
 *      
 *      Por otro lado, el método setter será aquel que permita "establecer" el valor de un atributo privado del objeto que deseemos.
 *      Por convención, para definir un método setter se debe escribir la palabra "set" al inicio del identificador y este no debe
 *      devolver ningún tipo de dato.
 *      
 * Cada vez que se cree un método setter, es conveniente crear un método getter para saber si se realizó correctamente el cambio.
 * 
 * ---------- Palabra reservada "THIS"
 * 
 * Esta palabra reservada se utiliza como un "objeto" para así diferenciar un atributo de la clase con el nombre de un parámetro (de
 * un método) que tenga el mismo identificador. La sintaxis de esta palabra reservada es:
 * 
 *      this.<nombre del atributo>
 *      
 * ---------- Partición de una clase 
 * 
 * En algunas ocasiones, cuando el código de nuestro programa se vuelve muy largo, es necesario continuar la codificación de una 
 * clase en otro lugar o línea de código, como si se definiese una clase en dos partes del código. Para definir una clase con la 
 * capacidad de poder ser dividida en partes, es necesario escribir el modificador de clase "partial" (antes de la palabra reservada
 * "class") en cada bloque donde se defina la clase.
 * 
 * ---------- Modularización mediante el uso de distintos "ficheros fuente"
 * 
 * El fichero fuente que genera Visual Studio para programar en C# es el denominado "Program.cs", este es el fichero donde se 
 * codifica todo el programa principal y es el que posee el método Main que se ejecuta inicialmente. Sin embargo, esto no significa
 * que no se puede codificar el programa del proyecto en otros archivos, realizando una modularización del código. Estos son los 
 * denominados archivos "clase", donde es posible codificar otras clases que pueden ser utilizadas en el fichero "Program.cs".
 * 
 * Para crear un archivo clase en Visual Studio, solo basta con ir a la pestaña "PROYECTO" y seleccionar la opción de agregar
 * clase. El nombre que se le de a este archivo será el mismo que tendrá la clase por defecto que genera Visual Studio en ese
 * fichero.
 *
 * ---------- Métodos y variables STATIC
 * 
 * Las variables de tipo STATIC son aquellas que tienen el modificador de acceso "static" antes de la palabra reservada que 
 * identifica el tipo de dato de la variable. Estas se caracterizan por ser "variables de clase", es decir que los objetos creados a 
 * partir de una misma clase compartirán la variable static y no podrán ser llamadas desde los objetos con la sintaxis del punto ".". 
 * 
 * Lo antes mencionado también aplica para los métodos, solo que estos reciben el nombre de "Métodos de Clase".
 * 
 * Una vez que se declare una variable/método con el modificador de acceso "static", es posible acceder a ella mediante el uso de
 * la siguiente sintaxis:
 * 
 *      <Nombre de la clase>.<Identificador variable/método static>;
 * 
 * Nota. Por defecto, las variables que son definidas con la palabra reservada const, son también del tipo static.
 * 
 * ---------- Importar métodos y variables static de una clase
 * 
 * Cuando se hace uso de los métodos y variables static de una clase en repetidas ocasiones, es conveniente realizar la importación 
 * de estas para así simplificar su escritura en cada sentencia donde se utilizan. Para hacerlo, es necesario escribir fuera del 
 * namespace la siguiente sintaxis:
 * 
 *      using static <Nombre del espacio de nombres>.<Nombre de la clase>;
 * 
 * 
 * ---------- Clases anónimas
 * 
 * Una clase anónima es aquella que se crea "implícitamente" cuando se inicializa un objeto del tipo "var" y únicamente pueden 
 * contener atributos públicos. Los objetos que pertenecen a una clase anónima se utilizan comúnmente para agrupar código y agilizar
 * la escritura de este. Los atributos que se definen en una clase ánonima deben ser variables implícitas, las cuales únicamente se
 * deben de inicializar. La sintaxis para crear un objeto de una clase anónima es:
 * 
 *      var <identificador> = new { <inicializar atributo> , <inicializar atributo>, ... };
 *      
 * Para que dos objetos pertenezcan a la misma clase anónima, es necesario que ambos cumplan los siguientes criterios a la hora 
 * de crearlos:
 *      -Tener el mimo número de atributos.
 *      -Los identificados de los atributos deben ser iguales.
 *      -Que el tipo de dato almacenado en estos atributos sea el mismo.
 *      -El orden de los atributos debe ser el mismo.
 *      
 */

using System;
using static System.Math;               //Importando métodos y variables staticas de las clases
using static System.Console;

namespace ConsoleApp_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo primerC;            //Se crea un objeto o variable de tipo Circulo.
            primerC = new Circulo();    //Se inicializa el objeto de tipo Circulo.
            Console.WriteLine(primerC.CalcularArea(4) + primerC.Color);
            
            Circulo segundoC = new Circulo();
            segundoC.Color = "negro";           //Se modifica el atributo color
            Console.WriteLine(segundoC.CalcularArea(3) + segundoC.Color);

            //------------------------------------------------------------------------------------------------------------------

            Telefono miTelefono = new Telefono();       //Inicialización de un objeto con el constructor de la clase.
            Console.WriteLine(miTelefono.getInfo());    //Llamado al método GETTER del objeto
            Telefono mi2Telefono = new Telefono("azul", false); //Inicialización de un objeto con la sobrecarga del constructor
            Console.WriteLine(mi2Telefono.getInfo());

            miTelefono.setColor("rojo");    //Llamado al método SETTER del objeto
            Console.WriteLine("El color de mi primer teléfono es: " +miTelefono.getColor());

            //-------------------------------------------------------------------------------------------------------------------

            //Las siguientes líneas de código hacen uso de la clase partida "Computadora" 
            Computadora computadoraApple = new Computadora();
            computadoraApple.setAlmacenamiento(900);

            Computadora computadoraAcer = new Computadora();

            computadoraAcer.tieneMayorAlmacenamientoQue(computadoraApple);   //Uso del método definido en otro archivo fuente
            computadoraApple.tieneMayorAlmacenamientoQue(computadoraAcer);

            //---------------------------------------------------------------------------------------------------------------------

            //Uso de métodos y variables de clase (STATIC)
            Console.WriteLine("La conversion dio como resultado: " + OperarMatematicas.radianesAgrados(OperarMatematicas.PI*2));

            //Se redujo la cantidad de código al importar los métodos y variables de las clases Console y Math
            WriteLine("La raíz de 2pi es igual a: " + Sqrt(2*PI));

            //Ejemplo de clases anónimas

            var objetoClaseAnonima = new { variable1 = "hola", variable2 = 13 };
            var objeto2ClaseAnonima = new { variable1 = "adios", variable2 = 20 };
            var nuevaClaseAnonima = new { variable1 = 23.56, variable2 = false};    //Clases anónimas diferentes a las dos anteriores
            var nueva2ClaseAnonima = new { variable3 = 23.4, variable4 = true };

            objeto2ClaseAnonima = objetoClaseAnonima;      //Son de la misma clase anónima, así que si se puede asignar el valor.
            
        }
    }

    //Ejemplo de creación de una clase
    class Circulo
    {
        //Atributos
        private const double pi=3.1416;
        public string Color = "blanco";

        //Métodos
        public double CalcularArea(int radio)
        {
            return pi * radio * radio;
        }
    }

    //Ejemplo de uso de constructores
    class Telefono
    {
        //Atributos
        private int ram;
        private double almacenamiento;
        private bool camara;
        private string color;

        //Constructor

        public Telefono()
        {
            ram = 8;
            almacenamiento = 128;
            camara = true;
            color = "blanco";
        }

        //Sobrecarga de constructor
        public Telefono(string colorT, bool camaraT)
        {
            ram = 8;
            almacenamiento = 128;
            camara = camaraT;
            color = colorT;
        }

        //Métodos
        public String getInfo()
        {
            if (camara)
                return $"Este telefono {color} tiene {ram} GB de RAM, {almacenamiento} GB de almacenamiento y una camara";
            else
                return $"Este telefono {color} tiene {ram} GB de RAM, {almacenamiento} GB de almacenamiento y no tiene camara";
        }

        //Ejemplo de funciones SETTER y GETTER
        public void setColor(string color) { this.color = color; }      // Uso de la palabra reservada this
        public string getColor() => color;

    }

    //Ejemplo para partir clases
    partial class Computadora
    {
        private int almacenamiento;
        private int RAM;
        public Computadora () { almacenamiento = 1000; }
    }
    
    partial class Computadora
    {
        public int getAlmacenamiento() => almacenamiento;
        public void setAlmacenamiento(int almacenamientoCom) { almacenamiento = almacenamientoCom; }
    }

    //Ejemplo de una clase con variables y métodos static
    class OperarMatematicas
    {
        public const double PI = 3.1416;                                                
        static public double radianesAgrados(double radianes) => radianes * 180 / PI;
        
    }

}
