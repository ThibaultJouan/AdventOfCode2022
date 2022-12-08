// See https://aka.ms/new-console-template for more information

using AOC;

var inputs = FileInterraction.ReadWholeContent("C:\\Users\\ThibaultJOUAN\\OneDrive - QuartzX\\Bureau\\AOC\\jour6.txt").ToList();

var j1 = new Jour1(FileInterraction.ReadWholeContent("C:\\Users\\ThibaultJOUAN\\OneDrive - QuartzX\\Bureau\\AOC\\jour1.txt").ToList());
var j2 = new Jour2(FileInterraction.ReadWholeContent("C:\\Users\\ThibaultJOUAN\\OneDrive - QuartzX\\Bureau\\AOC\\jour2.txt").ToList());
var j3 = new Jour3(FileInterraction.ReadWholeContent("C:\\Users\\ThibaultJOUAN\\OneDrive - QuartzX\\Bureau\\AOC\\jour3.txt").ToList());
var j4 = new Jour4(FileInterraction.ReadWholeContent("C:\\Users\\ThibaultJOUAN\\OneDrive - QuartzX\\Bureau\\AOC\\jour4.txt").ToList());
var j5 = new Jour5(FileInterraction.ReadWholeContent("C:\\Users\\ThibaultJOUAN\\OneDrive - QuartzX\\Bureau\\AOC\\jour5.txt").ToList());
var j6 = new Jour6(FileInterraction.ReadWholeContent("C:\\Users\\ThibaultJOUAN\\OneDrive - QuartzX\\Bureau\\AOC\\jour6.txt").ToList());
var j7 = new Jour7(FileInterraction.ReadWholeContent("C:\\Users\\ThibaultJOUAN\\OneDrive - QuartzX\\Bureau\\AOC\\jour7.txt").ToList());
var j8 = new Jour8(FileInterraction.ReadWholeContent("C:\\Users\\ThibaultJOUAN\\OneDrive - QuartzX\\Bureau\\AOC\\jour8.txt").ToList());

var result1 = j4.Resolve1();
var result2 = j4.Resolve2();


Console.WriteLine(result1);
Console.WriteLine(result2);