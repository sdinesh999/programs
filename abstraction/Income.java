public class Income extends Person {
   private double Income;   // Annual salary
   
   public Income(String name, String address, int number, double Income) {
      super(name, address, number);
      setIncome(Income);
   }
   
   public void mailCheck() {
      System.out.println("Within mailCheck of Salary class ");
      System.out.println("Mailing check to " + getName() + " with income " + Income);
   }
 
   public double getIncome() {
      return Income;
   }
   
   public void setIncome(double newIncome) {
      if(newIncome >= 0.0) {
         Income = newIncome;
      }
   }
   
   public double computePay() {
      System.out.println("Computing salary pay for " + getName());
      return Income/52;
   }
}
