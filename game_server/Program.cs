﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Configuration;

using System.Text.Json;

namespace GameServer
{
    class Program
    {

        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient(ServerSettings.port);

            Console.WriteLine("Server started on Port " + ServerSettings.port);

            IPEndPoint ep = null;
            PlayerModel pm;

            Player player = new Player(100);

            while (true)
            {
                byte[] receivedData = udpClient.Receive(ref ep);

                string msg = Encoding.ASCII.GetString(receivedData);


                pm = JsonSerializer.Deserialize<PlayerModel>(msg);

                // Add to player list...
                if (!player.tryConnect(ep, pm))
                {
                    // TODO!
                }
                // send status of other
                player.doUpdate(ep, pm);

                // send response


                Console.WriteLine(msg);
            }


        }
    }
}