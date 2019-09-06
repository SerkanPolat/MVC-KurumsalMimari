using Ninject.Extensions.Interception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.CrossCuttingConcerns.Logging
{
    public class LoggingInterceptor:SimpleInterceptor
    {
        protected override void BeforeInvoke(IInvocation invocation)
        {
            //Loglama FrameWorkunun Loglama Islemlerinin Yapilacagi Yer.
            Console.WriteLine(invocation.Request.Method.Name);
          //  base.BeforeInvoke(invocation);
        }

        protected override void AfterInvoke(IInvocation invocation)
        {
            //
           // base.AfterInvoke(invocation);
        }
    }
}
