// See https://aka.ms/new-console-template for more information

using AOC;

Console.WriteLine("Hello, World!");


var inputs = FileInterraction.ReadWholeContent("C:\\Users\\ThibaultJOUAN\\OneDrive - QuartzX\\Bureau\\AOC\\jour2.txt").ToList();

Jour1 j1 = new Jour1(inputs);
Jour2 j2 = new Jour2(inputs);

var result1 = j2.Resolve1();
//var result2 = j1.Resolve2();


Console.WriteLine(result1);
//Console.WriteLine(result2);


/*
A < B < C


A = pierre
B = papier
C = sciseaux

X = pierre
Y = papier
Z = sciseaux

1 = pierre
2 = papier
3 = sciseaux
    
    
//     1 2 3     
// 1   D W L
// 2   L D W
// 3   W L D


//     X Y Z     
// A   3 6 0
// B   0 3 6
// C   6 0 3


11 // D %11
12 // W
13 // L
21 // L
22 // D %11
23 // W
31 // W
32 // L
33 // D %11
*/
