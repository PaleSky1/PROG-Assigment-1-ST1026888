using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanele_s_Recipe_App
{
    internal class Step
    {
        public string Description { get; set; }

        public Step(string description)
        {
            Description = description;
        }

        public static Step[] AddStepToArray(Step[] array, Step step)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = step;
            return array;
        }

        public static Step[] ResizeArray(Step[] array, int newSize)
        {
            Array.Resize(ref array, newSize);
            return array;
        }
    }
}
