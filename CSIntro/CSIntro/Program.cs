using System;

class HelloCSharp
{
	static void Main()
	{
		/*throw new System.NotImplementedException ("Intended exception.");
		System.Console.WriteLine ("Hello C# !!");*/
		CSIntro.Name.main ();
		Console.WriteLine ("Good Day !");
		DateTime now = DateTime.Now;
		Console.WriteLine (now);
		Double squareroot = Math.Sqrt (12345);
		Console.WriteLine (squareroot);
		for (int i = 2; i <= 100; i++) {
			if (i % 2 != 0) {
				Console.WriteLine (-i);
			} else {
				Console.WriteLine (i);
			}
		}
	}
}