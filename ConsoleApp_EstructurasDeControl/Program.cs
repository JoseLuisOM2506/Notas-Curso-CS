/* --------------------------------------- Estructuras de control --------------------------------------------------------
 * Las estructuras de control permiten que el programa sea capaz de tomar decesiones por si solo para asi modificar el flujo
 * de ejecución.
 * 
 * 
 * ----------"Declaración de variables booleanas"
 * Las variables booleanas permiten almacenar un bit, es decir un cero o uno, solo que estos están representados con frases.
 * Para un bit igual a uno de utiliza la palabra "true" y para un bit igual a cero se usa la palabra  "false". La palabra
 * reservada para declarar una variable booleana es "bool".
 * Sintaxis:
 *  bool <nombre de la variable> = <true o false>;
 * 
 * ----------"Operadores lógicos"
 * Los operadores lógicos permiten realizar operaciones con los valores lógicos para obtener un nuevo valor lógico con relación
 * a la operacion hecha. Estos son:
 * 
 *      -NOT(negación): !
 *      -AND(multiplicación): &&
 *      -OR(suma): ||
 *      
 * ----------"Operadores de comparación"
 * Estos comparan dos valores para obtener un valor lógico nuevo que respresenta la relación establecida. Existen de diferentes 
 * tipos, estos son:
 *      
 *      -Igual que: ==
 *      -Diferente que: !=
 *      -Menor que: <
 *      -Menor o igual que: <=
 *      -Mayor que: >
 *      -Mayor o igual que: >= 
 *      
 * Existe un metodo de la clase String llamado "Compare", que ayuda a comparar cadenas de caracteres de una mejor manera. En caso
 * de que los dos strings sean iguales el método retorna un 0, sino retorna un -1. El tercer parametro sirve para deshabilitar la
 * sensibilidad de diferenciar mayusculas y minusculas
 *      
 * ----------"Estructuras de control selectivas"
 * Estas estructuras permiten cambiar el flujo de ejecución del programa mediante la seleccion de uno de los caminos de ejecución 
 * disponibles con ayuda de una expresión condicional.
 * 
 * ----------"Condición IF"
 * Verifica que la expresión condicional entre paréntesis sea verdadera, en caso de ser true se ejecuta el código del condicional, 
 * si no lo es, entonces se salta este código.
 *  Sintaxis:
 * 
 *      if(<Expresión condicional>){
 *          <Sentencia>;
 *          <Sentencia>;
 *          ...
 *      }
 *      
 *      if(<expresión condicional>) <Sentencia> ;
 * 
 * ----------"Condición IF-ELSE"
 * Verifica que la expresión condicional entre paréntesis sea verdadera, en caso de ser true entonces se ejecuta el código dentro 
 * del ámbito del "IF", sino lo es, entonces se ejecuta el código dentro del ámbito del "ELSE".
 *  Sintaxis:
 *  
 *      if(<Expresión condicional>){
 *          <Sentencia>;
 *          <Sentencia>;
 *          ...
 *      }
 *      else
 *      {
 *          <Sentencia>;
 *          <Sentencia>;
 *          ...
 *      
 *      }
 *      
 *      if(<expresión condicional>) <Sentencia> ;
 *      else <Sentencia> ;
 * 
 * ----------"Condición IF-ELSE IF"
 * Verifica que la expresión condicional entre paréntesis sea verdadera, en caso de ser true entonces se ejecuta el código dentro 
 * del ámbito del "IF", sino lo es, entonces verifica la segunda expresión condicional (ELSE IF) hasta llegar a la última condición que podrá
 * terminar en un ELSE. La peculiaridad de utilizar este tipo de estructura de control es que solo se podrá ejecutar el código de
 * la primera expresión condicional que se cumpla. En caso de cumplirse la primera, las demás ya no se verificarán, omitiendo su código.
 *  Sintaxis:
 * 
 *      if(<Expresión condicional>){
 *          <Sentencia>;
 *          <Sentencia>;
 *          ...
 *      }
 *      else if (<Expresión condicional>)
 *      {
 *          <Sentencia>;
 *          <Sentencia>;
 *          ...
 *      }
 *      else
 *      {
 *          <Sentencia>;
 *          <Sentencia>;
 *          ...
 *      }
 *      
 *      if(<expresión condicional>) <Sentencia> ;
 *      else if(<expresión condicional>) <Sentencia> ;
 *      else <Sentencia> ;
 * 
 * ----------"Condición switch"
 * Esta estructura permite realizar multiples comparaciones con el operador "==" a un solo valor de referencia y ejecutar el código
 * correspondiente al caso que se cumplio. Su funcionamiento es muy similar al de la condición "IF-ELSEIF".
 *  Sintaxis:
 *  
 *      switch(<valor referencia>)
 *      {
 *          case <valor por comparar>:
 *              <sentencias>
 *          break;
 *          case <valor por comparar>:
 *              <sentencias>
 *          break;
 *          ...
 *          default:
 *              <sentencias>
 *          break;
 *  }
 * 
 * Algunas cosas a considerar de esta estructura son:
 *  -Cada valor por comparar no se puede repetir.
 *  -Los valores por comparar deben ser int, char o string.
 *  -Todos los case deben de tener su respectivo break.
 *  -Se pueden sustituir los break por return o throw.
 * 
 * ----------"Estructuras de control iterativas"
 * Estas estructuras se ocupan para repetir un grupo de sentencias de forma determinada o indeterminada. Estas estructuras son:
 * 
 *  -Iteradores determinados:
 *      -For
 *      -Foreach
 *  -Iteradores indeterminados:
 *      -While
 *      Do-While
 * 
 * --------- Bucle WHILE
 * Permite ejecutar el código dentro el ámbito de este bucle si se cumple la expresión condicional, si aun se cumple  se
 * repetirá el código hasta que ya no se cumpla la condición.
 * Sintaxis:
 * 
 *      while(<expresión condicional>){
 *      <Sentencia>;
 *      <Sentencia>;
 *      ...
 *      }
 * 
 * --------- Bucle DO-WHILE
 * Permite ejecutar el código dentro el ámbito de este bucle, y si se cumple la expresión condicional se repetirá el código, 
 * iterando el mismo proceso hasta que la expresión condicional no se cumpla, donde ahora ya no se ejecutará el código del bucle.
 *  Sintaxis:
 *  
 *      do{
 *      <Sentencias>;
 *      <Sentencias>;
 *      ...
 *      }while(<Expresión condicional>);
 *  
 * --------- Bucle FOR
 * El bucle FOR permite repetir el código que este dentro de su ámbito un número determinado de veces, para esto, es necesario
 * crear una expresión condicional compuesta para el bucle, donde primero se inicializa una variable de iteración con un valor
 * de referencia, después se escribirá la expresión condicional sencilla que determinará si el código del bucle se debe repetir
 * o no, finalmente se escribirá una expresión de iteración que permita modificar la variable de iteración hasta que se cumpla la
 * expresión condicional.
 * 
 *      for(<inicialización de la variable de iteración>;<expresión condicional>;<expresión de iteración>){
 *      <Sentencia>;
 *      <Sentencia>;
 *      ...
 *      }
 *      
 * --------- Anidación de estructuras de control
 * Una característica interesante de las estructuras de control, es que estas permiten que dentro de su ámbito se declaren otras
 * estructuras de control similares o diferentes, a esto se le conoce como estructuras de control anidadas, y permiten que el flujo
 * de ejecución sea tan complejo como uno lo requiera.
 * 
 */

