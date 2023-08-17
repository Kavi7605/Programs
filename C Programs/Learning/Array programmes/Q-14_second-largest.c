#include <stdio.h>

void main()
{
  //to find the second largest element in an array.
    int h[5], i, j, tmp;
    printf("Enter 5 elements:\n");
    for(i=0;i<5;i++)
    {
        scanf("%d", &h[i]);
    }
    for(i=0;i<5;i++)
    {
        for(j=i+1;j<5;j++)
        {
            if(h[i]<h[j])
            {
                tmp=h[i];
                h[i]=h[j];
                h[j]=tmp;
            }
        }
    }
    printf("Second Largest Element is %d", h[1]);
}
