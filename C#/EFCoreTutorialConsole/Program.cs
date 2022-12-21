using System;
using System.Runtime.CompilerServices;

namespace EFCoreTutorialConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var context = new SchoolContext())
			{
				//-------------------------------------------
				//var std = new Student()
				//{
				//	Name = "Beyza"
				//};

				//context.Students.Add(std);

				//-------------------------------------------
				//var s = context.Students.Where(s => s.Name == "Beyza").ToList();

				//foreach (var str in s)
				//{
				//	Console.WriteLine(str.StudentId);
				//}
				//var std = context.Students.Where(x => x.Name == "Musa");

				//-------------------------------------------
				//foreach(var student in std)
				//{
				//	context.Students.Remove(student);
				//}

				//context.SaveChanges();

				//-------------------------------------------

				//var std = context.Students.First<Student>();
				//std.Name = "Musa";
				//context.SaveChanges();

				//--------------------------------------------

				//var std = context.Students.Find(8);
				//std.Name = "Rumeysa";
				//context.SaveChanges();

				//--------------------------------------------

				//var std = context.Students.Single(s => s.Name == "Furkan");
				//std.Name = "Musa";
				//context.SaveChanges();

				//--------------------------------------------

				var std = context.Students.Where(s => s.Name == "Furkan");
				foreach(var st in std)
				{
					st.Name = "Musa";
				}
				context.SaveChanges();
			}
		}
	}
}