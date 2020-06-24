using Microsoft.VisualStudio.TestTools.UnitTesting;
using arLib2;

namespace arQueue_Tests
{
    [TestClass]
    public class arQueueTests
    {
        [TestMethod]
        public void intNumbEnter()
        {
            //arrange
            int[] expected_ar = { 5, 6, 7 };

            //act
            ArrayQueue<int> arr = new ArrayQueue<int>(3);
            arr.Enqueue(5);
            arr.Enqueue(6);
            arr.Enqueue(7);
            int[] actual_ar = new int[3];
            int i = 0;
            while (!arr.IsEmpty())
            {
                actual_ar[i] = arr.Peek();
                arr.Dequeue();
                i++;
            }
            //foreach(var elem in arr)
            //{
            //    actual_ar[i] = elem;
            //    i++;
            //}

            //assert
            Assert.AreEqual(true, arr.isEmpty);
            CollectionAssert.AreEqual(expected_ar, actual_ar);
        }
        [TestMethod]
        public void intNumbClear()
        {
            //arrange
            int[] expected_ar = {0, 0, 0 };

            //act
            ArrayQueue<int> arr = new ArrayQueue<int>(3);
            arr.Enqueue(5);
            arr.Enqueue(6);
            arr.Enqueue(7);
            int[] actual_ar = new int[3];
            int i = 0;
            arr.Clear();
            foreach (var elem in arr)
            {
                actual_ar[i] = elem;
                i++;
            }

            //assert
            CollectionAssert.AreEqual(expected_ar, actual_ar);
        }
        [TestMethod]
        public void intNumbDequeue()
        {
            //arrange
            int[] expected_ar = { 11, 12,0};

            //act
            ArrayQueue<int> arr = new ArrayQueue<int>(3);
            arr.Enqueue(5);
            arr.Enqueue(11);
            arr.Enqueue(12);
            int[] actual_ar = new int[3];
            int i = 0;
            arr.Dequeue();
            foreach (var elem in arr)
            {
                actual_ar[i] = elem;
                i++;
            }

            //assert
            CollectionAssert.AreEqual(expected_ar, actual_ar);
        }
        [TestMethod]
        public void intNumbPeek()
        {
            //arrange
            int expected = 5;

            //act
            ArrayQueue<int> arr = new ArrayQueue<int>(3);
            arr.Enqueue(5);
            arr.Enqueue(11);
            arr.Enqueue(12);
            int actual=0;
            actual = arr.Peek();
           

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
