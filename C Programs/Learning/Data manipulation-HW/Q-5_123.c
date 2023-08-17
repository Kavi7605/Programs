#include <stdio.h>

void main()
{
    //5.	Write a program in C to read any digit, display in the word. *
    int a[10];
    int size=0, i, no;
  //  printf("Enter total number you want to enter: ");
    //scanf("%d", &size);
    printf("Enter a number: ");
    scanf("%d", &no);

    for(i=0;no>0;i++)
    {
        a[i]=no%10;
        no=no/10;
        size++;
        //scanf("%d", &a[i]);
    }
    printf("Answer - \n");
    //for(i=0;i<size;i++)
    for(i=size-1;i>=0;i--)
    {
        switch(a[i])
        {
            case 0:
                printf("zero ");
                break;
            case 1:
                printf("one ");
                break;
            case 2:
                printf("two ");
                break;
            case 3:
                printf("three ");
                break;
            case 4:
                printf("four ");
                break;
            case 5:
                printf("five ");
                break;
            case 6:
                printf("six ");
                break;
            case 7:
                printf("seven ");
                break;
            case 8:
                printf("eight ");
                break;
            case 9:
                printf("nine ");
                break;
        }
    }
}
