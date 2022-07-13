// Bir sayının, n faktoriyelini Recursion Fonksiyon ile Bulalım

public static int Factorial(int number)
{
    if( number <= 1 ){
        // Gelen sayı 1 yada 1'den küçükse faktöriyeli 1'dir.

        return 1;
    }  
        

    else{
        //Yukarıdaki koşul çalışmaz ise ->  n * (n -1)! bul.

        return number * Factorial(number - 1);
    }                      
}
