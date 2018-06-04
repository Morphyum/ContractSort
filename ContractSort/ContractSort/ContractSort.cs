using Harmony;
using System.Reflection;

namespace ContractSort
{
    public class ContractSort
    {
        internal static string ModDirectory;
        public static void Init(string directory, string settingsJSON) {
            var harmony = HarmonyInstance.Create("de.morphyum.ContractSort");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            ModDirectory = directory;
        }
    }
}
