using System;

public class Employee{
    private string firstname;
    private string lastname;
    private string id;
    private int age;
    private string address;
    private string title;
    private double yearlysalary;
    private string employmentstatus;


  public string FirstName{get; set;}
  public string LastName{get; set;}
  public int Age{
    get{return age;}
    set{if (value>=18)
      age = value;
    else
      age = 18;
      }}
  public double YearlySalary{
    
    get{return yearlysalary;}
    set{if (value>=1000)
      yearlysalary = value;
    else
      yearlysalary = 1000;
    }  }
  public string Id{get;set;}
  public string EmploymentStatus{get;set;}

  public Employee(){
    FirstName = "Unknown";
    LastName = "Unknown";
    Id = "Unknown";
    age = 0;
    EmploymentStatus = "active";

  }
  public Employee(string Firstname, string Lastname, string ID, int age,double Yearlysalary){
    FirstName= Firstname;
    LastName= Lastname;
    Id = ID;
    Age = age;
    EmploymentStatus= "active";
    YearlySalary = Yearlysalary;

  }
  public void intro(){
    Console.WriteLine("First name: "+FirstName);
    Console.WriteLine("Last name: "+LastName);
    Console.WriteLine("Age: "+Age);
    Console.WriteLine("Id: "+ Id);
    Console.WriteLine("Yearly Salary: "+ YearlySalary);
     }
  
  public void IncreaseSalary(double percent){
    if (percent>=0){
        YearlySalary = YearlySalary*percent/100+YearlySalary;
        Console.WriteLine("Yearly salary updated to "+YearlySalary);}
    else
      Console.WriteLine("invalid input. Yearly Salary not updated");
  }
  public void RemoveEmployee(){
    if (EmploymentStatus=="inactive")
      Console.WriteLine("Employee already inactive");
    else if(EmploymentStatus=="active"){
      EmploymentStatus = "inactive";
      Console.WriteLine("Employee removed");
    }
      
  }
}