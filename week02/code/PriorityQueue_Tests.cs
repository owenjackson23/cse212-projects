using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue in which all items have the same priority: Bod (1), Tim (1), Sue (1), George (1) and
    // run until the queue is empty
    // Expected Result: bob, tim, sue, george
    // Defect(s) Found: 
    public void TestPriorityQueue_SamePriority()
    {
        var bob = new PriorityItem("Bob", 1);
        var tim = new PriorityItem("Tim", 1);
        var sue = new PriorityItem("Sue", 1);
        var george = new PriorityItem("George", 1);

        PriorityItem[] expectedResult = [bob, tim, sue, george];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);

        for (int i = expectedResult.Length; i > 0; i--)
        {

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
        }

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}