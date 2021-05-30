using GetWell.Properties;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetWell
{
    public partial class Localisation_Form : Form
    {
        public Localisation_Form()
        {
            InitializeComponent();
        }

        ///////////////////////////////check connection state///////////////////////
        public bool IsConnectedToInternet()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
        //////////////////////////////////////////////////////
        

        ////////////////////////code to move the form using the mouse/////////////////////////////
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Panel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////


        bool choose = false;
        Bitmap markerIcon = (Bitmap)Image.FromFile("img/MapMarker.png");
        double lat;
        double longt;
        private void Localisation_Form_Load(object sender, EventArgs e)
        {
            MapLoad();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mapZoomIn_Click(object sender, EventArgs e)
        {
            if (map.Zoom < map.MaxZoom)
                map.Zoom++;
        }

        private void btn_mapZoomOut_Click(object sender, EventArgs e)
        {
            if (map.Zoom > map.MinZoom)
                map.Zoom--;
        }

        private void btn_MapNav_Click(object sender, EventArgs e)
        {
            if (map.CanDragMap == false)
            {
                map.CanDragMap = true;
                btn_MapNav.FillColor = Color.Orange;
                btn_MapPoint.FillColor = Color.Transparent;
                choose = false;
                map.Cursor = Cursors.SizeAll;
            }
        }

        private void btn_MapPoint_Click(object sender, EventArgs e)
        {
            choose = true;
            map.CanDragMap = false;
            btn_MapNav.FillColor = Color.Transparent;
            btn_MapPoint.FillColor = Color.Orange;
            map.Cursor = Cursors.Cross;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void map_Click(object sender, EventArgs e)
        {
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult confirm;
            if (choose)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    double lat = map.FromLocalToLatLng(e.X, e.Y).Lat;
                    double lng = map.FromLocalToLatLng(e.X, e.Y).Lng;
                    LocalisationData.lat = lat;
                    LocalisationData.lng = lng;

                    var cnfForm = new ConfirmLocalusation_Form();
                    confirm = cnfForm.ShowDialog();

                    if (confirm == DialogResult.OK)
                    {
                        map.Position = new GMap.NET.PointLatLng(lat, lng);
                        PointLatLng point = new PointLatLng(lat, lng);
                        map.Overlays.Clear();
                        GMapMarker marker = new GMarkerGoogle(point, markerIcon);
                        GMapOverlay markers = new GMapOverlay("markers");
                        markers.Markers.Add(marker);
                        map.Overlays.Add(markers);
                        MedecinController.UpdateLocal(Medecin.Id_doc, lat, lng);
                        OperationDone_Form op = new OperationDone_Form();
                        op.ShowDialog(); 
                    }

                }

            }
        }

        private void btn_MyLocation_Click(object sender, EventArgs e)
        {
            map.Position = new GMap.NET.PointLatLng(lat, longt);
        }

        private void MapLoad()
        {
            if (IsConnectedToInternet() == true)
            {
                panel_error.Visible = false;
                lat = Medecin.latitude;//31.628257577053745, -8.057650526354239
                longt = Medecin.longitude;
                map.MapProvider = GMapProviders.GoogleMap;
                map.MinZoom = 2;
                map.MaxZoom = 100;
                map.Zoom = 20;
                map.CanDragMap = false;
                map.DragButton = MouseButtons.Left;
                map.Position = new GMap.NET.PointLatLng(lat, longt);
                map.ShowCenter = false;
                PointLatLng point = new PointLatLng(lat, longt);

                GMapMarker marker = new GMarkerGoogle(point, markerIcon);
                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);

                buttons_panel.Visible = true;
                map.Visible = true;
                panel_error.Visible = false;
            }
            else
            {
                buttons_panel.Visible = false;
                map.Visible = false;
                panel_error.Visible = true;
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            MapLoad(); 
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {

        }

        private void Localisation_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void map_Load(object sender, EventArgs e)
        {

        }
    }
}
