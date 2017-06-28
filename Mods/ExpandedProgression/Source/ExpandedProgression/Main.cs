using System;
using Harmony;
using Verse;
using System.Reflection;

namespace ExpandedProgressionNative
{
    [StaticConstructorOnStartup]
    public class Main
    {
        static Main()
        {
            // this constructor is just used to signal Harmony to look through this assembly for all patches
            var harmony = HarmonyInstance.Create("com.cosmicdan.rimworld.expandedprogression");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            Log.Message("ExpandedProgression mod native has loaded!");
        }
    }

    public class Util
    {
        internal static bool isCarbonThing(Thing thing)
        {
            foreach (var thingCategory in thing.def.thingCategories)
                if (thingCategory.defName.Equals("Carbon"))
                    return true;

            return false;
        }
    }

}
