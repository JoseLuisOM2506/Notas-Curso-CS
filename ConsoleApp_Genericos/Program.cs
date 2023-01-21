/*------------------------------------------Programación genérica------------------------------------------------------------
 * 
 * Este tipo de programación consiste en crear una clase genérica que sea capaz de trabajar con cualquier tipo de objeto o dato que 
 * uno le indique. De este modo se podrá reutilizar mucho código debido a la versatilidad de la clase.
 * 
 * ---------- Alternativa de programación genérica con herencia de la clase OBJECT
 * 
 * Como se recordará, gracias a la herencia es posible crear objetos de la clase OBJECT e inicializarlos con cualquier otro tipo de 
 * clase, entonces, si se crea una clase que trabaje en su ámbito con objetos de la clase OBJECT, se habrá obtenido lo que se 
 * conoce como clase genérica. Sin embargo hay algunos inconvenientes de hacer esto, como:
 *     - El uso continuo de casting para transformar al objeto OBJECT en otro tipo.
 *     - El código será cada vez más difícil de comprender.
 *     - No habrá posibilidad de comprobar errores en tiempo de compilación.
 *     
 * ---------- Creación de clases genéricas
 * 
 * Existe una sintaxis en C# para poder crear clases genéricas de una manera más sencilla y correcta, sin hacer uso de la herencia.
 * Para hacer esto, es necesario declarar un "parámetro genérico" en el argumento angular de la clase que deseemos, por convención 
 * se utiliza la letra "T" para identificar a el parámetro genérico, de la siguiente forma:
 * 
 *      class <identificador de la clase> <<parámetro genérico (letra T)>>
 *      {
 *          <Miembros de la clase>;
 *      }
 * 
 * Una vez declarado el parámetro genérico, este podrá ser utilizado en el ámbito de la clase como un tipo de objeto. De modo que
 * cuando se instancie la clase, se deberá especificar el tipo de objeto que reemplazara al parámetro genérico en cada línea de
 * código donde se utilizó.
 * 
 * Cuando se instancia esta clase genérica, se debe de utilizar la siguiente sintaxis para especificar el parámetro genérico:
 * 
 *      <clase> <<tipo de objeto>> <identificador > = new <constructor> <<tipo de objeto>> (); 
 *      
 * ---------- Crear restricciones en clase genéricas
 * 
 * Si se quiere evitar que una clase genérica trabaje con un tipo de objeto especifico, es necesario agregar una "restricción".
 * Dicha restricción estará ligada al parámetro genérico, donde se declarara que este solo puede ser sustituido por tipos de
 * objetos que implementen una cierta interfaz. La sintaxis para declarar una restricción es la siguiente:
 * 
 *      class <Identificador de la clase><<parámetro genérico>> where <parámetro genérico>: <Interfaz que debería implementar>
 *      {
 *      <Miembros de la clase>
 *      }
 *      
 */

using System;

namespace ConsoleApp_Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de uso de herencia para realizan programación genérica
            AlmacenObjetos archivos = new AlmacenObjetos(2);
            archivos.agregar("Rafael");
            archivos.agregar(9.8);

            string nombrePrimero = (string)archivos.getElemento(0);        //Estas obligado a realizan un casting para usar el dato
            double miNumero = (double)archivos.getElemento(1);
            Console.WriteLine(nombrePrimero + "/" + miNumero);

            //Segundo ejemplo

            AlmacenObjetos repositorio = new AlmacenObjetos(2);
            repositorio.agregar(new Personas("Julian"));
            repositorio.agregar(new Personas("Sebastian"));

            Personas primeraPersona = (Personas)repositorio.getElemento(0);     //Se realiza un casting 
            Console.WriteLine(primeraPersona.NOMBRE);

            //Ejemplo para usar clases genéricas
            AlmacenObjetos2<Personas> repositorio2 = new AlmacenObjetos2<Personas>(2);      //Se evitan los casting, usando clases genéricas
            repositorio2.agregar(new Personas("Julian"));
            repositorio2.agregar(new Personas("Sebastian"));
            Console.WriteLine(repositorio2.getElemento(1).NOMBRE);


        }
    }

    //Clase que se utiliza para usar la programación genérica, haciendo uso de la herencia con la clase OBJECT
    class AlmacenObjetos
    {
        //Atributos
        private Object[] datosElemento;
        private int i = 0;

        //Constructor
        public AlmacenObjetos(int z) { datosElemento = new Object[z]; }

        //Métodos
        public void agregar(Object obj)
        {
            datosElemento[i] = obj;
            i++;
        }
        public Object getElemento(int i) => datosElemento[i];
    }

    class Personas : IEdad
    {
        protected string nombre;
        protected int edad = 20;

        public string NOMBRE { get => nombre; }

        public Personas(string nombre) { this.nombre = nombre; }

        public int getEdad() { return edad; }
    }


    //Creación de clases genéricas para la programación genérica
    class AlmacenObjetos2<T> where T : IEdad              //Se coloca una restricción en el parámetro genérico para que solo acepte clases con la interfaz IEdad
    {
        //Atributos
        private T[] datosElemento;
        private int i = 0;

        //Constructor
        public AlmacenObjetos2(int z) { datosElemento = new T[z]; }

        //Métodos
        public void agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }
        public T getElemento(int i) => datosElemento[i];
    }

    //Interface que se usa para demostrar restricciones en clases genéricas
    interface IEdad
    {
        int getEdad();
    }
}
