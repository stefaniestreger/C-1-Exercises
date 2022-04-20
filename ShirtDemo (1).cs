using static System.Console;
class ShirtDemo
{
   static void Main()
   {
     Shirt[] s = new Shirt[10];
     Shirt shirt1 = new Shirt("Wool", "Black", "Large");
     Shirt shirt2 = new Shirt("Cotton", "Red", "Large");
     s[0] = shirt1;
     s[1] = shirt2;
     Display(s[0], s[1]);
   }
   
   public static void Display(params Shirt[] shirts)
   {
      for(int x=0; x < shirts.Length; ++x) {
        WriteLine("{0}, {1}, {2}", shirts[x].Material, shirts[x].Color, shirts[x].Size);
      }
   }
}

class Shirt
{
      public Shirt () {

      }

      public Shirt(string material, string color, string size) {
        Material = material;
        Color = color;
        Size = size;
      }

      public string Material {get; set;}
      public string Color {get; set;}
      public string Size {get; set;}
}
;
