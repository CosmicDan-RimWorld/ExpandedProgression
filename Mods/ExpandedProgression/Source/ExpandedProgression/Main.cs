using System;
using Harmony;
using Verse;
using System.Reflection;

namespace ExpandedProgressionNative
{
    public class Main : Mod
    {
        public Main(ModContentPack content) : base(content)
        {
            var harmony = HarmonyInstance.Create("com.cosmicdan.rimworld.expandedprogression");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            Log.Message("ExpandedProgression mod native has loaded!");
        }
    }
}
