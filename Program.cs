var unsortedValues = new int[] { 29, 929, 44, 423, 3214, 64, 12, 662, 2, 1, 7, 79, 22, 41, 3, 112, 1 };
Console.WriteLine("Unsorted Items:");
Console.WriteLine(string.Join(", ", unsortedValues));
var sortedList = SelectionSortCode.GetSelectionSort(unsortedValues);
Console.WriteLine(string.Join(", ", sortedList));

