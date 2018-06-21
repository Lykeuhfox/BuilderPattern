using Workshop.Armory;

namespace Workshop.Component
{
    interface IArtificialIntelligence
    {
        string Name { get; set; }

        string RunDiagnostics(ISuit suit);
    }
}
