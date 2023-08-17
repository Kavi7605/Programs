#include <stdio.h>

void main()
{
    //reverse the number
    int no, tmp=0;
    printf("Enter a number: ");
    scanf("%d", &no);

    while(no>0)
    {
        tmp=tmp*10;
        tmp=tmp+no%10;
        no=no/10;

    printf("tmp: %d, no: %d\n ", tmp,no);
    }
    printf("reverse no: %d", tmp);
}
