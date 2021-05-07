using System;
using System.Collections.Generic;
using System.Text;

namespace Pilas.clases
{
    class PilaLineal
    {
        private static int TAMPILA = 49;
        private int cima;
        private Object[] ListaPila;
          
        //CONSTRUCTOR
        public PilaLineal()
        {
            cima = -1;//condicion de pila vacia
            ListaPila = new Object[TAMPILA];

        }

        public bool pilaLlena()
        {
            return cima == (TAMPILA - 1);
        }


        //OPERACIONES QUE MODIFICAN LA PILA
        public void insertar(Object elemento)
        {
            if(pilaLlena())
            {
                throw new Exception("Desbordamiento de pila Stack Overflow");

            }
            //incrementar puntero cima y vamos a insertar el elemento
            cima++;
            ListaPila[cima] = elemento;

        }


        public bool pilaVacia()
        {
            return cima == -1;
        }



        //Retorna un tipo char
        public Object quitarChar()
        {
            object aux;
            if (pilaVacia())
            {
                throw new Exception("La pila esta vacia, no se puede sacar");

            }
            aux = (object)ListaPila[cima];
            cima--;
            return aux;

        }

        //extraer elemento de la pila (pop)
        public Object quitar()
        {
            int aux;
            if(pilaVacia())
            {
                throw new Exception("La pila esta vacia, no se puede sacar");

            }

            //guardar el elemento en la cima
            aux = (int)ListaPila[cima];
            //decrementar el valor de cima
            cima--;
            return aux;
        }

        public void LimpiarPila()
        {
            cima = -1;

        }

        //operacion de acceso a la pila
        public Object cimaPila()
        {
            if(pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            return ListaPila[cima];
        }

        
    }
}
