﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456", modelo: "Modelo1", imei: "12345", memoria: 64);
//Smartphone nokia = new Nokia(numero:"123456", modelo:"Modelo 1",imei:"11111111", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");


Console.WriteLine("SmartPhone IPHONE: ");
Smartphone iphone = new Iphone(numero:"7891011", modelo: "Modelo2", imei: "6789", memoria: 128);
//Smartphone nokia = new Nokia(numero:"123456", modelo:"Modelo 1",imei:"11111111", memoria:64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");


