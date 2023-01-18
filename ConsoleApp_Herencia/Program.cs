/* --------------------------------------------------- Herencia ----------------------------------------------------------------
* 
* La herencia es una característica de la POO que permite a una "clase padre" heredar o compartir sus atributos y métodos con sus
* "clases hijas". Como una clase hija puede ser clase padre de otra clase, existe una jerarquía de herencia, donde la clase con 
* mayor jerarquía se conoce como "superclase" y esta hereda todo su ámbito permitido (conforme al encapsulamiento) a sus clases 
* hijas, nietas, etc; las cuales se conocen como "subclases" o "clases derivadas".
*
* La sintaxis que se debe seguir para utilizar la herencia en clases es la siguiente:
*       class <identificador de la clase padre> 
*       {
*           <Atributos>
*           <Constructores>
*           <Métodos>
*       }
*       class <identificador de la clase hija> : <identificador de la clase padre>
*       {
*           <Atributos>
*           <Constructores>
*           <Métodos>
*       }
* 
* Una vez que se especifique cual es la clase padre e hija, será posible comprobar que un objeto de la clase hija puede acceder a
* los atributos y métodos que hereda de la clase padre.
* 
* Nota. Es importante mencionar que C# no soporta la herencia múltiple de clases, es decir que solo una clase
* puede ser heredada por otra.
* 
* ---------- Métodos heredados por defecto (Clase Object)
* 
* Todas las clases que se crean en C# heredarán por defecto algunos métodos provenientes de la "superclase cósmica" llamada
* "object". Estos métodos son:
* 
*       -Equals
*       -GetHashCode
*       -GetType
*       -ToString
*       
* Nota. En la documentación oficial de Visual Studio se describe el funcionamiento de cada método.   
* 
* ---------- Instrucción BASE
*  
*  Esta instrucción permite llamar al constructor de la clase padre desde la clase hija. Su uso es indispensable, ya que en caso de 
*  instanciar un objeto de la clase hija, se debe inicializar el estado del objeto tanto en la clase hija como en la clase padre. 
*  Su sintaxis es:
*  
*       public <Identificador constructor clase hija> (<declarar parámetros clase hija>) :base(<enviar parámetros a clase padre>)
*       {
*           <Sentencias>
*       }
*  
*  Nota. Los parámetros que se envían a la clase padre deben ser los suficientes para satisfacer al propio constructor y estos
*  forzosamente deben ser "alguno" de los parámetros que se declararon en el constructor de la clase hija.
*  
*  Nota2. La instrucción BASE también se puede utilizar para llamar métodos de la clase padre desde la clase hija.
*  
* ---------- Constructores utilizando herencia
* 
*  Si se desean colocar constructores en clases que van ha heredar código, es importante considerar que los constructores de
*  la clase padre se deberán heredar obligatoriamente a las clases hijas. Si la superclase está trabajando con su constructor por
*  defecto, entonces las subclases heredaran este constructor con la instrucción ":base()", la cual esta implícitamente en el 
*  el código. En caso de crear un constructor en la superclase, se debe seguir la siguiente sintaxis en la clase hija para que
*  no existan errores de compilación. Nótese que se hará uso de la instrucción "base" en el constructor de la clase hija.
*       
*       class <identificador clase padre> 
*       {
*           <Atributos>
*           
*           public <identificador clase padre> (<parámetros>)
*           {
*               <sentencias>
*           }
*           
*           <Métodos>
*       }
*       class <identificador clase hija> : <identificador clase padre>
*       {
*           <Atributos>
*           
*           public <identificador clase hija> (<parámetros clase padre>, <nuevos parámetros>) : base(<identificador parámetros clase padre>)
*           {
*               <sentencias>
*           }
*           
*           <Métodos>
*       }
* 
* ---------- Principio de sustitución de Liskov en herencia ( ... es siempre un ...)
* 
* Este principio establece que a una instancia de la clase padre se le puede asignar/instanciar un objeto de la clase hija.
* La forma de utilizar el principio de sustitución es con la siguiente sintaxis:
* 
*       <clase padre> <identificador> = new <constructor clase hija> (<parámetros>);
*       
*       <instancia clase padre> = <instancia clase hija>;
* 
* --------- Herencia en métodos usando polimorfismo (NEW, VIRTUAL, OVERRIDE)
* 
* Los métodos en una clase son versátiles cuando se trata de la herencia, ya que se pueden usar ciertas palabras reservadas para 
* modificar el comportamiento de estos.
*  
*  La palabra reservada "new" se utiliza para ocultar y reemplazar un método heredado, desde la clase hija. Para hacer esto, es 
*  necesario que el método de la clase padre e hija sean exactamente iguales en cuanto al tipo de dato, identificador y número de 
*  parámetros. Esta palabra debe escribirse como modificador en el lugar donde se declara el método.
*  
*  La palabra reservada "virtual" se escribe como modificador en un método de la clase padre para conceder el permiso a las clases
*  hijas de poder modificar este método heredado en su ámbito, esta palabra reservada se debe usar de la mano con la palabra 
*  reservada override. La palabra virtual se coloca en un método de la clase padre, antes del tipo de dato.
*  
*  La palabra reservada "override" se coloca en los métodos de las clases hijas (antes del tipo de dato) e indica que se va ha
*  modificar el método heredado de la clase padre donde se colocó la palabra reservada virtual.
*  
*  Nota. Las palabra reservadas "virtual y override" permiten que un objeto, al que se le aplico el principio de sustitución de
*  herencia, se comporte como un objeto de varias clases, a esto se le conoce como "polimorfismo".
*  
* ---------- Modificador de acceso PROTECTED
* 
* Es un modificador que solo puede ser utilizado en una jerarquía de clases y cumple una función intermedia entre los modificadores
* public y private. Es aplicable en los campos y métodos de una clase padre, permitiendo que solo las clases hijas tengan acceso a 
* estos campos y métodos "sin necesidad del uso de objetos".
* 
* Nota. Cuando existe una jerarquía de clases, la clase hija puede utilizar los métodos y atributos públicos de la clase padre, tal
* cual como ocurre cuando se utiliza el modificador de acceso PROTECTED. La diferencia es que fuera de la jerarquía de clases,
* las instancias no pueden utilizar los métodos protected pero si los public.
*  
*/

