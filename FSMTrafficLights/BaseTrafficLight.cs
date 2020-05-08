using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FSMTrafficLights
{
    public abstract class BaseTrafficLight:BaseLight,IStateMachine
    {
        private System.Windows.Forms.Timer Timer =null;
        
        /// <summary>On時的顏色</summary>
        protected Color ColorLightOn { get; set; }
        /// <summary>下個亮的燈</summary>
        protected BaseTrafficLight NextOnLight { get; set; }
        /// <summary>Off時的顏色 </summary>
        protected Color ColorLightOff { get; set; }
        /// <summary>是否亮登 </summary>
        public bool IsLight { get; set; }
        /// <summary>亮燈的時間(秒)</summary>
        protected int DurationSeconds { get; set; }
        private int Count = 0;

        /// <summary>Turn On</summary>
        public override void TurnOn()
        {
            this.BackColor = this.ColorLightOn;
            this.IsLight = true;
            Count = 0;
            if (Timer == null)
            {
                Timer = new System.Windows.Forms.Timer();
                Timer.Interval = 1000;
                Timer.Tick += this.TimerTick;
            }
            Timer.Start();
        }
        public void TimerTick(object sender, EventArgs e)
        {
            var timer = ((System.Windows.Forms.Timer)sender);
            timer.Stop();
            Count++;
            if(Count >= DurationSeconds)
            {
                this.Exit();
            }
            else
            {
                timer.Start();
            }
        }
        public override void TurnOff()
        {
            this.BackColor = this.ColorLightOff;
            this.IsLight = false;
        }
        private BaseTrafficLight() : base()
        {
            
            this.IsLight = false;
          

        }
        /// <summary></summary>
        /// <param name="nextOnLight">下個 On 的燈/param>
        /// <param name="colorLightOn">on 時的顏色</param>
        /// <param name="durationSeconds">On 的時間</param>
        public BaseTrafficLight(BaseTrafficLight nextOnLight,Color colorLightOn,int durationSeconds) : this()
        {
            NextOnLight = nextOnLight;
            ColorLightOn = colorLightOn;
            ColorLightOff = Color.Gray;
            DurationSeconds = durationSeconds;
        }
        public BaseTrafficLight(BaseTrafficLight nextOnLight, Color colorLightOn,Color colorLightOff,int durationSeconds) :this(nextOnLight, colorLightOn, durationSeconds)
        {
            ColorLightOff = colorLightOff;
        }
        public virtual void Entry()
        {
            this.TurnOn();
        }
        public virtual void Exit()
        {
            this.TurnOff();
            NextOnLight.Entry();
        }
        public virtual void Input()
        {

        }
        public virtual void Transfer()
        {

        }
    }
}
