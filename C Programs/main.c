#include <stdio.h>
#include <stdlib.h>

void main()
{
    //single line comment
    /*multi-line comment
    line 2*/
/*
    printf("Escape Characters \n");
    printf("new line \n");
    printf("kavya \t chavda \n");
    printf("\\ \n");
    printf("\' \n");
    printf("\" \n");
*/
    //get user input
    int a, b, c, d;
    printf("enter a value for A: ");
    scanf("%d",&a);
    printf("enter a value for B: ");
    scanf("%d",&b);


/*
    // addition
    int a, b, c, d;
    a=5610;
    b=2783;
    c=8279;
    d=a+b+c;
    printf("a+b+c = d \n");
    printf("%d+%d+%d = %d",a,b,c,d);


    // substraction
    int a=50, b=30, c=20, d;
    d=a-b-c;
    printf("a-b-c = d \n");
    printf("%d-%d-%d = %d",a,b,c,d);


    // multi
    int a=2, b=3, c=4, d;

    d=a*b*c;
    printf("a*b*c = d \n");
    printf("%d*%d*%d = %d",a,b,c,d);


    //Division
    int a=5, b=10, d;

    d=a/b;
    printf("a/b = d \n");
    printf("%d/%d = %d \n",a,b,d);
*/
    d=a%b;
    printf("a%b = d \n");
    printf("%d mod %d = %d \n",a,b,d);
/*
    float a=5 ,b=10 ,c=3 ,d=5 ,E;
    E=a/(b+c)*d;
    printf("a/b+c*d = E \n");
    printf("%0.2f/%0.2f+%0.2f*%0.2f = %0.2f \n",a,b,c,d,E);

       float age;

   age = 87.68478;
   printf("Kavya got %f Percentage in 10th.\n", age);

*/
    printf("\n\n\n\n");
    // homework +,-,*,/,% and use float
}
