const int PIRATE = 1;
const int STONE_CHEWER = 2;
const int GHOST_WARRIOR = 3;
const int OUTWORLDER = 4;
const int MONSTER_KNIGHT = 5;
const int DARK_GOBLIN = 6;

const int PIRATE_HEALTH = 20;
const int PIRATE_ATTACK = 3;
const int PIRATE_SPEED = 3;
const int PIRATE_ARMOR = 3;

const int STONE_CHEWER_HEALTH = 50;
const int STONE_CHEWER_ATTACK = 10;
const int STONE_CHEWER_SPEED = 1;
const int STONE_CHEWER_ARMOR = 1;

const int GHOST_WARRIOR_HEALTH = 20;
const int GHOST_WARRIOR_ATTACK = 2;
const int GHOST_WARRIOR_SPEED = 5;
const int GHOST_WARRIOR_ARMOR = 2;

const int OUTWORLDER_HEALTH = 15;
const int OUTWORLDER_ATTACK = 2;
const int OUTWORLDER_SPEED = 1;
const int OUTWORLDER_ARMOR = 2;

const int MONSTER_KNIGHT_HEALTH = 15;
const int MONSTER_KNIGHT_ATTACK = 4;
const int MONSTER_KNIGHT_SPEED = 3;
const int MONSTER_KNIGHT_ARMOR = 3;

const int DARK_GOBLIN_HEALTH = 10;
const int DARK_GOBLIN_ATTACK = 1;
const int DARK_GOBLIN_SPEED = 2;
const int DARK_GOBLIN_ARMOR = 8;

Console.WriteLine("PLAYER1, which character would you like to choose PIRATE(1), STONE_CHEWER(2), GHOST_WARRIOR(3), OUTWORLDER(4), MONSTER_KNIGHT(5) or DARK_GOBLIN(6)?");
int PLAYER1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("PLAYER2, which character would you like to choose PIRATE(1), STONE_CHEWER(2), GHOST_WARRIOR(3), OUTWORLDER(4), MONSTER_KNIGHT(5) or DARK_GOBLIN(6)?");
int PLAYER2 = int.Parse(Console.ReadLine()!);

double health1 = 0;
double health2 = 0;
double attack1 = 0;
double attack2 = 0;
int speed1 = 0;
int speed2 = 0;
double armor1 = 0;
double armor2 = 0;

switch (PLAYER1)
{
    case 1: 
    health1 = PIRATE_HEALTH + PIRATE_ARMOR;
    attack1 = PIRATE_ATTACK;
    speed1 = PIRATE_SPEED;
    break;

    case 2:
    health1 = STONE_CHEWER_HEALTH + STONE_CHEWER_ARMOR;
    attack1 = STONE_CHEWER_ATTACK;
    speed1 = STONE_CHEWER_SPEED;
    break;

    case 3:
    health1 = GHOST_WARRIOR_HEALTH + GHOST_WARRIOR_ARMOR;
    attack1 = GHOST_WARRIOR_ATTACK;
    speed1 = GHOST_WARRIOR_SPEED;
    break;

    case 4: 
    health1 = OUTWORLDER_HEALTH + OUTWORLDER_ARMOR;
    attack1 = OUTWORLDER_ATTACK;
    speed1 = OUTWORLDER_SPEED;
    break;

    case 5:
    health1 = MONSTER_KNIGHT_HEALTH + MONSTER_KNIGHT_ARMOR;
    attack1 = MONSTER_KNIGHT_ATTACK;
    speed1 = MONSTER_KNIGHT_SPEED;
    break;

    case 6:
    health1 = DARK_GOBLIN_HEALTH + DARK_GOBLIN_ARMOR;
    attack1 = DARK_GOBLIN_ATTACK;
    speed1 = DARK_GOBLIN_SPEED;
    break;
}    

switch (PLAYER2)
{
    case 1: 
    health2 = PIRATE_HEALTH + PIRATE_ARMOR;
    attack2 = PIRATE_ATTACK;
    speed2 = PIRATE_SPEED;
    break;

    case 2:
    health2 = STONE_CHEWER_HEALTH + STONE_CHEWER_ARMOR;
    attack2 = STONE_CHEWER_ATTACK;
    speed2 = STONE_CHEWER_SPEED;
    break;

    case 3:
    health2 = GHOST_WARRIOR_HEALTH + GHOST_WARRIOR_ARMOR;
    attack2 = GHOST_WARRIOR_ATTACK;
    speed2 = GHOST_WARRIOR_SPEED;
    break;

    case 4: 
    health2 = OUTWORLDER_HEALTH + OUTWORLDER_ARMOR;
    attack2 = OUTWORLDER_ATTACK;
    speed2 = OUTWORLDER_SPEED;
    break;

    case 5:
    health2 = MONSTER_KNIGHT_HEALTH + MONSTER_KNIGHT_ARMOR;
    attack2 = MONSTER_KNIGHT_ATTACK;
    speed2 = MONSTER_KNIGHT_SPEED;
    break;

    case 6:
    health2 = DARK_GOBLIN_HEALTH + DARK_GOBLIN_ARMOR;
    attack2 = DARK_GOBLIN_ATTACK;
    speed2 = DARK_GOBLIN_SPEED;
    break;
}    

while (health1 > 0 && health2 > 0)
{
    health1 -= attack2 * speed2 * Random.Shared.Next(-15, 16) / 100d;
    health2 -= attack1 * speed1 * Random.Shared.Next(-15, 16) / 100d;
}
   
if (health1 > 0)
{
    Console.WriteLine("PLAYER1 win");
}
else if (health1 < 0)
{
    Console.WriteLine("PLAYER2 win");
}
else if (health1 ==0 && health2 == 0)
{
    Console.WriteLine("Nobody win");
}
