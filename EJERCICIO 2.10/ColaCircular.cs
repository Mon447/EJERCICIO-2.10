using System;
using System.Windows.Forms;


namespace EJERCICIO_2._10
{

    public class ColaCircular
    {
        private int[] datos;
        private int frente;
        private int final;
        private int capacidad;
        private int contador;

        public ColaCircular(int tamano)
        {
            capacidad = tamano;
            datos = new int[capacidad];
            frente = -1;
            final = -1;
            contador = 0;
        }

        public bool EstaVacia() { return contador == 0; }
        public bool EstaLlena() { return contador == capacidad; }
        public int ContadorElementos() { return contador; }

        public void Enqueue(int valor)
        {
            if (EstaLlena())
            {
                throw new InvalidOperationException("La cola circular está llena. No se puede encolar.");
            }
            if (EstaVacia())
            {
                frente = 0;
            }

            final = (final + 1) % capacidad;
            datos[final] = valor;
            contador++;
        }

        public int Dequeue()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La cola circular está vacía. No se puede desencolar.");
            }

            int valorExtraido = datos[frente];
            frente = (frente + 1) % capacidad;
            contador--;

            if (EstaVacia())
            {
                frente = -1;
                final = -1;
            }
            return valorExtraido;
        }

        public int Peek()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La cola está vacía. No se puede ver el frente.");
            }
            return datos[frente];
        }

        public string MostrarEstado()
        {
            if (EstaVacia())
            {
                return "Cola Circular: [VACÍA]";
            }

            string resultado = "Cola Circular (Frente a Final): ";
            int indiceActual = frente;

            for (int i = 0; i < contador; i++)
            {
                resultado += $"[{datos[indiceActual]}] ";
                indiceActual = (indiceActual + 1) % capacidad;
            }
            return resultado + $"\nÍndices Internos: Frente={frente}, Final={final}, Capacidad={capacidad}";
        }
    }
}


   
