using System;

class MainClass {

  public class Employee{
    private string firstname;
    private string lastname;
    private string id;
    private int age;
    private string address;
    private string title;
    private double yearlysalary;
    private string employmentstatus;

  
  public Employee(){
    firstname = "Unknown";
    lastname = "Unknown";
    id = "Unknown";
    age = 0;
    employmentstatus = "active";

  }
  public Employee(string Firstname, string Lastname, string Id, int Age){
    firstname= Firstname;
    lastname= Lastname;
    id = Id;
    age = Age;
    employmentstatus= "active";

  }
  public void intro(){
    Console.WriteLine(firstname);
    Console.WriteLine(lastname);
    Console.WriteLine(id);
    Console.WriteLine(age);
    Console.WriteLine(employmentstatus);
  }
  }

  
public static void Main (string[] args) {
  Employee Jack = new Employee(); 
  Jack.intro();
  Employee John = new Employee("john", "smith", "1234", 45);
  John.intro();
   
  }
}