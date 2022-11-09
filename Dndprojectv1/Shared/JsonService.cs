using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Dndprojectv1.Shared
{
    
    public class JsonService
    {
        public HttpClient httpClient;

        public JsonService(HttpClient context)
        {
            this.httpClient = context;
        }

        public async Task<ApiClasses.Rootobject> ListItem(string url)
        {
            ApiClasses.Rootobject myJson;
            myJson = await JsonSerializer.DeserializeAsync<ApiClasses.Rootobject>
        (await httpClient.GetStreamAsync($"/api/{ url}"));
            return myJson;
        }

        public async Task<Spell.Rootobject> Spell(string url)
        {
            Spell.Rootobject myJson;
            myJson = await JsonSerializer.DeserializeAsync<Spell.Rootobject>
        (await httpClient.GetStreamAsync($"/api/spells/{url}"));
            return myJson;
        }
        public async Task<CharacterClass.Rootobject> CharClass(string url)
        {
            CharacterClass.Rootobject myJson;
            myJson = await JsonSerializer.DeserializeAsync<CharacterClass.Rootobject>
        (await httpClient.GetStreamAsync($"/api/classes/{url}"));
            return myJson;
        }

        public async Task<Race.Rootobject> Race(string url)
        {
            Race.Rootobject myJson;
            myJson = await JsonSerializer.DeserializeAsync<Race.Rootobject>
        (await httpClient.GetStreamAsync($"/api/raceses/{url}"));
            return myJson;
        }
    }
}
