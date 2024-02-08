// See https://aka.ms/new-console-template for more information
using diagnostico.Models;

Human boromir = new Human("Boromir",10,100,100);
Orc orc1 = new Orc("Orc1",12,20,100);
for (int i = 0; i < 9; i++)
{
    boromir.attack(orc1);
}