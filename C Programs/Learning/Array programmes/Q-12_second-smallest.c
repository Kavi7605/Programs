#include <stdio.h>

void main()
{
  //to find the second smallest element in an array.
    int k[5], i, j, tmp;
    printf("Enter 5 elements: ");
    for(i=0;i<5;i++)
    {
        scanf("%d", &k[i]);
    }
    for(i=0;i<5;i++)
    {
        for(j=i+1;j<5;j++)
        {
            if(k[i]>k[j])
            {
                tmp=k[i];
                k[i]=k[j];
                k[j]=tmp;
            }
        }
    }
    for(i=0;i<5;i++)
    {
        printf("%d ", k[i]);
    }
    printf("\nSecond Smallest element is %d", k[1]);
}
