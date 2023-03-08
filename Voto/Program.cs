// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

int n1 = 0;
int n2 = 0;
int n3 = 0;

{
    Console.WriteLine("Ingresa un numero  ");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingresa otro numero ");
    n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingresa otro numero ");
    n3 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine("El valor mayor es  " + n1);
             }
    else if (n2 > n3)
            {
                Console.WriteLine("  El valor mayor es  " +n2);
            }
        else if (n3 > n1)
        {
            Console.WriteLine("El valor mayor es " +n3);
        }
   
    
    


    Console.ReadLine();
}