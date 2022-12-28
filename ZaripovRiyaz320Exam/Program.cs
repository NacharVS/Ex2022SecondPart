using ZaripovRiyaz320Exam.Units;

Soldier soldier = new Soldier
{
    Name = "Солдат 1",
    Health = 100,
    Damage = 10
};

Miner miner1 = new Miner
{
    Name = "Шахтер 1",
    Health = 100
};

Harvester harvester1 = new Harvester
{
    Name = "Собиратель 1",
    Health = 100
};

soldier.Move();

miner1.Move();

harvester1.Move();

soldier.Attack(miner1);