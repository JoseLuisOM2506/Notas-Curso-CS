/*
 * ----------------------------------------        "Sintaxis básica"        -----------------------------------------------------
 * 
 * ----------"Comentarios"
 * 
 * Este lenguaje de programación permite utilizar comentarios para describir el código. Existen diferentes formas para poner un 
 * comentario las más comunes son:
 *  1.- Usar dobles barras //, para hacer un comentario que únicamente ocupe una línea de código.
 *  2.- Usar la nomenclatura que se ocupa en este comentario para utilizar más de una línea de código.
 * 
 * ----------"Identificadores"
 * 
 * Los identificadores son los nombres que se les da a algunos elementos del código para poder diferenciarlos, los elementos con
 * identificadores son:
 *  -Namespaces
 *  -Clases
 *  -Métodos
 *  -Variables
 *  -Constantes
 * 
 * Algunas reglas para nombrar identificadores son:
 *  -Solo se pueden utilizar letras, números y guiones bajos.
 *  -Deben comenzar por una letra  (recomendación).
 *
 * -------------------------------------------------------------------------------------------------------------------------------
 * 
 * ----------"Tipos de datos"
 *  
 * En c# se pueden tener almacenados diferentes tipos de datos. Estos se pueden clasificar de la siguiente forma:
 *  
 *  Por valor:
 *      -Primitivos:
 *          Enteros (Valores númericos enteros):
 *              Con signo (distingue los valores positivos y negativos), se clasifican por el tamaño:
 *                  sbyte
 *                  short
 *                  int: 32 bits
 *                  long: 64 bits
 *              Sin signo (no distingue los valores positivos y negativos), se clasifican por el tamaño:
 *                  byte
 *                  ushort
 *                  uint
 *                  ulong
 *                  
 *          Reales (Pueden almacenar números reales como racionales e irracionales), se clasifican por el tamaño:
 *              float: 32 bits (al inicializar la variable se debe colocar una f al final del número).
 *              double: 64 bits
 *              decimal: 128 bits (al incializar la variable se debe colocar una m al final del número).
 *              
 *          Booleanos (bool), puede obtener dos estados:
 *              true
 *              false
 *          
 *      -Estructuras
 *      -Enumerados
 *      
 *  Por referencia:
 *      string (Cadena de caracteres): 16 bits por cáracter
 *      
 *      
 * ----------"Variables"
 * 
 * Una variable es un elemento en código que se declara (crea) para reservar un espacio de memoria RAM con el identificador 
 * propuesto, en dicha variable se almacenará un valor (con el tipo de dato declarado) que podrá cambiar durante la ejecución 
 * del código.
 * 
 *  Algunas convenciones para declarar variables son:
 *      No comenzar el nombre de la variable con un guion bajo
 *      No crear más de una variable que se distinga por una solo letra
 *      Comenzar el nombre de la variable con letra minúscula
 *      Aplicar el método Camel/Case para nombrar las variables. Palabras diferenciadas con una letra mayúscula inicial.
 *      No utilizar notación húngara (<letra tipo de dato><nombre identificador>), por ejemplo "fsueldo".
 * 
 * Existen dos sintaxis para utilizar una variable, estas son:
 *  1.- Declarar: Declarar una variable se refiere a crear y construir la variable. Para declarar una variable se debe indicar 
 *  primero el tipo de dato y después escribir el identificador.
 *      Sintaxis: <Variable> <identificador>;
 *      Ejemplo: int dia;
 *      
 *  2.- Inicializar: Inicializar una variable hace referencia a almacenarle o asignarle un valor.
 *      Sintaxis: <identificador> = <valor que se le desea asignar>;
 *      Ejemplo: dia = 10;
 *  Es posible declarar la variable e inicializarla al mismo tiempo.
 *      Sintaxis: <Variable> <identificador> = <valor que se le desea asignar>;
 *      Ejemplo: int dia = 3;
 *      
 * 
 * Nota. Es importante remarcar que no es posible inicializar una variable sin antes declararla.
 * 
 * -------------------------------------------------------------------------------------------------------------------------------
 * Operadores aritméticos 
 * 
 * Son utilizados en la programación para operar de manera aritmética con las variables numéricas.
 * Existen los siguientes tipos:
 *  1.- Operador de suma "+"
 *  2.- Operador de resta "-"
 *  3.- Operador de multiplicación "*"
 *  4.- Operador de división "/"
 *  5.- Operador de modulo o residuo "%" , este permite obtener el residuo de una división entre dos números.
 * 
 * Operadores de asignación y de incremento
 * Los operadores de asignación realizan las mismas operaciones anteriores, la diferencia es que estos son capaces de asignar o
 * guardar el valor resultante de la operación en la primera variable escrita.  
 * 
 *  1.- Operador de asignación para la suma "+="                    ,equivalencia "x = x + y"
 *  2.- Operador de asignación para la resta "-="                   ,equivalencia "x = x - y"
 *  3.- Operador de asignación para la multiplicación "*="          ,equivalencia "x = x * y"
 *  4.- Operador de asignación para la división "/="                ,equivalencia "x = x / y"
 *  5.- Operador de asignación para el módulo o residuo "%="        ,equivalencia "x = x % y"
 * 
 * Los operadores de incremento se caracterizan por aumentar o disminuir el valor de una variable en una unidad, por lo que hay dos
 * tipos de sintaxis para utilizar:
 *  1.- Incremento "++"
 *  2.- Decremento "--"
 *  
 *  Cade destacar que el flujo de ejecución es de izquierda a derecha, entonces si el operador de incremento/decremento se utiliza
 *  como prefijo, primero se realizará la operación y luego se utilizará la variable en la sentencia especificada. En caso de que
 *  se utilice el operador de incremento/decremento como sufijo, entonces primero se utilizara la variable en la sentencia y 
 *  despues se realizará la operación definida.
 * 
 * -----------------------------------------------------------------------------------------------------------------------------
 * 
 * Formas de imprimir texto en la consola.
 * 
 * El operador "+" es el único que puede ser utilizado con el tipo de dato "string" y sirve para "concatenar" o unir varios tipos 
 * de datos en un solo string o cadena de caracteres.
 *      Por ejemplo:     Console.WriteLine("Hola me llamo" + nombre + "y tengo la edad de" + edad + "años");
 * 
 * Otra manera de imprimir texto es mediante la interpolación en un string, donde se utiliza el símbolo $ antes del string para 
 * indicar que este realizara una interpolación y cada vez que se desee ingresar el valor de una variable al string, se escribirán
 * unas llaves y dentro el nombre de la variable. Sintaxis: {<nombre de la variable>}.
 *      Por ejemplo:    Console.WriteLine($"Hola me llamo {nombre} y tengo la edad de {edad} años");
 *      
 * Otra forma de imprimir texto es mediante el uso de más argumentos en el método Console.WriteLine(), donde el primer argumento 
 * servirá para definir el string principal por imprimir y los demás argumentos serán para inicializar los parámetros del método y 
 * así incluirlos en el string principal cuando se requiera. Para incluir los valores de los parámetros en el string principal, 
 * es necesario utilizar la sintaxis {<número del parámetro (inciando en 0)>} en el string principal.
 *      Por ejemplo:    Console.WriteLine("Hola me llamo {0} y tengo la edad de {1} años",nombre,edad);
 *      
 * En caso de que no se requiera hacer un salto de línea cada vez que se imprima un dato en consola, se puede utilizar el 
 * método "Console.Write()".
 *      
 * ------------------------------------------------------------------------------------------------------------------------------
 * 
 * Variables implícitas
 * 
 * Se utilizan este tipos de variables para que el programa asigne el tipo de valor de la variable cuando se este ejecutando
 * la sentencia donde se inicializa. La palabra reservada que se utiliza para este modificador de variable es "var".
 * 
 * ------------------------------------------------------------------------------------------------------------------------------
 * 
 * Conversión explícita de variables o "Casting"
 * 
 * Cuando se trabaja con dos variables con tipos de datos diferentes, por ejemplo una suma de una variable entera con una float,
 * lo que daría un error de compilación; es necesario realizar una conversión manual del tipo de dato de alguna de las variables 
 * para que ambas tengan el mismo tipo de dato y así se pueda trabajar con ambas.
 * 
 *      La sintaxis del casting es:  (<tipo de dato>)<variable>;
 * 
 * Conversión implícita de variables
 * 
 * Esta forma de conversión se realiza automáticamente por el lenguaje C#, y depende mucho de las variables que se están utilizando.
 * Estas conversiones implícitas se pueden realizar con variables que sean del mismo tipo de dato pero con diferente tamaño.
 * 
 * En la documentación oficial de Visual Studio sobre C# se encuentra una tabla con las diferentes conversiones implícitas que se
 * pueden realizar.
 * 
 * Conversión de tipos de datos no compatibles
 * 
 * Se utiliza el método <tipo de dato>.Parse() para convertir un tipo de dato a otro que no sea compatible, por lo general se usa
 * para convertir strings a otro tipo de dato. Si la conversión se realiza de manera erronea, es posible que se genere una
 * excepción (error no controlado) en tiempo de ejecución.
 * 
 * ------------------------------------------------------------------------------------------------------------------------------
 * 
 * Solicitar la escritura de algo por teclado
 * 
 * Para solicitar la escritura de algo por teclado a un usuario, se utiliza el método "Console.ReadLine()". Lo que se verá en la
 * consola es una línea parpeante la cual indica un tiempo de espera para que el usuario tecle algo,una vez escrito algo, para 
 * seguir con el flujo del programa solo basta con oprimir la tecla "Enter".
 * 
 * Nota. Como el método Console.ReadLine() "retorna" un valor del tipo string, es necesario convertir este tipo de dato para
 * que así se pueda almacenar en variables numéricas.
 * 
 * -----------------------------------------------------------------------------------------------------------------------------
 * 
 * Constantes
 * 
 * Al igual que las variables, estas sirven para reservar un espacio en la memoria de la computadora, donde se guardará un valor
 * que no podrá cambiar durante toda la ejecución del programa una vez que se inicialice.
 * 
 * Para declarar constantes es necesario utilizar el modificador de variable "const", aclarando que los modificadores de variable
 * se escriben justamente antes del tipo de dato. Además, cada vez que se declare una constante es necesario inicializarla en la
 * misma sentencia.
 * 
 * Por convención, el nombre de las constantes se escribe en mayúsculas.
 * 
 * ------------------------------------------------------------------------------------------------------------------------------
 * 
 * Atajos de teclado con intellincense
 * 
 * Visual studio permite simplificar la escritura de algunas sentencias por medio del intellincense, por lo general la más usada
 * es:
 * 
 * cw -------------> Console.WriteLine
 * 
 * Al colocar estos comandos, se desplegará una pantalla para observar lo que se puede conseguir si es que se presiona dos veces
 * el botón TAB.
 * 
 * ------------------------------------------------------------------------------------------------------------------------------
 */

