/*          
 *          Primera aplicacion
 * 
 * Visual studio es un entorno de desarrollo que es capaz de crear una gran variedad de aplicaciones con disntintos lenguajes de 
 * programacion, en este caso, se empezara el curso con el uso de aplicaciones de consola en el lenguaje C#. Las aplicaciones de 
 * consola se ejecuntan en la ventana de comandos de la computadora y unicamente trabajan con texto.
 * 
 * Al crear el proyecto o "solucion", como se llama en Visual studio, se creara una carpeta con el nombre de la solucion, dentro
 * de esta carpeta se encuentra otra carpeta con el mismo nombre, donde se encuentran los archivos del proyecto, y un archivo con
 * la extension .sln
 * 
 * C# es un lenguja "case sensitive", osea que es capaz de identificar las mayusculas y minusculas como diferentes sentencias de
 * texto.
 * 
 * 
 * C# se caracteriza por tener bloques los cuales se identifican por tener una llave de apertura y una de cierre. Todo aquello que 
 * se encuentre denro de estas llaves se llama bloque o ambito.
 * 
 * Todas las sentencias o comandos en C# deberan de terminar con un punto y coma, al menos que sea una clase, metodo o espacio de
 * trabajo. Este punto y coma le indica al compilador que ese comando o sentencia a terminado.
 * 
 * Visual Studio implementa un autocompletado de comandos, este recibe el nombre de intellinsence, para facilicar y visualizar las
 * alternativas de comandos que interpreta el entorno de desarrollo, se pueden utilizar las flechas de arriba y abajo para navegar
 * en la ventana desplegable del intellinsence. Para elegir una opcion se debe precionar TAB.
 * 
 * Al crear la solucion, se creara una archivo Program.cs que contendra el codigo que se muestra mas adelante.
 * 
 * La clase "Program" contiene el metodo "Main" o principal, el cual contendra todo el codigo principal. Al compilar este archivo,
 * el ejecutable obtenido empezara a realizar las intrucciones que esten dentro de este metodo, cada una de ellas en orden 
 * descendente.
 * 
 * 
 * 
 */

//Esta sentencia indica que se va utilizar el namespace "System" de la bliblioteca de clases o API. Este namespece contiene a la
//clase "Console".
using System;                       

//Un namespace es un "conjunto de código" donde una Clase no puede tener el mismo nombre o identificador que otra. Pero si se
//crea otro namespace, es posible repetir los identificadores.
namespace ConsoleApp_Primera_aplicacion     
{

    class Program
    {
        static void Main(string[] args)
        {
            // Metodo "WriteLine" de la instancia "Console" para escribir texto en la consola.
            Console.WriteLine("hola mundo");

            //Es posible eliminar el using System para escribir la sentencia de arriba de otra forma, donde primero se nombra 
            //el namespace System, seguido de la clase Console para finalizar con el metodo WriteLine.
            System.Console.WriteLine("Bienvenido al curso de C#");

        }
    }
}





