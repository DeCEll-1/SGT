using CsvHelper;
using SSSystemGenerator.Classes.CSVClasses;
using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class CSVHelper
    {

        public static CSVs GetAllCSVs()
        {
            CSVs csv = new CSVs();

            string coreCampaignFolderPath = Paths.GameCoreCampaignFolder.FullName;

            csv.Industries.AddRange(GetIndrustryListFromPath(coreCampaignFolderPath + @"\" + Finals.INDUSTRIES_FILE_NAME));

            csv.Submarkets.AddRange(GetSubmarketsListFromPath(coreCampaignFolderPath + @"\" + Finals.SUBMARKETS_FILE_NAME));

            csv.MarketConditions.AddRange(GetMarketConditionsListFromPath(coreCampaignFolderPath + @"\" + Finals.MARKET_CONDITIONS_FILE_NAME));

            csv.PlanetGenDatas.AddRange(GetPlanetGenDataListFromPath(coreCampaignFolderPath + @"\" + Finals.PROCGEN_FOLDER_NAME + @"\" + Finals.PLANET_GEN_DATA_FILE_NAME));

            foreach (DirectoryInfo modDirectory in SettingsController.ModsToLoad)
            {

                string modPath = modDirectory.FullName;
                int len = modPath.Split('\\').Length;

                if (File.Exists(modPath + @"\data\campaign\" + Finals.INDUSTRIES_FILE_NAME))
                {
                    csv.Industries.AddRange(
                        GetIndrustryListFromPath(
                            modPath + @"\data\campaign\" + Finals.INDUSTRIES_FILE_NAME
                        )
                    );
                }

                if (File.Exists(modPath + @"\data\campaign\" + Finals.SUBMARKETS_FILE_NAME))
                {
                    csv.Submarkets.AddRange(
                        GetSubmarketsListFromPath(
                            modPath + @"\data\campaign\" + Finals.SUBMARKETS_FILE_NAME
                        )
                    );
                }

                if (File.Exists(modPath + @"\data\campaign\" + Finals.MARKET_CONDITIONS_FILE_NAME))
                {
                    csv.MarketConditions.AddRange(
                        GetMarketConditionsListFromPath(
                            modPath + @"\data\campaign\" + Finals.MARKET_CONDITIONS_FILE_NAME
                        )
                    );
                }

                if (File.Exists(modPath + @"\data\campaign\" + Finals.PROCGEN_FOLDER_NAME + @"\" + Finals.PLANET_GEN_DATA_FILE_NAME))
                {
                    csv.PlanetGenDatas.AddRange(
                        GetPlanetGenDataListFromPath(
                            modPath + @"\" + Finals.PROCGEN_FOLDER_NAME + @"\" + Finals.PLANET_GEN_DATA_FILE_NAME
                        )
                    );
                }

            }

            return csv;
        }


        #region Industries

        /// <summary>
        /// get industry csv
        /// </summary>
        /// <param name="path"></param>
        /// <returns>null if not found anything</returns>
        public static List<IndustriesCSV> GetIndrustryListFromPath(string path)
        {
            List<IndustriesCSV> records = null;

            //https://joshclose.github.io/CsvHelper/getting-started/#reading-a-csv-file

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<IndustriesCSV>().ToList();
            }

            string modName = path.Split('\\')[path.Split('\\').Length - 4];
            records.ForEach(record =>
            {
                record.owner = modName;
            });

            List<IndustriesCSV> stuffToDelete = new List<IndustriesCSV>();

            foreach (IndustriesCSV industry in records)
            {

                if (industry.id == "" || industry.id == null || industry.id.Contains("#"))
                {
                    stuffToDelete.Add(industry);
                    continue;
                }

            }

            foreach (IndustriesCSV industryToDelete in stuffToDelete) { records.Remove(industryToDelete); }

            return records;

        }

        #endregion

        #region Submarkets

        /// <summary>
        /// get submarkets csv
        /// </summary>
        /// <param name="path"></param>
        /// <returns>null if not found anything</returns>
        public static List<SubmarketsCSV> GetSubmarketsListFromPath(string path)
        {

            List<SubmarketsCSV> records = null;

            //https://joshclose.github.io/CsvHelper/getting-started/#reading-a-csv-file

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<SubmarketsCSV>().ToList();
            }

            string modName = path.Split('\\')[path.Split('\\').Length - 4];
            records.ForEach(record =>
            {
                record.owner = modName;
            });

            List<SubmarketsCSV> stuffToDelete = new List<SubmarketsCSV>();

            foreach (SubmarketsCSV submarket in records)
            {
                if (submarket.id == "" || submarket.id == null || submarket.id.Contains("#"))
                {
                    stuffToDelete.Add(submarket);
                    continue;
                }
            }

            foreach (SubmarketsCSV submarketToDelete in stuffToDelete) { records.Remove(submarketToDelete); }

            return records;

        }
        #endregion

        #region MarketConditions

        /// <summary>
        /// get market conditions csv
        /// </summary>
        /// <param name="path"></param>
        /// <returns>null if not found anything</returns>
        public static List<MarketConditionsCSV> GetMarketConditionsListFromPath(string path)
        {

            List<MarketConditionsCSV> records = null;

            //https://joshclose.github.io/CsvHelper/getting-started/#reading-a-csv-file

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<MarketConditionsCSV>().ToList();
            }

            string modName = path.Split('\\')[path.Split('\\').Length - 4];
            records.ForEach(record =>
            {
                record.owner = modName;
            });

            List<MarketConditionsCSV> stuffToDelete = new List<MarketConditionsCSV>();

            foreach (MarketConditionsCSV conditions in records)
            {
                if (conditions.id == "" || conditions.id == null || conditions.id.Contains("#"))
                {
                    stuffToDelete.Add(conditions);
                    continue;
                }
            }

            foreach (MarketConditionsCSV conditionToRemove in stuffToDelete) { records.Remove(conditionToRemove); }

            return records;

        }

        #endregion

        #region MarketConditions

        /// <summary>
        /// get market conditions csv
        /// </summary>
        /// <param name="path"></param>
        /// <returns>null if not found anything</returns>
        public static List<PlanetGenData> GetPlanetGenDataListFromPath(string path)
        {

            List<PlanetGenData> records = null;

            //https://joshclose.github.io/CsvHelper/getting-started/#reading-a-csv-file

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<PlanetGenData>().ToList();
            }

            string modName = path.Split('\\')[path.Split('\\').Length - 5];
            records.ForEach(record =>
            {
                record.owner = modName;
            });

            List<PlanetGenData> stuffToDelete = new List<PlanetGenData>();

            foreach (PlanetGenData genData in records)
            {
                if (genData.type == "" || genData.id.Contains("#"))
                {
                    stuffToDelete.Add(genData);
                    continue;
                }
            }

            foreach (PlanetGenData genDataToDelete in stuffToDelete) { records.Remove(genDataToDelete); }

            return records;

        }

        #endregion
    }
}
