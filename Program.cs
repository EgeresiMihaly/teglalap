Console.WriteLine("Kérem a téglalap magasságát:");
int height = int.Parse(Console.ReadLine());

Console.Write("Kérem a téglalap szélességét:");
int width = int.Parse(Console.ReadLine());

int perimeter = 2 * (height+width);
int area = height*width;

Console.WriteLine("A téglalap kerülete :" +perimeter);
Console.WriteLine("A téglalap területe : " +area);
