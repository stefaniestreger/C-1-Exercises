 using static System.Console;
class CarDemo
{
   static void Main()
   {
    Car car1 = new Car("Civic", 38.50);
    Car car2 = new Car("Honda");
    Display("Before: ", car1);
    Display("After: ", car1);
    Display("Before: ", car2);
    Display("After: ", car2);
   }
   
   public static void Display(string message, Car s)
   {
    WriteLine("{0}{1}, {2}", message, s.Model, s.Mpg);
   }
}  

class Car 
{
   public Car(string model, double mpg = 20) {
     this.Model = model;
     this.Mpg = mpg;
   }

   public string Model {get; set;}
   public double Mpg {get; set;}

   public static Car operator ++(Car a) {
     a.Mpg++;
     return a;
   }
}
