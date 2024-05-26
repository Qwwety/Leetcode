// See https://aka.ms/new-console-template for more information


using System.Linq;


internal class Program
{
    private static void Main(string[] args)
    {
        var nums = new int[] { 10, 2 }; //210
        var nums2 = new int[] { 1, 3, 30, 34, 5, 9 }; //9534330
        //Console.WriteLine(LargestNumber(nums));
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
        //Console.WriteLine(Merge(intervals3));
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
        Console.WriteLine(AddTwoNumbers(l1, l2));
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