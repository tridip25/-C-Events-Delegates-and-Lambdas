using System;

namespace singletonAndMediatorSimpleExample
{
    class Program
    {
        static void Main(string[] args)
        {
          
          var obj2 = new File2(); //This should be called first as we should let the delgate(pipeline)
                                  // know where to dumb the data beforehand....
          var obj1 = new File1();
          obj1.EnterPressed();

        }
    }
}
