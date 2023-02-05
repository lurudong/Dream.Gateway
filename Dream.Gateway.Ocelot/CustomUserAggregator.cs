using Ocelot.Middleware;
using Ocelot.Multiplexer;

namespace Dream.Gateway.Ocelot
{
    public class CustomUserAggregator : IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {

            Dictionary<string, string> result = new Dictionary<string, string>();
            int count = 0;
            foreach (var item in responses)
            {
                string content = await item.Items.DownstreamResponse().Content.ReadAsStringAsync();
                result.Add();
            }
        }
    }
}
