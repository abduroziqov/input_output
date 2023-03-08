namespace input_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Kvadratning tomoni a berilgan.
            //S = a * a formula orqali yuzasi aniqlansin.
            Console.Write("Kvadratning tomonini kiriting a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            int S = a * a;
            Console.Write("Kvadratning yuzasi " + S + " ga teng");


        }
    }
}