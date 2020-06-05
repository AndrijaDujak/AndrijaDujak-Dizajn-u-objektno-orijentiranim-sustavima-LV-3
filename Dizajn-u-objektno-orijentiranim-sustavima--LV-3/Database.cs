using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Dizajn_u_objektno_orijentiranim_sustavima__LV_3
{
    class Database /*: ICloneable*/ //Zadatak 1
    {
        private List<List<string>> data; //list of lists of strings
        private string filePath;
        public void Dataset()
        {
            this.data = new List<List<string>>();
        }
        public void Dataset(string filePath)
        {
            this.filePath = filePath;
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }
        //zadatak 1
        /*
        public object Clone()
        {
            Database Clonecopy = (Database)this.MemberwiseClone();
            Clonecopy.LoadDataFromCSV(this.filePath);
            return Clonecopy;
        }
        */
        // Nepotrenmop je koristiti deep clone

    }
}
