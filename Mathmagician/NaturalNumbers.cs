using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//must connect projects tests and class
//must set class as a dependency
//right click on classTest (MathmagicianTests.cs)... Add...Reference..Check box..Ok
//this is only done per solution.  ties project and solutions together.
namespace Mathmagician
{
    //type public then check test to pass the tests
    public class NaturalNumbers
    {
        
        protected int first;
        protected int increment;

        //create Constructor. Ran when ever a new instance is created
        public NaturalNumbers()
        {
            first = 1;
            increment = 1;
        }

        public virtual int GetNext(int x)
        {
            return x+increment;
        }

        public int GetFirst()
        {
            return first;
        }

        public int[] GetSequence()
        {
            return GetSequence(10);
        }

        public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count < length)
            {
                output.Add(GetNext(output.Last()));
            }
            return output.ToArray();
        }
        public string ToString(int[] array)
        {
            string output = String.Join(" ", array);
            return output;
        }
    }
}
