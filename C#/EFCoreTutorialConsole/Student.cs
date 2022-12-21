using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorialConsole
{
	internal class Student
	{
		public int StudentId { get; set; }
		public string Name { get; set; }

		public Grade Grade { get; set; }
	}
}
