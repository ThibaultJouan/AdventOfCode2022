// See https://aka.ms/new-console-template for more information

using AOC;

var inputs = FileInterraction.ReadWholeContent("C:\\Users\\ThibaultJOUAN\\OneDrive - QuartzX\\Bureau\\AOC\\jour2.txt").ToList();

Jour1 j1 = new Jour1(inputs);
Jour2 j2 = new Jour2(inputs);

var result1 = j2.Resolve1();
var result2 = j2.Resolve2();


Console.WriteLine(result1);
Console.WriteLine(result2);