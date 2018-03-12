using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\admin\Desktop\新增資料夾\lab-2-zi-chuan-chu-li-chaochunghui-master\Data\Input.txt");
            String line = null;
            while((line=file.ReadLine()) != null){
                var chars = line.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if(chars[i]=='.'||chars[i]=='?'||chars[i]=='!'){
                        Console.WriteLine(chars[i]);
                    }
                    else{
                        Console.Write(chars[i]);        
                    }
                    
                }
                Console.Read();
            }
        }
    }
}
