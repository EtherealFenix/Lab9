using System;

class MainClass {

  

  
public static void Main (string[] args) {
  Employee Employee1 = new Employee(); 
  Employee1.intro();
  Employee Employee2 = new Employee("Robert", "Downey", "12321", 12,0);
  Employee2.YearlySalary = 100;
  Employee2.intro();
  Employee Employee3 =new Employee("John", "Smith","S0089", 38,50000);
  Employee3.intro();
  Employee3.IncreaseSalary(-2);
  Employee Employee4 = new Employee("Maria", "Lambert", "S0100",26,80000);
  Employee4.intro();
  Employee4.IncreaseSalary(7); 
  Employee4.RemoveEmployee();
  Employee4.RemoveEmployee();
  }
}