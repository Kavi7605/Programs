#include <stdio.h>

void main()
{
    //1st
    int arr1[5], arr2[5], arr3[10], i;
    printf("Enter three values for arr1: \n");
    for(i=0;i<3;i++)
    {
        scanf("%d", &arr1[i]);
    }
    printf("Enter three values for arr2: \n");
    for(i=0;i<3;i++)
    {
        scanf("%d", &arr2[i]);
    }

    for(i=0;i<3;i++)
    {
        arr3[i]=arr1[i];
    }
    printf("Final result, arr3:\n%d\n%d\n%d\n", arr3[0],arr3[1],arr3[2]);

    for(i=0;i<3;i++)
    {
        arr3[i+3]=arr2[i];
    }
    printf("%d\n%d\n%d", arr3[3],arr3[4],arr3[5]);
}
