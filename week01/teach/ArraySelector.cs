public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // create results list
        var results = new int[select.Length];

        // set indices for lists 1 & 2 to 0
        int indexList1 = 0;
        int indexList2 = 0;

        // foreach loop through the selector array
        foreach (int i in select)
        {
            // if the value is 1,
            if (select[i] == 1)
            {
                // add to the results the value at the current index for list1
                results[i] = list1[indexList1];
                // increment the index by 1
                indexList1++;
            }
            // elif the value is 2,
            else if (select[i] == 2)
            {
                // add to the results the value at the current index for list2
                results[i] = list2[indexList2];
                // increment the index by 1
                indexList2++;
            }
        }
        return results;
    }
}