using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blocknoteUWP.Models
{
    internal class NoteModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DataCreate { get; set; } = DateTime.Now;
    }
}
