using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
	/// <summary>
	/// Stack contains element of selected dadta type. and stares lost value at the top of stack.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	class Stack<T>
	{

		public Node<T> stack;
		public Node<T> butom;
		public Node<T> top;


		/// <summary>
		/// Push ads an element to the top of  the stack
		/// </summary>
		/// <param name="NewNode"></param>
		public void Push(Node<T> NewNode)
		{
			
			if(stack != null)
			{
				Node<T>.count++;
				GetLast().next = NewNode;
				top = GetLast();


				return;
			}

			stack = NewNode;
			butom = stack;
			top = butom;
			Node<T>.count++;
		}


		/// <summary>
		/// Gets last element of the stack
		/// </summary>
		/// <returns></returns>
		/// 
		public Node<T> GetLast()
		{
			Node<T> current = stack;
			while (current.next != null)
			{
				current = current.next;
			}
			return current;
		}


		/// <summary>
		/// prints all the elements of the stack
		/// </summary>
		public void Print()
		{
			Node<T> Bottom = butom;
			
			while (Bottom != top)
			{
				Console.WriteLine(Bottom.value);
				Bottom = Bottom.next;			
			}

		}

		/// <summary>
		/// Delets last element of the stack.
		/// </summary>
		public void Pop()
		{
			Node<T> current = stack;

			while(current.next != top)
			{
				current = current.next;
			}

			top = null;
			top = current;
		}

		/// <summary>
		/// Returns value of the last element
		/// </summary>
		/// <returns></returns>
		public T Top()
		{
			Node<T> current = stack;

			T valueToReturn;

			while (current.next != top)
			{
				current = current.next;
			}
			valueToReturn = current.value;

			return valueToReturn;
		}


		/// <summary>
		/// Shaws if the stack is empty or not
		/// </summary>
		/// <returns></returns>
		public bool IsEmpty()
		{
			bool isEmpty = true;

			if (Node<T>.count > 0)
			{
				isEmpty = false;
			}

			return isEmpty;
		}

	}
}
