/*----------------------------------------------------Excepciones------------------------------------------------------------------
 * 
 * Las excepciones en programación son una serie de errores que ocurren en tiempo de ejecución del programa y que el programador
 * debe controlar ya que el programa se detiene en el punto donde ocurrió el error. Visual Studio es capaz de mostrar la excepción 
 * que detuvo el programa en la aplicación de consola con un mensaje con los detalles del error.
 *      Algunas de estas excepciones son:
 *          -Memoria corrupta
 *          -Desbordamientos de pila
 *          -Sectores de disco duro defectuosos
 *          -Acceso a ficheros inexistentes
 *          -Conexiones de BBDD interrumpidas
 *          -Entre otros
 * 
 * Para controlar las excepciones que ocurren en nuestro programa se utiliza la estructura "TRY-CATCH".
 * 
 * ----------Estructura TRY-CATCH
 * Esta estructura se utiliza para "intentar" ejecutar un bloque de código que se encuentra en el ámbito del "TRY", si ese bloque de
 * código arroja una excepción acorde a la indicada en el argumento del CATCH, entonces se ejecutará el bloque de código que
 * pertenece al ámbito del CATCH.
 * Sintaxis:
 * 
 *      try{
 *       <Sentencia>;
 *       ...
 *      }
 *      catch(<Clase de la excepción deseada> <Identificador>){
 *       <Sentencia>;
 *       ...
 *      }
 *      catch(<Clase de la excepción deseada> <Identificador>){    //Se puede agregar cuanto bloques catch se requieran
 *       <Sentencia>;
 *       ...
 *      }
 *  
 *  Nota. Los objetos creados en el argumento de bloque catch tienen la posibilidad de guardar en el atributo ".Message", como 
 *  string, un mensaje con información de la excepción que acaba de ocurrir.
 *      
 *  Otra forma más sencilla de utilizar el bloque TRY-CATCH es:
 *      
 *      try{
 *       <Sentencia>;
 *       ...
 *      }
 *      catch{                      // El objeto que captura es de la clase "Exception"
 *       <Sentencia>;
 *       ...
 *      }
 *      
 * ----------Tipos de excepciones por jerarquía (Herencia de clases)
 * - Exception:
 *      - SystemException:
 *          - FormatException. Permite capturar excepciones que se originan por errores de formato en variables.
 *          - OverFlowException. Permite capturar excepciones ocasionadas por sobrepasar el almacenamiento de memoria de una variable.
 *          - Etc.
 * 
 * Nota. A pesar de que la clase "Exception" es capaz de capturar todas las excepciones posibles, en ocasiones se requiere que
 * el programa ejecute diferentes líneas de código para diferentes excepciones.
 * 
 * ----------Filtros de excepciones
 * Para excluir una excepción especifica de una clase genérica, como si se tratase de un filtro, se utiliza la siguiente sintaxis:
 * 
 *      try{
 *       <Sentencia>;
 *       ...
 *      }catch(<Clase de la excepción deseada> <Identificador>) when (<objeto anterior>.GetType() != typeof(FormatException)){
 *       <Sentencia>;
 *       ...
 *      }
 *      
 * ----------Obtención de excepciones implícitas
 * En ocasiones el compilador es capaz de capturar algunas excepciones que suelen ocurrir comúnmente para así aumentar el 
 * rendimiento del programa. Por ejemplo, cuando se realizan operaciones con números enteros grandes y ocurre un desbordamiento, 
 * en este caso, lo que hace el compilador es almacenar un valor cualquiera a la variable que se acaba de desbordar.
 * 
 * Sin embargo, en ocasiones es necesario evitar este comportamiento ya que en programas muy grandes podría provocar errores mas 
 * graves. Para esto se utiliza el bloque conocido como CHECKED.
 * 
 * ------------- Bloque CHECKED
 * Esta expresión revisa el código entre su ámbito para lanzar una excepción con las excepciones implícitas que omite el compilador.
 * Sintaxis:
 * 
 *      checked{
 *       <Sentencias para revisar>
 *       ...
 *      }
 * 
 * O si solo se quiere evaluar una sentencia:
 * 
 *      checked(<Sentencia>);
 * 
 * ------------- Bloque UNCHECKED
 * Es lo contrario al bloque checked, en este caso en su ámbito evita las excepciones implícitas que ya omite el compilador.
 * Sintaxis:
 * 
 *      unchecked{
 *       <Sentencias para revisar>
 *       ...
 *      }
 * 
 * O si solo se quiere evaluar una sentencia:
 * 
 *      unchecked(<Sentencia>);
 * 
 * 
 * Nota. El bloque checked y unchecked solo funcionan con tipos de dato int y long.
 * 
 * ----------Clausula "throw" para lanzar excepciones
 * Esta sentencia es de utilidad para forzar al compilador a que lance una excepción que deseemos. Su sintaxis es:
 * 
 *      throw new <Nombre de la excepción>();
 * 
 * ----------Bloque FINALLY
 * Este bloque se utiliza para garantizar que se ejecute un grupo de código muy importante, despues de que se ejecute el bloque 
 * TRY o CATCH. Esto se utiliza comunmente cuando se trabaja con ficheros o bases de datos. Su sintaxis es:
 *      
 *      try{
 *       <Sentencia>;
 *       ...
 *      }
 *      catch(<Clase de la excepción deseada> <Identificador>){
 *       <Sentencia>;
 *       ...
 *      }
 *      finally{    
 *       <Sentencia>;
 *       ...
 *      }
 *       
 * 
 */

