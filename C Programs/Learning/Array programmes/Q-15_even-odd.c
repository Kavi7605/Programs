#include <stdio.h>

void main()
{
    //to separate odd and even number from input array to two separate arrays.
    int a[10], i, e[10], o[10], ec=0, oc=0;
    printf("Enter numbers: ");
    for(i=0;i<10;i++)
    {
        scanf("%d", &a[i]);
    }
    for(i=0;i<10;i++)
    {
        if(a[i] % 2 == 0)
        {
            e[ec++]=a[i];
        }
        else
        {
            o[oc++]=a[i];
        }
    }
    printf("Even numbers:");
    for(i=0;i<ec;i++)
    {
        printf("%d ", e[i]);
    }
    printf("\nOdd numbers:");
    for(i=0;i<oc;i++)
    {
        printf("%d ", o[i]);
    }
}
