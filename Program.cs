int xa, xb, ya, yb, za, zb;
Console.Write($"Введите кординату x точки a: ");
int.TryParse(Console.ReadLine()!, out xa);  
Console.Write($"Введите кординату y точки a: ");
int.TryParse(Console.ReadLine()!, out ya);  
Console.Write($"Введите кординату z точки a: ");
int.TryParse(Console.ReadLine()!, out za);  
Console.Write($"Введите кординату x точки b: ");
int.TryParse(Console.ReadLine()!, out xb);  
Console.Write($"Введите кординату y точки b: ");
int.TryParse(Console.ReadLine()!, out yb);  
Console.Write($"Введите кординату z точки b: ");
int.TryParse(Console.ReadLine()!, out zb);  

int x = (xb - xa) * (xb - xa);
int y = (yb - ya) * (yb - ya);
int z =(zb - za) * (zb - za);
double ans = Math.Sqrt( x + y + z);
Console.Write($"Кординаты точек a и b = {ans}");

    
