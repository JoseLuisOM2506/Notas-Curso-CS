/*--------------------------------------------Clases abstractas y selladas-------------------------------------------------
 * 
 * ---------- Clases abstractas
 * 
 * En una jerarquía de clases, la clase abstracta es aquella que solo puede hacer pocas cosas (tiene menor acceso a miembros), 
 * por ende, esta usualmente suele ser la superclase de la jerarquía. Estas clases tienen el mismo comportamiento que una interfaz
 * normal, difiriendo en que ahora se podrán declarar métodos abstractos (métodos que solo se definen) que obligan a las clases 
 * hijas a implementarlos y métodos normales, los cuales deben definirse.
 * 
 * La sintaxis de una clase abstracta es simple, ya que solo se debe usar la palabra reservada "abstract" antes de la palabra 
 * "class" de la clase que deseas convertir.
 * 
 *      abstract class <identificador>
 *      {
 *          <Atributos>
 *          <Métodos>
 *          <Métodos abstractos>
 *      }
 * 
 * Para declarar un método abstracto en una clase del tipo abstracto se debe utilizar la palabra "abstract" después del modificador
 * de acceso, como se muestra a continuación:
 * 
 *      <modificador de acceso> abstract <tipo de dato> <identificador> (<parámetros>);
 * 
 * Después de declarar el método abstracto, las clases hijas deberán definirlo con la siguiente sintaxis:
 * 
 *      <modificador de acceso> override <tipo de dato> <identificador>(<parámetros>)
 *      {
 *          <Sentencias>;
 *      }
 * 
 * Nota. Al igual que en las interfaces, no es posible instanciar objetos de la clase abstracta, pero si se puede utilizar el
 * principio de sustitución de herencia para asignar un objeto de la clase hija al objeto de la clase abstracta.
 * 
 * --------- Clases selladas (sealed)
 * 
 * Estas son clases que no son capaces de heredar sus miembros, para declarar una clase como sellada, se escribe la palabra 
 * reservada "sealed" antes de la palabra "class", como se muestra a continuación:
 * 
 *      sealed class <identificador>
 *      {
 *          <Atributos>
 *          <Constructores>
 *          <Métodos>
 *      }
 * 
 * ---------- Métodos sellados (sealed)
 * 
 * Cuando un método ha sido implementado en una jerarquía, ya sea por una clase abstracta o usando la palabra reservada virtual,
 * y se quiere evitar que este método sea sobrescrito más veces por las clases hijas, se hace uso de la declaración del
 * método sellado en la clase padre donde se quiere omitir la sobreescritura a las clase hijas. La declaración de un método sellado
 * se hace en el mismo método donde se usa palabra reservada "override". La sintaxis es:
 * 
 *          <Modificador de acceso> sealed override <tipo de dato> <identificador> ()
 *          {
 *              <Sentencias>
 *          }
 *

 */


using System;

namespace ConsoleApp_Clases_Abstractas_y_Selladas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Estudiante miEstudiante = new Estudiante();
            Trabajador miTrabajador = new Trabajador();

            miEstudiante.pensar();      //Uso del método normal heredado de la clase abstracta
            miEstudiante.getNombre();   //Uso del método abstracto implementado de la clase abstracta
            miTrabajador.getNombre();

            Personas miPersona = new Trabajador();      //Principio de sustitución con clases abstractas

            miPersona.pensar();
            miPersona.getNombre();      //Método obtenido a través del polimorfismo

            
        }
        
    }
  
    abstract class Personas
    {
        //Métodos normales
        public void pensar() { Console.WriteLine("Hola, soy capaz de pensar "); }


        //Métodos abstractos
        public abstract void getNombre();
    }

    class Estudiante : Personas
    {
        public override void getNombre() { Console.WriteLine("El nombre del estudiantes es: Alfonso"); }    //Se desarrolla el método abstracto
    }


    class Trabajador : Personas
    {
        //Se invalida la sobreescritura de esta clase en la herencia
        public sealed override void getNombre() { Console.WriteLine("El nombre del trabajador es: Alberto"); }

    }

    sealed class Ingeniero : Trabajador                //Esta clase no podrá heredar
    {

        
    }

}
