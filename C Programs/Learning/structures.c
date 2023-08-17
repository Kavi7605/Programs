#include <stdio.h>
#include <string.h>

struct Laptops{
    char owner[10];
    char company[20];
    char model[20];
    int price;
    int ram;
    int rom;
};

struct Students {
    int no;
    char name[10];
    int submark[3];
};

void print(struct Laptops *lapi);

void main()
{
    struct Laptops kavi;
    struct Laptops adi;
    struct Students studs[3];

    studs[0].no = 24;
    strcpy(studs[0].name,"Kavi");
    studs[0].submark[0] = 34;
    studs[0].submark[1] = 45;
    studs[0].submark[2] = 56;

    studs[1].no = 01;
    strcpy(studs[1].name,"Adi");
    studs[1].submark[0] = 43;
    studs[1].submark[1] = 76;
    studs[1].submark[2] = 12;

    printd(&studs[0]);
    printd(&studs[1]);

    strcpy(kavi.owner,"Kavya");
    strcpy(kavi.company,"ASUS");
    strcpy(kavi.model,"DASH F15");
    kavi.price=99980;
    kavi.ram=16;
    kavi.rom=512;

    strcpy(adi.owner,"Aditi");
    strcpy(adi.company,"Lenevo");
    strcpy(adi.model,"Legion i5");
    adi.price=71260;
    adi.ram=8;
    adi.rom=512;

    print(&kavi);
    print(&adi);

    printf("\nSize of Laptop Structure: %d %d.", sizeof(struct Laptops), sizeof(struct Students));
}

void printd(struct Students *prinnt) {

    printf("Stud no: %d\n",prinnt->no);
    printf("Stud Name: %s\n",prinnt->name);
    printf("Sub1 Mark %d\n",prinnt->submark[0]);
    printf("Sub2 Mark %d\n",prinnt->submark[1]);
    printf("Sub3 Mark %d\n\n",prinnt->submark[2]);
}

void print(struct Laptops *lapi){
    printf("%s's Laptop Specifications\n", lapi->owner);
    printf( "Company: %s\n", lapi->company);
    printf( "Model: %s\n", lapi->model);
    printf( "Price: %d\n", lapi->price);
    printf( "RAM: %d\n", lapi->ram);
    printf( "ROM: %d\n\n", lapi->rom);
}
