using Pilas.clases;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Pilas
{
    class Program
    {
        static void ejemploPilaLineal()
        {
            //PilaLineal pila;
            int x;
            int CLAVE = -1;
            PilaListaSimple listaEnla = new PilaListaSimple();

            Console.WriteLine("Ingrese numeros y para terminar -1");
            try
            {
                //pila = new PilaLineal();
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if(x!= -1)
                    {
                        listaEnla.Agregar(x);
                    }

                } while (x != CLAVE);

                Console.WriteLine("ORDEN INVERSO");
                listaEnla.inverso();

                int pausa;
                pausa = 0;

                while (!listaEnla.ListaVacia())
                {
                    x = (int)(listaEnla.eliminar());
                    Console.WriteLine($"Elemento:{x}");
                }
                //pila.insertar(900);
              
            }
            catch (Exception error)
            {
                Console.WriteLine("Error= " + error.Message);
            }
        }

        static void palindromo()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            String pal;
            PilaListaSimple listaEnla = new PilaListaSimple();

            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Teclee una palabra para ver si es ");
                pal = Console.ReadLine();

                //PARTE MODIFICADA
                string remplazada = Regex.Replace(pal, @"\s", "");
                string convertida = remplazada.ToLower();
                Regex reg = new Regex("[^a-zA-Z0-9]");
                string textoNormalizado = convertida.Normalize(NormalizationForm.FormD);
                string textoSA = reg.Replace(textoNormalizado, "");// texto sin acento
                //

                //creamos la pila con los chars
                for (int i = 0; i < textoSA.Length;)
                {
                    Char c;
                    c = textoSA[i++];
                    listaEnla.Agregar(c);
                }
                
                Console.WriteLine("ORDEN INVERSO: ");  
                listaEnla.inverso();
                //comprueba si es palindromo
                esPalindromo = true;

                int pausa;
                pausa = 0;

                for (int j = 0; esPalindromo && !listaEnla.ListaVacia();)
                {
                    Char c;
                    c = (Char)listaEnla.eliminarPal();
                    esPalindromo = textoSA[j++] == c; //evalua si la pos es igual 
                }
                listaEnla.LimpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {pal} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es ");
                }
                

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
            

        }

        static void EjemploPilaLista()
        {
            int x;  
            PilaListaSimple listaEnla;
            listaEnla = new PilaListaSimple();
            PilaLista pl = new PilaLista();
            listaEnla.Agregar(1);
            listaEnla.Agregar(5);
            listaEnla.Agregar(16);
            listaEnla.Agregar(217);
            listaEnla.Agregar(41);
            listaEnla.Agregar(19);

            //var xx = listaEnla.eliminar();
            //var xx = pl.quitar();

            //while (!listaEnla.ListaVacia())
            //{
            //    x = (int)(listaEnla.eliminar());
            //    Console.WriteLine($"Elemento:{x}");
            //}

            Console.WriteLine("ORDEN INVERSO: ");
            listaEnla.inverso();

            int pausa;
            pausa = 0;
        }

        static void Expresion()
        {
            Evaluador mat = new Evaluador();
            string exp;
            Console.WriteLine("Ingrese la expresion matematica: ");
            exp = Console.ReadLine();
            mat.evaluar(exp);
            
        }
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //ejemploPilaLineal();
            //palindromo();

            EjemploPilaLista();
            //Expresion();

        }
    }
}
