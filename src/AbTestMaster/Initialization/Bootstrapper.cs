using AbTestMaster.Services;

namespace AbTestMaster.Initialization
{
    public class AbTestMasterBootstrapper
    {
        internal static string[] AssmeblyNames;

        public static void Initialize(string[] assemblyNames)
        {
            AssmeblyNames = assemblyNames;

            //on application initialise, load all views, goals, configuration & targets
            SplitServices.SplitViews = SplitFinder.FindSplitViews();
            SplitServices.SplitGoals = SplitFinder.FindSplitGoals();
            TargetService.Config = TargetFinder.FindConfig();
            TargetService.Targets = TargetFinder.FindTargets();
        }
    }
}
