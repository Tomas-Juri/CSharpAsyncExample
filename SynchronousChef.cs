using System;
using System.Threading;

namespace CSharpAsyncExample
{
    public class SynchronousChef
    {
        public int DelayMultiply { get; set; }

        public SynchronousChef()
        {
            DelayMultiply = 100;
        }

        public void MakeBreakfast()
        {
            BoilWater();
            BoilEggs();
            FryBacon();
            ToastBread();
            ApplyButter();
            ApplyJam();
            PourCoffee();
            PourJuice();
        }

        public void PourCoffee()
        {
            Console.WriteLine("[Chef] Start pouring coffee");
            Thread.Sleep(5 * DelayMultiply);
            Console.WriteLine("[Chef] Coffee Ready");
        }

        public void BoilEggs()
        {
            Console.WriteLine("[Chef] Put Eggs into boiling water");
            Thread.Sleep(70 * DelayMultiply);
            Console.WriteLine("[Chef] Eggs Boiled");
        }

        public void FryBacon()
        {
            Console.WriteLine("[Chef] Throw bacon in pan");
            Thread.Sleep(40 * DelayMultiply);
            Console.WriteLine("[Chef] Bacon Fried");
        }

        public void ToastBread()
        {
            Console.WriteLine("[Chef] Put bread in toaster");
            Thread.Sleep(20 * DelayMultiply);
            Console.WriteLine("[Chef] Bread Toasted");
        }

        public void ApplyButter()
        {
            Console.WriteLine("[Chef] Start spreading Butter");
            Thread.Sleep(15 * DelayMultiply);
            Console.WriteLine("[Chef] Butter applied");
        }

        public void ApplyJam()
        {
            Console.WriteLine("[Chef] Start spreading Jam");
            Thread.Sleep(15 * DelayMultiply);
            Console.WriteLine("[Chef] Jam applied");
        }

        public void PourJuice()
        {
            Console.WriteLine("[Chef] Start pouring Juice");
            Thread.Sleep(5 * DelayMultiply);
            Console.WriteLine("[Chef] Juice Ready");
        }

        public void BoilWater()
        {
            Console.WriteLine("[Chef] Set coffee water to boil");
            Thread.Sleep(200 * DelayMultiply);
            Console.WriteLine("[Chef] Coffee Water is boiled");
        }
    }
}