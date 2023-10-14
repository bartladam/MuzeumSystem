using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzeumSystem
{
    /// <summary>
    /// Security guard is protecting exhibition
    /// </summary>
    internal class SecurityGuard
    {
        /// <summary>
        /// Name of guard who protect exhibition
        /// </summary>
        public string nameGuard { get; init; }
        /// <summary>
        /// Surname of guard who protect exhibition
        /// </summary>
        public string surnameGuard { get; init; }
        /// <summary>
        /// Each guard has one exhibition to protect
        /// </summary>
        private Exhibition exhibition { get; set; }
        public SecurityGuard(string nameGuard, string surnameGuard)
        {
            this.nameGuard = nameGuard;
            this.surnameGuard = surnameGuard;
        }
        /// <summary>
        /// The work guard
        /// </summary>
        /// <param name="exhibition"></param>
        /// <returns></returns>
        public string Guard(Exhibition exhibition)
        {
            this.exhibition = exhibition;
            return string.Format("Guard: {0} {1} is guarding exhibition: {2}", nameGuard, surnameGuard, exhibition.nameExhibition);
        }
    }
}
