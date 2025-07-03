public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // 1. Create an array of doubles with the size of 'length'.        
        double[] multiples = new double[length];

        // 2. Use a loop to iterate from 0 to length.
        for (int i = 0; i < length; i++)
        {
            // 3. In each iteration, calculate the multiple of 'number' by multiplying it with the current index + 1.
            double multiple = number * (i + 1);
            
            // 4. Store the result in the corresponding index of the array.
            multiples[i] = multiple;
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // If the list is empty, do nothing
        if (data.Count == 0) return;

        // Step 1: Find the real number of positions to move
        // Use % to handle cases where amount is bigger than the list size
        int positionsToMove = amount % data.Count;

        // Step 2: If we don't need to move anything, stop
        if (positionsToMove == 0) return;

        // Step 3: Copy the last 'positionsToMove' numbers to a new list
        List<int> lastNumbers = new List<int>();
        for (int i = data.Count - positionsToMove; i < data.Count; i++)
        {
            lastNumbers.Add(data[i]);
        }

        // Step 4: Remove those numbers from the end of the list
        for (int i = 0; i < positionsToMove; i++)
        {
            data.RemoveAt(data.Count - 1); // Remove the last number each time
        }

        // Step 5: Add the saved numbers to the start of the list
        for (int i = lastNumbers.Count - 1; i >= 0; i--)
        {
            data.Insert(0, lastNumbers[i]); // Add each number at the beginning
        }
    }
}
