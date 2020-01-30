using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Await_Exception_Show
{
    class Scenario2
    {
         public async Task<int> ShowAsync()
        {
            Task<int> res;
            try
            {
                res = Task.Run(() =>
                {
                    try
                    {
                        Task.Delay(2000);
                        throw new CustomException("Some Exception");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return 3;
                    }

                    Console.WriteLine("msg");
                    return 4;

                });

                //return res.Result;
                res.Wait();
            }
            catch(AggregateException ex)
            {
                Console.WriteLine(ex.InnerException.GetType());
                // ex InnerException is CustomException
            }

            return 1;
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

            }
        }

        //public static void Main(String[] args)
        //{
        //    Scenario2 t = new Scenario2();
        //    t.Call();
        //    Console.ReadLine();
        //}
    }

    public class CustomException : Exception
    {
        public CustomException(String message)
            : base(message)
        { }
    }
}
