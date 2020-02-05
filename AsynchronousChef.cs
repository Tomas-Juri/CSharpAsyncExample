using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAsyncExample
{
    public class AsynchronousChef
    {
        public int DelayMultiply { get; set; }

        public AsynchronousChef()
        {
            DelayMultiply = 100;
        }

        public Task PourCoffee() => Task.Run(() =>
        {
            Console.WriteLine("[Chef] Start pouring coffee");
            Thread.Sleep(5 * DelayMultiply);
            Console.WriteLine("[Chef] Coffee Ready");
        });

        public Task BoilEggs() => Task.Run(() =>
        {
            Console.WriteLine("[Chef] Put Eggs into boiling water");
            Thread.Sleep(70 * DelayMultiply);
            Console.WriteLine("[Chef] Eggs Boiled");
        });

        public Task FryBacon() => Task.Run(() =>
        {
            Console.WriteLine("[Chef] Throw bacon in pan");
            Thread.Sleep(40 * DelayMultiply);
            Console.WriteLine("[Chef] Bacon Fried");
        });

        public Task ToastBread() => Task.Run(() =>
        {
            Console.WriteLine("[Chef] Put bread in toaster");
            Thread.Sleep(20 * DelayMultiply);
            Console.WriteLine("[Chef] Bread Toasted");
        });

        public Task ApplyButter() => Task.Run(() =>
        {
            Console.WriteLine("[Chef] Start spreading Butter");
            Thread.Sleep(15 * DelayMultiply);
            Console.WriteLine("[Chef] Butter applied");
        });

        public Task ApplyJam() => Task.Run(() =>
        {
            Console.WriteLine("[Chef] Start spreading Jam");
            Thread.Sleep(15 * DelayMultiply);
            Console.WriteLine("[Chef] Jam applied");
        });

        public Task PourJuice() => Task.Run(() =>
        {
            Console.WriteLine("[Chef] Start pouring Juice");
            Thread.Sleep(5 * DelayMultiply);
            Console.WriteLine("[Chef] Juice Ready");
        });

        public Task BoilWater() => Task.Run(() =>
        {
            Console.WriteLine("[Chef] Set coffee water to boil");
            Thread.Sleep(200 * DelayMultiply);
            Console.WriteLine("[Chef] Coffee Water is boiled");
        });
    }
}