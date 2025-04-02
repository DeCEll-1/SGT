namespace SSSystemGenerator.Classes.CSVClasses
{
    public class StarGenData
    {
        [CsvHelper.Configuration.Attributes.Ignore]
        public string owner { get; set; }
        public string id { get; set; }
        public string age { get; set; }
        public string tags { get; set; }
        public string freqYOUNG { get; set; }
        public string freqAVERAGE { get; set; }
        public string freqOLD { get; set; }
        public string minRadius { get; set; }
        public string maxRadius { get; set; }
        public string habZoneStart { get; set; }
        public string probOrbits { get; set; }
        public string minOrbits { get; set; }
        public string maxOrbits { get; set; }
        public string coronaMin { get; set; }
        public string coronaMult { get; set; }
        public string coronaVar { get; set; }
        public string solarWind { get; set; }
        public string minFlare { get; set; }
        public string maxFlare { get; set; }
        public string crLossMult { get; set; }
        public string lightColorMin { get; set; }
        public string lightColorMax { get; set; }

    }
}