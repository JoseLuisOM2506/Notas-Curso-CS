/* --------------------------------------------- Delegados------------------------------------------
 *
 * Los delegados son funciones que delegan tareas a otras funciones, estos tienen mucha similitud con los apuntadores del lenguaje
 * C++. A si como existen referencias a objetos, un delegado se podría decir que es una referencia a un método.
 * 
 * En C# se utilizan los delegados para llamar a eventos, reducir el código al manejar diferentes proyectos y reutilizar mucho
 * código.
 * 
 * La sintaxis para declarar un delegado es:
 * 
 *      delegate <tipo de dato / objeto> <identificador del delegado>(<argumentos>);
 * 
 * Nota: Un delegado solo puede llamar a métodos con la misma estructura con la que se definio el delegado. Además, los delegados
 * pueden hacer referencia a cualquier método perteneciente al mismo archivo fuente donde se declaró.
 * 
 * Después de que se declare el delegado, por convención en la clase Program, es necesario crear una instancia del delegado que
 * apunte al método que se desea utilizar con el. La sintaxis para instanciar un delegado es:
 * 
 *      <identificador del delegado> <identificador objeto> = new <identificador del delegado>(<método al que apunta>);
 * 
 * Para utilizar el objeto delegado se debe hacer una llamada como si se tratara de un método.
 * 
 *      <identificador objeto> ();
 * 
 * Esta llamada permitirá apuntar al método instanciado. En el caso de querer cambiar el método al que apunta el delegado, se puede
 * volver a instanciar de la siguiente forma
 * 
 *      <identificador objeto> = new <identificador del delegado>(<método al que apunta>);
 * 
 * ---------- Delegados predicados
 * 
 * Son delegados que solo pueden devolver valores del tipo boolean (true o false). Se suelen utilizar para filtrar listas de valores
 * comprobando si una condición es cierta para un valor. Para utilizar un delegado predicado, se debe instanciar un objeto de la 
 * clase "Predicate" con la siguiente sintaxis:
 * 
 *      Predicate<<param generico>> <identificador del predicado> = new Predicate<<param generico>>(<método bool al que apunta>);
 * 
 * Después de instanciar el objeto delegado predicado, es posible utilizarlo en algunos métodos de las librerías de C# que 
 * solicitan este tipo de objetos como parámetros.
 * 
 * Nota. El parámetro genérico del objeto predicado debe ser del mismo tipo de dato que tiene el parámetro del método bool al va a
 * apuntar.
 * 
 * ---------- Expresiones lambda
 * 
 * Son funciones anónimas con parámetros que al definirse no necesitan ser nombradas y así simplifican código. Se suelen utilizar 
 * al crear delegados sencillos, expresiones LINQ query ,entre otras cosas.
 * La sintaxis es:
 * 
 *      <parámetro> => <expresión / sentencia>
 * 
 *      <parámetro> => {<sentencia>; <sentencia>; ...}
 *      
 *      (<parámetro>, <parámetro>, ...) => <expresión / bloque de sentencias>
 * 
 * Nota. Las sintaxis antes mostradas se deben utilizar para definir funciones anónimas dentro del argumento de otro método.
 * 
 * La expresión lambda puede ser utilizada en un método normal, ya definido, para retornar un valor. Como se muestra en la siguiente 
 * sintaxis.
 * 
 *      <modificador> <tipo de dato> <identificador del método> (<parámetros>) => <valor por retornar>;
 *      
 * ---------- Expresiones regulares
 * 
 * Son secuencias de caracteres que se usan en los string como un patrón de búsqueda, se utilizan para validar formularios, 
 * búsquedas en ficheros o BBDD, comprobación de entradas de usuario, entre otras cosas.
 * 
 * Algunas clases útiles para utilizar expresiones regulares son:
 *      -Regex (regular expression)
 *      -Match
 *      -MatchCollection
 *      -GroupCollection
 * 
 * El método más usado en expresiones regulares es:
 *      - Matches
 *      
 * Y la propiedad más util es:
 *      - Groups
 * 
 * Nota. Para conocer todas las expresiones regulares que hay en C# se recomienda la consulta de estas en la documentación oficial.
 * 
 * Para crear una expresión regular, es necesario escribir la secuencia de caracteres en una variable String y enviar esta variable 
 * al argumento del constructor de una instancia de la clase "Regex", como se muestra a continuación:
 * 
 *      string <identificador> = "<expresión regular>";
 * 
 * Nota. Para distinguir una secuencia de escape con una expresión regular, es necesario escribir antes de las comillas dobles el
 * símbolo @, (@"").
 *      
 *      Regex <identificador> = new Regex(<identificador del string donde está la expresión regular>);
 *      
 * Para buscar coincidencias entre un string cualquiera con la expresión regular creada, es necesario crear una instancia de la
 * clase "MatchCollection" e inicializarla de la siguiente manera:
 * 
 *      MatchCollection <identificador> = <identificador del objeto Regex>.Matches(<string por evaluar>);
 * 
 * La cantidad de coincidencias se almacenará en el atributo "Count" del objeto MatchCollection.
 * 
 *      
 */


using System;
using System.Text.RegularExpressions;               //Se agregó la libreria para usar expresiones regulares

