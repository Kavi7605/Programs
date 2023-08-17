#include <stdio.h>

void main()
{
  //6th
    int A[5], B[5], i, j=4;

    printf("Enter 5 values in array:\n");
    for(i=0;i<5;i++)
    {
        printf("A[%d]=", i);
        scanf("%d", &A[i]);
    }
    i=4;
    for(j=4;j>=0;j--)
    {
        B[j]=A[i-j];
    }
    printf("\nReverse array output:\n");
    for(i=0;i<5;i++)
    {
        printf("B[%d]=%d\n", i, B[i]);
    }
}
