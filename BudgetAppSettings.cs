using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Budget_App_Project
{
    public class BudgetAppSettings
    {
        public List<string> CategoryList { get; set; } 
        public string UserFolderPath { get; set; } //where user wants template and alltransacs files

        public BudgetAppSettings() 
        { 
            CategoryList = new List<string>
        { "Paycheck", "Investment Returns", "Gift",
        "Credit Card", "Entertainment", "Insurance", "Loan", "Rent", "Tax", "Utilities",
        "Other"};
            //UserFolderPath = @"d:"; 
            //UserFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            UserFolderPath = string.Empty;
        }
    }
    public static class AppSettingsManager
    {
        public static BudgetAppSettings UserSettings { get; set; } = new();
        public static string fileName = "BudgetAppSettings.json";
        //public static string filePath = Path.Combine(UserSettings.UserFolderPath, fileName);
                
        public static void AskUserForSavePath()
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = "Choose save folder for this apps budgeting data"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                UserSettings.UserFolderPath = dialog.SelectedPath;                
            }            
        }
        public static void SaveAppSettings(BudgetAppSettings settings)
        {
            string settingsFileFolder = Path.Combine(
                   Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                   "MyBudgetApp");
            string filePath = Path.Combine(settingsFileFolder, fileName);
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            File.WriteAllText(filePath, JsonSerializer.Serialize(settings, options));
        }
        public static void LoadAppSettings() //This only happens once when app opened
        {
            string settingsFileFolder = Path.Combine(
                   Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                   "MyBudgetApp");

            if (!Directory.Exists(settingsFileFolder))
            {
                Directory.CreateDirectory(settingsFileFolder);
            }
            
            string filePath = Path.Combine(settingsFileFolder, fileName);
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var loaded = JsonSerializer.Deserialize<BudgetAppSettings>(json);
                UserSettings = loaded ?? new BudgetAppSettings();
            }
            else
            {
                UserSettings = new BudgetAppSettings(); //return the default values settings
                AskUserForSavePath();
                SaveAppSettings(UserSettings);
            }
        }
    }
}
