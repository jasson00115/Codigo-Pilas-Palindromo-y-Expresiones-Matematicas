using System;
using System.Collections.Generic;
using System.Text;

namespace Pilas.clases
{
    class Evaluador
    {

        public double evaluar(String infija)//METODO PARA EVALUAR EXPRESIONES
        {
            String posfija = convertir(infija); //convertir la expresion infija a posfija
            Console.WriteLine("La expresion posfija es: " + posfija);
            return evaluarPosFija(posfija);

        }

        private static int prioridadEnExpresion(char operador)//METODO PARA DEVOLVER LA PRIORIDAD
        {
            if (operador == '^') return 4;
            if (operador == '*' || operador == '/') return 2;
            if (operador == '+' || operador == '-') return 1;
            if (operador == '(') return 5;
            return 0;

        }

        private static int prioridadEnPila(char operador)
        {
            if (operador == '^') return 4;
            if (operador == '*' || operador == '/') return 2;
            if (operador == '+' || operador == '-') return 1;
            if (operador == '(') return 0;
            return 0;
        }

        private static double evaluarPosFija(String posfija)
        {
            PilaLineal pila = new PilaLineal();
            for (int i = 0; i < posfija.Length; i++)
            {
                char letra = posfija[i];
                if (!esOperador(letra))
                {
                    double num = Convert.ToDouble(letra + "");
                    pila.insertar(num);

                }
                else
                {
                    double num2 = (double)pila.quitarChar();
                    double num1 = (double)pila.quitarChar();
                    double num3 = operacion(letra, num1, num2);
                    pila.insertar(num3);
                }
            }

            return (double)pila.cimaPila();
        }

        private static bool esOperador(char letra)//METODO PARA SABER SI ES UN OPERADOR
        {
            if (letra == '*' || letra == '/' || letra == '+' || letra == '-' || letra == '(' || letra == ')' || letra == '^')
            {
                return true;
            }
            return false;
        }

        private static double operacion (char letra, double num1, double num2)
        {
            if (letra == '*') return num1 * num2;
            if (letra == '/') return num1 / num2;
            if (letra == '+') return num1 + num2;
            if (letra == '-') return num1 - num2;
            if (letra == '^') return Math.Pow(num2, num2);
            return 0;
        }

        private static String convertir(String infija)
        {
            String posfija = "";
            PilaLineal pila = new PilaLineal();
            for (int i = 0; i < infija.Length; i++)
            {
                char letra = infija[i];
                if (esOperador(infija[i]))
                {
                    if (pila.pilaVacia())
                    {
                        pila.insertar(letra);
                    }
                    else
                    {
                        int pe = prioridadEnExpresion(letra);
                        int pp = prioridadEnPila((char)pila.cimaPila());
                        if ( pe > pp)
                        {
                            pila.insertar(letra);
                        }
                        else
                        {
                            posfija += pila.quitarChar();
                            pila.insertar(letra);

                        }
                    }
                }

                else
                {
                    posfija += letra;

                }

            }
            while (!pila.pilaVacia())
            {
                posfija += pila.quitarChar();
            }
            return posfija; 
        }

    }
}
