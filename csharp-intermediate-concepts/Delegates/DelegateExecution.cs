using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

   
    public class DelegateExecution
    {
        static void Main(string[] args)
        {
            var executeManager = new ExecutionManager();
            var operationManager = new OperationManager(20, 10, executeManager);

            var result = operationManager.Execute(Operation.Multiply);
            Console.WriteLine("The result of the operation is " + result);
        }
    }
}
