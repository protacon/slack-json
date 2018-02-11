using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Slack.Json.Github
{
    public class SlackActionModel
    {
        public string Type { get; set; }
        public string Channel { get; set; }
        public bool Enabled { get; set; } = true;
        public JArray Data { get; set; }
    }
}