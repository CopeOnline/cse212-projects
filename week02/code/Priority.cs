public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and priority: Bob (2), Tim (5), Sue (3) and George (5)
        
        // Expected Result: [Bob (Pri:2), Tim (Pri:5), Sue (Pri:3), George (Pri:5)]

        Console.WriteLine("Test 1");       

        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("George", 5);
   
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: No defects found

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Find person with the highest priority and remove from queue. If same priority exists remove FIFO. Repeat two times.
        // Expected Result: Tim, George, Sue

        Console.WriteLine("Test 2");

        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("George", 5);

        var removed = priorityQueue.Dequeue();
        Console.WriteLine(removed);   
        // Console.WriteLine(priorityQueue);

        removed = priorityQueue.Dequeue();
        Console.WriteLine(removed);
        // Console.WriteLine(priorityQueue);

        removed = priorityQueue.Dequeue();
        Console.WriteLine(removed);
        // Console.WriteLine(priorityQueue);

        // Defect(s) Found: Line 32 in PriorityQueue added, was not removing item with dequeue method.
        //           Found: Line 25 PriotiryQueue _queueCount - 1 would not check the last value for priority and for loop started checking at index 1
        //                  changed to zero to check from first of list
        //           Found: LIne 26 used the >= signs which overwrote previous highPriorityIndex changed to > for FIFO

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Try to remove person from empty queue
        // Expected Result: Error for empty queue
        Console.WriteLine("Test 3");

        priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();

        // Defect(s) Found: No defects found

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}