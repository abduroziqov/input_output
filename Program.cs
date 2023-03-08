namespace input_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kvadratning tomoni a berilgan.
            //P = 4 * a formula orqali perimetri aniqlansin.
            Console.Write("Kvadratning tomonini kiriting a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            int p = 4 * a;
            Console.Write("Kvadratning peremetri " + p + " ga teng");


        }
    }
}