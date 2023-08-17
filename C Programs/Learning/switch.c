#include <stdio.h>

void main()
{
    int a, flag=1;
    char str[10];

    while(flag)
    {
        system("cls");
        printf("1. cat\n");
        printf("2. dog\n");
        printf("3. rabbit\n");
        printf("4. rat\n");
        //printf("Enter your choice: ");
        //scanf("%d", &a);

        printf("Enter str: ");
        scanf("%s", str);
        switch(str[0])
        {
            case '1':
                    printf("you selected cat. %s\n",str);
                    flag=0;
                    break;
            case '2':
                    printf("you selected dog\n");
                    flag=0;
                    break;
            case '3':
                    printf("you selected rabbit\n");
                    flag=0;
                    break;
            case '4':
                    printf("you selected rat\n");
                    flag=0;
                    break;
            default:
                    printf("choice not found\n");
                    break;
        }
    }
}
