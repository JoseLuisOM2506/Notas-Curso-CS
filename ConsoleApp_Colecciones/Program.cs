/* ------------------------------------------------ Colecciones --------------------------------------------------------
 * 
 * Las colecciones son estructuras de datos que forman parte del namespace System.Collection.Generic. Estas colecciones son 
 * clases genéricas que permiten crear objetos que almacenan cualquier tipo de elemento. A diferencia de los arreglos, las 
 * colecciones tienen la capacidad de ordenar elementos, añadirlos, eliminarlos, buscarlos, entre otras cosas. Sin embargo, 
 * las colecciones consumen más recursos que los arreglos.
 * 
 * las colecciones más utilizadas son:
 * 
 *      -List<T>         Parecidos a los arreglos pero con métodos adicionales para agregar, eliminar, ordenar y buscar, etc.
 *      -Queue<T>        Las "colas". Un elemento entra y uno sale. Primero en entrar-primero en salir.
 *      -Stack<T>        Parecido a las queue pero con algunas diferencias. Primero en entrar-último en salir.
 *      -LinkedList<T>   Comportamiento como Queue o Stack pero con acceso aleatorio.
 *      -HashSet<T>      Lista de valores sin ordenar.
 *      -Dictionary<Tkey,Tvalue>     Almacena elementos con estructura de clave-valor.
 *      -SortedList<Tkey,Tvalue>     Igual que los Dictionary pero ordenados.
 *  
 *  Nota. En la documentación oficial de C# se encuentran más colecciones, junto con sus miembros.
 * 
 * ------ Colección LIST (listas)
 * 
 * Las listas son colecciones que son capaces de guardar elementos de un solo un tipo de objeto, dichos elementos se almacenan 
 * adyacentemente uno de otro en la memoria, como en una "lista real". Al igual que los arreglos, cada uno de los elementos de una 
 * lista posee un "índice" para saber dónde se ubica cada elemento y asi poder acceder a estos, donde el primer elemento agregado a 
 * la lista empieza con el índice 0 y los siguientes continúan con la enumeración.
 * 
 * Representación hipotética:
 *
 *                       List
 *          +-----------------------------+         
 *          |  --------Elemento0--------  |
 *          |  --------Elemento1--------  |
 *          |  --------Elemento2--------  |
 *          |  --------Elemento3--------  | 
 *          |  --------Elemento4--------  |
 *          +-----------------------------+
 * 
 * Para crear una lista, es necesario instanciar un objeto de la clase LIST con la siguiente sintaxis:
 * 
 *      List<<tipo de objeto>> <identificador> = new List<<tipo de objeto>> ();
 * 
 * Si se desea agregar un elemento a la lista, se utiliza el siguiente método:
 * 
 *      <Identificador de la lista>.Add(<valor/elemento>);
 * 
 * En caso de que se requiera acceder a cada elemento, se puede utilizar la siguiente sintaxis:
 * 
 *      <identificador de la lista>[<índice del elemento>];
 *      
 *      ó
 *      
 *      <identificador de la lista>..ElementAt(<índice del elemento>);
 *      
 * Nota. Así como en los arreglos, es posible utilizar el bucle FOR y FOREACH para recorrer una lista.
 * 
 * Es posible eliminar elementos de la lista con el siguiente método:
 *      
 *      <identificador de la lista>.RemoveAt(<índice del elemento>);
 * 
 * Nota. Si se elimina un elemento de la lista, los elementos con índice mayor se recorrerán para ocupar el espacio vacío, y ahora
 * los elementos tendrán un nuevo índice acorde al lugar que ocuparon. Esto puede significar un problema de rendimiento grave 
 * en caso de que se requiera reacomodar muchos elementos de una la lista.
 * 
 *
 * ---------- Colección LinkedList (listas enlazadas)
 * 
 * Su funcionamiento es muy similar a las LIST, la diferencia es que la colección LinkedList es más eficiente y consume menos 
 * recursos debido a su forma de almacenar los elementos, que es mediante el uso de los denominados "nodos", los cuales se 
 * conforman en su interior por el elemento en cuestión y en sus extremos por los enlaces (Links). Como se muestra en la siguiente
 * representación:
 * 
 *          +-----------------------Nodo------------------------+
 *          |   ----Enlace--------Elemento---------Enlace-----  |
 *          +---------------------------------------------------+
 *          
 * La ventaja de los nodos, es que gracias a sus enlaces no es necesario que los nodos estén en un espacio de memoria adyacente 
 * como en las listas, ya que estos sirven como conectores que apuntan hacia otros nodos, logrando así agruparse en orden.
 * 
 * Representación hipotética:
 * 
 *                              LinkedList
 *          +---------------------------------------------------+
 *          |  ----Enlace--------Elemento0---------Enlace-----  |
 *          |                                                 | <-----  Esta es una conexión entre nodos
 *          |  ----Enlace--------Elemento1---------Enlace-----  |
 *          |  |                                                |
 *          |  ----Enlace--------Elemento2---------Enlace-----  |
 *          |                                                |  |
 *          |  ----Enlace--------Elemento3---------Enlace-----  |
 *          +---------------------------------------------------+
 *          
 * Nota. El primer y último nodo de una linkedlist tiene un enlace que apunta a null.
 *
 * Para crear una linkedlist se sigue la siguiente sintaxis:
 * 
 *      LinkedList<<tipo de objeto>> <identificador> = new LinkedList<<tipo de objeto>> ();
 * 
 * Si se desea agregar un elemento al inicio al final de la lista enlazada, se utilizan los siguientes métodos:
 * 
 *      <Identificador de la lista enlazada>.AddFirst(<valor/elemento>);
 *      
 *      o
 *      
 *      <Identificador de la lista enlazada>.AddLast(<valor/elemento>);
 * 
 *  En caso de que se requiera acceder a cada elemento, se puede utilizar la siguiente sintaxis:
 *      
 *      <identificador de la lista>..ElementAt(<indice del elemento>);
 *      
 * Nota. Es posible utilizar el bucle FOR y FOREACH para recorrer una lista.
 * 
 * Es posible eliminar elementos de la lista enlazada con el siguiente método:
 *      
 *      <identificador de la lista>.RemoveAt(<valor del elemento que se desea eliminar>);
 *      
 * Nota. Cuando se elimina un elemento, lo que sucede es que únicamente se actualizan los enlaces de cada nodo, en donde ahora los 
 * nodos adyacentes al nodo eliminado se enlazan. Consumiendo asi menos recursos para hacer esta acción.
 * 
 * Para trabajar únicamente con un nodo de una lista enlazada, es posible crear objetos de la clase "LinkedListNode" de la
 * siguiente forma:
 * 
 *      LinkedListNode<<tipo de dato>> <identificador> = new LinkedListNode<<tipo de dato>>();
 *      
 * ---------- Colecciones Queue (Colas)
 * 
 * Este tipo de colección utiliza el principio de almacenamiento y acceso F.I.F.O. (First in, First out), donde el primero elemento 
 * en entrar es el primero en salir, ósea que el acomodo de elementos es como en una "cola real". Debido a esta característica, una
 * vez agregados los elementos, para poder acceder ellos es necesario sacarlos de la cola (eliminarlos), en el mismo orden que 
 * entraron, y después ocupar su valor. Este tipo de colección se utiliza en tareas secuenciales que requieren acceder a todos los 
 * elementos.
 * 
 * Representación hipotética:     
 *                                                      Queue                    
 *                  +----------------------------------------------------------------------------+
 *   Entran ---->   | --------Elemento---------Elemento---------Elemento---------Elemento------- |   Salen ----->
 *                  +----------------------------------------------------------------------------+
 *                              Fin                                              Inicio
 *                              
 * Nota. Las colas no hacen uso de un índice para identificar a los métodos, debido al principio F.I.F.O.
 *                                                                                                     
 * Para crear una cola se sigue la sintaxis siguiente:
 * 
 *      Queue<<tipo de objeto>> <identificador> = new Queue<<tipo de objeto>> ();
 * 
 * Para agregar elementos a la cola, se hace uso del siguiente método:
 * 
 *      <identificador de la cola>.Enqueue(<valor/elemento>);
 * 
 * El acceso y eliminación del elemento inicial de la cola se realiza con la siguiente sintaxis:
 * 
 *       <identificador de la cola>.Dequeue();
 * 
 * Si solo se requiere el acceso al primer elemento, se utiliza el siguiente método:
 * 
 *       <identificador de la cola>.Peek();
 * 
 * Nota. Es posible utilizar el bucle FOR y FOREACH para recorrer una cola. Sin embargo, como el bucle FOREACH hace uso del
 * método dequeue implícitamente, después de recorrer la cola se eliminarán todos sus elementos.
 *
 * ---------- Colección STACK (Pila)
 * 
 * Este tipo de colección utiliza el principio de almacenamiento y acceso L.I.F.O. (Last in, First out), donde el último elemento 
 * en entrar es el primero en salir, ósea que el acomodo de elementos es como en una "pila real". Al igual que en las colas, para 
 * poder acceder a los elementos es necesario sacarlos de la pila (eliminarlos), con el orden L.I.F.O, y después ocupar su valor.
 * 
 * Representación hipotética:
 * 
 *                                                      Stack                    
 *   Entran ---->   +----------------------------------------------------------------------------+
 *                  | --------Elemento---------Elemento---------Elemento---------Elemento------- |   
 *   Salen <-----   +----------------------------------------------------------------------------+
 *                              Fin                                              Inicio
 * 
 * Para crear una pila se sigue la sintaxis siguiente:
 * 
 *      Stack<<tipo de objeto>> <identificador> = new Stack<<tipo de objeto>> ();
 *      
 * Para agregar elementos a la pila, se hace uso del siguiente método:
 * 
 *      <identificador de la pila>.Push(<valor/elemento>);
 * 
 * El acceso y eliminación del elemento final de la pila se realiza con la siguiente sintaxis:
 * 
 *       <identificador de la pila>.Pop();
 *       
 * Si solo se requiere el acceso al último elemento, se utiliza el siguiente método:
 * 
 *       <identificador de la pila>.Peek();
 * 
 * Nota. Es posible utilizar el bucle FOR y FOREACH para recorrer una pila. Sin embargo, como el bucle FOREACH hace uso del
 * método Pop implícitamente, después de recorrer la cola se eliminarán todos sus elementos.
 * 
 * ---------- Colección Dictionary (Diccionario)
 * 
 * Son similares a los arreglos en cuanto al almacenamiento de datos, solo que ahora cada elemento tendrá una clave única que escoge 
 * el programador para identificarlos. Esta característica extra provoca que los diccionarios consuman más recursos que las demás 
 * colecciones.
 * 
 *  Representación hipotética:
 *                                                    Dictionary                    
 *                  +----------------------------------------------------------------------------+
 *                  | --------Elemento---------Elemento---------Elemento---------Elemento------- |   
 *                  |          T-key            T-key            T-key            T-key          |
 *                  +----------------------------------------------------------------------------+
 *                                                                                           
 * Para crear un diccionario se sigue la sintaxis siguiente:
 * 
 *      Dictionary<<tipo key>, <tipo objeto>> <identificador> = new Dictionary<<tipo key>, <tipo objeto>> ();
 * 
 * Para agregar elementos el diccionario, se hace uso de las siguiente sintaxis:
 * 
 *      <identificador del diccionario>. Add(<valor key>,<valor/elemento>);
 *      
 *      o
 *      
 *      <identificador del diccionario>[<valor key>] = <valor/elemento>;
 *      
 * El acceso a un elemento del diccionario se realiza con la siguientes sintaxis:
 * 
 *      <identificador del diccionario>[<T-key>];
 * 
 * La eliminación de uno de los elementos del diccionario se hace con el siguiente método:
 * 
 *      <identificador del diccionario>.Remove(<T-key>);
 *      
 * Nota. Es posible utilizar el bucle FOR y FOREACH para recorrer un diccionario. Sin embargo, es necesario el uso de algunas
 * propiedades de la clase "Dictionary" en ambos casos.
 *
 */


