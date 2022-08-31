public static class SelectionSortCode
{
    //The way this algorithm works is by sending to the current position the smaller value, so you don't compare that value anymore because the previous index will not be compared in the next time it repeats the for loops
    public static int[] GetSelectionSort(int[] values)
    {
        //Get the array Size
        var size = values.Length;
        //Walk through all the elements
        for (var i = 0; i < size - 1; i++)
        {
            //set the small index as the current index(we don't know if it is)
            var smallerIndex = i;
            //Walk through all the other positions of the array
            for (var j = i + 1; j < size; j++)
            {
                //If any index is smaller than smallerIndex, set it to that value(j)
                if (values[j] < values[smallerIndex])
                    smallerIndex = j;
            }

            //create a temporary variable with the smaller VALUE
            var temp = values[smallerIndex];
            //set the value where the index is smaller to the value in the current position
            values[smallerIndex] = values[i];
            //Now put in the current index the smaller value
            values[i] = temp;
            //next run this value will be on the previous index, so it will not be compared because you can't fin it neither in indexes j or i
        }

        return values;
    }
}
