var counter = 0;
// if an argument is passed on the command line, get it, otherwise set it to -1.  
var max = args.Length is not 0 ? Convert.ToInt32(args[0]) : -1;

// if max variable is -1, create an infinite loop.
// if max variable is not -1, create a loop and run it until the counter variable is equal to the max variable.
while(max is -1 || counter < max)
{
    // counter variable is incremented by 1 and printed to the console.
    Console.WriteLine($"counter: {++counter}");
    // wait 1 second.
    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
}