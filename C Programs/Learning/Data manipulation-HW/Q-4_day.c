#include <stdio.h>

void main()
{
 //4th
    int d, flag=1;
    while(flag)
    {
        printf("Enter a number between 1-7: ");
        scanf("%d", &d);
        switch(d)
        {
            case 1:
                    printf("Monday");
                    break;
            case 2:
                    printf("Tuesday");
                    break;
            case 3:
                    printf("Wednesday");
                    break;
            case 4:
                    printf("Thursday");
                    break;
            case 5:
                    printf("Friday");
                    break;
            case 6:
                    printf("Saturday");
                    break;
            case 7:
                    printf("Sunday");
                    break;
            default:
                    printf("\nError: The number entered is not in range 1-7.");
                    flag=0;
                    break;
        }
    }
}
