﻿// See https://aka.ms/new-console-template for more information


using System;
using System.Data;
using System.Linq;


internal class Program
{
    private static void Main(string[] args)
    {
        var nums = new int[] { 10, 2 }; //210
        var nums2 = new int[] { 1, 3, 30, 34, 5, 9 }; //95343301
        //Console.WriteLine(LargestNumber(nums2));
        //https://leetcode.com/problems/largest-number/
        //https://metanit.com/sharp/tutorial/3.23.php
        string LargestNumber(int[] nums)
        {
            if (nums.All(_ => _ == 0)) return "0";

            var s = nums.Select(_ => _.ToString()).ToList();

            s.Sort((a, b) => (b + a).CompareTo(a + b)); // складывает попарно, потом сложенное превращает в одно и продолжает складывать 

            var order = string.Concat(s);

            return order;

        }


        var intervals = new int[][] { [1, 3], [2, 6], [8, 10], [15, 18] }; //[[1,6],[8,10],[15,18]]
        var intervals2 = new int[][] { [1, 4], [4, 5] }; //[[1,5]]
        var intervals3 = new int[][] { [1, 4], [2, 3] }; //[[1,4]]
        //Console.WriteLine(Merge(intervals));
        //https://leetcode.com/problems/merge-intervals/
        int[][] Merge(int[][] intervals)
        {
            var Ordered = intervals.OrderBy(x => x[0]).ToList();

            var subResult = new List<int[]> { Ordered[0] };

            for (int i = 1; i < Ordered.Count(); i++) //(var x in Ordered)
            {
                var Max = subResult.Last()[1];
                var NewStart = Ordered[i][0];
                //var 

                if (Max >= NewStart)
                {
                    if (Ordered[i][1] > Max)
                        subResult.Last()[1] = Ordered[i][1];
                }
                else
                {
                    subResult.Add(Ordered[i]);
                }

            }

            var result = subResult.ToArray();

            return result;
        }


        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        //Console.WriteLine(AddTwoNumbers(l1, l2));
        //https://leetcode.com/problems/add-two-numbers/description/
        ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode();
            ListNode current = dummyHead;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;

                int sum = x + y + carry;
                carry = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;

                if (l1 != null) 
                    l1 = l1.next;

                if (l2 != null) 
                    l2 = l2.next;
            }

            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return dummyHead.next;
        }


        //Считаем Стринги
        //Console.WriteLine(DummyCalculator("1*4*3+1+9+2*2*5"));
        int DummyCalculator(string input)
        {

            var value = Convert.ToInt32(new DataTable().Compute(input, null));


            //List<string> subs = input.Split('+').OrderByDescending(x => x.Length).ToList();

            //subs.Aggregate((Int32.Parse(p), Int32.Parse(x)x) => p *= x);

            //var result = 0;
            //foreach (var sub in subs)
            //{
            //    var subresult = 0;

            //    if (sub.Length > 1)
            //    {
            //        subresult++;

            //        var subslplit= sub.Split("*");

            //        foreach (var item in subslplit)
            //        {
            //            subresult *= Int32.Parse(item);
            //        }
            //    }
            //    else
            //    {
            //        result += Int32.Parse(sub);
            //    }

            //    result += subresult;

            //}

            return value;
        }



        //https://leetcode.com/problems/two-sum/description/
        //Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity? +
        var arr1 = new int[] { 2, 7, 11, 15 };
        var target1 = 9;//[0,1]

        var arr2 = new int[] { 3, 2, 4 };
        var target2 = 6;//[1,2]

        var arr3 = new int[] { 3, 3 };
        var target3 = 6; //[0,1]

        var arr4 = new int[] { 3,2,3 };
        var target4 = 6; //[0,1]

        Console.WriteLine(TwoSum(arr4,target4));

        int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> hasMap= new Dictionary<int,int>();

            for (int i=0;i<nums.Length;i++)
            {
                int tmp = nums[i];

                if (hasMap.ContainsKey(target - tmp))
                {
                    return new int[] { i, hasMap[target - nums[i]] };
                }

                hasMap[nums[i]]=i;
            }
            return new int[0];
        }

        Console.ReadKey();
    }
}


//https://leetcode.com/problems/add-two-numbers/description/
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Test
{
    public int val;

}