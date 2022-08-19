using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Comp> comp = new List<Comp>()
            {
                new Comp(){Cod=1, Name="HP",    ProT="Intel" ,ProF=2.3,RAM= 16 ,Hds= 1024 ,Gcs=16,Cost=409990,Copi=3},
                new Comp(){Cod=2, Name="Huawei",ProT="AMD"   ,ProF=2.1,RAM= 16 ,Hds= 512  ,Gcs=8, Cost=52999, Copi=2},
                new Comp(){Cod=3, Name="DELL",  ProT="Intel" ,ProF=3.5,RAM= 32 ,Hds= 1024 ,Gcs=24,Cost=599990,Copi=1},
                new Comp(){Cod=4, Name="MSI",   ProT="Intel" ,ProF=3.6,RAM= 32 ,Hds= 512 , Gcs=8, Cost=170990,Copi=8},
                new Comp(){Cod=5, Name="iRU",   ProT="Intel" ,ProF=2.5,RAM= 16 ,Hds= 500 , Gcs=8, Cost=78990, Copi=5},
                new Comp(){Cod=6, Name="HP",    ProT="Intel" ,ProF=2.6,RAM= 16 ,Hds= 512 , Gcs=8, Cost=143100,Copi=10},
            };

            Console.Write("Введите процессор:");
            string name = Console.ReadLine();
            List<Comp> comp1 = comp.Where(x => x.Name == name).ToList();
            Print(comp1);

            Console.Write("Введите ОЗУ:");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Comp> comp2 = comp.Where(x => x.RAM >= ram).ToList();
            Print(comp2);
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
            List<Comp> comp3 = comp.OrderBy(x => x.Cost).ToList();
            Print(comp3);
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
            IEnumerable<IGrouping<string, Comp>> comp4 = comp.GroupBy(x => x.ProT);
            foreach (IGrouping<string, Comp> gr in comp4)
            {
                Console.WriteLine(gr.Key);
                foreach (Comp e in gr)
                {
                    Console.WriteLine($"{e.Cod} {e.Name} {e.ProT} {e.ProF} {e.RAM} {e.Hds} {e.Gcs} {e.Cost} {e.Copi}");
                }
            }
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
            Comp comp5 = comp.OrderByDescending(x => x.Cost).FirstOrDefault();
            Console.WriteLine($"{comp5.Cod} {comp5.Name} {comp5.ProT} {comp5.ProF} {comp5.RAM} {comp5.Hds} {comp5.Gcs} {comp5.Cost} {comp5.Copi}");
            Console.WriteLine();
            Comp comp6 = comp.OrderByDescending(x => x.Cost).LastOrDefault();
            Console.WriteLine($"{comp6.Cod} {comp6.Name} {comp6.ProT} {comp6.ProF} {comp6.RAM} {comp6.Hds} {comp6.Gcs} {comp6.Cost} {comp6.Copi}");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
            Console.WriteLine(comp.Any(x => x.Copi > 30));
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();
        }
        static void Print(List<Comp> comp)
        {
            foreach (Comp e in comp)
            {
                Console.WriteLine($"{e.Cod} {e.Name} {e.ProT} {e.ProF} {e.RAM} {e.Hds} {e.Gcs} {e.Cost} {e.Copi}");
            }
            Console.WriteLine();
        }
    }
}