using System;

namespace ConsoleApp_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //----- Primer ejemplo
            /*
            Animales miAnimal = new Animales();
            Aves miAve = new Aves();
            Pinguino miPinguino = new Pinguino();

            miAnimal.respirar();    
            miAve.respirar();       //El método respirar fue heredado por la clase Animales
            miPinguino.respirar();  //El método respirar fue heredado por la clase Aves que a su vez lo heredo de la clase Animales
            
            miPinguino.procesoDeGestacion(); // El método procesoDeGestacion fue heredado por la clase Aves

            miPinguino.nadar();     //Solo los objetos de la clase pinguino pueden usar el método nadar
            */

            //----- Segundo ejemplo

            //Ejemplo de uso de constructores con herencia
            Animales miAnimal = new Animales("Humano");     //Los constructores se heredan para todas las subclases
            Aves miAve = new Aves("Águila");
            Pinguinos miPinguino = new Pinguinos("Piolin");

            miAnimal.respirar();        
            miAve.respirar();               //Se heredaron los atributos, constructores y métodos de la clase Animales
            miPinguino.respirar();
            miPinguino.nadar();

            //Ejemplo donde se aplica el principio de sustitución de herencia
            Aves miSegundaAve = new Pinguinos("Cabo");  
            miAnimal = miAve;               

            miSegundaAve.procesoDeGestacion();
            miAnimal.respirar();

            Animales[] almacenDeAnimales = new Animales[2] {miAnimal,miAve };   //Principio de sustitución con arreglos

            almacenDeAnimales[1].respirar();

            //Ejemplo de herencia en métodos con polimorfismo

            miAnimal = new Animales("Humano");     
            miAve = new Aves("Águila");
            miPinguino = new Pinguinos("Piolin");

            miAve.volar();          //Este método utiliza la palabra reservada "new" para sobreescribir
            miPinguino.volar();

            miAnimal.comer();      //Este método utiliza la palabra reservada "virtual y override" para modificar
            miAve.comer();
            miPinguino.comer();

            //Ejemplo de polimorfismo de una instancia

            Aves[] almacenDeAves = { miAve, miPinguino };               //Principio de sustitución con arreglos
            foreach (Aves animal in almacenDeAves) animal.volar();      //Ejemplo donde no funciona el polimorfismo

            Animales[] almacenDeAnimales2 =  { miAnimal, miAve , miPinguino };   //Principio de sustitución con arreglos
            foreach(Animales animal in almacenDeAnimales2) animal.comer();       //Se aplica polimorfismo para usar métodos de clases hijas

            //-----
        }
    }
    //----- Primer ejemplo
    /* Para utilizar este ejemplo, debe comenta o eliminar el código de los demás ejemplos
     
    class Animales : Object      //Superclase, que hereda de la superclase cósmica (no es necesesaría su escritura) 
    {
        public void respirar() { Console.WriteLine("Puedo respirar"); }
    }

    class Aves : Animales   //Subclase, hija de Animales
    {
        public void procesoDeGestacion() { Console.WriteLine("Puedo poner huevos"); }
    }

    class Pinguino : Aves  //Subclase, hija de Aves
    { 
        public void nadar() { Console.WriteLine("Puedo nadar"); }
    }
    */
    //----- Segundo ejemplo

    class Animales : Object      //Superclase, que hereda de la superclase cósmica (no es necesesaría su escritura) 
    {
        //Atributo
        private String nombreAnimales;
        //Constructor
        public Animales(String nombreAnimales) { this.nombreAnimales = nombreAnimales; }
        //Método
        public void respirar() { Console.WriteLine($"Mi nombre es {nombreAnimales} y puedo respirar"); }
        public virtual void comer() { Console.WriteLine($"Mi nombre es {nombreAnimales} y puedo comer"); }     //Uso de la palabra virtual 
    }

    class Aves : Animales   //Subclase, hija de Animales
    {
        //Atributo
        protected String nombreAves;       //Uso del modificador de acceso protected para que se pueda utilizar esta variable en la clase Pinguinos
        //Constructor
        public Aves(String nombreAves):base(nombreAves) { this.nombreAves = nombreAves; } //Uso de la sentencia "base"
        //Método
        public void procesoDeGestacion() { Console.WriteLine($"Mi nombre es {nombreAves} y puedo poner huevos"); }
        public void volar() { Console.WriteLine($"Mi nombre es {nombreAves} y puedo volar"); }
        public override void comer() { Console.WriteLine($"Mi nombre es {nombreAves} y puedo comer plantas, carne y semillas."); }  //Uso de la palabra override
        
    }

    class Pinguinos : Aves  //Subclase, hija de Aves
    {
        //Constructor
        public Pinguinos(String nombrePinguinos) : base(nombrePinguinos) { nombreAves = nombrePinguinos; }  //Uso de la sentencia "base"
        //Método
        public void nadar() { Console.WriteLine($"Mi nombre es {nombreAves} y puedo nadar"); }
        new public void volar() { Console.WriteLine($"Mi nombre es {nombreAves} y no puedo volar"); }          //Uso de la palabra new
        public override void comer() { Console.WriteLine($"Mi nombre es {nombreAves} y puedo comer peces"); }    //Uso de la palabra override
    }

    //-----
}
