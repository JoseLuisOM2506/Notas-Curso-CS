/*----------------------------------------------- Properties ----------------------------------------------------
* 
 * Las properties o propiedades son un tipo especial de campos de clase públicos, a las que se les puede definir con exactitud lo 
 * que harán cuando se les asigne un valor o se acceda a ellas, de una manera muy similar a como lo hacen los métodos getter y 
 * setter cuando trabajan con atributos públicos. Sin embargo, las propiedades no son capaces de almacenar valores por si solas
 * como lo hacen las variables.
 * 
 * Para declara una propiedad, es necesario hacerlo como si se tratase de un campo, con la diferencia de que se le definirá un 
 * ámbito con llaves "{}", dentro de este ámbito se definirán dos bloques de código, el "get" y "set". En el bloque "get" se
 * definirán las sentencias de código que deberá hacer la propiedad cuando se quiera acceder a esta, siendo de suma importancia el
 * uso de por lo menos una sentencia "return" para devolver un valor al lugar donde se llamó la propiedad. En el bloque "set se 
 * definirán las sentencias de código que establezca el comportamiento de la propiedad cuando se quiera modificar su valor, en este
 * caso, para acceder al valor que se le quiere asignar a la variable dentro del set, se hace uso de la palabra reservada "value" la
 * cual se trabajará como una variable, además, como la propiedad no es capaz de almacenar un valor, es necesario utilizar 
 * atributos privados ya declarados en la clase para dotar a la propiedad con esta característica.
 * 
 * La sintaxis de una propiedad es la siguiente:
 * 
 *          public <tipo de dato> <identificador>
 *          {
 *              get{
 *                  <sentencias>;
 *                  return <valor>;
 *              }
 *              
 *              set{
 *                  <sentencias utilizando "value" y campos ya declarados>;
 *              }
 *          }
 * 
 * Nota. Usualmente una propiedad suele trabajar en conjunto con un campo privado, por lo que ambos suelen tener el mismo
 * identificador, solo que la propiedad estará escrita en mayúsculas y el campo en minúsculas. En ocasiones incluso la propiedad
 * se escribe en minúsculas con un guion bajo inicial.
 * 
 * 
 * ---------- Expression bodied
 * 
 * Esta es una sintaxis más rápida para definir a los bloques "get" y "set de una propiedad con una única sentencia. Para esto se 
 * hace uso del operador lambda "=>" de la siguiente manera:
 * 
 *          public <tipo de dato> <identificador>
 *          {
 *              get => <sentencia>;
 *              
 *              set => <sentencia>;
 *          }
 *          
 * Nota. Como el operador lambda funciona también para retornar un valor, entonces ya no es necesario utilizar la sentencia 
 * "return" en el bloque get.
 * 
 * 
 * ---------- Propiedades de solo escritura o lectura
 * 
 * En caso de requerir una propiedad a la que no se le pueda asignar un valor (solo lectura) o acceder a ellas (solo escritura), es 
 * posible prescindir de la escritura del bloque "set" o "get".
 * 
 * 
 * ----------- Memoria stack y heap
 * 
 * Cuando se programa en C#, el compilador se encarga de utilizar dos memorias diferentes (stack y head) para almacenar los datos 
 * del programa. 
 * 
 * La memoria principal es la stack, esta es de almacenamiento temporal y es el lugar donde se reservan los espacios de memoria 
 * cuando se declaran las variables. Además, cuando se declara un objeto de una clase, se crea una referencia de objeto en la 
 * memoria stack que puede ser apuntada a un objeto que se almacena en la memoria heap. 
 * 
 * La memoria secundaria o dinámica se llama heap, que se utiliza en su mayoría para crear espacios de memoria donde se almacenan
 * los objetos de clase cuando se inicializan en el código. La manera en que el código accede a esta memoria es por medio de 
 * punteros que unen dinámicamente la referencia en la memoria stack con el espacio de memoria reservado en el heap.
 * 
 * Nota. Cuando se le asigna un objeto de clase a otro (<instancia1> = <instancia2>), lo que realmente sucede es que ahora las
 * dos referencias de objeto apuntaran al mismo objeto en el heap. Sin embargo, si los objetos fueran de una estructura, entonces
 * se creara una copia nueva de la estructura en el stack.
 * 
 * 
 *--------- Structs
 * Las estructuras o structs son algo similares a las clases, estas son diferentes en la manera en la que se reserva espacio de 
 * memoria en el stack y heap. Mientras que una clase hace uso de objetos para crear sus referencias en el stack y luego apuntar
 * dinámicamente a la memoria heap para acceder al espacio de código del objeto, las structs no crean referencias y tampoco 
 * hacen uso de la memoria heap, sino que cada vez que se inicializa un objeto se crea una copia de la estructura en el heap.
 * 
 * La sintaxis que se debe seguir para crear structs es la misma que una clase, solo es necesario cambiar la palabra reservada
 * class por struct.
 * 
 *      struct <identificador> 
 *      {
 *          <atributos>
 *          <propiedades>
 *          <constructor>
 *          <métodos>
 *      }
 * 
 * Algunas características de las estructuras que le diferencian de las clases son:
 *      - No se permite la declaración de constructor por defecto.
 *      - El compilador no inicia los campos con si valor por defecto. Se debe inicializarlos en el constructor.
 *      - No puede tener sobrecarga de constructores.
 *      - No heredan de otras clases, pero si implementan interfaces.
 *      - Son selladas (sealed).
 *
 * Usos de las estructuras:
 * 
 * - Cuando necesitas trabajar con una cantidad elevada de datos en memoria(números complejos, puntos tridimensionales,etc.).
 *      - Cuando las instancias no deban cambiar (inmutables).
 *      - Cuando la instancia tenga tamaño inferior a 16 bytes.
 *      - Cuando no se necesite convertir a un objeto (boxed).
 *      - Por razones de rendimiento.
 * 
 * 
 * ----------- Enum o tipo enumerados
 * De manera simple, se dice que son un conjunto de constantes accesibles a través de un identificador. Estos enum se utilizan para 
 * trabajar con valores fijos (constantes) de una manera más adecuada en un programa. Por convención, los tipos enumerados se declaran 
 * en el ámbito del namespace. La sintaxis es la siguiente:
 * 
 *      enum <identificador> {< identificador constante1> , <identificador constante2>, ...}
 *      
 * Nota. Cuando se crea un enum con puros identificadores, el compilador les asigna valores enteros por defecto (0,1,2,...).
 * 
 * La sintaxis para declarar un enum y cambiar los valores de cada constante es:
 * 
 *      enum <identificador> {< identificador constante1> =<valor entero> , <identificador constante2> = <valor entero>, ...}
 * 
 * Es posible trabajar con los identificadores de un tipo enumerado, como si fuesen strings (pero no lo son), o con sus valores 
 * enteros. Para esto, primero es necesario primero crear variables con la siguiente sintaxis:
 * 
 *     <identificador del enum> <identificador de la variable> = <identificador del enum>.<identificador constante requerida>;
 * 
 *  Después, si se utiliza esta variable de manera ordinaria, únicamente se podrá trabajar con el identificador almacenado. Pero
 *  si se realiza un casting a otra variable de la siguiente manera, se podrá acceder al valor entero de la constante.
 *  
 *      <tipo de dato int/double> <identificador de la nueva variable> = (<tipo de dato int/double>) <identificador de la variable enum>
 *  
 *  Si se requiere guardar un valor nulo en un tipo enumerado, se utiliza la siguiente sintaxis:
 *  
 *      <identificador del enum>? <identificador de la variable> = null;
 * 
 * 
 * ---------- Garbage collection
 * 
 * Conocido en español como recolector de basura, se encarga de liberar espacio de memoria en el head que es ocupado por código
 * que ya no se utiliza, a fin de que el programa consuma menos recursos de la computadora. El garbage collection actúa cuando lo
 * ve necesario.
 * 
 * ---------- Destructores
 * 
 * Los destructores son un conjunto de código perteneciente a una clase, que se ejecuta cuando el garbage collection elimina un
 * recurso en la memoria (instancia). 
 * 
 * Algunos ejemplos de su uso son:
 *      - Cierre de la conexión con BBDD.
 *      - Cierre de stream cuando se trabaja con fichero.
 *      - Eliminación de objetos pertenecientes a colecciones.
 * 
 * La declaración de un destructor se realiza con la siguiente sintaxis:
 *          
 *      class <identificador de la clase>
 *      {
 *          <atributos>
 *          <Propiedades>
 *          <constructores>
 *          <métodos>
 *      
 *      //Declaración del destructor
 *          ~<identificador de la clase>()
 *          {
 *              <sentencias>
 *          }
 *      }
 *  
 * ---------- Consideraciones a tomar en cuenta en el uso de destructores
 * 
 *  - Los destructores solo se usan en clases
 *  - Los destructores no se heredan ni sobrecargan.
 *  - Los destructores no se pueden llamar. Estos se invocan automáticamente.
 *  - No se pueden usar modificadores de acceso ni parámetros
 *  

 */

