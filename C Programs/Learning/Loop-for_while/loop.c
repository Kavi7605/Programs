#include <stdio.h>

void main()
{
    int a1=10, a2=20, a3=30;
    int i, j, size , sum=0, arr[10];
/*
    // * pattern
    printf("Enter number of rows: ");
    scanf("%d", &size);

    for(i=size-1;i>0;i--)
    {
        for(j=0;j<i;j++)
        {
            printf("* ");
        }
        for(j=0;j<size-i;j++)
        {
            printf("%d ", j);
        }
        printf("\n");
    }

    for(i=1;i<size;i++)
    {

        for(j=0;j<i;j++)
        {
            printf("*");
        }
        printf("\n");
    }
    printf("\n");
    for(i=size-1;i>0;i--)
    {
        for(j=0;j<i;j++)
        {
            printf("*");
        }
        printf("\n");
    }

    printf("Enter number of rows: ");
    scanf("%d", &size);
    for(i=1;i<size;i++)
    {

        for(j=0;j<i;j++)
        {
            printf("%d",i);
        }
        printf("\n");
    }


    //AtoZ 10 lines
    for(j=0;j<10;j++)
    {

        for(i=65;i<91;i++)
        {
            printf("%c", i);
        }
        printf("\n");
    }
        //AtoZ
        for(i=65;i<91;i++)
        {
            printf("%c", i);
        }
*/
    //sum of 10 values using for loop
    printf("Enter a 10 values: ");
    for(i=0; i < 10; i++)
    {
        scanf("%d", &arr[i]);
        sum = sum +  arr[i];
    }
    printf("%d", sum);
/*
    //sum of 10 values using while loop
    i=0;
    printf("Enter a 10 values: ");
    while (i<10)
    {
        scanf("%d", &arr[i]);
        sum = sum +  arr[i];
        i++;
    }
    printf("Sum of all values: %d", sum);

    printf("A1 : %d\n",a1);
    printf("A2 : %d\n",a2);
    printf("A3 : %d\n",a3);

    //for(init; condition; increment)

    for(i=1; i < 10; i++)
    {
        printf("FOR: Value of I: %d\n",i);
    }

    //while(condition)
    while (i<20)
    {
        printf("WHILE: Value of I: %d\n",i);
        i++;
    }
    */

    char str[] = "hello";

    char str{10];

    str = "hello";

    printf("\n\n\n");
}

