/*------------------------------------------------Arreglos o Arrays --------------------------------------------------------
 * 
 * Estos son uno de los tipos de estructuras de datos que hay C# y tienen la capacidad de almacenar varios valores del mismo
 * tipo de dato u objetos. En general, se utilizan los arreglos para almacenar muchos valores que tienen alguna relación entre sí.
 * Su sintaxis es la siguiente:
 *
 *  Declaración:
 *      <tipo de variable/objeto>[] < identificador >;
 * 
 * Nota. Cuando se declara un arreglo, es posible trabajarlo como un objeto para así acceder a sus atributos por defecto.
 *
 *  Inicialización:
 *      <identificador> = new < tipo de variable/objeto>[<# del tamaño>];
 *      
 *  Declaración e inicialización:
 *      <tipo de variable/objeto>[] <identificador> = new <tipo de variable/objeto>[<# del tamaño>];
 *      
 *  Nota. La inicialización de estos arreglos almacena algunos valores por defecto, según el tipo de dato u objeto.
 * 
 * La manera en la que se almacenan los valores en un arreglo, es mediante la asignación de valores en uno de los espacios 
 * reservados, conocidos como "elementos", del arreglo. La cantidad de elementos del arreglo dependerá de su tamaño y cada uno de 
 * estos tienen un índice numérico consecutivo para poder acceder a ellos. En este caso como el arreglo es unidimensional, el índice 
 * numérico estará conformado por un solo número, que siempre inicia con el "0". Para asignar un valor a cada uno de los elementos 
 * de un arreglo, se hace uso de la siguiente sintaxis:
 * 
 *      <identificador del arreglo> [<índice del elemento>] = < valor >;
 *
 * La siguiente sintaxis permite declarar el arreglo e inicializarlo asignando los valores que se deseen. Especificando el tamaño:
 *
 *      <tipo de variable/objeto>[] <identificador> = new int[<# del tamaño>] {<valor>,<valor>,...};
 *      
 * o sin especificar el tamaño:
 * 
 *      <tipo de variable/objeto>[] <identificador> = {<valor>,<valor>,...};
 *
 * Para acceder al valor almacenado en cada uno de los elementos del arreglo, es necesario utilizar la siguiente sintaxis:
 *
 *      <identificador del arreglo> [<índice del elemento>]
 *
 * Nota. Si se intenta acceder a un elemento con un índice que no existe en el arreglo, el compilador lanzará una excepción. 
 * Tampoco es posible agrandar el tamaño del array una vez inicializado.
 * 
 * ---------- Arreglos implícitos
 * 
 * Este tipo de arreglo es aquel donde no se declara el tipo de dato que almacenará pero si es necesario inicializarlo con los
 * valores que almacenará, los cuales deben ser del mismo tipo de dato. La sintaxis para crear un arreglo implícito es la siguiente:
 * 
 *      var <identificador> = new[] {<valor>, <valor>, ...};
 * 
 * ---------- Arreglos de clases anónimas
 * 
 * La sintaxis para crear este tipo de arreglos es:
 * 
 *      var <identificador> = new []
 *      {
 *      new{<atributo implícito>,<atributo implícito>,...},
 *      new{<atributo implícito>,<atributo implícito>,...},
 *      ...
 *      };
 *      
 * Cada objeto creado en el array forzosamente debe pertenecer a la misma clase anónima, respetando las reglas que esto conlleva.
 * 
 * ---------- Recorrido de arreglos con bucle FOR
 * 
 * Para asignar o acceder a los valores de un arreglo de manera secuencial con el bloque for, es necesario utilizar la variable de
 * iteración de la siguiente manera:
 * 
 *      for (<inicialización de la variable de iteración>;<expresión para salir del bucle>;<expresión de iteración>){
 *          <identificador del arreglo>[<variable de iteración>] = <valor>;
 *      }
 * 
 * Nota. Cabe destacar que el recorrido que haga el bucle for sobre el arreglo, con la variable de iteración, debe estar dentro del
 * rango de valores que tiene el índice del arreglo y no necesariamente debe recorre todo el arreglo.
 * 
 * ---------- Recorrido de arreglos con bucle FOREACH
 * 
 * Esta estructura de control está diseñada exclusivamente para recorrer cualquier estructura de datos de una forma más rápida y
 * sencilla. Para utilizarla solo basta con escribir en el argumento del bucle FOREACH una variable/objeto que almacene 
 * temporalmente en cada iteración los valores de cada elemento del arreglo, y después especificar el arreglo que se va a recorrer.
 * Es indispensable que la variable/objeto temporal, conocida como iterador, sea del mismo tipo de dato que tiene el arreglo. 
 * La sintaxis para usar este bucle es:
 *      
 *      foreach(<tipo de variable/objeto> <identificador> in <identificador de estructura de datos>)
 *      {
 *          <sentencias que se van a repetir, haciendo uso del iterador>
 *          ...
 *      }
 *      
 * o    
 * 
 *      foreach(<tipo de variable/objeto> <identificador> in <identificador de estructura de datos>)
 *          <sentencia que se van a repetir, haciendo uso del iterador>;
 * 
 * Nota: Cabe mencionar que este bucle solo sirve para "acceder a todos" los elementos del arreglo.
 * 
 * ---------- Extras de arreglos
 * 
 * - Es posible utilizar los arreglos como parámetros de métodos. Pero en este caso el parámetro estará referenciado al arreglo 
 * original, por lo tanto, si se modifican los valores del parámetro, también se harán las mismas modificaciones a los valores 
 * del arreglo de origen.
 * 
 * - Es posible retornar un arreglo con un método.
 * 
 */

