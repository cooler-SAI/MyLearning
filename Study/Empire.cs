using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Empire
    {
        /// <summary>
        /// Glory Race, more yonger than others
        /// </summary>
        public string Humans;
        /// <summary>
        /// KARAZ a KARAK home of Dwarfs, strong Race
        /// </summary>
        public string Dwarfs;
        /// <summary>
        /// More glory and Older race of this world
        /// </summary>
        public string HighElves;

        public string Info()
        {
            return $": Glory Race\n" +
                $": strong Race\n" +
                $": glory and Older race\n ";

        }

        public Empire(string Humans, string Dwarfs, string HighElves)
        {
            this.Humans = Humans;
            this.Dwarfs = Dwarfs;
            this.HighElves = Dwarfs;

        }
        public Empire(string Humans, string Dwarfs) :
            this(Humans, Dwarfs)
        {


        }


    }
}
