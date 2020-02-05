using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAsyncExample
{
    public class ComplexAsynchronousChef
    {
        public int DelayMultiply { get; set; }

        public ComplexAsynchronousChef()
        {
            DelayMultiply = 100;
        }

        public async Task MakeBreakfast()
        {
            var coffeeTask = PrepareCoffee();
            var eggsTask = BoilEggs();
            var baconTask = FryBacon();
            var breadTask = PrepareBread();
            PourJuice();
            await Task.WhenAll(coffeeTask, eggsTask, baconTask, breadTask);
        }

        public async Task PrepareCoffee()
        {
            Console.WriteLine("[Chef] Start preparing coffee");
            await BoilWater();
            Console.WriteLine("[Chef] Start pouring coffee");
            await Task.Delay(5 * DelayMultiply);
            Console.WriteLine("[Chef] Coffee Ready");
        }

        public Task BoilEggs() => Task.Run(() =>
        {
            Console.WriteLine("[Chef] Put Eggs into boiling water");
            Task.Delay(70 * DelayMultiply).Wait();
            Console.WriteLine("[Chef] Eggs Boiled");
        });

        public Task FryBacon() => Task.Run(() =>
        {
            Console.WriteLine("[Chef] Throw bacon in pan");
            Task.Delay(40 * DelayMultiply).Wait();
            Console.WriteLine("[Chef] Bacon Fried");
        });

        public async Task PrepareBread()
        {
            Console.WriteLine("[Chef] Put bread in toaster");
            await Task.Delay(20 * DelayMultiply);
            Console.WriteLine("[Chef] Bread toasted");
            ApplyButter();
            ApplyJam();
            Console.WriteLine("[Chef] Bread ready");
        }

        public void ApplyButter()
        {
            Console.WriteLine("[Chef] Start spreading Butter");
            Task.Delay(15 * DelayMultiply).Wait();
            Console.WriteLine("[Chef] Butter applied");
        }

        public void ApplyJam()
        {
            Console.WriteLine("[Chef] Start spreading Jam");
            Task.Delay(15 * DelayMultiply).Wait();
            Console.WriteLine("[Chef] Jam applied");
        }

        public void PourJuice()
        {
            Console.WriteLine("[Chef] Start pouring Juice");
            Task.Delay(5 * DelayMultiply).Wait();
            Console.WriteLine("[Chef] Juice Ready");
        }

        public async Task BoilWater()
        {
            Console.WriteLine("[Chef] Set coffee water to boil");
            await Task.Delay(200 * DelayMultiply);
            Console.WriteLine("[Chef] Coffee Water is boiled");
        }
    }

}