using Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorSegurosResidenciais.controller
{
    class LoadStates
    {
        private LinkedList<State> states = new LinkedList<State>();        

        public LoadStates()        {
            string[] file;
            try
            {
                var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string path = Path.Combine(projectPath, "Resources");
                file = File.ReadAllLines(path + "/states.txt", Encoding.UTF8);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
                file = new string[] {
                    "São Paulo,SP,Bebedouro,0.52",
                    "São Paulo,SP,Barretos,0.46",
                    "Minas Gerais,MG,Belo Horizonte,0.58",
                    "Minas Gerais,MG,Juiz de Fora,0.51"
                };
            }
            foreach (var line in file)
                {
                    string[] content = line.Split(',');
                    State state = new State(content[0], content[1].ToCharArray());
                    City city = new City(content[2], double.Parse(content[3], CultureInfo.InvariantCulture) / 100.0);
                    state.addCity(city);
                    states.AddLast(state);
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
    }
}
