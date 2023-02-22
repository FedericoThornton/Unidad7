using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // VECTORES - ARRAY - ARREGLO
            int n;
            int [] numeros = new int [10];
            acu = 0;
          //   0 1 2 3 4 5 6 7 8 9  
          //  |7| | | | | |1| | | |


            numeros[6] = 1;
            numeros[0] = 7;

            a = numeros[6] + numeros[0];
            console.WriteLine(numeros[0]);

            // para escribir un vector

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine ("Ingrese la nota: ");
                n = int.Parse (Console.ReadLine());
                numeros [x] = n;

            // para leer un vector
            for (int x = 0; x < 10; x++)
            {
                acu += numeros [x];
                Console.WriteLine (" El valor de numeros es " = numeros[x]);



                // int
                // float (double, decimal)

                // double[] dias = new double[31];

                
                //vector de char
                char[] asistencias = new char [10];
                asistencia [0] = 'p';
                asistencia [1] = 'p';
                asistencia [2] = 'a';

                // cadena de caracteres es un vector de char en el que puedo ordenar caracteres con un sentido
                char [] frases = new char [10];
                // caracter BARRA CERO \0 le da fin a una cadena de caracteres
                frases [5] = '\0';
                //|h|o|l|a| |q|u|e| |t|a|l|\0| | | | | | | | 

                char [] nombre = new char [10];
                char letra;
                int indice = 0;
                console.WriteLine ("Ingrese su nombre letra por letra (termina con punto)");
                letra = char.Parse (Console.ReadLine());
                while (letra != '.' && indice < 10)
                {
                    nombre [indice] = letra;
                    letra = char.Parse (Console.ReadLine());
                    indice ++;

                }
                 nombre [indice] = '\0';

                 Console.Write ("Hola ");
                 indice = 0;
                 while (nombre [indice] != '\0')
                 {
                    Console.Write(nombre[indice]);
                    indice ++;

                    // STRING
                    string nombre;

                    Console.WriteLine ("Ingrese su nombre: ");
                    nombre = Console.ReadLine();
                    // no hay que hacer ninguna transformacion .Parse porque readline devuelve un dato string
                    Console. WriteLine ("Hola " + nombre);
                 }
                


            }

            }
        }  

    }
}
