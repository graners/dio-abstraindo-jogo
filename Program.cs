// See https://aka.ms/new-console-template for more information
using rpgGame.src.Entities;
using static System.Console;

Knight hero = new("Arus", 23, "Knight");
Wizard wizard = new("Jenica", 23, "White Wizard");

WriteLine(hero);
WriteLine(wizard);

wizard.Attack();
wizard.Attack(10);


