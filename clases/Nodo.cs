using System;
using System.Collections.Generic;
using System.Text;

namespace Pilas.clases
{
    class Nodo
    {
        public Object dato;
        public Nodo enlace;


        //Constructor 
        public Nodo(Object x)
        {//Pasando el primer dato
            dato = x;
            enlace = null; //Nulo porque es el pirmero nodo por lo que no tiene sucesor
        }
        //Segundo constructor
        public Nodo(Object x, Nodo nuevo)
        { //Pasando como parametro el dato y el nodo nuevo
            dato = x;
            enlace = nuevo;
        }

        //Metodos para que nos devuelva la informacion
        public Object getDato()
        { //Para que nos devuelva el dato
            return dato;
        }
        public Nodo getEnlace()
        { //Para que nos devuelva el enlace
            return enlace;
        }
        public void setEnlace(Nodo enlace)
        {
            this.enlace = enlace;
        }

    }
}

