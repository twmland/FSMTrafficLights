using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSMTrafficLights
{
    public partial class Form1 : Form
    {
        TrafficLights TrafficLightsH = null;
        TrafficLights TrafficLightsV = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TrafficLightsH = new TrafficLights();
            TrafficLightsV = new TrafficLights();
            panelGreenLightH.Controls.Add(TrafficLightsH.GreenLight);
            TrafficLightsH.GreenLight.Size = panelGreenLightH.Size;
            panelRedLightH.Controls.Add(TrafficLightsH.RedLight);
            TrafficLightsH.RedLight.Size = panelRedLightH.Size;
            panelYellowLightH.Controls.Add(TrafficLightsH.YellowLight);
            TrafficLightsH.YellowLight.Size = panelYellowLightH.Size;
            TrafficLightsH.GreenLight.Entry();

            panelGreenLightV.Controls.Add(TrafficLightsV.GreenLight);
            TrafficLightsV.GreenLight.Size = panelGreenLightV.Size;
            panelRedLightV.Controls.Add(TrafficLightsV.RedLight);
            TrafficLightsV.RedLight.Size = panelRedLightV.Size;
            panelYellowLightV.Controls.Add(TrafficLightsV.YellowLight);
            TrafficLightsV.YellowLight.Size = panelYellowLightV.Size;
            TrafficLightsV.RedLight.Entry();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }

    public class TrafficLights
    {
        public TrafficLight GreenLight = null;
        public TrafficLight RedLight = null;
        public TrafficLight YellowLight = null;
        public TrafficLights()
        {
            GreenLight = new TrafficLight(null, Color.Green, 10); 
            RedLight = new TrafficLight(GreenLight, Color.Red, 12);
            YellowLight = new TrafficLight(RedLight, Color.Yellow, 2);
            GreenLight.SetNextOnLight(YellowLight);
            GreenLight.Initial();
            RedLight.Initial();
            YellowLight.Initial();

        }
    }
}
