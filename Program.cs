using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CSharpAsyncExample
{
    public class Kitchen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make Breakfast with simple chef");
            MakeBreakfastWithSimpleChef().Wait();
        }

        static async Task MakeBreakfastWithSimpleChef()
        {
            var chef = new Chef();
            var timer = new Stopwatch();
            timer.Start();

            Console.WriteLine($"[Kitchen] Started making breakfast");

            var waterTask = chef.BoilWater();
            var eggsTask = chef.BoilEggs();
            var baconTask = chef.FryBacon();
            var breadTask = chef.ToastBread();

            await breadTask;
            await chef.ApplyButter();
            await chef.ApplyJam();

            await Task.WhenAll(eggsTask, baconTask, waterTask);
            await chef.PourCoffee();
            await chef.PourJuice();

            timer.Stop();
            Console.WriteLine($"[Kitchen] Breakfast done in '{timer.Elapsed.Seconds}'s '{timer.Elapsed.Milliseconds}'ms");
        }
    }
}
