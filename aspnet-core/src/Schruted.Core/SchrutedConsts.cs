using Schruted.Debugging;

namespace Schruted
{
    public class SchrutedConsts
    {
        public const string LocalizationSourceName = "Schruted";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "0c81eb1c6fae4ed89081b4a8a25fd6f7";
    }
}
