// See https://aka.ms/new-console-template for more information


using Aula03;

Console.WriteLine("Program initialized");
var moana = new Animation(1, "Moana", 3, "Adventure");
moana.Play();
moana.IncreaseVolume();
moana.Stop();

var nosferatu = new Movie(2, "Nosferatu", 10, "Horror");
nosferatu.Play();
nosferatu.Stop();

Console.WriteLine("Program finished");
