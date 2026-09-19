using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue in which all items have the same priority: Bob (1), Tim (1), Sue (1), George (1) and
    // run until the queue should be empty
    // Expected Result: Bob, Tim, Sue, George
    // Defect(s) Found:
    //      The highest priority was set to >= instead of >, so the last value with the same priority was selected instead of the first
    //      The Dequeue method was not removing the items.
    public void TestPriorityQueue_SamePriority()
    {
        var bob = new PriorityItem("Bob", 1);
        var tim = new PriorityItem("Tim", 1);
        var sue = new PriorityItem("Sue", 1);
        var george = new PriorityItem("George", 1);

        PriorityItem[] expectedResult = [bob, tim, sue, george];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);
        priorityQueue.Enqueue(george.Value, george.Priority);

        int i = 0;
        for (int j = (expectedResult.Length); j > 0; j--)
        {

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
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
    // Scenario: Create a queue in which all items have different priority: Bob (2), Tim (4), Sue (3), George (1) and
    // run until the queue should be empty
    // Expected Result: Tim, Sue, Bob, George
    // Defect(s) Found: None
    public void TestPriorityQueue_DifferentPriority()
    {
        var bob = new PriorityItem("Bob", 2);
        var tim = new PriorityItem("Tim", 4);
        var sue = new PriorityItem("Sue", 3);
        var george = new PriorityItem("George", 1);

        PriorityItem[] expectedResult = [tim, sue, bob, george];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);
        priorityQueue.Enqueue(george.Value, george.Priority);

        int i = 0;
        for (int j = (expectedResult.Length); j > 0; j--)
        {

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
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
    // Scenario: Create a queue in which all items have varied priority, with some sharing the same priority: Bob (2), Tim (1), Sue (3), George (1) and
    // run until the queue should be empty
    // Expected Result: Sue, Bob, Tim, George
    // Defect(s) Found: None
    public void TestPriorityQueue_VariedPriority()
    {
        var bob = new PriorityItem("Bob", 2);
        var tim = new PriorityItem("Tim", 1);
        var sue = new PriorityItem("Sue", 3);
        var george = new PriorityItem("George", 1);

        PriorityItem[] expectedResult = [sue, bob, tim, george];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);
        priorityQueue.Enqueue(george.Value, george.Priority);

        int i = 0;
        for (int j = (expectedResult.Length); j > 0; j--)
        {

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
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
    // Scenario: Try to get the next item from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: None
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

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
}