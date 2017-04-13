﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibrary.Interfaces;
using MediaLibrary.CreaterMediaCollections;
using MediaLibrary.MediaElements;

namespace MediaLibrary.MediaCollectedElements
{
    public class Selection : CollectionLibrary
    {
        public Selection(string name, ICollection<Media> media_element_list) : base(name, media_element_list)
        {
        }
    }
}
