using System;
namespace HIC_Tech
{
	public class Card
    {
		private string suit;
		private string faceValue;

		public Card(string aFaceValue, string aSuit)
		{
			suit = aSuit;
			faceValue = aFaceValue;
		}

        public string FaceValue
        {
            get { return faceValue; }
            set { faceValue = value; }
        }

        public string Suit
        {
            get { return suit; }
            set { suit = value; }
        }
    }
}

