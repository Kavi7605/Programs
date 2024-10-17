import java.util.LinkedList;

class StudentRecord {
    int studentID;
    int score;

    public StudentRecord(int studentID, int score) {
        this.studentID = studentID;
        this.score = score;
    }

    @Override
    public String toString() {
        return "(" + studentID + ", " + score + ")";
    }
}

class HashTable {
    private final int size;
    private final LinkedList<StudentRecord>[] chainTable;
    private final StudentRecord[] linearTable;

    public HashTable(int initialSize) {
        this.size = getNextPrime(initialSize);
        this.chainTable = new LinkedList[size];
        this.linearTable = new StudentRecord[size];

        for (int i = 0; i < size; i++) {
            chainTable[i] = new LinkedList<>();
        }
    }

    private int hash(int key) {
        return key % size;
    }

    public void insertChaining(int studentID, int score) {
        int index = hash(studentID);
        chainTable[index].add(new StudentRecord(studentID, score));
    }

    public void insertProbing(int studentID, int score) {
        int index = hash(studentID);
        while (linearTable[index] != null) {
            index = (index + 1) % size; 
        }
        linearTable[index] = new StudentRecord(studentID, score);
    }

    public void deleteChaining(int studentID) {
        int index = hash(studentID);
        chainTable[index].removeIf(record -> record.studentID == studentID);
    }

    public void deleteProbing(int studentID) {
        int index = hash(studentID);
        while (linearTable[index] != null) {
            if (linearTable[index].studentID == studentID) {
                linearTable[index] = null;
                break;
            }
            index = (index + 1) % size;
        }
    }

    public void displayChaining() {
        System.out.println("Using Separate Chaining:");
        for (int i = 0; i < size; i++) {
            System.out.print("table[" + i + "] ");
            if (chainTable[i].isEmpty()) {
                System.out.println();
            } else {
                for (StudentRecord record : chainTable[i]) {
                    System.out.print("--> " + record + " ");
                }
                System.out.println();
            }
        }
    }

    public void displayProbing() {
        System.out.println("Using Linear Probing:");
        for (int i = 0; i < size; i++) {
            System.out.print("table[" + i + "] ");
            if (linearTable[i] != null) {
                System.out.println("--> " + linearTable[i]);
            } else {
                System.out.println();
            }
        }
    }

    private int getNextPrime(int n) {
        while (!isPrime(n)) {
            n++;
        }
        return n;
    }

    private boolean isPrime(int n) {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.sqrt(n); i++) {
            if (n % i == 0) return false;
        }
        return true;
    }
}

public class Practical12 {
    public static void main(String[] args) {
        HashTable hashTable = new HashTable(6);

        hashTable.insertChaining(231, 123);
        hashTable.insertChaining(326, 432);
        hashTable.insertChaining(212, 523);
        hashTable.insertChaining(321, 43);
        hashTable.insertChaining(433, 423);
        hashTable.insertChaining(262, 111);
        hashTable.displayChaining();

        System.out.println("\nAfter deleting record with student ID 212:");
        hashTable.deleteChaining(212);
        hashTable.displayChaining();

        System.out.println("\nInserting using Linear Probing:");
        hashTable.insertProbing(231, 123);
        hashTable.insertProbing(326, 432);
        hashTable.insertProbing(212, 523);
        hashTable.insertProbing(321, 43);
        hashTable.insertProbing(433, 423);
        hashTable.insertProbing(262, 111);
        hashTable.displayProbing();

        System.out.println("\nAfter deleting record with student ID 212:");
        hashTable.deleteProbing(212);
        hashTable.displayProbing();
    }
}
