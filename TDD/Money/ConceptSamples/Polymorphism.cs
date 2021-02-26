using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public interface IGeometricForm
    {
        void Draw(int countForms);
    }

    public static class FormsFactory
    {
        public static IGeometricForm CreateForm(string form)
        {
            switch(form)
            {
                case "circle":
                    return new Circle();
                case "square":
                    return new Square();
                default:
                    return null;
            }
        }
    }

    public class Circle : IGeometricForm
    {
        public void Draw(int countForms)
        {
            System.Console.WriteLine("We drew {0} circles.", countForms);
        }
    }

    public class Square : IGeometricForm
    {
        public void Draw(int countForms)
        {
            System.Console.WriteLine("We drew {0} squares.", countForms);
        }
    }

}
