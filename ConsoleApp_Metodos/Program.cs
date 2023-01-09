
/*-----------------------------------------------------      Métodos      -------------------------------------------------------
 * 
 * "Uso de secuencias de escape en Strings"
 * 
 * Para utilizar caracteres especiales en los Strings, es necesario el uso del carácter de escape "\" junto con una letra
 * que define lo que se desea hacer, a continuación se muestran las secuencias de escape más utilizadas.
 *     /<carácter reservado> ; utilizado para mostrar caracteres especiales reservados como las comillas dobles.
 *     /n ; utilizado para dar un salto de línea.
 *     /t ; utilizado para dar una tabulación.
 *     /u<hexadecimal del carácter en Unicode> ; utilizado para mostrar caracteres especiales que no se encuentran en el teclado.
 *     
 * 
 * "Strings literales o Verbatim Strings"
 * 
 * Los strings literales permiten interpretar  la escritura que se coloca dentro de las comillas para deterctar saltos de 
 * linea, tabulaciones, signos especiales, entre otras cosas. Para hacer uso de esto se debe colocar el simbolo @ seguido de
 * unas comillas dobles. Sintaxis: @"<string literal que se deseé colocar>"
 * 
 * --------------------------------------------------------------------------------------------------------------------------------
 * "Métodos"
 * Los métodos son un conjunto de código fuera del flujo de programa principal (Main) que poseen un nombre identificativo y permiten 
 * realizar una tarea especifica. Para que un método se ejecute, se debe definir dentro de una "Clase" y es necesario llamarlo 
 * en el programa principal. La manera en la que el método envía y resibe información hacia el programa principal u otro método es
 * a través de la sentencia "return" para enviar y los parámetros para recibir.
 * 
 * La sintaxis generalizada es la siguiente:
 * 
 *     <Modificador de acceso> <Tipo de dato> <identificador> (<Parámetros>, <Parámetros>,...) {
 *          <Cuerpo del método>
 *          return <valor>;
 *      }
 *     
 * Usando la sintaxis "expression-bodied" con el operador lambda "=>"
 *   
 *      <Modificador de acceso> <Tipo de dato> <identificador> (<Parámetro>,<Parámetro>,...) => <valor por retornar>;
 * 
 * Para que un método no devuelva un valor, se utiliza el tipo de dato "void". De este modo, no será necesario utilizar la sentencia 
 * return. Todo lo que se encuentre después del return, nunca se ejecutará ya que el flujo de ejecución del método termina ahí.
 * 
 * El concepto de "Modularización" consiste en dividir tu código principal en varias partes con la ayuda de los métodos.
 * 
 * El ámbito, alcance o contexto de un método hace referencia a todo el código que se encuentra dentro de las llaves de este. Si se
 * declara una variable dentro de las llaves de un método, se dice que el ámbito de esta variable es "local", por lo que no se podrá
 * utilizar esa variable fuera del alcance del método donde se declaró.
 * 
 * El flujo de ejecución del código dentro del contexto de los métodos es de arriba hacia abajo.
 * 
 * "Campos de una clase"
 * Existe un término nuevo útil en el uso de clases, el cual es llamado como "campos de clase", estos son variables que se declaran
 * en el ámbito de una clase, pueden ser accesibles y utilizables en los métodos de la clase sin importar el lugar en el que estos son 
 * declarados.
 * 
 * "Sobrecarga de métodos"
 * 
 * Esta es una característica del lenguaje c# que permite que se declaren dos métodos, con el mismo nombre, dentro de la misma 
 * clase.
 * 
 * Para hacer una sobrecarga de métodos, es necesario:
 *  -Diferente tipo de datos en los parámetros.
 *  -Diferente número de parámetros.
 * 
 * "Parámetros opcionales"
 * Si se inicializa un parámetro de un método, el lenguaje de programación entiende que ya se le esta asignando un valor por ende
 * interpreta que ya no es necesario ingresarlo nuevamente. Los paramatros opcionales se definen despues de los parametros 
 * obligatorios.
 * 
 * Las ambigüedades ocurren cuando dos métodos pueden corresponder a la misma llamada, la solución que da Visual Studio es que
 * ejecuta el método que más se adapte a la llamada realizada.
 * 
 */


using System;

namespace ConsoleApp_Metodos
{
   class Program
    {
        
        //El método Main es aquel donde se codifica el programa principal, ya que es aquí donde inicia el flujo de ejecución. Este 
        //método utiliza el tipo de dato void ya que no retorna ningún dato, y el modificador de acceso "static" lo utiliza para
        //que se pueda ejecutar el método sin que se tenga que crear un objeto.
        //El orden de los métodos extras con el Main no importa, ya que siempre se ejecutará inicialmente el método Main.
        static void Main(string[] args)
        {
            string miInformacion = "\tHola mi nombre es \"Luis\" \n \tTengo 20 años\n"; //Uso de caracteres especiales
            string miCorreo = @"    Mi correo electrónico es: 
                                    luis@hotmail.com";
            string signoEspecial = "\nLa fórmula general para resolver ecuaciones cuadráticas utiliza el signo \u00B1";
          
            Console.WriteLine(miInformacion + miCorreo + signoEspecial);

            //-------------------------------------------------------------------------------------------------------------------
            int numero3 = 2;
            Console.WriteLine($"\n \nEl resultado de la operación es: {operarNumeros(numero3)+multiplicacion(2,3)}" );
            miNombreCompleto(Console.ReadLine(),Console.ReadLine());
            Console.WriteLine("Mi edad es de " + edad +" años");
            miNombreCompleto(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.WriteLine("El cálculo realizado da como resultado: " + calculo(2,2.5,5));

        }

        //Para utilizar métodos fuera de la función principal se debe utilizar la palabra reservada static antes del tipo de dato.
        static double operarNumeros(int numero3)
        {
            double numero1 = 10, numero2 = 7, resta = numero1 - numero2 / numero3;
            return resta;
        }
        //Método que no retorna valor
        static void miNombreCompleto (string nombre,string apellido) 
        {
            Console.WriteLine($"Tu nombre completo es: {nombre} {apellido}"); 
        }
        //Método de una sola línea que retorna lo especificado
        static int multiplicacion(int num1, int num2) => num1 * num2;

        static int edad = 20; //Variable con ámbito de clase o Campo de la clase Program

        //Sobrecarga de método miNombreCompleto
        static void miNombreCompleto(string nombre, string apellido, string apellido2)
        {
            Console.WriteLine($"Tu nombre completo es: {nombre} {apellido} {apellido2}");
        }

        //Uso de parámetros opcionales
        static double calculo(int num1, double num2, int num3=3, int num4=5) => num1 + num2 - num3 * num4;

    } 
}


