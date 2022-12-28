// See https://aka.ms/new-console-template for more information

using TaskFirst;

var units = new List<Unit>();

var worker = new Worker();
var miner = new Miner();
var harvester = new Harvester();
worker.Work();
miner.Work();
harvester.Work();

var tank = new Tank() { Name = "Tank" };
var volcano = new VolcanoTank() { Name = "Volcano" };
var soldier = new Soldier() { Name = "Soldier" };

tank.Attack(soldier);
tank.Attack(soldier);
volcano.Attack(new Unit[] { harvester, miner, tank });