using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CSharpAsyncExample
{
    public class Kitchen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make Breakfast with Synchronous chef");
            // MakeBreakfastWithSynchronousChef();

            Console.WriteLine("---");

            Console.WriteLine("Make Breakfast with Asynchronous chef");
            // MakeBreakfastWithAsynchronousChef().Wait();

            Console.WriteLine("---");

            Console.WriteLine("Make Breakfast with ComplexAsynchronous chef");
            MakeBreakfastWithComplexAsynchronousChef().Wait();
        }

        static void MakeBreakfastWithSynchronousChef()
        {
            var chef = new SynchronousChef();
            var timer = new Stopwatch();
            timer.Start();

            Console.WriteLine($"[Kitchen] Started making breakfast");

            chef.BoilWater();
            chef.BoilEggs();
            chef.FryBacon();
            chef.ToastBread();
            chef.ApplyButter();
            chef.ApplyJam();
            chef.PourCoffee();
            chef.PourJuice();

            timer.Stop();
            Console.WriteLine($"[Kitchen] Breakfast done in '{timer.Elapsed.Seconds}'s '{timer.Elapsed.Milliseconds}'ms");
        }

        static async Task MakeBreakfastWithAsynchronousChef()
        {
            var chef = new AsynchronousChef();
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

        
        static async Task MakeBreakfastWithComplexAsynchronousChef()
        {
            var chef = new ComplexAsynchronousChef();
            var timer = new Stopwatch();
            timer.Start();

            Console.WriteLine($"[Kitchen] Started making breakfast");

            await chef.MakeBreakfast();

            timer.Stop();
            Console.WriteLine($"[Kitchen] Breakfast done in '{timer.Elapsed.Seconds}'s '{timer.Elapsed.Milliseconds}'ms");
        }
    }
}
