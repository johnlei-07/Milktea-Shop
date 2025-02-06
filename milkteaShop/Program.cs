// See https://aka.ms/new-console-template for more information


using System.Numerics;
using System.Runtime.CompilerServices;

static void productList(){
    String[] products = { "\n[1] WINTERMELON                                SIZES",
        "[2] TARO                            SMALL      MEDIUM     LARGE ",
        "[3] MOCHA                         PHP 50.00  PHP 75.00   PHP 100.00",
        "[4] COOKIES N CREAM",
        "[5] CHOCOLATE                               SUGAR LEVEL",
        "[6] DARK CHOCOLATE                         LEVEL 0 = 0%",
        "[7] CARAMEL                                LEVEL 1 = 25%",
        "[8] MOCHA                                  LEVEL 2 = 50%",
        "[9] STRAWBERRY                             LEVEL 3 = 75%",
        "[10] VANILLA                               LEVEL 4 = 100%",
        "[11] YOUR ORDERLIST",
        "[12] PAYMENT",
        "[13] EXIT/DONE\n"
    };
    foreach (String show in products) {
        Console.WriteLine(show);
    }
  
}

static void sizesList() {
   
    String[] sizes = {"SMALL    PHP 50.00",
    "MEDIUM    PHP 75.00",
    "LARGE     PHP 100.00",
    "SELECT [s] SMALL [m] MEDIUM [l] LARGE"
    };
    
    foreach (String show in sizes) {
        Console.WriteLine(show);
    }
}

static void sugarlvlList() {
    
    String[] sugarlvl = {"SUGAR LEVEL",
    "SELECT [0] = 0%",
    "SELECT [1] = 25%",
    "SELECT [2] = 50%",
    "SELECT [3] = 75%",
    "SELECT [4] = 100%"
    };
    
    foreach (String show in sugarlvl) {
        Console.WriteLine(show);
    }
}

static void showOrder(int orderCount, String[] cart, int total) {
    for (int i = 0; i < orderCount; i++) {
        Console.WriteLine(cart[i]);
    }
    Console.WriteLine("TOTAL: PHP " + total);
}

static void computationS(ref int total, ref int orderCount, int quantityS,  int perOrder, int sugarlvlS, String[] cart,int select) {
    
    perOrder = quantityS * 50;
    total += perOrder;
    if (select == 1)
    {
        cart[orderCount] = "WINTERMELON" + "\n[SMALL]" + "\nLEVEL " + sugarlvlS + "\n" + quantityS + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 2)
    {
        cart[orderCount] = "TARO" + "\n[SMALL]" + "\nLEVEL " + sugarlvlS + "\n" + quantityS + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 3)
    {
        cart[orderCount] = "MOCHA" + "\n[SMALL]" + "\nLEVEL " + sugarlvlS + "\n" + quantityS + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 4)
    {
        cart[orderCount] = "COOKIES N CREAM" + "\n[SMALL]" + "\nLEVEL " + sugarlvlS + "\n" + quantityS + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 5)
    {
        cart[orderCount] = "CHOCOLATE" + "\n[SMALL]" + "\nLEVEL " + sugarlvlS + "\n" + quantityS + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 6)
    {
        cart[orderCount] = "DARK CHOCOLATE" + "\n[SMALL]" + "\nLEVEL " + sugarlvlS + "\n" + quantityS + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 7)
    {
        cart[orderCount] = "CARAMEL" + "\n[SMALL]" + "\nLEVEL " + sugarlvlS + "\n" + quantityS + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 8)
    {
        cart[orderCount] = "MOCHA" + "\n[SMALL]" + "\nLEVEL " + sugarlvlS + "\n" + quantityS + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 9)
    {
        cart[orderCount] = "STRAWBERRY" + "\n[SMALL]" + "\nLEVEL " + sugarlvlS + "\n" + quantityS + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 10)
    {
        cart[orderCount] = "VANILLA" + "\n[SMALL]" + "\nLEVEL " + sugarlvlS + "\n" + quantityS + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }else {
        Console.WriteLine("INVALID INPUT");
    }

}

