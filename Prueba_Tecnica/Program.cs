using System;
using System.Collections.Generic;
//using System.Object;
namespace Prueba_Tecnica
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }

    class Algoritmos
    {
        public string Array_Analisis(List<int>[] Listas)
        {
            int n_alto = 0;//almacena el numero mas alto
            var lista_mayor = new List<int>() ;//Es la lista que contiene mayor cantidad de numeros
            lista_mayor.Add(1);
            var lista_m = "";//Es un string que representa cada numero de la lista mayor


            foreach (List<int> lista in Listas)//Se obtiene cada lista
            {
                if (lista.Count > lista_mayor.Count) lista_mayor = lista;
                foreach (int numero in lista)//se obtiene cada numero de la lista
                {
                    if (numero > n_alto)
                    {
                        n_alto = numero;
                    }
                }
            }
            foreach (var numero in lista_mayor) //para retornar un string de la lista_m
            {
                lista_m = lista_m + numero.ToString();
            }

            return lista_m + "El numero mas alto es " + n_alto.ToString();
        }

        public int[] Fibonacci(int numero)
        {
            int[] fibonaci = new int[5];

            fibonaci[0] = numero;
            for (int x = 0; x < fibonaci.Length; x++)
            {
                if (x == 0) { fibonaci[x] = numero + (numero-1); continue; };//Para el primer Fibonacci el numero dado menos 1 como numero anterior y luego termina esa interacion
                fibonaci[x] = numero + fibonaci[x - 1];//numero antepenultimo menos el numero anterior
                numero=fibonaci[x-1];//almacenar el numero antepenultimo para la proxima iteracion

            }
            return fibonaci;
        }

        public string[] billetes(int monto)
        {
            var billetes = new int[] { 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1 };//Billetes Dominicanos ordenados por valor
            var desglose = new string[billetes.Length];//almacena una cadena por cada billete
            var cantidad = 0;//la cantidad de billetes 
            for (int x = 0; x < billetes.Length; x++)
            {
                while ((monto - billetes[x]) >= 0)//Comprueba 
                {
                    monto = monto - billetes[x];
                    cantidad++;
                }
                desglose[x] = "La cantidad de billetes es " + cantidad.ToString() + " del billete " + billetes[x].ToString() +" Total = " + (cantidad*billetes[x]);
                cantidad = 0;//Reiniciar conteo
                


            }
            return desglose;
        }
    }


}
