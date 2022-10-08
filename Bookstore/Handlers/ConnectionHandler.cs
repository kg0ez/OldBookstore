﻿using System;
using System.Net.Sockets;
using System.Text;

namespace Bookstore.Handlers
{
    public static class ConnectionHandler
    {
        public static string Client(string json)
        {
            TcpClient client = null;

            const string IP = "127.0.0.1";
            const int PORT = 8080;

            try
            {
                client = new TcpClient(IP, PORT);
                NetworkStream stream = client.GetStream();


                byte[] buffer = Encoding.Unicode.GetBytes(json);

                stream.Write(buffer, 0, buffer.Length);

                buffer = new byte[client.ReceiveBufferSize];
                int bytes = 0;

                StringBuilder response = new StringBuilder();

                do
                {
                    bytes = stream.Read(buffer, 0, buffer.Length);
                    response.Append(Encoding.Unicode.GetString(buffer, 0, bytes));
                }
                while (stream.DataAvailable);

                string resp = response.ToString();
                return resp;
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }

            finally { client.Close(); }

            return "gg";
        }
    }
}

