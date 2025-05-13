using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC225017.DataAccess.Collection
{
    public class MyCollection
    {

        public void Dictionary()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(1, "IMIC");
            myDictionary.Add(2, "BE");
            myDictionary.Add(3, "HN");

            foreach (var item in myDictionary)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        public void ArrayList()
        {
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add("IMIC");
            arrayList1.Add(3.14);
            arrayList1.Add(true);
            arrayList1.Add(new List<int> { 1, 2, 3 });

            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("ArrayList count: " + arrayList1.Count);
        }


        public void hashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Key1", "IMIC");
            hashtable.Add("Key2", "BE");
            hashtable.Add("Key3", "HN");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine(hashtable["Key1"]);
            Console.WriteLine("Hashtable count: " + hashtable.Count);
        }

        public void SortedList()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(3, "IMIC");
            sortedList.Add(1, "BE");
            sortedList.Add(2, "HN");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine(sortedList[1]);// LẤY THEO KEY BE
            Console.WriteLine(sortedList.GetKey(1)); // LẤY THEO KEY

            Console.WriteLine(sortedList.GetByIndex(1)); // LẤY THEO INDEX

            Console.WriteLine("SortedList count: " + sortedList.Count);
        }

        public void Stack()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("IMIC");
            stack.Push(3.14);
            stack.Push(true);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Stack count: " + stack.Count);
        }

        public void Queue()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("IMIC");
            queue.Enqueue(3.14);
            queue.Enqueue(true);
            queue.Enqueue("IMIC");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Queue count: " + queue.Count);
        }

        public void HashSet()
        {
            var intHashSet = new HashSet<int>() { 1, 2, 3, 4, 5, 4, 4, 4, 4 };
            //  intHashSet.Add(10);
            //intHashSet.Remove(5);
            //Check Set contains item
            // bool contain = intHashSet.Contains(1);
            // Iterate over all objects
            foreach (var item in intHashSet)
                Console.WriteLine(item);
            //Delete all items
            intHashSet.Clear();


            
        }
    }
}
