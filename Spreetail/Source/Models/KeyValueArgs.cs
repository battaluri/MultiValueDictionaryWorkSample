using PowerArgs;

namespace Spreetail.WorkSample.Source.Models
{
    public class KeyValueArgs
    {
        [ArgRequired(PromptIfMissing = true), ArgDescription("Key of the entry"), ArgPosition(1)]
        public string Key { get; set; }

        [ArgRequired(PromptIfMissing = true), ArgDescription("Value of the entry"), ArgPosition(2)]
        public string Value { get; set; }
    }

    public class RemoveArgs
    {
        [ArgRequired, ArgDescription("Key of the entry"), ArgPosition(1)]
        public string Key { get; set; }

        [ArgDescription("Value of the entry"), ArgPosition(2)]
        public string Value { get; set; }
    }
}
