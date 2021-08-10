using System;

namespace TestProject
{
    public class TestProjectClass
    {
        static void Main()
        {
           
        }
        /*public static bool StringEqual(string p_first, string p_second)
        {
            return p_first == p_second;
        }*/
        public static bool StringArr(string [] f_arr,string [] s_arr)
        {
            for(int i=0;i<f_arr.Length;i++)
            { 
                if(f_arr[i] != s_arr[i])  { return false; }
            }
            return true;
        }
        public static bool StringIsInArr(string[] p_arr, string p_second)
        {
            for(int i=0;i<p_arr.Length;i++)
            {
                if(p_arr[i]==p_second){ return true; }
            }
            return false;
        }
        public static bool MoreThan(int a,int b) { return a > b; }
    }
}
