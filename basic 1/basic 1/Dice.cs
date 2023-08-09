using System;
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

