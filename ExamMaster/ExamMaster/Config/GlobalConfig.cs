﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMaster.Config
{
    [Serializable]
    [JsonObject("GlobalConfig")]
    public class GlobalConfig
    {
        public static readonly GlobalConfig INSTANCE;

        static GlobalConfig()
        {
            INSTANCE = (GlobalConfig)JsonConvert.DeserializeObject(File.ReadAllText(Environment.CurrentDirectory + @"\config.cfg"), typeof(GlobalConfig));
        }

        [JsonProperty]
        public List<CatalogModel> Catalogs = new List<CatalogModel>();
        [JsonProperty]
        public String SQL_TaskID = "P_Id";
        [JsonProperty]
        public String SQL_Question = "Frage";
        [JsonProperty]
        public String SQL_Answer1 = "Antwort1";
        [JsonProperty]
        public String SQL_Answer2 = "Antwort2";
        [JsonProperty]
        public String SQL_Answer3 = "Antwort3";
        [JsonProperty]
        public String SQL_Answer4 = "Antwort4";
        [JsonProperty]
        public String SQL_RightAnswer = "RichtigeAntwort";
    }

    [Serializable]
    [JsonObject("CatalogModel")]
    public class CatalogModel
    {
        private String name;
        private short variations;
        private String sqlVariationName;
        private String sqlTaskName;

        [JsonProperty]
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        [JsonProperty]
        public String SQLVariationName
        {
            get
            {
                return sqlVariationName;
            }
            set
            {
                sqlVariationName = value;
            }
        }

        [JsonProperty]
        public String SQLTaskName
        {
            get
            {
                return sqlTaskName;
            }
            set
            {
                sqlTaskName = value;
            }
        }


        [JsonProperty]
        public short VariationCount
        {
            get
            {
                return variations;
            }
            set
            {
                variations = value;
            }
        }
    }
}