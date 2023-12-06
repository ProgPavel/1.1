using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public struct ModelStruct
    {
        int r;
        int y;
        int р;
        public int x;
    }

    class ModelClass
    {
        public int x;      
    }
                  
    static class MyFunctions
    {          
        public static void ProcessStruct(ModelStruct modelStruct)
        {
             modelStruct.x = 10;
        }
        public static void ProcessClass(ModelClass modelClass)
        {
            modelClass.x = 10;
        }
    }
}
