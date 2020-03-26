using System;
using System.Collections.Generic;
using System.Text;

namespace TypesOfClasses.ClassStructure
{
    public class Square : AbstractGeometricShape
    {
        public int GenericProperty {
            get
            {
                Console.WriteLine("Square Property has been initialized");
                return 0;
            } set { 
            }
        }

        public int Variable = InitializeVariable();

        public Square()
        {
            Console.WriteLine("Square Contructor has been called");
        }

        private static int InitializeVariable()
        {
            Console.WriteLine("Property has been initialized");
            return 1;
        }
    }
}
