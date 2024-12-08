namespace ConsoleApp113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Check Even Or ODD
            Console.WriteLine("Enter The Number : ");
            float num=Convert.ToSingle(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("The Number Is Even");
            }
            else
            {
                Console.WriteLine("The Number Is Odd");
            }
            #endregion
        }
    }
}