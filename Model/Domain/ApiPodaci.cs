using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class ApiPodaci
    {
        public List<Teams> teams { get; set; }
        public List<Elements> elements { get; set; }
        public List<Types> element_types { get; set; }

        public static ApiPodaci GetData()
        {
            var webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;

            var json = webClient.DownloadString("https://fantasy.premierleague.com/api/bootstrap-static/");

            var data = JsonConvert.DeserializeObject<ApiPodaci>(json);

            return data;
        }
    }

    public class Teams
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Elements {
        public int id { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public int team { get; set; }
        public int element_type { get; set; }
    
    }

    public class Types
    {
        public int id { get; set; }
        public string plural_name_short { get; set; }
    }


}
