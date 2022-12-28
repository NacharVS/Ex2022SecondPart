// See https://aka.ms/new-console-template for more information

using TaskFirst;

var units = new List<Unit>();

var worker = new Worker();
var miner = new Miner();
var harvester = new Harvester();
worker.Work();
miner.Work();
harvester.Work();

var tank = new Tank();
var volcano = new VolcanoTank();
var soldier = new Soldier();

tank.Attack(soldier);
