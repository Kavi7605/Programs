#include <stdio.h>

void main()
{

/*  //1st
    float h, f;
    printf("Enter your Height in centimeter: ");
    scanf("%f", &h);
    float n=30.48;
    f=h/n;
    printf("Feet value: %.3f", f);
*/
/*  //3nd
    char alp;

    printf("Enter a Alphabet: ");
    scanf("%c", &alp);

    if(alp>='a' && alp<='z' || alp>='A' && alp<='Z')
    {
        switch(alp)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
                    printf("%c is a vowel", alp);
                    break;
            default:
                    printf("%c is a consonant", alp);
                    break;
        }
    }
    else
    {
        printf("ERROR: You didn't entered a alphabet.");
    }
*/
 //4th
/*    int d, flag=1;
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
*/
  //6th
/*    int d, flag=1;
    while(flag)
    {
        printf("Enter a number between 1-12: ");
        scanf("%d", &d);
        switch(d)
        {
            case 1:
                    printf("January");
                    break;
            case 2:
                    printf("February");
                    break;
            case 3:
                    printf("March");
                    break;
            case 4:
                    printf("April");
                    break;
            case 5:
                    printf("May");
                    break;
            case 6:
                    printf("June");
                    break;
            case 7:
                    printf("July");
                    break;
            case 8:
                    printf("August");
                    break;
            case 9:
                    printf("September");
                    break;
            case 10:
                    printf("October");
                    break;
            case 11:
                    printf("November");
                    break;
            case 12:
                    printf("December");
                    break;
            default:
                    printf("\nError: The number entered is not in range 1-12.");
                    flag=0;
                    break;
        }
    }*/
    /*
    char a;

    printf("Enter a character : ");
    scanf("%c", &a);
    if(a>=65 && a<=97 || a>=90 && a<=122)
    {
        printf("You entered a Alphabet.");
    }
    else if(a>=0 && a<=9)
    {
        printf("You entered a Digit.");
    }
    else
    {
        printf("You entered a Special character.");
    }
*/
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
