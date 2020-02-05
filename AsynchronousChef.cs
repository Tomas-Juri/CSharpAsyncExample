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

        public async Task MakeBreakfast()
        {
            var waterTask = BoilWater();
            var eggsTask = BoilEggs();
            var baconTask = FryBacon();
            var breadTask = ToastBread();

            await breadTask;
            await ApplyButter();
            await ApplyJam();

            // await eggsTask;
            // await baconTask;
            // await waterTask;               
            await Task.WhenAll(eggsTask, baconTask, waterTask);
            await PourCoffee();
            await PourJuice();
        }

        public async Task PourCoffee()
        {
            Console.WriteLine("[Chef] Start pouring coffee");
            await Task.Delay(5 * DelayMultiply);
            Console.WriteLine("[Chef] Coffee Ready");
        }

        public async Task BoilEggs() 
        {
            Console.WriteLine("[Chef] Put Eggs into boiling water");
            await Task.Delay(70 * DelayMultiply);
            Console.WriteLine("[Chef] Eggs Boiled");
        }

        public async Task FryBacon()
        {
            Console.WriteLine("[Chef] Throw bacon in pan");
            await Task.Delay(40 * DelayMultiply);
            Console.WriteLine("[Chef] Bacon Fried");
        }

        public async Task ToastBread()
        {
            Console.WriteLine("[Chef] Put bread in toaster");
            await Task.Delay(20 * DelayMultiply);
            Console.WriteLine("[Chef] Bread Toasted");
        }

        public async Task ApplyButter()
        {
            Console.WriteLine("[Chef] Start spreading Butter");
            await Task.Delay(15 * DelayMultiply);
            Console.WriteLine("[Chef] Butter applied");
        }

        public async Task ApplyJam()
        {
            Console.WriteLine("[Chef] Start spreading Jam");
            await Task.Delay(15 * DelayMultiply);
            Console.WriteLine("[Chef] Jam applied");
        }

        public async Task PourJuice()
        {
            Console.WriteLine("[Chef] Start pouring Juice");
            await Task.Delay(5 * DelayMultiply);
            Console.WriteLine("[Chef] Juice Ready");
        }

        public async Task BoilWater()
        {
            Console.WriteLine("[Chef] Set coffee water to boil");
            await Task.Delay(200 * DelayMultiply);
            Console.WriteLine("[Chef] Coffee Water is boiled");
        }
    
        public async Task<string> TellAJoke()
        {
            return "Joke";
        }
    }
}