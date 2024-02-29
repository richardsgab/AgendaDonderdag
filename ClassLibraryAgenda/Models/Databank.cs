using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAgenda.Models
{
    public class Databank
    {
        private List<AgendaInput>inputs = new List<AgendaInput>();

        public void AddInput(AgendaInput aginput)
        {            
            inputs.Add(aginput);
        }
        public List<AgendaInput> FindInputs(DateTime dt)
        {
            List<AgendaInput> results = new List<AgendaInput>();
            for(int i = 0; i < inputs.Count; i++)  
            {
                var temp = dt.ToShortDateString();
                if (inputs[i].Date.ToString() == temp.ToString())
                {
                    results.Add(inputs[i]);
                }
            }
            return results;
        }
        public List<AgendaInput> DeleteInputs()
        {
            List<AgendaInput> results = new List<AgendaInput>();
            for (int i = 0; i < inputs.Count; i++)
            {
                results.Remove(inputs[i]);
            }
            return results;
        }



    }
    }
}
