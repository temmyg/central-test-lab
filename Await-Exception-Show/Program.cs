using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronious
{
    class Test
    {
        public Task ShowAsync()
        {
            throw new Exception("My Own Exception");

            return Task.Run(()=>{
                Task.Delay(2000);
                // throw new Exception("My Own Exception");
            }).ContinueWith(t => {
                Console.WriteLine(t.Exception.Message);
            });
        }

        public async Task Call()
        {
            try
            {
                await ShowAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Program
    {
        //public static void Main(String [] args)
        //{
        //    Test t = new Test();
        //    try
        //    {
        //        t.Call();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    Console.ReadLine();
        //}
    }
}
