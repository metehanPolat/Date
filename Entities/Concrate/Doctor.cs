using Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class Doctor:IEntity//s takısı gertime
    {
        public int Id { get; set; }
        public string Name { get; set; }//Name yaz
        public string Profession { get; set; }
    }
}
