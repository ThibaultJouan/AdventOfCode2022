// See https://aka.ms/new-console-template for more information

using AOC;

var inputs = FileInterraction.ReadWholeContent("C:\\Users\\ThibaultJOUAN\\OneDrive - QuartzX\\Bureau\\AOC\\jour5.txt").ToList();

Jour1 j1 = new Jour1(inputs);
Jour2 j2 = new Jour2(inputs);
Jour3 j3 = new Jour3(inputs);
Jour4 j4 = new Jour4(inputs);
Jour5 j5 = new Jour5(inputs);

var result1 = j5.Resolve1();
var result2 = j5.Resolve2();


Console.WriteLine(result1);
Console.WriteLine(result2);