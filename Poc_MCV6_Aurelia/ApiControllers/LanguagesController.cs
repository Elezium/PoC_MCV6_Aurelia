using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Poc_MCV6_Aurelia.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyNamespace
{
    [Route("api/[controller]")]
    public class LanguagesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Language> Get()
        {

			List<Language> lang = new List<Language>()
			{
				new Language {LanguageId=1, Name="C#", PrismName="language-csharp" },
				new Language {LanguageId=1, Name="Javascript", PrismName="language-javascript" },
				new Language {LanguageId=1, Name="HTML", PrismName="language-html" },
			};
            return lang;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