using System;

namespace ConsoleApp_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo para demostrar el uso del bloque TRY-CATCH
            int numEntero = 0, repetir;
            Console.WriteLine("Ingrese solo un número entero");

            do
            {
                repetir = 0;
                try
                {
                    numEntero = int.Parse(Console.ReadLine());
                }
                catch (FormatException exFormato)
                {
                    Console.WriteLine("No has ingresado un número entero, intentalo de nuevo: ");
                    repetir = 1;
                }
                catch (OverflowException exTamaño)
                {
                    Console.WriteLine("Has ingresado un número entero muy grande, intentalo de nuevo: ");
                    repetir = 1;
                }
            } while (repetir == 1);

            Console.WriteLine("El número entero que ingresó es: " + numEntero);

            //Uso de clase Excepcion que permite capturar cualquier excepción.
            //En este caso es necesario que el orden de los bloques catch empiece con la excepción más específica a la
            //menos específica, según la jerarquía de excepciones.
            Console.WriteLine("Ingrese solo un número entero");
            try
            {
                numEntero = int.Parse(Console.ReadLine());
            }
            catch (FormatException exFormato)
            {
                Console.WriteLine("No has ingresado un número entero");
            }
            catch (Exception exGeneral) when (exGeneral.GetType()!=typeof(OverflowException)) //Se ignora la excepción OverFlow
            {
                Console.WriteLine("Ha ocurrido un error");
                Console.WriteLine(exGeneral.Message);
            }
            catch(OverflowException exTamaño)
            {
                Console.WriteLine("Has ingresado un número entero muy grande");
            }

            //---------------------------------------------------------------------------------------------------------------------
            //Uso de excepciones implícitas, bloque CHECKED y UNCHECKED
            int numero1 = int.MaxValue, resultado1 = numero1 + 1;
            Console.WriteLine($"{numero1}    {resultado1}");
            checked
            {
                int numero2 = int.MaxValue, resultado2 = unchecked(numero2 + 2);
                Console.WriteLine($"{numero2}    {resultado2}");
            }
            //--------------------------------------------------------------------------------------------------------------------
            //Uso de la clausura Throw

            Console.WriteLine("Ingrese un número del 1 al 5");
            int rango = int.Parse(Console.ReadLine());
            if (rango < 1 || rango >5)
            {
                throw new ArgumentOutOfRangeException();
            }

            //---------------------------------------------------------------------------------------------------------------------

            //Uso del bloque finally con ficheros

            //Se crea un objeto del tipo "StreamReader" para almacenar los datos del fichero
            System.IO.StreamReader fichero = null;      

            try
            {
                string lineaPorLeer;
                string path = @"TextFile1.txt";     //El fichero se encuentra en la carpeta "bin" del proyecto, junto al .exe.

                //Se inicializa el objeto con su constructor, enviando la direccion del archivo
                fichero = new System.IO.StreamReader(path); 

                //El siguiente bucle se utiliza para leer, guardar e imprimir el contenido del fichero 
                while((lineaPorLeer=fichero.ReadLine()) != null)    
                {
                    Console.WriteLine(lineaPorLeer);
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Ocurrio un error al intentar leer el fichero");  
            }
            finally
            {
                //Se cierra el fichero en este bloque para asegurarse de que esto ocurra
                if (fichero != null ) fichero.Close();       
            }
        }

        
    }
}