using IcecreamForGarden.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace IcecreamForGarden
{
    public partial class frmBoard : Form
    {
        /// <summary>
        /// Data storage - list of maps
        /// </summary>
        public List<MapItem> MapList { get; set; }

        /// <summary>
        /// Sign that current map needs to be stopped
        /// </summary>
        public bool StopMapItem { get; set; }

        /// <summary>
        /// Decreasing pause between clicks
        /// </summary>
        public int DecreaseTimeout { get; set; } = 70;

        public frmBoard()
        {
            InitializeComponent();
        }

        protected void btnReadFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.InitialDirectory = Path.Combine(Application.StartupPath, "map");
                openDialog.FileName = "map-list.json";
                openDialog.Filter = "JSON text (*.json)|*.json|All files (*.*)|*.*";
                //openDialog.FilterIndex = 2;
                openDialog.RestoreDirectory = true;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    this.ReadMapListFromFile(openDialog.FileName);
                }
            }
        }

        protected void ReadMapListFromFile(string filePath)
        {
            this.MapList = null;
            StreamReader reader = null;
            lbMapList.DataSource = null;
            try
            {
                using (reader = new StreamReader(filePath))
                {
                    var jsonText = reader.ReadToEnd();
                    this.MapList = JsonSerializer.Deserialize<List<MapItem>>(jsonText);
                    lbMapList.DataSource = this.MapList;
                }
                //MessageBox.Show(this, $"Number of entries: {this.MapList.Count}", "Read from file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                reader?.Close();
                Debug.WriteLine($"Error: <[{ex.Message}]>");
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected void btnRunMapItem_Click(object sender, EventArgs e)
        {
            if (lbMapList.SelectedItem == null)
            {
                return;
            }
            var points = (lbMapList.SelectedItem as MapItem).points;
            var len = points.Count;
            this.StopMapItem = false;

            for (var index = 0; index < len; index++)
            {
                if (this.StopMapItem)
                {
                    break;
                }
                var thisPoint = points[index];
                var timeout = (thisPoint.timeBefore > this.DecreaseTimeout) ? (this.DecreaseTimeout) : 0;
                Thread.Sleep(thisPoint.timeBefore - timeout);
                //MouseInput.MoveMouse(thisPoint.screenX, thisPoint.screenY);
                MouseInput.LeftClick(thisPoint.screenX, thisPoint.screenY);
                lbRunMapItem.Text = $"{index + 1} / {len}";
            }
        }

        protected void frmBoard_KeyPress(object sender, KeyPressEventArgs ev)
        {
            if (ev.KeyChar == 's')
            {
                this.StopMapItem = true;
            }
        }

        protected void lbMapList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (sender as ListBox);
            if (listBox.SelectedItem == null)
            {
                return;
            }
            var len = (lbMapList.SelectedItem as MapItem).points.Count;
            lbRunMapItem.Text = $"0 / {len}";
        }
    }
}
