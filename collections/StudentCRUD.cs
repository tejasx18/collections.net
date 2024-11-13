using System;
using System.Collections.Generic;


namespace collections
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public override string ToString()
        {
            return $"{Id} , {Name} , {Marks}";
        }
    }
    // Manage Students

    public class StudentCRUD
    {
        List<Student> Students;
        public StudentCRUD()
        {
            Students = new List<Student>(); 
        }

        public void AddStudent(Student stud)
        {
            Students.Add(stud);
        }
        public void ModifyStudent(Student stud)
        {
            
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Id == stud.Id)
                {
                    Students[i].Name = stud.Name;
                    Students[i].Marks = stud.Marks;
                    break;
                }
            }
        }
        public void DeleteStudent(int id)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Id == id)
                {
                    Students.Remove(Students[i]);
                    break;
                }
            }
        }
        public List<Student> StudentList()
        {
            return Students;
        }

        public Student GetStudentById(int id)
        {
            Student s = new Student();
            foreach (var item in Students)
            {
                if (item.Id == id)
                {
                    s.Id = item.Id;
                    s.Name = item.Name;
                    s.Marks = item.Marks;
                    break;
                }
            }
            return s;
        }

    }

    //public class DemoMain
    //{

    //    static void Main(string[] args)
    //    {
    //        StudentCRUD crud = new StudentCRUD();
    //        try
    //        {
    //            int a = 1;
    //            do
    //            {
    //                Console.WriteLine("1.Student List");
    //                Console.WriteLine("2.Add student");
    //                Console.WriteLine("3.Modify student");
    //                Console.WriteLine("4.Delete student");
    //                Console.WriteLine("5.Get student By Id");
    //                Console.WriteLine("Select option from above");
    //                int op = Convert.ToInt32(Console.ReadLine());

    //                switch (op)
    //                {
    //                    case 1:
    //                        List<Student> students = crud.StudentList();
    //                        Console.WriteLine("Id    Name    Marks");
    //                        foreach (var item in students)
    //                        {
    //                            Console.WriteLine(item);
    //                        }
    //                        break;
    //                    case 2:
    //                        Student s1 = new Student();
    //                        Console.WriteLine("Enter Id");
    //                        s1.Id = Convert.ToInt32(Console.ReadLine());
    //                        Console.WriteLine("Enter Name");
    //                        s1.Name = Console.ReadLine();
    //                        Console.WriteLine("Enter Marks");
    //                        s1.Marks = Convert.ToInt32(Console.ReadLine());
    //                        crud.AddStudent(s1);
    //                        Console.WriteLine("Added the student");
    //                        break;
    //                    case 3:
    //                        Student s2 = new Student();
    //                        Console.WriteLine("Enter existing Id");
    //                        s2.Id = Convert.ToInt32(Console.ReadLine());
    //                        Console.WriteLine("Enter new Name");
    //                        s2.Name = Console.ReadLine();
    //                        Console.WriteLine("Enter new Marks");
    //                        s2.Marks = Convert.ToInt32(Console.ReadLine());
    //                        crud.ModifyStudent(s2);
    //                        Console.WriteLine("updated the student");
    //                        break;
    //                    case 4:
    //                        Console.WriteLine("Enter existing Id to delete");
    //                        int id = Convert.ToInt32(Console.ReadLine());
    //                        crud.DeleteStudent(id);
    //                        Console.WriteLine("Deleted the student");
    //                        break;
    //                    case 5:
    //                        Console.WriteLine("Enter existing Id");
    //                        int id2 = Convert.ToInt32(Console.ReadLine());
    //                        Student s = crud.GetStudentById(id2);
    //                        Console.WriteLine(s);
    //                        break;
    //                }
    //                Console.WriteLine("Press 1 for continue or 0 to exit");
    //                a = Convert.ToInt32(Console.ReadLine());
    //            }

    //            while (a == 1);

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }
    //}


}
