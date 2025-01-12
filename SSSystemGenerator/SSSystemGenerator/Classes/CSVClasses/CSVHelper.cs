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

            foreach (DirectoryInfo modDirectory in SettingsController.ModsToLoad)
            {

                string modPath = modDirectory.FullName;
                int len = modPath.Split('\\').Length;

                if (File.Exists(modPath + @"\data\campaign\" + Finals.INDUSTRIES_FILE_NAME))
                    csv.Industries.AddRange(
                        GetIndrustryListFromPath(modPath + @"\data\campaign\" + Finals.INDUSTRIES_FILE_NAME))
                        ;

                if (File.Exists(modPath + @"\data\campaign\" + Finals.SUBMARKETS_FILE_NAME))
                    csv.Submarkets.AddRange(GetSubmarketsListFromPath(modPath + @"\data\campaign\" + Finals.SUBMARKETS_FILE_NAME));

                if (File.Exists(modPath + @"\data\campaign\" + Finals.MARKET_CONDITIONS_FILE_NAME))
                    csv.MarketConditions.AddRange(GetMarketConditionsListFromPath(modPath + @"\data\campaign\" + Finals.MARKET_CONDITIONS_FILE_NAME));


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

        /// <summary>
        /// returns industries list as 'id + " - " + name'
        /// </summary>
        /// <param name="marketConditionsList"></param>
        /// <returns></returns>
        public static List<string> İndustriesListToStringIDNameList(List<IndustriesCSV> industriesList)
        {
            List<string> stringListToReturn = new List<string>();

            foreach (IndustriesCSV industries in industriesList)
            {
                stringListToReturn.Add(industries.id + " - " + industries.name);
            }

            return stringListToReturn;
        }

        /// <summary>       
        /// /// doesnt add the things market contains
        /// </summary>
        /// <param name="marketConditionsList"></param>
        /// <returns>list of the things market doesnt have</returns>
        public static List<string> İndustriesListToStringIDNameListExcludingMarketItems(List<IndustriesCSV> industriesList, MarketData market)
        {
            List<string> stringListToReturn = new List<string>();

            foreach (IndustriesCSV industries in industriesList)
            {

                if (market.industries.Contains(industries.id))
                {
                    continue;
                }

                stringListToReturn.Add(industries.id + " - " + industries.name);
            }

            return stringListToReturn;
        }

        /// <summary>
        /// so i need a list that doesnt have the things a market haves so thiss for this
        /// </summary>
        /// <param name="marketConditionsList"></param>
        /// <returns></returns>
        public static List<string> IndustriesListToStringIDNameList(List<IndustriesCSV> industriesList, MarketData market)
        {
            List<string> stringListToReturn = new List<string>();

            stringListToReturn.Add("Added Items:");

            stringListToReturn.Add("Not Added:");

            foreach (IndustriesCSV industry in industriesList)
            {

                if (market.industries.Contains(industry.id))
                {
                    int indexToInsertTo = stringListToReturn.IndexOf("Added Items:") + 1;//+1 because its suppose to be added after this

                    stringListToReturn.Insert(indexToInsertTo, industry.id + " - " + industry.name);
                }
                else
                {
                    int indexToInsertTo = stringListToReturn.IndexOf("Not Added:") + 1;//+1 because its suppose to be added after this

                    stringListToReturn.Insert(indexToInsertTo, industry.id + " - " + industry.name);
                }

            }

            return stringListToReturn;
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

        /// <summary>
        /// returns submarkets list as 'id + " - " + name'
        /// </summary>
        /// <param name="marketConditionsList"></param>
        /// <returns></returns>
        public static List<string> SubmarketsListToStringIDNaneList(List<SubmarketsCSV> submarkets)
        {
            List<string> stringListToReturn = new List<string>();

            foreach (SubmarketsCSV submarket in submarkets)
            {
                stringListToReturn.Add(submarket.id + " - " + submarket.name);
            }

            return stringListToReturn;
        }

        /// <summary>
        /// doesnt add the things market contains
        /// </summary>
        /// <param name="marketConditionsList"></param>
        /// <returns></returns>
        public static List<string> SubmarketsListToStringIDNaneListExcludingMarketItems(List<SubmarketsCSV> submarkets, MarketData market)
        {
            List<string> stringListToReturn = new List<string>();

            foreach (SubmarketsCSV submarket in submarkets)
            {

                if (market.submarkets.Contains(submarket.id))
                {
                    continue;
                }
                else
                {
                    stringListToReturn.Add(submarket.id + " - " + submarket.name);
                }

            }

            return stringListToReturn;
        }

        /// <summary>
        /// so i need a list that doesnt have the things a market haves so thiss for this
        /// </summary>
        /// <param name="marketConditionsList"></param>
        /// <returns></returns>
        public static List<string> SubmarketsListToStringIDNaneList(List<SubmarketsCSV> submarkets, MarketData market)
        {
            List<string> stringListToReturn = new List<string>();

            stringListToReturn.Add("Added Items:");

            stringListToReturn.Add("Not Added:");

            foreach (SubmarketsCSV submarket in submarkets)
            {

                if (market.submarkets.Contains(submarket.id))
                {
                    int indexToInsertTo = stringListToReturn.IndexOf("Added Items:") + 1;//+1 because its suppose to be added after this

                    stringListToReturn.Insert(indexToInsertTo, submarket.id + " - " + submarket.name);
                }
                else
                {
                    int indexToInsertTo = stringListToReturn.IndexOf("Not Added:") + 1;//+1 because its suppose to be added after this

                    stringListToReturn.Insert(indexToInsertTo, submarket.id + " - " + submarket.name);
                }

            }

            return stringListToReturn;
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

        /// <summary>
        /// returns condition list as 'id + " - " + name'
        /// </summary>
        /// <param name="marketConditionsList"></param>
        /// <returns></returns>
        public static List<string> MarketConditionsListToStringIDNameList(List<MarketConditionsCSV> marketConditionsList)
        {
            List<string> listToReturn = new List<string>();

            foreach (MarketConditionsCSV condition in marketConditionsList)
            {

                listToReturn.Add(condition.id + " - " + condition.name);

            }

            return listToReturn;

        }

        /// <summary>
        /// doesnt add the things market contains
        /// </summary>
        /// <param name="marketConditionsList"></param>
        /// <returns></returns>
        public static List<string> MarketConditionsListToStringIDNameListExcludingMarketItems(List<MarketConditionsCSV> marketConditionsList, MarketData market)
        {
            List<string> listToReturn = new List<string>();

            foreach (MarketConditionsCSV condition in marketConditionsList)
            {
                if (market.marketConditions.Contains(condition.id))
                {
                    continue;
                }
                else
                {
                    listToReturn.Add(condition.id + " - " + condition.name);
                }


            }

            return listToReturn;

        }

        /// <summary>
        /// so i need a list that doesnt have the things a market haves so thiss for this
        /// </summary>
        /// <param name="marketConditionsList"></param>
        /// <returns></returns>
        public static List<string> MarketConditionsListToStringIDNameList(List<MarketConditionsCSV> marketConditionsList, MarketData market)
        {
            List<string> stringListToReturn = new List<string>();

            stringListToReturn.Add("Added Items:");

            stringListToReturn.Add("Not Added:");

            foreach (MarketConditionsCSV condition in marketConditionsList)
            {

                if (market.marketConditions.Contains(condition.id))
                {
                    int indexToInsertTo = stringListToReturn.IndexOf("Added Items:") + 1;//+1 because its suppose to be added after this

                    stringListToReturn.Insert(indexToInsertTo, condition.id + " - " + condition.name);
                }
                else
                {
                    int indexToInsertTo = stringListToReturn.IndexOf("Not Added:") + 1;//+1 because its suppose to be added after this

                    stringListToReturn.Insert(indexToInsertTo, condition.id + " - " + condition.name);
                }

            }

            return stringListToReturn;
        }

        #endregion
    }
}
