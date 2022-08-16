// void Method2(string msg) // Take arguments, return nothing
// {
//     Console.WriteLine(msg);
// }
// Method2("Text message"); 
// Method2(msg: "Text message"); // if point to the argument is needed

// void Method21(string msg, int count) // Take arguments, give nothing
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Matrix has you", 4); // "Text" is taken as argument by msg, 4 is taken as argument by count
// Method21(count: 4, msg: "Matrix has you"); // same result
// Method21(msg: "Matrix has you", count: 4); // same result