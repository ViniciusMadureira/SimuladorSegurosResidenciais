using Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorSegurosResidenciais.controller
{
    class LoadStates
    {
        LinkedList<State> states = new LinkedList<State>();
        LinkedList<City> cities = new LinkedList<City>();

        public LoadStates()        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = Path.Combine(projectPath, "Resources");
            string[] file = File.ReadAllLines(path + "/states.txt", Encoding.UTF8);            
            foreach (var line in file)
            {
                string[] content = line.Split(',');
                State state = new State(content[0], content[1].ToCharArray());                
                City city = new City(content[2], double.Parse(content[3]));
                state.addCity(city);
                states.AddLast(state);
                //addState(state);
                //addCity(city);
            }
        }

        public LinkedList<State> getStates()
        {
            return states;
        }

        private bool addState(State newState)
        {
            foreach (var state in states)
            {
                if (state.getName() == newState.getName())
                {
                    return false;
                }
            }
            states.AddLast(newState);
            return true;
        }

        private bool addCity(City newCity)
        {            
            foreach(var city in cities)
            {
                if (city.getName() == newCity.getName())
                {
                    return false;
                }
            }
            cities.AddLast(newCity);
            return true;
        }
    }
}
