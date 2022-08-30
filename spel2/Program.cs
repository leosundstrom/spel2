Random generator = new Random();
int attackDamage;
int heavyAttack;
int health = 100;
string pText;
int enemyHealth = 100;
int enemyAttack;
bool enemyAlive = true;
bool pAlive = true;
bool game = true;
int gold = 0;
string weapon = "fists";




Console.WriteLine("You're nothing but a man with no weapon or armor. You're in the forest minding your own business when suddenly, an enemy appears! Theres no way out of this, attack!");


battle();
void battle(){
bool pTurn = true;
bool mTurn = false;

while(enemyHealth >= 1 && health >= 1){ 
pText = Console.ReadLine();

if(pText == "gold"){
    Console.WriteLine($"You currently have {gold} gold coins!");
}

if(pTurn == true && pAlive == true && pText == "attack"){
    attackDamage = generator.Next(11,21);
enemyHealth = enemyHealth - attackDamage;
Console.WriteLine($"You hit the enemy with your {weapon} dealing -{attackDamage} damage!");
if(enemyHealth <= 0){
    enemyHealth = 0;
    enemyAlive = false;
}
Console.WriteLine($"Enemys health is now {enemyHealth}!");
pTurn = false;
mTurn = true;
}
if(enemyHealth <= 0){
    Console.WriteLine("You've slain your enemy! He dropped 100 gold!");
    enemyAlive = false;
    gold = gold + 100;
}
if(mTurn == true && enemyAlive == true){
    enemyAttack = generator.Next(11,21);
    health = health - enemyAttack;
    Console.WriteLine($"The enemy dealt -{enemyAttack} damage!");
    Console.WriteLine($"Your health is now {health}!");
    pTurn = true;
    mTurn = false;

}
if(health <= 0){
    pAlive = false;
}
if(pAlive == false){
    
    game = false;
}
if(game == false){
    Console.Clear();
    Console.WriteLine("You died!");
}
}
if(enemyAlive == false){
    shop();
}
}


void shop(){
Console.WriteLine($"You enter the shop with {gold} gold!");
Console.WriteLine("You can purchase a stone sword for 75 gold");
Console.ReadLine();
if(pText == "buy stone sword"){
  gold = gold - 75;
  weapon = "Stone Sword";
  attackDamage = generator.Next(11,31);   
}
if(pText == "exit"){
    battle();
}
}

Console.ReadLine();