using System;
using System.Transactions;

namespace ConsoleApp_Properties_Structs_Enum_Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----Ejemplo para usar properties
            Personas miPersona = new Personas(20, "Arturo");
            Console.WriteLine("Yo tengo " + miPersona.EDAD + " años.");

            try { miPersona.EDAD = -20; }
            catch { Console.WriteLine("Ingreso un número invalido para la propiedad"); }

            miPersona.EDAD = 15;
            Console.WriteLine($"Mi nombre es {miPersona.NOMBRE} y tengo " + miPersona.EDAD + " años.");

            //-----Ejemplo para usar objetos de estructuras

            Animales miAnimal = new Animales(2, "Piolin");
            Console.WriteLine($"Mi nombre es {miAnimal.NOMBRE}");

            miAnimal.setNombre(miAnimal, "Kike");
            //Como el objeto que se enviar como parámetro es de una estructura, la asignación entre este tipo de objetos crea una
            //provoca que la instancia dentro del método tenga una copia del parámetro, por ende los cambios realizados
            //se hacen a la instancia de estructura que está dentro del método y no en la instancia "miAnimal", de ahí que al
            //imprimir nuevamente el valor "nombre" se obtenga el mismo resultado que antes.
            Console.WriteLine($"Mi nombre es {miAnimal.NOMBRE}");

            //Mismo ejemplo que el anterior solo que con objetos de clases

            Personas miPersona2 = new Personas(2, "´Luis");
            Console.WriteLine($"Mi nombre es {miPersona2.NOMBRE}");

            miPersona2.setNombre(miPersona2, "Santiago");
            //Como el objeto que se enviar como parámetro es de una clase, la asignación entre este tipo de objetos hará que la
            //la referencia de la instancia dentro del método apunte al mismo objeto al que apunta la referencia "miPersona2", por
            //ende los cambios realizados en el método se hacen al objeto al que apuntan estas dos referencias, 
            //así que al imprimir nuevamente el valor "nombre", se obtiene un resultado diferente debido al cambio realizado.
            Console.WriteLine($"Mi nombre es {miPersona2.NOMBRE}");

            //Uso de tipos enumerados (enum)
            Meses1 miCumpleaños = Meses1.Junio;
            Console.WriteLine(miCumpleaños);            //Es importante mencionar que los tipos enumerados no son strings

            Meses2 mes2 = Meses2.Abril;
            int valorMes2 = (int)mes2;                  //Para acceder al valor almacenado se debe hacer un casting
            Console.WriteLine(valorMes2);

            //Ejemplo para usar destructores
            UsoArchivos nuevoArhivo = new UsoArchivos();

        }

    }

    class Personas
    {
        //Atributos
        protected int edad;
        protected string nombre;

        //Propiedades
        public int EDAD                                     //Propertie de lectura y escritura
        {
            get { return this.edad; }                       //Se retorna el atributo edad
            set { this.edad = validacionEdad(value); }      //Se utiliza un método para validad el valor dado, y si es permitido se asigna a al campo edad
        }
        public string NOMBRE                                //Propertie de solo lectura
        {
            get => this.nombre;                             //Uso de Expression bodied
        }

        //Constructores
        public Personas(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        //Métodos
        static private int validacionEdad(int edad)                //Ese método valida si la variable edad es mayor a 0.
        {
            if (edad <= 0) throw new ArgumentOutOfRangeException();
            else return edad;
        }

        public void setNombre(Personas persona, string nombre) { persona.nombre = nombre; }  //Método para probar el funciónamiento de la memoria heap
    }


    //Ejemplo de declaración de una estructura igual a la clase anterior
    struct Animales                                         //Se crea una estructura 
    {
        //Atributos
        private int edad;
        private string nombre;

        //Propiedades
        public int EDAD
        {
            get { return this.edad; }
            set { this.edad = validacionEdad(value); }
        }
        public string NOMBRE
        {
            get => this.nombre;
        }

        //Constructores
        public Animales(int edad, string nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        //Métodos
        static private int validacionEdad(int edad)
        {
            if (edad <= 0) throw new ArgumentOutOfRangeException();
            else return edad;
        }

        public void setNombre(Animales animal, string nombre) { animal.nombre = nombre; } //Método para probar el funcionamiento de la memoria stack
    }

    //Ejemplo de creación de enum

    enum Meses1 { Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre }     //Se agregan solo identificadores.
    enum Meses2 { Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre } //Se asignan valores automáticamente
    enum Meses3 { Enero = 1, Junio = 6, Diciembre = 12 }           //Se asigna un valor propio a cada identificador


    //Ejemplo para usar destructores

    class UsoArchivos
    {
        //Atributos
        private StreamReader miArchivo = null;
        private string lineas;

        //Constructor
        public UsoArchivos()
        {
            miArchivo = new StreamReader(@"mitexto.txt");
            while ((lineas = miArchivo.ReadLine()) != null) Console.WriteLine(lineas);
        }

        //Destructor
        ~UsoArchivos()
        {
            miArchivo.Close();
        }
    }
}
