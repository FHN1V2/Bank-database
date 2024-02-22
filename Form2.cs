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
using static Database.Form1;
using Newtonsoft.Json.Linq;

namespace Database
{
    public partial class Form2 : Form
    {
        //public Form2(DataTransferObject data)
        //{
        //    InitializeComponent();
        //    this.data = data;
        //}

        //private DataTransferObject data;
        private readonly DataTransferObject data;
        private readonly Form1 form1;

        public Form2(DataTransferObject data, Form1 form1)
        {
            InitializeComponent();
            this.data = data;
            this.form1 = form1;
        }



        private void buttonSaveChange_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\vil20\\OneDrive\\Рабочий стол\\curse\\Database\\bin\\Debug\\db.json";

            // Read existing JSON from file
            string json = File.ReadAllText(filePath);

            // Parse the JSON string into a JObject
            JObject jsonObject = JObject.Parse(json);

            // Check if the ID exists in the JSON
            if (jsonObject[data.Data] != null)
            {
                // Update the "Name" field of the record with the specified ID
                jsonObject[data.Data]["Name"] = textBoxFIO.Text;

                // Serialize the JObject back to a JSON string
                string updatedJson = jsonObject.ToString();

                // Write the updated JSON back to the file
                File.WriteAllText(filePath, updatedJson);

                MessageBox.Show(
                    "Имя успешно обновлено",
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

            form1.LoadData();
            this.Close();
        }

        private void buttonCancleChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
