using System.Numerics;

namespace AddTwoNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListNode l1 = new ListNode(9, null);
            ListNode l2 = new ListNode(0, null);
            ListNode result = AddTwoNumbers(l1, l2);

        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //string conversion of l1
            string l1String = "";
            do
            {
                l1String = l1String.Insert(0, l1.val.ToString());
                l1 = l1.next;
            }
            while (l1 != null);
            BigInteger l1number = BigInteger.Parse(l1String);

            //string conversion of l2
            string l2String = "";
            do
            {
                l2String = l2String.Insert(0, l2.val.ToString());
                l2 = l2.next;
            }
            while (l2 != null);
            BigInteger l2number = BigInteger.Parse(l2String);


            //String Revese
            string resultStr = (l1number + l2number).ToString();
            char[] charArray = resultStr.ToCharArray();
            Array.Reverse(charArray);
            var reversedStr = new string(charArray);


            //String to ListNode Conversion
            List<ListNode> nodes = new();
            foreach (char x in reversedStr)
            {
                nodes.Add(new ListNode(x - '0', null));
            }
            foreach (ListNode x in nodes)
            {
                try
                {
                    x.next = nodes[nodes.IndexOf(x) + 1];
                }
                catch
                {
                    x.next = null;
                }

            }
            return nodes[0];
        }

        //ListNode Documentation
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


    }
}