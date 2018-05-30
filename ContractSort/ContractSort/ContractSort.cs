using Harmony;
using System.Reflection;

namespace ContractSort
{
    public class ContractSort
    {
        public static void Init() {
            var harmony = HarmonyInstance.Create("de.morphyum.ContractSort");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
