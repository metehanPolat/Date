using Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TC { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
    }
}
