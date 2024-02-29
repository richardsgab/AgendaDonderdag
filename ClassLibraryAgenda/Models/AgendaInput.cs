using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAgenda.Models
{
    public class AgendaInput
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public AgendaInput(string text, DateTime date)
        {
            Text = text;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Date} - {Text}";
        }
    }
}
