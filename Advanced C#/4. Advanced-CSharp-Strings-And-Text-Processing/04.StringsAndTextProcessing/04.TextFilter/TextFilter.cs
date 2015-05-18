using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

class TextFIlter
{
    static void Main()
    {
        string[] banList = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string someText = Console.ReadLine();
           // "It is not Linux, it is GNU/Lunux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Lunux! Sincerely, a Windows client.";
         foreach (var word in banList)
         {
             someText = someText.Replace(word, new string('*', word.Length));
         }
         Console.WriteLine(someText);
        
    }
}