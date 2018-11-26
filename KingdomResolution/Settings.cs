﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityModManagerNet;

namespace KingdomResolution
{
    public class Settings : UnityModManager.ModSettings
    {
        public float eventTimeFactor = 1;
        public float projectTimeFactor = 1;
        public float baronTimeFactor = 1;
        public float eventPriceFactor = 1;
        public bool skipPlayerTime = false;
        public bool overrideIgnoreEvents = false;
        public bool easyEvents = false;
        public bool alwaysInsideKingdom = false;
        public bool previewEventResults = false;
        public bool previewDialogResults = false;
        public override void Save(UnityModManager.ModEntry modEntry)
        {
            Save(this, modEntry);
        }
    }
}
