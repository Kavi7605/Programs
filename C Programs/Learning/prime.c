#include <stdio.h>

void main()
{
    int n, i, count=0;
    printf("Enter a number: ");
    scanf("%d", &n);

    for(i=1;i<n;i++)
    {
        if(n%i==0) count++;
        //count = count + ((n%i == 0) ? 1 : 0);
        if(count>1) break;
    }

    if(count==1)
    {
        printf("%d is a prime number.", n);
    }
    else
    {
        printf("%d is not a prime number.", n);
    }
}
