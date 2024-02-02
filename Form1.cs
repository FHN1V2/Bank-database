using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string filePath = "C:\\Users\\vil20\\OneDrive\\Рабочий стол\\curse\\Database\\bin\\Debug\\db.json";// переписать на чтение с ведённого пути
           
            // Чтение строк из файла
            string[] lines = File.ReadAllLines(filePath);
            // Обработка каждой строки
            foreach (string line in lines)
            {
                // Разделение строки по символу '|'
                string[] parts = line.Split('|');

                // Извлечение данных
                string id = parts[0].Trim();
                string name = parts[1].Trim();
                string birthDate = parts[2].Trim();
                string expiryDate = parts[3].Trim();
                int amount = int.Parse(parts[4].Trim());

                // Добавление данных в таблицу
                ShowDate.Rows.Add(id, name, birthDate, expiryDate, amount);
            }

        }
        static void RemoveEmptyLines(string filePath)
        {
            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(filePath);

            // Создаем новый список строк, исключая пустые строки
            var newLines = lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToList();

            // Записываем новые строки обратно в файл
            File.WriteAllLines(filePath, newLines);
        }

        private void ShowDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAddData_Click(object sender, EventArgs e)
        {
            string[] Data = { textBoxID.Text, textBoxName.Text, textBoxOpen.Text, textBoxClose.Text, textBoxStartDep.Text };//дописать проверку условий валидности данных
            ShowDate.Rows.Add(Data);//Data[0], Data[1], Data[2], Data[3], Data[4]
            WriteDataToJson(Data);
        }
        private void WriteDataToJson(string[] data)
        {
            string filePath = "C:\\Users\\vil20\\OneDrive\\Рабочий стол\\curse\\Database\\bin\\Debug\\db.json";

            string jsonRecord =  data[0] + " | " + data[1] + " | " + data[2] + " | " + data[3] + " | " + data[4] + " | ";

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("");
                sw.WriteLine(jsonRecord);
            }
            RemoveEmptyLines(filePath);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\vil20\\OneDrive\\Рабочий стол\\curse\\Database\\bin\\Debug\\db.json";
            int index = RemoveLineWithElement(filePath,textBoxForDel.Text);
            ShowDate.Rows.RemoveAt(index);
            ShowDate.Refresh();
            
        }

        static int RemoveLineWithElement(string filePath, string elementToDelete)
        {
            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(filePath);
            int index = Array.FindIndex(lines, line => line.Contains(elementToDelete));
            // Создаем новый список строк, исключая те, которые содержат элемент для удаления
            var newLines = new System.Collections.Generic.List<string>();
            foreach (string line in lines)
            {
                if (!line.Contains(elementToDelete))
                {
                    newLines.Add(line);
                }
            }

            // Записываем новые строки обратно в файл
            File.WriteAllLines(filePath, newLines);
            return index;
        }

        private void textBoxForDel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
