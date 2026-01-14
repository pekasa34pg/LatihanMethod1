static void tambah (int a,int b)
{
 int c = 0;

    c = a + b;
  Console.WriteLine($"{a} + {b} = {c}");
}




static void kurang (int a,int b)
{
   int c = 0;

    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}






static void kali (int a,int b)
{
   int c = 0;

    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}




static void bagi (int a, int b)
{
    int c = 0;

    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah(10,2);

tambah(8, 9);

kurang(10,2);

kurang(90, 3);

kali(10,2);

kali(8,9);

bagi(10,2);

bagi(8, 6);
