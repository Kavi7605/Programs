#include <stdio.h>

void main()
{
    //to rotate an array by N positions.
    int q[5], i, j, k, tmp[5];
    printf("Enter 5 values: \n");
    for(i=0;i<5;i++)
    {
        scanf("%d", &q[i]);
    }
    printf("You entered: ");
    for(i=0;i<5;i++)
    {
        printf("%d ", q[i]);
    }
    printf("\nEnter the number to rotate the array: ");
    scanf("%d", &j);

//    k=j; // (1,0,-1)
    j=j%5;

   // printf("jk: %d %d",j,k);

    for(i=0;i<5;i++)
    {
        //printf("i: %d",i);
        if(j>4) j=0;
        //j=+k
        tmp[i]=q[j++];
        //j=j+k;   //j++
    }
    for(i=0;i<5;i++)
    {
        printf("\n%d ", tmp[i]);
    }
}