using System;

namespace ConsoleApp_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de declaración e inicialización de un arreglo con valores por defecto
            int[] arreglo1;
            arreglo1 = new int[3];
            
            string[] arreglo2 = new string[5];

            //Asignación de datos en un elemento del arreglo

            arreglo2[0] = "a";
            arreglo2[1] = "b";
            arreglo2[2] = "c";
            arreglo2[3] = "d";
            arreglo2[4] = "e";
            

            //Acceder a un elemento de un arreglo

            Console.WriteLine(arreglo1[0] + arreglo2[4]);

            //Ejemplo de declaración e inicialización de un arreglo con asignación 

            int[] arreglo3 = new int[3] { 10, 14 , 2};  //Esta restringido a colocar obligatoriamente los 3 elementos 
            string[] arreglo4 = {"a","b","c","d","e"};  //El tamaño del arreglo esta definido por el número de elementos iniciados

            //Ejemplo de arrays implícitos

            var arregloImp = new[] {"José" , "Dany" };  //El tamaño del arreglo esta definido por el número de elementos iniciados

            //Ejemplo de Arrays de objetos

            Poligono miPoligono = new Poligono(5, "pentagono");

            Poligono[] miArregloDePoligonos = new Poligono[2];

            miArregloDePoligonos[0] = miPoligono;
            miArregloDePoligonos[1] = new Poligono(6, "hexagono");

            //Ejemplo de arreglo de objetos con clases anónimas

            var pelotas = new[] 
            {
                new{tipo = "basquetbol" , cantidad = 3 },
                new{tipo = "futbol" , cantidad = 10  }
            };

            //Ejemplo de acceso y asignación por recorrido de arreglos con bucle for
            char[] arreglo5 = { 'P', 'r', 'u', 'e', 'b', 'a' };
            int[] arreglo6 = new int[6];
            for (int i = 0; i < arreglo5.Length;i++)                    //Se utilizo un atributo de arreglo5 para saber su tamaño
            {
                Console.Write(arreglo5[i]);             //Accediendo a todos los elementos del arreglo
                arreglo6[i] = i * 4 + 2;                //Asignando valor a todos los elementos del arreglo
            }

            //Ejemplo de acceso por recorrido de arreglos con bucle foreach
            foreach(char elemento in arreglo5)
            {
                Console.Write(elemento);
            }

            //Ejemplo especial de arrays en métodos
            int[] arreglo7 = new int[3] { 12,22,32};
            metodoArreglo(arreglo7);            //Al mandar un arreglo por parámetros, se realiza una comunicación dinámica
            foreach (int iterador in arreglo7) Console.Write("\n"+iterador);     //Esta comunicación se demuestra en consola ya que el cambio
                                                                                //se aplicó para ambos arreglos

     
        }

        static void metodoArreglo(int[] arregloM)
        {
            for (int i = 0; i < arregloM.Length; i++)       //Se modifica el contenido del arreglo pasado por parámetro
            {
                arregloM[i] -= 2;
            }
        }

    }

    class Poligono
    {
        private int numDeLados;
        private string nombreDelPoligono;

        public Poligono(int numDeLados, string nombreDelPoligono)
        {
            this.numDeLados= numDeLados;
            this.nombreDelPoligono=nombreDelPoligono;
        }
        
    }
}
