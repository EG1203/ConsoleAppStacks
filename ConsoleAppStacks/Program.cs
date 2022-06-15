Stack<int> MyStack = new Stack<int>(Enumerable.Range(0, 100));
double StackAvg = MyStack.Where(x => (x & 1) == 0).Average();
foreach (var item in MyStack) 
Console.WriteLine(item);