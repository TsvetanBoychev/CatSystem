using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatSystem
{
    class CatSystemStart
    {
        static void Main()
        {
            var peshoOwner = new Owner("Pesho", "Ivanov");
            var goshoowner = new Owner("Gosho", "Ivanov");
            var cat = new Cat(CatColor.Yellow);
            var anothercat = new Cat(CatColor.Black);
            var YetAnotherCat = new Cat(CatColor.Brown);

            peshoOwner.AddCat(cat, "Maca");
            peshoOwner.AddCat(anothercat, "Sylvestyr");
            Console.WriteLine(peshoOwner.AllCats);
           



            //peshoOwner.IncreaseAge(); //Eми, така, пич, се викат методи от класовете
            //Console.WriteLine(peshoOwner.Age);


            //Console.WriteLine(peshoOwner.FullName);
            //Console.WriteLine(peshoOwner.FirstName);
        }
    }
}
