﻿using System.Text.Json;
using ModChart;

namespace ScuffedWalls.Functions
{
    [SFunction("Environment", "EnvironmentEnhancement")]
    class EnvironmentEnhancement : ScuffedFunction
    {
        public override void Run()
        {
            FunLog();

            InstanceWorkspace.Environment.Add(new TreeDictionary()
            {
                ["_id"] = GetParam("id", null, p => (object)p),
                ["_track"] = GetParam("track", null, p => (object)p),
                ["_lookupMethod"] = GetParam("lookupmethod", null, p => (object)p),
                ["_duplicate"] = GetParam("duplicate", null, p => (object)int.Parse(p)),
                ["_active"] = GetParam("active", null, p => (object)bool.Parse(p)),
                ["_scale"] = GetParam("scale", null, p => JsonSerializer.Deserialize<object[]>(p)),
                ["_localPosition"] = GetParam("localposition", null, p => JsonSerializer.Deserialize<object[]>(p)),
                ["_localRotation"] = GetParam("localrotation", null, p => JsonSerializer.Deserialize<object[]>(p)),
                ["_position"] = GetParam("position", null, p => JsonSerializer.Deserialize<object[]>(p)),
                ["_rotation"] = GetParam("rotation", null, p => JsonSerializer.Deserialize<object[]>(p)),
                ["_lightID"] = GetParam("lightid", null, p => (object)int.Parse(p))
            });
            ConsoleOut("Environment",1,0,"Environment Enhancement");
            Parameter.ExternalVariables.RefreshAllParameters();
        }
    }
}
