using System;
using System.Text;

namespace StringDemoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "";
            //（1）字符访问（下标访问s[i]）
            s = "ABCD";
            Console.WriteLine(s[0]); // 输出"A";
            Console.WriteLine(s.Length); // 输出4
            Console.WriteLine();

            //（2）打散为字符数组（ToCharArray）
            s = "ABCD";
            char[] arr = s.ToCharArray(); // 把字符串打散成字符数组{'A','B','C','D'}
            Console.WriteLine(arr[0]); // 输出数组的第一个元素，输出"A"
            Console.WriteLine();

            //（3）截取子串（Substring）
            s = "ABCD";
            Console.WriteLine(s.Substring(1)); // 从第2位开始（索引从0开始）截取一直到字符串结束，输出"BCD"
            Console.WriteLine(s.Substring(1, 2)); // 从第2位开始截取2位，输出"BC"
            Console.WriteLine();

            //（4）匹配索引（IndexOf()）
            s = "ABCABCD";
            Console.WriteLine(s.IndexOf('A')); // 从字符串头部开始搜索第一个匹配字符A的位置索引，输出"0"
            Console.WriteLine(s.IndexOf("BCD")); // 从字符串头部开始搜索第一个匹配字符串BCD的位置，输出"4"
            Console.WriteLine(s.LastIndexOf('C')); // 从字符串尾部开始搜索第一个匹配字符C的位置，输出"5"
            Console.WriteLine(s.LastIndexOf("AB")); // 从字符串尾部开始搜索第一个匹配字符串BCD的位置，输出"3"
            Console.WriteLine(s.IndexOf('E')); // 从字符串头部开始搜索第一个匹配字符串E的位置，没有匹配输出"-1";
            Console.WriteLine(s.Contains("ABCD")); // 判断字符串中是否存在另一个字符串"ABCD"，输出true
            Console.WriteLine();

            //（5）大小写转换（ToUpper和ToLower）
            s = "aBcD";
            Console.WriteLine(s.ToLower()); // 转化为小写，输出"abcd"
            Console.WriteLine(s.ToUpper()); // 转化为大写，输出"ABCD"
            Console.WriteLine();

            //（6）填充对齐（PadLeft和PadRight）
            s = "ABCD";
            Console.WriteLine(s.PadLeft(6, '_')); // 使用'_'填充字符串左部，使它扩充到6位总长度，输出"__ABCD"
            Console.WriteLine(s.PadRight(6, '_')); // 使用'_'填充字符串右部，使它扩充到6位总长度，输出"ABCD__"
            Console.WriteLine();

            //（7）截头去尾（Trim）
            s = "__AB__CD__";
            Console.WriteLine(s.Trim('_')); // 移除字符串中头部和尾部的'_'字符，输出"AB__CD"
            Console.WriteLine(s.TrimStart('_')); // 移除字符串中头部的'_'字符，输出"AB__CD__"
            Console.WriteLine(s.TrimEnd('_')); // 移除字符串中尾部的'_'字符，输出"__AB__CD"
            Console.WriteLine();

            //（8）插入和删除（Insert和Remove）
            s = "ADEF";
            Console.WriteLine(s.Insert(1, "BC")); // 在字符串的第2位处插入字符串"BC"，输出"ABCDEF"
            Console.WriteLine(s);
            Console.WriteLine(s.Remove(1)); // 从字符串的第2位开始到最后的字符都删除，输出"A"
            Console.WriteLine(s);
            Console.WriteLine(s.Remove(0, 2)); // 从字符串的第1位开始删除2个字符，输出"EF"
            Console.WriteLine();

            //（9）替换字符（串）（Replace）
            s = "A_B_C_D";
            Console.WriteLine(s.Replace('_', '-')); // 把字符串中的'_'字符替换为'-'，输出"A-B-C-D"
            Console.WriteLine(s.Replace("_", "")); // 把字符串中的"_"替换为空字符串，输出"A B C D"
            Console.WriteLine();

            //（10）分割为字符串数组（Split）——互逆操作：联合一个字符串静态方法Join(seperator,arr[])
            s = "AA,BB,CC,DD";
            string[] arr1 = s.Split(','); // 以','字符对字符串进行分割，返回字符串数组
            Console.WriteLine(arr1[0]); // 输出"AA"
            Console.WriteLine(arr1[1]); // 输出"BB"
            Console.WriteLine(arr1[2]); // 输出"CC"
            Console.WriteLine(arr1[3]); // 输出"DD"
            Console.WriteLine();

            s = "AA--BB--CC--DD";
            string[] arr2 = s.Replace("--", "-").Split('-'); // 以字符串进行分割的技巧：先把字符串"--"替换为单个字符"-"，然后以'-'字符对字符串进行分割，返回字符串数组
            Console.WriteLine(arr2[0]); // 输出"AA"
            Console.WriteLine(arr2[1]); // 输出"BB"
            Console.WriteLine(arr2[2]); // 输出"CC"
            Console.WriteLine(arr2[3]); // 输出"DD"
            Console.WriteLine();

            //（11）格式化（静态方法Format）
            Console.WriteLine(string.Format("{0} + {1} = {2}", 1, 2, 1 + 2));
            Console.WriteLine(string.Format("{0} / {1} = {2:0.000}", 1, 3, 1.00 / 3.00));
            Console.WriteLine(string.Format("{0:yyyy年MM月dd日}", DateTime.Now));


            //（12）连接成一个字符串（静态方法Concat、静态方法Join和实例方法StringBuilder.Append）
            s = "A,B,C,D";
            string[] arr3 = s.Split(','); // arr = {"A","B","C","D"}

            Console.WriteLine(string.Concat(arr3)); // 将一个字符串数组连接成一个字符串，输出"ABCD"

            Console.WriteLine(string.Join(",", arr3)); // 以","作为分割符号将一个字符串数组连接成一个字符串，输出"A,B,C,D"

            StringBuilder sb = new StringBuilder(); // 声明一个字符串构造器实例
            sb.Append("A"); // 使用字符串构造器连接字符串能获得更高的性能
            sb.Append('B');
            Console.WriteLine(sb.ToString());// 输出"AB"

            Console.ReadKey();
        }
    }
}
