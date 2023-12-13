// See https://aka.ms/new-console-template for more information



using ConsoleApp1;

//Заняття 2.1
//Заняття 2.1
//Заняття 2.1
//string Hello = "Hello, World!";
//int x = 10;

//Console.WriteLine(x);

//ModelStruct modelStruct = new ModelStruct
//{
//    x = 5
//};

//ModelClass modelclass = new ModelClass
//{
//    x = 5
//};

//Console.WriteLine(modelStruct.x);
//Console.WriteLine(modelclass.x);
//Console.ReadKey(true);

//MyFunctions.ProcessStruct(modelStruct);
//MyFunctions.ProcessClass(modelclass);

//Console.WriteLine(modelStruct.x);
//Console.WriteLine(modelclass.x);


//bool f = new();
//int i = new();
//var d = new double();
//Console.WriteLine("{0},{1},{2}", f, i, d);

double hyp = 4.0;
Console.WriteLine("{0:#.###}.", hyp);

bool logic ;

logic = false;

if (9 < 102) 
{
    logic = true;
}

Console.WriteLine("9<10 is" + logic);

Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
Console.WriteLine("bool.TrueString: {0}", bool.TrueString);

//Проверка на null
double? d3 = null;
if (d3.HasValue)
{
    Console.WriteLine("d3.HasValue" + d3.HasValue);
}
else
{
    Console.WriteLine("d3 іs null");
}

