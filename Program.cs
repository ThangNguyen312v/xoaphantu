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
            int index_del = -1;
            for (int i = 0; i < nuMs.Length; i++)
            {
                if (nuMs[i] == n)
                {
                    index_del = i;
                    break;
                }
            }
            for (int i = index_del; i < nuMs.Length - 1; i++)
            {
                nuMs[i] = nuMs[i + 1];
            }
            return nuMs;
        }
    }
}
