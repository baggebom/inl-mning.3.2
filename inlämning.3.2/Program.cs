using System;
namespace Upggift
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("har du slutat gymnasiet? svara med J eller N");
            string gymnasie = Console.ReadLine().ToLower();

            Console.WriteLine("hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (gymnasie == "j" && ålder < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");

            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }
            Console.ReadKey();
        }

    }
}
