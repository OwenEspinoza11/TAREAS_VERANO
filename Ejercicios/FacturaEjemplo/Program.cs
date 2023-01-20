using FacturaEjemplo;
public class SimFactura
{
    public static void Main(string[] args)
    {
        Factura f = new Factura();

        double[,] fa = new double[10,3];
        int cp, col, fila;
        double stf = 0;
        double tf;


        do
        {
            Console.WriteLine("Cantidad de producto a gestionar");
            cp = Convert.ToInt32(Console.ReadLine());

        } while (cp <= 0 || cp > 10);

        for (fila = 0; fila < 10; fila++)
        {   

            do
            {
                Console.WriteLine("Cantidad por producto");
                fa[fila,0] = Convert.ToDouble(Console.ReadLine());
                f.setFact(fa);
            } while (fa[fila,0] <= 0 || fa[fila,0] > 3);

            do
            {
                Console.WriteLine("Precio por producto");
                fa[fila,0] = Convert.ToDouble(Console.ReadLine());
                f.setFact(fa);
            } while (fa[fila,0] <= 0);

            fa[fila,2] = fa[fila,0] * fa[fila,1];
            stf = stf + fa[fila,2];
        }

        tf = stf * 1.15;

        for (fila = 0; fila < cp; fila++)
        {
            for (col = 0; col < 3; col++)
            {
                Console.WriteLine("\n" + fa[fila,col]);
            }
            Console.WriteLine();

        }

        Console.WriteLine("El subtotal de la factura es: " + stf);
        Console.WriteLine("El total de la factura es: " + tf);


    }

}


