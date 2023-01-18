//-------------------------------------------------- Interfaces --------------------------------------------------------
/* Son un conjunto de directrices que se deben cumplir en las clases selectas. Las interfaces están conformadas por declaraciones
 * de métodos vacíos llamados "directrices", los cuales les dan un comportamiento estricto a las clases. Para que una clase
 * este obligada a cumplir las directrices de una interface, es necesario que la interface este "implementando/heredando" sus 
 * métodos a la clase. La declaración de interfaces se realiza en el ámbito del namespace, con la siguiente sintaxis:
 * 
 *      interface <identificador iniciando con la letra I (convención)>
 *      {
 *      //Declaración de directrices
 *      <tipo de dato> <identificador>(<parámetros>);
 *      <tipo de dato> <identificador>(<parámetros>);
 *      ...
 *      }
 * 
 * Nota: No se deben usar modificadores de acceso a los métodos que se coloquen en las interfaces.
 * 
 * La sintaxis que se utiliza para que una clase deba implementar las directrices de una interface es la siguiente:
 * 
 *      class <identificador de la clase> : <identificador de la clase padre/ interfaz> , <identificador de la interfaz> , ...
 *      {
 *          <atributos>
 *          <constructores>
 *          <métodos>
 *      }
 * 
 * Una vez hecha la implementación, se deberá de realizar la definición de las directrices en el ámbito de la clase.
 * 
 * Nota. Una clase puede implementar cuantas interfaces se requiera. Si dos interfaces tienen una directriz igual, y una clase 
 * implementa esas dos interfaces, ocurre un problema de "ambigüedad" ya que al definir la directriz, esta puede satisfacer a las
 * dos interfaces. 
 * 
 * --------- Corregir problema de ambigüedad con directrices repetidas en interfaces diferentes
 * 
 * Para corregir este problema es necesario definir dos directrices casi iguales dentro de la clase, con la siguiente sintaxis
 * especial para especificar a que interfaz hace referencia cada directriz. Nótese que no se hace uso de un modificador de acceso.
 * 
 *          <tipo de dato> <identificador de la interfaz>.<identificador de directriz con ambigüedad>()
 *          {
 *              <Sentencias>;
 *          }
 *          
 * Como ambas directrices tienen el mismo identificador, no es posible acceder a este método a través de una instancia. Para poder 
 * acceder a las directrices repetidas, es necesario utilizar el principio de sustitución, donde se deberá de instanciar un
 * objeto especial que pertenezca a la interface que posee la directriz que se quiere usar. Para inicializar este objeto de la 
 * interfaz, se tiene que utilizar el constructor de la clase implementada donde existe la ambigüedad o en cuyo caso, asignar
 * un objeto de esta misma clase.
 * 
 * Nota. Como ocurrió con la herencia, al utilizar el principio de sustitución, los objetos de la interfaz perderán el acceso a los
 * métodos de la clase donde existía la ambigüedad.
 * 
 * --------- Restricciones en interfaces
 * 
 *      - No se permite declara en una interfaz un campo/atributo, constructor, destructor.
 *      - No se pueden usar modificadores de acceso en métodos ( todos los métodos se definen de forma implícita como public).
 *      - No se pueden anidar clases ni otro tipo de estructuras.
 *      
 * -------- Extras de interfaces
 * 
 * Es posible crear otros archivos fuente en el proyecto donde se incluyan las interfaces que uno requiera.

 * 
 */


using System;

namespace ConsoleApp_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de uso del método definido en la interfaz
            Casa miCasa = new Casa();
            Console.WriteLine("El número de habitaciones de mi casa son: " + miCasa.numeroHabitaciones());

            //Ejemplo de uso de métodos que se repiten en interfaces
            Hotel miHotel = new Hotel();
            ISuites ImiSuite = miHotel;             //Se aplica principio de sustitución para poder acceder al método color
            Console.WriteLine("El color de mi suite es: " + ImiSuite.color());

        }
    }

    interface IHabitaciones                    //Declaración de la interfaz IHabitaciones
    {
        int numeroHabitaciones();              //Se define solo el método y no se deben usar modificadores de acceso

        string color();                 //Directriz repetida en otra interfaz
    }

    interface ISuites
    {
        int numeroSuites();
        double precioSuites();

        string color();                 //Directriz repetida en otra interfaz
    }


    class Inmobiliario
    {
        public virtual void ubicacion(string lugar) { Console.WriteLine($"La ubicación del inmobiliario es: {lugar}"); }

    }
    class Terreno : Inmobiliario
    {
        public int areaDelTerreno() => 200;        //Método que no se implementa de una interfaz
    }
    class Casa : Inmobiliario, IHabitaciones            //Se implementa la interface
    {
        public int numeroHabitaciones() => 3;           //Definición de la directriz de la interface
        public string color() => "rojo";
    }
    class Hotel : Inmobiliario, IHabitaciones, ISuites    //Declaración de múltiples interfaces
    {
        public int numeroHabitaciones() => 100;
        public int numeroSuites() => 20;
        public double precioSuites() => 1999.99;

        //Ejemplo de solución de ambigüedad en directrices repetidas 
        string IHabitaciones.color() => "Amarillo";
        string ISuites.color() => "Blanco";
    }


}

