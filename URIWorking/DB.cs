using System;
using System.Net;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace KitDB
{
    using System;
    using System.Net;
    using System.IO;
    using System.Text.Json;
    using System.Collections.Generic;
    
    class DataBase
    {
       
        public Dictionary<string,object>? DB { get; set; }
        
    }
    class DataGetter
    {
       
        
        public WebClient page;
        public void Run()
        {
            page = new WebClient();
            page.DownloadFile("https://kitchaos-dreamscapestudios.github.io/Base.json", "./Info.json");
           
          
            
        }
        public object GetData(string pword)
        {
            var reader = new StreamReader("./Info.json");
            
           
           
            string json = reader.ReadToEnd();
            DataBase? Base = JsonSerializer.Deserialize<DataBase>(json);
            reader.Close();
            try
            {
               return Base.DB[pword];
            }
            catch(KeyNotFoundException)
            {
              
                return "Entry Not in Database!";
            };
          

            
        }

    }
}
