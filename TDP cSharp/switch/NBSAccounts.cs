using System;

class NBSAccounts {

    public float tax(int salary){
        return salary*23/100;
    }

    public void netSalary(int salary){
            Console.WriteLine(tax(salary));
    }
}