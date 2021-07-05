/*
 * Изучите код данного приложения для расчета суммы целых чисел от 0 до N, а затем
 * измените код приложения таким образом, чтобы выполнялись следующие требования:
 * 1. Расчет должен производиться асинхронно.
 * 2. N задается пользователем из консоли. Пользователь вправе внести новую границу в процессе вычислений,
 * что должно привести к перезапуску расчета.
 * 3. При перезапуске расчета приложение должно продолжить работу без каких-либо сбоев.
 */

using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait.Task1.CancellationTokens
{
    class Program
    {
        /// <summary>
        /// The Main method should not be changed at all.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Mentoring program L2. Async/await.V1. Task 1");
            Console.WriteLine("Calculating the sum of integers from 0 to N.");
            Console.WriteLine("Use 'q' key to exit...");
            Console.WriteLine();

            Console.WriteLine("Enter N: ");

            string input = Console.ReadLine();
            while (input.Trim().ToUpper() != "Q")
            {
                if (int.TryParse(input, out int n))
                {
                    CalculateSum(n);
                }
                else
                {
                    Console.WriteLine($"Invalid integer: '{input}'. Please try again.");
                    Console.WriteLine("Enter N: ");
                }

                input = Console.ReadLine();
            
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        private static void CalculateSum(int n)
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;

            var task1 = Task.Run(async () =>
            {
                await Calculator.CalculateAsync(n, token)
                .ContinueWith(x =>
                {

                    Console.WriteLine();
                    Console.WriteLine($"Sum for {n} = {x.Result}.");
                    Console.WriteLine();
                    Console.WriteLine("Enter N: ");

                }, TaskContinuationOptions.OnlyOnRanToCompletion);
            });

            Task.Run(async () =>
            {
                await Task.Run(() =>
                {
                    var inputValue = Console.ReadLine();
                    if (int.TryParse(inputValue, out int value))
                    {
                        tokenSource.Cancel();
                        if (task1.Status != TaskStatus.RanToCompletion)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter N: ");
                        }
                    };
                });
            });

            Console.WriteLine($"The task for {n} started... Enter N to cancel the request:");

            task1.Wait();
        }
    }
}