﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.DAL.Data
{
    public class MessageD
    {
        public long Message_id { get; set; }
        public long Topic_id { get; set; }
        public long Utilisateur_id { get; set; }
        public System.DateTime DatePoste { get; set; }
        public string ContenuMessage { get; set; }
    }
}