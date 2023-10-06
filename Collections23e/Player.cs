using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections23e
{
    public class Player
    {

		//instance fields
		private int _id;
        private string _type;
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

		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}

		//constructor
        public Player(int id, string type, string name)	
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
