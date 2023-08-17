class Employee{
    int rollno;
    String name;
    float fee;
    Employee(int rollno,String name,float fee){
        this.rollno=rollno;
        this.name=name;
        this.fee=fee;
    }
    void display(){System.out.println(rollno+" "+name+" "+fee);}
}

class example15{
    public static void main(String args[]){
        Employee e1 = new Employee(111,"ankit",5000f);
        Employee e2 = new Employee(112,"sumit",6000f);
        e1.display();
        e2.display();
    }
}