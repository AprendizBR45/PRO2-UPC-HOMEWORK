public class MatrizEnteros
{
    public int[,] M; //Elemento de la Matriz
    public int fila;//Cantidad de filas
    public int columna;//Cantidad de columnas
    public int defaultValue = 99;//Valor por defecto

    //El constructor vacio
    public MatrizEnteros()
    {
        M = new int[0, 0];
        fila = 0;
        columna = 0;
    }

    //El constructor dandole la cantidad X y Y
    public MatrizEnteros(int cantX, int cantY)
    {
        //Dimensionar la matriz
        M = new int[cantX, cantY];
        columna = cantX;
        fila = cantY;
    }

    //Cargar la matriz con valores por defecto
    public void CargarMatrizDefault()
    {
        //Dar valores por defecto a la matriz
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                M[y, x] = defaultValue;
            }
        }
    }

    //Mostrar el contenido de la matriz
    public void MostrarMatriz()
    {
        string res = "";
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                int dato = M[y, x];
                res = res + dato + " , ";
            }
            res = res + "\n";
        }
        Console.WriteLine(res);
    } 

    
    public void MatrizSerie_Domino()
    {
        int datoA = 1;
        int datoB = 6;
        bool cambiar = true;
        for (int x = 0; x < columna; x++)
        {
            for (int y = 0; y < fila; y++)
            {
                if (cambiar)
                {
                    M[x, y] = datoA;
                    datoA++;
                    cambiar = false;
                }else{
                    M[x, y] = datoB;
                    datoB--;
                    cambiar = true;
                }

            }
        }
    }


}