using System;
using System.Collections.Generic;           //Se agrega el namespace que contiene las clases de colecciones

namespace ConsoleApp_Colecciones
{

    class Program
    {
        static void Main(string[] arg)
        {
            //Ejemplo para mostrar el uso de la colección List
            List<int> enteros = new List<int>();

            //Es posible utilizar bucles para almacenar varios datos en una lista
            for (int i = 0; i < 4; i++)
            {
                enteros.Add(i + 1);                 //Se hace uso del método Add para agregar valores a la lista
            }

            //Se pueden almacenar los elementos de un arreglo, además se puede extender el tamaño de la lista (a diferencia de un array que no puede)
            int[] numeros = { 5, 6, 7, 8 };
            for (int i = 0; i < numeros.Length; i++) enteros.Add(numeros[i]);

            //Se puede usar el bucle foreach para extraer los datos de la lista, cabe mencionar que los elementos de la lista se
            //enumeran y ordenan de la misma forma que un arreglo


            //Usar el método RemoveAt para remover un elemento con el índice especificado
            enteros.RemoveAt(enteros.Count - 1); //Esta instrucción elimina el último elemento de la lista

            enteros.RemoveAt(0);        //Se elimina el primer elemento de la lista

            //Al eliminar el primer elemento, se recorre el orden como se había mencionado. Ahora el elemento 2 es el 1, así consecutivamente con todos
            Console.WriteLine("\n" + enteros.ElementAt(0) + "\n" + enteros[1]);  //Con el método ElementAt se accede al elemento de la lista con el índice especificado


            //-----------------------------------------------------------------------------------------------------------------------------------------------------------
            //Ejemplo para mostrar el uso de la colección LinkedList

            LinkedList<string> nombres = new LinkedList<string>();
            nombres.AddFirst("José");           //Se utiliza AddFirst para agregar el objeto como primer elemento de la linkedlist
            nombres.AddLast("Alberto");         //Para agregar el objeto como último elemento en la linkedlist se usa AddLast
            nombres.AddLast("Daniel");

            foreach (string elemento in nombres) Console.WriteLine(elemento);       //También se pueden usar bucles para acceder o almacenar elementos

            nombres.Remove("Alberto");                  //El método Remove, elimina el primer elemento que se parezca al objeto especificado

            //Como se eliminó un elemento, se cambiaron los enlaces de los nodos, es decir que se cambió el orden de la lista pero de una manera más optimizada
            Console.WriteLine(nombres.ElementAt(1));    // Se usa ElementAt para acceder al nodo especificado

            //Se pueden crear objetos de tipo nodo, para almacenarlos en una linkedlist
            LinkedListNode<string> nodoNombre = new LinkedListNode<string>("Maria");

            nombres.AddFirst(nodoNombre);       //Para agregar el nodo como primer elemento, se puede usar el mismo método AddFirst



            //-----------------------------------------------------------------------------------------------------------------------------------------------------------
            //Ejemplo para mostrar el uso de la colección Queue

            Queue<int> datos = new Queue<int>();

            foreach (int elemento in new int[] { 1, 2, 3, 4, 5 })
            {
                datos.Enqueue(elemento);            //Se utiliza el método Enqueue para agregar objetos a la cola, respetando el principio F.I.F.O.
            }

            //Para acceder a los datos de la cola, se deben sacar (eliminar) de esta para poder utilizarlos, respetando el principio F.I.F.O.

            for (int i = 0; 0 < datos.Count - 2; i++)
            {
                int dato = datos.Dequeue();         //Se usa el método Dequeue para sacar los elementos en orden de llegada
                Console.WriteLine(dato);
            }

            //Al acceder / eliminar los datos de la cola, ya no se encontrarán almacenados en esta, por ende al recorrer la cola con un bucle solo se mostrara
            //el último dato.
            foreach (int elemento in datos) Console.WriteLine(elemento);

            //El bucle foreach permite acceder a todos los datos de la cola, eliminándolos al igual que un for
            datos.Enqueue(1);
            datos.Enqueue(2);
            foreach (int elemento in datos) Console.WriteLine(elemento);

            //Se puede usar el método Peek para acceder al primer elemento de una cola, sin eliminarlo
            datos.Enqueue(200);
            datos.Enqueue(302);
            Console.WriteLine("\n" + datos.Peek());


            //-----------------------------------------------------------------------------------------------------------------------------------------------------------
            //Ejemplo para mostrar el uso de la colección Stack

            Stack<string> animales = new Stack<string>();

            animales.Push("camello");   //El método Push en las pilas es el equivalente al método Enqueue de las colas, solo que se respeta el principio L.I.F.O.
            animales.Push("gato");
            animales.Push("oveja");
            animales.Push("Abeja");

            for (int i = 0; 0 < animales.Count - 2; i++)
            {
                Console.WriteLine(animales.Pop());              //El método Pop es el equivalente al Dequeue, solo que respeta el principio L.I.F.O.
            }

            //También se puede usar el bucle foreach para acceder /eliminar a todos los elementos
            foreach (string elemento in animales) Console.WriteLine(elemento);

            //Existe el método Peek para los stack, solo que ahora respeta el principio L.I.F.O
            animales.Push("Lagarto");
            animales.Push("Rana");
            Console.WriteLine("\n" + animales.Peek());

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------
            //Ejemplo para mostrar el uso de la colección Dictionary

            Dictionary<string, int> personas = new Dictionary<string, int>();

            //Para agregar elementos se usa el método Add
            personas.Add("Alejandro", 50);
            personas.Add("Angela", 23);
            //También se puede seguir la siguiente sintaxis para agregar elementos
            personas["Pedro"] = 45;
            personas["Fernanda"] = 13;

            //Para acceder a un elemento se usa la sintaxis del arreglo, solo que el índice se cambiara por la key asignada
            Console.WriteLine("Pedro tiene " + personas["Pedro"] + " años");

            //Se pueden eliminar elementos usando el método Remove
            personas.Remove("Pedro");

            //Para acceder a todos los elementos, se puede usar un foreach
            foreach (string clave in personas.Keys)      //Se utiliza un atributo de la colección "Keys" para usarlas en el recorrido de la colección
            {
                Console.WriteLine($"Nombre: {clave} Edad: {personas[clave]}");
            }


        }
    }

}
