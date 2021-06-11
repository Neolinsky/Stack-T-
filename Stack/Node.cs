using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
	 class Node<T>
	{
		public Node<T> next;
		

		public T value;
		public static int count;


		public Node()
		{

		}


		public Node(T value)
		{
			this.value = value;
		}
	}
}
