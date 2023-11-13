using System;

class A {
    static void Main(string[] args){
        int tam = 5; // Tamaño del array bidimensional
        int[,] genArray = new int[tam, tam]; // Array bidimensional (No utilizado)

        int p = 0; // Numero a poner en el array del 1 - 25

        int x = 0; // Index de las filas
        int y = 0; // Index de las columnas

        int vueltas = 0;

        while (y < tam){
            if (genArray[x, y] > 0){
                if (x < tam-1) {
                    x++;
                    continue;
                } else {
                    y++;
                    continue;
                }
            }
            
            p++;
            genArray[x, y] = p;

            if (y > 0 && y % 2 == 1){
                if (x > 0 && x % 2 == 1){
                    x--;
                    y++;
                } else {
                    if (x < tam-1) x++;
                    y--;
                }
            } else {
                if (y == tam-1)
                    if (x == 0){
                        x++;
                        continue;
                    }

                if (x > 0) {
                    if (x % 2 == 1){
                        x++;
                        y--;
                        if (y > 0 && y % 2 == 1) y--;
                    } else {
                        if (y == tam-1) continue;
                        else x--;
                    }
                }
                
                y++;
            }
        }

        // Presentacion en consola

        int f = 0;
        foreach (int child in genArray){
            if (vueltas == 0) Console.Write("[ ");
            
            Console.Write((f > 0 ? ", " : "") + (child < 10 ? child.ToString() + " " : child.ToString()));
            f++;
            
            vueltas++;

            if (vueltas == tam){
                f = 0;
                Console.Write(" ]");
                Console.WriteLine();
                vueltas = 0;
            }
        }
    }
}