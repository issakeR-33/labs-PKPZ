using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the circles:");
        Console.Write("R = ");
        int R = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Write the coordinates of the point:");
        Console.Write("x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        string result = Perevirka(x, y, R);
        Console.WriteLine(result);

        Console.ReadLine();
    }

    static string Perevirka(int x, int y, int R)
    {
        if (x <= 0 && y >= 0 && x >= -R && y <= R)
        {
            int d1 = (x + R) * (x + R) + (y - R) * (y - R);
            if (d1 > R * R) return "Tak";        
            if (d1 == R * R) return "Na meshi"; 
            return "Ni";                         
        }

        if (x >= 0 && y <= 0 && x <= R && y >= -R)
        {
            int d2 = (x - R) * (x - R) + (y + R) * (y + R);
            if (d2 > R * R) return "Tak";        
            if (d2 == R * R) return "Na meshi";  
            return "Ni";                         
        }

       
        return "Ni";
    }
}
