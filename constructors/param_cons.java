class Param{  
    int id;  
    String name;  
    //creating a parameterized constructor  
    Param(int i,String n){  
    id = i;  
    name = n;  
    }  
    //method to display the values  
    void display(){System.out.println(id+" "+name);}  
   
    public static void main(String args[]){  
    //creating objects and passing values  
    Param s1 = new Param(22,"sai");  
    Param s2 = new Param(42,"dinesh");  
    //calling method to display the values of object  
    s1.display();  
    s2.display();  
   }  
}  