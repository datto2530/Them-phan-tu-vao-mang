using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap kich thuoc mang");          //nhap kich thuoc mang
            n = int.Parse(Console.ReadLine());
            int[] array = new int[n + 1];
            for (int i = 0; i < n; i++)                         //nhap kich thuoc mang
            {
                Console.WriteLine("Nhap phan tu mang");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mang co cac phan tu la: ");      //in ra man hinh mang da nhap
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }
            Console.WriteLine("Nhap so can chen: ");              //Nhap so can chen:
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vi tri can chen: ");          //Nhap vi tri chen:
            int p = int.Parse(Console.ReadLine());
            for (int i = n; i >= p ; i--)
            {
                array[i] = array[i - 1];
            }
            array[p -1] = x;                                     //Chen X vao vi tri can
            for (int i = 0; i < n; i++)                          //in ra toan bo mang bao gom ca vi tri lon nhat
            {
                Console.Write(array[i] + "\t");
            }
        }
    }
}