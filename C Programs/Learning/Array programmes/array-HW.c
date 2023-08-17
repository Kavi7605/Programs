#include <stdio.h>

void main()
{
/* //1st
    int arr1[5], arr2[5], arr3[10], i;
    printf("Enter three values for arr1: \n");
    for(i=0;i<3;i++)
    {
        scanf("%d", &arr1[i]);
    }
    printf("Enter three values for arr2: \n");
    for(i=0;i<3;i++)
    {
        scanf("%d", &arr2[i]);
    }

    for(i=0;i<3;i++)
    {
        arr3[i]=arr1[i];
    }
    printf("Final result, arr3:\n%d\n%d\n%d\n", arr3[0],arr3[1],arr3[2]);

    for(i=0;i<3;i++)
    {
        arr3[i+3]=arr2[i];
    }
    printf("%d\n%d\n%d", arr3[3],arr3[4],arr3[5]);


*/
/*
 //3nd
    char fst[10], sur[10], full[20];
    int i, j;

    printf("Enter your first name: ");
    scanf("%s", fst);
    printf("Enter your surname: ");
    scanf("%s", sur);

    for(i=0;fst[i]!='\0';i++)
    {
        full[i]=fst[i];
    }
    full[i]=' ';
    j=++i;
    while(sur[i-j]!='\0')
    {
        full[i]=sur[i-j];
        i++;
    }
    full[i]='\0';
    puts(full);
*/
/*
    int arr1[5], arr2[5], arr3[10], i, j, k;
    printf("Enter three values for arr1: \n");
    for(i=0;i<3;i++)
    {
        scanf("%d", &arr1[i]);
    }
    printf("Enter three values for arr2: \n");
    for(i=0;i<3;i++)
    {
        scanf("%d", &arr2[i]);
    }

    for(i=0,j=0,k=0;i<6;i++)
    {
        if(i%2 == 0)
            arr3[i]=arr1[j++];
        else
            arr3[i]=arr2[k++];
    }

    printf("Final result, arr3:");
    for(i=0;i<6;i++)
    {
        printf("\n%d", arr3[i]);
    }
*/
/*
  //6th
    int A[5], B[5], i, j=4;

    printf("Enter 5 values in array:\n");
    for(i=0;i<5;i++)
    {
        printf("A[%d]=", i);
        scanf("%d", &A[i]);
    }
    i=4;
    for(j=4;j>=0;j--)
    {
        B[j]=A[i-j];
    }
    printf("\nReverse array output:\n");
    for(i=0;i<5;i++)
    {
        printf("B[%d]=%d\n", i, B[i]);
    }
*/
/*
    //1st Minimum
    int min, n, b;

    printf("Enter value for N: ");
    scanf("%d", &n);
    printf("Enter %d values: ", n);

    int a[n];
    for(b=0;b<n;b++)
    {
        scanf("%d", &a[b]);
    }
    min=a[0];
    for(b=1;b<n;b++)
    {
        if(min>a[b])
        {
            min=a[b];
        }
    }
    printf("\nMinimum value is: %d", min);
*/
/*
    //2st Maximum
    int b, n, max;

    printf("Enter value for N: ");
    scanf("%d", &n);
    int a[n];

    printf("Enter %d values: ", n);
    for(b=0;b<n;b++)
    {
        scanf("%d", &a[b]);
    }
    max=a[0];
    for(b=1;b<n;b++)
    {
        if(max<a[b])
        {
            max=a[b];
        }
    }
    printf("\nMaximum value is: %d", max);
*/
/*  //7th palindrome
    char str1[10], str2[10];
    int i, size=0;
    printf("Enter a String: ");
    scanf("%s", str1);

    while(str1[size] != '\0')
    {
        size++;
    }

    for(i=size-1;i>=0;i--)
    {
        str2[i] = str1[(size-1)-i];
    }
    str2[size]='\0';
    printf("rev: %s\n", str2);

    for(i=0;str1[i]==str2[i];i++){ }

    if(i==size+1)
    {
        printf("input string '%s' is palindrome.", str1);
    }
    else
    {
        printf("input string '%s' is not palindrome.", str1);
    }
*/
/*  //8th to sort elements of array in ascending order.
    int arr1[100];
    int n, i, j, tmp;
    printf("Input the size of array : ");
    scanf("%d", &n);
    printf("Input %d elements in the array :\n",n);
    for(i=0;i<n;i++)
    {
        printf("element - %d : ",i);
        scanf("%d",&arr1[i]);
    }
    for(i=0; i<n; i++)
    {
        for(j=i+1; j<n; j++)
        {
            if(arr1[j] <arr1[i])
            {
                tmp = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = tmp;
            }
        }
    }
    printf("\nElements of array in sorted ascending order:\n");
    for(i=0; i<n; i++)
    {
        printf("%d  ", arr1[i]);
    }
    printf("\n\n");
*/
  //9th to sort elements of the array in descending order.
/*    int arr1[100];
    int n, i, j, tmp;
    printf("Input the size of array : ");
    scanf("%d", &n);
    printf("Input %d elements in the array :\n",n);
    for(i=0;i<n;i++)
    {
        printf("element - %d : ",i);
        scanf("%d",&arr1[i]);
    }
    for(i=0; i<n; i++)
    {
        for(j=i+1; j<n; j++)
        {
            if(arr1[i] < arr1[j])
            {
                tmp = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = tmp;
            }
        }
    }
    printf("\nElements of array is sorted in descending order:\n");
    for(i=0; i<n; i++)
    {
        printf("%d  ", arr1[i]);
    }
    printf("\n\n");*/

/*    //to separate odd and even number from input array to two separate arrays.
    int a[10], i, e[10], o[10], ec=0, oc=0;
    printf("Enter numbers: ");
    for(i=0;i<10;i++)
    {
        scanf("%d", &a[i]);
    }
    for(i=0;i<10;i++)
    {
        if(a[i] % 2 == 0)
        {
            e[ec++]=a[i];
        }
        else
        {
            o[oc++]=a[i];
        }
    }
    printf("Even numbers:");
    for(i=0;i<ec;i++)
    {
        printf("%d ", e[i]);
    }
    printf("\nOdd numbers:");
    for(i=0;i<oc;i++)
    {
        printf("%d ", o[i]);
    }
*/
/*  //to insert new value in the array.
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
*/
/*    //to rotate an array by N positions.
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
*/
/*  //to delete an element at desired position from an array.
    int a[5], i, b, z=0;
    printf("Enter 5 values: \n");
    for(i=0;i<5;i++)
    {
        scanf("%d", &a[i]);
    }
    printf("Enter the position of the array to delete it:");
    scanf("%d", &b);
    printf("Before: \n");
    for(i=0;i<5;i++)
    {
        printf("%d ", a[i]);
    }
    a[b-1]=z;
    printf("\nAfter: \n");
    for(i=0;i<5;i++)
    {
        printf("%d ", a[i]);
    }
*/
/*  //to find the second smallest element in an array.
    int k[5], i, j, tmp;
    printf("Enter 5 elements: ");
    for(i=0;i<5;i++)
    {
        scanf("%d", &k[i]);
    }
    for(i=0;i<5;i++)
    {
        for(j=i+1;j<5;j++)
        {
            if(k[i]>k[j])
            {
                tmp=k[i];
                k[i]=k[j];
                k[j]=tmp;
            }
        }
    }
    for(i=0;i<5;i++)
    {
        printf("%d ", k[i]);
    }
    printf("\nSecond Smallest element is %d", k[1]);
*/
/*  //to find the second largest element in an array.
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
*/
//Write a program in C to count the frequency of each element of an array.
/*    int a[10], b[10], c[10], size=0, i, j;

    printf("Enter 10 values:\n");
    for(i=0;i<10;i++)
    {
        scanf("%d", &a[i]);
    }
    for(i=0;i<10;i++)
    {
        for(j=0;j<size;j++)
        {
            if(b[j]==a[i])
            {
                c[j]++;
                break;
            }
        }

        if(j>=size)
        {
            b[j]=a[i];
            c[j]=1;
            size++;
        }
    }

    for(i=0;i<size;i++)
    {
        printf("%d, %d\n", b[i], c[i]);
    }
*/
//Write a program in C to count a total number of duplicate and unique elements in an array.
 /*   int a[10], b[10], c[10], size=0, i, j, count=0;

    printf("Enter 10 values:\n");
    for(i=0;i<10;i++)
    {
        scanf("%d", &a[i]);
    }
    for(i=0;i<10;i++)
    {
        for(j=0;j<size;j++)
        {
            if(b[j]==a[i])
            {
                c[j]++;
                break;
            }
        }

        if(j>=size)
        {
            b[j]=a[i];
            c[j]=1;
            size++;
        }
    }

    for(i=0;i<size;i++)
    {
        printf("%d, %d\n", b[i], c[i]);
    }

    for(i=0;i<size;i++)
    {
        if(c[i]>1)
        {
            count++;
        }
    }
    printf("%d Number of duplicate element.", count);

    count=0;
    for(i=0;i<size;i++)
    {
        if(c[i]==1)
        {
            count++;
        }
    }
    printf("\n%d Number of Unique element.", count);

*/




}
