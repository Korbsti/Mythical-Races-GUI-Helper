using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicalRacesHelperGUI
{
    internal class RaceHelper
    {
        bool isCreatingRace = false;

        public bool GetIsCreatingRace() { return isCreatingRace; }
        public void SetIsCreatingRace(bool isCreatingRace) { this.isCreatingRace= isCreatingRace; }
    }
}
