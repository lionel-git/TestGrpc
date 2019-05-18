using System;
using System.Threading;


namespace TestGrpc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var cancelSource = new CancellationTokenSource();
            var token = cancelSource.Token;
            Console.WriteLine(token.CanBeCanceled);
            Console.WriteLine(token.IsCancellationRequested);
            cancelSource.Cancel();
            Console.WriteLine(token.IsCancellationRequested);

            var token2 = CancellationToken.None;
            Console.WriteLine(token2.IsCancellationRequested);
            Console.WriteLine(token2.CanBeCanceled);

            Console.WriteLine("Wait key...");
            Console.ReadKey();
        }
    }
}
