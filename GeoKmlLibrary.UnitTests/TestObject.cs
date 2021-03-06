﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoKmlLibrary.UnitTests
{
    [GeoKmlTitle("TestAsTitle")]
    [GeoKmlDescription("TestAsDescription")]
    [GeoKmlGeometry("TestAsGeometry")]
    [GeoKmlSymbol("TestAsStyle")]
    public class TestObject
    {
        public DbGeography TestAsGeometry { get; set; }
        public string TestAsDescription { get; set; }
        public string TestAsTitle { get; set; }
        public string TestAsStyle { get; set; }
    }
}