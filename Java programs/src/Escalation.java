
public class Escalation {
    public static void main(String[] args) {
        Emp e1 = new Emp();
        e1.setEmpId(3);
        e1.setEmpName("Kavya");

            Emp e2 = new Emp();
            e2.setEmpId(4);
            e2.setEmpName("Chavda");

        System.out.println(e1.getEmpId());
    }
}

class Emp{
    private int empId;
    private String empName;

    public int getEmpId(){
        return empId;
    }

    public void setEmpId(int empId){
        this.empId = empId;
    }

    public String getEmpName(){
        return empName;
    }

    public void setEmpName(String empName){
        this.empName = empName;
    }
}