static void computationM(ref int total, ref int orderCount, int quantityM, int perOrder, int sugarlvlM, String[] cart, int select)
{

    perOrder = quantityM * 75;
    total += perOrder;
    if (select == 1)
    {
        cart[orderCount] = "WINTERMELON" + "\n[MEDIUM]" + "\nLEVEL " + sugarlvlM + "\n" + quantityM + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 2)
    {
        cart[orderCount] = "TARO" + "\n[MEDIUM]" + "\nLEVEL " + sugarlvlM + "\n" + quantityM + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 3)
    {
        cart[orderCount] = "MOCHA" + "\n[MEDIUM]" + "\nLEVEL " + sugarlvlM + "\n" + quantityM + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 4)
    {
        cart[orderCount] = "COOKIES N CREAM" + "\n[MEDIUM]" + "\nLEVEL " + sugarlvlM + "\n" + quantityM + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 5)
    {
        cart[orderCount] = "CHOCOLATE" + "\n[MEDIUM]" + "\nLEVEL " + sugarlvlM + "\n" + quantityM + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 6)
    {
        cart[orderCount] = "DARK CHOCOLATE" + "\n[MEDIUM]" + "\nLEVEL " + sugarlvlM + "\n" + quantityM + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 7)
    {
        cart[orderCount] = "CARAMEL" + "\n[MEDIUM]" + "\nLEVEL " + sugarlvlM + "\n" + quantityM + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 8)
    {
        cart[orderCount] = "MOCHA" + "\n[MEDIUM]" + "\nLEVEL " + sugarlvlM + "\n" + quantityM + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 9)
    {
        cart[orderCount] = "STRAWBERRY" + "\n[MEDIUM]" + "\nLEVEL " + sugarlvlM + "\n" + quantityM + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 10)
    {
        cart[orderCount] = "VANILLA" + "\n[MEDIUM]" + "\nLEVEL " + sugarlvlM + "\n" + quantityM + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }else {
        Console.WriteLine("INVALID INPUT");
    }

}

static void computationL(ref int total, ref int orderCount, int quantityL, int perOrder, int sugarlvlL, String[] cart, int select)
{

    perOrder = quantityL * 100;
    total += perOrder;
    if (select == 1)
    {
        cart[orderCount] = "WINTERMELON" + "\n[LARGE]" + "\nLEVEL " + sugarlvlL + "\n" + quantityL + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 2)
    {
        cart[orderCount] = "TARO" + "\n[LARGE]" + "\nLEVEL " + sugarlvlL + "\n" + quantityL + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 3)
    {
        cart[orderCount] = "MOCHA" + "\n[LARGE]" + "\nLEVEL " + sugarlvlL + "\n" + quantityL + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 4)
    {
        cart[orderCount] = "COOKIES N CREAM" + "\n[LARGE]" + "\nLEVEL " + sugarlvlL + "\n" + quantityL + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 5)
    {
        cart[orderCount] = "CHOCOLATE" + "\n[LARGE]" + "\nLEVEL " + sugarlvlL + "\n" + quantityL + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 6)
    {
        cart[orderCount] = "DARK CHOCOLATE" + "\n[LARGE]" + "\nLEVEL " + sugarlvlL + "\n" + quantityL + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 7)
    {
        cart[orderCount] = "CARAMEL" + "\n[LARGE]" + "\nLEVEL " + sugarlvlL + "\n" + quantityL + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 8)
    {
        cart[orderCount] = "MOCHA" + "\n[LARGE]" + "\nLEVEL " + sugarlvlL + "\n" + quantityL + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 9)
    {
        cart[orderCount] = "STRAWBERRY" + "\n[LARGE]" + "\nLEVEL " + sugarlvlL + "\n" + quantityL + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }
    else if (select == 10)
    {
        cart[orderCount] = "VANILLA" + "\n[LARGE]" + "\nLEVEL " + sugarlvlL + "\n" + quantityL + " quantity" + "\nPHP " + perOrder + "\n----------";
        orderCount++;
    }else {
        Console.WriteLine("INVALID INPUT");
    }

}



