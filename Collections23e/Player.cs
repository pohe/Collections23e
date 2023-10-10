using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections23e
{

    public enum PlayerType { Warrior, Mage, Sorcerer, Cleric }

    public class Player
    {
       
        //instance fields
        private int _id;
        private PlayerType _type;
        private string _name;


		//properties
        public int Id
		{
			get { return _id; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public PlayerType Type
		{
			get { return _type; }
			set { _type = value; }
		}

		//constructor
        public Player(int id, PlayerType type, string name)	
        {
			_id = id;
			_type = type;
			_name = name;
        }

        //methods	

        public override string ToString()
        {
            return $"Id {_id} Name {_name} Type {_type}";
        }
    }
}
