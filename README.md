# repo-for-final-work-gb
This is a repo with a simple prog for final work after completion of GB basic course.

The prog is for search of index of max value in an array, based on the following block-scheme:

![maxIndBlockSceme](https://github.com/MillaAlex/repo-for-final-work-gb/blob/main/maxIndBlockSceme.png)

The values in the array are already given but can be easily changed to being generated randomly.
The command to use for random filling:

- array[i] = new Random().Next(a, b);
where a & b the start and end numbers for the random.

- As the first step, the start variables were defined: current index, max number index, max (max value);
- On the second step, there was condition for check if the index does not exceed the array size;
- If it is in the limit, another condition was checked - if the current value is bigger than the originally assumed max value;
- If the current value is bigger than the originally assumed max value, it becomes new max, as well as its index becomes new max number index. At the same time the current index increases by 1. IF the current value is less than the originally assumed max value, the max remains unchanged and current index increases by 1;
- When the whole array is checked, the prog displays max number index and the value of this number.
