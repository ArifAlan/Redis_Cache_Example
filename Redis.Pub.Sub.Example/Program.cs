﻿using StackExchange.Redis;

ConnectionMultiplexer connection = await ConnectionMultiplexer.ConnectAsync("localhost:1453");//redis sunucusuna bağlantı oluşturduk
ISubscriber subscriber = connection.GetSubscriber();// bu bağlantı üzerinden bir subcscriber oluşturduk

while (true)
{
    Console.Write("Mesaj : ");
    string message = Console.ReadLine();
    await subscriber.PublishAsync("mychannel", message);
}