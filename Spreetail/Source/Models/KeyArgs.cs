using PowerArgs;

namespace Spreetail.WorkSample.Source.Models
{
    public class OneArgs
    {
        [ArgRequired(PromptIfMissing = true), ArgDescription("Key of the entry"), ArgPosition(1)]
        public string Key { get; set; }
    }
}
