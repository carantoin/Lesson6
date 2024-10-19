var points = new (double x, double y)[] 
{
    (3.5, 7.2),
    (-0.5, 1.2),
    (0.72, -3.12)
};
for (int i = 0; i < points.Length; i++)
{ 
    double x = points[i].x; 
    double y = points[i].y;
    bool isInside = (x * x <= 2 - y) && (y >= 0); 
        
    if (isInside)
    {
        Console.WriteLine($"Точка ({x}, {y}) лежит в области, ограниченной параболой y = 2 - x^2 и осью абсцисс.");
    }
        
    else
    {
        Console.WriteLine($"Точка ({x}, {y}) не лежит в области, ограниченной параболой y = 2 - x^2 и осью абсцисс."); 
    }
}