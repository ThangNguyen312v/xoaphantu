using System;
namespace xoaphantu{
    class Program{
        static void Main(string[] Args){
            int[] nUms = {10,4,6,7,8,6,0,0,0,0};
            int x = 7;
            nUms = Xoaso(nUms, x);

            foreach(int i in nUms)
            {
                Console.WriteLine(i + "");
            }
        }
        static int[] Xoaso(int[] nuMs,int n){
          int index_del = Array.IndexOf(nuMs, n) ;
          if(index_del != -1)
          {
            int[] numS = new int[nuMs.Length - 1];

            Array.Copy(nuMs, 0, numS, 0, index_del);
            Array.Copy(nuMs, index_del + 1, numS, index_del, nuMs.Length - index_del - 1);

            return numS;
          }
          else
          {
            return nuMs;
          }
        }
    }
}
