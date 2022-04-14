using static System.Console;
using System.Globalization;
public class TestClassifiedAd
{
   public static void Main()
   {
    ClassifiedAd firstAd = new ClassifiedAd();
    firstAd.Category = "Used cars";
    firstAd.Words = 100;
    ClassifiedAd secondAd = new ClassifiedAd();
    secondAd.Category = "Help wanted";
    secondAd.Words = 60;
    Display(firstAd);
    Display(secondAd);
   }
   
   static void Display(ClassifiedAd ad) {
     WriteLine("The classified ad with {0} words in category {1} costs {2}", ad.Words, ad.Category, ad.Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
     }
}

class ClassifiedAd
{
    private string category;
    private int words;
    private double price;
    public string Category {
      get {
        return category;
      }
      set {
        category = value;
      }
    }
    
    public int Words {
      get {
        return words;
      }
      set {
        words = value;
        CalcPrice();
      }
    }
    
    public double Price {
      get {
        return price;
      }
    }

    private void CalcPrice() 
    {
      price = words * .09;
    }
}
