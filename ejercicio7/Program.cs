using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)


        {    
//1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
//Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

           
         //   int[] numeros = new int[10];

        //    for (int x = 0; x < 10; x++)
       //     {
        //        Console.WriteLine ("Ingrese un nro: ");
                // numeros [x] = int.Parse (Console.ReadLine());
                
          //  }
          //  int max = numeros [o];
          //  int pos = 1;
          //  for (int x = 0; x < 10; x++)
          //  {
           //     if (numeros[x] > max)
           //     {
           //         max = numeros [x];
            //        pos = x + 1;
            //    }
          //  }
           
         //  Console.WriteLine ("el maximo es: " + max);
         //  Console.WriteLine ("Y su posicion es " + pos);


           // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
          // Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
            
          //  float promedio;
         //   int acu = 0;
        //    int[] numeros = new int[5];

         //   for (int x = 0; x < 5; x++)
         //   {
       //         Console.WriteLine ("Ingrese un nro: ");
       //         numeros [x] = int.Parse (Console.ReadLine());
      //           acu+= numeros [x];
      //      }


       //     for (int x = 0; x < 5; x++)
      //      {
     //            promedio = acu / 5;
               
     //           if (numeros [x] > promedio)
       //         {
      //              Console.WriteLine ("los numeros mayores al promedio son: " + numeros [x]);
     //           }
     //       }

         // 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
          //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
          //Mostrar el resultado en pantalla. Ejemplo:
          //  CADENA FUENTE: “La mar estaba serena"
         //   CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
          //  CADENA RESULTADO: “Li mir estibi sereni"

         //   char[] frase = new char [30];
          // char letra1, letra2;
          //  int indice = 0;
          //  char letra;
            
          //  char letra;
          //  Console.WriteLine ("Ingrese una letra: ");
          //  letra = char.Parse (Console.ReadLine());
          //  while (letra != '0' && indice < 30)
          //  {
          //      frase [indice] = letra;
          //      Console.WriteLine ("Ingrese una letra: ");
          //      letra = char.Parse (Console.ReadLine());
          //      indice++;
        // /   }
         ///   frase [indice] = '\0';
         //   console.WriteLine ("La frase completa es: ");
          //  indice = 0;
         //   while (frase[indice] != '\0')
         //   {
         //     Console.write (frase[indice]);
         //     indice++;
         //   }
         //   console.WriteLine("ingrese letra a reemplazar");
          //  letra1 = char.Parse (Console.ReadLine());
         //    console.WriteLine("ingrese letra nueva");
         //   letra2 = char.Parse (Console.ReadLine());
         //   indice = 0;
        //    while (frase [indice] != '\0')
        //    {
        //      if (frase [indice] == letra1)
        //      {
        //        frase [indice] = letra2;
        //        indice++;
        //     }
        //    }
        //    Console.WriteLine ("la frase nueva es: ");
        //    indice =o;
        //    while (frase [indice] != '\0')
       //     {
        //      Console.write (frase [indice]);
       //       indice++;
        //     }

            //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
           // - Número de Artículo (1 a 15)
           // - Cantidad Vendida 

             // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
             // Se pide determinar e informar:
             // a) El número de artículo que más se vendió en total.
             // b) Los números de artículos que no registraron ventas.
             // c) Cuantas unidades se vendieron del número de artículo 10.

             int numeroArticulo;
             int cantidadVendida;
             int[] totalCantidadVendida = new int[15];
             for (int x = 0; x < 15; x++)
             {
                totalCantidadVendida[x] = 0;              
             }

             Console.WriteLine("ingrese numero de aticulo: ");
             numeroArticulo = int.Parse (Console.ReadLine());
             Console.WriteLine("Ingrese cantidad vendida: ");
             cantidadVendida = int.Parse (Console.ReadLine());

             while (numeroArticulo != 0)
             {


                totalCantidadVendida[numeroArticulo - 1] += cantidadVendida;

               Console.WriteLine("ingrese numero de aticulo: ");
               numeroArticulo = int.Parse (Console.ReadLine());
               Console.WriteLine("Ingrese cantidad vendida: ");
               cantidadVendida = int.Parse (Console.ReadLine());
             }

             // punto a
             int maxcantidad = cantidadVendida [0];
             int numeromax =1;
             for (int x = 0; x < 15; x++)
             {
             if (totalCantidadVendida [x] > maxcantidad)
             {
              maxcantidad = totalCantidadVendida[x];
              numeroArticulo = x+1;
             } 
              
             }
             Console.WriteLine("El producto mas vendido es: " + numeroArticulo + 'con la cantidad de: ' + maxcantidad);
            // punto b
            for (int x = 0; x < 15; x++)
            {
              if (totalCantidadVendida [x] == 0;)
            {
              Console.WriteLine ("el producto " + (x + 1) + "no tuvo ventas");
            }

            }

            // punto c
            Console.WriteLine ("la cantidad vendida del articulo 10 fue: " + totalCantidadVendida[9]);
            
        }
    }
}
