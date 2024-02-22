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
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Newtonsoft.Json.Linq;


// при изменении ФИО меняется последняя запись, а не та которая нужна


namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        public class DataTransferObject
        {
            public string Data { get; set; }
        }

        private bool CheckData(string[] data)// улучить проверку
        {
            
            // Извлечение данных
            string id = data[0];
            string name = data[1];
            string birthDate = data[2];
            string expiryDate = data[3];
            string amount = data[4];
            if (id.Length!=6)
            {
                return false;
            }
            if (name ==" ")
            {
                return false;
            }
            if (birthDate==" ")
            {
                return false;
            }
            if (expiryDate == " ")
            {
                return false;
            }
            if (amount ==" ")
            {
                return false;
            }
            return true;

        }
        public void LoadData()
        {
            ShowDate.Rows.Clear();
            string filePath = "C:\\Users\\vil20\\OneDrive\\Рабочий стол\\curse\\Database\\bin\\Debug\\db.json";// переписать на чтение с ведённого пути
           
            // Чтение строк из файла
            string json = File.ReadAllText(filePath);
            var data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);
            // Обработка каждой строки
            foreach (var item in data)
            {

                // Извлечение данных
                string id = item.Key;
                string name = item.Value["Name"];
                string birthDate = item.Value["DateStart"];
                string expiryDate = item.Value["DateEnd"];
                string amount =item.Value["Value"];

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
            if (CheckData(Data))
            {
                ShowDate.Rows.Add(Data);//Data[0], Data[1], Data[2], Data[3], Data[4]
                textBoxID.Text = "";
                textBoxName.Text = "";
                textBoxOpen.Text = "";
                textBoxClose.Text = "";
                textBoxStartDep.Text = "";
                WriteDataToJson(Data);
            }
            else
            {
                MessageBox.Show(
                    "Ошибка ввода",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        private void WriteDataToJson(string[] data)
        {
            string filePath = "C:\\Users\\vil20\\OneDrive\\Рабочий стол\\curse\\Database\\bin\\Debug\\db.json";

            string jsonRecord = $"\"{data[0]}\": {{\n" +
                                $"    \"Name\": \"{data[1]}\",\n" +
                                $"    \"DateStart\": \"{data[2]}\",\n" +
                                $"    \"DateEnd\": \"{data[3]}\",\n" +
                                $"    \"Value\": \"{data[4]}\"\n" +
                                $"  }}";

            // Read existing JSON from file
            string existingJson = File.ReadAllText(filePath);

            // Remove closing brace from existing JSON
            existingJson = existingJson.TrimEnd('}', '\r', '\n');

            // Add comma if JSON is not empty
            if (!string.IsNullOrEmpty(existingJson))
            {
                existingJson += "},";
            }

            // Append new record to existing JSON
            string updatedJson = existingJson + "\n  " + jsonRecord + "\n}";

            // Write updated JSON back to file
            File.WriteAllText(filePath, updatedJson);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
                string filePath = "C:\\Users\\vil20\\OneDrive\\Рабочий стол\\curse\\Database\\bin\\Debug\\db.json";

                // Read existing JSON from file
                string json = File.ReadAllText(filePath);

                // Parse the JSON string into a JObject
                JObject jsonObject = JObject.Parse(json);

                // Check if the ID exists in the JSON
                if (jsonObject[textBoxForDel.Text] != null)
                {
                    // Remove the entry with the specified ID
                    jsonObject.Remove(textBoxForDel.Text);

                    // Serialize the JObject back to a JSON string
                    string updatedJson = jsonObject.ToString();

                    // Write the updated JSON back to the file
                    File.WriteAllText(filePath, updatedJson);

                    MessageBox.Show(
                        "Данные успешно удалены",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    MessageBox.Show(
                        "ID не найден",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            LoadData();
            //ShowDate.Refresh();
            
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

        private void buttonChangeFio_Click(object sender, EventArgs e)
        {
            DataTransferObject data = new DataTransferObject();
            data.Data = textBoxForDel.Text;

            Form2 form2 = new Form2(data,this);
            form2.Show();            
        }
    }
}
