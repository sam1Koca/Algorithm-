// Son örneğimizde de Recursion Fonksiyon Kullanrak Fibonacci dizisini yazdıralım.

public static void Main()
{
   int sayi = Int32.Parse(Console.ReadLine());
 
   for(int i = 0; i <= sayi; i++)
      Console.WriteLine(fibonacciHesapla(i));
}
 
public static int fibonacciHesapla(int sayi)
{
   if (sayi == 1 || sayi == 0)
      return 1;
 
   return fibonacciHesapla(sayi-1) + fibonacciHesapla(sayi - 2);
}