using System;

namespace ConsoleApp_Sintaxis_basica
{
    class Program
    {
        static void Main (string[] args)
        {
            int dia;    //Declaración de la variable "dia" del tipo entero
            dia = 10;   //Inicializando la variable "dia" con el valor 10
            int mes = 3;    //Declaracion e inicializacion de la variable mes, con el tipo de dato entero y el valor 3
            
            Console.WriteLine(dia); //Se imprime en la consola la variable dia
            Console.WriteLine(mes); //Se imprime en la consola la variable mes

            //Nota. Recuerde que el flujo de ejecución del programa inicia desde la primera línea de código de este método,
            //ejecutando cada sentencia en orden descendente hasta llegar a la última llave de su ámbito. De no respetar el orden
            //de ejecución, Visual Studio indicará que hay un error en el código, lo mismo ocurrirá si se compila el programa.

            //--------------------------------------------------------------------------------------------------------------------

            int practicaOperadores = 4 + 6;  // Se declara la variable y se inicializa con la suma 4 + 6
            practicaOperadores = practicaOperadores - 2; // Esta es una alternativa para no usar operadores de asignación
            practicaOperadores /= 2; // Se utiliza el operador de asignacion para la división

            Console.WriteLine("El resultado de utilizar los anteriores operadores da un valor de " + practicaOperadores-- + " unidades");

            practicaOperadores--; // Se decrementa el valor de la variable en una unidad
            practicaOperadores %= 2; // Se utiliza el operador de asignación para el módulo

            Console.WriteLine($"El resultado de utilizar los anteriores operadores da un valor de {++practicaOperadores} unidades ");

            //--------------------------------------------------------------------------------------------------------------------

            int altura1, altura2, altura3 = 12;      //Declaración de 3 variables del tipo entero e inicialización de la última declarada
            altura1=altura2= 14;      //Inicialización de 2 variables con el valor 14

            var peso = 10.3;              //Declaración implícita de la variable y inicialización con valor decimal.

            int miPeso = (int) peso;     //Casting para convertir en una variable decimal a entero de forma explícita.

            peso = miPeso;              //Conversión de una varible entera a decimal de forma implícita.

            Console.Write("Mi ");               //Otra forma de imprimir datos en pantalla, sin realizar un salto de línea despues
            Console.WriteLine("peso es: ");
            Console.Write(peso+ "\n");

            //--------------------------------------------------------------------------------------------------------------------

            string miNombre = Console.ReadLine();       //Se pide por consola el nombre del usuario y se guarda como string
            int numPerros = int.Parse(Console.ReadLine());  //Se pide por consola el numero de perros y se convierte el string que retorna
                                                            //a entero

            //--------------------------------------------------------------------------------------------------------------------

            const float PI = 3.1416f;                   //Se declara la constante pi de tipo double y se inicializa con el valor 3.1416.
            int radio = 10;
            double areaCirculo1 = PI * radio * radio;
            int radio2 = 13;
            double areaCirculo2 = Math.PI * Math.Pow(radio2,2); //Uso de un atributo y método de la clase Math 
            Console.WriteLine("Las áreas de los círculos son: \n {0} \n {1}", areaCirculo1, areaCirculo2);  //Otra forma de imprimir en 
                                                                                                            //consola

        }
    }
}
