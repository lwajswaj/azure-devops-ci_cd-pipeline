using System;
using System.Collections.Generic;

namespace Application.Models
{
    public partial class ToDo
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Note { get; set; }
    }
}
