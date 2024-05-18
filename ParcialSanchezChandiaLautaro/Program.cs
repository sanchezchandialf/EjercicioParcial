using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialSanchezChandiaLautaro
{

    public class SistemaCorreo
    {

        public SistemaCorreo() { }
        public void EnviarCorreo(Correo correo, int cantidad,Correo[]correorespaldo)
        {
          
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese un remitente");
                string remitenteenviar = Console.ReadLine();
                 Console.WriteLine("Ingrese destinatario");
                 string destinatarioanviar = Console.ReadLine();
                 Console.WriteLine("Ingrese asunto");
                 string asuntoaenviar = Console.ReadLine();
                 Console.WriteLine("Ingrese el cuerpo del mensaje");
                string cuerpoaenviar = Console.ReadLine();
                 Console.WriteLine("mensaje enviado con exito"); 
                 Correo correocreado = new Correo(remitenteenviar, destinatarioanviar, asuntoaenviar, cuerpoaenviar);

                 correorespaldo[i] = correocreado;
            
            }

        }


    }

    public class Correo : ParcialSanchezChandiaLautaro.SistemaCorreo
    {
        public String Remitente;
        public String Destinatario;
        public String Asunto;
        public String Cuerpo;
        public Correo(string remitente, string destinatario, string asunto, string cuerpo)
        {
            this.Remitente = remitente;
            this.Asunto = asunto;
            this.Remitente = remitente;
            this.Destinatario = destinatario;

        }
        public Correo()
        {

        }
        public override string ToString()
        {
            return ("el remitente es:   " + Remitente +"  el destinatario:  " +Destinatario+ "   el asunto es:   "+Asunto+ "   por cuestiones de seguridad el cuerpo del mensaje no se puede observar");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Correo correaenviar = new Correo();
            SistemaCorreo sistemaCorreo = new SistemaCorreo();
            Console.WriteLine("Bienvenidos al correo es un honor poder ofrecerles servicios");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("a cuantos usuario desea mandar mensaje");
            Int32.TryParse(Console.ReadLine(), out int cantidad);
            Correo[] elementosEnviados=new Correo[cantidad];
            sistemaCorreo.EnviarCorreo(correaenviar,cantidad,elementosEnviados);
            foreach (var item in elementosEnviados)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("dese eliminar algun usuario? 1 para si 2 para no ");
            Int32.TryParse(Console.ReadLine(), out int resultado);
            if (resultado == 1)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("ingrese el nombre del remitente");
                string remitenteaborrar = Console.ReadLine();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("ingrese asunto");
                string asunto=Console.ReadLine();
                
                for (int i = 0; i < elementosEnviados.Length; i++)
                {
                    if (elementosEnviados[i].Remitente == remitenteaborrar &&elementosEnviados[i].Asunto==asunto)
                    {
                        int posicioneliminar = i;
                        Correo[] nuevoResguardo = new Correo[elementosEnviados.Length - 1];
                        Array.Copy(elementosEnviados, 0, nuevoResguardo, 0, posicioneliminar);
                        Array.Copy(elementosEnviados, posicioneliminar + 1, nuevoResguardo, posicioneliminar, elementosEnviados.Length - posicioneliminar - 1);
                        elementosEnviados = nuevoResguardo;
                    }
                }


            }
            else Console.WriteLine("fin programa muchas gracias por participar");


            Console.WriteLine("sus elementos enviados quedaron de la siguiente manera");
            foreach (var item in elementosEnviados)
            {
                Console.WriteLine(item);
            }

        }
    }
}



