#include <stdio.h>

void main()
{
  //to insert new value in the array.
    int v[5], c, h, i;
    printf("Enter 5 numbers: \n");
    for(i=0;i<5;i++)
    {
        scanf("%d", &v[i]);
    }
    printf("You entered:");
    for(i=0;i<5;i++)
    {
        printf("%d ", v[i]);
    }
    printf("\nEnter the index to change it: ");
    scanf("%d", &c);
    printf("Enter a new value: ");
    scanf("%d", &h);
    v[c-1]=h;
    for(i=0;i<5;i++)
    {
        printf("%d ", v[i]);
    }
}
