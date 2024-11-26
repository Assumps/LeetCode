using LeetCode.MergeSortedArray;
using LeetCode.RemoveDuplicatedFromSortedArray;
using LeetCode.RemoveElement;

int[] array1 = new int[] { 1, 2, 3, 0, 0, 0 };
int[] array2 = new int[] { 2, 5, 6 };
MergeSortedArray.Merge(array1, 3, array2, 3);

int[] arrayRemoved = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
var arraySize = RemoveElement.RemovesElement(arrayRemoved, 2);
Console.WriteLine( arraySize);

int[] removeDuplicated = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
var arrayDesduplicated = RemoveDuplicatesFromSortedArray.RemoveDuplicates(removeDuplicated);