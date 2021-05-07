using System;
using System.Collections.Generic;
using System.Text;

namespace Pilas.clases
{
    class PilaListaSimple
    {
        public Nodo primero;
        public Nodo cola;
        int cima;

        //CONSTRUCTOR
        public PilaListaSimple()
        {
            primero = null;
            cola = null;
        }

        //METODO SI LA LISTA ESTA VACIA
        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //INSERTAR ELEMENTOS A LA LISTA
        public void Agregar(object dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (ListaVacia())
            {
                primero = nuevo;
            }
            else
            {
                nuevo.enlace = primero;
                primero = nuevo;
            }
            cima++;
        }


        //METODO PARA ELIMINAR EN EL PALINDROMO 
        public object eliminarPal()
        {
            char aux;
            if (ListaVacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (char)primero.dato;
            primero = primero.enlace;
            cima--;
            return aux;
        }


        //ELIMINAR 
        public object eliminar()
        {
            int aux;
            if (ListaVacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (int)primero.dato;
            primero = primero.enlace;
            cima--;
            return aux;
        }



        public void inverso()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.dato);
                actual = actual.enlace;
            }
        }

        public void LimpiarPila()
        {
            cima = -1;

        }

        //public void insertar(object name)
        //{
        //    Nodo dato = new Nodo(name);

        //    if (primero == null)
        //    {
        //        primero = dato;
        //        primero.enlace = null;
        //        cola = dato;
        //    }
        //    else
        //    {
        //        cola.enlace = dato;
        //        dato.enlace = null;
        //        cola = dato;
        //    }
        //}


        //public void insertarprimero(object dato)
        //{
        //    Nodo aux = new Nodo(dato);
        //    aux.enlace = primero;
        //    primero = aux;
        //    cima++;
        //}

    }
}
