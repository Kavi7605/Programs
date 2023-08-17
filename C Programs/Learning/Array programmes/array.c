#include <stdio.h>

const int CITY = 2;
void main()
{
    int i,j, n, sum=0;
    //printf("c: %d\n", CITY);

    int x[5], y[5], result[5];

    for(i=0;i<5;i++)
    {
     printf("Enter x[%d]: ",i);
     scanf("%d", &x[i]);
    }
    for(i=0;i<5;i++)
    {
     printf("Enter y[%d]: ",i);
     scanf("%d", &y[i]);
    }

    for(i=0;i<5;i++)
    {
        result[i]=x[i]+y[4-i];
        printf("Addition of %d + %d = %d\n",x[i], y[4-i], result[i]);
    }
/*
    printf("Enter your name1: ");
    fgets(array, sizeof(array), stdin);
    puts(array);

    printf("Enter your name2: ");
    fgets(str, sizeof(str), stdin);
    puts(str);*/
/*
    displayString(array, 10);
    printf("main.array: %s, main.i: %d\n",array, i);

    displayString(str,i);
  printf("\nmain.str: %s, num: %d",str, i);*/
}

void displayString(char r[], int a)
{
    printf("original name %s and value: %d\n", r, a);

    printf("enter new name: ");
    gets(r);
    printf("enter new value: ");
    scanf("%d",&a);

    printf("changed name '%s' and value: %d\n", r, a);
}

//scanf("%s", array);

    //printf("%s", array);
    /*for(i=0; array[i] != '\0';i++)
    {
        printf("%c", array[i]);
    }*/
/*
    int b[5]={10,20,30};
    for(i=0;i<5;i++)
    {
        printf("B[%d]:%d\n", i, b[i]);
    }
*/
/*  //Sum of N numbers using array
    printf("Enter a value of N: ");
    scanf("%d",&n);
    int k[n];
    for(i=0;i<n;i++)
    {
        printf("Enter a value: %d =", i);
        scanf("%d",&k[i]);
        sum=sum+k[i];
    }
    for(i=0;i<n-1;i++)
    {
        printf("%d+",k[i]);
    }
    printf("%d=%d", k[i], sum);
    printf("\n\n\n");*/

    /*int a[3][3]={{1,2,3},{4,5,6},{7,8,9}};
    for(i=0;i<3;i++)
    {
        for(j=0;j<3;j++)
        {
            printf("%d,",a[i][j]);
        }
        printf("\n");
    }
*/

//HW

/*
1. write a program to scan two arrays and merge them into third array.
output:
x[]
1
2
3

y[]
4
5
6
final result
res[]
1
2
3
4
5
6

2. write a program to scan two arrays and merge them into third array (in even odd index).
output:
x[]
1
2
3

y[]
4
5
6
final result
res[]
1x
4y
2x
5y
3x
6y


3. write a program to scan first name and last name of user and merge them into one array and print it.
output:
enter first name: kavya
enter last name: chavda
final result: kavya chavda


4. wap to scan user name and do addition of ascii values of the characters in the name.
output:
enter name: abc
65+66+67 = 180




*/
