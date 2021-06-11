using System;

namespace Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<int> stack = new Stack<int>();

			for (int i = 0; i < 5; i++)
			{
				stack.Push(new Node<int>(i));
			}


			stack.Print();



			Console.WriteLine();

			stack.Pop();

			Console.WriteLine();



			Console.WriteLine(stack.top.value);

			Console.WriteLine();
			Console.WriteLine();

			stack.Print();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine(stack.Top());

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine(stack.IsEmpty());
	
		}
	}
}
