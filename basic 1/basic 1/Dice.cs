using System;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace basic_1
{
	public class Dice
	{
		private int sides;
		private int throws;
		private int? current;

		public int? Current
		{
			get { return current; }
		}

        public int Throws
        {
            get { return throws; }
        }

        public Dice(int numberOfSides)
		{
			sides = numberOfSides;
			throws = 0;
        }

		public int Roll()
		{
			Random rnd = new Random();
			int rolled = rnd.Next(1, sides + 1);
			throws++;
			current = rolled;

            return rolled;
		}

		public void PickUp()
		{
			current = null;
		}
	}
}


namespace basic_1
{
	public class GameRequests
	{
		private string basicUrl;

		public string BasicUrl
		{
			set { basicUrl = value; }
		}

		public GameRequests(string url)
		{
			basicUrl = url;
		}

		private string GetStreamReader(string url, string method)
		{
            var request = WebRequest.Create(url);
            request.Method = method;

            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();

            StreamReader reader = new StreamReader(webStream);
			string data = reader.ReadToEnd();
            return data;
        }


		public string[] StartGame(int players)
		{
			string url = basicUrl + "/start-game";
			string data = GetStreamReader(url, "GET");
			try
			{
                string[]? deck = JsonSerializer.Deserialize<string[]>(data);
                return deck;
            }
			catch
			{
                Console.WriteLine("Error");
                return new string[] {};
			}
        }

        public string[] GetDeck(int players)
        {
            string url = basicUrl + "/get-deck";
            string data = GetStreamReader(url, "GET");
            try
            {
                string[]? deck = JsonSerializer.Deserialize<string[]>(data);
                return deck;
            }
            catch
            {
                Console.WriteLine("Error");
                return new string[] { };
            }
        }
    }
}

