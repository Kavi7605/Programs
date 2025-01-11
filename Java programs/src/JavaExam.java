class Counter {
    private int count = 0;

    // Synchronized method to ensure thread-safe increment
    public synchronized void increment() {
        count++;
    }

    public int getCount() {
        return count;
    }
}

class JavaExam extends Thread {
    Counter counter;

    JavaExam(Counter counter) {
        this.counter = counter;
    }

    public void run() {
        for (int i = 0; i < 1000; i++) {
            counter.increment();
        }
    }

    public static void main(String[] args) {
        Counter counter = new Counter();
        
        JavaExam thread1 = new JavaExam(counter);
        JavaExam thread2 = new JavaExam(counter);

        thread1.start();
        thread2.start();

        try {
            thread1.join();
            thread2.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        // Expected count should be 2000 if synchronization is correct
        System.out.println("Final Count: " + counter.getCount());
    }
}

// class RunnableDemo implements Runnable {
//     public void run() {
//         System.out.println("Thread running using Runnable interface.");
//     }

//     public static void main(String[] args) {
//         RunnableDemo runnable = new RunnableDemo();
//         Thread thread = new Thread(runnable);
//         thread.start();
//     }
// }

// class ExceptionDemo extends Thread {
//     public void run() {
//         try {
//             Thread.sleep(1000);
//             System.out.println("Thread execution.");
//         } catch (InterruptedException e) {
//             System.out.println("Thread was interrupted.");
//         }
//     }

//     public static void main(String[] args) {
//         ExceptionDemo thread = new ExceptionDemo();
//         thread.start();
//         thread.interrupt();  // Interrupts the thread during sleep
//     }
// }

// class ThreadMethodsDemo extends Thread {
//     public void run() {
//         System.out.println(Thread.currentThread().getName() + " is running.");
//     }

//     public static void main(String[] args) {
//         ThreadMethodsDemo thread1 = new ThreadMethodsDemo();
//         ThreadMethodsDemo thread2 = new ThreadMethodsDemo();
        
//         thread1.setName("First Thread");
//         thread2.setName("Second Thread");

//         thread1.start();
//         thread2.start();

//         try {
//             thread1.join();  // Main thread waits for thread1 to finish
//         } catch (InterruptedException e) {
//             e.printStackTrace();
//         }
        
//         System.out.println(thread1.getName() + " has finished execution.");
//     }
// }
// class PriorityDemo extends Thread {
//     public void run() {
//         System.out.println(Thread.currentThread().getName() + " with priority " + Thread.currentThread().getPriority() + " is running.");
//     }

//     public static void main(String[] args) {
//         PriorityDemo thread1 = new PriorityDemo();
//         PriorityDemo thread2 = new PriorityDemo();
//         PriorityDemo thread3 = new PriorityDemo();

//         thread1.setPriority(Thread.MIN_PRIORITY);  // Priority 1
//         thread2.setPriority(Thread.NORM_PRIORITY); // Priority 5
//         thread3.setPriority(Thread.MAX_PRIORITY);  // Priority 10

//         thread1.start();
//         thread2.start();
//         thread3.start();
//     }
// }
