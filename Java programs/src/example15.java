class example15{
    int num;
    String name;
    float fee;
    example15(int num, String name, float fee){
        this.fee=fee;
        this.name=name;
        this.num=num;       
    }
    void display(){System.out.println(name +" "+ num +" "+ fee);}
}
class Test1{
    public static void main(String[] args) {
        example15 e1 = new example15(0, null, 0);
        example15 e2 = new example15(0, null, 0);
        e1.display();
        e2.display();
    }
}