using System;


namespace ConsoleApp_EstructurasDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplos del uso de operadores lógicos y de comparación
            bool diaSoleado = false;
            Console.WriteLine(diaSoleado);          

            Console.WriteLine(!diaSoleado);         //Como se utiliza el operador !, el valor se niega y el resultado es true

            bool numeroMayor = 5 > 7;
            Console.WriteLine(numeroMayor);         //Como 5 no es mayor a 7, el resultado es false

            //---------------------------------------------------------------------------------------------------------------
            int miAltura = 210, tuAltura = 170;
            //Ejemplo de condición IF
            if (miAltura >= 180)
            {
                Console.WriteLine("¡Eres muy alto!");
            }
            if (tuAltura < 180) Console.WriteLine("¡No eres tan alto!");

            //Ejemplo de condición IF-ELSE
            if (miAltura >= 180)
            {
                Console.WriteLine("¡Eres muy alto!");
            }
            else
            {
                Console.WriteLine("¡No eres tan alto!");
            }

            if (tuAltura >= 180) Console.WriteLine("¡Eres muy alto!");
            else Console.WriteLine("¡No eres tan alto!");

            //Ejemplo de condición IF-ELSE IF
            Console.WriteLine("¿Cual es su edad? :");
            int edadUsuario = int.Parse(Console.ReadLine());
            if (edadUsuario >= 60) Console.WriteLine("Eres un adulto de la tercera edad");
            else if (edadUsuario >= 18) Console.WriteLine("Eres un adulto");
            else Console.WriteLine("Eres un niño/adolescente");

            //Uso del método "Compare" para Strings

            int comparacion = String.Compare("Juanito", "JuaNIto", false); 
            Console.WriteLine("La comparacion de strings dio como resultado: " + comparacion );

            //Ejemplo de condición switch
            Console.WriteLine("¿Te gustan los animales?");
            switch (Console.ReadLine())
            {
                case "si":
                    Console.WriteLine("¡SI! a mi tambien, creo que nos llevaremos bien");
                    break;
                case "no":
                    Console.WriteLine("¿NO? Creo que no me caes bien");
                    break;
                default:
                    Console.WriteLine("No entiendo lo que dices");
                    break;
            }
            //----------------------------------------------------------------------------------------------------------

            //Juego de "adivina el número que estoy pensando" para entender el funcionamiento de la estructura WHILE
            Console.WriteLine("Adivina el número entre el 1 y 10 que estoy pensando!");
            Random aleatorio = new Random();    //Se crea un objeto "Random" con el nombre "aleatorio"
                //Se utiliza el método "Next" para generar el número aleatorio y este valor se almacena en una variable entera.
            int numAleatorio = aleatorio.Next(1,10);    
            int numero = Int32.Parse(Console.ReadLine()) , intentos = 1;
            while (numero != numAleatorio)
            {
                Console.WriteLine("Ese no es el número, intentalo de nuevo.");
                numero = Int32.Parse(Console.ReadLine());
                intentos++;
            }
            Console.WriteLine($"¡Exacto!, el número es {numAleatorio}, te costo {intentos} intentos.");


            //Recepción de datos (filtrados) utilizando el bucle DO-WHILE
            int entero;
            do
            {
                Console.WriteLine("Dame un número entero del 5 al 10");
                entero = int.Parse(Console.ReadLine());
            } while (entero < 5 || entero > 10 );


            //Factorial de un número, utilizando los bucles FOR
            Console.WriteLine("¿A qué número deseas sacarle el factorial?");
            int numeroF = int.Parse(Console.ReadLine()), resultadoF = 1;
            for (int i = numeroF; i > 0; i--)
            {
                resultadoF *= i;
            }
            Console.WriteLine($"El resultado es: {resultadoF}");
        }
    }
}
