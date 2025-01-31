using System.Collections;

namespace Advanced_C__Assignment1
{
    internal class Program
    {

        #region function for Q2
        //public static void Reverse(ArrayList list)
        //{
        //    int L= 0;
        //    int R = list.Count - 1;
        //    while (L < R)
        //    {
        //        object temp = list[L];
        //        list[L] = list[R];
        //        list[R] = temp;
        //        L++;
        //        R--;
        //    }
        //}
        #endregion
        #region function for Q3
        //public static List<int> EvenNumber(List<int> nums)
        //{
        //    List<int> evenNums = new List<int>();
        //    foreach (var num in nums)
        //    {
        //        if (num % 2 == 0)
        //        {
        //            evenNums.Add(num);
        //        }
        //    }
        //    return evenNums;
        //}
        #endregion
        #region function for Q5
        public static int NonRepeated(string s)
        {
            Dictionary<char,int> charCount = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                    return i; 
            }

            return -1;
        }
        #endregion
        static void Main(string[] args)
        {

            #region Question1
            //bool f;
            //int min, max, value;
            //float min2, max2, value2;
            //do
            //{
            //    do
            //    {
            //        Console.Write("Enter the max value for the range: ");
            //        f = int.TryParse(Console.ReadLine(), out max);
            //    } while (!f);

            //    do
            //    {
            //        Console.Write("Enter the min value for the range: ");
            //        f = int.TryParse(Console.ReadLine(), out min);
            //    } while (!f);
            //    if (min.CompareTo(max) > 0)
            //        Console.WriteLine("the min cannot be larger than max value");

            //} while (min.CompareTo(max) > 0);

            //Range<int> range = new Range<int>(min, max);
            //Console.Write("Enter a value to check if it's in range: ");
            //do
            //{
            //    f = int.TryParse(Console.ReadLine(), out value);
            //} while (!f);
            //if (range.IsInRange(value))
            //{
            //    Console.WriteLine("this value in the range");
            //}
            //else
            //{
            //    Console.WriteLine("this value is not in the range");
            //}

            //Console.WriteLine(range.GetLength());
            #endregion
            #region Question2
            //ArrayList list1 = new ArrayList();
            //list1.Add("A");
            //list1.Add("B");
            //list1.Add("#");
            //list1.Add("R");
            //list1.Add(4);

            //Console.WriteLine("Original ArrayList: ");
            //foreach (var item in list1)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Reverse(list1);
            //Console.WriteLine("Reversed ArrayList: ");
            //foreach (var item in list1)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region Question3
            //List<int> nums = new List<int> { 2, 3,9, 5 ,4};

            //List<int> evenNums = EvenNumber(nums);
            //Console.WriteLine("even numbers:");
            //foreach (var number in evenNums)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region Question 4
            //try
            //{
            //    FixedSizeList<int> list = new FixedSizeList<int>(3);
            //    list.Add(1);
            //    list.Add(2);
            //    list.Add(3);
            //    Console.WriteLine("Current List id:");
            //    list.Display();
            //    list.Add(4);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    FixedSizeList<string> stringList = new FixedSizeList<string>(2);
            //    stringList.Add("Lojain");
            //    stringList.Add("Emad");
            //    Console.WriteLine("string List elements:");
            //    stringList.Display();
            //    Console.WriteLine(stringList.Get(5));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region Question5
            string name = "Lojain";
            int index = NonRepeated(name);
            Console.WriteLine($"The index of the first NonRepeated character is:{index}");
            string name2 = "salsabil";
            int index2 = NonRepeated(name2);
            Console.WriteLine($"The index of the first NonRepeated character is:{index2}");
            #endregion

        }





    }
 }
