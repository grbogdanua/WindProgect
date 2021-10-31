using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
	class TeacherList
	{
		public List<Teacher> Teachers { get; private set; }

		public TeacherList(List<Teacher> teachers)
		{
			Teachers = new List<Teacher> { };
			Teachers.AddRange(teachers);
		}
		public TeacherList(Teacher teacher)
		{
			Teachers = new List<Teacher> { };
			Teachers.Add(teacher);
		}
		public TeacherList()
		{
			Teachers = new List<Teacher> { };
		}

		public void AddTeacher(Teacher teacher)
		{
			Teachers.Add(teacher);
		}
		public void AddTeacher()
		{
			Teachers.Add(new Teacher());
		}
		public void SortTechers()
		{
			Teachers.Sort();
		}
		/*public void GetInfo()
		{
			foreach (Teacher teacher in Teachers)
			{
				teacher.Getinfo();
			}
		}*/
		public void Serch(string teachersurname)
		{
			foreach (Teacher teacher in Teachers)
			{
				if (teacher.Surname == teachersurname)
				{
					//teacher.Getinfo();
				}
			}
		}
		/*public void WorkWithTeacher(string teachersurname)
		{
			foreach (Teacher teacher in Teachers)
			{
				if (teacher.Surname == teachersurname)
				{
					teacher.WorkWith();
				}
			}
		}*/
	}
}
