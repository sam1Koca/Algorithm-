// Bu örnekte de, Recursion Fonksiyon kullanarak 10 defa Ekrana Yazı yazınca duran program yazalım.

int counter = 0;
void Recursion()
{
   counter++;
   if(counter <= 10)
   {
      Console.WriteLine("Hello! I am Sayit.");
      Recursion();
   }
   else
   {
      return;
   }
}