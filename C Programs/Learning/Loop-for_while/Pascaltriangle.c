#include <stdio.h>
int main()
{
   int rows, coef = 1, k, i, j;
   printf("Enter the number of rows: ");
   scanf("%d", &rows);

   //
   for (i = 0; i < rows; i++){
    //append spaces
      for (k = 1; k <= (rows - i); k++)
            printf("  ");

    //prints the numbers
      for (j = 0; j <= i; j++)
        {
            //prints 1 at start of each row
            if (j == 0)
                coef = 1;

            //prints other numbers after 1
            else
                coef = coef * (i - j + 1) / j;

            printf("%4d", coef);
        }

      printf("\n");
   }
   return 0;
}

// coef = 5 * (5 - 5 + 1) / 5;
