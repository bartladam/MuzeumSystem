using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    internal class SecurityGuard
    {
        public string nameGuard { get; init; }
        public string surnameGuard { get; init; }
        private Exhibition exhibition { get; set; }
        public SecurityGuard(string nameGuard, string surnameGuard)
        {
            this.nameGuard = nameGuard;
            this.surnameGuard = surnameGuard;
        }
        public string Guard(Exhibition exhibition)
        {
            this.exhibition = exhibition;
            return string.Format("Guard: {0} {1} is guarding exhibition: {2}", nameGuard, surnameGuard, exhibition.nameExhibition);
        }
    }
}
