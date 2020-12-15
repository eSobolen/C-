using System;
using System.Collections;

class Program
{
	static void Main(string[] args)
	{
		StudentComparer studentComparer = new StudentComparer();
		Student[] students = {
				new Student("Bill",1999,6,7,9),
				new Student("Tom",2001,8,9,4),
				new Student("Nick",2000,8,10,7),
				new Student("Ted",2001,8,9,9),
				new Student("Alex",2000,7,6,5)
			};

		int sortedHead = 0;
		for (int i = 0; i < students.Length; i++)
		{
			for (int j = sortedHead; j < students.Length; j++)
			{
				if (students[i].Year > students[j].Year)
				{
					(students[i], students[j]) = (students[j], students[i]);
				}
			}
			sortedHead++;
		}

		Console.WriteLine("Sorted by Year");

		foreach (Student student in students)
		{
			student.print();
		}

		Array.Sort(students, studentComparer);

		Console.WriteLine("Sorted by Name");

		foreach (Student student in students)
		{
			student.print();
		}
	}
}

class Human : IComparable<Human>
{
	private string name;
	private int year;
	private string state;

	public string Name
	{
		set { name = value; }
		get { return name; }
	}

	public int Year
	{
		set { year = value; }
		get { return year; }
	}

	public Human() { }

	public Human(string name, int year, string state)
	{
		this.name = name;
		this.year = year;
		this.state = state;
	}

	public void print()
	{
		Console.WriteLine(name + ";" + year + ";" + state + ";");
	}

	public virtual int info()
	{
		return DateTime.Today.Year - year;
	}

	public int CompareTo(Human p)
	{
		return this.Name.CompareTo(p.name);
	}
}

class Student : Human
{
	private int gradeMath;
	private int gradePhisics;
	private int gradeHistory;

	public Student() : base() { }

	public Student(string name, int year, int gradeMath, int gradePhisics, int gradeHistory) : base(name, year, "Student")
	{
		this.gradeMath = gradeMath;
		this.gradePhisics = gradePhisics;
		this.gradeHistory = gradeHistory;
	}

	public double getAvarageGrade()
	{
		return (gradeHistory + gradeMath + gradePhisics) / 3.0;
	}

	public int Info()
	{
		int[] grades = new int[3];
		grades[0] = gradePhisics;
		grades[1] = gradeMath;
		grades[2] = gradeHistory;
		return grades.max();
	}
}

class StudentComparer : IComparer
{
	public int Compare(object x, object y)
	{
		return string.Compare(((Student)x).Name, ((Student)y).Name);
	}
}
