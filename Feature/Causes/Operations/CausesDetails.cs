using static Solidare.Core.Database;

namespace Solidare.Feature.Causes.Operations
{
    class CausesDetails : Operation
    {
        public string Query => "SELECT * FROM Causas";
    }
}
