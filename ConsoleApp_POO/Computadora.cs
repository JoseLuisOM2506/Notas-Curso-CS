using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Este fichero se utiliza para ejemplificar la funcionalidad de la modularización de ficheros fuente
namespace ConsoleApp_POO
{
    //Continuación de la clase "Computadora" en un fichero diferente
    partial class Computadora
    {
        public void tieneMayorAlmacenamientoQue(Computadora param)
        {
            if (param.almacenamiento > this.almacenamiento )
                Console.WriteLine("No tiene mayor almacenamiento");
            else
                Console.WriteLine("Si tiene mayor almacenamiento");
        }
    }
}
