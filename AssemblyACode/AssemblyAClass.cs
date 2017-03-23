using Newtonsoft.Json;

namespace AssemblyACode
{
    public sealed class AssemblyAClass
    {
        public string GetJson(object item)
        {
            return JsonConvert.SerializeObject(item);
        }
    }
}
