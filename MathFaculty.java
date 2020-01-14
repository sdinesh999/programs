class Faculty
{
    String designation = "Faculty";
    String clgname = "XYZ";
    void profession(){
        System.out.println("Teaching");
    }
}
public class MathFaculty extends Faculty
{
    String Subject = "Mathematics";
    public static void main(String args[])
    {
        MathFaculty MF = new MathFaculty();
        System.out.println(MF.clgname);
         System.out.println(MF.designation);
          System.out.println(MF.Subject);
          MF.profession();
    }
}