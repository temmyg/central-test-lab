using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Await_Exception_Show
{
    class Scenario1
    {
        public Task ShowAsync()
        {
            Task res = null;
            try
            {
                res = Task.Run(() =>
                {

                    Task.Delay(2000);
                    throw new CustomException("Some Exception");

                    Console.WriteLine("msg");

                });

                res.Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("AggregateException thrown, inner is {0}", ex.InnerException.GetType());
            }

            throw new CustomException("secondary excepton");

            return res;
        }

        public async void Call()
        {
            try
            {
                await ShowAsync();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("most outside exception {0}", ex.Message);
            }
        }

        public static void Main(String[] args)
        {
            Scenario1 t = new Scenario1();
            t.Call();
            Console.ReadLine();
        }
    }
}
