public class AbstractionDemo {

   public static void main(String [] args) {
      Income s = new Income("Sai", "Kumar, UP", 3, 3600.00);
      Person e = new Income("John", "Boston, MA", 2, 2400.00);
      System.out.println("access the data using employee id");
      s.mailCheck();
      System.out.println("\n access the data using employee id");
      e.mailCheck();
   }
}
