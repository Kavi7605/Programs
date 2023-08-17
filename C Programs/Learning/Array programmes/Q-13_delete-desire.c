#include <stdio.h>

void main()
{
  //to delete an element at desired position from an array.
    int a[5], i, b, z=0;
    printf("Enter 5 values: \n");
    for(i=0;i<5;i++)
    {
        scanf("%d", &a[i]);
    }
    printf("Enter the position of the array to delete it:");
    scanf("%d", &b);
    printf("Before: \n");
    for(i=0;i<5;i++)
    {
        printf("%d ", a[i]);
    }
    a[b-1]=z;
    printf("\nAfter: \n");
    for(i=0;i<5;i++)
    {
        printf("%d ", a[i]);
    }
}
