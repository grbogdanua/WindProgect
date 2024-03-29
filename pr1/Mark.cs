﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
	[Serializable]
	public enum StudentType
	{
		Excellent,
		Good,
		Bad,
		Stupid,
		Verystupid
	}
	[Serializable]
	public class Mark
	{
		public int[] Marks { get; set; }
		public StudentType AverageMark { get; set; }

		public Mark(int[] marks)
		{
			Marks = marks;
			AverageMark = Average(Marks);
		}
		public Mark()
		{
			//Console.WriteLine("Please write 5 marks.");
			//Console.Write("Mark: ");
			Marks = new int[5];
			Random random = new Random();
			for(int i = 0; i < 5; i++)
			{
				Marks[i] = random.Next(1, 5);
			}
			/*var enteredMark = Console.ReadLine();
			for (int i = 0; i < 5; i++)
			{
				int num;
				if (!int.TryParse(enteredMark, out num))
				{
					Console.WriteLine("Mark isn`t number. Try again.");
				}
				else
				{
					Marks[i] = num;
				}
				Console.Write("Mark: ");
				enteredMark = Console.ReadLine();
			}*/
			AverageMark = Average(Marks);
		}
		public StudentType Average(int[] marks)
		{
			int summ = 0;
			int count = 0;
			foreach (int mark in Marks)
			{
				summ += mark;
				count += 1;
			}
			switch (summ / count)
			{
				case 5:
					return (StudentType.Excellent);
				case 4:
					return (StudentType.Good);
				case 3:
					return (StudentType.Bad);
				case 2:
					return (StudentType.Stupid);
				default:
					return (StudentType.Verystupid);
			}
		}
		public void GetInfo()
		{
			Console.WriteLine($"Average Mark: {AverageMark}.");
		}
	}
}