String[] cart = new String[99];
int orderCount = 0;
int total = 0;
Boolean done = false;
int perOrder = 0;


while (!done) {
    
    productList();
    Console.WriteLine("SELECT ORDER/COMMAND: ");
    int select = Convert.ToInt32(Console.ReadLine());
    switch (select) {
        case 1:
            Console.WriteLine("YOU SELECT WINTERMELON");
            sizesList();
            Console.WriteLine("\nSELECT SIZE: ");
            char selectsize1 = Convert.ToChar(Console.ReadLine());

            switch (selectsize1) {
                case 's': case 'S':
                    Console.WriteLine("SMALL SIZE");
                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlS = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityS = Convert.ToInt32(Console.ReadLine());

                    computationS(ref total,ref orderCount,quantityS,perOrder,sugarlvlS,cart,select);
                    //perOrder = quantity1 * 50;
                    //total += perOrder;
                    //cart[orderCount] = "\nWINTERMELON "+"\n[SMALL]" + "\nLEVEL "+sugarlvlS1 +"\n"+quantity1 +" quantity"+"\nPHP " + perOrder + "\n----------";
                    //orderCount++;

                    break;
                case 'm': case 'M':
                    Console.WriteLine("MEDIUM SIZE");
                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAL LVL: ");
                    int sugarlvlM = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityM = Convert.ToInt32(Console.ReadLine());


                    computationM(ref total, ref orderCount, quantityM, perOrder, sugarlvlM, cart, select);
                    //perOrder = quantityM * 75;
                    //total += perOrder;
                    //cart[orderCount] = "WINTERMELON\n" + "[MEDIUM]\n" + "LEVEL " + sugarlvlM +"\n"+ quantityM + "quantity \n" +"PHP " + perOrder + "\n----------";
                    //orderCount++;

                    break;
                case 'l': case 'L':
                    Console.WriteLine("LARGE SIZE");
                    sugarlvlList();

                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlL = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityL = Convert.ToInt32(Console.ReadLine());

                    computationL(ref total, ref orderCount, quantityL, perOrder, sugarlvlL, cart, select);
                    //perOrder =quantity3 * 100;
                    //total += perOrder;
                    //cart[orderCount] = "WINTERMELON\n" + "[LARGE]\n" + "LEVEL " + sugarlvlL1 + "\n" + quantity3 + "quantity \n" + "PHP " + perOrder + "\n----------";
                    // orderCount++;
                    break;

                default: Console.WriteLine("INVALID INPUT"); break;
            }
            break;

        case 2:
            Console.WriteLine("YOU SELECT TARO");
            sizesList();
            Console.WriteLine("\nSELECT SIZE: ");
            char selectsize2 = Convert.ToChar(Console.ReadLine());

            switch (selectsize2) {
                case 's': case 'S':
                    Console.WriteLine("SMALL SIZE");

                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlS1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityS = Convert.ToInt32(Console.ReadLine());

                    computationS(ref total, ref orderCount, quantityS, perOrder, sugarlvlS1, cart,select);

                    //perOrder = quantity4 * 50;
                    //total += perOrder;
                    //cart[orderCount] = "TARO\n" + "[SMALL] \n" + "LEVEL " + sugarlvlS2 + "\n" + quantity4 +"quantity\n" + "PHP " + perOrder + "\n----------";
                    //orderCount++;
                    break;
                case 'm': case 'M':
                    Console.WriteLine("MEDIUM SIZE");
                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAL LVL: ");
                    int sugarlvlM = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityM = Convert.ToInt32(Console.ReadLine());


                    computationM(ref total, ref orderCount, quantityM, perOrder, sugarlvlM, cart, select);



                    //perOrder = quantityM * 75;
                    //total += perOrder;
                    //cart[orderCount] = "TARO\n" + "[MEDIUM] \n" + "LEVEL " + sugarlvlM + "\n" + quantityM + "quantity\n" + "PHP " + perOrder + "\n----------";

                    break;
                case 'l': case 'L':
                    Console.WriteLine("LARGE SIZE");

                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlL = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityL = Convert.ToInt32(Console.ReadLine());

                    computationL(ref total, ref orderCount, quantityL, perOrder, sugarlvlL, cart, select);

                    //perOrder = quantity6 * 100;
                    // total += perOrder;
                    //cart[orderCount] = "TARO\n" + "[LARGE] \n" + "LEVEL " + sugarlvlL2 + "\n" + quantity6 + "quantity\n" + "PHP " + perOrder + "\n----------";
                    //orderCount++;
                    break;

                default: Console.WriteLine("INVALID INPUT"); break;
            }

            break;
        case 3:
            Console.WriteLine("YOU SELECT MOCHA");
            sizesList();
            Console.WriteLine("\nSELECT SIZE: ");
            char selectsize3 = Convert.ToChar(Console.ReadLine());

            switch (selectsize3) {
                case 's': case 'S':
                    Console.WriteLine("SMALL SIZE");

                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlS1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityS = Convert.ToInt32(Console.ReadLine());

                    computationS(ref total, ref orderCount, quantityS, perOrder, sugarlvlS1, cart, select);

                    break;
                case 'm': case 'M':
                    Console.WriteLine("MEDIUM SIZE");
                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAL LVL: ");
                    int sugarlvlM = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityM = Convert.ToInt32(Console.ReadLine());


                    computationM(ref total, ref orderCount, quantityM, perOrder, sugarlvlM, cart, select);
                    break;
                case 'l': case 'L':
                    Console.WriteLine("LARGE SIZE");
                    sugarlvlList();

                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlL = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityL = Convert.ToInt32(Console.ReadLine());

                    computationL(ref total, ref orderCount, quantityL, perOrder, sugarlvlL, cart, select);
                    break;
                default: Console.WriteLine("INVALID INPUT"); break;
            }
            break;
        case 4:
            Console.WriteLine("YOU SELECT COOKIES N CREAM");
            sizesList();
            Console.WriteLine("\nSELECT SIZE: ");
            char selectsize4 = Convert.ToChar(Console.ReadLine());
            switch (selectsize4){
                case 's': case 'S':
                    Console.WriteLine("SMALL SIZE");

                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlS1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityS = Convert.ToInt32(Console.ReadLine());

                    computationS(ref total, ref orderCount, quantityS, perOrder, sugarlvlS1, cart, select);
                    break;
                case 'm': case 'M':
                    Console.WriteLine("MEDIUM SIZE");
                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAL LVL: ");
                    int sugarlvlM = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityM = Convert.ToInt32(Console.ReadLine());


                    computationM(ref total, ref orderCount, quantityM, perOrder, sugarlvlM, cart, select);
                    break;
                case 'l': case 'L':
                    Console.WriteLine("LARGE SIZE");
                    sugarlvlList();

                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlL = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityL = Convert.ToInt32(Console.ReadLine());

                    computationL(ref total, ref orderCount, quantityL, perOrder, sugarlvlL, cart, select);
                    break;
                default: Console.WriteLine("INVALID INPUT"); break;

            }
            break;
        case 5:
            Console.WriteLine("YOU SELECT COOKIES N CREAM");
            sizesList();
            Console.WriteLine("\nSELECT SIZE: ");
            char selectsize5 = Convert.ToChar(Console.ReadLine());
            switch (selectsize5)
            {
                case 's': case 'S':
                    Console.WriteLine("SMALL SIZE");

                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlS1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityS = Convert.ToInt32(Console.ReadLine());

                    computationS(ref total, ref orderCount, quantityS, perOrder, sugarlvlS1, cart, select);
                    break;
                case 'm': case 'M':
                    Console.WriteLine("MEDIUM SIZE");
                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAL LVL: ");
                    int sugarlvlM = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityM = Convert.ToInt32(Console.ReadLine());


                    computationM(ref total, ref orderCount, quantityM, perOrder, sugarlvlM, cart, select);
                    break;
                case 'l': case 'L':
                    Console.WriteLine("LARGE SIZE");
                    sugarlvlList();

                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlL = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityL = Convert.ToInt32(Console.ReadLine());

                    computationL(ref total, ref orderCount, quantityL, perOrder, sugarlvlL, cart, select);
                    break;
                default: Console.WriteLine("INVALID INPUT"); break;

            }
            break;
        case 6:
            Console.WriteLine("YOU SELECT COOKIES N CREAM");
            sizesList();
            Console.WriteLine("\nSELECT SIZE: ");
            char selectsize6 = Convert.ToChar(Console.ReadLine());
            switch (selectsize6)
            {
                case 's': case 'S':
                    Console.WriteLine("SMALL SIZE");

                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlS1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityS = Convert.ToInt32(Console.ReadLine());

                    computationS(ref total, ref orderCount, quantityS, perOrder, sugarlvlS1, cart, select);
                    break;
                case 'm': case 'M':
                    Console.WriteLine("MEDIUM SIZE");
                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAL LVL: ");
                    int sugarlvlM = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityM = Convert.ToInt32(Console.ReadLine());


                    computationM(ref total, ref orderCount, quantityM, perOrder, sugarlvlM, cart, select);
                    break;
                case 'l': case 'L':
                    Console.WriteLine("LARGE SIZE");
                    sugarlvlList();

                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlL = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityL = Convert.ToInt32(Console.ReadLine());

                    computationL(ref total, ref orderCount, quantityL, perOrder, sugarlvlL, cart, select);
                    break;
                default: Console.WriteLine("INVALID INPUT"); break;

            }
            break;
        case 7:
            Console.WriteLine("YOU SELECT COOKIES N CREAM");
            sizesList();
            Console.WriteLine("\nSELECT SIZE: ");
            char selectsize7 = Convert.ToChar(Console.ReadLine());
            switch (selectsize7)
            {
                case 's': case 'S':
                    Console.WriteLine("SMALL SIZE");

                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlS1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityS = Convert.ToInt32(Console.ReadLine());

                    computationS(ref total, ref orderCount, quantityS, perOrder, sugarlvlS1, cart, select);
                    break;
                case 'm': case 'M':
                    Console.WriteLine("MEDIUM SIZE");
                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAL LVL: ");
                    int sugarlvlM = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityM = Convert.ToInt32(Console.ReadLine());


                    computationM(ref total, ref orderCount, quantityM, perOrder, sugarlvlM, cart, select);
                    break;
                case 'l': case 'L':
                    Console.WriteLine("LARGE SIZE");
                    sugarlvlList();

                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlL = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityL = Convert.ToInt32(Console.ReadLine());

                    computationL(ref total, ref orderCount, quantityL, perOrder, sugarlvlL, cart, select);

                    break;
                default: Console.WriteLine("INVALID INPUT"); break;

            }
            break;
        case 8:
            Console.WriteLine("YOU SELECT COOKIES N CREAM");
            sizesList();
            Console.WriteLine("\nSELECT SIZE: ");
            char selectsize8 = Convert.ToChar(Console.ReadLine());
            switch (selectsize8)
            {
                case 's': case 'S':
                    Console.WriteLine("SMALL SIZE");

                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlS1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityS = Convert.ToInt32(Console.ReadLine());

                    computationS(ref total, ref orderCount, quantityS, perOrder, sugarlvlS1, cart, select);
                    break;
                case 'm': case 'M':
                    Console.WriteLine("MEDIUM SIZE");
                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAL LVL: ");
                    int sugarlvlM = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityM = Convert.ToInt32(Console.ReadLine());


                    computationM(ref total, ref orderCount, quantityM, perOrder, sugarlvlM, cart, select);
                    break;
                case 'l': case 'L':
                    Console.WriteLine("LARGE SIZE");
                    sugarlvlList();

                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlL = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityL = Convert.ToInt32(Console.ReadLine());

                    computationL(ref total, ref orderCount, quantityL, perOrder, sugarlvlL, cart, select);
                    break;
                default: Console.WriteLine("INVALID INPUT"); break;

            }
            break;
        case 9:
            Console.WriteLine("YOU SELECT COOKIES N CREAM");
            sizesList();
            Console.WriteLine("\nSELECT SIZE: ");
            char selectsize9 = Convert.ToChar(Console.ReadLine());
            switch (selectsize9)
            {
                case 's': case 'S':
                    Console.WriteLine("SMALL SIZE");

                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlS1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityS = Convert.ToInt32(Console.ReadLine());

                    computationS(ref total, ref orderCount, quantityS, perOrder, sugarlvlS1, cart, select);
                    break;
                case 'm': case 'M':
                    Console.WriteLine("MEDIUM SIZE");
                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAL LVL: ");
                    int sugarlvlM = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityM = Convert.ToInt32(Console.ReadLine());


                    computationM(ref total, ref orderCount, quantityM, perOrder, sugarlvlM, cart, select);
                    break;
                case 'l': case 'L':
                    Console.WriteLine("LARGE SIZE");
                    sugarlvlList();

                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlL = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityL = Convert.ToInt32(Console.ReadLine());

                    computationL(ref total, ref orderCount, quantityL, perOrder, sugarlvlL, cart, select);
                    break;
                default: Console.WriteLine("INVALID INPUT"); break;

            }
            break;
        case 10:
            Console.WriteLine("YOU SELECT COOKIES N CREAM");
            sizesList();
            Console.WriteLine("\nSELECT SIZE: ");
            char selectsize10 = Convert.ToChar(Console.ReadLine());
            switch (selectsize10)
            {
                case 's': case 'S':
                    Console.WriteLine("SMALL SIZE");

                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlS1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityS = Convert.ToInt32(Console.ReadLine());

                    computationS(ref total, ref orderCount, quantityS, perOrder, sugarlvlS1, cart, select);
                    break;
                case 'm': case 'M':
                    Console.WriteLine("MEDIUM SIZE");
                    sugarlvlList();
                    Console.WriteLine("SELECT SUGAL LVL: ");
                    int sugarlvlM = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityM = Convert.ToInt32(Console.ReadLine());


                    computationM(ref total, ref orderCount, quantityM, perOrder, sugarlvlM, cart, select);
                    break;
                case 'l': case 'L':
                    Console.WriteLine("LARGE SIZE");
                    sugarlvlList();

                    Console.WriteLine("SELECT SUGAR LVL: ");
                    int sugarlvlL = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER QUANTITY: ");
                    int quantityL = Convert.ToInt32(Console.ReadLine());

                    computationL(ref total, ref orderCount, quantityL, perOrder, sugarlvlL, cart, select);
                    break;
                default: Console.WriteLine("INVALID INPUT"); break;

            }
            break;
        case 11:
            Console.WriteLine("-----YOUR ORDER----- ");
            showOrder(orderCount,cart,total);
            break;
        case 12:
            Console.WriteLine("-----YOUR ORDER----- ");
            showOrder(orderCount,cart,total);

            Console.WriteLine("ENTER YOUR MONEY: ");
            int payment = Convert.ToInt32(Console.ReadLine());

            if (payment > total)
            {
                int totalAll = payment - total;
                Console.WriteLine("THANK YOU SIR/MAAM");
                Console.WriteLine("Your balance is: " + totalAll);
            }else {
                Console.WriteLine("NOT ENOUGH MONEY");
                Console.WriteLine("YOUR MONEY IS: " + payment + " YOUR BILL: " + total);
            }
            break;
        case 13:
            done = true;
            break;
        default:
            Console.WriteLine("INVALID INPUT");
            break;

    }


}

