//1.Hər biri 2 parametr qəbul edib və riyazi əməlləri yerinə yetiren method yazin.

//class Program
//{
//    public static void Main()
//    {

//        Console.WriteLine(Sum(5, 8));
//        Console.WriteLine(Product(4,20));
//        Console.WriteLine(Subtract(4,22));
//        Console.WriteLine(Divide(20,4));
//    }

//    public static int Sum(int n, int m)
//    {
//        return n + m;

//    }
//    public static int Product(int n, int m)
//    {
//        return n * m;

//    }
//    public static int Subtract(int n, int m)
//    {
//        return n - m;

//    }
//    public static int Divide(int n, int m)
//    {
//        return n / m;

//    }

//}








//2.Verilen arqumentlere uygun tek ve cut edeleri tapan method yazin.(14, 20, 35, 40, 57, 60, 100)

//class Program
//{
//    public static void Main()
//    {

//        Console.WriteLine(Number(14));
//        Console.WriteLine(Number1(20));
//        Console.WriteLine(Number2(35));
//        Console.WriteLine(Number3(40));
//        Console.WriteLine(Number4(57));
//        Console.WriteLine(Number5(60));
//        Console.WriteLine(Number6(100));
//    }

//    public static int Number(int n)
//    {
//        if (n % 2 == 0)
//        {
//            Console.Write("Cut ededdir:");
//        }
//        else
//        {
//            Console.Write("Tek ededdir:");
//        }
//        return n;

//    }
//    public static int Number1(int n)
//    {
//        if (n % 2 == 0)
//        {
//            Console.Write("Cut ededdir:");
//        }
//        else
//        {
//            Console.Write("Tek ededdir:");
//        }
//        return n;

//    }
//    public static int Number2(int n)
//    {
//        if (n % 2 == 0)
//        {
//            Console.Write("Cut ededdir:");
//        }
//        else
//        {
//            Console.Write("Tek ededdir:");
//        }
//        return n;
//    }
//    public static int Number3(int n)
//    {
//        if (n % 2 == 0)
//        {
//            Console.Write("Cut ededdir:");
//        }
//        else
//        {
//            Console.Write("Tek ededdir:");
//        }
//        return n;

//    }
//    public static int Number4(int n)
//    {
//        if (n % 2 == 0)
//        {
//            Console.Write("Cut ededdir:");
//        }
//        else
//        {
//            Console.Write("Tek ededdir:");
//        }
//        return n;

//    }
//    public static int Number5(int n)
//    {
//        if (n % 2 == 0)
//        {
//            Console.Write("Cut ededdir:");
//        }
//        else
//        {
//            Console.Write("Tek ededdir:");
//        }
//        return n;

//    }
//    public static int Number6(int n)
//    {
//        if (n % 2 == 0)
//        {
//            Console.Write("Cut ededdir:");
//        }
//        else
//        {
//            Console.Write("Tek ededdir:");
//        }
//        return n;

//    }
//}




//Array kimi



//class Program
//{
//    public static void Main()
//    {

//        ArrNum([14, 20, 35, 40, 57, 60, 100]);

//    }
//    public static void ArrNum(int[] n)
//    {

//        for (int i = 0; i < n.Length; i++)
//        {
//            if (n[i] % 2 == 0)
//            {

//                Console.WriteLine("Cut ededdir:" + n[i]);
//            }
//            else
//            {

//                Console.WriteLine("Tek ededdir:" + n[i]);
//            }
//        }
//    }

//}







//3.Verilmis arreyde elementlerin həm 4-ə, həm də 5-ə bölününen elementlerin cemini tapin.[14, 20, 35, 40, 57, 60, 100]

//class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine(ArrNum([14, 20, 35, 40, 57, 60, 100])); 
//    }
//    public static int ArrNum(int[] n)
//    {
//        int sum = 0;
//        for (int i = 0; i < n.Length; i++)
//        {
//            if (n[i] % 4 == 0 && n[i] % 5 == 0)
//            {
//                sum+=n[i];
//            }
           
//        }return sum;
//    }
//}







//4.Daxil edilmiş cümlədə daxil edilmis simvoldan nece eded olduğunu tapan Proqramın alqoritmini yazin.(Cumle serbestdir).

//class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine(Sentence(" Men C sharp oyrenirem", 'm'));
//    }
//    public static int Sentence(string n, char letter)
//    {
//        int count = 0;
//        n= n.ToLower();
//        letter = char.ToLower(letter);
//        for (int i = 0; i < n.Length; i++)
//        {
//            if (n[i] == letter)
//            {
//                count++;
//            }
//        }
//        return count;
//    }
//}