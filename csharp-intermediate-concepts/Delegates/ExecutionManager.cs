using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class ExecutionManager
    {
        public Dictionary<Operation, Func<int>> FuncExecute { get; set; }

        private Func<int> _sum;
        private Func<int> _substract;
        private Func<int> _multiply;

        public ExecutionManager()
        {
            FuncExecute = new Dictionary<Operation, Func<int>>(3);
        }

        public void PopulateFunctions(Func<int> Sum, Func<int> Substract, Func<int> Multiply)
        {
            _sum = Sum;
            _substract = Substract;
            _multiply = Multiply;
        }

        public void PrepareExecution()
        {
            FuncExecute.Add(Operation.Sum, _sum);
            FuncExecute.Add(Operation.Substract, _substract);
            FuncExecute.Add(Operation.Multiply, _multiply);
        }
    }
}