namespace ConsoleApp_Delegados_Predicados_Lambdas_ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo para usar delegados
            ObjetoDelegado miDelegado = new ObjetoDelegado(MensajeInicial.AvisoInicial);    //Se instancia el delegado, apuntando al método

            miDelegado();       //Se hace una llamada al delegado

            miDelegado = new ObjetoDelegado(MensajeFinal.AvisoFinal);       //Se instancio el objeto nuevamente, apuntando a otro método

            miDelegado();       //Se hace una llamada al delegado

            SegundoObjetoDelegado miSegundoDelegado = new SegundoObjetoDelegado(MensajeInicial.AvisoInicial);

            miSegundoDelegado("Hola mundo");        //Llamada a un delegado con parámetros


            //Ejemplo para usar delegados predicados
            List<int> enteros = new List<int>();
            for (int i = 1; i <= 10; i++) enteros.Add(i);

            Predicate<int> miDelegadoPredicado = new Predicate<int>(getPares);      //Instanciación de un objeto Predicate que apunta a un método bool

            //Se utiliza un método especial de las listas, para encontrar todos los elementos que cumplan con el método al que apunta el predicado
            List<int> enterosPares = enteros.FindAll(miDelegadoPredicado);      //Como el método retorna una lista, se almacenan en una nueva.          

            foreach (int pares in enterosPares) Console.Write(pares + " ");
            Console.WriteLine();


            //Ejemplo para usar expresiones lambda

            OperacionMat miOperacion = new OperacionMat(factorial);     //Uso de método definido con expresión lambda
            Console.WriteLine(miOperacion(10));

            OperacionMat miSegundaOperacion = new OperacionMat(nume => nume * nume);      //Uso de expresión lambda en delegados
            Console.WriteLine(miSegundaOperacion(10));

            OperacionMat2 miTerceraOperacion = new OperacionMat2((num1, num2) => num1 + num2);  //Uso de expresión lambda con 2 parámetros en delegados
            Console.WriteLine(miTerceraOperacion(8, 9));

            List<int> numeros = new List<int> { 2, 4, 6, 7, 8, 9, 3, 1, 5 };           //Uso de expresión lambda en listas y predicados
            List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
            numerosPares.ForEach(par => Console.WriteLine(par));


            //Ejemplo de expresiones regulares

            string oracion = "Hola mi nombres es David, mi número de teléfono es (+52)329-494-0145, mi C.P. es 97060";
            string patron1 = "[D]";      //Expresión regular que busca las letras D


            Regex miRegex = new Regex(patron1);                                 //Se crea un objeto del tipo expresión regular
            MatchCollection miMatch = miRegex.Matches(oracion);                 //Se crea una colección del tipo match para instanciarlo

            if (miMatch.Count > 0) Console.WriteLine($"Se encontraron {miMatch.Count} coincidencias");
            else Console.WriteLine("No se encontro lo pedido");

            //Ejemplo con otros patrones
            string patron2 = @"\d{3}";             //Esta expresión regular permite buscar 3 dígitos adyacentes 
            expresionRegular(patron2, oracion);     //Este método solo agiliza la búsqueda para diferentes patrones

            string patron3 = @"número de teléfono | C.P.";      //Con el símbolo | se puede representar el operador lógico "o" para buscar ambos textos
            expresionRegular(patron3, oracion);

            string texto = "El repositorio donde se encuentra este apunte es: https://github.com/JoseLuisOM2506/Notas-Curso-CS";
            string patron4 = "https?://(www.)?github.com/JoseLuisOM2506/Notas-Curso-CS";     //El grupo ()? o ? se utiliza para hacer una coincidencia opcional
            expresionRegular(patron4, texto);
        }

        //Declaración de delegados
        delegate void ObjetoDelegado();
        delegate void SegundoObjetoDelegado(string msj);        //Declaración de delegado con parámetros

        //Delegado utilizados en el ejemplo de expresiones lambda
        delegate int OperacionMat(int num);
        delegate int OperacionMat2(int num1, int num2);

        //Método a utilizar con el delegado predicado
        static bool getPares(int num) => num % 2 == 0 ? true : false;

        //Método a utilizar con las expresiones lambdas
        public static int factorial(int num) => num == 1 ? num : num * factorial(num - 1);


        //Método a usar con expresiones regulares

        public static void expresionRegular(string patron, string texto)
        {
            Regex miRegex = new Regex(patron);      //Se crea un objeto del tipo expresión regular
            MatchCollection miMatch = miRegex.Matches(texto);                 //Se crea una colección del tipo match para instanciarlo

            Console.WriteLine("Número de coincidencias: " + miMatch.Count());
        }
    }

    //Clases para el ejemplo de delegados
    class MensajeInicial
    {
        public static void AvisoInicial() { Console.WriteLine("Hola, este es el mensaje inicial."); }
        public static void AvisoInicial(string msj) { Console.WriteLine(msj); }
    }

    class MensajeFinal
    {
        public static void AvisoFinal() { Console.WriteLine("Este es el mensaje final, adios."); }
        public static void AvisoFinal(string msj) { Console.WriteLine(msj); }
    }

}
