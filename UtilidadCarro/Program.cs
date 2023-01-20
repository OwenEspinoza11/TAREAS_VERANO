using UtilidadCarro;
public class CalcularUtilidad
{
    public static void Main(string[] args)
    {
        CarroUtilidad utilidadC = new CarroUtilidad();

        double[,] uc = new double[3, 5];
        int col, fila;
        double ingreso,egreso,utilidadF;

        do
        {
            Console.WriteLine("Ingresos");
            ingreso = Convert.ToInt32(Console.ReadLine());

        } while (ingreso <= 0 || ingreso > 10);

        for (fila = 0; fila < 3; fila++)
        {

            do
            {
                Console.WriteLine("Precio del carro");
                uc[fila, 0] = Convert.ToDouble(Console.ReadLine());
                utilidadC.setUtilidad(uc);
            } while (uc[fila, 0] <= 12000 || uc[fila, 0] > 65000);

            do
            {
                Console.WriteLine("Egresos");
                uc[fila, 0] = Convert.ToDouble(Console.ReadLine());
                utilidadC.setUtilidad(uc);
            } while (uc[fila, 1] <= 0 || uc[fila, 1] > ingreso);

            uc[fila, 2] = uc[fila, 0] * uc[fila, 1];
            utilidadF = ingreso - uc[fila,2];

        }

        for (fila = 0; fila < ingreso; fila++)
        {
            for (col = 0; col < 5; col++)
            {
                Console.WriteLine("\n" + uc[fila, col]);
            }
            Console.WriteLine();

        }

        Console.WriteLine("La utilidad total es: " + utilidadF);

    }


}
