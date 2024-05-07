using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Entitati
{
    public class Produs
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public long Pret { get; set; }
        public string AdresaUrlImagini { get; set; }
        public string Tip { get; set; }
        public string Brend { get; set; }
        public int CantitateStoc { get; set; }
        
    }
}